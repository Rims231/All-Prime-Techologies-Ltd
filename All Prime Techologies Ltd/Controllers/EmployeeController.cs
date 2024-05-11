using All_Prime_Techologies_Ltd.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace All_Prime_Techologies_Ltd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private readonly IEmployee _employeeService;

        public EmployeeController(IEmployee EmployeeService)
        {
            _employeeService = EmployeeService;
        }

        [HttpGet(Name = "GetAll")]

        public async Task<ActionResult<ServiceResponse<List<GetAllEmployeesDtos>>>> GetAll()
        {
            return Ok(await _employeeService.GetAll());
        }
        //[HttpGet("GetSingle")]
        //public async Task <ActionResult<ServiceResponse<List<GetAllEmployeesDtos>>>> GetSingle()
        // {
        //   return Ok(await _employeeService.GetSingle());
        // }

        [HttpGet("{id:int}", Name = "GetById")]

        public async Task<ActionResult<ServiceResponse<List<GetAllEmployeesDtos>>>> GetById(int id)
        {
            return Ok(await _employeeService.GetById(id));
        }
        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<GetAllEmployeesDtos>>>> AddEmployee(AddEmployeesDtos newClient)
        {

            return Ok(await _employeeService.AddEmployee(newClient));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<GetAllEmployeesDtos>>>> UpdateEmployee(UpDateEmployeesDtos updatedEmployee)
        {
            var response = await _employeeService.UpdateEmployee(updatedEmployee);

            if (response.Data is null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ServiceResponse<List<GetAllEmployeesDtos>>>> DeleteEmployee(int id)
        {
            var response = await _employeeService.DeleteEmployee(id);
            if (response.Data is null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }

    }

}


    

