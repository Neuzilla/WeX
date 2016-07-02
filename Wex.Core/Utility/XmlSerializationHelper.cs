using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Neuzilla.Wex.Core.Utility
{
    public class XmlSerializationHelper
    {
        public static string SerializeObject(object x)
        {
            XmlSerializer xs = new XmlSerializer();
            return xs.Serialize(x);
        }

        public static T DeserializeObject<T>(IRestResponse response)
        {
            XmlDeserializer xs = new XmlDeserializer();
            return xs.Deserialize<T>(response);
        }
    }
}
