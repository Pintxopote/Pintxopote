using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pintxopote.Models
{
    public class Tabernak
    {
        public int idtaberna { get; set; }
        public string izena { get; set; }
        public string deskribapena { get; set; }
        public string kokapena { get; set; }
        public string kontaktua { get; set; }
        public string argazkia { get; set; }
        public int pintxoak { get; set; }
        public virtual Pintxo Pintxo { get; set; }
    }
}
