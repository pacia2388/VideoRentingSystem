namespace VideoRentingSystem.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8824f74c-abc0-44ae-a305-2c2a8748d1e7', N'admin@videostore.com', 0, N'AHTMHpPjF+FYhW9ObUo6MH4KTePU1ZQRc0AcEkuwGwHD1LB4ablHCc6I13nufBRGPw==', N'9a6640db-7cea-4495-8f7d-f1ba2a2ae9d9', NULL, 0, 0, NULL, 1, 0, N'admin@videostore.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd4f9ad39-895a-47ad-b330-a48664bca260', N'guest@videostore.com', 0, N'APx6pPMh62MM97KP/ev+c6v1bkVXVk2G1lXrKoEgkhzmYdg9U1vK+0X4QvlTr+ufzQ==', N'7b15707b-4742-4a52-bfad-54864a3a7263', NULL, 0, 0, NULL, 1, 0, N'guest@videostore.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'241c3609-7f26-4392-9794-b16167b82a7d', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8824f74c-abc0-44ae-a305-2c2a8748d1e7', N'241c3609-7f26-4392-9794-b16167b82a7d')
");
        }

        public override void Down()
        {
        }
    }
}
