using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using GBO.MyAirport.EF;
using GBO.MyAirport.Razor.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace GBO.MyAirport.Razor.Bagages
{
    public class CreateModel : BagagePageModel
    {
        public CreateModel(MyAirportContext context, IXmlDocumentation xmlDocumentation) : base(context)
        {
        }

        public async Task<IActionResult> OnGetAsync()
        {
            Vols = await GetVolsAsSelectListItem();

            return Page();
        }
        
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            await ValidateVol();
            
            if (!ModelState.IsValid)
            {
                return Page();
            }


            _context.Bagages.Add(Bagage);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Details", new { id = Bagage.BagageID });
        }
    }
}