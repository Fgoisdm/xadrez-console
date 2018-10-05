﻿using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {

            //Criando o Tabuleiro do jogo de xadrez
            Tabuleiro tab = new Tabuleiro(8, 8);

            //Testando população do rei e torre manualmente
            tab.colocaPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
            tab.colocaPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            tab.colocaPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));

            //Imprimindo o Tabuleiro já com as peças
            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
