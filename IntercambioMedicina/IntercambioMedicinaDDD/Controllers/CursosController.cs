using AutoMapper;
using IntercambioMedicina.Application.Interface;
using IntercambioMedicina.Domain.Entities;
using IntercambioMedicinaDDD.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;


namespace IntercambioMedicinaDDD.Controllers
{
    public class CursosController : Controller
    {
        private readonly ICursoAppService _cursoApp;
        private readonly IAlunoAppService _alunoApp;

        public CursosController(ICursoAppService cursoApp, IAlunoAppService alunoApp)
        {
            _alunoApp = alunoApp;
            _cursoApp = cursoApp;
        }


        // GET: Alunos
        public ActionResult Index()
        {
            var cursoViewModel = Mapper.Map<IEnumerable<Curso>, IEnumerable<CursoViewModel>>(_cursoApp.GetAll());
            return View(cursoViewModel);
        }

        // GET: Alunos/Details/5
        public ActionResult Details(int id)
        {
            var curso = _cursoApp.GetById(id);
            var cursoViewModel = Mapper.Map<Curso, CursoViewModel>(curso);
            return View(cursoViewModel);
        }

        // GET: Alunos/Create
        public ActionResult Create()
        {
            ViewBag.AlunoId = new SelectList(_alunoApp.GetAll(), "AlunoId", "Nome");
            return View();
        }

        // POST: Alunos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CursoViewModel curso)
        {
            if (ModelState.IsValid)
            {
                var cursoDomain = Mapper.Map<CursoViewModel, Curso>(curso);
                _cursoApp.Add(cursoDomain);

                return RedirectToAction("Index");
            }
            ViewBag.AlunoId = new SelectList(_alunoApp.GetAll(), "AlunoId", "Nome", curso.AlunoId);
            return View(curso);
        }

        // GET: Alunos/Edit/5
        public ActionResult Edit(int id)
        {
            var curso = _cursoApp.GetById(id);
            var cursoViewModel = Mapper.Map<Curso, CursoViewModel>(curso);

            return View(cursoViewModel);
        }

        // POST: Alunos/Edit/5
        [HttpPost]
        public ActionResult Edit(CursoViewModel curso)
        {
            if (ModelState.IsValid)
            {
                var cursoDomain = Mapper.Map<CursoViewModel, Curso>(curso);
                _cursoApp.Update(cursoDomain);

                return RedirectToAction("Index");
            }
            return View(curso);
        }

        // GET: Alunos/Delete/5
        public ActionResult Delete(int id)
        {
            var curso = _cursoApp.GetById(id);
            var cursoViewModel = Mapper.Map<Curso, CursoViewModel>(curso);

            return View(cursoViewModel);
        }

        // POST: Alunos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public ActionResult DeleteConfirmed(int id)
        {
            var curso = _cursoApp.GetById(id);
            _cursoApp.Remove(curso);

            return RedirectToAction("Index");

        }

    }
}



