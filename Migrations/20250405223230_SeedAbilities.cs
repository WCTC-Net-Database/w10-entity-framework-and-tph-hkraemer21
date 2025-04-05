using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace W9_assignment_template.Migrations
{
    public partial class SeedAbilities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("SET IDENTITY_INSERT[dbo].[Abilities] ON");
            migrationBuilder.Sql("INSERT INTO[dbo].[Abilities]([Id], [Name], [Description], [Discriminator], [Taunt], [Shove]) VALUES(1, N'Shove', N'Pushes with great strength.', N'PlayerAbility', NULL, 10)");
            migrationBuilder.Sql("INSERT INTO[dbo].[Abilities] ([Id], [Name], [Description], [Discriminator], [Taunt], [Shove]) VALUES(4, N'Taunt', N'Laughs obnoxiously', N'GoblinAbility', 0, NULL)");
            migrationBuilder.Sql("SET IDENTITY_INSERT[dbo].[Abilities] OFF");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Abilities");
        }
    }
}
