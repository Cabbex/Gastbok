using System;
using System.ComponentModel.DataAnnotations;

namespace Gastbok.Models {
    public class Comment {

        public int Id { get; set; }

        public DateTime DateTime { get; set; }

        [Display(Name = "Skriv ett inlägg")]
        public String TextData { get; set; }

        public String UserId { get; set; }
    }
}