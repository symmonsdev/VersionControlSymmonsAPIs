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
using System.Net;

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

                    if (ordDetailInfo.Count() == 0) 
                    {
                        Response.StatusCode = 404; //Not Found
                        return ordDetailInfo;
                    }
                    else 
                    { 
                        return ordDetailInfo;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex; //Error Controller will return error status code
                //return (IEnumerable<OrderDetailResult>)StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database.");
            }
        }
    }

}
