using System;
using System.Collections.Generic;
using System.Linq;


namespace Model
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {            
            Console.WriteLine("Digite a placa do veiculo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo para remover: ");
            string placa = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veiculo permaneceu no estacionamento: ");

                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + (precoPorHora * horas);
                
                Console.WriteLine($"O veiculo {placa} foi removido e o valor a ser recebido é : {valorTotal}");
                veiculos.Remove(placa);
            }
            else
            {
                Console.WriteLine("Veiculo não encontrado. Confira os dados informados.");
            }
            Console.ReadKey();
        }

        public void ListarVeiculos()
        {
           if (veiculos.Any())
           {
               Console.WriteLine("Os veiculos estacionados são: ");

               foreach(var item in veiculos)
               {
                    Console.WriteLine(item);
               }
           
           }else
           {
               Console.WriteLine("Não há veiculos no estacionamento.");
           }      
           Console.ReadKey();
        }
    }
}
