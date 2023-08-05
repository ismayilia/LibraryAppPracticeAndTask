using Domain.Models;

namespace Repository.Repositories.Interfaces
{
    public interface ILibraryRepository : IBaseRepository<Library> //spesifik libraryrepo ucun ishler goreceyik(library)
    {                                                             // Library gonderik generice metod ucun
    }
}
