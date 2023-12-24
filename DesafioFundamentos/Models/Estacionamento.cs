using System;
using System.Collections.Generic;

namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private double custo;

        // Lista para armazenar os veículos estacionados
        private List<string> veiculos = new List<string>();

        public Estacionamento(double custoPorHora)
        {
            this.custo = custoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine($"Veículo com placa {placa} adicionado com sucesso!");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo que deseja remover:");
            string placa = Console.ReadLine();
            if (veiculos.Contains(placa))
            {
                veiculos.Remove(placa);
                Console.WriteLine($"Veículo com placa {placa} removido com sucesso!");
            }
            else
            {
                Console.WriteLine($"Veículo com placa {placa} não encontrado!");
            }
        }

        public void ListarVeiculos()
        {
            Console.WriteLine("Veículos estacionados:");
            foreach (var veiculo in veiculos)
            {
                Console.WriteLine(veiculo);
            }
        }
    }
}

