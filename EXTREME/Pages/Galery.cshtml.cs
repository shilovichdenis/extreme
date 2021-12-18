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
    public class GaleryModel : PageModel
    {
        private readonly Microsoft.AspNetCore.Hosting.IWebHostEnvironment webHostEnvironment;

        public GaleryModel(IWebHostEnvironment webHostEnvironment)
        {
            this.webHostEnvironment = webHostEnvironment;
        }

        public List<string> Album = new List<string>();
        public IActionResult OnGet()
        {
            var provider = new PhysicalFileProvider(webHostEnvironment.WebRootPath);
            var contents = provider.GetDirectoryContents(Path.Combine("images", "gyms", "shpilevskogo", "galery"));
            var objFiles = contents.OrderBy(m => m.LastModified);

            foreach (var item in objFiles.ToList())
            {
                Album.Add("shpilevskogo/galery/" + item.Name);
            }

            contents = provider.GetDirectoryContents(Path.Combine("images", "gyms", "rokossovskogo", "galery"));
            objFiles = contents.OrderBy(m => m.LastModified);

            foreach (var item in objFiles.ToList())
            {
                Album.Add("rokossovskogo/galery/" + item.Name);
            }

            contents = provider.GetDirectoryContents(Path.Combine("images", "gyms", "skripnikova", "galery"));
            objFiles = contents.OrderBy(m => m.LastModified);

            foreach (var item in objFiles.ToList())
            {
                Album.Add("skripnikova/galery/" + item.Name);
            }

            return Page();
        }
    }
}
