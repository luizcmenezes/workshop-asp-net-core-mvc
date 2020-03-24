using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _conetxt;

        public DepartmentService(SalesWebMvcContext context)
        {
            _conetxt = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _conetxt.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
