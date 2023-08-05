using LibraryApp.Controllers;
using Service.Heplers.Enums;
using Service.Heplers.Extentions;


// console baglanmasin deye, devam elesin operationlar

Menues(); // Metoda atiriq ki cox duzulmesin. sonrada cagiririq

//Menyu ile ishlemek ucundur, Library-nin adin daxil edende gedecek Controllere,switch keys eger 1-dise get
// LibraryControllerin icindeki Creat metodun ishlet, Console falan orda olacaq
// Nece dene case olsa 14 olsa 14 dene case olacaq


LibraryController library = new();

while (true)
{
   
    Operation: string operationStr  = Console.ReadLine();

    int operation;

    bool isCorrectOperation = int.TryParse(operationStr, out operation);


    if (isCorrectOperation)
    {

        switch (operation)
        {
            case (int)Operations.CreateLibrary:     // Tipleri uygun olmadigina gore casting (int)/Enum bir basa isleyir 
                library.Create();                                          
                break;
            case 2:
                Console.WriteLine("Library delete");
                break;
            case 3:
                Console.WriteLine("Library edit");
                break;
            case (int)Operations.GetAllLibraries:
                library.GetAll();
                break;
            case (int)Operations.GetLibraryById:
                library.GetById();
                break;
            case (int)Operations.SearchByName:
                library.SearchByName();
                break;
            default:
                ConsoleColor.Red.WriteConsole("Please write correct option: ");
                goto Operation;

        }
        //switch (operation)
        //{
        //    case 1:
        //        library.Create();
        //        break;
        //    case 2:
        //        Console.WriteLine("Library delete");
        //        break;
        //    case 3:
        //        Console.WriteLine("Library edit");
        //        break;
        //    case 4:
        //        library.GetAll();
        //        break;
        //    default:
        //        ConsoleColor.Red.WriteConsole("Please write correct option: ");
        //        goto Operation;

        //}

    }
    else
    {
        ConsoleColor.Red.WriteConsole("Please write correct option format: ");
        goto Operation;
    }


}

static void Menues() 
{

    // Bunlar bitenden sonra book ucun option yaziriq
    ConsoleColor.DarkBlue.WriteConsole("Choose one option for working with application : " +
    "Library operations: 1 - Create, 2 - Delete, 3 - Edit, 4 - GetAll, 5 - GetById");
}