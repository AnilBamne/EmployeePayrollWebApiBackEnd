using BusinessLayer.Interface;
using CommonLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryLayer.Entity;
using System.Collections.Generic;

namespace EmpPayrollWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmpBL empBL;
        public EmployeeController(IEmpBL empBL)
        {
            this.empBL = empBL;
        }
        [HttpPost("Register")]
        public ActionResult Register(EmpModel model)
        {
            var result = empBL.Register(model);
            if(result!= null)
            {
                return Ok(new ResponseModel<EmployeeEntity> { Status = true,Message="Registeration Successful",Data=result });
            }
            else
            {
                return BadRequest(new ResponseModel<EmployeeEntity> { Status = false, Message = "Registeration Failed", Data = result });
            }
        }
        [HttpGet("GetAllEmployees")]
        public ActionResult GetAllEmployees()
        {
            var result = empBL.GetAllEmp();
            if (result != null)
            {
                return Ok(new ResponseModel<List<EmployeeEntity>> { Status = true, Message = "Getting All Emp Successful", Data = result });
            }
            else
            {
                return BadRequest(new ResponseModel<List<EmployeeEntity>> { Status = false, Message = "Getting All Emp Failed", Data = result });
            }
        }
        [HttpPost("Update")]
        public ActionResult Update(int empId,EmpModel model)
        {
            var result = empBL.Update(empId,model);
            if (result != null)
            {
                return Ok(new ResponseModel<EmployeeEntity> { Status = true, Message = "Update Successful", Data = result });
            }
            else
            {
                return BadRequest(new ResponseModel<EmployeeEntity> { Status = false, Message = "Update Failed", Data = result });
            }
        }
        [HttpGet("GetEmployeeById")]
        public ActionResult GetEmployeeById(int id)
        {
            var result = empBL.GetEmpById(id);
            if (result != null)
            {
                return Ok(new ResponseModel<EmployeeEntity> { Status = true, Message = "Getting Emp Successful", Data = result });
            }
            else
            {
                return BadRequest(new ResponseModel<EmployeeEntity> { Status = false, Message = "Getting Emp Failed", Data = result });
            }
        }
    }
}
