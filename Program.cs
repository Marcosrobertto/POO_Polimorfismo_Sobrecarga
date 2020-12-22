using System;
using POO_Polimorfismo_Sobrecarga.classe;

namespace POO_Polimorfismo_Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.Mostrar();
            funcionario.Mostrar("Marcos");
            funcionario.Mostrar(2);

            Console.WriteLine();
            Console.Beep();
        }
    }
}
