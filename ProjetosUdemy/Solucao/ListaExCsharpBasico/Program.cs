
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListaExCsharpBasico;

namespace ListaExCsharpBasico
{
    class Program
    {

        static void Main(string[] args)
        {
            //Funcao Principal - Basta chamar a funcao nesse campo e ela sera executada.
            Ex1MostrarNumeros();
            Console.WriteLine("Pressione alguma tecla para sair");
            Console.ReadKey();  
        }

        //EX1
        /// <summary>
        /// Funcao que mostra todos os numeros de 1000 a 0
        /// </summary>
        public static void Ex1MostrarNumeros()
        {
            for (int i = 1000; i >= 0; i--)
            {
                Console.Write(i + " ");

            }
        }

        //EX2
        /// <summary>
        /// Funcao que mostra a media aritimetica entre os numeros digitados
        /// </summary>
        public static void MediaAritimetica()
        {
            try
            {
                Console.WriteLine("Digite quantos numeros deverao ser lidos");
                int quantidade = int.Parse(Console.ReadLine());
                
                int soma = 0;
                for (int i = 0;i < quantidade ; i++)
                {
                    soma += int.Parse(Console.ReadLine());


                }
                int media = soma / quantidade;
                Console.WriteLine("Media :" + media);   
            }
            catch (Exception ex)
            { 
            Console.WriteLine("ERROR :" + ex.Message);
            }
        }


        /// <summary>
        /// Funcao para verificar quais numeros sao impares dentro do intervalo de 0 a 200
        /// </summary>
        public static void VerificarParOuImpar0a200() {

            Console.WriteLine("Digite quantos numeros deverao ser lidos");
            int quantidade = int.Parse(Console.ReadLine());

            int[] soma = new int [quantidade];
            for (int i = 0; i < quantidade; i++)
            {
                soma[i] = int.Parse(Console.ReadLine());
                
            }
            for (int i = 0; i < quantidade; i++)
            {
                if (soma[i] < 0 || soma[i] > 200)
                {
                    Console.WriteLine("Numero fora do intervalo de 0 a 200");
                }
                else if (soma[i] % 2 != 0)
                    {
                    Console.WriteLine("Impar : " + soma[i]);
                    
                }

            }
        }

        /// <summary>
        /// Funcao para mostrar a tabuada de um Numero qualquer escolhido
        /// </summary>
        public static void Tabuada()
        {
            Console.WriteLine("Digite o numero o qual deve ter a tabuada impressa");
            int Numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Tabuada do " + Numero);
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i + "X" + Numero + " = " + (i*Numero));
            }

        }

        /// <summary>
        /// Funcao para somar separadamente os numeros pares e impares descritos
        /// </summary>
        public static void SomaParEImpar()
        {
            int aux = 0;
            int par = 0;
            int impar = 0;
            Console.WriteLine("Digite 4 numeros");
            for (int i = 0; i < 4; i++)
            {
                aux = int.Parse(Console.ReadLine());

                if (aux % 2 == 0)
                {
                    par = par + aux;
                }
                else { 
                impar = impar + aux;    
                }
            }
            Console.WriteLine("Par : " + par + "\nImpar : " + impar);

        }

        /// <summary>
        /// Funcao que calcula media da turma e media individual de cada aluno -> Utilizado Classe e lista para facilitar o controle
        /// </summary>
        public static void MediaEscolar() //Poderiam ser construidos Getters e Setters entretanto para reduzir o tamanho do codigo utilizei apenas os atributos como publicos
        {

            try
            {
                List<Aluno> turma = new List<Aluno>();
                string nome = Console.ReadLine().Trim();
                int controle = 0;
                while (!nome.Equals("finalizar"))
                {
                    controle++;


                    int b1 = int.Parse(Console.ReadLine());
                    int b2 = int.Parse(Console.ReadLine());
                    int b3 = int.Parse(Console.ReadLine());
                    int b4 = int.Parse(Console.ReadLine());


                    Aluno aux = new Aluno(nome, b1, b2, b3, b4);

                    turma.Add(aux);
                    nome = Console.ReadLine().Trim();
                }
                int media = 0;
                int mediaInd = 0;
                for (int i = 0; i < controle; i++ )
                {
                    mediaInd += turma[i].B1;
                    mediaInd += turma[i].B2;
                    mediaInd += turma[i].B3;
                    mediaInd += turma[i].B4;

                    media += mediaInd;

                    turma[i].mediaIndividual = mediaInd/4;

                    mediaInd = 0;
                }

                media = media/controle;

                for (int i = 0; i < controle; i++)
                {
                    Console.WriteLine("Media de : " + turma[i].nome + " : " + turma[i].mediaIndividual);
                }
                Console.WriteLine("Media da Turma : " + media);

            }
            catch (Exception ex) {
                Console.WriteLine("ERROR : " + ex.Message);
            }
        }

        /// <summary>
        /// Funcao que busca o maior e menor entre os digitados
        /// </summary>
        public static void MaiorMenor()
        {
            try
            {
                Console.WriteLine("Digite quantos numeros deverao ser lidos");
                int quantidade = int.Parse(Console.ReadLine());

                int menor, maior; 

                int numero = int.Parse(Console.ReadLine());
                menor = maior = numero;
                for (int i = 0; i < quantidade - 1; i++)
                {
                    if (numero > maior) { maior = numero; }
                    if (numero < menor) { menor = numero; }

                    numero = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Maior : " + maior + " Menor : " + menor);
            }
            catch (Exception ex)
            {
            Console.WriteLine(ex.Message);
            
            }
        }

        /// <summary>
        /// Funcao que Mostra todos os multiplos de 3 entre 0 e 1000
        /// </summary>
        public static void MultiploDe3()
        {
            for (int i = 1000; i >= 0; i--)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i + "- Numero multiplo de 3 ");
                }
                else {
                    Console.WriteLine(i);
                }

            }
        }


        /// <summary>
        /// Funcao realiza calculos basicos
        /// </summary>
        public static void ConversorDeBase()
        {
            int x = 0;
            Console.WriteLine("Escolha : ");
            Console.WriteLine("1-Adicao\n2-Subtracao\n3-Multiplicacao\n4-Divisao");
         x = int.Parse(Console.ReadLine());
            while (x != 0) {
                string menu = "S";

            switch (x)
            {
                case 1:
                        Console.WriteLine("Digite o primeiro numero");
                        int n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero");
                        int n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Soma = " + (n1 + n2));
                        Console.WriteLine("Deseja voltar ao menu?\nS-SIM\nN-NAO");
                             menu = Console.ReadLine().ToUpper();
                        break;

                case 2:
                        Console.WriteLine("Digite o primeiro numero");
                        int n12 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero");
                        int n22 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Subtracao = " + (n12 - n22));
                        Console.WriteLine("Deseja voltar ao menu?\nS-SIM\nN-NAO");
                        menu = Console.ReadLine().ToUpper();
                        break;

                case 3:
                        Console.WriteLine("Digite o primeiro numero");
                        int n122 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero");
                        int n222 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Multiplicacao = " + (n122 * n222));
                        Console.WriteLine("Deseja voltar ao menu?\nS-SIM\nN-NAO");
                        menu = Console.ReadLine().ToUpper();
                        break;

                case 4:
                        Console.WriteLine("Digite o primeiro numero");
                        int n1222 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o segundo numero");
                        int n2222 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Divisao = " + (n1222 / n2222));
                        Console.WriteLine("Deseja voltar ao menu?\nS-SIM\nN-NAO");
                        menu = Console.ReadLine().ToUpper();
                        break;

                      

                    default:
                    Console.WriteLine("Numero Invalido");
                    break;
            }
                if (menu.Equals("S"))
                {
                    Console.WriteLine("1-Adicao\n2-Subtracao\n3-Multiplicacao\n4-Divisao");
                    x = int.Parse(Console.ReadLine());
                }
                else { x = 0; }
            }
        }


        /// <summary>
        /// Funcao que calcula valor a ser pago pelo imposto de renda
        /// </summary>
        public static void CalculadoraDeImposto()
        {
            Console.WriteLine("Digite o Salario ou 0 para sair :");
            double salario = Double.Parse(Console.ReadLine());
            while (salario != 0.0)
            {
                double aux = salario;
                if (salario < 1903.98)
                {

                }
                else if (salario < 2826.65) { aux = aux * 0.075; Console.WriteLine("Valor a ser pago : " + aux); }
                else if (salario < 3751.05) { aux = aux * 0.15; Console.WriteLine("Valor a ser pago : " + aux); } 
                else if (salario < 4664.68) { aux = aux * 0.225; Console.WriteLine("Valor a ser pago : " + aux); } 
                else { aux = aux * 0.275; Console.WriteLine("Valor a ser pago : " + aux); }

                Console.WriteLine("Digite o Salario ou 0 para sair :");
                salario = Double.Parse(Console.ReadLine());
            }
        
        }

        public static void ClassificaNadador()
        {
            string nome;
            int idade;
            int controle = 0;
            List<Nadador> Nadadores = new List<Nadador>();
            int x = 1;
            while (x != 0)
            {
                
               nome = Console.ReadLine();
               idade = int.Parse(Console.ReadLine());
                Nadador aux = new Nadador(nome,idade);
                controle++;
                if (idade > 5 && idade < 7)
                {
                    aux.classificacao = "infantil A";
                }
                else if (idade > 8 && idade < 11) { aux.classificacao = "infantil B"; } 
                else if (idade > 12 && idade < 13) { aux.classificacao = "Juvenil A"; } 
                else if (idade > 14 && idade < 17) { aux.classificacao = "Juvenil B"; } 
                else if(idade > 18) { aux.classificacao = "Adultos"; }

                Nadadores.Add(aux);

                Console.WriteLine("Deseja Cadastrar mais nadadores: \n1-Sim\n2-Nao");
                x = int.Parse(Console.ReadLine());
            }
            for (int a = 0;a < controle ;a++ )
            {
               Console.WriteLine(Nadadores[a].nome +" - " +Nadadores[a].idade + " - " + Nadadores[a].classificacao);
                
            }
        }


        /// <summary>
        /// Funcao para achar o menor e o maior termo dentre os digitados com parada no termo 0
        /// </summary>
        public static void MenorMaiorParadaEm0()
        {

            try
            {
                int menor, maior;

                int numero = int.Parse(Console.ReadLine());
                menor = maior = numero;
                while(numero != 0)
                {
                    if (numero > maior) { maior = numero; }
                    if (numero < menor) { menor = numero; }

                    numero = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Maior : " + maior + " Menor : " + menor);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

        }


        /// <summary>
        /// Funcao que calcula o aumento salarial de acordo com os anos trabalhados
        /// </summary>
        public static void aumentoSalarial()
        {
            int anos = int.Parse(Console.ReadLine());
            double salario = Double.Parse(Console.ReadLine());

            if (anos > 0 && anos <= 3)
            {
                int x = anos;
            while (x > 0)
                {
                    salario = salario * 1.5;
                    x--;
                }
            }
            if (anos > 3)
            {
            
                for (int i = 0; i < anos - 3; i++) {
                    salario = salario * 2;
                    if ((i + 3 ) % 10 == 0)
                    {
                        salario = salario * 0.1;
                    }
                }
               
             
            
            }
        
        
        }
        

        /// <summary>
        /// Desafio enviado por WhatsApp
        /// </summary>
        /// <param name="recebido">String com o valor a ser convertido</param>
        public void MorteSubita(string recebido)
        {
            int variavel;
            try
            {
                variavel = int.Parse(recebido);

            }
            catch (Exception ex) { variavel = 0; }
        }




    }
}