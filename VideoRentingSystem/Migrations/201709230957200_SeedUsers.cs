namespace VideoRentingSystem.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'7f838894-8f89-4e3a-b05d-511db16e798d', N'guset@videostore.com', 0, N'AA1z1h1Z7NimPsL+MuxhCNKdFkRHIMAWfSyNlOEgJvqXGvi12vhc0VEIopfaUanQbA==', N'56cf5ce7-cbdc-46bf-9383-f8ebb7b72174', NULL, 0, 0, NULL, 1, 0, N'guset@videostore.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8824f74c-abc0-44ae-a305-2c2a8748d1e7', N'admin@videostore.com', 0, N'AHTMHpPjF+FYhW9ObUo6MH4KTePU1ZQRc0AcEkuwGwHD1LB4ablHCc6I13nufBRGPw==', N'9a6640db-7cea-4495-8f7d-f1ba2a2ae9d9', NULL, 0, 0, NULL, 1, 0, N'admin@videostore.com')
            
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'241c3609-7f26-4392-9794-b16167b82a7d', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7f838894-8f89-4e3a-b05d-511db16e798d', N'241c3609-7f26-4392-9794-b16167b82a7d')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8824f74c-abc0-44ae-a305-2c2a8748d1e7', N'241c3609-7f26-4392-9794-b16167b82a7d')
");
        }

        public override void Down()
        {
        }
    }
}
