using SCREENSOUND_BASE.Banco;
using SCREENSOUND_BASE.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCREENSOUND_BASE.Menu
{
    internal class MenuSair : Menu
    {
        public override void Executar(DAL<Artista> artistaDAL)
        {
            Console.WriteLine("Tchau tchau :)");
        }
    }
}
