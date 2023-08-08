using BusinessLayer.Interface;
using CommonLayer.Model;
using RepositoryLayer.Entity;
using RepositoryLayer.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Service
{
    public class EmpBL:IEmpBL
    {
        private readonly IEmployeeRL employeeRL;
        public EmpBL(IEmployeeRL employeeRL)
        {
            this.employeeRL = employeeRL;
        }
        public EmployeeEntity Register(EmpModel model)
        {
            try
            {
                return employeeRL.Register(model);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public List<EmployeeEntity> GetAllEmp()
        {
            return employeeRL.GetAllEmp();
        }
        public EmployeeEntity Update(int empId, EmpModel model)
        {
            return employeeRL.Update(empId, model);
        }
        public EmployeeEntity GetEmpById(int id)
        {
            return employeeRL.GetEmpById(id);
        }
    }
}
