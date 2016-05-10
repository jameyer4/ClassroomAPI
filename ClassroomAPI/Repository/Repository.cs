﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClassroomAPI.Repository
{
    public class Repository
    {
        public GetMarks Marks()
        {
            GetMarks marks = new GetMarks();
            return marks;
        }
        public GetStudents Students()
        {
            GetStudents students = new GetStudents();
            return students;
        }
        public GetSubjects Subjects()
        {
            GetSubjects subjects = new GetSubjects();
            return subjects;
        }
        public GetTeachers Teachers()
        {
            GetTeachers teachers = new GetTeachers();
            return teachers;
        }
    }
}