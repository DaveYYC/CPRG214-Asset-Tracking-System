using CPRG214.AssetTrackingSystem.Domain;
using Microsoft.EntityFrameworkCore;

namespace CPRG214.AssetTrackingSystem.Data
{
    public class AssetContext : DbContext
    {
        public AssetContext() : base() {}
        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetType> AssetTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // change the connection string here for your computer
            optionsBuilder.UseSqlServer(@"Server=DAVES-LAPTOP;
                                        Database=CompanyAssets;
                                        Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // seed data created here
            modelBuilder.Entity<Asset>().HasData(
                new Asset 
                { 
                    Id = 1, 
                    TagNumber = "1", 
                    AssetTypeId = 1, 
                    Manufacturer = "Dell", 
                    Model = "Inspiron", 
                    SerialNumber="1001", 
                    Description="Dell Inspiron Desktop Computer"
                },
                new Asset 
                { Id = 2, 
                    TagNumber = "2", 
                    AssetTypeId = 1, 
                    Manufacturer = "HP", 
                    Model = "Pavillion", 
                    SerialNumber = "1002", 
                    Description = "HP Pavillion Desktop Computer" 
                },
                new Asset 
                { Id = 3, 
                    TagNumber = "3", 
                    AssetTypeId = 1, 
                    Manufacturer = "Acer", 
                    Model = "Aspire", 
                    SerialNumber = "1003", 
                    Description = "Acer Aspire Desktop Computer" 
                },
                new Asset 
                { Id = 4, 
                    TagNumber = "4", 
                    AssetTypeId = 2, 
                    Manufacturer = "Acer", 
                    Model = "SB220Q", 
                    SerialNumber = "1004", 
                    Description = "Acer Monitor" 
                },
                new Asset 
                { Id = 5, 
                    TagNumber = "5", 
                    AssetTypeId = 2, 
                    Manufacturer = "LG", 
                    Model = "27mp57vq", 
                    SerialNumber = "1005", 
                    Description = "LG Monitor" 
                },
                new Asset 
                { Id = 6, 
                    TagNumber = "6", 
                    AssetTypeId = 2, 
                    Manufacturer = "HP", 
                    Model = "19-2113w", 
                    SerialNumber = "1006", 
                    Description = "HP Monitor" },
                new Asset 
                { Id = 7, 
                    TagNumber = "7", 
                    AssetTypeId = 3, 
                    Manufacturer = "Avaya", 
                    Model = "1408", 
                    SerialNumber = "1007", 
                    Description = "Avaya Phone" 
                },
                new Asset 
                { Id = 8, 
                    TagNumber = "8", 
                    AssetTypeId = 3,
                    Manufacturer = "Polycom", 
                    Model = "vx411", 
                    SerialNumber = "1008", 
                    Description = "Polycom Phone" 
                },
                new Asset 
                { Id = 9, 
                    TagNumber = "9", 
                    AssetTypeId = 3, 
                    Manufacturer = "Cisco", 
                    Model = "78741", 
                    SerialNumber = "1009", 
                    Description = "Cisco Phone" 
                }
                );

            modelBuilder.Entity<AssetType>().HasData(
                new AssetType { Id = 1, Name = "Desktop Computer" },
                new AssetType { Id = 2, Name = "Monitor" },
                new AssetType { Id = 3, Name = "Phone" }
                );
        } 
    }
}
