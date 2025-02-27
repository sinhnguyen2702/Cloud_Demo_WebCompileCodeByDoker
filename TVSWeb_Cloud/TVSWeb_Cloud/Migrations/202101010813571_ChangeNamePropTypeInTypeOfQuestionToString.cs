namespace TVSWeb_Cloud.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeNamePropTypeInTypeOfQuestionToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TypeOfQuestions", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TypeOfQuestions", "Name", c => c.Int(nullable: false));
        }
    }
}
