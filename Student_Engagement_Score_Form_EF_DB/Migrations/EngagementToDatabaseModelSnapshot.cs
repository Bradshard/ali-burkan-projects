﻿// <auto-generated />
using Student_Engagement_Score_Form_EF_DB.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Student_Engagement_Score_Form_EF_DB.Migrations
{
    [DbContext(typeof(EngagementToDatabase))]
    partial class EngagementToDatabaseModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Student_Engagement_Score_Form_EF_DB.Model.Engagement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EngagementName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PageView")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("VideoView")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Engagements");
                });

            modelBuilder.Entity("Student_Engagement_Score_Form_EF_DB.Model.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Contact_Adress");

                    b.Property<string>("StudentName")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("StudentSurname")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("StudentId");

                    b.ToTable("StudentList");
                });

            modelBuilder.Entity("Student_Engagement_Score_Form_EF_DB.Model.Engagement", b =>
                {
                    b.HasOne("Student_Engagement_Score_Form_EF_DB.Model.Student", null)
                        .WithMany("Engagements")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Student_Engagement_Score_Form_EF_DB.Model.Student", b =>
                {
                    b.Navigation("Engagements");
                });
#pragma warning restore 612, 618
        }
    }
}
