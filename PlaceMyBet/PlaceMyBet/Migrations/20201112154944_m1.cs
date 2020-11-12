using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PlaceMyBet.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    EventoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    equipoLocal = table.Column<string>(nullable: true),
                    equipoVisitante = table.Column<string>(nullable: true),
                    fecha = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.EventoId);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Email = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: true),
                    Edad = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                });

            migrationBuilder.CreateTable(
                name: "Mercados",
                columns: table => new
                {
                    MercadoId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tipoMercado = table.Column<double>(nullable: false),
                    infocuotaOver = table.Column<double>(nullable: false),
                    infocuotaUnder = table.Column<double>(nullable: false),
                    dineroapostadoOver = table.Column<double>(nullable: false),
                    dineroapostadoUnder = table.Column<double>(nullable: false),
                    EventoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mercados", x => x.MercadoId);
                    table.ForeignKey(
                        name: "FK_Mercados_Eventos_EventoId",
                        column: x => x.EventoId,
                        principalTable: "Eventos",
                        principalColumn: "EventoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CBancaria",
                columns: table => new
                {
                    CBancariaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    saldoBanco = table.Column<double>(nullable: false),
                    nombreBanco = table.Column<string>(nullable: true),
                    numtarCredito = table.Column<string>(nullable: true),
                    UsuarioId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CBancaria", x => x.CBancariaId);
                    table.ForeignKey(
                        name: "FK_CBancaria_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Apuestas",
                columns: table => new
                {
                    ApuestaId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    tipoApuesta = table.Column<bool>(nullable: false),
                    cuota = table.Column<double>(nullable: false),
                    dineroApostado = table.Column<double>(nullable: false),
                    fecha = table.Column<string>(nullable: true),
                    MercadoId = table.Column<int>(nullable: false),
                    UsuarioId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apuestas", x => x.ApuestaId);
                    table.ForeignKey(
                        name: "FK_Apuestas_Mercados_MercadoId",
                        column: x => x.MercadoId,
                        principalTable: "Mercados",
                        principalColumn: "MercadoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Eventos",
                columns: new[] { "EventoId", "equipoLocal", "equipoVisitante", "fecha" },
                values: new object[] { 1, "FCBarcelona", "Real Madrid", "20/10/2020" });

            migrationBuilder.InsertData(
                table: "Usuario",
                columns: new[] { "UsuarioId", "Apellidos", "Edad", "Email", "Nombre" },
                values: new object[] { 1, "Juan", 26, "email123@gmail.com", "Illo" });

            migrationBuilder.InsertData(
                table: "CBancaria",
                columns: new[] { "CBancariaId", "UsuarioId", "nombreBanco", "numtarCredito", "saldoBanco" },
                values: new object[] { 1, 1, "Santander", "4599867523412345", 2599.0 });

            migrationBuilder.InsertData(
                table: "Mercados",
                columns: new[] { "MercadoId", "EventoId", "dineroapostadoOver", "dineroapostadoUnder", "infocuotaOver", "infocuotaUnder", "tipoMercado" },
                values: new object[] { 1, 1, 100.0, 50.0, 1.4299999999999999, 2.8500000000000001, 1.5 });

            migrationBuilder.InsertData(
                table: "Apuestas",
                columns: new[] { "ApuestaId", "MercadoId", "UsuarioId", "cuota", "dineroApostado", "fecha", "tipoApuesta" },
                values: new object[] { 1, 1, "1", 1.5, 100.0, "20/10/2020", true });

            migrationBuilder.CreateIndex(
                name: "IX_Apuestas_MercadoId",
                table: "Apuestas",
                column: "MercadoId");

            migrationBuilder.CreateIndex(
                name: "IX_CBancaria_UsuarioId",
                table: "CBancaria",
                column: "UsuarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mercados_EventoId",
                table: "Mercados",
                column: "EventoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apuestas");

            migrationBuilder.DropTable(
                name: "CBancaria");

            migrationBuilder.DropTable(
                name: "Mercados");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "Eventos");
        }
    }
}
