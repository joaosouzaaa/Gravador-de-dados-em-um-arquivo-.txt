using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastramento
{
    interface IPessoa
    {
        void SetNome(string nome);
        void SetTelefone(string telefone);
        void SetCPF(string cpf);
        void Gravar();
        // Interface - Obriga a classe que herdá-la a ter Gravar, nome, telefone e cpf como obrigatórios.
    }
}
