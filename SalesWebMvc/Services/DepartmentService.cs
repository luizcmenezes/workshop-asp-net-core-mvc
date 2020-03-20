using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _conetxt;

        public DepartmentService(SalesWebMvcContext context)
        {
            _conetxt = context;
        }

        public List<Department> FindAll()
        {
            return _conetxt.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
