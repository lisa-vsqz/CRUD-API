using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_PRODUCTOS.Migrations
{
    /// <inheritdoc />
    public partial class apiproductos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "IdProducto", "Cantidad", "Descripcion", "Nombre" },
                values: new object[] { 1, 12, "", "Producto" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: 1);
        }
    }
}
