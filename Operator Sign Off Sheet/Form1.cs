using Operator_Sign_Off_Sheet.Database;
using Operator_Sign_Off_Sheet.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operator_Sign_Off_Sheet.Views;

namespace Operator_Sign_Off_Sheet
{
    public partial class Form1 : Form
    {
        int _jobID = 0;
        public Form1()
        {
            InitializeComponent();
            comboBoxBatchNumbers.Items.AddRange(GetJobsFromDB().ToArray());
            CommonMethods common = new CommonMethods();
            var items = DatabaseInterface.GetAllJobs();

            var itemsInList = common.JobObjectsFromDataTable(items);

            foreach (DataRow item in items.Rows)
            {
                MessageBox.Show(item.Field<int>("BatchNumber").ToString());
            }

            itemsInList[0].Date = DateTime.Now;

            bool success = DatabaseInterface.UpdateJob(itemsInList[0]);

            var items2 = DatabaseInterface.GetAllJobs();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            
            DateTime theDate = DateTime.UtcNow;

            string custom = theDate.ToString("U");

            MessageBox.Show(custom);


        }

        private void CSM1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pre1stBoard newBoard = new Pre1stBoard();
            newBoard.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBoxBatchNumbers.SelectedItem != null)
            {
                LoadJob(_jobID);
            }
        }

        private void LoadJob(int JobID)
        {
            // clear the list of current selected job (if one)
            richTextBoxJobDetails.Text = "";
            // create connection to our database
            using (LinqToOlgaDBDataContext con = new LinqToOlgaDBDataContext())
            {
                // SQL query using linq that will find a job in the database that maches the select JobID
                var getTheJob = from a in con.JobsTbls
                                where a.JobID == JobID
                                select a;

                
                    JobDetails jon = new JobDetails()
                    {
                        JobFromDB = getTheJob.First()
                    };

                    richTextBoxJobDetails.Text = jon.ToString();
                


                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //get list of current jobs that are in database
        }

        /// <summary>
        /// Gets the current jobs from the database
        /// </summary>
        /// <returns></returns>
        private List<JobsTbl> GetJobsFromDB()
        {
            using (LinqToOlgaDBDataContext con = new LinqToOlgaDBDataContext())
            {
                // get all jobs from the database
                return con.JobsTbls.ToList();
            }
        }

        private void comboBoxBatchNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {
            // check if the user has selected an item before doing something with it
            if (comboBoxBatchNumbers.SelectedItem != null)
            {
                // cast the selected item as a JobTbl object then save the JobID in a varible
                _jobID = ((JobsTbl)comboBoxBatchNumbers.SelectedItem).JobID;
            }
        }

        private void buttonPreFirstWizard_Click(object sender, EventArgs e)
        {
            PreFirstBoardWizard pre1stWizard = new PreFirstBoardWizard();
            pre1stWizard.ShowDialog();
        }
    }
}
