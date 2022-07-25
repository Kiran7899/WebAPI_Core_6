using Microsoft.AspNetCore.Mvc;

namespace Cityinfo.API.Controllers
{
    [ApiController]
    [Route("api/files")]
    public class FilesController : ControllerBase
    {
        [HttpGet("{fileid}")]
        public ActionResult GetFile(string fileid)
        {
            string fileName = "Kiran Kumar Balasubramanian Appointment Letter.pdf";

            if(!System.IO.File.Exists(fileName))
            {
                return NotFound();
            }

            var bytes = System.IO.File.ReadAllBytes(fileName);
            return File(bytes,"text/plain",fileName);
        }
    }
}
