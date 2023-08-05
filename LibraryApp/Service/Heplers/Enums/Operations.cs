using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Heplers.Enums
{
    public enum Operations
        //crud-lar/ menyudaki ardicilliqa gore siraliyiriq/ Ne qederside duzuruk bura hamisin
    {
        CreateLibrary = 1,
        DeleteLibrary,
        EditLibrary,
        GetAllLibraries,
        GetLibraryById,
        SearchByName

    }
}
