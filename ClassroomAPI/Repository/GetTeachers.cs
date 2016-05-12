using System.Collections.Generic;
using System.Linq;
using ClassroomAPI.Models;
using ClassroomAPI.Models.DB_Models;

namespace ClassroomAPI.Repository
{
    public class GetUsers
    {
        private readonly ClassroomContext _db = new ClassroomContext();
        Repository rep = new Repository();
        //GetMarks marks = new GetMarks();
        //GetSubjects subjects = new GetSubjects();
        public GetUsers()
        {

        }

        public List<Users> GetAllUserss()
        {
            List<Users> users = _db.Users.ToList();
            return users;
        }

        public Users GetUsersById(int id)
        {
            Users user = _db.Users.Single(x => x.Id == id);
            return user;
        }

        public Users GetUsersByUsername(string name)
        {
            Users user = new ClassroomContext().Users.Where(x => x.UserName.Equals(name)).Single();
            return user;
        }
        public string GetUsersUsernameById(int id)
        {
            var username = _db.Users.Single(x => x.Id == id).UserName;
            return username;
        }
        public int GetUsersIdByUsername(string name)
        {
            var id = GetUsersByUsername(name).Id;
            return id;
        }
        public List<Users> GetUserssByStudentId(int id)
        {

            var markList = new GetMarks().GetMarksByStudentId(id);
            //var subjectList = subjects.GetSubjectByMarkId(.id;
            List<Subject> subjectList = new List<Subject>();
            foreach (var x in markList)
            {
                subjectList.Add(new GetSubjects().GetSubjectByMarkId(x.Id));
            }
            List<Users> users = new List<Users>();
            foreach (var x in subjectList)
            {
                users.Add(GetUsersById(x.Id));
            }
            return users;
        }
    }
}