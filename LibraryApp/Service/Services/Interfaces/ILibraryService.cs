using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services.Interfaces
{
    public interface ILibraryService// spesifik library ucun yaziriq, libraryservice var ve generic repom var hemde libraryrepom var, libraryrepo gedir generic reponu ishledir, generic reponun icinde genel ish goreceyimiz metodlar var, amma libraryservice ayricadi. bu uje gedib library reponu istifade edecek, oda oz ozluyunde generic reponu istifade edir  
    {
        void Create(Library library);
        List<Library> GetAll();
        Library GetById(int id);
        List<Library> SearchByName(string name);
    }
}
