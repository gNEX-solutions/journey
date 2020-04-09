﻿// <auto-generated />
using System;
using Journey.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Journey.Migrations
{
    [DbContext(typeof(JournyDbContext))]
    partial class JournyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Journey.Models.Activity", b =>
                {
                    b.Property<int>("ActivityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ActivityImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("ActivityId");

                    b.HasIndex("DestinationId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("Journey.Models.Admin", b =>
                {
                    b.Property<int>("AdminId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfilePictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminId");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("Journey.Models.Attraction", b =>
                {
                    b.Property<int>("AttractionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AttractionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CreatedUserId")
                        .HasColumnType("int");

                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.Property<byte>("IsDeleted")
                        .HasColumnType("tinyint");

                    b.Property<byte>("IsModified")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("IsPublished")
                        .HasColumnType("tinyint");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AttractionId");

                    b.HasIndex("DestinationId");

                    b.ToTable("Attractions");
                });

            modelBuilder.Entity("Journey.Models.AttractionImage", b =>
                {
                    b.Property<int>("AttractionImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AttractionId")
                        .HasColumnType("int");

                    b.Property<string>("AttractionImageCaption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AttractionImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AttractionImageId");

                    b.HasIndex("AttractionId");

                    b.ToTable("AttractionImages");
                });

            modelBuilder.Entity("Journey.Models.Destination", b =>
                {
                    b.Property<int>("DestinationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AdditonalInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CatagoryId")
                        .HasColumnType("int");

                    b.Property<string>("CreatedUserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DestinationCatogaryId")
                        .HasColumnType("int");

                    b.Property<string>("DestinationName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DestinationTravellingModeId")
                        .HasColumnType("int");

                    b.Property<TimeSpan?>("EnjoyableTime")
                        .HasColumnType("time");

                    b.Property<byte>("IsDeleted")
                        .HasColumnType("tinyint");

                    b.Property<byte?>("IsPublished")
                        .HasColumnType("tinyint");

                    b.Property<int?>("PuBlisherId")
                        .HasColumnType("int");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TravellingModeId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("VisitedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("DestinationId");

                    b.HasIndex("DestinationCatogaryId");

                    b.HasIndex("DestinationTravellingModeId");

                    b.ToTable("Destinations");
                });

            modelBuilder.Entity("Journey.Models.DestinationAttribute", b =>
                {
                    b.Property<int>("DestinationAttributeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AttributeTypeId")
                        .HasColumnType("int");

                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.Property<int?>("DesttinationAttributesTypeDestinationAttributesTypeId")
                        .HasColumnType("int");

                    b.Property<double>("value")
                        .HasColumnType("float");

                    b.HasKey("DestinationAttributeId");

                    b.HasIndex("DestinationId");

                    b.HasIndex("DesttinationAttributesTypeDestinationAttributesTypeId");

                    b.ToTable("DestinationAttributes");
                });

            modelBuilder.Entity("Journey.Models.DestinationAttributesType", b =>
                {
                    b.Property<int>("DestinationAttributesTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AttributeTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DestinationAttributesTypeId");

                    b.ToTable("DesttinationAttributesTypes");
                });

            modelBuilder.Entity("Journey.Models.DestinationCatogary", b =>
                {
                    b.Property<int>("DestinationCatogaryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CatagoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DestinationCatogaryId");

                    b.ToTable("DestinationCatogaries");
                });

            modelBuilder.Entity("Journey.Models.DestinationComment", b =>
                {
                    b.Property<int>("DestinationCommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CeatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.Property<byte>("IsDeleted")
                        .HasColumnType("tinyint");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("DestinationCommentId");

                    b.HasIndex("DestinationId");

                    b.ToTable("DestinationComments");
                });

            modelBuilder.Entity("Journey.Models.DestinationImage", b =>
                {
                    b.Property<int>("DestinationImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.Property<string>("ImageCaption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DestinationImageId");

                    b.HasIndex("DestinationId");

                    b.ToTable("DestinationImages");
                });

            modelBuilder.Entity("Journey.Models.DestinationPopularity", b =>
                {
                    b.Property<int>("DestinationPopularityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.Property<int?>("PopularityTypeId")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
                        .HasColumnType("int");

                    b.Property<double>("value")
                        .HasColumnType("float");

                    b.HasKey("DestinationPopularityId");

                    b.HasIndex("DestinationId");

                    b.HasIndex("PopularityTypeId");

                    b.ToTable("DestinationPopularities");
                });

            modelBuilder.Entity("Journey.Models.DestinationTravellingMode", b =>
                {
                    b.Property<int>("DestinationTravellingModeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TravellingMode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DestinationTravellingModeId");

                    b.ToTable("DestinationTravellingModes");
                });

            modelBuilder.Entity("Journey.Models.FollwedBy", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("FollowedByUserId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "FollowedByUserId");

                    b.ToTable("FollwedBies");
                });

            modelBuilder.Entity("Journey.Models.NearbyDestinationSuggestion", b =>
                {
                    b.Property<int>("NearbyDestinationSuggestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.Property<string>("SuggestedDestinationName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NearbyDestinationSuggestionId");

                    b.HasIndex("DestinationId");

                    b.ToTable("NearbyDestinationSuggestions");
                });

            modelBuilder.Entity("Journey.Models.NearbyDestinationsMapping", b =>
                {
                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.Property<int>("NearbyDestinationId")
                        .HasColumnType("int");

                    b.HasKey("DestinationId", "NearbyDestinationId");

                    b.ToTable("NearbyDestinationsMappings");
                });

            modelBuilder.Entity("Journey.Models.PopularityType", b =>
                {
                    b.Property<int>("PopularityTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PopularityTypeId");

                    b.ToTable("PopularityTypes");
                });

            modelBuilder.Entity("Journey.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("IsDeleted")
                        .HasColumnType("tinyint");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("varchar(MAX)");

                    b.Property<string>("ProfilePictureUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefreshToken")
                        .HasColumnType("varchar(MAX)");

                    b.Property<string>("Username")
                        .HasColumnType("varchar(MAX)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Journey.Models.UserFeedback", b =>
                {
                    b.Property<int>("UserFeedbackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AdminId")
                        .HasColumnType("int");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DestinationID")
                        .HasColumnType("int");

                    b.Property<byte>("Rating")
                        .HasColumnType("tinyint");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("UserFeedbackId");

                    b.HasIndex("AdminId");

                    b.HasIndex("DestinationID");

                    b.HasIndex("UserId");

                    b.ToTable("UserFeedbacks");
                });

            modelBuilder.Entity("Journey.Models.WishLIst", b =>
                {
                    b.Property<int>("WishListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("DestinationId")
                        .HasColumnType("int");

                    b.Property<byte?>("IsDeleted")
                        .HasColumnType("tinyint");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("WishListId");

                    b.HasIndex("DestinationId");

                    b.HasIndex("UserId");

                    b.ToTable("WishLIsts");
                });

            modelBuilder.Entity("Journey.Models.Activity", b =>
                {
                    b.HasOne("Journey.Models.Destination", "Destination")
                        .WithMany("Activities")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Journey.Models.Attraction", b =>
                {
                    b.HasOne("Journey.Models.Destination", "Destination")
                        .WithMany("Attractions")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Journey.Models.AttractionImage", b =>
                {
                    b.HasOne("Journey.Models.Attraction", "Attraction")
                        .WithMany("AttractionImages")
                        .HasForeignKey("AttractionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Journey.Models.Destination", b =>
                {
                    b.HasOne("Journey.Models.DestinationCatogary", "DestinationCatogary")
                        .WithMany("Destinations")
                        .HasForeignKey("DestinationCatogaryId");

                    b.HasOne("Journey.Models.DestinationTravellingMode", "DestinationTravellingMode")
                        .WithMany("Destinations")
                        .HasForeignKey("DestinationTravellingModeId");
                });

            modelBuilder.Entity("Journey.Models.DestinationAttribute", b =>
                {
                    b.HasOne("Journey.Models.Destination", "Destination")
                        .WithMany("DestinationAttributes")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Journey.Models.DestinationAttributesType", "DesttinationAttributesType")
                        .WithMany("DestinationAttributes")
                        .HasForeignKey("DesttinationAttributesTypeDestinationAttributesTypeId");
                });

            modelBuilder.Entity("Journey.Models.DestinationComment", b =>
                {
                    b.HasOne("Journey.Models.Destination", "Destination")
                        .WithMany("DestinationComments")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Journey.Models.DestinationImage", b =>
                {
                    b.HasOne("Journey.Models.Destination", "Destination")
                        .WithMany("DestinationImages")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Journey.Models.DestinationPopularity", b =>
                {
                    b.HasOne("Journey.Models.Destination", "Destination")
                        .WithMany("DestinationPopularities")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Journey.Models.PopularityType", "PopularityType")
                        .WithMany("DestinationPopularities")
                        .HasForeignKey("PopularityTypeId");
                });

            modelBuilder.Entity("Journey.Models.FollwedBy", b =>
                {
                    b.HasOne("Journey.Models.User", "User")
                        .WithMany("FollwedBies")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Journey.Models.NearbyDestinationSuggestion", b =>
                {
                    b.HasOne("Journey.Models.Destination", "Destination")
                        .WithMany("NearbyDestinationSuggestions")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Journey.Models.NearbyDestinationsMapping", b =>
                {
                    b.HasOne("Journey.Models.Destination", "Destination")
                        .WithMany("NearbyDestinationsMappings")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Journey.Models.UserFeedback", b =>
                {
                    b.HasOne("Journey.Models.Admin", "Admin")
                        .WithMany("UserFeedbacks")
                        .HasForeignKey("AdminId");

                    b.HasOne("Journey.Models.Destination", "Destination")
                        .WithMany("UserFeedbacks")
                        .HasForeignKey("DestinationID");

                    b.HasOne("Journey.Models.User", "User")
                        .WithMany("UserFeedbacks")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Journey.Models.WishLIst", b =>
                {
                    b.HasOne("Journey.Models.Destination", "Destination")
                        .WithMany("WishLIsts")
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Journey.Models.User", "User")
                        .WithMany("WishLIsts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
