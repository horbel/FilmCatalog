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
        private static int ID;
        public BinaryFilmRepository()
        {
            serializer = new FilmSerializer();

            if(!File.Exists("films.dat"))
            {
                films = new List<Film>();
                ID = 1;
            }
                
            else
            {
                films = serializer.DeserializeFilm().ToList();
                ID = films.Count; 
            }
        }

        public void AddFilm(Film filmParam)
        {
            filmParam.FilmID = ID++;
            films.Add(filmParam);
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

        public void RemoveAll()
        {
            films.Clear();
        }

        public void SortByTitle(bool descending)
        {
            if(descending)
                films = films.OrderByDescending(f => f.Title).ToList();
            
            else
                films = films.OrderBy(f => f.Title).ToList();
        }

        public void SortByYear(bool descending)
        {
            if (descending)
                films = films.OrderByDescending(f => f.Year).ToList();
            else
                films = films.OrderBy(f => f.Year).ToList();
        }

        public void SortByUpload(bool descending)
        {
            if(descending)
                films = films.OrderByDescending(f => f.UploadDate).ToList();
            else
                films = films.OrderBy(f => f.UploadDate).ToList();
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
