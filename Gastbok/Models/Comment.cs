using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gastbok.Models {
    public class Comment {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public long TextData { get; set; }
        public ApplicationUser User { get; set; }
    }
}