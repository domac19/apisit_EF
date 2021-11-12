namespace CodeFirstVidzy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RestrictionsToTagGenreAndVideo : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.TagVideos", newName: "VideoTags");
            DropPrimaryKey("dbo.VideoTags");
            AlterColumn("dbo.Genres", "Name", c => c.String(nullable: false, maxLength: 255));
            AddPrimaryKey("dbo.VideoTags", new[] { "Video_Id", "Tag_Id" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.VideoTags");
            AlterColumn("dbo.Genres", "Name", c => c.String());
            AddPrimaryKey("dbo.VideoTags", new[] { "Tag_Id", "Video_Id" });
            RenameTable(name: "dbo.VideoTags", newName: "TagVideos");
        }
    }
}
