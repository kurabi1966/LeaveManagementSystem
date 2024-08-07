using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Web.Models.LeaveTypes
{
    public class LeaveTypeReadOnlyVM : BaseLeaveTypeVM
    {
        [Display(Name = "Leave Type Name")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Days")]
        public int NumberOfDays { get; set; }
    }

}

