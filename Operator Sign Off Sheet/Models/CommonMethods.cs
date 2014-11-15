using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Sign_Off_Sheet.Models
{
    /// <summary>
    /// Common library that we can use to convert objects to useable classes
    /// </summary>
    public class CommonMethods
    {
        public List<JobObject> JobObjectsFromDataTable(DataTable table)
        {
            List<JobObject> _result = new List<JobObject>();
            foreach (DataRow row in table.Rows)
            {
                _result.Add(new JobObject()
                    {
                        Date = row.Field<DateTime>("Date"),
                        TypeFirstOff = row.Field<string>("TypeOfFirstOff"),
                        SMprogrammeIssue = row.Field<string>("SMProgramIssue"),
                        ERMN = row.Field<int>("ERMN"),
                        JobID = row.Field<int>("ID"),
                        JobNumber = row.Field<int>("JobNo"),
                        BatchNumber = row.Field<int>("BatchNumber"),
                        PasteType = row.Field<string>("TypeOfPaste"),
                        ChangeNotes = row.Field<int>("ChangeNoteNum"),
                        ConcessionNum = row.Field<int>("ConcessionNumber"),
                        LineNumber = row.Field<int>("LineNo"),
                        PCBCheckRequired = row.Field<bool>("PCBCheckRequired"),
                        PCBSide = row.Field<string>("PCBSide")
                    });
            }

            return _result;
        }



    }
}
