using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


namespace LeaveManagementSystem.Web;

[PrimaryKey(nameof(Id))]
public class LeaveType
{
    public int Id { get; set; }

    [Column(TypeName = "nvarchar(128)")]
    // [Display(Name = "Type")]
    [Required(ErrorMessage = "Leave Type is required.")]
    public required string Name { get; set; }

    // [Display(Name = "Days")]
    [Required(ErrorMessage = "Number of Days is a required field.")]
    [Range(1, 365, ErrorMessage = "Number of days must be between 1 and 365.")]
    public required int NumberOfDays { get; set; }
}
