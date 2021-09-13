namespace Guia1_DSE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Peliculas", "productor", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Peliculas", "productor");
        }
    }
}
