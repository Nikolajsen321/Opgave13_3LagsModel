using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Dataacess.Model;

namespace Dataacess.Context
{
	internal class StudentContext : DbContext
	{
		public StudentContext()
		{ bool created = Database.EnsureCreated();
			if (created)
			{
				Debug.WriteLine("Database created");
			}
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=LAPTOP-CP8PKIBC\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=SSPI; TrustServerCertificate=true");
			optionsBuilder.LogTo(message =>Debug.WriteLine(message));

		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Student>().HasData(new Student[]
			{
				new Student{Navn ="Hans",StudieStart=new DateTime(2021,10,12),Alder = 20, StudentId=-1, StudieType=Student._StudieType.Ungdomudannelse},
				new Student{Navn ="Jens",StudieStart=new DateTime(2021,10,12),Alder = 20, StudentId=1, StudieType=Student._StudieType.Ungdomudannelse}
			});
			
		}

		public DbSet<Student> Students { get; set; }
		public DbSet<Hold> Holds { get; set; }





	}
}
