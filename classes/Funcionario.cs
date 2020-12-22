using System;

namespace POO_Polimorfismo_Sobrecarga.classe
{
    public class Funcionario
    {
        // Sintaxe completa
        // Atalho : propfull
        private int myVar;
        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        // Alternativa com sintaxe reduzida:
        public string Name { get; set; }
        

        public string[] lista = {"Marcos", "Tsuka", "Priscila", "Fernanda"};
        
        public void Mostrar(){
            foreach(var item in lista) {
                Console.WriteLine(item);
            }
        }

        public void Mostrar(int indice) {
            Console.WriteLine($"Busca por indice: {lista[indice]}");
        }

        public void Mostrar(string busca) {
            foreach(var item in lista) {
                if(item == busca) {
                    Console.WriteLine($"Resultado: {item}");
                }

            }
        }
        
        
    }
}