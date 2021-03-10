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
    public class OpenOrderByPOandBillToController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Open_Orders__ByShipToResult> GetOpenOrdersByPO_ByBillTo(string PONbr, DateTime fromDate, string user, int billToID)
        {
            try
            {
                using (symportalSPsContext db = new symportalSPsContext())
                {
                    IEnumerable<Open_Orders__ByShipToResult> openOrds = db.Open_Orders__ByPO_BillToAsync(PONbr, fromDate, user, billToID).Result.ToList();

                    if (openOrds.Count() == 0)
                    {
                        Response.StatusCode = 404; //Not Found
                        return openOrds;
                    }
                    else
                    {
                        return openOrds;
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
