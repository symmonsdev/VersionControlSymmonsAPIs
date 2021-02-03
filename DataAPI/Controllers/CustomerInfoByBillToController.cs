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
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerInfoByBillToController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Customer_InfoResult> GetCustomerInfo_ByBillTo(string BillToID, string StateProv)
        {
            try
            {
                using (symportalSPsContext db = new symportalSPsContext())
                {
                    IEnumerable<Customer_InfoResult> custInfo = db.GetCustomerInfo_ByBillToAsync(BillToID, StateProv).Result.ToList();

                    return custInfo;
                }
            }
            catch (Exception)
            {
                return (IEnumerable<Customer_InfoResult>)StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from database.");
            }
        }
    }
}
