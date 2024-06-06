using LeaveManagement.Web.Constants;
using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Controllers;

public class ExpensesController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<Employee> _userManager;

    public ExpensesController(ApplicationDbContext context, UserManager<Employee> userManager)
    {
        _context = context;
        _userManager = userManager;
    }


    // GET: Expenses
    public Task<IActionResult> Index()
    {
        IQueryable<Expense> expenseQuery = _context.Expenses;

        if (!User.IsInRole(Roles.Administrator))
        {
            var userId = _userManager.GetUserId(User);
            expenseQuery = expenseQuery.Where(expense => expense.EmployeeId == userId);
        }

        var expenses = expenseQuery
            .Include(e => e.Employee)
            .ToList();

        return Task.FromResult<IActionResult>(View(expenses));
    }

    // GET: Expenses/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var expense = await _context.Expenses
            .Include(e => e.Employee)
            .FirstOrDefaultAsync(m => m.Id == id);

        if (expense == null)
        {
            return NotFound();
        }

        return View(expense);
    }

    // GET: Expenses/Create
    public IActionResult Create()
    {
        ViewBag.EmployeeIdDefault = "Default";
        return View();
    }

    // POST: Expenses/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(
        [Bind("Id,Title,Description,Amount,ExpenseDate,EmployeeId")]
        Expense expense)
    {
        if (ModelState.IsValid)
        {
            string currentUserId = _userManager.GetUserId(User);
            expense.Status = "Under review"; // Set status to "Under review
            expense.EmployeeId = currentUserId;

            _context.Add(expense);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        return View(expense);
    }

    // GET: Expenses/Edit/5
    [Authorize(Roles = Roles.Administrator)]
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var expense = await _context.Expenses.FindAsync(id);
        if (expense == null)
        {
            return NotFound();
        }

        return View(expense);
    }

    // POST: Expenses/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    [Authorize(Roles = Roles.Administrator)]
    public async Task<IActionResult> Edit(int id,
        [Bind("Id,Title,Description,Amount,ExpenseDate,EmployeeId, Status")]
        Expense expense)
    {
        if (id != expense.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(expense);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExpenseExists(expense.Id))
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

        return View(expense);
    }

    // GET: Expenses/Delete/5
    [Authorize(Roles = Roles.Administrator)]
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var expense = await _context.Expenses
            .FirstOrDefaultAsync(m => m.Id == id);
        if (expense == null)
        {
            return NotFound();
        }

        return View(expense);
    }

    // POST: Expenses/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    [Authorize(Roles = Roles.Administrator)]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var expense = await _context.Expenses.FindAsync(id);
        _context.Expenses.Remove(expense);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool ExpenseExists(int id)
    {
        return _context.Expenses.Any(e => e.Id == id);
    }
}