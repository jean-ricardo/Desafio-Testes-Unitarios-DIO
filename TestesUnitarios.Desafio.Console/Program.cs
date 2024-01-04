﻿using System;

namespace TestesUnitarios.Desafio.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var validacoesLista = new Services.ValidacoesLista();
            var validacoesString = new Services.ValidacoesString();

            // Uso da classe ValidacoesLista
            var lista = new System.Collections.Generic.List<int> { 5, -1, -8, 9 };
            var listaSemNegativos = validacoesLista.RemoverNumerosNegativos(lista);
            var contemNumero9 = validacoesLista.ListaContemDeterminadoNumero(lista, 9);
            var contemNumero10 = validacoesLista.ListaContemDeterminadoNumero(lista, 10);
            var listaMultiplicadaPor2 = validacoesLista.MultiplicarNumerosLista(lista, 2);
            var maiorNumero = validacoesLista.RetornarMaiorNumeroLista(lista);
            var menorNumero = validacoesLista.RetornarMenorNumeroLista(lista);

            // Uso da classe ValidacoesString
            var texto = "Esse é um texto qualquer";
            var quantidadeCaracteres = validacoesString.RetornarQuantidadeCaracteres(texto);
            var contemPalavra = validacoesString.ContemCaractere(texto, "qualquer");
            var naoContemPalavra = validacoesString.ContemCaractere(texto, "teste");
            var terminaComPalavra = validacoesString.TextoTerminaCom(texto, "qualquer");

            // Exemplos de impressões de resultados
            System.Console.WriteLine("Lista sem negativos: " + string.Join(", ", listaSemNegativos));
            System.Console.WriteLine("Contém o número 9 na lista: " + contemNumero9);
            System.Console.WriteLine("Contém o número 10 na lista: " + contemNumero10);
            System.Console.WriteLine("Lista multiplicada por 2: " + string.Join(", ", listaMultiplicadaPor2));
            System.Console.WriteLine("Maior número na lista: " + maiorNumero);
            System.Console.WriteLine("Menor número na lista: " + menorNumero);
            System.Console.WriteLine("Quantidade de caracteres no texto: " + quantidadeCaracteres);
            System.Console.WriteLine("Contém a palavra 'qualquer' no texto: " + contemPalavra);
            System.Console.WriteLine("Não contém a palavra 'teste' no texto: " + naoContemPalavra);
            System.Console.WriteLine("Texto termina com a palavra 'qualquer': " + terminaComPalavra);
        }
    }
}