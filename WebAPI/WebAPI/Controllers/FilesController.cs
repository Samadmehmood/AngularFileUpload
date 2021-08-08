using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilesController : ControllerBase
    {
       
        [HttpPost]
        
        public async Task<ActionResult> Files(List<IFormFile> files)
        {
            if (files == null || files.Count == 0)
            {
                return BadRequest("No file is uploaded.");
            }

            foreach (var certificate in files)
            {
                var filePath = "Files"; // determine the destination for file storage
                await using var stream = new FileStream(filePath, FileMode.Create);
                await certificate.CopyToAsync(stream);
            }

            return Ok();
        }
    }
}
