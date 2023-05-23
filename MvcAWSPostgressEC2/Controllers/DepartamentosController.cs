using Microsoft.AspNetCore.Mvc;
using MvcAWSPostgressEC2.Models;
using MvcAWSPostgressEC2.Repositories;

namespace MvcAWSPostgressEC2.Controllers
{
    public class DepartamentosController : Controller
    {
        private RepositoryDepartamentos repo;

        public DepartamentosController(RepositoryDepartamentos repo)
        {
            this.repo = repo;
        }

        public async Task<IActionResult> Index()
        {
            return View(await this.repo.GetDepartamentosAsync());
        }

        public async Task<IActionResult> Details(int id)
        {
            return View(await this.repo.FindDepartamentoAsync(id));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Departamento departamento)
        {
            await this.repo.InsertDepartamento(departamento.IdDepartamento
                , departamento.Nombre, departamento.Localidad);
            return RedirectToAction("Index");
        }
    }
}
