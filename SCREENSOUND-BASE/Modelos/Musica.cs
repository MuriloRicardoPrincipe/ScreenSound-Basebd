using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCREENSOUND_BASE.Modelos
{
    public class Musica
    {
        public Musica(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; set; }
        public int Id { get; set; }
        public int? AnoLancamento { get; set; }

        //Referenciando
        public virtual Artista Artista { get; set; }

        public void ExibirFichaTecnica()
        {
            Console.WriteLine($"Nome: {Nome}");

        }

        public override string ToString()
        {
            return @$"Id: {Id}
        Nome: {Nome}";
        }
    }
}
