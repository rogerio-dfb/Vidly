namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
        INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c1045f64-f138-4178-ad0c-696746249285', N'admin@vidly.com', 0, N'AF0bJhgYkq7n+NW7ohC+KtQmGows171af/qmhG3X7+Z7eFL5hkdCmHY/dAWrnFQHWw==', N'67055824-9b04-45a1-9733-cf68f4b89e83', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
        INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c3d8c586-ce31-44f6-856d-b50a65399ce4', N'guest@vidly.com', 0, N'AFxVw/bK6khVke/+pm7imbOE6uiFjGCcjJyXwL2Z5/Tct1w88Pr/qijxQ5qSuC6wlw==', N'7adb496f-4c3b-43e6-b5c5-618f2bc08b9d', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

        INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'3b5dd781-cdfb-4d5b-a42e-a4f4c8046dda', N'CanManageMovies')

        INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c1045f64-f138-4178-ad0c-696746249285', N'3b5dd781-cdfb-4d5b-a42e-a4f4c8046dda')

");
        }
        
        public override void Down()
        {
        }
    }
}
