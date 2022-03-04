using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheReynoldsGroupSite.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryTypevalue = table.Column<int>(type: "int", nullable: false),
                    CategoryDescription = table.Column<int>(type: "int", nullable: false),
                    TotalValuesFromQuestions = table.Column<int>(type: "int", nullable: false),
                    TenToSeven = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SixToFour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThreeToOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NegOneToNegTwo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NegThreeToNegFour = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    ClientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssignedTo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.ClientId);
                });

            migrationBuilder.CreateTable(
                name: "Coach",
                columns: table => new
                {
                    CoachId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoachFirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoachLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CoachType = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coach", x => x.CoachId);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AskQuestion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionNumber = table.Column<int>(type: "int", nullable: false),
                    CategoryType = table.Column<int>(type: "int", nullable: false),
                    AssessmentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MostLikely = table.Column<int>(type: "int", nullable: true),
                    Likley = table.Column<int>(type: "int", nullable: true),
                    Neutral = table.Column<int>(type: "int", nullable: true),
                    Unlikely = table.Column<int>(type: "int", nullable: true),
                    MostUnlikely = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Coach");

            migrationBuilder.DropTable(
                name: "Question");
        }
    }
}
