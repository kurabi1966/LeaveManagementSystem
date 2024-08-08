using System;
using LeaveManagementSystem.Web.Models.LeaveTypes;

namespace LeaveManagementSystem.Web.Services;

public interface ILeaveTypeService
{
    Task<List<LeaveTypeReadOnlyVM>> GetAll();
    Task<T?> Get<T>(int id) where T : class;
    Task Remove(int id);
    Task Create(LeaveTypeCreateVM model);
    Task Edit(LeaveTypeEditVM model);
    Task<bool> LeaveTypeExists(int id);
    Task<bool> LeaveTypeIsNotUnique(string name);
    Task<bool> LeaveTypeIsNotUnique(int id, string name);

}
