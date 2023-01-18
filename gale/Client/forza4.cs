using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Client
{
    public class forza4
    {

        int giocatore = 0;
        private readonly int[,] tabella;
        int riga { get; }
        int colonna{ get; }
        public int this[int r,int c]
        {
            get=>tabella[r,c];
            set=> tabella[r,c] = value; 
        }

        public forza4()
        {
            riga = 5;
            colonna = 6;
        }


        public void inserisci(Image img)
        {
            if (giocatore == 1) // se giocatore 1 inserisci rosso
            {
                img.SetValue("\pallina_gialla.jpeg");
            }
            else // se giocatore 2 inserisci giallo 
            {
                img.SetValue("\pallina_rossa.png");
            }



        }


    }
}
