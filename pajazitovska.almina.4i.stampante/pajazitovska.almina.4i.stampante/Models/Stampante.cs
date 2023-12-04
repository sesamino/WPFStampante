using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pajazitovska.almina._4i.stampante.Models
{
    public class Stampante
    {
        //serbatoi di colore
        public int C { get; set; }
        public int M { get; set; } 
        public int Y{ get; set; }      
        public int B { get; set; }

        public int Fogli { get; set; }
        //PRIMO COSTRUTTORE
        public Stampante() { 
            C = M = Y = B = 100;
            Fogli = 200;
        }
        //metodo bool Stampa(Pagina p)
        // torna false se non ci sono pagine o colori per stampare
        public bool Stampa(Pagina p)
        {                     
            if( (Fogli>0) && 
                (C >= p.C)&&
                (M >= p.M) &&   
                (Y >= p.Y) &&   
                (B >= p.B) 
                ){//controllare se è ciano o magenta o yellow o black (si può scrivere anche sulla stessa riga ma scrivendolo in questo modo riga per riga è più leggibile)

                    C -= p.C;
                    M -= p.M;
                    Y -= p.Y;
                    B -= p.B;
                    Fogli--;

                    return true;
            }
            return false;
        }
        public int StatoInchiostro(string colore) 
        { 

        }

    }
}
