using System.Collections.Generic;
using static System.Console;

namespace Colecoes.Helper
{
    public class OperacoesListas
    {
        public void ImprimirListaString(List<string> lista)
        {            
            foreach (var item in lista)
            {
                WriteLine(item);
            }
        }
    }
}