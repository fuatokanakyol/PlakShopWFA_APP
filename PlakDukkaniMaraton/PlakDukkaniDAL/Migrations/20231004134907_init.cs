using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PlakDukkaniDAL.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Album_Table",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Album_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Musician_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Release_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    IsItOnSale = table.Column<bool>(type: "bit", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Album_Table", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manager_Table",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manager_Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Register_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Update_Date = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manager_Table", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Album_Table",
                columns: new[] { "Id", "Album_Name", "Discount", "IsItOnSale", "Musician_Name", "Price", "RegisterDate", "Release_Date", "UpdateDate" },
                values: new object[,]
                {
                    { 1, "Rhapsody in Blue", 15.0, true, "George Gershwin", 19.989999999999998, new DateTime(2008, 10, 4, 16, 49, 7, 154, DateTimeKind.Local).AddTicks(321), new DateTime(1924, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "Abbey Road", 10.0, true, "The Beatles", 24.989999999999998, new DateTime(2009, 10, 4, 16, 49, 7, 154, DateTimeKind.Local).AddTicks(326), new DateTime(1969, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "Thriller", 5.0, false, "Michael Jackson", 29.989999999999998, new DateTime(2010, 10, 4, 16, 49, 7, 154, DateTimeKind.Local).AddTicks(328), new DateTime(1982, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, "The Dark Side of the Moon", 10.0, true, "Pink Floyd", 21.989999999999998, new DateTime(2011, 10, 4, 16, 49, 7, 154, DateTimeKind.Local).AddTicks(329), new DateTime(1973, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, "Hotel California", 15.0, true, "Eagles", 27.989999999999998, new DateTime(2012, 10, 4, 16, 49, 7, 154, DateTimeKind.Local).AddTicks(331), new DateTime(1976, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, "Legend", 0.0, false, "Bob Marley & The Wailers", 18.989999999999998, new DateTime(2013, 10, 4, 16, 49, 7, 154, DateTimeKind.Local).AddTicks(333), new DateTime(1984, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, "Back in Black", 10.0, true, "AC/DC", 22.989999999999998, new DateTime(2014, 10, 4, 16, 49, 7, 154, DateTimeKind.Local).AddTicks(334), new DateTime(1980, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, "Born to Run", 5.0, true, "Bruce Springsteen", 20.989999999999998, new DateTime(2015, 10, 4, 16, 49, 7, 154, DateTimeKind.Local).AddTicks(336), new DateTime(1975, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, "Darkness on the Edge of Town", 10.0, true, "Bruce Springsteen", 23.989999999999998, new DateTime(2016, 10, 4, 16, 49, 7, 154, DateTimeKind.Local).AddTicks(337), new DateTime(1978, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, "A Night at the Opera", 0.0, false, "Queen", 26.989999999999998, new DateTime(2017, 10, 4, 16, 49, 7, 154, DateTimeKind.Local).AddTicks(339), new DateTime(1975, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, "Wish You Were Here", 15.0, true, "Pink Floyd", 19.989999999999998, new DateTime(2018, 10, 4, 16, 49, 7, 154, DateTimeKind.Local).AddTicks(340), new DateTime(1975, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, "Led Zeppelin IV", 10.0, true, "Led Zeppelin", 25.989999999999998, new DateTime(2019, 10, 4, 16, 49, 7, 154, DateTimeKind.Local).AddTicks(341), new DateTime(1971, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, "The Wall", 5.0, false, "Pink Floyd", 29.989999999999998, new DateTime(2020, 10, 4, 16, 49, 7, 154, DateTimeKind.Local).AddTicks(343), new DateTime(1979, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, "The Rolling Stones", 0.0, false, "The Rolling Stones", 18.989999999999998, new DateTime(2021, 10, 4, 16, 49, 7, 154, DateTimeKind.Local).AddTicks(344), new DateTime(1964, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, "Purple Rain", 10.0, true, "Prince", 22.989999999999998, new DateTime(2022, 10, 4, 16, 49, 7, 154, DateTimeKind.Local).AddTicks(346), new DateTime(1984, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Manager_Table_Manager_Name",
                table: "Manager_Table",
                column: "Manager_Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Album_Table");

            migrationBuilder.DropTable(
                name: "Manager_Table");
        }
    }
}
