using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataAPI.Models;
using static DataAPI.Models.symportalSPsContext;
using Microsoft.AspNetCore.Authorization;

namespace DataAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IsItemPartOrWholeController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<IsItemPartOrWholeResult> IsItemPartOrWhole(string SKU, string CustID)
        {
            try
            {
                using (symportalSPsContext db = new symportalSPsContext())
                {
                    IEnumerable<IsItemPartOrWholeResult> itemInfo = db.IsItemPartOrWholeAsync(SKU, CustID).Result.ToList();

                    return itemInfo;
                }
            }
            catch (Exception)
            {
                return (IEnumerable<IsItemPartOrWholeResult>)StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database.");
            }
        }

    }
}
