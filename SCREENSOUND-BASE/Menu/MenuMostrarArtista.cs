using SCREENSOUND_BASE.Banco;
using SCREENSOUND_BASE.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCREENSOUND_BASE.Menu
{
    internal class MenuMostrarArtistas : Menu
    {
        public override void Executar(DAL<Artista> artistaDAL)
        {
            base.Executar(artistaDAL);
            ExibirTituloDaOpcao("Exibindo todos os artistas registradas na nossa aplicação");

            foreach (var artista in artistaDAL.Listar())
            {
                Console.WriteLine($"Artista: {artista}");
            }

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
