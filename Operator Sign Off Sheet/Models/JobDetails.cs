using Operator_Sign_Off_Sheet.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Sign_Off_Sheet.Models
{
    class JobDetails
    {
        public JobsTbl JobFromDB { get; set; }

        public override string ToString()
        {
            return "Date: " + this.JobFromDB.Date + Environment.NewLine + "Job Number: " + this.JobFromDB.JobNumber + Environment.NewLine + "Job Issue: " + this.JobFromDB.JobIssue
                + Environment.NewLine + "SM Issue: " + this.JobFromDB.SMIssue + Environment.NewLine + "Batch Number: " + this.JobFromDB.BatchNumber + Environment.NewLine + "Type of paste: " + this.JobFromDB.PasteType
                + Environment.NewLine + "ERMN: " + this.JobFromDB.ERMN + Environment.NewLine + "CCP Number: " + this.JobFromDB.CCP + Environment.NewLine + "Line Number: " + this.JobFromDB.LineNo + Environment.NewLine + "PCB Side: " + this.JobFromDB.PCBSide
                + Environment.NewLine + "Type of 1st off: " + this.JobFromDB.TypeOf1stOff + Environment.NewLine;
        }

    }
}
