using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Castle.Models
{
    public class Testimonial
    {
        public string Body { get; set; }
        public int PostNumber { get; internal set; }
        private static int NextPostNumber = 1;
        public static List<Testimonial> TestimonialMasterList = new List<Testimonial>();

        public Testimonial(string body)
        {
            this.Body = body;
            PostNumber = NextPostNumber;

            
            NextPostNumber++;
            
        }

        public static void AddToMasterList(Testimonial post)
        {
            TestimonialMasterList.Add(post);
        }


    }
}
