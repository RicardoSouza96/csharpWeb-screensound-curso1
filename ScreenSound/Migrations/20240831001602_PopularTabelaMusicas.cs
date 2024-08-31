using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopularTabelaMusicas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Musica", new string[] { "Nome", "AnoLancamento" }, new object[] { "Meu bem querer", 1980 });
            migrationBuilder.InsertData("Musica", new string[] { "Nome", "AnoLancamento" }, new object[] { "Rope", 2011 });
            migrationBuilder.InsertData("Musica", new string[] { "Nome", "AnoLancamento" }, new object[] { "Rope", 2011 });
            migrationBuilder.InsertData("Musica", new string[] { "Nome", "AnoLancamento" }, new object[] { "Fé na festa", 2010 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Artistas");
        }
    }
}
