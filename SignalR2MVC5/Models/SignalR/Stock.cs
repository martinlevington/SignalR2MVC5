using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using SignalR2MVC5.Hubs;
using SignalR2MVC5.SignalR;

namespace SignalR2MVC5.Models.SignalR
{
    public class Stock
    {



        private decimal _price;

        public string Symbol { get; set; }

        public decimal Price
        {
            get => _price;
            set
            {
                if (_price == value)
                {
                    return;
                }

                _price = value;

                if (DayOpen == 0)
                {
                    DayOpen = _price;
                }
            }
        }

        public decimal DayOpen { get; private set; }

        public decimal Change => Price - DayOpen;

        public double PercentChange => (double)Math.Round(Change / Price, 4);


    }
}