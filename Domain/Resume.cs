using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Resume { 
        public int Id { get; set; }
        public List<Milestone> Milestones { get; set; }

    }
}
