﻿using Microsoft.EntityFrameworkCore;
using practic3.Models;


namespace practic3.Data
{
	public class AppDbContext :DbContext
	{
		public AppDbContext( DbContextOptions<AppDbContext> options ) : base( options ) { }

		public DbSet<Product> Products { get; set; }
	}
}
