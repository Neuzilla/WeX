using Neuzilla.Wex.Core.Apis;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core
{
    /// <summary>
    /// Api request builder based on RestSharp
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class RequestBuilder<T> where T: new()
    {
        IApi<T> _api;
        public RequestBuilder(IApi<T> api)
        {
            _api = api;
        }

        public IRestRequest GetRequest()
        {
            Method requestMethod= Method.GET;
            if (_api is IMustPost)
                requestMethod = Method.POST;
            RestRequest request = new RestRequest(_api.Url, requestMethod);

            if (_api is IJsonRequest)
            {
                IJsonRequest jsonapi = _api as IJsonRequest;
                string json = 
                      JsonConvert.SerializeObject(
                        jsonapi.JsonData,
                        new JsonSerializerSettings { ContractResolver = new CamelCasePropertyNamesContractResolver() }
                      );
                request.AddParameter("application/json", json, ParameterType.RequestBody); ;
            }
            var interfaces=_api.GetType().GetInterfaces();
            foreach(var inf in interfaces)
            {
                var props=inf.GetProperties(BindingFlags.Public|BindingFlags.Instance);
                foreach (var prop in props)
                {
                    var attrs = prop.GetCustomAttributes(true);
                    foreach (var attr in attrs)
                    {
                        if (attr is QueryStringAttribute)
                        {
                            var attr1 = attr as QueryStringAttribute;
                            var paramname = attr1.AliasName;
                            var paramvalue = prop.GetValue(_api);
                            if (paramvalue != null)
                            {
                                if (attr1.ToLowerCase)
                                    request.AddParameter(paramname, paramvalue.ToString().ToLower(), ParameterType.QueryString);
                                else
                                    request.AddParameter(paramname, paramvalue.ToString(), ParameterType.QueryString);
                            }
                            break;
                        }
                        else if(attr is FormParameterAttribute)
                        {
                            var attr1 = attr as FormParameterAttribute;
                            var paramname = attr1.AliasName;
                            var paramvalue = prop.GetValue(_api);
                            request.AddParameter(paramname, paramvalue.ToString(), ParameterType.GetOrPost);         
                        }
                    }
                }
            }

            return request;
        }
    }
}
