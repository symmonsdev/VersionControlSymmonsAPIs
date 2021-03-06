﻿using System;
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
    public class CustomerInfoByShipToController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Customer_InfoResult> GetCustomerInfo_ByShipTo(Decimal ShipToID)
        {
            try
            {
                using (symportalSPsContext db = new symportalSPsContext())
                {
                    IEnumerable<Customer_InfoResult> custInfo = db.GetCustomerInfo_ByShipToAsync(ShipToID).Result.ToList();

                    if (custInfo.Count() == 0)
                    {
                        Response.StatusCode = 404; //Not Found
                        return custInfo;
                    }
                    else
                    {
                        return custInfo;
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
