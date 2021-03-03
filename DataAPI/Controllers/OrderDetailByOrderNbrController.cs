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
    public class OrderDetailByOrderNbrController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<OrderDetailResult> GetOrderDetail_OrdNbr(Decimal OrdNbr, string OrdStatus)
        {
            try
            {
                using (symportalSPsContext db = new symportalSPsContext())
                {
                    IEnumerable<OrderDetailResult> ordDetailInfo = db.GetOrderDetail_OrdNbrAsync(OrdNbr, OrdStatus).Result.ToList();

                    return ordDetailInfo;
                }
            }
            catch (Exception ex)
            {

                return (IEnumerable<OrderDetailResult>)StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database.");
            }
        }
    }

}
