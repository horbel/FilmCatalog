using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using FilmsCatalog.Model.Entities;

namespace FilmsCatalog.Model.Repository
{
    public class FilmSerializer
    {
        public void SerializeFilm(IEnumerable<Film> filmsParam)
        {
            try {
                using (FileStream fs = new FileStream("films.dat", FileMode.OpenOrCreate))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fs, filmsParam);
                }
            }
            catch { throw new NotImplementedException("can not serealire"); }
        }

        public IEnumerable<Film> DeserializeFilm()
        {
            try {
                using (FileStream fs = new FileStream("films.dat", FileMode.OpenOrCreate))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    return (formatter.Deserialize(fs) as IEnumerable<Film>);
                }
            }
            catch { throw new NotImplementedException("can not deserealire"); }
        }

    }
}
