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
    public class GetPriceGroupController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<GetPriceGroupResult> GetPriceGroup(string BranchID)
        {
            try
            {
                using (symportalSPsContext db = new symportalSPsContext())
                {
                    IEnumerable<GetPriceGroupResult> priceGrpInfo = db.GetPriceGroupAsync(BranchID).Result.ToList();

                    return priceGrpInfo;
                }
            }
            catch (Exception)
            {
                return (IEnumerable<GetPriceGroupResult>)StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database.");
            }
        }
    }
}
