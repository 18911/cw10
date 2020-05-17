using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cw10.Models{
    public class Studies{
        [Key]
        public int IdStudy { get; set; }
        public string Name { get; set; }
    }
}
