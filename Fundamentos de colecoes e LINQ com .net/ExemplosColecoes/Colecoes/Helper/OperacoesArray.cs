using System;

namespace Colecoes.Helper
{
    public class OperacoesArray
    {
        public void OrdenarBubleSort(ref int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length -1; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        public void ImprimirArray(int[] array)
        {
            var linha = string.Join(", ", array);
            System.Console.WriteLine(linha);
        }

        public void Ordernar(ref int[] array)
        {
            Array.Sort(array);
        }

        public void Copiar(ref int[] array, ref int[] arrayDestino)
        {
            Array.Copy(array, arrayDestino, array.Length);
        }
    }
}