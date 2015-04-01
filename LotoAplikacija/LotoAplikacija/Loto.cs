using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LotoAplikacija
{
    class Loto
    {
        public List<int> UplaceniBrojevi { get; set; }
        public List<int> DobitniBrojevi { get; set; }

        public Loto() {
            UplaceniBrojevi = new List<int>();
            DobitniBrojevi = new List<int>();
        
        }

        public bool UnesiUplaceneBrojeve(List<string> korisnickeVrijednosti) {

            bool ispravni = false;
            UplaceniBrojevi.Clear();

            foreach (string v in korisnickeVrijednosti) {
                int broj = 0;
                if (int.TryParse(v, out broj)== true)
                {
                    if (broj >=1 && broj<= 39)
                    {
                        if (UplaceniBrojevi.Contains(broj) == false)
                        {
                            UplaceniBrojevi.Add(broj);
                        }
                    }
                }
            
            }
            if (UplaceniBrojevi.Count == 7)
            {
                ispravni = true;

            }
            return ispravni;
        }

        public void GenenrirajDobitnuKombinaciju() {

            DobitniBrojevi.Clear();
            Random genetatorBrojeva = new Random();
            while (DobitniBrojevi.Count < 7)
            {
                int broj = genetatorBrojeva.Next(1, 39);
                if (DobitniBrojevi.Contains(broj) == false)
                {
                    DobitniBrojevi.Add(broj);
                }
            }
        }

        public int IzracunajBrojPogodaka() {
            int brojPogodaka = 0;
            foreach (int broj in UplaceniBrojevi)
            {
                if (DobitniBrojevi.Contains(broj)== true)
                {
                    brojPogodaka++;
                }
            }
            return brojPogodaka;
        }
    }
}
