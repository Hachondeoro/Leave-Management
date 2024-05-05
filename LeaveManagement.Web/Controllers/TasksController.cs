using LeaveManagement.Web.Constants;
using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Controllers;

public class TasksController : Controller
{
    private readonly ApplicationDbContext _context;
    private readonly UserManager<Employee> _userManager;


    public TasksController(ApplicationDbContext context, UserManager<Employee> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    // GET: Tasks
    public Task<IActionResult> Index()
    {
        IQueryable<EmployeeTask> taskQuery = _context.EmployeeTasks;

        if (!User.IsInRole(Roles.Administrator))
        {
            var userId = _userManager.GetUserId(User);
            taskQuery = taskQuery.Where(task => task.AssigneeId == userId);
        }

        var tasks = taskQuery
            .Include(e => e.Assignee)
            .Include(e => e.Assigner)
            .ToList();

        return Task.FromResult<IActionResult>(View(tasks));
    }

    // GET: Tasks/Details/5
    public async Task<IActionResult> Details(int? id)
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

        var assignee = _context.Users.FirstOrDefault(u => u.Id == employeeTask.AssigneeId);
        if (assignee != null)
        {
            ViewBag.AssigneeName = assignee.Firstname + " " + assignee.Lastname;
        }

        var assigner = _context.Users.FirstOrDefault(u => u.Id == employeeTask.AssignerId);
        if (assigner != null)
        {
            ViewBag.AssignerName = assigner.Firstname + " " + assigner.Lastname;
        }


        return View(employeeTask);
    }

    // GET: Tasks/Create
    [Authorize(Roles = Roles.Administrator)]
    public IActionResult Create()
    {
        var currentUserId = _userManager.GetUserId(User);
        var model = new EmployeeTask
        {
            AssignerId = currentUserId
        };
        var employeesList = _context.Users.ToList().Select(e => new
            {
                Id = e.Id,
                Name = e.Firstname + " " + e.Lastname
            })
            .ToList();

        ViewBag.Employees = new SelectList(employeesList, "Id", "Name");

        return View(model);
    }

    // POST: Tasks/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    [Authorize(Roles = Roles.Administrator)]
    public async Task<IActionResult> Create(
        [Bind("Id,Title,Description,AssigneeId,AssignerId,StartDate,DueDate,Status")]
        EmployeeTask employeeTask)
    {
        if (ModelState.IsValid)
        {
            string currentUserId = _userManager.GetUserId(User);
            employeeTask.AssignerId = currentUserId; // setting current user id as assigner id

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

        var employeesList = _context.Users.ToList().Select(e => new
            {
                Id = e.Id,
                Name = e.Firstname + " " + e.Lastname
            })
            .ToList();

        ViewBag.Employees = new SelectList(employeesList, "Id", "Name");


        var employeeTask = await _context.EmployeeTasks.FindAsync(id);
        if (employeeTask == null)
        {
            return NotFound();
        }

        var assigner = _context.Users.FirstOrDefault(u => u.Id == employeeTask.AssignerId);
        if (assigner != null)
        {
            ViewBag.AssignerName = assigner.Firstname + " " + assigner.Lastname;
        }

        return View(employeeTask);
    }

    // POST: Tasks/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id,
        [Bind("Id,Title,Description,AssigneeId,AssignerId,StartDate,DueDate,Status")]
        EmployeeTask employeeTask)
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
    [Authorize(Roles = Roles.Administrator)]
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

        var assignee = _context.Users.FirstOrDefault(u => u.Id == employeeTask.AssigneeId);
        if (assignee != null)
        {
            ViewBag.AssigneeName = assignee.Firstname + " " + assignee.Lastname;
        }

        var assigner = _context.Users.FirstOrDefault(u => u.Id == employeeTask.AssignerId);
        if (assigner != null)
        {
            ViewBag.AssignerName = assigner.Firstname + " " + assigner.Lastname;
        }

        return View(employeeTask);
    }

    // POST: Tasks/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    [Authorize(Roles = Roles.Administrator)]
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