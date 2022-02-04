using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace ProdajaMobilnihAplikacija.WebAPI.Database
{
    public partial class Prodaja_Mobilnog_SoftveraContext : DbContext
    {
        public Prodaja_Mobilnog_SoftveraContext()
        {
        }

        public Prodaja_Mobilnog_SoftveraContext(DbContextOptions<Prodaja_Mobilnog_SoftveraContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Drzava> Drzavas { get; set; }
        public virtual DbSet<Fakultet> Fakultets { get; set; }
        public virtual DbSet<Grad> Grads { get; set; }
        public virtual DbSet<Kartica> Karticas { get; set; }
        public virtual DbSet<Kategorija> Kategorijas { get; set; }
        public virtual DbSet<Klijent> Klijents { get; set; }
        public virtual DbSet<KorisnickiNalog> KorisnickiNalogs { get; set; }
        public virtual DbSet<MojSoftver> MojSoftvers { get; set; }
        public virtual DbSet<Ocjena> Ocjenas { get; set; }
        public virtual DbSet<Racun> Racuns { get; set; }
        public virtual DbSet<Softver> Softvers { get; set; }
        public virtual DbSet<Zaposlenik> Zaposleniks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=Prodaja_Mobilnog_Softvera;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Drzava>(entity =>
            {
                entity.ToTable("Drzava");

                entity.Property(e => e.DrzavaId).HasColumnName("DrzavaID");

                entity.Property(e => e.Naziv)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Oznaka)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fakultet>(entity =>
            {
                entity.ToTable("Fakultet");

                entity.Property(e => e.FakultetId).HasColumnName("FakultetID");

                entity.Property(e => e.Naziv)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.Univerzitet)
                    .HasMaxLength(55)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Grad>(entity =>
            {
                entity.ToTable("Grad");

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.Property(e => e.DrzavaId).HasColumnName("DrzavaID");

                entity.Property(e => e.Naziv)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Drzava)
                    .WithMany(p => p.Grads)
                    .HasForeignKey(d => d.DrzavaId)
                    .HasConstraintName("FK__Grad__DrzavaID__267ABA7A");
            });

            modelBuilder.Entity<Kartica>(entity =>
            {
                entity.ToTable("Kartica");

                entity.Property(e => e.KarticaId).HasColumnName("KarticaID");

                entity.Property(e => e.Broj)
                    .HasMaxLength(55)
                    .IsUnicode(false);

                entity.Property(e => e.BrojKartice)
                    .HasMaxLength(55)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Kategorija>(entity =>
            {
                entity.ToTable("Kategorija");

                entity.Property(e => e.KategorijaId).HasColumnName("KategorijaID");

                entity.Property(e => e.Naziv)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Opis)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Oznaka)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Klijent>(entity =>
            {
                entity.ToTable("Klijent");

                entity.Property(e => e.KlijentId).HasColumnName("KlijentID");

                entity.Property(e => e.Adresa)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BrojTel)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DatumRodjenja)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Datum_rodjenja");

                entity.Property(e => e.Email)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.Property(e => e.Ime)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.KarticaId).HasColumnName("KarticaID");

                entity.Property(e => e.KorisnickoIme)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LozinkaHash)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.LozinkaSalt)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Prezime)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Klijents)
                    .HasForeignKey(d => d.GradId)
                    .HasConstraintName("FK__Klijent__GradID__30F848ED");

                entity.HasOne(d => d.Kartica)
                    .WithMany(p => p.Klijents)
                    .HasForeignKey(d => d.KarticaId)
                    .HasConstraintName("FK__Klijent__Kartica__31EC6D26");
            });

            modelBuilder.Entity<KorisnickiNalog>(entity =>
            {
                entity.ToTable("KorisnickiNalog");

                entity.Property(e => e.KorisnickiNalogId).HasColumnName("KorisnickiNalogID");

                entity.Property(e => e.TipKorisnickogNaloga)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MojSoftver>(entity =>
            {
                entity.ToTable("MojSoftver");

                entity.Property(e => e.MojSoftverId).HasColumnName("MojSoftverID");

                entity.Property(e => e.Datum)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.KlijentId).HasColumnName("KlijentID");

                entity.Property(e => e.Komentar).HasMaxLength(255);

                entity.Property(e => e.OcjenaId).HasColumnName("OcjenaID");

                entity.Property(e => e.RacunId).HasColumnName("RacunID");

                entity.Property(e => e.SoftverId).HasColumnName("SoftverID");

                entity.Property(e => e.ZaposlenikId).HasColumnName("ZaposlenikID");

                entity.HasOne(d => d.Klijent)
                    .WithMany(p => p.MojSoftvers)
                    .HasForeignKey(d => d.KlijentId)
                    .HasConstraintName("FK__MojSoftve__Klije__412EB0B6");

                entity.HasOne(d => d.OcjenaNavigation)
                    .WithMany(p => p.MojSoftvers)
                    .HasForeignKey(d => d.OcjenaId)
                    .HasConstraintName("FK__MojSoftve__Ocjen__440B1D61");

                entity.HasOne(d => d.Racun)
                    .WithMany(p => p.MojSoftvers)
                    .HasForeignKey(d => d.RacunId)
                    .HasConstraintName("FK__MojSoftve__Racun__4222D4EF");

                entity.HasOne(d => d.Softver)
                    .WithMany(p => p.MojSoftvers)
                    .HasForeignKey(d => d.SoftverId)
                    .HasConstraintName("FK__MojSoftve__Softv__4316F928");

                entity.HasOne(d => d.Zaposlenik)
                    .WithMany(p => p.MojSoftvers)
                    .HasForeignKey(d => d.ZaposlenikId)
                    .HasConstraintName("FK__MojSoftve__Zapos__44FF419A");
            });

            modelBuilder.Entity<Ocjena>(entity =>
            {
                entity.ToTable("Ocjena");

                entity.Property(e => e.OcjenaId).HasColumnName("OcjenaID");

                entity.Property(e => e.Komentar).HasMaxLength(255);

                entity.Property(e => e.Ocjena1).HasColumnName("Ocjena");
            });

            modelBuilder.Entity<Racun>(entity =>
            {
                entity.ToTable("Racun");

                entity.Property(e => e.RacunId).HasColumnName("RacunID");

                entity.Property(e => e.Datum).HasColumnType("datetime");

                entity.Property(e => e.NacinPlacanja).HasMaxLength(50);
            });

            modelBuilder.Entity<Softver>(entity =>
            {
                entity.ToTable("Softver");

                entity.Property(e => e.SoftverId).HasColumnName("SoftverID");

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KategorijaId).HasColumnName("KategorijaID");

                entity.Property(e => e.Naziv)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Verzija)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ZaposlenikId).HasColumnName("ZaposlenikID");

                entity.HasOne(d => d.Kategorija)
                    .WithMany(p => p.Softvers)
                    .HasForeignKey(d => d.KategorijaId)
                    .HasConstraintName("FK__Softver__Kategor__398D8EEE");

                entity.HasOne(d => d.Zaposlenik)
                    .WithMany(p => p.Softvers)
                    .HasForeignKey(d => d.ZaposlenikId)
                    .HasConstraintName("FK__Softver__Zaposle__3A81B327");
            });

            modelBuilder.Entity<Zaposlenik>(entity =>
            {
                entity.ToTable("Zaposlenik");

                entity.Property(e => e.ZaposlenikId).HasColumnName("ZaposlenikID");

                entity.Property(e => e.DatumRodjenja)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Datum_rodjenja");

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.FakultetId).HasColumnName("FakultetID");

                entity.Property(e => e.GradId).HasColumnName("GradID");

                entity.Property(e => e.Ime).HasMaxLength(60);

                entity.Property(e => e.KontaktBr)
                    .HasMaxLength(16)
                    .HasColumnName("Kontakt_br");

                entity.Property(e => e.KorisnickiNalogId).HasColumnName("KorisnickiNalogID");

                entity.Property(e => e.KorisnickoIme).HasMaxLength(50);

                entity.Property(e => e.LozinkaHash).HasMaxLength(255);

                entity.Property(e => e.LozinkaSalt).HasMaxLength(255);

                entity.Property(e => e.Prezime).HasMaxLength(60);

                entity.Property(e => e.Spol).HasMaxLength(10);

                entity.HasOne(d => d.Fakultet)
                    .WithMany(p => p.Zaposleniks)
                    .HasForeignKey(d => d.FakultetId)
                    .HasConstraintName("FK__Zaposleni__Fakul__35BCFE0A");

                entity.HasOne(d => d.Grad)
                    .WithMany(p => p.Zaposleniks)
                    .HasForeignKey(d => d.GradId)
                    .HasConstraintName("FK__Zaposleni__GradI__34C8D9D1");

                entity.HasOne(d => d.KorisnickiNalog)
                    .WithMany(p => p.Zaposleniks)
                    .HasForeignKey(d => d.KorisnickiNalogId)
                    .HasConstraintName("FK__Zaposleni__Koris__36B12243");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
