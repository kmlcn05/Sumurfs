﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Smurfs.DataAccess.Concrete.Context;

#nullable disable

namespace Smurfs.DataAccess.Migrations
{
    [DbContext(typeof(SmurfsContext))]
    partial class SmurfsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Smurfs.Entities.Conrete.Bank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BankName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Banks");
                });

            modelBuilder.Entity("Smurfs.Entities.Conrete.Call", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Appointee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BankId")
                        .HasColumnType("int");

                    b.Property<string>("CagriCozumSuresi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CallDateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CallDateResolved")
                        .HasColumnType("datetime2");

                    b.Property<string>("CallDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CallName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CallPriority")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CallStatusId")
                        .HasColumnType("int");

                    b.Property<string>("JiraTaskNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Reporter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaskType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BankId");

                    b.HasIndex("CallStatusId");

                    b.ToTable("Calls");
                });

            modelBuilder.Entity("Smurfs.Entities.Conrete.CallStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CallStatusName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CallStatus");
                });

            modelBuilder.Entity("Smurfs.Entities.Conrete.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DepartmentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Smurfs.Entities.Conrete.DZDStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("DZDStatusName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DZDStatuses");
                });

            modelBuilder.Entity("Smurfs.Entities.Conrete.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("LogDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Page")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProcessId")
                        .HasColumnType("int");

                    b.Property<int?>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProcessId");

                    b.HasIndex("UsersId");

                    b.ToTable("Logs");
                });

            modelBuilder.Entity("Smurfs.Entities.Conrete.Premium", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PremiumDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UsersId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsersId");

                    b.ToTable("Premiums");
                });

            modelBuilder.Entity("Smurfs.Entities.Conrete.Process", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ProcessName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Processes");
                });

            modelBuilder.Entity("Smurfs.Entities.Conrete.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Analyst")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnalystManDay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("BankId")
                        .HasColumnType("int");

                    b.Property<int?>("DZDStatusId")
                        .HasColumnType("int");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Developer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DeveloperManDay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JiraProjectName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JiraProjectNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JiraTaskNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PmManDay")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ProjectDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.Property<int?>("TeamId")
                        .HasColumnType("int");

                    b.Property<string>("TotalManDay")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BankId");

                    b.HasIndex("DZDStatusId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("StatusId");

                    b.HasIndex("TeamId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Smurfs.Entities.Conrete.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("StatusName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Statuses");
                });

            modelBuilder.Entity("Smurfs.Entities.Conrete.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("TeamName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("Smurfs.Entities.Conrete.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<byte>("Active")
                        .HasColumnType("tinyint");

                    b.Property<DateTime>("DateOfStart")
                        .HasColumnType("datetime2");

                    b.Property<byte>("FirstLogin")
                        .HasColumnType("tinyint");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("teamId")
                        .HasColumnType("int");

                    b.Property<int?>("usergroupId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("teamId");

                    b.HasIndex("usergroupId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Smurfs.Entities.Conrete.UserGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("GroupName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserGroups");
                });

            modelBuilder.Entity("Smurfs.Entity.Concrete.CallParameters", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CallCarpani")
                        .HasColumnType("int");

                    b.Property<int>("CallGerceklesen")
                        .HasColumnType("int");

                    b.Property<int?>("CallId")
                        .HasColumnType("int");

                    b.Property<int>("CallKapasite")
                        .HasColumnType("int");

                    b.Property<int>("CallVerimDegeri")
                        .HasColumnType("int");

                    b.Property<int>("CallVerimSonucu")
                        .HasColumnType("int");

                    b.Property<int>("CallVerimYuzdesi")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ParametersDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CallId");

                    b.ToTable("CallParameters");
                });

            modelBuilder.Entity("Smurfs.Entity.Concrete.ProjectParameters", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ParametersDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProjeCarpani")
                        .HasColumnType("int");

                    b.Property<int>("ProjeGerceklesen")
                        .HasColumnType("int");

                    b.Property<int>("ProjeKapasite")
                        .HasColumnType("int");

                    b.Property<int>("ProjeVerimDegeri")
                        .HasColumnType("int");

                    b.Property<int>("ProjeVerimSonucu")
                        .HasColumnType("int");

                    b.Property<int>("ProjeVerimYuzdesi")
                        .HasColumnType("int");

                    b.Property<int?>("ProjectId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("ProjectParameters");
                });

            modelBuilder.Entity("Smurfs.Entities.Conrete.Call", b =>
                {
                    b.HasOne("Smurfs.Entities.Conrete.Bank", "Bank")
                        .WithMany()
                        .HasForeignKey("BankId");

                    b.HasOne("Smurfs.Entities.Conrete.CallStatus", "CallStatus")
                        .WithMany()
                        .HasForeignKey("CallStatusId");

                    b.Navigation("Bank");

                    b.Navigation("CallStatus");
                });

            modelBuilder.Entity("Smurfs.Entities.Conrete.Log", b =>
                {
                    b.HasOne("Smurfs.Entities.Conrete.Process", "Process")
                        .WithMany("Logs")
                        .HasForeignKey("ProcessId");

                    b.HasOne("Smurfs.Entities.Conrete.User", "Users")
                        .WithMany("Logs")
                        .HasForeignKey("UsersId");

                    b.Navigation("Process");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Smurfs.Entities.Conrete.Premium", b =>
                {
                    b.HasOne("Smurfs.Entities.Conrete.User", "Users")
                        .WithMany("Premium")
                        .HasForeignKey("UsersId");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Smurfs.Entities.Conrete.Project", b =>
                {
                    b.HasOne("Smurfs.Entities.Conrete.Bank", "Bank")
                        .WithMany("Project")
                        .HasForeignKey("BankId");

                    b.HasOne("Smurfs.Entities.Conrete.DZDStatus", "DZDStatus")
                        .WithMany("Project")
                        .HasForeignKey("DZDStatusId");

                    b.HasOne("Smurfs.Entities.Conrete.Department", "Department")
                        .WithMany("Project")
                        .HasForeignKey("DepartmentId");

                    b.HasOne("Smurfs.Entities.Conrete.Status", "Status")
                        .WithMany("Project")
                        .HasForeignKey("StatusId");

                    b.HasOne("Smurfs.Entities.Conrete.Team", "Team")
                        .WithMany("Project")
                        .HasForeignKey("TeamId");

                    b.Navigation("Bank");

                    b.Navigation("DZDStatus");

                    b.Navigation("Department");

                    b.Navigation("Status");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("Smurfs.Entities.Conrete.User", b =>
                {
                    b.HasOne("Smurfs.Entities.Conrete.Team", "team")
                        .WithMany("Users")
                        .HasForeignKey("teamId");

                    b.HasOne("Smurfs.Entities.Conrete.UserGroup", "usergroup")
                        .WithMany("Users")
                        .HasForeignKey("usergroupId");

                    b.Navigation("team");

                    b.Navigation("usergroup");
                });

            modelBuilder.Entity("Smurfs.Entity.Concrete.CallParameters", b =>
                {
                    b.HasOne("Smurfs.Entities.Conrete.Call", "Call")
                        .WithMany("CallParameters")
                        .HasForeignKey("CallId");

                    b.Navigation("Call");
                });

            modelBuilder.Entity("Smurfs.Entity.Concrete.ProjectParameters", b =>
                {
                    b.HasOne("Smurfs.Entities.Conrete.Project", "Project")
                        .WithMany("ProjectParameters")
                        .HasForeignKey("ProjectId");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Smurfs.Entities.Conrete.Bank", b =>
                {
                    b.Navigation("Project");
                });

            modelBuilder.Entity("Smurfs.Entities.Conrete.Call", b =>
                {
                    b.Navigation("CallParameters");
                });

            modelBuilder.Entity("Smurfs.Entities.Conrete.Department", b =>
                {
                    b.Navigation("Project");
                });

            modelBuilder.Entity("Smurfs.Entities.Conrete.DZDStatus", b =>
                {
                    b.Navigation("Project");
                });

            modelBuilder.Entity("Smurfs.Entities.Conrete.Process", b =>
                {
                    b.Navigation("Logs");
                });

            modelBuilder.Entity("Smurfs.Entities.Conrete.Project", b =>
                {
                    b.Navigation("ProjectParameters");
                });

            modelBuilder.Entity("Smurfs.Entities.Conrete.Status", b =>
                {
                    b.Navigation("Project");
                });

            modelBuilder.Entity("Smurfs.Entities.Conrete.Team", b =>
                {
                    b.Navigation("Project");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Smurfs.Entities.Conrete.User", b =>
                {
                    b.Navigation("Logs");

                    b.Navigation("Premium");
                });

            modelBuilder.Entity("Smurfs.Entities.Conrete.UserGroup", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
