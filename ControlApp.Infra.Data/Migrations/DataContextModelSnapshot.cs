﻿// <auto-generated />
using System;
using ControlApp.Infra.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ControlApp.Infra.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ControlApp.Domain.Entities.Empresa", b =>
                {
                    b.Property<Guid>("EmpresaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Ativo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true)
                        .HasColumnName("ATIVO");

                    b.Property<string>("NomeDaEmpresa")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("NOME_EMPRESA");

                    b.HasKey("EmpresaId");

                    b.ToTable("EMPRESAS", (string)null);
                });

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

                    b.Property<DateTime?>("DataHoraUltimaAutenticacao")
                        .HasColumnType("datetime2")
                        .HasColumnName("DATA_HORA_ULTIMA_AUTENTICACAO");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("EMAIL");

                    b.Property<string>("FotoUrl")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasColumnName("FOTO_URL");

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
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("USERNAME");

                    b.HasKey("UsuarioId");

                    b.HasIndex("UserName")
                        .IsUnique()
                        .HasFilter("[USERNAME] IS NOT NULL");

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

                    b.Property<string>("LatitudeFimExpediente")
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("LATITUDE_FIM_EXPEDIENTE");

                    b.Property<string>("LatitudeInicioExpediente")
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("LATITUDE_INICIO_EXPEDIENTE");

                    b.Property<double?>("LatitudeInicioPausa")
                        .HasColumnType("FLOAT")
                        .HasColumnName("LATITUDE_INICIO_PAUSA");

                    b.Property<double?>("LatitudeRetornoPausa")
                        .HasColumnType("FLOAT")
                        .HasColumnName("LATITUDE_RETORNO_PAUSA");

                    b.Property<string>("LongitudeFimExpediente")
                        .HasColumnType("VARCHAR(50)")
                        .HasColumnName("LONGITUDE_FIM_EXPEDIENTE");

                    b.Property<string>("LongitudeInicioExpediente")
                        .HasColumnType("VARCHAR(50)")
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
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("CPF");

                    b.Property<Guid?>("EmpresaId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("EMPRESA_ID");

                    b.Property<TimeSpan>("HoraAlmocoFim")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIME")
                        .HasColumnName("HORA_ALMOCO_FIM")
                        .HasDefaultValueSql("CAST('00:00:00' AS TIME)");

                    b.Property<TimeSpan>("HoraAlmocoInicio")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIME")
                        .HasColumnName("HORA_ALMOCO_INICIO")
                        .HasDefaultValueSql("CAST('00:00:00' AS TIME)");

                    b.Property<TimeSpan>("HoraEntrada")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIME")
                        .HasColumnName("HORA_ENTRADA")
                        .HasDefaultValueSql("CAST('00:00:00' AS TIME)");

                    b.Property<TimeSpan>("HoraSaida")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TIME")
                        .HasColumnName("HORA_SAIDA")
                        .HasDefaultValueSql("CAST('00:00:00' AS TIME)");

                    b.Property<bool>("IsOnline")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false)
                        .HasColumnName("IS_ONLINE");

                    b.Property<string>("LatitudeAtual")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("LATITUDE_ATUAL");

                    b.Property<string>("LongitutdeAtual")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("LONGITUDE_ATUAL");

                    b.Property<string>("NumeroMatricula")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("NUMERO_MATRICULA");

                    b.HasIndex("Cpf")
                        .IsUnique()
                        .HasFilter("[CPF] IS NOT NULL");

                    b.HasIndex("EmpresaId");

                    b.HasDiscriminator().HasValue("Tecnico");
                });

            modelBuilder.Entity("ControlApp.Domain.Entities.Empresa", b =>
                {
                    b.OwnsOne("ControlApp.Domain.Entities.Endereco", "Endereco", b1 =>
                        {
                            b1.Property<Guid>("EmpresaId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Bairro")
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)")
                                .HasColumnName("BAIRRO");

                            b1.Property<string>("Cep")
                                .HasMaxLength(10)
                                .HasColumnType("nvarchar(10)")
                                .HasColumnName("CEP");

                            b1.Property<string>("Cidade")
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)")
                                .HasColumnName("CIDADE");

                            b1.Property<string>("Complemento")
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)")
                                .HasColumnName("COMPLEMENTO");

                            b1.Property<Guid>("EnderecoId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Estado")
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)")
                                .HasColumnName("ESTADO");

                            b1.Property<string>("Logradouro")
                                .HasMaxLength(255)
                                .HasColumnType("nvarchar(255)")
                                .HasColumnName("LOGRADOURO");

                            b1.Property<string>("Numero")
                                .HasMaxLength(50)
                                .HasColumnType("nvarchar(50)")
                                .HasColumnName("NUMERO");

                            b1.HasKey("EmpresaId");

                            b1.ToTable("EMPRESAS");

                            b1.WithOwner()
                                .HasForeignKey("EmpresaId");
                        });

                    b.Navigation("Endereco");
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

            modelBuilder.Entity("ControlApp.Domain.Entities.Tecnico", b =>
                {
                    b.HasOne("ControlApp.Domain.Entities.Empresa", "Empresa")
                        .WithMany("Tecnicos")
                        .HasForeignKey("EmpresaId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("ControlApp.Domain.Entities.Empresa", b =>
                {
                    b.Navigation("Tecnicos");
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
