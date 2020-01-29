using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bogoodski2020backend.Models;
using bogoodski2020backend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace bogoodski2020backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RunlogController : ControllerBase
    {
        private readonly RunlogService _runlogService;

        public RunlogController(RunlogService runlogService)
        {
            _runlogService = runlogService;
        }

        [HttpGet]
        public ActionResult<List<RunRecord>> Get() =>
            _runlogService.Get();

        [HttpGet("{id:length(24)}", Name = "GetRunRecord")]
        public ActionResult<RunRecord> Get(string id)
        {
            var runRecord = _runlogService.Get(id);

            if (runRecord == null)
            {
                return NotFound();
            }

            return runRecord;
        }

        [HttpPost]
        public ActionResult<RunRecord> Create(RunRecord runRecord)
        {
            _runlogService.Create(runRecord);

            return CreatedAtRoute("GetRunRecord", new { id = runRecord.Id.ToString() }, runRecord);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, RunRecord runRecordIn)
        {
            var runRecord = _runlogService.Get(id);

            if (runRecord == null)
            {
                return NotFound();
            }

            _runlogService.Update(id, runRecordIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var runRecord = _runlogService.Get(id);

            if (runRecord == null)
            {
                return NotFound();
            }

            _runlogService.Remove(runRecord.Id);

            return NoContent();
        }
    }
}