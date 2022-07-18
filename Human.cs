using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloGitWorld
{
    public class Human
    {
        public virtual int Id { get; set; }
        public virtual DateTime Created { get; set; }
        public virtual string? Name { get; set; }
        public virtual string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        

    }
}
