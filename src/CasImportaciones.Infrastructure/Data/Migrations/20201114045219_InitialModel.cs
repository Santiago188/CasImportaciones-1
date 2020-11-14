using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace CasImportaciones.Infrastructure.Data.Migrations
{
    public partial class InitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    IdCategoria = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(maxLength: 80, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.IdCategoria);
                });

            migrationBuilder.CreateTable(
                name: "Inventario",
                columns: table => new
                {
                    IdInventario = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Referencia = table.Column<string>(maxLength: 15, nullable: true),
                    Cantidad = table.Column<string>(nullable: true),
                    Fecha = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventario", x => x.IdInventario);
                });

            migrationBuilder.CreateTable(
                name: "OrdenCompra",
                columns: table => new
                {
                    IdCompra = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Referencia = table.Column<string>(nullable: true),
                    Cantidad = table.Column<int>(nullable: false),
                    FechaCompra = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenCompra", x => x.IdCompra);
                });

            migrationBuilder.CreateTable(
                name: "OrdenVenta",
                columns: table => new
                {
                    IdVenta = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FechaVenta = table.Column<DateTime>(nullable: false),
                    Cantidad = table.Column<int>(maxLength: 80, nullable: false),
                    ValorTotal = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenVenta", x => x.IdVenta);
                });

            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    IdUsuario = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Cedula = table.Column<int>(nullable: false),
                    PrimerNombre = table.Column<string>(maxLength: 40, nullable: true),
                    SegundoNombre = table.Column<string>(maxLength: 40, nullable: true),
                    PrimerApellido = table.Column<string>(maxLength: 40, nullable: true),
                    SegundoApellido = table.Column<string>(maxLength: 40, nullable: true),
                    Correo = table.Column<string>(maxLength: 30, nullable: true),
                    Telefono = table.Column<double>(nullable: false),
                    Direccion = table.Column<double>(maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.IdUsuario);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    Refertencia = table.Column<string>(maxLength: 15, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 40, nullable: true),
                    Precio = table.Column<double>(nullable: false),
                    Marca = table.Column<string>(maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.Refertencia);
                });

            migrationBuilder.CreateTable(
                name: "Proveedor",
                columns: table => new
                {
                    IdProveedor = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    NombreProveedor = table.Column<string>(maxLength: 40, nullable: true),
                    Direccion = table.Column<string>(maxLength: 25, nullable: true),
                    Telefono = table.Column<double>(nullable: false),
                    Ciudad = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proveedor", x => x.IdProveedor);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    IdRol = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.IdRol);
                });

            migrationBuilder.CreateTable(
                name: "TipoIdentificacion",
                columns: table => new
                {
                    IdTipo = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Descripcion = table.Column<string>(maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoIdentificacion", x => x.IdTipo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropTable(
                name: "Inventario");

            migrationBuilder.DropTable(
                name: "OrdenCompra");

            migrationBuilder.DropTable(
                name: "OrdenVenta");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Producto");

            migrationBuilder.DropTable(
                name: "Proveedor");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "TipoIdentificacion");
        }
    }
}
