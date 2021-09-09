using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastramento
{
    class PreMenu
    {
        public static void EscolhedorCliente()
        {
            while (true)
            // Faz um loop de escolhas até você quiser sair do loop.
            {
                string mensagem = "======================Cadastro de Cliente======================\n" +
                    "Escolha uma das opções a seguir:\n" +
                "0 - Sair do cadastro de cliente\n" +
                "1 - Cadastrar clientes no banco de dados\n" +
                "2 - Ver clientes cadastrados";
                Console.WriteLine(mensagem);
                int resposta = Convert.ToInt32(Console.ReadLine());

                if (resposta == 0) break;
                // Sai do loop caso a resposta seja 0.

                else if(resposta == 1)
                {
                    var cliente = new Cliente().Ler();

                    
                    var cliente2 = new Cliente();
                    Console.WriteLine("Insira o nome do cliente: ");
                    cliente2.Nome = Console.ReadLine();
                    Console.WriteLine("Insira o telefone do cliente: ");
                    cliente2.Telefone = Console.ReadLine();
                    Console.WriteLine("Insira o cpf do cliente: ");
                    cliente2.CPF = Console.ReadLine();
                    cliente2.Gravar();
                    // Você define o nome, telefone e cpf e grava eles no seu arquivo .txt.
                    Console.WriteLine("===============================\n");

                }
                else if(resposta == 2)
                {
                    var cliente3 = new Cliente().Ler();

                    int i = 0;
                    
                    foreach (Cliente c in  new Cliente().Ler())
                    {
                        i++;
                        Console.WriteLine($"===========Cliente {i}================");
                        Console.WriteLine("Nome: " + c.Nome + "\n");
                        Console.WriteLine("Telefone: " + c.Telefone + "\n");
                        Console.WriteLine("CPF: " + c.CPF + "\n");
                        // Você imprime todos os clientes que foram imprimidos até o dado momento.
                        
                    }
                }
                else Console.WriteLine("Número inválido, redigite-o");
            }
        }
        public static void EscolhedorUsuario()
        // Mesmas observações do cliente.
        {
            while (true)
            {
                string mensagem = "======================Cadastro de Usuário======================\n" +
                    "Escolha uma das opções a seguir:\n" +
                "0 - Sair do cadastro de usuário\n" +
                "1 - Cadastrar usuários no banco de dados\n" +
                "2 - Ver usuários cadastrados";
                Console.WriteLine(mensagem);
                int resposta = Convert.ToInt32(Console.ReadLine());

                if (resposta == 0) break;

                else if (resposta == 1)
                {
                    var usuario = new Usuario().Ler();

                    var usuario2 = new Usuario();
                    Console.WriteLine("Insira o nome do usuário: ");
                    usuario2.Nome = Console.ReadLine();
                    Console.WriteLine("Insira o telefone do usuário: ");
                    usuario2.Telefone = Console.ReadLine();
                    Console.WriteLine("Insira o cpf do usuário: ");
                    usuario2.CPF = Console.ReadLine();
                    usuario2.Gravar();
                    Console.WriteLine("===============================\n");
                }
                else if (resposta == 2)
                {
                    var usuario3 = new Usuario().Ler();

                    int i = 0;
                    foreach (Usuario u in new Usuario().Ler())
                    {
                        i++;
                        Console.WriteLine($"===========Usuário {i}================");
                        Console.WriteLine("Nome: " + u.Nome + "\n");
                        Console.WriteLine("Telefone: " + u.Telefone + "\n");
                        Console.WriteLine("CPF: " + u.CPF + "\n");
                        Console.WriteLine("===========================");
                    }
                }
                else Console.WriteLine("Número inválido, redigite-o");
            }
        }
    }
}
