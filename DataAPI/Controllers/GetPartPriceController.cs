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

                    if (partsPriceInfo.Count() == 0)
                    {
                        Response.StatusCode = 404; //Not Found
                        return partsPriceInfo;
                    }
                    else
                    {
                        return partsPriceInfo;
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
