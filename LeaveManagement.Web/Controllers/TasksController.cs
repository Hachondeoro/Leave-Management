using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeaveManagement.Web.Data;

namespace LeaveManagement.Web.Controllers;

public class TasksController : Controller
{
    private readonly ApplicationDbContext _context;

    public TasksController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: Tasks
    public async Task<IActionResult> Index()
    {
        return View(await _context.EmployeeTasks.ToListAsync());
    }

    // GET: Tasks/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {3
            return NotFound();
        }

        var employeeTask = await _context.EmployeeTasks
            .FirstOrDefaultAsync(m => m.Id == id);
        if (employeeTask == null)
        {
            return NotFound();
        }

        return View(employeeTask);
    }

    // GET: Tasks/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Tasks/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(
        [Bind("Id,Title,Description,AssigneeId,AssignerId,StartDate,DueDate,Status")] EmployeeTask employeeTask)
    {
        if (ModelState.IsValid)
        {
            _context.Add(employeeTask);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        return View(employeeTask);
    }

    // GET: Tasks/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var employeeTask = await _context.EmployeeTasks.FindAsync(id);
        if (employeeTask == null)
        {
            return NotFound();
        }

        return View(employeeTask);
    }

    // POST: Tasks/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id,
        [Bind("Id,Title,Description,AssigneeId,AssignerId,StartDate,DueDate,Status")] EmployeeTask employeeTask)
    {
        if (id != employeeTask.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(employeeTask);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeTaskExists(employeeTask.Id))
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

        return View(employeeTask);
    }

    // GET: Tasks/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var employeeTask = await _context.EmployeeTasks
            .FirstOrDefaultAsync(m => m.Id == id);
        if (employeeTask == null)
        {
            return NotFound();
        }

        return View(employeeTask);
    }

    // POST: Tasks/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var employeeTask = await _context.EmployeeTasks.FindAsync(id);
        _context.EmployeeTasks.Remove(employeeTask);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool EmployeeTaskExists(int id)
    {
        return _context.EmployeeTasks.Any(e => e.Id == id);
    }
}