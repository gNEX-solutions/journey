using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Journey.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    ProfilePictureUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "DestinationCatogaries",
                columns: table => new
                {
                    DestinationCatogaryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CatagoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DestinationCatogaries", x => x.DestinationCatogaryId);
                });

            migrationBuilder.CreateTable(
                name: "DestinationTravellingModes",
                columns: table => new
                {
                    DestinationTravellingModeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TravellingMode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DestinationTravellingModes", x => x.DestinationTravellingModeId);
                });

            migrationBuilder.CreateTable(
                name: "DesttinationAttributesTypes",
                columns: table => new
                {
                    DestinationAttributesTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttributeTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DesttinationAttributesTypes", x => x.DestinationAttributesTypeId);
                });

            migrationBuilder.CreateTable(
                name: "PopularityTypes",
                columns: table => new
                {
                    PopularityTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PopularityTypes", x => x.PopularityTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    ProfilePictureUrl = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<byte>(nullable: false),
                    RefreshToken = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    DestinationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DestinationName = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    EnjoyableTime = table.Column<TimeSpan>(nullable: true),
                    AdditonalInformation = table.Column<string>(nullable: true),
                    VisitedOn = table.Column<DateTime>(nullable: true),
                    IsPublished = table.Column<byte>(nullable: true),
                    CatagoryId = table.Column<int>(nullable: true),
                    CreatedUserId = table.Column<string>(nullable: true),
                    TravellingModeId = table.Column<int>(nullable: true),
                    PuBlisherId = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<byte>(nullable: false),
                    DestinationCatogaryId = table.Column<int>(nullable: true),
                    DestinationTravellingModeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.DestinationId);
                    table.ForeignKey(
                        name: "FK_Destinations_DestinationCatogaries_DestinationCatogaryId",
                        column: x => x.DestinationCatogaryId,
                        principalTable: "DestinationCatogaries",
                        principalColumn: "DestinationCatogaryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Destinations_DestinationTravellingModes_DestinationTravellingModeId",
                        column: x => x.DestinationTravellingModeId,
                        principalTable: "DestinationTravellingModes",
                        principalColumn: "DestinationTravellingModeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FollwedBies",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    FollowedByUserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FollwedBies", x => new { x.UserId, x.FollowedByUserId });
                    table.ForeignKey(
                        name: "FK_FollwedBies_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    ActivityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ActivityImageUrl = table.Column<string>(nullable: true),
                    DestinationId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.ActivityId);
                    table.ForeignKey(
                        name: "FK_Activities_Destinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Destinations",
                        principalColumn: "DestinationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Attractions",
                columns: table => new
                {
                    AttractionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttractionName = table.Column<string>(nullable: true),
                    ShortDescription = table.Column<string>(nullable: true),
                    IsPublished = table.Column<byte>(nullable: true),
                    DestinationId = table.Column<int>(nullable: false),
                    CreatedUserId = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<byte>(nullable: false),
                    IsModified = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attractions", x => x.AttractionId);
                    table.ForeignKey(
                        name: "FK_Attractions_Destinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Destinations",
                        principalColumn: "DestinationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DestinationAttributes",
                columns: table => new
                {
                    DestinationAttributeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    value = table.Column<double>(nullable: false),
                    AttributeTypeId = table.Column<int>(nullable: false),
                    DestinationId = table.Column<int>(nullable: false),
                    DesttinationAttributesTypeDestinationAttributesTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DestinationAttributes", x => x.DestinationAttributeId);
                    table.ForeignKey(
                        name: "FK_DestinationAttributes_Destinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Destinations",
                        principalColumn: "DestinationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DestinationAttributes_DesttinationAttributesTypes_DesttinationAttributesTypeDestinationAttributesTypeId",
                        column: x => x.DesttinationAttributesTypeDestinationAttributesTypeId,
                        principalTable: "DesttinationAttributesTypes",
                        principalColumn: "DestinationAttributesTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DestinationComments",
                columns: table => new
                {
                    DestinationCommentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: true),
                    DestinationId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    IsDeleted = table.Column<byte>(nullable: false),
                    CeatedAt = table.Column<DateTime>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DestinationComments", x => x.DestinationCommentId);
                    table.ForeignKey(
                        name: "FK_DestinationComments_Destinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Destinations",
                        principalColumn: "DestinationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DestinationImages",
                columns: table => new
                {
                    DestinationImageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(nullable: true),
                    ImageCaption = table.Column<string>(nullable: true),
                    DestinationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DestinationImages", x => x.DestinationImageId);
                    table.ForeignKey(
                        name: "FK_DestinationImages_Destinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Destinations",
                        principalColumn: "DestinationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DestinationPopularities",
                columns: table => new
                {
                    DestinationPopularityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeId = table.Column<int>(nullable: false),
                    DestinationId = table.Column<int>(nullable: false),
                    value = table.Column<double>(nullable: false),
                    PopularityTypeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DestinationPopularities", x => x.DestinationPopularityId);
                    table.ForeignKey(
                        name: "FK_DestinationPopularities_Destinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Destinations",
                        principalColumn: "DestinationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DestinationPopularities_PopularityTypes_PopularityTypeId",
                        column: x => x.PopularityTypeId,
                        principalTable: "PopularityTypes",
                        principalColumn: "PopularityTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NearbyDestinationsMappings",
                columns: table => new
                {
                    DestinationId = table.Column<int>(nullable: false),
                    NearbyDestinationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NearbyDestinationsMappings", x => new { x.DestinationId, x.NearbyDestinationId });
                    table.ForeignKey(
                        name: "FK_NearbyDestinationsMappings_Destinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Destinations",
                        principalColumn: "DestinationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NearbyDestinationSuggestions",
                columns: table => new
                {
                    NearbyDestinationSuggestionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SuggestedDestinationName = table.Column<string>(nullable: true),
                    DestinationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NearbyDestinationSuggestions", x => x.NearbyDestinationSuggestionId);
                    table.ForeignKey(
                        name: "FK_NearbyDestinationSuggestions_Destinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Destinations",
                        principalColumn: "DestinationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserFeedbacks",
                columns: table => new
                {
                    UserFeedbackId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<byte>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    DestinationID = table.Column<int>(nullable: true),
                    UserId = table.Column<int>(nullable: true),
                    AdminId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserFeedbacks", x => x.UserFeedbackId);
                    table.ForeignKey(
                        name: "FK_UserFeedbacks_Admins_AdminId",
                        column: x => x.AdminId,
                        principalTable: "Admins",
                        principalColumn: "AdminId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserFeedbacks_Destinations_DestinationID",
                        column: x => x.DestinationID,
                        principalTable: "Destinations",
                        principalColumn: "DestinationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserFeedbacks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WishLIsts",
                columns: table => new
                {
                    WishListId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DestinationId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<byte>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WishLIsts", x => x.WishListId);
                    table.ForeignKey(
                        name: "FK_WishLIsts_Destinations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Destinations",
                        principalColumn: "DestinationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WishLIsts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AttractionImages",
                columns: table => new
                {
                    AttractionImageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AttractionImageCaption = table.Column<string>(nullable: true),
                    AttractionImageUrl = table.Column<string>(nullable: true),
                    AttractionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttractionImages", x => x.AttractionImageId);
                    table.ForeignKey(
                        name: "FK_AttractionImages_Attractions_AttractionId",
                        column: x => x.AttractionId,
                        principalTable: "Attractions",
                        principalColumn: "AttractionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_DestinationId",
                table: "Activities",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_AttractionImages_AttractionId",
                table: "AttractionImages",
                column: "AttractionId");

            migrationBuilder.CreateIndex(
                name: "IX_Attractions_DestinationId",
                table: "Attractions",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_DestinationAttributes_DestinationId",
                table: "DestinationAttributes",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_DestinationAttributes_DesttinationAttributesTypeDestinationAttributesTypeId",
                table: "DestinationAttributes",
                column: "DesttinationAttributesTypeDestinationAttributesTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DestinationComments_DestinationId",
                table: "DestinationComments",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_DestinationImages_DestinationId",
                table: "DestinationImages",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_DestinationPopularities_DestinationId",
                table: "DestinationPopularities",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_DestinationPopularities_PopularityTypeId",
                table: "DestinationPopularities",
                column: "PopularityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Destinations_DestinationCatogaryId",
                table: "Destinations",
                column: "DestinationCatogaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Destinations_DestinationTravellingModeId",
                table: "Destinations",
                column: "DestinationTravellingModeId");

            migrationBuilder.CreateIndex(
                name: "IX_NearbyDestinationSuggestions_DestinationId",
                table: "NearbyDestinationSuggestions",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFeedbacks_AdminId",
                table: "UserFeedbacks",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_UserFeedbacks_DestinationID",
                table: "UserFeedbacks",
                column: "DestinationID");

            migrationBuilder.CreateIndex(
                name: "IX_UserFeedbacks_UserId",
                table: "UserFeedbacks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WishLIsts_DestinationId",
                table: "WishLIsts",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_WishLIsts_UserId",
                table: "WishLIsts",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "AttractionImages");

            migrationBuilder.DropTable(
                name: "DestinationAttributes");

            migrationBuilder.DropTable(
                name: "DestinationComments");

            migrationBuilder.DropTable(
                name: "DestinationImages");

            migrationBuilder.DropTable(
                name: "DestinationPopularities");

            migrationBuilder.DropTable(
                name: "FollwedBies");

            migrationBuilder.DropTable(
                name: "NearbyDestinationsMappings");

            migrationBuilder.DropTable(
                name: "NearbyDestinationSuggestions");

            migrationBuilder.DropTable(
                name: "UserFeedbacks");

            migrationBuilder.DropTable(
                name: "WishLIsts");

            migrationBuilder.DropTable(
                name: "Attractions");

            migrationBuilder.DropTable(
                name: "DesttinationAttributesTypes");

            migrationBuilder.DropTable(
                name: "PopularityTypes");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Destinations");

            migrationBuilder.DropTable(
                name: "DestinationCatogaries");

            migrationBuilder.DropTable(
                name: "DestinationTravellingModes");
        }
    }
}
