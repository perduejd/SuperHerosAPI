using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperHerosApi.Migrations
{
    /// <summary>
    /// Represents the initial migration to create the 'SuperHeroes' table.
    /// </summary>
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        /// <summary>
        /// Applies changes to the database schema during the migration.
        /// </summary>
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.CreateTable(  // Creation of the 'SuperHeroes' table with specified columns and constraints.
                name: "SuperHeroes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"), 
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    
                    table.PrimaryKey("PK_SuperHeroes", x => x.Id); // Define the PK constraint for superheroes table.
                });
        }

        /// <inheritdoc />
        /// <summary>
        /// Reverts changes made during the Up migration, undoing the creation of the superheroes table.
        /// </summary>
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Drop the 'SuperHeroes' table to revert the changes made during the Up migration.
            migrationBuilder.DropTable(
                name: "SuperHeroes");
        }
    }
}