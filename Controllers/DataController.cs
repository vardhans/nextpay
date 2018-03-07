using System;
using Microsoft.AspNetCore.Mvc;
using nextpay_capture.Models;

namespace hello_world
{
    [Route("api/payments")]
    public class DataController : Controller
    {
        [HttpPost]
        public IActionResult LodgePayment([FromBody]AccountDetails request){
            //TODO: Save content as file here.
            return Ok("Payment Received");
        }
    }
}