using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyEntityTest.Data;
using MyEntityTest.Data1;

namespace MyEntityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Database.SetInitializer<SchoolDBEntities>(null);
            //            EntityQuery();
            //            Poem();
            //            Artist();
            Order();

            Console.ReadLine();
        }

        public static void EntitySql()
        {
            using (var conn = new EntityConnection("Name=SchoolDBEntities"))
            {
                conn.Open();
                var command = conn.CreateCommand();
                command.CommandText = "SELECT Name FROM SchoolDBEntities.Student AS c";
                var rd = command.ExecuteReader(CommandBehavior.SequentialAccess);
                while (rd.Read())
                {
                    Console.WriteLine(rd["Name"]);
                }
            }
        }

        public static void EntityQuery()
        {
            using (var db = new SchoolDBEntities())
            {
                var list = db.Student.ToList();
                list.ForEach(a => Console.WriteLine($"我的名字是{a.Name}"));
            }
        }

        public static void AddStudent()
        {
            using (var db = new SchoolDBEntities())
            {
                var student = new Student
                {
                    Name = "李怡然"
                    //                    RowVersion = 
                };
            }
        }

        public static void Poem()
        {
            using (var db = new ShirenEntities())
            {
                var poem = new Poem { Name = "赠汪伦" };
                var poet = new Poet { Name = "李白" };
                var meter = new Meter { TypeName = "赠友" };
                poem.Poet = poet;
                poem.Meter = meter;
                db.Poem.Add(poem);

                poem = new Poem
                {
                    Name = "登黄鹤楼",
                    Poet = poet,
                    Meter = meter
                };
                db.Poem.Add(poem);


                poet = new Poet { Name = "杜甫" };
                meter = new Meter { TypeName = "抒情" };
                poem = new Poem
                {
                    Name = "大漠孤烟直",
                    Poet = poet,
                    Meter = meter
                };
                db.Poem.Add(poem);

                db.SaveChanges();
            }
            using (var db = new ShirenEntities())
            {
                var poems = db.Poem.ToList();
                poems.ForEach(a => Console.WriteLine($"诗名：{a.Name}，诗人：{a.Poet.Name}，类型：{a.Meter.TypeName}"));
            }
        }

        public static void Artist()
        {
            using (var db = new ShirenEntities())
            {
                var artist = new Artist { Name = "钱钟书" };
                var album1 = new Album { Name = "围城" };
                var album2 = new Album { Name = "我和那女孩" };
                artist.Albums.Add(album1);
                artist.Albums.Add(album2);

                var album = new Album { Name = "梦里花落知多少" };
                var artist1 = new Artist { Name = "郭敬明" };
                var artist2 = new Artist { Name = "三毛" };
                album.Artists.Add(artist1);
                album1.Artists.Add(artist2);

                db.Artist.Add(artist);
                db.Album.Add(album);
                db.SaveChanges();
            }
            using (var db = new ShirenEntities())
            {
                var artist = db.Artist.FirstOrDefault();
                var album = db.Album.FirstOrDefault();
                if (artist == null) return;
                Console.WriteLine($"我是作者{artist.Name}，我的作品有：");
                foreach (var item in artist.Albums)
                {
                    Console.WriteLine("\t" + item.Name);
                }
                if (album == null) return;
                Console.WriteLine($"作品《{album.Name}》的作者是：");
                foreach (var item in album.Artists)
                {
                    Console.WriteLine("\t" + item.Name);
                }
            }
        }

        public static void Order()
        {
            using (var db = new ShirenEntities())
            {
                var order = new Order { Customer = "孙小双", Time = DateTime.Now };
                var item1 = new Item { Price = 28, Name = "苹果" };
                var item2 = new Item { Price = 39, Name = "猕猴桃" };
                order.OrderItems.Add(new OrderItem{Count = 2, Item = item1});
                order.OrderItems.Add(new OrderItem{Count = 5, Item = item2 });
                db.Order.Add(order);
                db.SaveChanges();
            }
            using (var db = new ShirenEntities())
            {
                var order = db.Order.FirstOrDefault();
                if (order == null) return;
                Console.WriteLine($"客户{order.Customer}在{order.Time:yyyy-MM-dd HH:mm:ss}下单：");
                Console.WriteLine($"\t商品\t总数\t单价");
                foreach (var item in order.OrderItems)
                {
                    Console.WriteLine($"\t{item.Item.Name}\t{item.Count}\t{item.Item.Price:C}");
                }
            }
        }

    }
}
