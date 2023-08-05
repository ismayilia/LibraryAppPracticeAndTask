using Domain.Models;
using Repository.Repositories.Interfaces;

namespace Repository.Repositories
{
    // get genericden miras al onun icindeki ishleri gor,icindeki library-ye gore, elave metod olsa baza ile elaqedar
    // yaz LibraryRepositorynin icerisine baza ile elaqedar 

    public class LibraryRepository : BaseRepository<Library>, ILibraryRepository //ozunkin yaziriqki,ozunkinde interfaceinde metod olsa impliment elesin, Basedeki metodlarada cata bilirik
    {
    }
}
