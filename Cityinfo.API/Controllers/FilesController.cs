using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace Cityinfo.API.Controllers
{
    [ApiController]
    [Route("api/files")]
    public class FilesController : ControllerBase
    {
        private readonly FileExtensionContentTypeProvider _fileExtensionContentTypeProvider;
        public FilesController(FileExtensionContentTypeProvider fileExtensionContentTypeProvider)
        {
            _fileExtensionContentTypeProvider = fileExtensionContentTypeProvider;
        }
        [HttpGet("{fileid}")]
        public ActionResult GetFile(string fileid)
        {
            string fileName = "Kiran Kumar Balasubramanian Appointment Letter.pdf";


            if(!System.IO.File.Exists(fileName))
            {
                return NotFound();
            }

            if(!_fileExtensionContentTypeProvider.TryGetContentType(fileName, out var contenttype))
            {
                contenttype = "application/octet-stream";
            }

            var bytes = System.IO.File.ReadAllBytes(fileName);
            return File(bytes,contenttype,Path.GetFileName( fileName));
        }
    }
}
