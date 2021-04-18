using ProjetoMVC1.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjetoMVC1.Services
{
    public class DepartmentService
    {
        private readonly ProjetoMVC1Context _context;

        public DepartmentService(ProjetoMVC1Context context)
        {
            _context = context;

        }
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
