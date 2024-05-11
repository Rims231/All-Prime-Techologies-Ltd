

using All_Prime_Techologies_Ltd.Dtos;
using AutoMapper;

namespace All_Prime_Techologies_Ltd
{
    public class AutoMapper : Profile
    {
        public AutoMapper() {
            CreateMap<Employee, GetAllEmployeesDtos>();
            CreateMap<AddEmployeesDtos, Employee>();
            CreateMap<UpDateEmployeesDtos, Employee>();

        }
    }
}
