using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Highlight2
    {
        [Key]

        public int HighlightId { get; set; }
        public string Post2Name { get; set; }
        public string Post2Description { get; set; }
        public string Post2Image { get; set; }

        public string Status { get; set; }
    }
}
