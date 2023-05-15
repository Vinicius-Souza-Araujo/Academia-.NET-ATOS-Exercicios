using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14
{
    internal class Agenda
    {
        private List<Pessoa> _pessoaList = new List<Pessoa>();
        private int _cont;

        public void ArmazenaPesssoa(Pessoa pessoa)
        {
            string nome = pessoa.Nome;
            if (BuscaPessoa(nome) != null) {
                Console.WriteLine("Essa pessoa já existe em nossa base de dados!");
            }
            else
            {
                if (_cont < 10)
                {
                    _cont++;
                    _pessoaList.Add(pessoa);
                }
                else
                {
                    Console.WriteLine("Agenda cheia!");
                }
            }

            
        }

        public void RemovePessoa(string nome)
        {
                Pessoa p = new Pessoa();
                p = BuscaPessoa(nome);
                if (p != null) {
                    _pessoaList.Remove(p);
                    _cont = _cont - 1;
                }
                
               
            

        }

        public Pessoa BuscaPessoa(string nome)
        {
            foreach (Pessoa pessoa in _pessoaList)
            {
                if (pessoa.Nome == nome)
                {
                   return pessoa;
                }
                
            }
            return null;
        }

        public void ImprimeAgenda()
        {
            Console.WriteLine("---------- AGENDA ----------");
            Console.WriteLine("****************************");
            foreach (Pessoa pessoa in _pessoaList)
            {
                
                Console.WriteLine("Nome: " + pessoa.Nome);
                Console.WriteLine("Idade: " + pessoa.Idade);
                Console.WriteLine("Altura: " + pessoa.Altura);

                Console.WriteLine("****************************");
          
            }
            Console.WriteLine("----------------------------");
        }

    }
}
