using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;
using ClassroomAPI.Models;
using ClassroomAPI.Models.DB_Models;

namespace ClassroomAPI.Controllers
{
    public class StudentMarksController : ApiController
    {
        private ClassroomContext db = new ClassroomContext();

        // GET: api/StudentMarks
        public IQueryable<StudentMark> GetStudentMark()
        {
            return db.StudentMark;
        }

        // GET: api/StudentMarks/5
        [ResponseType(typeof(StudentMark))]
        public IHttpActionResult GetStudentMark(int id)
        {
            StudentMark studentMark = db.StudentMark.Find(id);
            if (studentMark == null)
            {
                return NotFound();
            }

            return Ok(studentMark);
        }

        // PUT: api/StudentMarks/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutStudentMark(int id, StudentMark studentMark)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != studentMark.Id)
            {
                return BadRequest();
            }

            db.Entry(studentMark).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentMarkExists(id))
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

        // POST: api/StudentMarks
        [ResponseType(typeof(StudentMark))]
        public IHttpActionResult PostStudentMark(StudentMark studentMark)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.StudentMark.Add(studentMark);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = studentMark.Id }, studentMark);
        }

        // DELETE: api/StudentMarks/5
        [ResponseType(typeof(StudentMark))]
        public IHttpActionResult DeleteStudentMark(int id)
        {
            StudentMark studentMark = db.StudentMark.Find(id);
            if (studentMark == null)
            {
                return NotFound();
            }

            db.StudentMark.Remove(studentMark);
            db.SaveChanges();

            return Ok(studentMark);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StudentMarkExists(int id)
        {
            return db.StudentMark.Count(e => e.Id == id) > 0;
        }
    }
}