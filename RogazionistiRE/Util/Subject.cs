using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogazionistiRE.Util {
    public class Subject {

        public int SubjectID;
        public string SubjectName;
        public string TeacherName;
        
        public Subject(string teacherName, string subjectName, int subjectID) {
            TeacherName = teacherName;
            SubjectName = subjectName;
            SubjectID = subjectID;
        }

        public string getSubjectName() {
            return SubjectName;
        }

        public string getTeacherName() {
            return SubjectName;
        }

        public int getSubjectID() {
            return SubjectID;
        }
    }
}
