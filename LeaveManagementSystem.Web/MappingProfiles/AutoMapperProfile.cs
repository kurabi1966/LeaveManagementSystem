
using LeaveManagementSystem.Web.Models.LeaveTypes;

namespace LeaveManagementSystem.Web.MappingProfiles
{
    public class AutoMapperProfile : AutoMapper.Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<LeaveType, LeaveTypeReadOnlyVM>();
            CreateMap<LeaveType, LeaveTypeCreateVM>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeEditVM>().ReverseMap();

            // .ForMember(d => d.Days, opt => opt.MapFrom(s => s.NumberOfDays));
        }
    }

}

