using System;
using AulaPOO_Heranca.classes;

namespace AulaPOO_Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciamos nossa subclasse
            PessoaFisica pf = new PessoaFisica();

            //Atribuios um valor para a propriedade disponível na superclassw
            pf.nome ="Ester";

            Console.WriteLine("Digite o seu CPF: ");
            pf.cpf = Console.ReadLine();

            //Mostramos no console o método de saudação 
            Console.WriteLine(pf.DarBoasVindas(pf.nome) );

            //Mostramos no Console o método de validação da subclasse 
            Console.WriteLine(pf.ValidarCPF(pf.cpf) );
        }
    }
}
