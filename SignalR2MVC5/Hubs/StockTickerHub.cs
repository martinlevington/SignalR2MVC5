using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using SignalR2MVC5.Models.SignalR;
using SignalR2MVC5.SignalR;

namespace SignalR2MVC5.Hubs
{
   
        [HubName("stockTickerMini")]
        public class StockTickerHub : Hub
        {
            private readonly StockTicker _stockTicker;

            public StockTickerHub() : this(StockTicker.Instance) { }

            public StockTickerHub(StockTicker stockTicker)
            {
                _stockTicker = stockTicker;
            }

            public IEnumerable<Stock> GetAllStocks()
            {
                return _stockTicker.GetAllStocks();
            }

            public string GetMarketState()
            {
                return _stockTicker.MarketState.ToString();
            }

            public void OpenMarket()
            {
                _stockTicker.OpenMarket();
            }

            public void CloseMarket()
            {
                _stockTicker.CloseMarket();
            }

            public void Reset()
            {
                _stockTicker.Reset();
            }
    }
    
}