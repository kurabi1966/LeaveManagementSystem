using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Web.Models.LeaveTypes
{
    public class LeaveTypeCreateVM
    {
        [Required]
        [Length(3, 128, ErrorMessage = "Leave type name must be between 3 and 128 characters")]
        [Display(Name = "Leave Type Name")]

        public string Name { get; set; } = string.Empty;
        [Required]
        [Display(Name = "Days")]
        [Range(1, 365, ErrorMessage = "Number of days must be between 1 and 365")]
        public int NumberOfDays { get; set; }
    }

}
