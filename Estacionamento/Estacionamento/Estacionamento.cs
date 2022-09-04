namespace Estacionamento
{

    public class Estacionamento
    {
        private readonly decimal precoInicial = 0;
        private readonly decimal precoPorHora = 0;
        private readonly List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            var placaVeiculo = Console.ReadLine();
            veiculos.Add(placaVeiculo);
            Console.WriteLine($"O veículo de placa {placaVeiculo} foi estacionado.");
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            var placaVeiculo = Console.ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placaVeiculo.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                var horasEstacionado = Console.ReadLine();
                decimal valorTotal = 0;

                valorTotal = (precoInicial + precoPorHora) * Convert.ToDecimal(horasEstacionado);

                veiculos.Remove(placaVeiculo);

                Console.WriteLine($"O veículo {placaVeiculo} foi removido e o preço total de {horasEstacionado} horas estacionado foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                for (int contador = 0; contador < veiculos.Count; contador++)
                {
                    Console.WriteLine($"{contador} = {veiculos[contador]}");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
