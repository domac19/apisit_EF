namespace CodeFirstVidzy.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateTableGenres : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO Genres (Id,Name) VALUES (1, 'Advanture'), (2, 'Action'), (3,'Horror'), (4, 'Comedy'), (5, 'Thriller') ");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id BETWEEN 1 AND 5");
        }
    }
}
