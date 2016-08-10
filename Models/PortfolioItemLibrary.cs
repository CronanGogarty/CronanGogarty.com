using CronanGogarty.com.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CronanGogarty.com.Models
{
    public class PortfolioItemLibrary
    {
        private readonly IList<IPortfolioItem> _items;


        public PortfolioItemLibrary()
        {
            _items = new PortfolioData().Items;
        }

        public IList<IPortfolioItem> AllItems()
        {
            return _items;
        }

        //public IEnumerable<IPortfolioItem> AllBooks(LibraryBookCategory category)
        //{
        //    return _books.Where(lb => lb.Category == category);
        //}

        public IPortfolioItem Item(byte itemId)
        {
            return _items.FirstOrDefault(i => i.ItemID == itemId);
        }
    }
}
