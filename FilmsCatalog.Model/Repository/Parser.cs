using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Diagnostics;
using HtmlAgilityPack;

namespace FilmsCatalog.Model.Repository
{
    public class Parser
    {
        public static string GetText1()
        {
            var webGet = new HtmlWeb()
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8,
            };
            var doc = webGet.Load("http://kinogo.co/1839-odin-doma-1990.html");
           
            var ourNode = doc.DocumentNode.SelectSingleNode("//div[@id='news-id-1839']");

            if (ourNode != null)
                return ourNode.InnerHtml;
            else
                return "nothing found";
        }



        public static void  GetText2()
        {
            List<string> outList = new List<string>();

            string html = "https://yandex.by/search/?numdoc=10&p=0&rdrnd=601861&text=kinogo.co%20Один%20дома%201990%20&lr=157";
            HtmlDocument HD = new HtmlDocument();
            var web = new HtmlWeb
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8 //GetEncoding("windows-1251")
            };

            HD = web.Load(html);

            
            HtmlNodeCollection NoAltElements = HD.DocumentNode.SelectNodes("//div");
            
            ///допилить
            if (NoAltElements != null)
            {
                foreach(HtmlNode node in NoAltElements)
                {

                    string outputText = node.InnerHtml;
                    Console.WriteLine(outputText);
                }
            }
            else
                Console.WriteLine("found nothing");
        }
        //шаблон запроса яндекс http://yandex.ru/yandsearch?text=[KEYWORD]&p=[PAGE_NUMBER]&numdoc=[RESULTS_ON_PAGE]
        public static void Main()
        {
            //Console.WriteLine(GetText1());
            //GetText2();
            //Process.Start("http://yandex.ru/yandsearch?text=kinogo.co Один дома 1990 &p=0&numdoc=10");

            

        }
    }

}
