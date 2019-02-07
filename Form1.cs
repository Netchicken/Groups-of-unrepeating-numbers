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
    using System.IO;

    public partial class Form1 : Form
    {
        private Students myStudents = new Students();


        public Form1()
        {
            InitializeComponent();

            this.Text = "Generating Counselling Triads";
            //   Operations.StudentNames.AddRange(LoadNames().ToArray());
            //   Operations.StudentNameCount = Operations.StudentNames.Count;
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            lbxOutputNames.Items.Clear();
            lbxOutputNames.Items.AddRange(Operations.StudentNames.ToArray());

            myStudents = new Students();

            //Instantiate the lists = names

            int countTo = Operations.StudentNameCount + 1;
            myStudents.StudentHistory = new List<string>[countTo];

            for (int i = 1; i < countTo; i++)
            {
                myStudents.StudentHistory[i] = new List<string>();
            }
            lbxOutput.Items.Clear();

            GenerateGroups();
            GenerateNameGroups();
        }


        private void GenerateGroups()
        {
            //need to have a list of all students to record all students they have been in a group with
            //output to date = 25 groups

            //All students have a list that contains all the students they have been in a group with before.

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
                        GenerateMembers();

                        //you can have a PAIR of people in a group with history
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

                        OutputGroups();
                    }

                }
                // this.Text = myStudents.Countgroups.ToString();
                btnCalc.Text = "Groups Generated = " + myStudents.Countgroups.ToString();
            }
        }

        private void GenerateNameGroups()
        {
            lbxOutputNames.Items.Clear();
            foreach (var items in myStudents.GeneratedGroups)
            {
                lbxOutputNames.Items.Add(Operations.StudentNames[items[0] - 1] + "  |  " + Operations.StudentNames[items[1] - 1] + "  |  " + Operations.StudentNames[items[2] - 1]);
            }
        }



        private void OutputGroups()
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
                lbxOutput.Items.Add(Group);
                myStudents.SingleGroup.Clear(); //empty the list ready for the next one
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

        private void rbUniques_CheckedChanged(object sender, EventArgs e)
        {

            if (rbUniques.Checked == true)
            {
                Operations.IsUnique = true;
                lbxOutput.Items.Clear();
                btnCalc.Text = "Generate Groups ";
            }
        }

        private void rbNonUnique_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNonUnique.Checked == true)
            {
                Operations.IsUnique = false;
                lbxOutput.Items.Clear();
                btnCalc.Text = "Generate Groups ";
            }

        }

        private void rbnRnd_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnRnd.Checked == true)
            {
                Operations.IsRnd = true;
                lbxOutput.Items.Clear();
                btnCalc.Text = "Generate Groups ";
            }
            else
            {
                Operations.IsRnd = false;
            }
        }


        private void btnLoadNames_Click(object sender, EventArgs e)
        {
            LoadNames();
        }

        private void LoadNames()
        {
            string[] error = { "No Names", "No Luck", "Its not in the correct place" };
            //if the ofd clicked is Open (Yes or OK) then ...
            if (ofd.ShowDialog() == DialogResult.OK)
            {

                //used a list as its just easier
                List<string> lines = new List<string>();

                //If the file exists then load it
                if (File.Exists(ofd.FileName))
                {
                    // Read in lines from file.
                    foreach (string line in File.ReadLines(ofd.FileName))
                    {
                        lines.Add(line);
                    }
                    //   return lines;
                }

                // return error;

                Operations.StudentNames.AddRange(lines.ToArray());
                Operations.StudentNameCount = Operations.StudentNames.Count;

                lbxOutputNames.Items.Clear();
                lbxOutputNames.Items.AddRange(Operations.StudentNames.ToArray());

                //                // show the file name you have selected

                //                StreamReader reader = new StreamReader(ofd.FileName);

                //                string text = "";
                //                //note the new ! = NOT so while its NOT end of the stream
                //                while (!reader.EndOfStream)
                //                {
                //                    text += reader.ReadLine();
                //                }

                ////Operations.LoadNames() = text;
                //                reader.Close();
            }

            //   return error;
        }


        private void lbxOutputNames_SizeChanged_1(object sender, EventArgs e)
        {
            //   lbxOutputNames.Items.Clear();


        }



        private void btnPrint_Click(object sender, EventArgs e)
        {
            string DateString = "";
            DateTime date = DateTime.Now;

            //hates saving with date symbols https://stackoverflow.com/questions/7348768/the-given-paths-format-is-not-supported
            //  DateString = "\\" + date.ToShortDateString() + " Student List " + date.ToShortTimeString() + ".txt";

            Operations.PrintCount++;
            DateString = "Counselling Student List " + Operations.PrintCount + ".txt";
            List<string> Allgroups = new List<string>();


            foreach (var line in lbxOutputNames.Items)
            {
                Allgroups.Add(line.ToString());
            }

            string path = Directory.GetCurrentDirectory();
            string docPath =
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //https://docs.microsoft.com/en-us/dotnet/api/system.io.file.writealllines?view=netframework-4.7.2
            File.WriteAllLines(Path.Combine(docPath, DateString), Allgroups);

            MessageBox.Show("File printed to Desktop");
        }
    }


}