using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorCrudScaffold.DAL;
using RazorCrudScaffold.Model;

namespace RazorCrudScaffold.Pages.EmployeeMaster
{
    public class IndexModel : PageModel
    {
        private readonly RazorCrudScaffold.DAL.MyDbContext _context;

        public IndexModel(RazorCrudScaffold.DAL.MyDbContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Employee = await _context.Employees.ToListAsync();
        }
    }
}
