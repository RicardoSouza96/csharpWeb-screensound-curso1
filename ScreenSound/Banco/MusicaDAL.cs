﻿using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco;

internal class MusicaDAL : DAL<Musica>
{
    private readonly ScreenSoundContext context;

    public MusicaDAL(ScreenSoundContext context)
    {
        this.context = context;
    }

    public override IEnumerable<Musica> Listar()
    {
        return context.Musica.ToList();
    }

    public override void Adicionar(Musica musica)
    {
        context.Musica.Add(musica);
        context.SaveChanges();
    }

    public override void Deletar(Musica musica)
    {
        context.Musica.Remove(musica);
        context.SaveChanges();
    }

    public override void Atualizar(Musica musica)
    {
        context.Musica.Update(musica);
        context.SaveChanges();
    }
}
