﻿using SCREENSOUND_BASE.Banco;
using SCREENSOUND_BASE.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCREENSOUND_BASE.Menu
{
    internal class MenuMostrarMusicas : Menu
    {
        public override void Executar(DAL<Artista> artistaDAL)
        {
            base.Executar(artistaDAL);
            ExibirTituloDaOpcao("Exibir detalhes do artista");
            Console.Write("Digite o nome do artista que deseja conhecer melhor: ");
            string nomeDoArtista = Console.ReadLine()!;
            var artistaRecuperado = artistaDAL.RecuperarPor(a => a.Nome.Equals(nomeDoArtista));
            if (artistaRecuperado is not null)
            {
                Console.WriteLine("\nDiscografia:");
                artistaRecuperado.ExibirDiscografia();
                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"\nO artista {nomeDoArtista} não foi encontrado!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
