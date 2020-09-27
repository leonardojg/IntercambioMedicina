using AutoMapper;
using IntercambioMedicina.Application.Interface;
using IntercambioMedicina.Domain.Entities;
using IntercambioMedicinaDDD.ViewModels;
using IntercambioMedicinaDDD.Infra.Data.Repositories;
using System.Collections.Generic;
using System.Web.Mvc;

namespace IntercambioMedicinaDDD.Controllers
{
    public class AlunosController : Controller
    {
        private readonly IAlunoAppService _alunoApp;

        public AlunosController(IAlunoAppService alunoApp)
        {
            _alunoApp = alunoApp;
        }


        // GET: Alunos
        public ActionResult Index()
        {
            var alunoViewModel = Mapper.Map<IEnumerable<Aluno>, IEnumerable<AlunoViewModel>>(_alunoApp.GetAll());
            return View(alunoViewModel);
        }

        public ActionResult Especiais()
        {
            var AlunoViewModel = Mapper.Map<IEnumerable<Aluno>, IEnumerable<AlunoViewModel>>(_alunoApp.ObterAlunosEspeciais());
            return View(AlunoViewModel);
        }

        // GET: Alunos/Details/5
        public ActionResult Details(int id)
        {
            var aluno = _alunoApp.GetById(id);
            var alunoViewModel = Mapper.Map<Aluno, AlunoViewModel>(aluno);
            return View(alunoViewModel);
        }

        // GET: Alunos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Alunos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(AlunoViewModel aluno)
        {
            if (ModelState.IsValid)
            {
                var alunoDomain = Mapper.Map<AlunoViewModel, Aluno>(aluno);
                _alunoApp.Add(alunoDomain);

                return RedirectToAction("Index");
            }
            return View(aluno);
        }

        // GET: Alunos/Edit/5
        public ActionResult Edit(int id)
        {
            var aluno = _alunoApp.GetById(id);
            var alunoViewModel = Mapper.Map<Aluno, AlunoViewModel>(aluno);

            return View(alunoViewModel);
        }

        // POST: Alunos/Edit/5
        [HttpPost]
        public ActionResult Edit(AlunoViewModel aluno)
        {
            if (ModelState.IsValid)
            {
                var alunoDomain = Mapper.Map<AlunoViewModel, Aluno>(aluno);
                _alunoApp.Update(alunoDomain);

                return RedirectToAction("Index");
            }
            return View(aluno);
        }

        // GET: Alunos/Delete/5
        public ActionResult Delete(int id)
        {
            var aluno = _alunoApp.GetById(id);
            var alunoViewModel = Mapper.Map<Aluno, AlunoViewModel>(aluno);

            return View(alunoViewModel);
        }

        // POST: Alunos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public ActionResult DeleteConfirmed(int id)
        {
            var aluno = _alunoApp.GetById(id);
            _alunoApp.Remove(aluno);

            return RedirectToAction("Index");

        }

    }
 }



