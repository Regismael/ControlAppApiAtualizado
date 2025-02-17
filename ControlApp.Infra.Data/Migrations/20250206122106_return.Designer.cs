﻿// <auto-generated />
using System;
using ControlApp.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ControlApp.Infra.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250206122106_return")]
    partial class @return
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ControlApp.Domain.Entities.Localizacao", b =>
                {
                    b.Property<Guid>("LocalizacaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataHora")
                        .HasColumnType("datetime2")
                        .HasColumnName("DATA_HORA");

                    b.Property<double?>("Latitude")
                        .HasColumnType("FLOAT")
                        .HasColumnName("LATITUDE");

                    b.Property<double?>("Longitude")
                        .HasColumnType("FLOAT")
                        .HasColumnName("LONGITUDE");

                    b.Property<double>("Precisao")
                        .HasColumnType("float")
                        .HasColumnName("PRECISAO");

                    b.Property<Guid>("TrajetoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("LocalizacaoId");

                    b.HasIndex("TrajetoId");

                    b.ToTable("LOCALIZACOES", (string)null);
                });

            modelBuilder.Entity("ControlApp.Domain.Entities.Usuario", b =>
                {
                    b.Property<Guid>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true)
                        .HasColumnName("ATIVO");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("FotoUrl")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("FOTOURL");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("NOME");

                    b.Property<int>("Role")
                        .HasColumnType("int")
                        .HasColumnName("ROLE");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("SENHA");

                    b.Property<string>("TipoUsuario")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UsuarioId");

                    b.ToTable("USUARIOS", (string)null);

                    b.HasDiscriminator<string>("TipoUsuario").HasValue("Usuario");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Ponto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true)
                        .HasColumnName("ATIVO");

                    b.Property<string>("DistanciaPercorrida")
                        .HasColumnType("VARCHAR(100)")
                        .HasColumnName("DISTANCIA_PERCORRIDA");

                    b.Property<DateTime?>("FimExpediente")
                        .HasColumnType("datetime2")
                        .HasColumnName("FIM_EXPEDIENTE");

                    b.Property<string>("FotoFimExpediente")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("FOTO_FIM_EXPEDIENTE");

                    b.Property<string>("FotoInicioExpediente")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("FOTO_INICIO_EXPEDIENTE");

                    b.Property<TimeSpan>("HorasDevidas")
                        .HasColumnType("TIME")
                        .HasColumnName("HORAS_DEVIDAS");

                    b.Property<TimeSpan>("HorasExtras")
                        .HasColumnType("TIME")
                        .HasColumnName("HORAS_EXTRAS");

                    b.Property<TimeSpan>("HorasTrabalhadas")
                        .HasColumnType("TIME")
                        .HasColumnName("HORAS_TRABALHADAS");

                    b.Property<DateTime?>("InicioExpediente")
                        .HasColumnType("datetime2")
                        .HasColumnName("INICIO_EXPEDIENTE");

                    b.Property<DateTime?>("InicioPausa")
                        .HasColumnType("datetime2")
                        .HasColumnName("INICIO_PAUSA");

                    b.Property<double?>("LatitudeFimExpediente")
                        .HasColumnType("FLOAT")
                        .HasColumnName("LATITUDE_FIM_EXPEDIENTE");

                    b.Property<double?>("LatitudeInicioExpediente")
                        .HasColumnType("FLOAT")
                        .HasColumnName("LATITUDE_INICIO_EXPEDIENTE");

                    b.Property<double?>("LatitudeInicioPausa")
                        .HasColumnType("FLOAT")
                        .HasColumnName("LATITUDE_INICIO_PAUSA");

                    b.Property<double?>("LatitudeRetornoPausa")
                        .HasColumnType("FLOAT")
                        .HasColumnName("LATITUDE_RETORNO_PAUSA");

                    b.Property<double?>("LongitudeFimExpediente")
                        .HasColumnType("FLOAT")
                        .HasColumnName("LONGITUDE_FIM_EXPEDIENTE");

                    b.Property<double?>("LongitudeInicioExpediente")
                        .HasColumnType("FLOAT")
                        .HasColumnName("LONGITUDE_INICIO_EXPEDIENTE");

                    b.Property<double?>("LongitudeInicioPausa")
                        .HasColumnType("FLOAT")
                        .HasColumnName("LONGITUDE_INICIO_PAUSA");

                    b.Property<double?>("LongitudeRetornoPausa")
                        .HasColumnType("FLOAT")
                        .HasColumnName("LONGITUDE_RETORNO_PAUSA");

                    b.Property<string>("ObservacaoFimExpediente")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("OBSERVACAO_FIM_EXPEDIENTE");

                    b.Property<string>("ObservacaoFimPausa")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("OBSERVACAO_FIM_PAUSA");

                    b.Property<string>("ObservacaoInicioExpediente")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("OBSERVACAO_INICIO_EXPEDIENTE");

                    b.Property<string>("ObservacaoInicioPausa")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("OBSERVACAO_INICIO_PAUSA");

                    b.Property<string>("Observacoes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("RetornoPausa")
                        .HasColumnType("datetime2")
                        .HasColumnName("RETORNO_PAUSA");

                    b.Property<int>("TipoPonto")
                        .HasColumnType("int")
                        .HasColumnName("TIPO_PONTO");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("USUARIO_ID");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("PONTOS", (string)null);
                });

            modelBuilder.Entity("Trajeto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2")
                        .HasColumnName("DATA");

                    b.Property<decimal>("DistanciaTotalKm")
                        .HasColumnType("DECIMAL(10,2)")
                        .HasColumnName("DISTANCIA_TOTAL_KM");

                    b.Property<TimeSpan>("DuracaoTotal")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIME")
                        .HasColumnName("DURACAO_TOTAL")
                        .HasDefaultValueSql("CAST('00:00:00' AS TIME)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasDefaultValue("Em andamento")
                        .HasColumnName("STATUS");

                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("USUARIO_ID");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("TRAJETOS", (string)null);
                });

            modelBuilder.Entity("ControlApp.Domain.Entities.Administrador", b =>
                {
                    b.HasBaseType("ControlApp.Domain.Entities.Usuario");

                    b.HasDiscriminator().HasValue("Administrador");
                });

            modelBuilder.Entity("ControlApp.Domain.Entities.Tecnico", b =>
                {
                    b.HasBaseType("ControlApp.Domain.Entities.Usuario");

                    b.Property<string>("Cpf")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("HoraAlmocoFim")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("HoraAlmocoInicio")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("HoraEntrada")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("HoraSaida")
                        .HasColumnType("time");

                    b.Property<bool>("IsOnline")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("Tecnico");
                });

            modelBuilder.Entity("ControlApp.Domain.Entities.Localizacao", b =>
                {
                    b.HasOne("Trajeto", "Trajeto")
                        .WithMany("Localizacoes")
                        .HasForeignKey("TrajetoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trajeto");
                });

            modelBuilder.Entity("Ponto", b =>
                {
                    b.HasOne("ControlApp.Domain.Entities.Tecnico", "Tecnico")
                        .WithMany("Pontos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tecnico");
                });

            modelBuilder.Entity("Trajeto", b =>
                {
                    b.HasOne("ControlApp.Domain.Entities.Tecnico", "Tecnico")
                        .WithMany("Trajetos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Tecnico");
                });

            modelBuilder.Entity("Trajeto", b =>
                {
                    b.Navigation("Localizacoes");
                });

            modelBuilder.Entity("ControlApp.Domain.Entities.Tecnico", b =>
                {
                    b.Navigation("Pontos");

                    b.Navigation("Trajetos");
                });
#pragma warning restore 612, 618
        }
    }
}
