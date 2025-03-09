namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mr11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musteris", "SiparisId", c => c.Int());
            CreateIndex("dbo.Musteris", "SiparisId");
            AddForeignKey("dbo.Musteris", "SiparisId", "dbo.Siparis", "SiparisId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Musteris", "SiparisId", "dbo.Siparis");
            DropIndex("dbo.Musteris", new[] { "SiparisId" });
            DropColumn("dbo.Musteris", "SiparisId");
        }
    }
}
