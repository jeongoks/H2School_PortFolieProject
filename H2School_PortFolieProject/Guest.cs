using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace H2School_PortFolieProject
{
    public class Guest
    {
        [EmailAddress]
        public string Email { get; set; }
        public string Name { get; set; }
        [Phone]
        public string Mobile { get; set; }
        public string TextBox { get; set; }
    }
}
