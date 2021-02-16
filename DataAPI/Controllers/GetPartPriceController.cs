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
    public class GetPartPriceController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<NetPriceResult> GetPartPrice(string SKU, string PriceGrp, Decimal CustID)
        {
            try
            {
                using (symportalSPsContext db = new symportalSPsContext())
                {
                    IEnumerable<NetPriceResult> partsPriceInfo = db.Get_Parts_Price_CPAsync(SKU, PriceGrp, CustID).Result.ToList();

                    return partsPriceInfo;
                }
            }
            catch (Exception)
            {
                return (IEnumerable<NetPriceResult>)StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database.");
            }
        }
    }
}
