using Microsoft.EntityFrameworkCore.Migrations;

namespace CPRG214.AssetTrackingSystem.Data.Migrations
{
    public partial class CreateAssetTrackingSystem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssetType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Asset",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagNumber = table.Column<string>(nullable: false),
                    AssetTypeId = table.Column<int>(nullable: false),
                    Manufacturer = table.Column<string>(nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: false),
                    SerialNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Asset", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Asset_AssetType_AssetTypeId",
                        column: x => x.AssetTypeId,
                        principalTable: "AssetType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AssetType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Desktop Computer" });

            migrationBuilder.InsertData(
                table: "AssetType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Monitor" });

            migrationBuilder.InsertData(
                table: "AssetType",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Phone" });

            migrationBuilder.InsertData(
                table: "Asset",
                columns: new[] { "Id", "AssetTypeId", "Description", "Manufacturer", "Model", "SerialNumber", "TagNumber" },
                values: new object[,]
                {
                    { 1, 1, "Dell Inspiron Desktop Computer", "Dell", "Inspiron", "1001", "1" },
                    { 2, 1, "HP Pavillion Desktop Computer", "HP", "Pavillion", "1002", "2" },
                    { 3, 1, "Acer Aspire Desktop Computer", "Acer", "Aspire", "1003", "3" },
                    { 4, 2, "Acer Monitor", "Acer", "SB220Q", "1004", "4" },
                    { 5, 2, "LG Monitor", "LG", "27mp57vq", "1005", "5" },
                    { 6, 2, "HP Monitor", "HP", "19-2113w", "1006", "6" },
                    { 7, 3, "Avaya Phone", "Avaya", "1408", "1007", "7" },
                    { 8, 3, "Polycom Phone", "Polycom", "vx411", "1008", "8" },
                    { 9, 3, "Cisco Phone", "Cisco", "78741", "1009", "9" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Asset_AssetTypeId",
                table: "Asset",
                column: "AssetTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Asset");

            migrationBuilder.DropTable(
                name: "AssetType");
        }
    }
}
