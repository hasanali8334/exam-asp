// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using exam.webapi.Context;

namespace exam.webapi.Migrations
{
    [DbContext(typeof(ExamContext))]
    [Migration("20210701183931_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("exam.webapi.Entity.Exam", b =>
                {
                    b.Property<int>("ExamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Questions")
                        .HasColumnType("TEXT");

                    b.Property<string>("examname")
                        .HasColumnType("TEXT");

                    b.HasKey("ExamId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("exam.webapi.Entity.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("copt")
                        .HasColumnType("TEXT");

                    b.Property<string>("opt1")
                        .HasColumnType("TEXT");

                    b.Property<string>("opt2")
                        .HasColumnType("TEXT");

                    b.Property<string>("opt3")
                        .HasColumnType("TEXT");

                    b.Property<string>("opt4")
                        .HasColumnType("TEXT");

                    b.Property<string>("opt5")
                        .HasColumnType("TEXT");

                    b.Property<string>("qtext")
                        .HasColumnType("TEXT");

                    b.HasKey("QuestionId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("exam.webapi.Entity.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("mail")
                        .HasColumnType("TEXT");

                    b.Property<string>("password")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
