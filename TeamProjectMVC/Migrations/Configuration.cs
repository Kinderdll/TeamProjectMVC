namespace TeamProjectMVC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TeamProjectMVC.Models.Model>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TeamProjectMVC.Models.Model context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Products.AddOrUpdate(
                new Models.Product { ProductName = "Sasmsung Galaxy A5 2017(16GB)", Description = "�����: 5.2,RAM: 3 GB,������: 16 MP,������: 4G,������� CPU: 8,SIM: Single,��������: 3000 mAh,���������: ���������,�������������: Samsung", Price = 290, ImgPath = "a5.jpg" },
                new Models.Product { ProductName = "Samsung Galaxy A3 2017 (16GB)", Description = "�����: 4.7,RAM: 2 GB,������: 13 MP,������: 4G,������� CPU: 8,SIM: Single,��������: 2350 mAh,���������: ���������,�������������: Samsung", Price = 212, ImgPath = "a3.jpg" },
                new Models.Product { ProductName = "Huawei P10 (64GB)", Description = "�����: 5.1, RAM: 4 GB, ������: 12 MP, ������: 4G, ������� CPU: 4+4, SIM: Single, ��������: 3200 mAh , �������������: Huawei",Price = 449, ImgPath = "p10.jpeg" },
                new Models.Product { ProductName = "Huawei P10 Lite (4GB/32GB)", Description = "�����: 5.2,RAM: 4 GB,������: 12 MP,������: 4G,������� CPU: 4 + 4,SIM: Single,��������: 3000 mAh,�������������: Huawei", Price = 329, ImgPath = "p10lite.jpeg" },
                new Models.Product { ProductName = "Apple iPhone 7(32GB)",Description = "�����: 4.7, RAM: 2 GB, ������: 12 MP, ������: 4G, ������� CPU: 4, SIM: Single, ��������: 1960 mAh, ���������: ��������� , �������������: Apple", Price = 571, ImgPath = "iph7.jpg" },
                new Models.Product { ProductName = "Apple iPhone 7 Plus (32GB)", Description = "�����: 5.5,RAM: 3 GB,������: 12 MP,������: 4G,������� CPU: 4,SIM: Single,��������: 2900 mAh,���������: ���������,�������������: Apple",Price = 717, ImgPath = "iph7plus.jpg" },
                new Models.Product { ProductName = "HTC 10 (32GB)", Description = "�����: 5.2, RAM: 4 GB, ������: 12 MP, ������: 4G, ������� CPU: 2+2, SIM: Single, ��������: 3000 mAh , �������������: HTC", Price = 442, ImgPath = "htc10.jpg" },
                new Models.Product { ProductName = "HTC One M9 (32GB)", Description = "�����: 5, RAM: 3 GB, ������: 20 MP, ������: 4G, ������� CPU: 4+4, SIM: Single, ��������: 2840 mAh , �������������: HTC",Price = 277, ImgPath = "htcm9.jpg" },
                new Models.Product { ProductName = "MLS iQTalk Verse 4G (8GB)", Description = "�����: 4, RAM: 1 GB, ������: 8 MP, ������: 4G, ������� CPU: 4, SIM: Single, ��������: 1500 mAh , �������������: MLS",Price = 89, ImgPath = "mlsiqtalk4g.jpg" },
                new Models.Product { ProductName = "MLS Easy S (8GB)", Description = "�����: 2.8, RAM: 1 GB, ������: 3.2 MP, ������: 4G, ������� CPU: 4, SIM: Dual, ��������: 1800 mAh , �������������: MLS",Price =104 , ImgPath = "mlseasy.jpg" },
                new Models.Product { ProductName = "LG G6 (32GB)", Description=" �����: 5.7, RAM: 4 GB, ������: 13 MP, ������: 4G, ������� CPU: 2+2, SIM: Single, ��������: 3300 mAh, ���������: ��������� , �������������: LG",Price = 516, ImgPath = "lgg6.jpg" },
                new Models.Product { ProductName = "LG G5 SE (32GB)", Description = "�����: 5.3, RAM: 3 GB, ������: 16 MP, ������: 4G, ������� CPU: 4+4, SIM: Single, ��������: 2800 mAh , �������������: LG", Price = 282, ImgPath = "lgg5se.jpg" },
                new Models.Product { ProductName = "LG K10 (16GB)", Description = "�����: 5.3, RAM: 1.5 GB, ������: 13 MP, ������: 4G, ������� CPU: 4, SIM: Single, ��������: 2300 mAh , �������������: LG",Price = 117, ImgPath = "lgk10.jpg" },
                new Models.Product { ProductName = "Samsung Galaxy J1 2016 (8GB)", Description = "�����: 4.5, RAM: 1 GB, ������: 5 MP, ������: 4G, ������� CPU: 4, SIM: Single, ��������: 2050 mAh , �������������: Samsung",Price = 136, ImgPath = "j12016.jpg" },
                new Models.Product { ProductName = "Alcatel OneTouch Pixi 4 (5) 3G (8GB)", Description = "�����: 5, RAM: 1 GB, ������: 8 MP, ������: 3G, ������� CPU: 4, SIM: Dual, ��������: 2000 mAh , �������������: Alcatel",Price = 74, ImgPath = "pixi4.jpg" },
                new Models.Product { ProductName = "Sony Xperia Z5 (32GB)", Description = "�����: 5.2, RAM: 3 GB, ������: 23 MP, ������: 4G, ������� CPU: 4+4, SIM: Single, ��������: 2900 mAh, ���������: ��������� , �������������: Sony",Price = 394, ImgPath = "sonyz5.jpg" }
               


                );
        }


    }
}
