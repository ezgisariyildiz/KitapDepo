namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mr1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kategoris", "KategoriAdi", c => c.String());
            AddColumn("dbo.Kitaps", "Aktif", c => c.Boolean(nullable: false));
            DropColumn("dbo.Kategoris", "KategoryAdi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kategoris", "KategoryAdi", c => c.String());
            DropColumn("dbo.Kitaps", "Aktif");
            DropColumn("dbo.Kategoris", "KategoriAdi");
        }
    }
}
