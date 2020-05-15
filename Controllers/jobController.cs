using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using retest.db;
using retest.models;

namespace retest.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class jobController : ControllerBase
  {
    [HttpGet]
    public ActionResult<IEnumerable<job>> Get()
    {
      {
        try
        {
          return Ok(FakeDB.Jobs);
        }
        catch (Exception e)
        {

          return BadRequest(e.Message);
        }
      }


    }

    [HttpPost]
    public ActionResult<job> Create([FromBody] job newJob)
    {
      try
      {
        FakeDB.Jobs.Add(newJob);
        return Created($"api/job/{newJob.Id}", newJob);
      }
      catch (Exception e)
      {

        return BadRequest(e.Message);
      }
    }







  }
}