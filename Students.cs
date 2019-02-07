using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounsellingTriads
{
    using System.IO;

    class Students
    {
        public List<string> SingleGroup = new List<string>();
        public List<string>[] StudentHistory = new List<string>[22];
        //  public List<string> studentHistory = new List<string>();

        public bool HasStudentBeenBefore = false;
        public bool HasOneStudentBeenAdded = false;
        public string student = null;
        public string StudentToAdd = null;

        public int Countgroups = 0;
        public int CountStudents = 21;
        public Random MyRnd = new Random();

    }

    //needs to avoid being reset
    static class Operations
    {
        public static bool IsUnique = true; //Unique or NonUnique groups
        public static bool IsRnd = false; //using the rnd radiobutton
        public static List<string> StudentNames = new List<string>();
        public static int StudentNameCount = 0;
        public static int GroupsCount = 0;


        public static IEnumerable<string> LoadNames(string fileName)
        {
            //used a list as its just easier
            List<string> lines = new List<string>();

            //If the file exists then load it
            if (File.Exists(fileName))
            {
                // Read in lines from file.
                foreach (string line in File.ReadLines(fileName))
                {
                    lines.Add(line);
                }
                return lines;
            }
            string[] error = { "No Names", "No Luck", "Its not in teh correct place" };
            return error;
        }
    }
}
