using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capeonato_individual
{
    class jogador : pessoa
    {
        public string numero_de_inscricao;
        public string email;
        public int numero_de_vitorias;
        public int numero_de_empates;
        public int numero_de_derrotas;
        public int pontosAcumelados;

        public override void cadastrarDados()
        {
            Console.WriteLine("digite suas informacões");
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
            Console.Write("numero de inscrição= ");
            this.numero_de_inscricao = Console.ReadLine();
            Console.Clear();

        }
        public override void mostrarDados()
        {
            Console.WriteLine("jogador");
            Console.WriteLine("                        ");
            Console.WriteLine("CPF= " + cpf);
            Console.WriteLine("RG= " + rg);
            Console.WriteLine("data de nascimento= " + Data_de_nascimento);
            Console.WriteLine("telefone= " + telefone);
            Console.WriteLine("endereço= " + endereco);
            Console.WriteLine("email= " + email);
            Console.WriteLine("============================================================");
            Console.WriteLine("pontos acumelados= " + pontosAcumelados);
            Console.WriteLine("vitorias= " + numero_de_vitorias);
            Console.WriteLine("derrotas= " + numero_de_derrotas);
            Console.WriteLine("empates= " + numero_de_empates);
            

        }
        public void calcularPontos()
        {
            int n;
            Console.WriteLine("digite os numeros de vitorias,derrotas e empates");
            Console.Write("vitorias= ");
            this.numero_de_vitorias = int.Parse(Console.ReadLine());
            Console.Write("derrotas= ");
            this.numero_de_derrotas = int.Parse(Console.ReadLine());
            Console.Write("empates= ");
            this.numero_de_empates = int.Parse(Console.ReadLine());
            n = numero_de_vitorias * 3;
            this.pontosAcumelados = n + this.numero_de_empates;
            Console.Clear();

        }
    }
}