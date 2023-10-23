using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API_PRODUCTOS.Migrations
{
    /// <inheritdoc />
    public partial class apiproductoss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: 1,
                column: "Descripcion",
                value: "xfgx");

            migrationBuilder.InsertData(
                table: "Producto",
                columns: new[] { "IdProducto", "Cantidad", "Descripcion", "Nombre" },
                values: new object[] { 2, 22, "utyr", "Producto" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Producto",
                keyColumn: "IdProducto",
                keyValue: 1,
                column: "Descripcion",
                value: "");
        }
    }
}
