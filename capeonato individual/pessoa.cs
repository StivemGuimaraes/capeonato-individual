using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capeonato_individual
{
    abstract class pessoa
    {
        public string cpf;
        public string rg;
        public string Data_de_nascimento;
        public string telefone;
        public string endereco;

        abstract public void cadastrarDados();
        abstract public void mostrarDados();
        
        
    }
}
