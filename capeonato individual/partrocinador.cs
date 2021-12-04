using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capeonato_individual
{
    class partrocinador : organizador
    {
        public string id;
        public string email;


        public override void cadastrarDados()
        {
            Console.WriteLine("digite suas informacões");
            Console.Write("id= ");
            this.id = Console.ReadLine();
            Console.Write("CPF= ");
            cpf = Console.ReadLine();
            Console.Write("rg= ");
            rg = Console.ReadLine();
            Console.Write("data de nascimento= ");
            Data_de_nascimento = Console.ReadLine();
            Console.Write("telefone= ");
            telefone = Console.ReadLine();
            Console.Write("endereço= ");
            endereco = Console.ReadLine();
            Console.Write("email= ");
            this.email = Console.ReadLine();
            Console.Clear();
        }
        public override void mostrarDados()
        {
            Console.WriteLine("organizador");
            Console.WriteLine("                        ");
            Console.WriteLine("id= " + this.id);
            Console.WriteLine("CPF= " + cpf);
            Console.WriteLine("RG= " + rg);
            Console.WriteLine("data de nascimento= " + Data_de_nascimento);
            Console.WriteLine("telefone= " + telefone);
            Console.WriteLine("endereço= " + endereco);
            Console.WriteLine("email= " + this.email);
        }
    }
}
