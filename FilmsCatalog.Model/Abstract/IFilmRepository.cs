using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilmsCatalog.Model.Entities;


namespace FilmsCatalog.Model.Abstract
{
    public interface IFilmRepository
    {
        IEnumerable<Film> Films { get; }
    }
}
