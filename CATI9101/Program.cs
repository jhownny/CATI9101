using System;


namespace CATI9101
{
    internal class Program
    {   //atributos
        //static int x;




        static void Main(string[] args)
        {//declaração de variaveis

            /* 
             var x = 10;
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
            //

            /*
             Console.WriteLine("Digite seu nome:");
             string nome = Console.ReadLine();
             Console.WriteLine("Digite o ano de seu nascimento:");
             //int ano = (int)Console.ReadLine();  //cast não foi ):
             //int ano = int.Parse(Console.ReadLine()); // Parse foi :D
             string ano = Console.ReadLine(); //Classe Convert foi :D
             int idade = DateTime.Now.Year - int.Parse(ano);
             Console.WriteLine(" oi {0} sua idade {1}", nome, idade);
             */


            /*
            bool atende = false;
            int[] vnumero = new int[10];
            string sair = string.Empty;
            int cont = 10;    

            while (sair!= "s" && cont > 0)
            {

                Console.WriteLine("Digite um numero de 1 a 10: ");
                
                    int numero = int.Parse(Console.ReadLine());

                do
                {
                    if (numero > 0 && numero < 11)
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine("{0} x {1} = {2}", numero, i + 1, numero * (i + 1));
                            //Console.WriteLine(numero + "x" + 1 + "=" + numero * (i + 1));

                        }
                        atende = false;
                    }
                    else
                    {

                        atende = true;

                        Console.WriteLine("Sabe lê não? Você deve Digitar um valor entre 1 e 10: ");
                        numero = int.Parse(Console.ReadLine());

                    }
                } while (atende);
                 
                cont--; //numero na variavel contador
                vnumero [cont] = numero; 

                Console.WriteLine("Deseja sair? (s/N): ");
                sair = Console.ReadLine();
                Console.Clear(); //Limpar console
                                 
            } //fim do while
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.Write("Você consultou as tabuadas dos numeros: ");
            Console.WriteLine("-----------------------------------------------------------------------------");
            foreach (var item in vnumero)
            {
                
                if (item != 0) Console.Write($"{item}, ");

            }
            */
            /*
            string[] jogadores = { "lima", "Genivaldo", "Cleiton", "Varildo", "Kelcino" };
            //int[,] pontos = { { 0, 2 }, { 1, 3 }, { 2, 5 }, { 3, 4 } };
            string[] times = new string[5];
            int [,] tabela = new int[5,6];
            

            
            //int[,] m = new int[4, 2];
            //m[0, 0] = 0;
            //m[1, 0] = 1;
            //m[2, 0] = 2;
            //m[3, 0] = 3;
            //m[4, 0] = 4;
            //m[0, 1] = 2;
            
             
            foreach (string jogador in jogadores)
            {
                Console.WriteLine(jogador);
            }
            for (int i = 0; i < jogadores.Length; i++)
            {
                Console.WriteLine("Digite o nome do {0}° jogador:", (i + 1));
                jogadores[i] = Console.ReadLine();
            }
          

            
                    //manipulação de strings
            string nome = " Jhonata Batista Santos ";
            Console.WriteLine(nome + " - " + nome.Length);

                    //retornar caracteres
            Console.WriteLine(nome.Length);

                    //Removendo espaços do começo e do fim (TRIM)
           /* nome = nome.Trim();
            Console.WriteLine(nome + " - " + nome.Length);

                     //exibindo os primeiros 4 caracters de nome
            Console.WriteLine("Primeiro nome: " + nome.Substring(0,7));
            Console.WriteLine("sobrenome: " + nome.Substring(8));

                     //alterando a variavel para manter apenas os 4 primeiros caracteres.

            nome = nome.Substring(0,4);
            nome = nome.Remove(4);


            Console.WriteLine(nome.Remove(4));//mantem as 4 primeiros

            nome = nome.Replace(" ", " ");
            Console.WriteLine(nome);


                    //coloca caracteres em uma string
            Console.WriteLine(nome.Insert(8, ""));

                    //retorna a posição da primeira ocorrencia da string.
            Console.WriteLine(nome.IndexOf("o"));
            
                    //retorna caracteres em maiusculo e minusculo. 
            Console.WriteLine(nome.ToUpper());
            Console.WriteLine(nome.ToLower());
            


            //Divide uma string em um vetor de strings.
            
            string[] vnome;
            vnome = nome.Split(' ');
            for (int i = 0; i < vnome.Length; i++)
            {
                Console.WriteLine(vnome[i]);
            }
            

            //invertendo as frase.
            string frase = "Amapá é dois mais dois";
            Console.WriteLine(frase);
            string fraseinv = string.Empty;
            for (int i = frase.Length -1; i > -1; i--)
            {
                fraseinv += frase.Substring(i, 1);
            }
            Console.WriteLine(fraseinv);
            */


            //Manupulação de Matrizes
            Console.WriteLine();
            int [] numeros = new int[6];
            Random random = new Random();    
            for (int i = 0; i < numeros.Length; i++)
            {
                int sorteados = random.Next(1, 60);    
                if (i==0)

                numeros[i] = sorteados;

                else // à aprtir do segundo número sorteado.
                {
                    if(Array.BinarySearch(numeros, sorteados)< 0);
                    numeros[i] = sorteados;

                }

                if (i!=numeros.Length -1)    
                Console.Write(numeros[i] + "-"); 
                else
                    Console.WriteLine(numeros[i]);
            }
            Console.WriteLine();
            Array.Sort(numeros); //ordena os números no vetor
            for (int i = 0; i < numeros.Length; i++)
            {
                if (i != numeros.Length - 1)
                    Console.Write(numeros[i] + "-");
                else
                    Console.WriteLine(numeros[i]);
            }


            //maneiras de conversões de tipos
            Console.ReadKey();

            
            
        }
    }
}
