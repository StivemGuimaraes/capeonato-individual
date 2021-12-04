using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capeonato_individual
{
    class funcionario : audiencia
    {
        public string id;
        public double salario;

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
            Console.Write("salario= ");
            this.salario = double.Parse(Console.ReadLine());
            Console.Clear();
        }
        public override void mostrarDados()
        {
            Console.WriteLine("funcionario");
            Console.WriteLine("                        ");
            Console.WriteLine("id= " + this.id);
            Console.WriteLine("CPF= " + cpf);
            Console.WriteLine("RG= " + rg);
            Console.WriteLine("data de nascimento= " + Data_de_nascimento);
            Console.WriteLine("telefone= " + telefone);
            Console.WriteLine("endereço= " + endereco);
            Console.WriteLine("email= " + this.email);
            Console.WriteLine("salario= " + this.salario);
        }
    }
}
