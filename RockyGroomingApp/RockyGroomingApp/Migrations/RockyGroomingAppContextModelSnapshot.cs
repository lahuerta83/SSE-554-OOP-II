using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using RockyGroomingApp.Models;

namespace RockyGroomingApp.Migrations
{
    [DbContext(typeof(RockyGroomingAppContext))]
    partial class RockyGroomingAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RockyGroomingApp.Models.Dog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Appointment");

                    b.Property<string>("Groomer");

                    b.Property<string>("Name");

                    b.Property<string>("Service");

                    b.HasKey("ID");

                    b.ToTable("Dog");
                });
        }
    }
}
