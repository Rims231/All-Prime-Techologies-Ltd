using All_Prime_Techologies_Ltd.Dtos;
using All_Prime_Techologies_Ltd.Models;
using AutoMapper;
using System.Net;

namespace All_Prime_Techologies_Ltd.Service
{
    public class EmployeeService : IEmployee
    {
        private static readonly List<Employee> Employees = new List<Employee>
        {   new Employee(),
            new Employee{Id=1,FirstName="Rico",MiddleName="Pablo"},
            new Employee{Id=2,FirstName="Noel",MiddleName="Charles"},
            new Employee{Id=3,FirstName="Pattern",MiddleName="Hello"},
        };

        private readonly IMapper _mapper;

        public EmployeeService(IMapper mapper )
        {
            _mapper = mapper;
        }

       
        public async Task<ServiceResponse<List<GetAllEmployeesDtos>>> AddEmployee(AddEmployeesDtos newEmployee)
        {
            var serviceResponse = new ServiceResponse<List<GetAllEmployeesDtos>>();
            Employees.Add(_mapper.Map<Employee>(newEmployee));
            serviceResponse.Data = Employees.Select(c => _mapper.Map<GetAllEmployeesDtos>(c)).ToList();
            return serviceResponse;

            
        }

        public async Task<ServiceResponse<List<GetAllEmployeesDtos>>> GetAll()
        {
            var serviceResponse = new ServiceResponse<List<GetAllEmployeesDtos>>();
            serviceResponse.Data = Employees.Select(c => _mapper.Map<GetAllEmployeesDtos>(c)).ToList();
            return serviceResponse;
            
        }

        public async Task<ServiceResponse<GetAllEmployeesDtos>> GetById(int id)
        {
            var serviceResponse = new ServiceResponse<GetAllEmployeesDtos>();
            var Employee = Employees.FirstOrDefault(c => c.Id == id);
            serviceResponse.Data = _mapper.Map<GetAllEmployeesDtos>(Employee);
            return serviceResponse;
            
        }

        public async Task<ServiceResponse<GetAllEmployeesDtos>> UpdateEmployee(UpDateEmployeesDtos updateEmployee)
        {
            var serviceResponse = new ServiceResponse<GetAllEmployeesDtos>();
            var Employee = Employees.FirstOrDefault(c => c.Id == updateEmployee.Id);
            Employee.FirstName = updateEmployee.FirstName;
            Employee.LastName = updateEmployee.LastName;
            Employee.MiddleName = updateEmployee.MiddleName;
            Employee.MaritalStatus = updateEmployee.MaritalStatus;
            Employee.Email = updateEmployee.Email;
            Employee.Class = updateEmployee.Class;

            serviceResponse.Data = _mapper.Map<GetAllEmployeesDtos>(Employee);

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetAllEmployeesDtos>>> DeleteEmployee(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetAllEmployeesDtos>>();
            try
            {

                var Client = Employees.First(c => c.Id == id);
                if (Client is null)
                    throw new Exception($"Client with Id'{id}'not found oh.");

                Employees.Remove(Client);



                serviceResponse.Data = Employees.Select(c => _mapper.Map<GetAllEmployeesDtos>(c)).ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;


            }
            return serviceResponse;

        }
    }




}
