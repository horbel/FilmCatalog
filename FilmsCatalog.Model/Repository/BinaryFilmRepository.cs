using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using FilmsCatalog.Model.Abstract;
using FilmsCatalog.Model.Entities;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace FilmsCatalog.Model.Repository
{
    [Serializable]
    public class BinaryFilmRepository : IFilmRepository, IFilmEdit
    {
        private FilmSerializer serializer;
        private List<Film> films;

        public BinaryFilmRepository()
        {
            serializer = new FilmSerializer();

            if(!File.Exists("films.dat"))
                films = new List<Film>();
            else
            {
                films = serializer.DeserializeFilm().ToList();  
            }
        }

        public void AddFilm(Film filmParam)
        {
            films.Add(filmParam);
            films.Last().FilmID = films.Count;
        }

        public void SerializeFilm()
        {
            serializer.SerializeFilm(this.films);
        }
        public void RemoveFilm(int filmId)
        {
            films.Remove(films.Where(f => f.FilmID == filmId)
                .FirstOrDefault());         
        }

        

        public IEnumerable<Film> Films
        {
            get
            {
                return films;
            }
        }
    }
}
