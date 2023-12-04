using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SuperHerosApi.Data;

#nullable disable

namespace SuperHerosApi.Migrations
{ 
    [DbContext(typeof(DataContext))] // DataContextModel represents the model snapshot for Entity Framework migrations.

    partial class DataContextModel : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {

#pragma warning disable 612, 618 // Suppress warnings related to obsolete methods.

            
            modelBuilder 
                .HasAnnotation("ProductVersion", "7.0.3") 
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            
            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder); // Configure identity columns for SQL Server.

            
            modelBuilder.Entity("SuperHerosApi.Models.SuperHero", b => // Define the entity for the SuperHero model.
            {
                
                b.Property<int>("Id") // Configure the properties of the SuperHero entity.
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                // Configure identity column for the SuperHero entity.
                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                // Configure other properties of the SuperHero entity.
                b.Property<string>("FirstName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("LastName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<string>("Place")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                // Define the primary key for the SuperHero entity.
                b.HasKey("Id");

                // Specify the table name for the SuperHero entity.
                b.ToTable("SuperHeroes");
            });


#pragma warning restore 612, 618 // Restore warnings related to obsolete methods.
        }
    }
}
