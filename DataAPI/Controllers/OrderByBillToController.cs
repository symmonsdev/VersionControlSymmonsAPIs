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
    public class OrderByBillToController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<OrderSummaryWithDetailResult> GetOrder_BillTo(Decimal BillToID, string OrdStatus, string OrdType, DateTime? StartDate, DateTime? EndDate)
        {
            try
            {
                using (symportalSPsContext db = new symportalSPsContext())
                {
                    IEnumerable<OrderSummaryWithDetailResult> ordInfo = db.GetOrder_BillToAsync(BillToID, OrdStatus, OrdType, StartDate, EndDate).Result.ToList();

                    if (ordInfo.Count() == 0)
                    {
                        Response.StatusCode = 404; //Not Found
                        return ordInfo;
                    }
                    else
                    {
                        List<OrderSummaryWithDetailResult> lst = new List<OrderSummaryWithDetailResult>();
                        lst = (List<OrderSummaryWithDetailResult>)ordInfo;

                        foreach (OrderSummaryWithDetailResult item in lst)
                        {
                            IEnumerable<OrderDetailResult> ordDetailInfo = db.GetOrderDetail_OrdNbrAsync(item.Order_Number.Value, OrdStatus).Result.ToList();
                            item.Line_Items = ordDetailInfo;
                        }


                        return ordInfo;
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
