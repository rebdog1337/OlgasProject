using Operator_Sign_Off_Sheet.Database.OperatorSignOffDSTableAdapters;
using Operator_Sign_Off_Sheet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operator_Sign_Off_Sheet.Database
{
    public static class DatabaseInterface
    {
        /// <summary>
        /// Gets all jobs from the access database
        /// </summary>
        /// <returns>DateTable that contains rows from the JobTbl table</returns>
        public static DataTable GetAllJobs()
        {
            JobsTblTableAdapter tableAdap = new JobsTblTableAdapter();
            DataTable jobs = tableAdap.GetAllJobs();

            // returns
            return jobs;
        }



        /// <summary>
        /// Returns rows from JobTbl that have dates between selected dates
        /// </summary>
        /// <param name="from">Date from</param>
        /// <param name="to">Date to</param>
        /// <returns></returns>
        public static DataTable GetJobsBetweenDates(DateTime from, DateTime to)
        {
            JobsTblTableAdapter tableAdap = new JobsTblTableAdapter();
            DataTable jobs = tableAdap.GetJobsBetween(from,to);
            return jobs;
        }


        /// <summary>
        /// Inserts new job into the database
        /// </summary>
        /// <param name="newJob">New job data</param>
        /// <returns>true if successful</returns>
        public static bool InsertNewJob(JobObject newJob)
        {
            JobsTblTableAdapter jobTableAdaptor = new JobsTblTableAdapter();
            try
            {
                jobTableAdaptor.InsertNewJob(newJob.Date, newJob.JobNumber, newJob.SMprogrammeIssue, newJob.PasteType,
               newJob.ChangeNotes, newJob.ConcessionNum, newJob.PCBCheckRequired, newJob.BatchNumber, newJob.LineNumber, newJob.PCBSide, newJob.TypeFirstOff, newJob.ERMN
               );

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
           
        }

        /// <summary>
        /// Updates a job using a matching JobID
        /// </summary>
        /// <param name="update">Job updated details</param>
        /// <returns>true if successful</returns>
        public static bool UpdateJob(JobObject update)
        {
            JobsTblTableAdapter jobTableAdaptor = new JobsTblTableAdapter();
            try
            {
                jobTableAdaptor.UpdateJob(update.Date, update.JobNumber, update.SMprogrammeIssue, update.PasteType,
             update.ChangeNotes, update.ConcessionNum, update.PCBCheckRequired, update.BatchNumber, update.LineNumber, update.PCBSide, update.TypeFirstOff, update.ERMN, update.JobID);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
          
        }
    }
}
