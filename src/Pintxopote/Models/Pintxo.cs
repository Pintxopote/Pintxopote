using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pintxopote.Models
{
    public class Pintxo
    {
        public string izena { get; set; }
        public string deskribapena { get; set; }
        public string argazkia { get; set; }
        public int idpintxo { get; set; }
        public virtual Tabernak Tabernak { get; set; }
    }
}
