using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using REST.Model.Entity;

namespace REST.MongoTest
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Mongo Sample

            DbContext<Book> ctx = new DbContext<Book>();
            Book book = new Book { Title = "Havkeye", ISBN = "787878787", Publisher = "Clint Barton" };

            //ctx.Collection.Save(book);
            var id = new ObjectId("5553d72749e25a3e987c8087");
            var xxx = ctx.Collection.AsQueryable().ToList().Where(x=> x.Id == id).FirstOrDefault();

            DbContext<Persons> ctxPersons = new DbContext<Persons>();
            var toUpdate = ctxPersons.Collection.AsQueryable().First();

            toUpdate.Name = "Edboard";
            toUpdate.Surname = "Thawne";

            //ctxPersons.Collection.Save(toUpdate);

            Persons person2 = new Persons
            {
                Name = "Adam",
                Surname = "Qwe"
            };

            //ctxPersons.Collection.Save(person2);

            //person 3
            Persons person3 = new Persons
            {
                Name = "Ada",
                Surname = "Asd"
            };

            //ctxPersons.Collection.Save(person3);


            //remove
            //ctxPersons.Collection.Remove(Query<Persons>.EQ(x=> x.Name, "Adam"));
            var query = Query.And(Query<Persons>.EQ(x => x.Name, "Adam"), Query<Persons>.EQ(x => x.Name, "Ada"));
            //ctxPersons.Collection.Remove(query);

            //ctxPersons.Collection.Save(person);
           

            #endregion

            
            Console.ReadKey();
        }
    }
}
