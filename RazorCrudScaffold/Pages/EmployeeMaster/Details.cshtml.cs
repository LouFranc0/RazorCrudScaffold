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
    public class DetailsModel : PageModel
    {
        private readonly RazorCrudScaffold.DAL.MyDbContext _context;

        public DetailsModel(RazorCrudScaffold.DAL.MyDbContext context)
        {
            _context = context;
        }

        public Employee Employee { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees.FirstOrDefaultAsync(m => m.ID == id);
            if (employee == null)
            {
                return NotFound();
            }
            else
            {
                Employee = employee;
            }
            return Page();
        }
    }
}
