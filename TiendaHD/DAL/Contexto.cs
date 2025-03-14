﻿using Microsoft.EntityFrameworkCore;
using TiendaHD.Models;

namespace TiendaHD.DAL;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options)
    {
        
    }

    public DbSet<Financiamientos> Financiamientos { get; set; }
    public DbSet<GastosADM> GastosADM { get; set; }
    public DbSet<Empleados> Empleados { get; set; }
    public DbSet<GastosMenores> GastosMenores { get; set; }
    public DbSet<Ventas> Ventas { get; set; }

	public DbSet<Compras> Compras { get; set; }

    public DbSet<Poblacion> Poblacion {  get; set; }

    public DbSet<CostoVentas> CostoVentas { get; set; }

}
