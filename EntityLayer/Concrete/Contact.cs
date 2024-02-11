using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]

        public int ContactID { get; set; }
        public string Description { get; set; }
        public string Mail {  get; set; }
        public string Adress { get; set; }
        public string Phone { get; set; }
        public string Map { get; set; }
        public string Location { get; set; }
    }
}
