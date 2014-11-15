using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operator_Sign_Off_Sheet.Database;


namespace Operator_Sign_Off_Sheet.Views
{
    public partial class AddNewJobs : Form
    {
        public AddNewJobs()
        {
            InitializeComponent();
        }

        private void AddNewJobs_Load(object sender, EventArgs e)
        {
            // set the date time picker control to default on todays date
            dateTimePicker1.Value = DateTime.Now;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a connection to our database
                // when using a 'using' statement all resources are automatically disposed after the statement
                using (LinqToOlgaDBDataContext con = new LinqToOlgaDBDataContext())
                {
                    // create a new row in database
                    JobsTbl newJob = new JobsTbl();
                    // set the date from the time picker
                    newJob.Date = dateTimePicker1.Value;
                    // get the batch number from the text box on the form
                    newJob.BatchNumber = int.Parse(textBoxBatchNo.Text);
                    // get job number from main form
                    newJob.JobNumber = (int)
                        JobNumberNUD.Value;
                    newJob.JobIssue = textBoxJobIssue.Text;
                    newJob.SMIssue = textBoxSMIssue.Text;
                    newJob.PasteType = textBoxPasteType.Text;
                    newJob.PCBSide = textBoxPCBSide.Text;
                    newJob.TypeOf1stOff = textBoxTypeOf1stOff.Text;
                    newJob.ChangeNotes = int.Parse(textBoxCnNo.Text);
                    newJob.CCP = int.Parse(textBoxCppNo.Text);
                    newJob.ERMN = int.Parse(textBoxErmnNo.Text);
                    newJob.LineNo = int.Parse(textBoxLineNo.Text);

                    // take the row we just made and when i call con.submitChanges() insert into db
                    con.JobsTbls.InsertOnSubmit(newJob);
                    // submits chnages to db
                    con.SubmitChanges();

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            // set all textboxs and fields to default when user presses this
        }
            
    }
}
