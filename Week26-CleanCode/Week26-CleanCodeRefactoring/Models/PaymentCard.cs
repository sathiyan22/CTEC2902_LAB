﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Week26_CleanCodeRefactoring.Models
{
    public class PaymentCard
    {
        public int PaymentCardId { get; set; }
        public string CardNumber { get; set; }
        public string ExpiryDate { get; set; }
        public string CVV { get; set; }
    }
}