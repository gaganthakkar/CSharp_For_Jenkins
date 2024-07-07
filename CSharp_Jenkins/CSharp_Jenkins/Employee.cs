using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Jenkins
{
    internal class Employee
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Hobbies { get; set; }


    }
}
