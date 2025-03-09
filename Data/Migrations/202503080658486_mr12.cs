namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mr12 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Siparis", "Adet", c => c.Int(nullable: false));
            AddColumn("dbo.Siparis", "SiparisTarihi", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Siparis", "SiparisTarihi");
            DropColumn("dbo.Siparis", "Adet");
        }
    }
}
