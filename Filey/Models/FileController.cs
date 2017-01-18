using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Filey.Models
{
    public class FileController : Controller
    {
        public static FileyContext Context = new FileyContext();
        // GET: File
        public async Task<ActionResult> Index()
        {
            var bsonCommand = new BsonDocument("buildinfo", 1);
            var buildinfo = await Context.Database.RunCommandAsync<BsonDocument>(bsonCommand);
            //var files = Context.BaseFileCollection.F
            return Content(buildinfo.ToJson(), "application/json");
        }

        // GET: File/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: File/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: File/Create
        [HttpPost]
        public ActionResult Create(PostFile file)
        {
            try
            {
                var baseFile = new BaseFile { Name = file.Name, Description = file.Description };

                // TODO: Add insert logic here
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: File/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: File/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: File/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: File/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
