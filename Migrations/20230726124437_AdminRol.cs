using Microsoft.EntityFrameworkCore.Migrations;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;

#nullable disable

namespace TareasMVC.Migrations
{
    /// <inheritdoc />
    public partial class AdminRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"IF NOT EXISTS(Select Id from AspNetRoles where Id = 'f49376bc-4abd-4cdb-b6bd-dc8ea58b59df')
            BEGIN
            INSERT AspNetRoles(Id,[Name], [NormalizedName])
            VALUES('f49376bc-4abd-4cdb-b6bd-dc8ea58b59df', 'admin', 'ADMIN')
            END");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE AspNetRoles Where Id = 'f49376bc-4abd-4cdb-b6bd-dc8ea58b59df'");
        }
    }
}
