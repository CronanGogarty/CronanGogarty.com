using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CronanGogarty.com.Models
{
    public class PortfolioService
    {
        private readonly IList<IPortfolioItem> _items;

        public PortfolioService()
        {
            _items = new PortfolioData().Items;
        }

        public IList<IPortfolioItem> AllItems()
        {
            return _items;
        }

        public IPortfolioItem GetItem(byte ItemID)
        {
            return _items.FirstOrDefault(i => i.ItemID == ItemID);
        }
    }
}