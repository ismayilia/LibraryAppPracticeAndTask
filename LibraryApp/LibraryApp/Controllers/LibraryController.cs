using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Domain.Models;
using Service.Heplers.Extentions;
using Service.Services;
using Service.Services.Interfaces;
using static System.Net.Mime.MediaTypeNames;

namespace LibraryApp.Controllers
{
    public class LibraryController
    {
        //Create yaziriq, book ucun yazsaq eyni book ucunde create, update ve s. yaziriq,
        //sonra cs-de switch-in 15-ci case-inde yaziriqki BookControllerin icindeki Create. eyni switchde ayri ayri 
        // Group ve Studend

        private readonly ILibraryService _libraryService;

        public LibraryController()
        {
            _libraryService = new LibraryService();
        }

        public void Create()
        {
            ConsoleColor.Cyan.WriteConsole("Add library name: ");
            Name:  string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name) )  // adin null ve bosh olmasin yoxla
            {
                ConsoleColor.Red.WriteConsole("Don`t be empty: ");
                goto Name;
            }

            bool isMatch = Regex.IsMatch(name, @"\d"); // Mailde- @ isharesin yoxlamaliyiq

            if (isMatch)
            {
                ConsoleColor.Red.WriteConsole("Don`t add digit for name: ");
                goto Name;
            }




            ConsoleColor.Cyan.WriteConsole("Add library seat count: ");
            SeatCount:  string seatCountStr = Console.ReadLine();

            int seatCount;

            bool isCorrectSeatCount= int.TryParse(seatCountStr, out seatCount);

            if (isCorrectSeatCount) // serviceni istifade edirik, onunda icinde creat var
            {
                Library Library = new() // Id 0 olur birinci ishleyende,int-in defaltu 0 olduguna gore gosterir 0 
                {
                    Name = name,
                    SeatCount= seatCount

                };
                _libraryService.Create(Library);
                ConsoleColor.Green.WriteConsole("Library create success");
            }
            else
            {
                ConsoleColor.Red.WriteConsole("Please add seat count format again: ");
                goto SeatCount;
            }
            // elimizde library olur adi, seatcountu, amma id 0-di heleki
        }


        public void GetAll()
        {
            var result = _libraryService.GetAll();

            foreach (var item in result)
            {
                string data = $"{item.Id} - {item.Name} - {item.SeatCount}";
                ConsoleColor.Green.WriteConsole(data);
            }
        }


        public void GetById() // bir defe yazib adin deyishib istifade ede bilerik
        {
            ConsoleColor.Cyan.WriteConsole("Add library id: ");
            Id: string idStr = Console.ReadLine();
            int id;
            bool isCorrectId = int.TryParse(idStr, out id);

            if (isCorrectId)
            {
                var result = _libraryService.GetById(id);

                if (result is null)
                {
                    ConsoleColor.Red.WriteConsole("Data not found, Write Id again: ");
                    goto Id;
                }

                string data = $"{result.Id} - {result.Name} - {result.SeatCount}";
                ConsoleColor.Green.WriteConsole(data);
            }
            else
            {
                ConsoleColor.Red.WriteConsole("Please add id format again: ");
                goto Id;
            }


        }

        public void SearchByName()
        {

            Console.WriteLine("Add text");
            string name = Console.ReadLine();

            List<Library> result = _libraryService.SearchByName(name);

            foreach (var item in result)
            {
                if (item.Name.Trim().ToLower().Contains(name.Trim().ToLower()))
                {
                    Console.WriteLine($"{item.Id} {item.Name} {item.SeatCount} ");
                }
            }
        }





    }
}
