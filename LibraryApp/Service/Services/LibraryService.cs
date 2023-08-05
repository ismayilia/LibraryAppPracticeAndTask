using Domain.Models;
using Repository.Repositories;
using Repository.Repositories.Interfaces;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Services
{
    public class LibraryService : ILibraryService
    {
        private readonly ILibraryRepository _libraryRepository;
        private  int _count=1; // her defe Library creat edende Id-in = edek counta, sonra countu 1 vahid artir

        public LibraryService()
        {
            _libraryRepository = new LibraryRepository();
        }


        public void Create(Library library)  //Responu istifade edirik. Bize gelen library console-dan gelecek
        {
            library.Id = _count;  
            _libraryRepository.Create(library); // Add elemeyi eleyir repo
            _count++;
        }

        public List<Library> GetAll() => _libraryRepository.GetAll(); // Bir setr olanda bele yazmaq olar
        //{
        //   return _libraryRepository.GetAll();*/ // List qaytarir, controllere apaririq foreache-e saliriq
        //}


        public Library GetById(int id)
        {
            return _libraryRepository.GetById(id);
            // Id unicdi birin geri qaytarir
        }

        public List<Library> SearchByName(string name)
        {
            return _libraryRepository.SearchByName(name);
        }


    }
}
