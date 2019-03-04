using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounsellingTriads
{
    /// <summary>
    /// You can't easily test static methods. Therefore if I wrap them in a class and instantiate that I can test the output of the static class.
    /// 
    /// </summary>
    public class TestingWrapper
    {

        public int CountNumbersGenerated()
        {
            return Operations.StudentNames.Count;

        }

        public int CountUniquesGenerated(Students myStudents)
        {
            var output = GenerateStudentGroups.GenerateGroups(myStudents);
            return myStudents.Countgroups;
        }

    }
}
