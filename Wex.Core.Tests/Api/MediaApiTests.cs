using Neuzilla.Wex.Core.Apis;
using Neuzilla.Wex.Core.Apis.Material;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Tests.Api
{
    public class MediaApiTests:ApiTestBase
    {
        [Test]
        public void TestUploadTempMediaApi()
        {
            UploadTempMediaApi api = new UploadTempMediaApi(context);
            api.Type = UploadMediaType.Image;
            api.FileName = "test.jpg";
            api.ContentType = "image/jpeg";

            api.ServerFilePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "../../test-data/images/IMG_20150427_121714.jpg");
            var response= api.Execute();
            Assert.AreEqual(UploadMediaType.Image, response.Type);
            Assert.IsTrue(response.Created_At>0);
            Assert.IsNotNull(response.Media_Id);
            Console.WriteLine(response.Media_Id);
        }

        [Test]
        public void TestUploadPermanentImageMediaApi()
        {
            IUploadPermanentImageMediaApi api = new UploadPermanentImageMediaApi(context);
            api.FileName = "test.jpg";
            api.ContentType = "image/jpeg";
            api.ServerFilePath = Path.Combine(TestContext.CurrentContext.TestDirectory, "../../test-data/images/IMG_20150427_121714.jpg");
            var response = api.Execute();
            Assert.IsNotNull(response.Url);
            Console.WriteLine(response.Url);
        }

        [Test]
        public void TestDownloadTempMediaApi()
        { 
            IDownloadTempMaterialApi api = new DownloadTempMaterialApi(context);
            api.MediaId = "Pbc_POxTs2eJgUf_ry4NG92CN-7Mj99OtBLPC7v9CQW4mxh8DVDsKTCQiWGXSjeI";
            var stream=api.Execute();
            Assert.NotNull(stream);
            Assert.IsTrue(stream.Length > 0);
        }
    }
}
