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
        public int Year { get; set; }
        public DateTime? UploadDate { get; set; }
        public Film()
        {

        }

    }
}
