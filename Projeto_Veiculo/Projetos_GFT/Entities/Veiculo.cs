using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Veiculo.Entities
{
    class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        public string Km { get; set; }
        public bool IsLigado { get; set; }
        public int LitrosCombustivel { get; set; }
        public int Velocidade { get; set; }
        public double Preco { get; set; }

        public Veiculo()
        {

        }

        public Veiculo(string marca, string modelo, string placa, string cor, string km, bool isLigado, int litrosCombustivel, int velocidade, double preco)
        {
            Marca = marca;
            Modelo = modelo;
            Placa = placa;
            Cor = cor;
            Km = km;
            IsLigado = isLigado;
            LitrosCombustivel = litrosCombustivel;
            Velocidade = velocidade;
            Preco = preco;
        }

        public void Acelerar()
        {
            if (IsLigado)
            {
                Velocidade += 20;
            }
            else
            {
                Console.WriteLine("Ligue o carro primeiro!");
            }
        }

        public void Abastecer(int qtd)
        {
            if (LitrosCombustivel + qtd > 60)
            {
                var excesso = 60 - LitrosCombustivel;
                Console.WriteLine("Quantidade inserida excede o limite do tanque, permitido apenas a quantidade: " + excesso);
            }
            else
            {
                LitrosCombustivel += qtd;
            }
        }
        public void Frear()
        {
            if (Velocidade < 20)
            {
                Velocidade = 0;
            }
            else
            {
                Velocidade -= 20;
            }

        }
        public void Pintar(string cor)
        {
            Cor = cor;
        }
        public void Ligar()
        {
            if (!IsLigado)
            {
                IsLigado = true;
                Console.WriteLine("Carro ligado com sucesso!");
            }
            else
            {
                Console.WriteLine("Carro já esta ligado!");
            }
        }
        public void Desligar()
        {
            if (IsLigado && Velocidade < 1)
            {
                IsLigado = false;
                Console.WriteLine("Carro desligado com sucesso!");
            }
            else if (Velocidade > 1)
            {
                Console.WriteLine("Veiculo não pode ser desligado, pois esta em movimento." + IsLigado);
            }
            else
            {
                Console.WriteLine("Veiculo já se se encontra desligado." + IsLigado);
            }
        }
        public override string ToString()
        {
            return "Marca: " + Marca + System.Environment.NewLine +
                    "Modelo: " + Modelo + System.Environment.NewLine +
                    "Placa: " + Placa + System.Environment.NewLine +
                    "Cor: " + Cor + System.Environment.NewLine +
                    "Km: " + Km + System.Environment.NewLine +
                    "Veiculo ligado: " + IsLigado + System.Environment.NewLine +
                    "Tanque: " + LitrosCombustivel + System.Environment.NewLine +
                    "Velocidade: " + Velocidade + System.Environment.NewLine +
                    "Preco: " + Preco + System.Environment.NewLine;
        }
    }
}
