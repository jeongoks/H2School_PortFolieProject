using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace H2School_PortFolieProject.Pages
{
    public class ContactModel : PageModel
    {
        public Guest Guests { get; set; }

        public void OnGet()
        {

        }
    }
}
