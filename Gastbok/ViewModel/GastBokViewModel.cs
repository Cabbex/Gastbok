using Gastbok.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gastbok.ViewModel {
    public class GastBokViewModel {
        public Comment Comment { get; set; }
        public List<Comment> dbComments { get; set; }
    }
}