namespace Datos.Persistencia.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administrador",
                c => new
                    {
                        AdministradorId = c.Int(nullable: false, identity: true),
                        AdministradorNombre = c.String(nullable: false, maxLength: 25),
                        AdministradorContrasenna = c.String(nullable: false, maxLength: 25),
                        AdministradorCorreo = c.String(nullable: false, maxLength: 25),
                    })
                .PrimaryKey(t => t.AdministradorId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Administrador");
        }
    }
}
