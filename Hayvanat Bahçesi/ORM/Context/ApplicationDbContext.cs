using Hayvanat_Bahçesi.ORM.Entity;
using Hayvanat_Bahçesi.ORM.Entity.ConditionalMapping;
using Hayvanat_Bahçesi.ORM.Entity.EntitySplitting;
using Hayvanat_Bahçesi.ORM.Entity.ManyToMany;
using Hayvanat_Bahçesi.ORM.Entity.TableSplitting;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hayvanat_Bahçesi.ORM.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
            Database.Connection.ConnectionString = @"Server=.;Database=Zoo;uid=sa;pwd=sa123";
        }
        public DbSet<AppUser> Users { get; set; } 
        public DbSet<Entity.ManyToMany.Animal> Animals { get; set; } 
        public DbSet<Zookeeper> Zookeepers { get; set; } 
        public DbSet<Veterinary> Veterinaries { get; set; } 
        public DbSet<Employee> Employees { get; set; } 
        public DbSet<Cage> Cages { get; set; }
        public DbSet<Animal_Baby> Animal_Babies { get; set; }
        public DbSet<Visitor> Visitors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Entity.EntitySplitting.AppUser>()
                   .Map(map =>
                   {
                       map.Properties(u => new
                       {
                           u.Id,
                           u.Username,
                           u.Password,
                       });

                       map.ToTable("UserAccountInfo");
                   })
                   .Map(map =>
                   {
                       map.Properties(u2 => new
                       {
                           u2.Id,
                           u2.ContactNumber,
                           u2.Address
                       });

                       map.ToTable("UserContactInfo");
                   });

            modelBuilder.Entity<Entity.TableSplitting.Employee>()
                .HasMany(t => t.AppUsers)
                .WithMany(t => t.Employees)
                .Map(map =>
                {
                    map.ToTable("EmployeeAppUsers");
                    map.MapLeftKey("EmployeeID");
                    map.MapRightKey("AppUsersID");
                });

            modelBuilder.Entity<Entity.TableSplitting.Employee>()
                .HasMany(t => t.Veterinaries)
                .WithMany(t => t.Employees)
                .Map(map =>
                {
                    map.ToTable("EmployeeVeterinaries");
                    map.MapLeftKey("EmployeeID");
                    map.MapRightKey("VeterinariesID");
                });

            modelBuilder.Entity<Entity.TableSplitting.Employee>()
               .HasMany(t => t.Zookeepers)
               .WithMany(t => t.Employees)
               .Map(map =>
               {
                   map.ToTable("EmployeeZookeepers");
                   map.MapLeftKey("EmployeeID");
                   map.MapRightKey("ZookeepersID");
               });

            modelBuilder.Entity<Entity.ManyToMany.Animal>()
                .HasMany(t => t.Veterinaries)
                .WithMany(t => t.Animals)
                .Map(map =>
                {
                    map.ToTable("AnimalVeterinaries");
                    map.MapLeftKey("AnimalID");
                    map.MapRightKey("VeterinariesID");
                });

            modelBuilder.Entity<Entity.ManyToMany.Animal>()
                .HasMany(t => t.Zookeepers)
                .WithMany(t => t.Animals)
                .Map(map =>
                {
                    map.ToTable("AnimalZookeepers");
                    map.MapLeftKey("AnimalID");
                    map.MapRightKey("ZookeepersID");
                });

            modelBuilder.Entity<Entity.ManyToMany.Animal>()
                .HasMany(t => t.Cages)
                .WithMany(t => t.Animals)
                .Map(map =>
                {
                    map.ToTable("AnimalCages");
                    map.MapLeftKey("AnimalID");
                    map.MapRightKey("CageID");
                });

            modelBuilder.Entity<Entity.ManyToMany.Animal>()
                .HasMany(t => t.Animal_Babies)
                .WithMany(t => t.Animals)
                .Map(map =>
                {
                   map.ToTable("Animals_Babies");
                   map.MapLeftKey("AnimalID");
                   map.MapRightKey("AnimalBabyID");
                });

            modelBuilder.Entity<Entity.TableSplitting.Employee>()
                .HasKey(k => k.EmployeeID)
                .ToTable("Employees");

            modelBuilder.Entity<EmployeeContactDetail>()
                .HasKey(k => k.EmployeeID)
                .ToTable("Employees");

            modelBuilder.Entity<Entity.TableSplitting.Employee>()
                .HasRequired(x => x.EmployeeContactDetail)
                .WithRequiredPrincipal(y => y.Employee);

            base.OnModelCreating(modelBuilder);

        }

    }
}
