using ProjectWeb.Data;
using System.Linq;
using ProjectWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace ProjectWeb.Services
{
    public class DepartmentService
    {
        private readonly ProjectWebContext _context;

        public DepartmentService(ProjectWebContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.Include(obj => obj.Sellers).OrderBy(x => x.Name).ToList();
        }
    }
}
