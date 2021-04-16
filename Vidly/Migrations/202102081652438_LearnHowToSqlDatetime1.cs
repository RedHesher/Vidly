namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LearnHowToSqlDatetime1 : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies (Id, Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES (1, 'Call of Ctulu',   'Horror',     '20050605 10:34:36', '20151010 06:45:45', 5)");
            Sql("INSERT INTO Movies (Id, Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES (2, 'Djungo',          'Adventure',  '20080805 10:35:36', '20151010 05:45:45', 4)");
            Sql("INSERT INTO Movies (Id, Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES (3, 'Mid Nigfht City', 'Love Story', '20040605 10:36:36', '20151010 03:45:45', 17)");
            Sql("INSERT INTO Movies (Id, Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES (4, 'Scott Pilgrim',   'Comic Film', '20070605 10:37:36', '20131010 02:45:45', 2)");

        }

        public override void Down()
        {
        }
    }
}
