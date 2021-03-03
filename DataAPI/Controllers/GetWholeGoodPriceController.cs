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
    public class GetWholeGoodPriceController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<NetPriceResult> GetWholeGoodPrice(string SKU, string PriceGrp, Decimal CustID, string IsNet)
        {
            try
            {
                using (symportalSPsContext db = new symportalSPsContext())
                {
                    IEnumerable<NetPriceResult> wholeGoodPriceInfo = db.Get_WholeGoods_PriceAsync(SKU, PriceGrp, CustID, IsNet).Result.ToList();

                    return wholeGoodPriceInfo;
                }
            }
            catch (Exception)
            {
                return (IEnumerable<NetPriceResult>)StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database.");
            }
        }
    }
}
