using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Interest { get; set; }
        public virtual List<Proposal> Proposals { get; set; }
        public virtual User Deputy { get; set; }
    }

    
}
