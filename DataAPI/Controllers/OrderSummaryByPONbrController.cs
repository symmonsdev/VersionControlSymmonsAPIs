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
    public class OrderSummaryByPONbrController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<OrderSummaryResult> GetOrderSummary_PONbr(String PONbr, Decimal BillToID, string OrdStatus, string OrdType, DateTime? StartDate, DateTime? EndDate)
        {
            try
            {
                using (symportalSPsContext db = new symportalSPsContext())
                {
                    IEnumerable<OrderSummaryResult> custInfo = db.GetOrderSummary_PONbrAsync(PONbr, BillToID, OrdStatus, OrdType, StartDate, EndDate).Result.ToList();

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
