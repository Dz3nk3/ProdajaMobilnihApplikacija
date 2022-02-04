using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProdajaMobilnihAplikacija.WebAPI.Migrations
{
    public partial class migi06 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drzava",
                columns: table => new
                {
                    DrzavaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Oznaka = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drzava", x => x.DrzavaID);
                });

            migrationBuilder.CreateTable(
                name: "Fakultet",
                columns: table => new
                {
                    FakultetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "varchar(55)", unicode: false, maxLength: 55, nullable: true),
                    Univerzitet = table.Column<string>(type: "varchar(55)", unicode: false, maxLength: 55, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fakultet", x => x.FakultetID);
                });

            migrationBuilder.CreateTable(
                name: "Kartica",
                columns: table => new
                {
                    KarticaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojKartice = table.Column<string>(type: "varchar(55)", unicode: false, maxLength: 55, nullable: true),
                    Broj = table.Column<string>(type: "varchar(55)", unicode: false, maxLength: 55, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kartica", x => x.KarticaID);
                });

            migrationBuilder.CreateTable(
                name: "Kategorija",
                columns: table => new
                {
                    KategorijaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Oznaka = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Opis = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorija", x => x.KategorijaID);
                });

            migrationBuilder.CreateTable(
                name: "KorisnickiNalog",
                columns: table => new
                {
                    KorisnickiNalogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipKorisnickogNaloga = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KorisnickiNalog", x => x.KorisnickiNalogID);
                });

            migrationBuilder.CreateTable(
                name: "Ocjena",
                columns: table => new
                {
                    OcjenaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ocjena = table.Column<int>(type: "int", nullable: true),
                    Komentar = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ocjena", x => x.OcjenaID);
                });

            migrationBuilder.CreateTable(
                name: "Racun",
                columns: table => new
                {
                    RacunID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Datum = table.Column<DateTime>(type: "datetime", nullable: true),
                    Cijena = table.Column<double>(type: "float", nullable: true),
                    Kolicina = table.Column<int>(type: "int", nullable: true),
                    NacinPlacanja = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racun", x => x.RacunID);
                });

            migrationBuilder.CreateTable(
                name: "Grad",
                columns: table => new
                {
                    GradID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    DrzavaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grad", x => x.GradID);
                    table.ForeignKey(
                        name: "FK_Grad_Drzava_DrzavaID",
                        column: x => x.DrzavaID,
                        principalTable: "Drzava",
                        principalColumn: "DrzavaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Softver",
                columns: table => new
                {
                    SoftverID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Verzija = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Cijena = table.Column<double>(type: "float", nullable: true),
                    KategorijaID = table.Column<int>(type: "int", nullable: true),
                    SlikaThumb = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    PositiveDifferent = table.Column<double>(type: "float", nullable: true),
                    Color = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Softver", x => x.SoftverID);
                    table.ForeignKey(
                        name: "FK_Softver_Kategorija_KategorijaID",
                        column: x => x.KategorijaID,
                        principalTable: "Kategorija",
                        principalColumn: "KategorijaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Klijent",
                columns: table => new
                {
                    KlijentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    Prezime = table.Column<string>(type: "varchar(60)", unicode: false, maxLength: 60, nullable: true),
                    BrojTel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Adresa = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Datum_rodjenja = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    GradID = table.Column<int>(type: "int", nullable: true),
                    KarticaID = table.Column<int>(type: "int", nullable: true),
                    LozinkaHash = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    LozinkaSalt = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    KorisnickoIme = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    SlikaThumb = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klijent", x => x.KlijentID);
                    table.ForeignKey(
                        name: "FK_Klijent_Grad_GradID",
                        column: x => x.GradID,
                        principalTable: "Grad",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Klijent_Kartica_KarticaID",
                        column: x => x.KarticaID,
                        principalTable: "Kartica",
                        principalColumn: "KarticaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Zaposlenik",
                columns: table => new
                {
                    ZaposlenikID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Prezime = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Kontakt_br = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    Datum_rodjenja = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Spol = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    LozinkaHash = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    LozinkaSalt = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    KorisnickoIme = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Aktivan = table.Column<bool>(type: "bit", nullable: true),
                    GradID = table.Column<int>(type: "int", nullable: true),
                    FakultetID = table.Column<int>(type: "int", nullable: true),
                    KorisnickiNalogID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zaposlenik", x => x.ZaposlenikID);
                    table.ForeignKey(
                        name: "FK_Zaposlenik_Fakultet_FakultetID",
                        column: x => x.FakultetID,
                        principalTable: "Fakultet",
                        principalColumn: "FakultetID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Zaposlenik_Grad_GradID",
                        column: x => x.GradID,
                        principalTable: "Grad",
                        principalColumn: "GradID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Zaposlenik_KorisnickiNalog_KorisnickiNalogID",
                        column: x => x.KorisnickiNalogID,
                        principalTable: "KorisnickiNalog",
                        principalColumn: "KorisnickiNalogID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MojSoftver",
                columns: table => new
                {
                    MojSoftverID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ocjena = table.Column<int>(type: "int", nullable: true),
                    Komentar = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    KlijentID = table.Column<int>(type: "int", nullable: true),
                    RacunID = table.Column<int>(type: "int", nullable: true),
                    SoftverID = table.Column<int>(type: "int", nullable: true),
                    OcjenaID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MojSoftver", x => x.MojSoftverID);
                    table.ForeignKey(
                        name: "FK_MojSoftver_Klijent_KlijentID",
                        column: x => x.KlijentID,
                        principalTable: "Klijent",
                        principalColumn: "KlijentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MojSoftver_Ocjena_OcjenaID",
                        column: x => x.OcjenaID,
                        principalTable: "Ocjena",
                        principalColumn: "OcjenaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MojSoftver_Racun_RacunID",
                        column: x => x.RacunID,
                        principalTable: "Racun",
                        principalColumn: "RacunID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MojSoftver_Softver_SoftverID",
                        column: x => x.SoftverID,
                        principalTable: "Softver",
                        principalColumn: "SoftverID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Analiza",
                columns: table => new
                {
                    AnalizaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Datum_analize = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    KlijentID = table.Column<int>(type: "int", nullable: true),
                    ZaposlenikID = table.Column<int>(type: "int", nullable: true),
                    SoftverID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Analiza", x => x.AnalizaID);
                    table.ForeignKey(
                        name: "FK_Analiza_Klijent_KlijentID",
                        column: x => x.KlijentID,
                        principalTable: "Klijent",
                        principalColumn: "KlijentID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Analiza_Softver_SoftverID",
                        column: x => x.SoftverID,
                        principalTable: "Softver",
                        principalColumn: "SoftverID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Analiza_Zaposlenik_ZaposlenikID",
                        column: x => x.ZaposlenikID,
                        principalTable: "Zaposlenik",
                        principalColumn: "ZaposlenikID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Analiza_KlijentID",
                table: "Analiza",
                column: "KlijentID");

            migrationBuilder.CreateIndex(
                name: "IX_Analiza_SoftverID",
                table: "Analiza",
                column: "SoftverID");

            migrationBuilder.CreateIndex(
                name: "IX_Analiza_ZaposlenikID",
                table: "Analiza",
                column: "ZaposlenikID");

            migrationBuilder.CreateIndex(
                name: "IX_Grad_DrzavaID",
                table: "Grad",
                column: "DrzavaID");

            migrationBuilder.CreateIndex(
                name: "IX_Klijent_GradID",
                table: "Klijent",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Klijent_KarticaID",
                table: "Klijent",
                column: "KarticaID");

            migrationBuilder.CreateIndex(
                name: "IX_MojSoftver_KlijentID",
                table: "MojSoftver",
                column: "KlijentID");

            migrationBuilder.CreateIndex(
                name: "IX_MojSoftver_OcjenaID",
                table: "MojSoftver",
                column: "OcjenaID");

            migrationBuilder.CreateIndex(
                name: "IX_MojSoftver_RacunID",
                table: "MojSoftver",
                column: "RacunID");

            migrationBuilder.CreateIndex(
                name: "IX_MojSoftver_SoftverID",
                table: "MojSoftver",
                column: "SoftverID");

            migrationBuilder.CreateIndex(
                name: "IX_Softver_KategorijaID",
                table: "Softver",
                column: "KategorijaID");

            migrationBuilder.CreateIndex(
                name: "IX_Zaposlenik_FakultetID",
                table: "Zaposlenik",
                column: "FakultetID");

            migrationBuilder.CreateIndex(
                name: "IX_Zaposlenik_GradID",
                table: "Zaposlenik",
                column: "GradID");

            migrationBuilder.CreateIndex(
                name: "IX_Zaposlenik_KorisnickiNalogID",
                table: "Zaposlenik",
                column: "KorisnickiNalogID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Analiza");

            migrationBuilder.DropTable(
                name: "MojSoftver");

            migrationBuilder.DropTable(
                name: "Zaposlenik");

            migrationBuilder.DropTable(
                name: "Klijent");

            migrationBuilder.DropTable(
                name: "Ocjena");

            migrationBuilder.DropTable(
                name: "Racun");

            migrationBuilder.DropTable(
                name: "Softver");

            migrationBuilder.DropTable(
                name: "Fakultet");

            migrationBuilder.DropTable(
                name: "KorisnickiNalog");

            migrationBuilder.DropTable(
                name: "Grad");

            migrationBuilder.DropTable(
                name: "Kartica");

            migrationBuilder.DropTable(
                name: "Kategorija");

            migrationBuilder.DropTable(
                name: "Drzava");
        }
    }
}
