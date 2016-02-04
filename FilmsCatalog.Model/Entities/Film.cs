using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FilmsCatalog.Model.Entities
{
    [Serializable]
    public class Film
    {        
        public int FilmID { get ; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Year { get; set; }
        public DateTime UploadDate { get; set; } 
        public string PictureLocation { get; set; }
        public Film()
        {
            Category = "Не выбрана";
            Year = "Не задан";            
            UploadDate = DateTime.Now;
            PictureLocation = null;
        }
    }
}
