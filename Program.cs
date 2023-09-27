using System;
using System.Collections.Generic;
using System.Text;
using DesafioProjetoHospedagem.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        // Cria os modelos de hóspedes e cadastra na lista de hóspedes
        List<Pessoa> hospedes = new List<Pessoa>(){
            new Pessoa(nome: "Hóspede 1"),
            new Pessoa(nome: "Hóspede 2")
        };

        // Cria a suíte
        Suite suite = new(tipoSuite: "Premium", capacidade: 3, valorDiaria: 30);

        // Cria uma nova reserva, passando a suíte e os hóspedes
        Reserva reserva = new(diasReservados: 10);
        reserva.CadastrarSuite(suite);
        reserva.CadastrarHospedes(hospedes);

        // Exibe a quantidade de hóspedes e o valor da diária
        Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
        Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
    }
}