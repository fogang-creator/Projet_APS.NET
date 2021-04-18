using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Metier;
using Metier.Domaine;

namespace HelpDeskweb.Controllers
{
    public class MotifsController : Controller
    {
        private ModelTicket db = new ModelTicket();

        // GET: Motifs
        public async Task<ActionResult> Index()
        {
            return View(await db.Motifs.ToListAsync());
        }

        // GET: Motifs/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Motif motif = await db.Motifs.FindAsync(id);
            if (motif == null)
            {
                return HttpNotFound();
            }
            return View(motif);
        }

        // GET: Motifs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Motifs/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "motifID,Libelle")] Motif motif)
        {
            if (ModelState.IsValid)
            {
                db.Motifs.Add(motif);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(motif);
        }

        // GET: Motifs/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Motif motif = await db.Motifs.FindAsync(id);
            if (motif == null)
            {
                return HttpNotFound();
            }
            return View(motif);
        }

        // POST: Motifs/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "motifID,Libelle")] Motif motif)
        {
            if (ModelState.IsValid)
            {
                db.Entry(motif).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(motif);
        }

        // GET: Motifs/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Motif motif = await db.Motifs.FindAsync(id);
            if (motif == null)
            {
                return HttpNotFound();
            }
            return View(motif);
        }

        // POST: Motifs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Motif motif = await db.Motifs.FindAsync(id);
            db.Motifs.Remove(motif);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
