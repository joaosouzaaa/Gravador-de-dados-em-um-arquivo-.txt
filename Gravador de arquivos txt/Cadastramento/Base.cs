using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastramento
{
    class Base : IPessoa
    // A classe Base está herdando da interface para outras classes herdarem desta e o código ficar mais organizado.
    {
        /// <summary>
        /// Construtores
        /// </summary>
        /// <param name="nome">Define o nome</param>
        /// <param name="telefone">Define o telefone</param>
        /// <param name="cpf">Define o cpf</param>
        public Base(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;
        }
        
        public Base() { }
        // Construtor sem nada dentro, para as classes se referenciarem a ele quando não for referente aos construtores anteriores.

        public string Nome;
        public string Telefone;
        public string CPF;

        public void SetNome(string nome) { this.Nome = nome; }
        public void SetTelefone(string telefone) { this.Telefone = telefone; }
        public void SetCPF(string cpf) { this.CPF = cpf; }
        // Está definindo as obrigatoriedades da interface como sendo os contrutores da classe base.

        public virtual void Gravar()
        {
            var dados = this.Ler();
            // Verifica se o arquivo é existente e diz aonde adicionar no arquivo os contrutores.
            dados.Add(this);
            StreamWriter escritor = new StreamWriter(diretorio());
            escritor.WriteLine("nome;telefone;cpf;");
            // Escreve a frase acima no arquivo .txt
            foreach(Base dado in dados)
            {
                var linha = (dado.Nome + ";" + dado.Telefone + ";" + dado.CPF + ";");
                escritor.WriteLine(linha);
                // Define o nome, telefone e cpf e os escreve em um arquivo.
            }
            escritor.Close();
            // Encerra a escrita que está ocorrendo.
        }
        


        public string diretorio()
        {
            return ConfigurationManager.AppSettings["BancoDeDados"] + this.GetType().Name + ".txt";
            // Define o local aonde será cadastrado.
        }

        public List<IPessoa> Ler()
        {
            var lista = new List<IPessoa>();
            if (File.Exists(diretorio()))
            {
                using(StreamReader arquivo = File.OpenText(diretorio()))
                // Cria uma lista na interface e se o local existir ele abrirá o arquivo .txt contido nesse local.
                {
                    string linha;
                    int i = 0;
                    while((linha = arquivo.ReadLine()) != null)
                    // Enquanto meu arquivo for diferente de nulo (não tiver nada dentro dele) ele fará as seguintes ações: 
                    {
                        i++;
                        if (i == 1) continue;
                        var DadosArquivo = linha.Split(';');

                        var definidor = (IPessoa)Activator.CreateInstance(this.GetType());
                        // Irá criar um arquivo do tipo específicado
                        definidor.SetNome(DadosArquivo[0]);
                        definidor.SetTelefone(DadosArquivo[1]);
                        definidor.SetCPF(DadosArquivo[2]);
                        // Irá definir o nome, telefone e cpf nas posições 0, 1 e 2 e adicioná-lo a uma lista.
                        lista.Add(definidor);
                    }
                }
                Console.WriteLine("=====================");
            }
            return lista;
        }

    }
}
