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
    public class OrderSummaryByBillToController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<OrderSummaryResult> GetOrderSummary_BillTo(Decimal BillToID, string OrdStatus, string OrdType, DateTime? StartDate, DateTime? EndDate)
        {
            try
            {
                using (symportalSPsContext db = new symportalSPsContext())
                {
                    IEnumerable<OrderSummaryResult> custInfo = db.GetOrderSummary_BillToAsync(BillToID, OrdStatus, OrdType, StartDate, EndDate).Result.ToList();

                    return custInfo;
                }
            }
            catch (Exception ex)
            {

                return (IEnumerable<OrderSummaryResult>)StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database.");
            }
        }
    }
}
