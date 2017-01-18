using Filey.Properties;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Filey.Models
{
    public class FileyContext
    {
        public IMongoDatabase Database;
        public IMongoCollection<BaseFile> BaseFileCollection => Database.GetCollection<BaseFile>("basefile");
        public FileyContext()
        {
            var client = new MongoClient(Settings.Default.FileyConnectionString);
            Database = client.GetDatabase(Settings.Default.FileyDatabase);
        }
    }
}