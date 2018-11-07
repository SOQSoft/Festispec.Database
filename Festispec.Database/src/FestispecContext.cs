﻿using System;
using System.Collections.Generic;
using System.Text;
using Festispec.Domain;
using Festispec.Domain.src;
using Microsoft.EntityFrameworkCore;

namespace Festispec.Database
{
    class FestispecContext : DbContext
    {
		//public DbSet<Inspection> Inspections { get; set; }
		//public DbSet<Employee> Employees { get; set; }
		//public DbSet<Role> Roles { get; set; }
		//public DbSet<Customer> Customers { get; set; }
		//public DbSet<Application> Applications { get; set; }

		public DbSet<Form> Forms { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Server=.;Database=Festispec;Trusted_Connection=True;");
		}
	}
}
