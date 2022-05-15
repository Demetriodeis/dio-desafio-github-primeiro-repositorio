using System;
using Colecoes.Helper;
using static System.Console;

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
           
        }
    }   
    
}
