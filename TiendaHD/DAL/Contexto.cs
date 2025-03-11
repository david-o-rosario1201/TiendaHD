﻿using Microsoft.EntityFrameworkCore;
using TiendaHD.Models;

namespace TiendaHD.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {
        
    }

    public DbSet<Financiamientos> Financiamientos { get; set; }
}
