using CommonLayer.Model;
using Microsoft.Extensions.Configuration;
using RepositoryLayer.Entity;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RepositoryLayer.Service
{
    public class EmployeeRL: IEmployeeRL
    {
        private readonly IConfiguration configuration;
        private readonly EmployeeDBContext empContext;
        public EmployeeRL(IConfiguration configuration, EmployeeDBContext empContext)
        {
            this.configuration = configuration;
            this.empContext = empContext;
        }

        public EmployeeEntity Register(EmpModel model)
        {
            EmployeeEntity employeeEntity = new EmployeeEntity();
            employeeEntity.Name=model.Name;
            employeeEntity.ProfileImage=model.ProfileImage;
            employeeEntity.Gender=model.Gender;
            employeeEntity.Department=model.Department;
            employeeEntity.Salary=model.Salary;
            employeeEntity.StartDate=model.StartDate;
            employeeEntity.Notes=model.Notes;
            employeeEntity.CreatedAt = DateTime.Now;
            employeeEntity.UpdatedAt = DateTime.Now;
            employeeEntity.IsTrash=model.IsTrash;

            empContext.Add(employeeEntity);
            empContext.SaveChanges();
            return employeeEntity;
        }
        public List<EmployeeEntity> GetAllEmp()
        {
            //List<EmployeeEntity> empList = new List<EmployeeEntity>();
            var list = empContext.EmployeeTable.ToList();
            return list;
        }
        public EmployeeEntity Update(int empId,EmpModel model)
        {
            var CheckEmployee = empContext.EmployeeTable.Where(a => a.Id == empId).FirstOrDefault();
            if (CheckEmployee != null)
            {
                CheckEmployee.Name = model.Name;
                CheckEmployee.Gender = model.Gender;
                CheckEmployee.Department = model.Department;
                CheckEmployee.Salary = model.Salary;
                CheckEmployee.UpdatedAt = DateTime.Now;
                empContext.SaveChanges();
                return CheckEmployee;
            }
            else
            {
                return null;
            }
        }
        public EmployeeEntity GetEmpById(int id)
        {
            var emp= empContext.EmployeeTable.Where(a => a.Id == id).FirstOrDefault();
            if(emp != null)
            {
                return emp;
            }
            else
            {
                return null;
            }
        }
    }
}
