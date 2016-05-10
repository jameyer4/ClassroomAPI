using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ClassroomAPI.Models;
using ClassroomAPI.Models.DB_Models;

namespace ClassroomAPI.Controllers
{
    public class TeacherSubjectsController : ApiController
    {
        private ClassroomContext db = new ClassroomContext();

        // GET: api/TeacherSubjects
        public IQueryable<TeacherSubjects> GetTeacherSubjects()
        {
            return db.TeacherSubjects;
        }

        // GET: api/TeacherSubjects/5
        [ResponseType(typeof(TeacherSubjects))]
        public IHttpActionResult GetTeacherSubjects(int id)
        {
            TeacherSubjects teacherSubjects = db.TeacherSubjects.Find(id);
            if (teacherSubjects == null)
            {
                return NotFound();
            }

            return Ok(teacherSubjects);
        }

        // PUT: api/TeacherSubjects/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTeacherSubjects(int id, TeacherSubjects teacherSubjects)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != teacherSubjects.Id)
            {
                return BadRequest();
            }

            db.Entry(teacherSubjects).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeacherSubjectsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/TeacherSubjects
        [ResponseType(typeof(TeacherSubjects))]
        public IHttpActionResult PostTeacherSubjects(TeacherSubjects teacherSubjects)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.TeacherSubjects.Add(teacherSubjects);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = teacherSubjects.Id }, teacherSubjects);
        }

        // DELETE: api/TeacherSubjects/5
        [ResponseType(typeof(TeacherSubjects))]
        public IHttpActionResult DeleteTeacherSubjects(int id)
        {
            TeacherSubjects teacherSubjects = db.TeacherSubjects.Find(id);
            if (teacherSubjects == null)
            {
                return NotFound();
            }

            db.TeacherSubjects.Remove(teacherSubjects);
            db.SaveChanges();

            return Ok(teacherSubjects);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TeacherSubjectsExists(int id)
        {
            return db.TeacherSubjects.Count(e => e.Id == id) > 0;
        }
    }
}