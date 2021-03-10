using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DataAPI.Models;
using static DataAPI.Models.symportalSPsContext;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DataAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]


    public class OpenOrdersByShipToController : ControllerBase
    {

        //[HttpGet]
        //public IEnumerable<Address_Book__GetAddressWithEmailResult> GetAddressWithEmail()
        //{
        //    using (symportalSPsContext db = new symportalSPsContext())
        //    {
        //        IEnumerable<Address_Book__GetAddressWithEmailResult> mat = (IEnumerable<Address_Book__GetAddressWithEmailResult>)db.Address_Book__GetAddressWithEmailAsync("mmartino", 69249).Result.ToList();

        //       // IEnumerable<string> mat = (IEnumerable<string>)db.Open_Orders__ByShipToAsync(69249, Convert.ToDateTime("12/26/2019"), "mmartino").Result.ToList();

        //        //foreach (var m in allMaterials.Result)
        //        //{
        //        //    Console.WriteLine($"TEST3 : {m.Code} {m.Material}");
        //        //}
        //        //return new string[] { "value1", "value2" };
        //        return mat;
        //    }
        //}

        [HttpGet]
        public IEnumerable<Open_Orders__ByShipToResult> GetOpenOrders(int shipToID, DateTime fromDate, string user)
        {
            try
            {
                using (symportalSPsContext db = new symportalSPsContext())
                {
                    //IEnumerable<Open_Orders__ByShipToResult> openOrds = db.Open_Orders__ByShipToAsync(69249, Convert.ToDateTime("12/26/2019"), "mmartino").Result.ToList();
                    IEnumerable<Open_Orders__ByShipToResult> openOrds = db.Open_Orders__ByShipToAsync(shipToID, fromDate, user).Result.ToList();

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

        // GET api/<OpenOrdersByShipToController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<OpenOrdersByShipToController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

      
    }
}
