using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CronanGogarty.com.Models
{
    public interface IPortfolioItem
    {
        byte ItemID { get; set; }
        string Title { get; set; }
        string Description { get; set; }
        string mainImage { get; set; }
        string thumbnailImage { get; set; }
        string url { get; set; }
        //List<string> skillsDemonstrated { get; set; }
    }
}
