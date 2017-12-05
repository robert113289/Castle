using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Castle.Models
{
    public class Testimonial
    {
        public string Body { get; set; }
        public string Identity { get; set; }
        public int PostNumber { get; internal set; }
        public bool IsApproved { get; set; }
        private static int NextPostNumber = 1;
        public static List<Testimonial> TestimonialMasterList = new List<Testimonial>();

        public Testimonial()
        {
            PostNumber = NextPostNumber;
            IsApproved = false;
            NextPostNumber++;
        }

        public static void AddToMasterList(Testimonial post)
        {
            TestimonialMasterList.Add(post);
        }

        public static Testimonial GetById(int id)
        {
            return TestimonialMasterList.Single(c => c.PostNumber == id);
        }

    }
}
