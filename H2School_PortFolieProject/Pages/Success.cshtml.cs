using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace H2School_PortFolieProject
{
    public class SuccessModel : PageModel
    {
        public string Name { get; set; }
        public string TextBox { get; set; }

        public void OnGet()
        {

        }

        public void OnPost(Guest guests)
        {
            Name = guests.Name;
            TextBox = guests.TextBox;
        }
    }
}
