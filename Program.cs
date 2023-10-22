﻿using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

DateTime dataAtual = DateTime.Now;

Console.BackgroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("*************************\nBEM VINDO AO HOTEL DIO.ME\n*************************\n");
Console.ResetColor();

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hospede1");
Pessoa p2 = new Pessoa(nome: "Hospede2");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"- Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"- Valor diária: {suite.ValorDiaria.ToString("C")}" +
$" - Total à pagar: {reserva.CalcularValorDiaria().ToString("C")}");
Console.WriteLine($"- Data da saída: {dataAtual}\n");
