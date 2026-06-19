using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace rw_fortia_prime_api.Entities;

public partial class FortiaDbContext : DbContext
{
    public FortiaDbContext()
    {
    }

    public FortiaDbContext(DbContextOptions<FortiaDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<RhPuesto> RhPuestos { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Data Source=10.128.0.2;Initial Catalog=BDFORTIA;Integrated Security=False;User Id=App2;Password=8Z2bpwvZ2pzpXV7Q;MultipleActiveResultSets=True;Connection Timeout=120000;TrustServerCertificate=True;");

//    protected override void OnModelCreating(ModelBuilder modelBuilder)
//    {
//        modelBuilder.UseCollation("SQL_Latin1_General_CP1_CI_AS");

//        modelBuilder.Entity<RhPuesto>(entity =>
//        {
//            entity.HasKey(e => new { e.ClaPuesto, e.ClaEmpresa });

//            entity.ToTable("RH_PUESTO", tb =>
//                {
//                    tb.HasTrigger("tD_RH_PUESTO");
//                    tb.HasTrigger("trUpd_RhPuestoxTabNiv");
//                    tb.HasTrigger("tr_RhPuesto_SincronizarVersion");
//                });

//            entity.Property(e => e.ClaPuesto).HasColumnName("CLA_PUESTO");
//            entity.Property(e => e.ClaEmpresa).HasColumnName("CLA_EMPRESA");
//            entity.Property(e => e.Alfanum1)
//                .HasMaxLength(18)
//                .IsUnicode(false)
//                .HasColumnName("ALFANUM1");
//            entity.Property(e => e.Alfanum2)
//                .HasMaxLength(18)
//                .IsUnicode(false)
//                .HasColumnName("ALFANUM2");
//            entity.Property(e => e.Alfanum3)
//                .HasMaxLength(18)
//                .IsUnicode(false)
//                .HasColumnName("ALFANUM3");
//            entity.Property(e => e.AplicaTodaUbi).HasColumnName("APLICA_TODA_UBI");
//            entity.Property(e => e.AreaOcupStps).HasColumnName("AREA_OCUP_STPS");
//            entity.Property(e => e.Auto)
//                .HasDefaultValue(0)
//                .HasColumnName("AUTO");
//            entity.Property(e => e.CambioResidencia).HasColumnName("CAMBIO_RESIDENCIA");
//            entity.Property(e => e.CambioResiedencia).HasColumnName("CAMBIO_RESIEDENCIA");
//            entity.Property(e => e.ClaDepto).HasColumnName("CLA_DEPTO");
//            entity.Property(e => e.ClaFrecuenciaViajar).HasColumnName("CLA_FRECUENCIA_VIAJAR");
//            entity.Property(e => e.ClaHorario).HasColumnName("CLA_HORARIO");
//            entity.Property(e => e.ClaNivelEstrucPto).HasColumnName("CLA_NIVEL_ESTRUC_PTO");
//            entity.Property(e => e.ClaOcupacion).HasColumnName("CLA_OCUPACION");
//            entity.Property(e => e.ClaPuestoPadre).HasColumnName("CLA_PUESTO_PADRE");
//            entity.Property(e => e.ClaRiesgo).HasColumnName("CLA_RIESGO");
//            entity.Property(e => e.ClaTabMercado).HasColumnName("CLA_TAB_MERCADO");
//            entity.Property(e => e.ClaTabulador).HasColumnName("CLA_TABULADOR");
//            entity.Property(e => e.ClaTabuladorInicial).HasColumnName("CLA_TABULADOR_INICIAL");
//            entity.Property(e => e.ClaUniNeg).HasColumnName("CLA_UNI_NEG");
//            entity.Property(e => e.CondEspErgonomica).HasColumnName("COND_ESP_ERGONOMICA");
//            entity.Property(e => e.CondEspTrabajo).HasColumnName("COND_ESP_TRABAJO");
//            entity.Property(e => e.CondicionEstres).HasColumnName("CONDICION_ESTRES");
//            entity.Property(e => e.ContactoExt)
//                .HasMaxLength(1000)
//                .IsUnicode(false)
//                .HasColumnName("CONTACTO_EXT");
//            entity.Property(e => e.ContactoInt)
//                .HasMaxLength(1000)
//                .IsUnicode(false)
//                .HasColumnName("CONTACTO_INT");
//            entity.Property(e => e.DescPuesto)
//                .HasMaxLength(1000)
//                .IsUnicode(false)
//                .HasColumnName("DESC_PUESTO");
//            entity.Property(e => e.DescPuestoIng)
//                .HasMaxLength(1000)
//                .IsUnicode(false)
//                .HasColumnName("DESC_PUESTO_ING");
//            entity.Property(e => e.Edad1).HasColumnName("EDAD1");
//            entity.Property(e => e.Edad2).HasColumnName("EDAD2");
//            entity.Property(e => e.EdoCivil)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValue("")
//                .IsFixedLength()
//                .HasColumnName("EDO_CIVIL");
//            entity.Property(e => e.EsCategoria)
//                .HasDefaultValue(0)
//                .HasColumnName("ES_CATEGORIA");
//            entity.Property(e => e.EsClave).HasColumnName("ES_CLAVE");
//            entity.Property(e => e.Experiencia)
//                .HasDefaultValue(0)
//                .HasColumnName("EXPERIENCIA");
//            entity.Property(e => e.ExperienciaMax).HasColumnName("EXPERIENCIA_MAX");
//            entity.Property(e => e.FechaRevision)
//                .HasColumnType("smalldatetime")
//                .HasColumnName("FECHA_REVISION");
//            entity.Property(e => e.FechaUltCambio)
//                .HasColumnType("smalldatetime")
//                .HasColumnName("FECHA_ULT_CAMBIO");
//            entity.Property(e => e.FechaValuacion)
//                .HasColumnType("smalldatetime")
//                .HasColumnName("FECHA_VALUACION");
//            entity.Property(e => e.HorarioTrabajo)
//                .HasMaxLength(40)
//                .IsUnicode(false)
//                .HasColumnName("HORARIO_TRABAJO");
//            entity.Property(e => e.IdCorpDato).HasColumnName("ID_CORP_DATO");
//            entity.Property(e => e.IdCorporativo).HasColumnName("ID_CORPORATIVO");
//            entity.Property(e => e.Inactivo).HasColumnName("INACTIVO");
//            entity.Property(e => e.LigaDocumento)
//                .HasMaxLength(100)
//                .IsUnicode(false)
//                .HasColumnName("LIGA_DOCUMENTO");
//            entity.Property(e => e.Niv01)
//                .HasDefaultValue(0)
//                .HasColumnName("NIV_01");
//            entity.Property(e => e.Niv02)
//                .HasDefaultValue(0)
//                .HasColumnName("NIV_02");
//            entity.Property(e => e.Niv03)
//                .HasDefaultValue(0)
//                .HasColumnName("NIV_03");
//            entity.Property(e => e.Niv04)
//                .HasDefaultValue(0)
//                .HasColumnName("NIV_04");
//            entity.Property(e => e.Niv05)
//                .HasDefaultValue(0)
//                .HasColumnName("NIV_05");
//            entity.Property(e => e.Niv06)
//                .HasDefaultValue(0)
//                .HasColumnName("NIV_06");
//            entity.Property(e => e.Niv07)
//                .HasDefaultValue(0)
//                .HasColumnName("NIV_07");
//            entity.Property(e => e.Niv08)
//                .HasDefaultValue(0)
//                .HasColumnName("NIV_08");
//            entity.Property(e => e.Niv09)
//                .HasDefaultValue(0)
//                .HasColumnName("NIV_09");
//            entity.Property(e => e.Niv10)
//                .HasDefaultValue(0)
//                .HasColumnName("NIV_10");
//            entity.Property(e => e.NivActual).HasColumnName("NIV_ACTUAL");
//            entity.Property(e => e.Nivel)
//                .HasMaxLength(10)
//                .IsUnicode(false)
//                .HasColumnName("NIVEL");
//            entity.Property(e => e.NivelMercado).HasColumnName("NIVEL_MERCADO");
//            entity.Property(e => e.NomPuesto)
//                .HasMaxLength(150)
//                .IsUnicode(false)
//                .IsFixedLength()
//                .HasColumnName("NOM_PUESTO");
//            entity.Property(e => e.NomPuestoIng)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasColumnName("NOM_PUESTO_ING");
//            entity.Property(e => e.ObsPuesto)
//                .HasMaxLength(1000)
//                .IsUnicode(false)
//                .HasColumnName("OBS_PUESTO");
//            entity.Property(e => e.ObsPuestoIng)
//                .HasMaxLength(1000)
//                .IsUnicode(false)
//                .HasColumnName("OBS_PUESTO_ING");
//            entity.Property(e => e.Observaciones)
//                .HasMaxLength(250)
//                .IsUnicode(false)
//                .HasColumnName("OBSERVACIONES");
//            entity.Property(e => e.Orden).HasColumnName("ORDEN");
//            entity.Property(e => e.PerfilPuesto)
//                .HasMaxLength(1000)
//                .IsUnicode(false)
//                .HasColumnName("PERFIL_PUESTO");
//            entity.Property(e => e.PeriodoEspTrabajo)
//                .HasMaxLength(100)
//                .IsUnicode(false)
//                .HasColumnName("PERIODO_ESP_TRABAJO");
//            entity.Property(e => e.PersonaRevisa)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasColumnName("PERSONA_REVISA");
//            entity.Property(e => e.Presentacion)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasColumnName("PRESENTACION");
//            entity.Property(e => e.RazonesCondEspErgo)
//                .HasMaxLength(200)
//                .IsUnicode(false)
//                .HasColumnName("RAZONES_COND_ESP_ERGO");
//            entity.Property(e => e.RazonesCondEspTrab)
//                .HasMaxLength(200)
//                .IsUnicode(false)
//                .HasColumnName("RAZONES_COND_ESP_TRAB");
//            entity.Property(e => e.Referencia1)
//                .HasMaxLength(15)
//                .IsUnicode(false)
//                .HasColumnName("REFERENCIA_1");
//            entity.Property(e => e.Referencia2)
//                .HasMaxLength(15)
//                .IsUnicode(false)
//                .HasColumnName("REFERENCIA_2");
//            entity.Property(e => e.Referencia3)
//                .HasMaxLength(15)
//                .IsUnicode(false)
//                .HasColumnName("REFERENCIA_3");
//            entity.Property(e => e.Referencia4)
//                .HasMaxLength(15)
//                .IsUnicode(false)
//                .HasColumnName("REFERENCIA_4");
//            entity.Property(e => e.RequisitoEscolaridad).HasColumnName("REQUISITO_ESCOLARIDAD");
//            entity.Property(e => e.RiesgoFncLab).HasColumnName("RIESGO_FNC_LAB");
//            entity.Property(e => e.Sexo)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValue("")
//                .IsFixedLength()
//                .HasColumnName("SEXO");
//            entity.Property(e => e.Sind).HasColumnName("SIND");
//            entity.Property(e => e.SubareaOcupStps).HasColumnName("SUBAREA_OCUP_STPS");
//            entity.Property(e => e.Tabulador).HasColumnName("TABULADOR");
//            entity.Property(e => e.TabuladorInicial)
//                .HasMaxLength(200)
//                .IsUnicode(false)
//                .HasColumnName("TABULADOR_INICIAL");
//            entity.Property(e => e.TieneAuto).HasColumnName("TIENE_AUTO");
//            entity.Property(e => e.TipoPuesto).HasColumnName("TIPO_PUESTO");
//            entity.Property(e => e.TratEsp)
//                .HasDefaultValue(false)
//                .HasColumnName("TRAT_ESP");
//            entity.Property(e => e.UltimoNivel).HasColumnName("ULTIMO_NIVEL");
//            entity.Property(e => e.ValorPuntos).HasColumnName("VALOR_PUNTOS");
//            entity.Property(e => e.ValorValuacion).HasColumnName("VALOR_VALUACION");
//            entity.Property(e => e.Viajar)
//                .HasDefaultValue(0)
//                .HasColumnName("VIAJAR");
//        });

//        OnModelCreatingPartial(modelBuilder);
//    }

//    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
