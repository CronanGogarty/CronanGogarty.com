using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CronanGogarty.com.Models
{
    public class PortfolioItem : IPortfolioItem
    {
        public byte ItemID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string mainImage { get; set; }
        public string thumbnailImage { get; set; }
        public string url { get; set; }
        public List<string> skillsDemonstrated { get; set; }
        public byte Position { get; set; }
    }
}