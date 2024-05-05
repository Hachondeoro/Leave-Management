using LeaveManagement.Web.Configurations.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Data;

public class ApplicationDbContext : IdentityDbContext<Employee>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfiguration(new RoleSeedConfiguration());
        builder.ApplyConfiguration(new UserSeedConfiguration());
        builder.ApplyConfiguration(new UserRoleSeedConfiguration());

        // For EmployeeTasks -> Employee (Assignee) relationship
        builder.Entity<EmployeeTask>()
            .HasOne(et => et.Assignee)
            .WithMany(u => u.EmployeeTasksAssigned)
            .HasForeignKey(et => et.AssigneeId)
            .OnDelete(DeleteBehavior.Restrict);

        // For EmployeeTasks -> Employee (Assigner) relationship
        builder.Entity<EmployeeTask>()
            .HasOne(et => et.Assigner)
            .WithMany(u => u.EmployeeTasksAssignedBy)
            .HasForeignKey(et => et.AssignerId)
            .OnDelete(DeleteBehavior.Restrict);

        // For Expenses -> Employee relationship
        builder.Entity<Expense>()
            .HasOne(e => e.Employee)
            .WithMany(u => u.ExpensesRecorded)
            .HasForeignKey(e => e.EmployeeId)
            .OnDelete(DeleteBehavior.Restrict);
    }

    public DbSet<LeaveType> LeaveTypes { get; set; }
    public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
    public DbSet<LeaveRequest> LeaveRequests { get; set; }
    public DbSet<EmployeeTask> EmployeeTasks { get; set; }
    public DbSet<Expense> Expenses { get; set; }
}