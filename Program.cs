using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula08_Array150623
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> nomes1 = new List<string>();

            while (true)
            {
                Console.WriteLine("Bem-vindos ao Senac Store!");
                Console.WriteLine("Digite 1 para buscar ou 2 para cadastrar 3 para remover ou 4 para alterar:");
                string resposta = Console.ReadLine();

                if (resposta == "1")
                {
                    if (nomes1.Count == 0)
                    {
                        Console.WriteLine("A lista está vazia...");
                    }
                    else
                    {
                        int contador = 0;
                        int quantidade = nomes1.Count;

                        while (contador < quantidade)
                        {
                            Console.WriteLine($" Nome: {nomes1[contador]} ");
                            contador += 1;
                        }
                    }
                }


                if (resposta == "2")
                {
                    Console.WriteLine("Digite o seu nome:");
                    string nome1 = Console.ReadLine();
                    nomes1.Add(nome1);
                    Console.WriteLine("Nome adcionado com sucesso!");
                }

              

                if (resposta == "3")
                {

                    Console.WriteLine("Escolha na lista a posicão que deseja remover: ");
                    int posicao = int.Parse(Console.ReadLine());

                    nomes1.RemoveAt(posicao);

                    Console.WriteLine("Nome removido com sucesso!");

                }
                if (resposta == "4")
                {
                    Console.WriteLine("Digite o número do usuário que deseja alterar:");
                    int numero = int.Parse(Console.ReadLine());

                    if (numero >= 0 && numero < nomes1.Count)
                    {
                        string nomeAntigo = nomes1[numero];

                        Console.WriteLine("Digite o novo nome para o usuário:");
                        string novoNome = Console.ReadLine();
                        

                        nomes1[numero] = novoNome;
                        Console.WriteLine($"Nome do usuário na posição {numero} alterado de {nomeAntigo} para {novoNome}");
                    }
                    else
                    {
                        Console.WriteLine("Esse nome não existe, tente novamente!");
                    }










                }



            }

            void repeticao()
            {
                // Laço de repetição (LOOP)
                // contador += 1; forma comum de fazer contas ou contador -= 1; ou contador *= 1; ou contador /= 1; (MAIS USADO)
                // contador ++;  => MAIS UM, SOMA APMAS UMA VEZ

                int contador = 0;

                Console.WriteLine("Olá");
                //while => enquanto, quero que repita um código

                while (contador < 5)
                {

                    Console.WriteLine("Olá!");
                    contador = contador + 1;



                }
            }

            void Listas()
            {
                List<string> nomes = new List<string>();

                nomes.Add("Jonatas");
                nomes.Add("Natanael");
                nomes.Add("Bruno");



                Console.WriteLine("O Primeiro é: " + nomes[0]);
                Console.WriteLine("O Segundo é: " + nomes[1]);
                Console.WriteLine("O Terceiro é: " + nomes[2]);


                int quantidade = nomes.Count;
                Console.WriteLine($"Existem {quantidade} usuários cadastrados!");

                Console.WriteLine("Digite o seu nome:");
                nomes.Add(Console.ReadLine());                // Para deixar a pessoa digitar o nome que desejar

                nomes.RemoveAt(3);

                nomes.Remove("Natanael");


                Console.ReadKey();
            }

            void Arrays()
            {

                // Array -> Conjunto de dados (vetor)
                // nomes[1] = Console.ReadLine(); Para a pessoa digitar o nome

                string[] nomes = new string[3];

                nomes[0] = "Kennedy";
                nomes[1] = "Rafany";
                nomes[2] = "João";

                Console.WriteLine("O nome da primeira posição é " + nomes[0]);
                Console.WriteLine("O nome da segunda posição é " + nomes[1]);
                Console.WriteLine("O nome da terceira posição é" + nomes[2]);

                Console.ReadKey();

            }
        }
    }
}
    