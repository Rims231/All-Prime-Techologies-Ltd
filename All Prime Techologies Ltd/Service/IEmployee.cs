using All_Prime_Techologies_Ltd.Dtos;

namespace All_Prime_Techologies_Ltd.Service
{
    public interface IEmployee
    {

        Task<ServiceResponse<List<GetAllEmployeesDtos>>> GetAll();


       // Task<ServiceResponse<List<GetAllEmployeesDtos>>> GetSingle();
        Task<ServiceResponse<GetAllEmployeesDtos>>GetById(int id);
        Task<ServiceResponse<List<GetAllEmployeesDtos>>> AddEmployee(AddEmployeesDtos newEmployee);
        Task<ServiceResponse<GetAllEmployeesDtos>> UpdateEmployee(UpDateEmployeesDtos newEmployee);
        Task<ServiceResponse<List<GetAllEmployeesDtos>>> DeleteEmployee(int id);
    }
}
