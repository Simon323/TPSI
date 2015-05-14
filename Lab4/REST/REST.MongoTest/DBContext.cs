using MongoDB.Driver;

namespace REST.MongoTest
{
    public class DbContext<T>
        where T : class 
    {
        private MongoDatabase db;

        public DbContext()
        {
            MongoClientSettings settings = new MongoClientSettings();
            settings.Server = new MongoServerAddress("localhost", 27017);

            MongoClient client = new MongoClient(settings);
            var server = client.GetServer();
            this.db = server.GetDatabase("bookStore");
            var collection = db.GetCollection<T>(typeof(T).Name);
        }

        public MongoCollection<T> Collection
        {
            get { return db.GetCollection<T>(typeof(T).Name); }
        } 
    }
}