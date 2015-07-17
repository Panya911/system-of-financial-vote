using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class Proposal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? Price { get; set; }
        public int CollectedAmount { get; set; }
        public bool FixedPrice { get; set; }
        public virtual User Author { get; set; }
        public bool Reviewed { get; set; }
    }
}
