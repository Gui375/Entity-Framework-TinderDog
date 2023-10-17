using Microsoft.AspNetCore.Mvc;
using PSF.Dados.EntityFramework;
using PSF.Dominio.Entities;

namespace PSF.WebApp.Controllers
{
    public class AnimalController : Controller
    {
        private Contexto db = new Contexto();

        public IActionResult Index()
        {
            var resultado = db.Animal
                .Where(f => f.Sexo == 'O')
                .Take(10)
                .Skip(0)
                .ToList();

            var novoAnimal = new Animal
            {
                AniamlID = 2,
                Raca = "12345678911",
                Nome = "Renato",
                DataNascimento = new DateTime(2021, 5, 5),
                Sexo = 'F'
                
            };

            db.Animal.Add(novoAnimal);

            return View(resultado);
        }

        public IActionResult ConfirmarSalvamento(Animal ent)
        {
            db.Animal.Add(ent);
            return View();
        }
    }

   
}
