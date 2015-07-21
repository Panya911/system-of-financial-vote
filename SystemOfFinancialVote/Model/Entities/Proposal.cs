using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Model.Entities
{
    public class Proposal
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        public int? Price { get; set; }
        public int CollectedAmount { get; set; }
        public bool FixedPrice { get; set; }
        public virtual User Author { get; set; }
        public bool Reviewed { get; set; }
    }
}
