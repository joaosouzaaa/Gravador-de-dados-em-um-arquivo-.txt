using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gravador_de_arquivos_txt
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu.Escolhedor();
            // Dá as escolhas do seu menu
            // Caso você queira você pode também rodar este arquivo em excel, somente mudando do tipo .txt para .csv
            // Para mudar para .csv é somente necessário renomeá-lo, também você pode ir ao diretório na classe base e alterar de .txt para .csv
            // Caso seu programa dê um erro de SystemIndexOutOfRange provavelmente é um problema em seu arquivo .txt
        }
    }
}
