using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace Clip_Back.Controllers
{
    public class FileUploadingController : ApiController
    {

        [HttpPost]
        [Route("api/FileUploading/UploadFile")]
        public async Task<HttpResponseMessage> UploadFile() 
        {
            var ctx = HttpContext.Current;
            var root = ctx.Server.MapPath("~/App_Data");
            var provider = new MultipartFormDataStreamProvider
                (root);
            try 
            {
                await Request.Content.ReadAsMultipartAsync(provider);
                foreach(var file in provider.FileData) 
                {
                    var name = file.Headers.ContentDisposition.FileName;

                    name = name.Trim('"');

                    var localFileName = file.LocalFileName;
                    var filePath = Path.Combine(root, name);

                    File.Move(localFileName, filePath);
                }

            }
            catch (Exception e) 
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, e);
            }

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}