using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco;

internal class MusicaDAL
{
    private readonly ScreenSoundContext context;

    public MusicaDAL(ScreenSoundContext context)
    {
        this.context = context;
    }

    public IEnumerable<Musica> Listar()
    {
        return context.Musica.ToList();
    }

    public void Adicionar(Musica musica)
    {
        context.Musica.Add(musica);
        context.SaveChanges();
    }

    public void Deletar(Musica musica)
    {
        context.Musica.Remove(musica);
        context.SaveChanges();
    }
}
