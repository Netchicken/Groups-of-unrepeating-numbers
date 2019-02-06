using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounsellingTriads
{
    class Students
    {
        public List<string> SingleGroup = new List<string>();
        public List<string>[] StudentHistory = new List<string>[22];
        //  public List<string> studentHistory = new List<string>();

        public bool IsUnique = true; //Unique or NonUnique groups
        public bool IsRnd = false; //using the rnd radiobutton
        public bool HasStudentBeenBefore = false;
        public bool HasOneStudentBeenAdded = false;
        public string student = null;
        public string StudentToAdd = null;

        public int Countgroups = 0;
        public int CountStudents = 21;
        public Random MyRnd = new Random();

    }
}
