using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.Web.Data;

public class Expense
{
    public int Id { get; set; }
    [Display(Name = "Expense")] public string Title { get; set; }
    public string Description { get; set; }

    [Column(TypeName = "decimal(18,2)")] public decimal Amount { get; set; }
    [Display(Name = "Date")] public DateTime ExpenseDate { get; set; }
    [Display(Name = "Employee")] public string EmployeeId { get; set; }
    public virtual Employee? Employee { get; set; }
}