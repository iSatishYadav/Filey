using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Filey.Models;
using MongoDB.Bson;

namespace Filey.Tests.Models
{
    [TestClass]
    public class BaseFileTest
    {
        [TestMethod]
        public void ToDocument_WithId_RepresentedAsObjectId()
        {
            var baseFile = new BaseFile { Id = ObjectId.GenerateNewId().ToString(), Description = "Hello World", Name = "Dummy File" };
            var fileBson = baseFile.ToBsonDocument();
            Assert.AreEqual(fileBson["_id"].BsonType, BsonType.ObjectId);
        }
    }
}
