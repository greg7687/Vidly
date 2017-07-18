namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomerBirthdate : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers Set Birthdate = '07/06/1987' WHERE Id = 1");
        }
        
        public override void Down()
        {
        }
    }
}
