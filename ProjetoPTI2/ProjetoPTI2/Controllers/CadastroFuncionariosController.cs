using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoPTI2.Data;
using ProjetoPTI2.Models;

namespace ProjetoPTI2.Controllers
{
    public class CadastroFuncionariosController : Controller
    {
        private readonly ProjetoPTI2Context _context;

        public CadastroFuncionariosController(ProjetoPTI2Context context)
        {
            _context = context;
        }

        // GET: CadastroFuncionarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.CadastroFuncionario.ToListAsync());
        }

        // GET: CadastroFuncionarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadastroFuncionario = await _context.CadastroFuncionario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cadastroFuncionario == null)
            {
                return NotFound();
            }

            return View(cadastroFuncionario);
        }

        // GET: CadastroFuncionarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CadastroFuncionarios/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Matricula,Cpf,Nome,Dt_Contratacao,Email,TipoLogin,Senha")] CadastroFuncionario cadastroFuncionario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cadastroFuncionario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cadastroFuncionario);
        }

        // GET: CadastroFuncionarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadastroFuncionario = await _context.CadastroFuncionario.FindAsync(id);
            if (cadastroFuncionario == null)
            {
                return NotFound();
            }
            return View(cadastroFuncionario);
        }

        // POST: CadastroFuncionarios/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Matricula,Cpf,Nome,Dt_Contratacao,Email,TipoLogin,Senha")] CadastroFuncionario cadastroFuncionario)
        {
            if (id != cadastroFuncionario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cadastroFuncionario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CadastroFuncionarioExists(cadastroFuncionario.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(cadastroFuncionario);
        }

        // GET: CadastroFuncionarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadastroFuncionario = await _context.CadastroFuncionario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cadastroFuncionario == null)
            {
                return NotFound();
            }

            return View(cadastroFuncionario);
        }

        // POST: CadastroFuncionarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cadastroFuncionario = await _context.CadastroFuncionario.FindAsync(id);
            _context.CadastroFuncionario.Remove(cadastroFuncionario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CadastroFuncionarioExists(int id)
        {
            return _context.CadastroFuncionario.Any(e => e.Id == id);
        }
    }
}
