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
    public class ShipmentTrackingByOrderNbrandInvoiceDtController : ControllerBase
    {

            [HttpGet]
            public IEnumerable<Shipment_TrackingResult> ShipmentTrackingByOrderNbrandInvoiceDt(int OrderNbr, String Ord_Type, DateTime Invoice_Dt)
            {
                try
                {
                    using (symportalSPsContext db = new symportalSPsContext())
                    {
                        IEnumerable<Shipment_TrackingResult> trackingInfo = db.Shipment_TrackingAsync(OrderNbr, Ord_Type, Invoice_Dt).Result.ToList();

                    if (trackingInfo.Count() == 0)
                    {
                        Response.StatusCode = 404; //Not Found
                        return trackingInfo;
                    }
                    else
                    {
                        return trackingInfo;
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
