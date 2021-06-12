namespace Movie_Store_MVC_5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'03c0281b-98ea-4aae-baa2-41104a635aac', N'admin@movies.com', 0, N'ANVEz5ZiuRm3I+CPZigqt1rSwgJlQnhlHybB6cF4fHIx7MUcaugpA6IlziXqQbd1Og==', N'21d2ed3b-74e0-4b38-b4cf-cf25716c4133', NULL, 0, 0, NULL, 1, 0, N'admin@movies.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3e522483-0a13-4ab3-94ea-78efa07b619c', N'guest@movies.com', 0, N'AOJgvfCa+LkhoGgKPUtOyGWmqA0k1wHdHm2SF0tMq2dhB0ye+p32I9GfQjKeOxfK9Q==', N'32ce9258-658e-44a5-a6bb-caaeabe935bc', NULL, 0, 0, NULL, 1, 0, N'guest@movies.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f90c95de-f048-4a6d-9a7c-0e6c69a00650', N'rezaul12@hotmail.com', 0, N'ADk2kB+ZSD7fCqhZTtWaPr2o0PhRkFo98PMSvGVOVQKiJtpFWrmGLB+mcL0QDOKoFQ==', N'1f11d817-786e-4f95-aec1-13ba89be248a', NULL, 0, 0, NULL, 1, 0, N'rezaul12@hotmail.com')
                    
                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'fda4972c-1e91-40d4-8854-84c6306f3752', N'CanManageMovies')
                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'03c0281b-98ea-4aae-baa2-41104a635aac', N'fda4972c-1e91-40d4-8854-84c6306f3752')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
