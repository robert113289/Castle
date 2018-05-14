using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Castle.Models
{
    public class Testimonial
    {
        public int ID { get; internal set; }
        public string Body { get; set; }
        public string Identity { get; set; }
        public bool IsApproved { get; set; }


        public Testimonial()
        {
            IsApproved = false;
        }


    }
}
