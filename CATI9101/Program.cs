using System;


namespace CATI9101
{
    internal class Program
    {   //atributos
        //static int x;




        static void Main(string[] args)
        {
            //declaração de variaveis
            /* var x = 10;
             var nome = "Maria";
             var teste = true;
             var valor = 12.89;
             var num = 15f;
             var y = false;

             byte[] vetor = new byte[5];
             vetor[0] = 74;
             vetor[1] = 104;
             vetor[2] = 111;
             vetor[3] = 119;
             for (int i = vetor.Length -1; i > -1 ; i--)
             {
                 //Console.WriteLine(vetor[i]);
             }

             byte l = 255; //0-255
             short s = 32767; //16bits

             int w = 0;
             w = -2147483648;
             w = 2147483647;
             uint ww = 2147483648 + 2147483647;
             double A, B, C, D;
             A = 2.55;
             float c = 10.65f;
             string m = "senac";
             m = m.Substring(2, 1);
             for (int i = 0; i < m.Length;i++)
             {
                // Console.WriteLine(m.Substring(i, 1));
             }
             bool chk = false;
             if (chk)
             {
                 for (int i = 0; i < m.Length; i++)
                 {
                     //Console.WriteLine(m.Substring(i, 1));
                 }
                 chk = true;
             }
            */
            //-------------------------------------------------------
            /* Console.WriteLine("Digite seu nome:");
             string nome = Console.ReadLine();
             Console.WriteLine("Digite o ano de seu nascimento:");
             //int ano = (int)Console.ReadLine();  //cast não foi ):
             //int ano = int.Parse(Console.ReadLine()); // Parse foi :D
             string ano = Console.ReadLine(); //Classe Convert foi :D
             int idade = DateTime.Now.Year - int.Parse(ano);
             Console.WriteLine(" oi {0} sua idade {1}", nome, idade);*/

            Console.WriteLine("Digite um numero de 1 a 10: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero > 0 && numero < 11)

            

            //maneiras de conversões de tipos
            Console.ReadKey();
            
        }
    }
}
