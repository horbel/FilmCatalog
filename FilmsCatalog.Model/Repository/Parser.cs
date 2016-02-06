using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace FilmsCatalog.Model.Repository
{
    public class Parser
    {
        public static string GetText()
        {
            var webGet = new HtmlWeb();
            var doc = webGet.Load("http://kinogo.co/1839-odin-doma-1990.html");
           
            var ourNode = doc.DocumentNode.SelectSingleNode("//img[@title='Один дома (1990)']");
            if (ourNode != null)
                return ourNode.InnerHtml;
            else
                return "nothing found";
        }


        public static void Main()
        {
           Console.WriteLine(GetText());
            

        }
    }

}
