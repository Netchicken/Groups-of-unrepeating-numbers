using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CounsellingTriads
{
    public partial class Form1 : Form
    {
        private Students myStudents;


        public Form1()
        {
            InitializeComponent();

            myStudents = new Students();

            //Instantiate the lists = names
            for (int i = 1; i < 22; i++)
            {
                myStudents.StudentHistory[i] = new List<string>();
            }
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {

            lbxOutput.Items.Clear();

            GenerateGroups();
        }


        private void GenerateGroups()
        {

            //need to have a list of all students to record all students they have been in a group with
            //output to date = 25 groups

            //All students have a list that contains all the students they have been in a group with before.




            for (int k = 1; k < 21; k++) //get all permutations
            {
                for (int i = k; i < 22; i++)
                {
                    myStudents.student = null;

                    //if random then generate rnd student number and use that
                    if (myStudents.IsRnd == true)
                    {
                        myStudents.student = myStudents.MyRnd.Next(1, 22).ToString();
                    }
                    else
                    {
                        myStudents.HasOneStudentBeenAdded = false;
                        myStudents.student = i.ToString(); //iterate though for loop
                        myStudents.StudentToAdd = null;
                    }
                    //Need to add the first member manually or it crashes at the foreach

                    if (myStudents.SingleGroup.Count == 0)
                    {
                        myStudents.SingleGroup.Add(myStudents.student);
                        //  myStudents.StudentHistory[1].Add("1");
                        myStudents.StudentHistory[1].Add(myStudents.student);
                    }
                    else
                    {
                        myStudents.HasStudentBeenBefore = false;

                        GenerateMembers();

                        //you can have a pair of people in a group with history
                        if (myStudents.IsUnique == false && myStudents.IsRnd == false)
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



                        //if the group has reached 3 then print it and clear it for the next group

                        if (myStudents.SingleGroup.Count == 3)
                        {
                            String Group = null;
                            myStudents.HasOneStudentBeenAdded = false; // reset for new group
                            foreach (var item in myStudents.SingleGroup)
                            {
                                Group += item + " ";
                            }
                            myStudents.Countgroups++;
                            lbxOutput.Items.Add(Group);
                            myStudents.SingleGroup.Clear(); //empty the list ready for the next one
                        }
                    }

                }
                //  count++;
                this.Text = myStudents.Countgroups.ToString();
                // }
            }
        }

        private void GenerateMembers()
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

        //public void RandomSelection()
        //{
        //    bool isFindingAmatch = true;


        //    if (myStudents.SingleGroup.Count == 0)
        //    {
        //        myStudents.SingleGroup.Add(myStudents.student);
        //        myStudents.StudentHistory[1].Add(myStudents.student);
        //    }

        //    while (isFindingAmatch)
        //    {
        //        myStudents.student = myStudents.MyRnd.Next(1, 22).ToString();
        //        GenerateMembers();
        //    }

        //    //add the student to the group
        //    if (myStudents.HasStudentBeenBefore == false)
        //    {
        //        myStudents.SingleGroup.Add(myStudents.StudentToAdd);
        //    }


        //}

        private void rbUniques_CheckedChanged(object sender, EventArgs e)
        {

            if (rbUniques.Checked == true)
            {
                myStudents.IsUnique = true;
                lbxOutput.Items.Clear();
            }
        }

        private void rbNonUnique_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNonUnique.Checked == true)
            {
                myStudents.IsUnique = false;
                lbxOutput.Items.Clear();
            }

        }

        private void rbnRnd_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNonUnique.Checked == true)
            {
                myStudents.IsRnd = true;

                lbxOutput.Items.Clear();
            }
            else
            {
                myStudents.IsRnd = false;
            }
        }
    }


    internal class Group
    {
        public List<string> AllTeams = new List<string>();
    }

}