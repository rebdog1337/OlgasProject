using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Sign_Off_Sheet.Models
{
    public class JobObject
    {
        public int JobID { get; set; }

        public DateTime Date { get; set; }

        public int JobNumber { get; set; }

        public string SMprogrammeIssue { get; set; }

        public string PasteType { get; set; }

        public int ChangeNotes { get; set; }

        public int ConcessionNum { get; set; }

        public bool PCBCheckRequired { get; set; }

        public int BatchNumber { get; set; }

        public int LineNumber { get; set; }

        public string PCBSide { get; set; }

        public string TypeFirstOff { get; set; }

        public int ERMN { get; set; }
        
    }
}
