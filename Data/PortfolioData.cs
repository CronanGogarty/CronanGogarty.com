using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CronanGogarty.com.Models
{
    public class PortfolioData
    {
        public IList<IPortfolioItem> Items
        {
            get
            {
                var items = new List<IPortfolioItem>();
                items.Add(new PortfolioItem()
                {
                    ItemID = 1,
                    Position = 1, 
                    Title = "ColtPoker.com",
                    Description = "ColtPoker.com was developed in 2011 by the team at Broad Street Services. I developed the web front-end layout from PSDs, then used that layout to create a site template in Telerik Sitefinity.",
                    mainImage = "Content/Images/Portfolio/Screenshots/Colt-Poker.png",
                    thumbnailImage = "Content/Images/Portfolio/Screenshots/Thumbnails/Colt-Poker.png",
                    url = "http://cronangogarty.com/Content/Portfolio/BroadStreet/Colt-Poker/coltpoker.com/index.html",
                    skillsDemonstrated = new List<string> { "HTML", "CSS3", "Telerik Sitefinity", "Visual Studio", "C#", "JavaScript", "Adobe PhotoShop" }
                });
                items.Add(new PortfolioItem()
                {
                    ItemID = 2,
                    Position = 1, 
                    Title = "FuguPoker.com",
                    Description = "FuguPoker.com was launched in 2011 by Broad Street Services. I created a standards-compliant, cross-browser-compatible front-end layout using HTML, CSS3 and JavaScript from PSDs. I then used the layout to build a full site in Telerik Sitefinity CMS",
                    mainImage = "Content/Images/Portfolio/Screenshots/Fugu-Poker.png",
                    thumbnailImage = "Content/Images/Portfolio/Screenshots/Thumbnails/Fugu-Poker.png",
                    url = "http://cronangogarty.com/Content/Portfolio/BroadStreet/Fugu-Poker/fugupoker.com/en/Home.html",
                    skillsDemonstrated = new List<string> { "HTML", "CSS3", "Telerik Sitefinity", "Visual Studio", "C#", "JavaScript", "Adobe PhotoShop" }
                });
                items.Add(new PortfolioItem()
                {
                    ItemID = 3,
                    Position = 1, 
                    Title = "RussellFastraxx.com",
                    Description = "I built this site in 2010 as a freelance developer for a heavy machinery specialist. This site was developed from the ground up with SEO as a primary concern. I focused on keyword density to ensure that the site would rank highly on Google's search results, which resulted in the site appearing on page 1 of Google's search results within that niche. In order to ensure fresh content I provided the client with a Wordpress CMS where he could add his own content. The home page also subscribed to some relevant RSS feeds to provide fresh content daily.",
                    mainImage = "Content/Images/Portfolio/Screenshots/Russell-Fastraxx.png",
                    thumbnailImage = "Content/Images/Portfolio/Screenshots/Thumbnails/Russell-Fastraxx.png",
                    url = "http://cronangogarty.com/Content/Portfolio/RussellFastraxx/",
                    skillsDemonstrated = new List<string> { "ASP.NET Web Forms", "SEO", "Google Analytics", "HTML", "CSS", "JavaScript", "Adobe PhotoShop", "Wordpress" }
                });
                items.Add(new PortfolioItem() { 
                    ItemID = 4,
                    Position = 1, 
                    Title = "HiLife Poker",
                    Description = "Launched in 2011 HiLife Poker would be my final project with Broad Street Services. Once again I was tasked with creating a cross-browser web layout using HTML, CSS3 and JavaScript along with making some modifications to existing C# ASP.NET components. The site was built using the Sitefinity CMS using templates that I created from provided PSD files.",
                    mainImage = "Content/Images/Portfolio/Screenshots/HiLife-Poker.png",
                    thumbnailImage = "Content/Images/Portfolio/Screenshots/Thumbnails/HiLife-Poker.png",
                    url = "http://cronangogarty.com/Content/Portfolio/BroadStreet/HiLife-Poker/hilifepoker.com/index.html",
                    skillsDemonstrated = new List<string> {"HTML", "CSS3", "JavaScript", "ASP.NET", "C#", "Adobe PhotoShop", "SQL Server"}
                });
                items.Add(new PortfolioItem()
                {
                    ItemID = 5,
                    Position = 1, 
                    Title = "PensEurope.com",
                    Description = "From 2007 through 2010 I was one of 2 developers responsibe for maintaining the European and Pacific ecommerce properties of National Pen. Primarily we developed new features for the multiple websites serving 17 countries in 11 languages. In addition to the customer-facing web properties, I designed and developed a streamlined order-entry system for the telesales agents working within the organization. I am proud to say that, to this day, the \"Browse By Unit Price\" feature that I developed is still driving sales on the current live site.",
                    mainImage = "Content/Images/Portfolio/Screenshots/National-Pen.png",
                    thumbnailImage = "Content/Images/Portfolio/Screenshots/Thumbnails/National-Pen.png",
                    url = "http://www.nationalpen.co.uk/uk/valuepens.asp?search=Valuepens&headerCategory=Valuepens",
                    skillsDemonstrated = new List<string> { "Classic ASP", "SQL Server", "Stored Procedures", "HTML", "CSS", "JavaScript", "ASP.NET Web Forms", "C#" }
                });
                items.Add(new PortfolioItem()
                {
                    ItemID = 6,
                    Position = 1,
                    Title = "Beginning ASP.NET 4.5",
                    Description = "Earlier in 2016 I decided to refresh my ASP.NET Web Forms skills. I developed this site whilst following the book \"Beginning ASP.NET 4.5\" by Matthew MacDonald, published by Apress. Each page within this site has a link to it's corresponding code on my GitHub account.",
                    mainImage = "Content/Images/Portfolio/Screenshots/BeginningASP.NET4.5.png",
                    thumbnailImage = "Content/Images/Portfolio/Screenshots/Thumbnails/BeginningASP.NET4.5.png",
                    url = "http://www.cronangogarty.com/BeginningASP.NET4.5/Default.aspx",
                    skillsDemonstrated = new List<string> { "ASP.NET 4.5 Web Forms", "C#", "HTML5", "CSS3", "JavaScript", "SQL Server", "ADO.NET", "Entity Framework", "LINQ", "AJAX"}
                });
                return items;
            }
        }
    }
}
