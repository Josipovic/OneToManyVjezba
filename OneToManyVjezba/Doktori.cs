using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToManyVjezba
{
    public class Doktori
    {
        public int Id { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Specijalizacija { get; set; }

        public  virtual Bolnica Bolnica { get; set; }
    }
}
