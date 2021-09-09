using Cadastramento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gravador_de_arquivos_txt
{
    class Menu
    {
        public static void Escolhedor()
        {
            while (true)
            // Faz um loop de escolhas até você quiser sair do loop.
            {
                string mensagem = "=====================Cadastro em um arquivo .txt=========================\n" +
                    "Escolha uma das opções a seguir:\n" +
                "0 - Sair da execução do programa\n" +
                "1 - Cadastro de Cliente\n" +
                "2 - Cadastro de Usuário\n";
                Console.WriteLine(mensagem);
                int resposta = Convert.ToInt32(Console.ReadLine());

                if (resposta == 0) break;
                // Sai da execução do programa.

                else if (resposta == 1)
                {
                    PreMenu.EscolhedorCliente();
                    // Dá as escolhas de cliente.
                }
                else if(resposta == 2)
                {
                    PreMenu.EscolhedorUsuario();
                    // Dá as escolhas de usuário.
                }
                else Console.WriteLine("Número inválido, redigite-o");
            }
        }
    }
}
