using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmsCatalog.Model.Entities;

namespace FilmsCatalog.Model.Abstract
{
    public interface IFilmEdit
    {
        void AddFilm(Film filmParam);
        void RemoveFilm(int filmId);
        void SortByTitle(bool descending);
        void SortByYear(bool descending);
        void SortByUpload(bool descending);
    }
}
