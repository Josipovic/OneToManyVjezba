using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyVjezba
{
    public class Bolnica
    {
        public int Id { get; set; }
        public string  NazivBolnice { get; set; }
        public string Adresa { get; set; }

        public  virtual List<Doktori>Doktori { get; set; }

        public Bolnica()
        {
            Doktori = new List<Doktori>();
        }

    }
}
