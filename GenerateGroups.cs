namespace CounsellingTriads
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    //todo Move the methods from the Form to this class and set up for Unit Testing
    public static class GenerateStudentGroups
    {
        public static IEnumerable<string> GenerateGroups(Students myStudents)
        {
            //need to have a list of all students to record all students they have been in a group with
            //output to date = 25 groups

            //All students have a list that contains all the students they have been in a group with before.

            List<string> AddGroups = new List<string>();


            int UpperLimit = Operations.StudentNameCount + 1;
            for (int k = 1; k < UpperLimit; k++) //get all permutations
            {
                for (int i = k; i < UpperLimit; i++)
                {
                    //reset for next student
                    myStudents.student = null;
                    myStudents.HasOneStudentBeenAdded = false;
                    myStudents.HasStudentBeenBefore = false;
                    myStudents.StudentToAdd = null;  //reset it to null

                    //if random then generate rnd student number and use that
                    if (Operations.IsRnd == true)
                    {
                        myStudents.student = myStudents.MyRnd.Next(1, UpperLimit).ToString();
                    }
                    else //for other conditions
                    {
                        myStudents.student = i.ToString(); //iterate though for loop
                    }
                    //Need to add the first member manually or it crashes at the foreach

                    if (myStudents.SingleGroup.Count == 0) //add in the first student manually
                    {
                        myStudents.SingleGroup.Add(myStudents.student);

                        myStudents.StudentHistory[1].Add(myStudents.student);
                    }
                    else
                    {
                        GenerateMembers(myStudents);

                        //you can have a PAIR of people in a group with history
                        //todo why rnd == false?
                        if (Operations.IsUnique == false && Operations.IsRnd == false)
                        {

                            //add the student to the group HasStudentBeenBefore == true &&
                            if (myStudents.HasOneStudentBeenAdded == false)
                            {
                                myStudents.HasOneStudentBeenAdded = true;
                                myStudents.SingleGroup.Add(myStudents.StudentToAdd);
                            }
                        }

                        else
                        {
                            //Uniques Only
                            //add the student to the group
                            if (myStudents.HasStudentBeenBefore == false)
                            {
                                myStudents.SingleGroup.Add(myStudents.StudentToAdd);
                            }
                        }
                        //pass in the line of the numbers 1,2,3
                        string line = OutputGroups(myStudents);

                        if (!string.IsNullOrEmpty(line))
                        {
                            AddGroups.Add(line);
                        }

                    }

                }

            }
            return AddGroups;
        }

        /// <summary>
        /// Return the numbers generated as a string 1,2,3
        /// </summary>
        /// <param name="myStudents"></param>
        /// <returns></returns>
        private static string OutputGroups(Students myStudents)
        {
            //if the group has reached 3 then print it and clear it for the next group
            if (myStudents.SingleGroup.Count == 3)
            {
                String Group = null;
                myStudents.HasOneStudentBeenAdded = false; // reset for new group

                int[] singleGroup = new int[3];//get an array of 3
                int count = 0;//get a counter that goes to 3
                foreach (var item in myStudents.SingleGroup)
                {
                    Group += item + " ";
                    singleGroup[count] = Convert.ToInt16(item); // add in the 3 items
                    count++;
                }
                myStudents.GeneratedGroups.Add(singleGroup); //list of arrays
                myStudents.Countgroups++;
                Operations.GroupsCount++;
                myStudents.SingleGroup.Clear(); //empty the list ready for the next one
                return Group;  //string 1,2,3
            }

            return null;

        }





        private static void GenerateMembers(Students myStudents)
        {
            foreach (var AGroupStudent in myStudents.SingleGroup) // for each person in the group
            { //convert the person to an int to find their history list
                int GroupStudent = Convert.ToInt32(AGroupStudent);

                if (!myStudents.StudentHistory[GroupStudent].Contains(myStudents.student))
                {
                    //if the student isn't in the group, and they have never been with the others then add them
                    if (myStudents.HasStudentBeenBefore == false)
                    {
                        myStudents.StudentToAdd = myStudents.student;
                    }
                    //add that person to the history of the others
                    myStudents.StudentHistory[GroupStudent].Add(myStudents.student);
                }
                else //they have met that person before
                {
                    myStudents.HasStudentBeenBefore = true;


                    ////add the student to the list to be saved if the non unique is true
                    //todo what the heck was I thinking here?
                    //  if (IsUnique == true)
                    //  {
                    myStudents.StudentToAdd = myStudents.student;
                    //  }
                    //  break; //stop this foreach and go back to For
                }
            }
        }


    }
}