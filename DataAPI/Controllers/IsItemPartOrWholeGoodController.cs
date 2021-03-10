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
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class IsItemPartOrWholeGoodController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<IsItemPartOrWholeResult> IsItemPartOrWhole(string SKU, string CustID)
        {
            try
            {
                using (symportalSPsContext db = new symportalSPsContext())
                {
                    IEnumerable<IsItemPartOrWholeResult> itemInfo = db.IsItemPartOrWholeAsync(SKU, CustID).Result.ToList();

                    if (itemInfo.Count() == 0)
                    {
                        Response.StatusCode = 404; //Not Found
                        return itemInfo;
                    }
                    else
                    {
                        return itemInfo;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex; //Error Controller will return error status code            
            }
        }

    }
}
