using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.FileProviders;

namespace EXTREME.Pages
{

    public class SkripnikovaGymModel : PageModel
    {
        private readonly IWebHostEnvironment webHostEnvironment;

        public SkripnikovaGymModel(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
        }

        public List<string> Album = new List<string>();
        public IActionResult OnGet()
        {
            var provider = new PhysicalFileProvider(webHostEnvironment.WebRootPath);
            var contents = provider.GetDirectoryContents(Path.Combine("images", "gyms", "skripnikova", "galery"));
            var objFiles = contents.OrderBy(m => m.LastModified);

            foreach (var item in objFiles.ToList())
            {
                Album.Add(item.Name);
            }

            return Page();
        }
    }
}
