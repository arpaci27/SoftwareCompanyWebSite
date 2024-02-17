using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Service
    {
        [Key]

        public int ServiceId { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
        public  double Price {  get; set; }
        public string Image {  get; set; }
        public string Description { get; set; }
        public bool Status {  get; set; }
        public string CoverImage { get; set; }
        public string Details1 { get; set; }
        public string Details2  { get; set; }
        public string Image2 { get; set; }


    }
}
