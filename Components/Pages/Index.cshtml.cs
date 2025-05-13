using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BlazorAppMediaRating;
using BlazorAppMediaRating.Data;

namespace BlazorAppMediaRating.Components.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BlazorAppMediaRating.Data.ApplicationDbContext _context;

        public IndexModel(BlazorAppMediaRating.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Movie = await _context.Movies.ToListAsync();
        }
    }
}
