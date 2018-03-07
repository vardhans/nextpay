using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace nextpay_capture.Models
{
    public class AccountDetails
    {
        public string BSB {get;set;}
        public string AccNo {get;set;}
        public string AccName {get;set;}
        public string PayRef {get;set;}
        public double Amount {get;set;}
    }
}