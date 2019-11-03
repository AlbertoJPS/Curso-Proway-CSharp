using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1.Class
{
    class Dados
    {
        string caminho = @"P:\Backup ProWay\C#\Curso-Proway-CSharp\Extras\Exercício_1.txt";

        #region Metodo
        public void Salvar(Pessoa pessoa)
        {
            StreamWriter arquivo = File.AppendText(caminho);
            arquivo.WriteLine(pessoa);
            arquivo.Close();
        }

        public List<Pessoa> LeiaTodos()
        {

            List<Pessoa> lista = new List<Pessoa>();
            StreamReader arquivo = File.OpenText(caminho);

            while (arquivo.EndOfStream == false)
            {
                string linha = arquivo.ReadLine();
                string[] linhaQuebrada = linha.Split(';');

                Pessoa pessoa = new Pessoa();
                pessoa.Nome = linhaQuebrada[0];
                pessoa.SobreNome = linhaQuebrada[1];
                pessoa.Idade = linhaQuebrada[2];
                pessoa.CPF = linhaQuebrada[3];

                lista.Add(pessoa);
            }

            return lista;
        }
        #endregion

    }
}
