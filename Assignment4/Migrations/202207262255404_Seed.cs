namespace Assignment4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seed : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO SIZES (Type,Price) VALUES ('XS','2')");
            Sql("INSERT INTO SIZES (Type,Price) VALUES ('S','3')");
            Sql("INSERT INTO SIZES (Type,Price) VALUES ('M','4')");
            Sql("INSERT INTO SIZES (Type,Price) VALUES ('L','5')");
            Sql("INSERT INTO SIZES (Type,Price) VALUES ('XL','6')");
            Sql("INSERT INTO SIZES (Type,Price) VALUES ('XXL','7')");
            Sql("INSERT INTO SIZES (Type,Price) VALUES ('XXXL','8')");
            Sql("INSERT INTO FABRICS (Type,Price) VALUES ('WOOL','4')");
            Sql("INSERT INTO FABRICS (Type,Price) VALUES ('COTTON','6')");
            Sql("INSERT INTO FABRICS (Type,Price) VALUES ('POLYESTER','1')");
            Sql("INSERT INTO FABRICS (Type,Price) VALUES ('RAYON','10')");
            Sql("INSERT INTO FABRICS (Type,Price) VALUES ('LINEN','3')");
            Sql("INSERT INTO FABRICS (Type,Price) VALUES ('CASHMERE','9')");
            Sql("INSERT INTO FABRICS (Type,Price) VALUES ('SILK','7')");
            Sql("INSERT INTO COLORS (Type,Price) VALUES ('WHITE','1')");
            Sql("INSERT INTO COLORS (Type,Price) VALUES ('RED','2')");
            Sql("INSERT INTO COLORS (Type,Price) VALUES ('ORANGE','2')");
            Sql("INSERT INTO COLORS (Type,Price) VALUES ('YELLOW','2')");
            Sql("INSERT INTO COLORS (Type,Price) VALUES ('GREEN','2')");
            Sql("INSERT INTO COLORS (Type,Price) VALUES ('BLUE','2')");
            Sql("INSERT INTO COLORS (Type,Price) VALUES ('INDIGO','3')");
            Sql("INSERT INTO COLORS (Type,Price) VALUES ('VIOLET','2')");

        }

        public override void Down()
        {
        }
    }
}
