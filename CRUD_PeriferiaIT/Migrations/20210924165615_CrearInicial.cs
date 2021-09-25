using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD_PeriferiaIT.Migrations
{
    public partial class CrearInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    EmpleadosID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(100)", nullable: true),
                    Apellido = table.Column<string>(type: "varchar(100)", nullable: true),
                    Identificacion = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.EmpleadosID);
                });

            migrationBuilder.CreateTable(
                name: "Viajes",
                columns: table => new
                {
                    ViajesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpleadosID = table.Column<int>(type: "int", nullable: false),
                    Origen = table.Column<string>(type: "varchar(100)", nullable: true),
                    Destino = table.Column<string>(type: "varchar(100)", nullable: true),
                    TiempoViaje = table.Column<float>(type: "float(1)", nullable: false),
                    NombrePasajero = table.Column<string>(type: "varchar(100)", nullable: true),
                    Vehiculo = table.Column<int>(type: "int", nullable: false),
                    HoraViaje = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Viajes", x => x.ViajesID);
                    table.ForeignKey(
                        name: "FK_Viajes_Empleados_EmpleadosID",
                        column: x => x.EmpleadosID,
                        principalTable: "Empleados",
                        principalColumn: "EmpleadosID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Viajes_EmpleadosID",
                table: "Viajes",
                column: "EmpleadosID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Viajes");

            migrationBuilder.DropTable(
                name: "Empleados");
        }
    }
}
