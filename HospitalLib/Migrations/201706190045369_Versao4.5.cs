namespace HospitalLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Versao45 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Agendamentoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataAgendada = c.DateTime(nullable: false),
                        Medico_Id = c.Int(nullable: false),
                        Paciente_Id = c.Int(nullable: false),
                        Secretaria_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Medicos", t => t.Medico_Id, cascadeDelete: true)
                .ForeignKey("dbo.Pacientes", t => t.Paciente_Id, cascadeDelete: true)
                .ForeignKey("dbo.Secretarias", t => t.Secretaria_Id, cascadeDelete: true)
                .Index(t => t.Medico_Id)
                .Index(t => t.Paciente_Id)
                .Index(t => t.Secretaria_Id);
            
            CreateTable(
                "dbo.Medicos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Crm = c.String(nullable: false, maxLength: 15),
                        Turno = c.String(nullable: false),
                        Nome = c.String(nullable: false),
                        Cpf = c.String(maxLength: 11),
                        DataNasc = c.DateTime(nullable: false),
                        Telefone = c.String(maxLength: 12),
                        AreaAtuacao_Id = c.Int(nullable: false),
                        Banco_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AreaAtuacaos", t => t.AreaAtuacao_Id, cascadeDelete: true)
                .ForeignKey("dbo.Bancoes", t => t.Banco_Id)
                .Index(t => t.AreaAtuacao_Id)
                .Index(t => t.Banco_Id);
            
            CreateTable(
                "dbo.AreaAtuacaos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Area = c.String(nullable: false, maxLength: 100),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Bancoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                        Conta = c.String(nullable: false, maxLength: 10),
                        Agencia = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pacientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Cpf = c.String(maxLength: 11),
                        DataNasc = c.DateTime(nullable: false),
                        Telefone = c.String(maxLength: 12),
                        Convenio_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Convenios", t => t.Convenio_Id, cascadeDelete: true)
                .Index(t => t.Convenio_Id);
            
            CreateTable(
                "dbo.Convenios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomePlano = c.String(nullable: false, maxLength: 100),
                        NomeEmpresa = c.String(nullable: false, maxLength: 100),
                        Telefone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Secretarias",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Cpf = c.String(maxLength: 11),
                        DataNasc = c.DateTime(nullable: false),
                        Telefone = c.String(maxLength: 12),
                        Banco_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bancoes", t => t.Banco_Id)
                .Index(t => t.Banco_Id);
            
            CreateTable(
                "dbo.Consultas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Data = c.DateTime(nullable: false),
                        PrecoTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Agendamento_Id = c.Int(),
                        Medico_Id = c.Int(nullable: false),
                        Paciente_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Agendamentoes", t => t.Agendamento_Id)
                .ForeignKey("dbo.Medicos", t => t.Medico_Id, cascadeDelete: true)
                .ForeignKey("dbo.Pacientes", t => t.Paciente_Id, cascadeDelete: true)
                .Index(t => t.Agendamento_Id)
                .Index(t => t.Medico_Id)
                .Index(t => t.Paciente_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Consultas", "Paciente_Id", "dbo.Pacientes");
            DropForeignKey("dbo.Consultas", "Medico_Id", "dbo.Medicos");
            DropForeignKey("dbo.Consultas", "Agendamento_Id", "dbo.Agendamentoes");
            DropForeignKey("dbo.Agendamentoes", "Secretaria_Id", "dbo.Secretarias");
            DropForeignKey("dbo.Secretarias", "Banco_Id", "dbo.Bancoes");
            DropForeignKey("dbo.Agendamentoes", "Paciente_Id", "dbo.Pacientes");
            DropForeignKey("dbo.Pacientes", "Convenio_Id", "dbo.Convenios");
            DropForeignKey("dbo.Agendamentoes", "Medico_Id", "dbo.Medicos");
            DropForeignKey("dbo.Medicos", "Banco_Id", "dbo.Bancoes");
            DropForeignKey("dbo.Medicos", "AreaAtuacao_Id", "dbo.AreaAtuacaos");
            DropIndex("dbo.Consultas", new[] { "Paciente_Id" });
            DropIndex("dbo.Consultas", new[] { "Medico_Id" });
            DropIndex("dbo.Consultas", new[] { "Agendamento_Id" });
            DropIndex("dbo.Secretarias", new[] { "Banco_Id" });
            DropIndex("dbo.Pacientes", new[] { "Convenio_Id" });
            DropIndex("dbo.Medicos", new[] { "Banco_Id" });
            DropIndex("dbo.Medicos", new[] { "AreaAtuacao_Id" });
            DropIndex("dbo.Agendamentoes", new[] { "Secretaria_Id" });
            DropIndex("dbo.Agendamentoes", new[] { "Paciente_Id" });
            DropIndex("dbo.Agendamentoes", new[] { "Medico_Id" });
            DropTable("dbo.Consultas");
            DropTable("dbo.Secretarias");
            DropTable("dbo.Convenios");
            DropTable("dbo.Pacientes");
            DropTable("dbo.Bancoes");
            DropTable("dbo.AreaAtuacaos");
            DropTable("dbo.Medicos");
            DropTable("dbo.Agendamentoes");
        }
    }
}
