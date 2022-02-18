using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace S4E1_POO_e_EstruturaRepeticao { 
public class Matematica
    {
        int NumeroBase;
        int NumeroMults;
        public Matematica(int n1, int n2)
	{
            this.NumeroBase = n1;
            this.NumeroMults = n2;

	}

        public static int exponenciacao(int n1, int n2) {
            if (n2 == 0)
            {
                return 1;
            }

            int aux = n1;
            for (int i = 1;i < n2 ; i = i + 1 )
            {
                n1 = n1 * aux;

            }
            return n1;
        }
}
}