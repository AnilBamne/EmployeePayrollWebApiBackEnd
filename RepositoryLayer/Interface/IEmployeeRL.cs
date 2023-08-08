using CommonLayer.Model;
using RepositoryLayer.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.Interface
{
    public interface IEmployeeRL
    {
        public EmployeeEntity Register(EmpModel model);
        public List<EmployeeEntity> GetAllEmp();
        public EmployeeEntity Update(int empId, EmpModel model);
        public EmployeeEntity GetEmpById(int id);
    }
}
