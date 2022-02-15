
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using S4E1_POO_e_EstruturaRepeticao;

namespace S4E1_POO_e_EstruturaRepeticao
{
    class Program
    {

        static void Main(string[] args)
        {
            Matematica A = new Matematica(1, 2); // Mesmo nao sendo necessario criei um construtor e o chamei so para demosntracao
             Console.WriteLine("Esse e o resultado : " + Matematica.exponenciacao(3, 4));
            Console.ReadKey();  
        }
    }

}