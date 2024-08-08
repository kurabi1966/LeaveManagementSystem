using System;
using AutoMapper;
using LeaveManagementSystem.Web.Data;
using LeaveManagementSystem.Web.Models.LeaveTypes;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.CodeAnalysis.Differencing;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagementSystem.Web.Services;

public class LeaveTypeService(ApplicationDbContext _context, IMapper _mapper) : ILeaveTypeService
{
    public async Task<List<LeaveTypeReadOnlyVM>> GetAll()
    {
        var data = await _context.LeaveTypes.ToListAsync();
        var viewData = _mapper.Map<List<LeaveTypeReadOnlyVM>>(data);
        return viewData;
    }
    public async Task<T?> Get<T>(int id) where T : class
    {
        var leaveType = await _context.LeaveTypes.FirstOrDefaultAsync(m => m.Id == id);
        if (leaveType == null) return null;
        return _mapper.Map<T>(leaveType);
    }

    public async Task Remove(int id)
    {
        var leaveType = await _context.LeaveTypes.FirstOrDefaultAsync(m => m.Id == id);
        if (leaveType != null)
        {
            _context.LeaveTypes.Remove(leaveType);
            await _context.SaveChangesAsync();
        }
    }
    public async Task Create(LeaveTypeCreateVM model)
    {
        var leaveType = _mapper.Map<LeaveType>(model);
        _context.Add(leaveType);
        await _context.SaveChangesAsync();

    }

    public async Task Edit(LeaveTypeEditVM model)
    {
        var leaveType = _mapper.Map<LeaveType>(model);
        _context.Update(leaveType);
        await _context.SaveChangesAsync();
    }

    // helper functions
    public async Task<bool> LeaveTypeExists(int id)
    {
        return await _context.LeaveTypes.AnyAsync(e => e.Id == id);
    }

    public async Task<bool> LeaveTypeIsNotUnique(string name)
    {
        return await _context.LeaveTypes.AnyAsync(e => e.Name.ToLower().Equals(name));
    }
    public async Task<bool> LeaveTypeIsNotUnique(int id, string name)
    {
        return await _context.LeaveTypes.AnyAsync(e => e.Name.ToLower().Equals(name) && e.Id != id);
    }
}
