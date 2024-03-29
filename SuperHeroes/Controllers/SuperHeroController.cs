﻿using SuperHeroes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperHeroes.Controllers
{
    public class SuperHeroController : Controller
    {
        ApplicationDbContext contex;
        public SuperHeroController()
        {
            contex = new ApplicationDbContext();
        }
        // GET: SuperHero
        public ActionResult Index()
        {
            var superhero = contex.SuperHero.ToList();
            // List<SuperHero> SuperHero = new List<SuperHero>();
            return View(superhero);
        }

        // GET: SuperHero/Details/5
        public ActionResult Select(int id)
        {
            var superhero = contex.SuperHero.Find(id);
            return View(superhero);
        }

        // GET: SuperHero/Create
        public ActionResult Create()
        {
            SuperHero superhero = new SuperHero();
            return View(superhero);
        } 

        // POST: SuperHero/Create
        [HttpPost]
        public ActionResult Create(SuperHero superhero)
        {
            try
            {
                // TODO: Add insert logic here
                contex.SuperHero.Add(superhero);
                contex.SaveChanges();
                return RedirectToAction("Index", "SuperHero");
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHero/Edit/5
        public ActionResult Edit(int id)
        {
            var superhero = contex.SuperHero.Find(id);            
            return View(superhero);
        }

        // POST: SuperHero/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, SuperHero superHero)
        {
            try
            {
                var superhero = contex.SuperHero.Find(id);
                superhero.SuperHeroNAme = Request.Form["SuperHeroName"];
                superhero.AlterEgoName = Request.Form["AlterEgoName"];
                superhero.PrimarySuperHeroAbility = Request.Form["PrimarySuperHeroAbility"];
                superhero.SecondarySuperheroAbility = Request.Form["SecondarySuperheroAbility"];
                superhero.CatchPhrase = Request.Form["CatchPhrase"];
                contex.SaveChanges();
                return RedirectToAction("Index","SuperHero");
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHero/Delete/5
        public ActionResult Delete(int id)
        {
            var superhero = contex.SuperHero.Find(id);
            return View(superhero);
        }

        // POST: SuperHero/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                SuperHero superhero = contex.SuperHero.Find(id);
                contex.SuperHero.Remove(superhero);
                contex.SaveChanges();
                
                return RedirectToAction("Index", "SuperHero");
            }
            catch
            {
                return View();
            }
        }
    }
}
