using System;
using Colecoes.Helper;
using System.Collections.Generic;
using static System.Console;
using System.Linq;

namespace Colecoes
{
    class Program
    {
        static void DemoArray()
        {
            int[] arrayInteiros = new int[3];
            int x = 0;

            arrayInteiros[0] = 3;
            arrayInteiros[1] = 4;
            arrayInteiros[2] = 10;

            WriteLine("Percorrendo array com for");
            for (int i = 0; i < arrayInteiros.Length; i++)
            {
                WriteLine(arrayInteiros[i]);
            }

            WriteLine("Percorrendo array com foreach");
            foreach (int item in arrayInteiros)
            {
                WriteLine(item);
            }

            WriteLine("Percorrendo array com While");
            while (x < arrayInteiros.Length)
            {
                WriteLine(arrayInteiros[x]);
                x++;
            }
        }

        static void DemoArrayMultidimensional()
        {
            int[,] matriz = new int[4,2]
           {
               { 8, 8 },
               { 1, 10 },
               { 54, 1 },
               { 40, 10 }
           };

           for (int i = 0; i < matriz.GetLength(0); i++)
           {
               for (int j = 0; j < matriz.GetLength(1); j++)
               {
                   Write($"|{matriz[i, j]}|");                   
               }
               Write("\n");
           }
        }

        static void DemoArrayOrdenacao()
        {
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5]{1,5,2,11,15};
            WriteLine("Array original");
            op.ImprimirArray(array);
            op.OrdenarBubleSort(ref array);
            WriteLine("Array ordenado");
            op.ImprimirArray(array);
        }

        static void DemoArraySort()
        {
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5]{1,5,2,11,15};
            WriteLine("Array original");
            op.ImprimirArray(array);
            op.Ordernar(ref array);
            WriteLine("Array ordenado");
            op.ImprimirArray(array);
        }

        static void DemoArrayCopy()
        {
            OperacoesArray op = new OperacoesArray();

            int[] array = new int[5]{1,5,2,11,15};
            int[] arrayCopy = new int[10];

            WriteLine("Array original");
            op.ImprimirArray(array);
            op.Copiar(ref array, ref arrayCopy);
            WriteLine("Array copiado");
            op.ImprimirArray(arrayCopy);
        }

        static void DemoArrayValueExists()
        {
            OperacoesArray op = new OperacoesArray();

            int[] array = new int[5]{1,5,2,11,15};

            bool existe = op.Existe(array, 20);

            if(existe)
            {
                WriteLine($"Encontrei o valor");
            }
            else
            {
                WriteLine("Não encontrei o valor");
            }
        }

        static void DemoArrayMaiorQuer()
        {
            OperacoesArray op = new OperacoesArray();

            int[] array = new int[5]{-1,5,2,11,15};

            bool maiorQuer = op.TodosMaiorQue(array, 0);

            if(maiorQuer)
            {
                WriteLine($"Todos os valores são maior que 0");
            }
            else
            {
                WriteLine($"Existe valores que não são maiores que 0");
            }
        }

        static void DemoArrayFind()
        {
            OperacoesArray op = new OperacoesArray();

            int[] array = new int[5]{-1,5,2,11,15};

            int valor = op.ObterValor(array, 21);

            if(valor > 0)
            {
                WriteLine($"Encontrei o valor");
            }
            else
            {
                WriteLine($"Não encontrei o valor");
            }
        }

        static void DemoArrayFindIndex()
        {
            OperacoesArray op = new OperacoesArray();

            int[] array = new int[5]{-1,5,2,11,15};

            int indice = op.ObterIndice(array, 11);

            if(indice > -1)
            {
                WriteLine($"Encontrei o valor do meu indice {indice}");
            }
            else
            {
                WriteLine($"Não encontrei o valor");
            }
        }

        static void DemoArrayRedimensinamento()
        {
            OperacoesArray op = new OperacoesArray();
            int[] array = new int[5]{-1,5,2,11,15};

            WriteLine($"Capacidade atual do array {array.Length}");

            op.RedimencionarArray(ref array, array.Length * 2);

            WriteLine($"Capacidade atual do array após o rendimencionar {array.Length}");
           
            string[] arrayString = op.ConverterParaArrayString(array);
            WriteLine("Array de string convertido");
            WriteLine(string.Join(", ", arrayString));
        }

        static void DemoColecoesGenericaColecoes()
        {
            OperacoesListas opLista = new OperacoesListas();
            List<string> estados = new List<string>();
            string[] estadosArray = new string[2]{"PA", "RR"};

            estados.Add("SP");
            estados.Add("RJ");
            estados.Add("BA");
            estados.Add("SC");

            WriteLine($"Quantidade de elementos na lista: {estados.Count}");
            opLista.ImprimirListaString(estados);

            WriteLine("Removendo o elemento");
            estados.Remove("BA");

            opLista.ImprimirListaString(estados);

            WriteLine("Adicionando uma coleção");
            estados.AddRange(estadosArray);

            opLista.ImprimirListaString(estados);

            WriteLine("Adicionando por indice");
            estados.Insert(1, "MG");
            
            opLista.ImprimirListaString(estados);
        }

        static void DemoColecoesEspecificasFila()
        {
            Queue<string> fila = new Queue<string>();

            fila.Enqueue("Demetrio");
            fila.Enqueue("Alessandra");
            fila.Enqueue("Nelcina");

            WriteLine($"Pessoas na fila: {fila.Count}");
            while(fila.Count > 0)
            {
                WriteLine($"Vez de: {fila.Peek()}");
                WriteLine($"{fila.Dequeue()} atendido");
            }
            WriteLine($"Pessoas na fila: {fila.Count}");
        }

        static void DemoColecoesEspecificasPilha()
        {
            Stack<string> pilha = new Stack<string>();
            
            pilha.Push(".NET");
            pilha.Push("DDD");
            pilha.Push("Codigo limpo");

            WriteLine($"Livros na pilha: {pilha.Count}");
            while(pilha.Count > 0)
            {
                WriteLine($"Próximo livro para a leitura: {pilha.Peek()}");
                WriteLine($"{pilha.Pop()} lido com sucesso");
            }
            WriteLine($"Livros na pilha: {pilha.Count}");
        }

        static void DemoDictonary()
        {
            Dictionary<string, string> estados = new Dictionary<string, string>();

            estados.Add("BA", "Bahia");
            estados.Add("SP", "São Paulo");
            estados.Add("RJ", "Rio de Janeiro");

            foreach (KeyValuePair<string, string> item in estados)
            {
                WriteLine($"Chave:{item.Key}, valor: {item.Value}");
            }

            var valorProcurado = "SC";

            if(estados.TryGetValue(valorProcurado, out string valorEncontrado))
            {
                WriteLine(valorEncontrado);
            }
            else
            {
                WriteLine("Valor não encontrado");
            }
        }

        static void CustomerError()
        {
            try
            {
                
            }
            catch (MyClassException)
            {
                
                throw;
            }
        }

        static void Main(string[] args)
        {
            int[] arrayNumeros = new int[10] {5, 20,19,4,100,1,8,4,19,100};

            var minimo = arrayNumeros.Min();
            var maximo = arrayNumeros.Max();
            var medio = arrayNumeros.Average();
            var soma = arrayNumeros.Sum();
            var distinct = arrayNumeros.Distinct().ToArray();

            WriteLine($"Minimo: {minimo}");
            WriteLine($"Maximo: {maximo}");
            WriteLine($"Medio: {medio}");
            WriteLine($"soma: {soma}");
            WriteLine($"distinct: {string.Join(", ", distinct)}");

            var numerosParesQuery =
                from num in arrayNumeros
                where num % 2 == 0
                orderby num
                select num;

            var numerosParesMetodos = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

            WriteLine($"Numeros paredes query:{string.Join(", ", numerosParesQuery)}");
            WriteLine($"Numeros paredes Method:{string.Join(", ", numerosParesMetodos)} ");
        }
    }
    
}
