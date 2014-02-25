using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PracticeNHibernateMVC.Mappings
{
    public class Page
    {
        public virtual Int32 ID { get; set; }
        public virtual String Name { get; set; }
        public virtual String Namespace { get; set; }
    }
}