using Microsoft.AspNetCore.Mvc;
using sortDatabase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace sortDatabase.Controllers
{
    public class SortController : Controller
    {
        private readonly DataContext _context;
        public SortController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var model = _context.oldData.Include(d => d.Manger).ToList();
            return View(model);
        }
    }
}
