using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operator_Sign_Off_Sheet.Views
{
    public partial class PreFirstBoardWizard : Form
    {
        public PreFirstBoardWizard()
        {
            InitializeComponent();
        }

        private void PreFirstBoardWizard_Load(object sender, EventArgs e)
        {

        }

        // store the users choice of PS Present and ok
        bool isPSPresentAndOK = false;
        //store users choice of Drawing ok
        bool drawingOk = false;
        //store users choice of BOM check
        bool BOMisOk = false;
        //store users choice of BOM present
        bool BomIsPresent = false;
        // store users choice of old programs cleared
        bool oldProgramsCleared = false;
        // store users choice of shim
        bool isShimOk = false;
        // paste type ok
        bool isPasteOk = false;

        private void buttonPsNext_Click(object sender, EventArgs e)
        {
            NextTab();
        }


        private void NextTab()
        {
            // check that there is a next tab
            if (tabControl1.SelectedIndex < tabControl1.TabCount)
            {
                // move to next tab
                tabControl1.SelectedIndex = tabControl1.SelectedIndex + 1;
            }
        }

        private void BackTab()
        {
            if (tabControl1.SelectedIndex > 0)
            {
                tabControl1.SelectedIndex = tabControl1.SelectedIndex - 1;
            }
        }

        private void checkBoxPsYes_CheckedChanged(object sender, EventArgs e)
        {
           
           
        }

        private void checkBoxPSNo_CheckedChanged(object sender, EventArgs e)
        {
            
           

            
        }

        private void buttonDrawingBack_Click(object sender, EventArgs e)
        {
            BackTab();
        }

        private void checkBoxDrawingYes_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBoxDrawingNo_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButtonPSYes_CheckedChanged(object sender, EventArgs e)
        {
            // enable the button so user can move to next question
            this.buttonPsNext.Enabled = true;
            // set the PS present and Ok to true
            isPSPresentAndOK = true;
        }

        private void radioButtonPSNo_CheckedChanged(object sender, EventArgs e)
        {
            // enable the button so user can move to next question
            this.buttonPsNext.Enabled = true;
            // set the PS present and Ok to false
            isPSPresentAndOK = false;
        }

        private void radioButtonDrawingYes_CheckedChanged(object sender, EventArgs e)
        {
            // set the next button enabled so user can move to next section
            buttonDrawingNext.Enabled = true;
            // set drawing ok to true
            drawingOk = true;
        }

        private void radioButtonDrawingNo_CheckedChanged(object sender, EventArgs e)
        {
            // set the next button enabled so user can move to next section
            buttonDrawingNext.Enabled = true;
            // set drawing ok to true
            drawingOk = false;
        }

        private void radioButtonBomYes_CheckedChanged(object sender, EventArgs e)
        {
            // once user has made a choice we need to enable the next button
            buttonBOMNext.Enabled = true;
            // set the Bom check to true
            BOMisOk = true;
        }

        private void radioButtonBOMNo_CheckedChanged(object sender, EventArgs e)
        {
            // once user has made a choice we need to enable the next button
            buttonBOMNext.Enabled = true;
            // set the Bom check to true
            BOMisOk = false;
        }

        private void radioButtonBOMPreYes_CheckedChanged(object sender, EventArgs e)
        {
            // set the bom is present and ok flag to true
            BomIsPresent = true;
        }

        private void radioButtonBomPresNo_CheckedChanged(object sender, EventArgs e)
        {
            // set the bom is present and ok flag to false
            BomIsPresent = false;
        }

        private void radioButtonProgramsYes_CheckedChanged(object sender, EventArgs e)
        {
            // enable the next button
            buttonProgramsNext.Enabled = true;
            // set the old programs flag to true
            oldProgramsCleared = true;
        }

        private void radioButtonProgramsNo_CheckedChanged(object sender, EventArgs e)
        {
            // enable the next button
            buttonProgramsNext.Enabled = true;
            // set the old programs flag to false
            oldProgramsCleared = false;
        }

        private void radioButtonShimYes_CheckedChanged(object sender, EventArgs e)
        {
            // enable the shim next button
            buttonShimNext.Enabled = true;
            // set the shim ok flag to true
            isShimOk = true;
        }

        private void radioButtonShimNo_CheckedChanged(object sender, EventArgs e)
        {
            // enable the shim next button
            buttonShimNext.Enabled = true;
            // set the shim ok flag to true
            isShimOk = false;
        }

        private void radioButtonPasteYes_CheckedChanged(object sender, EventArgs e)
        {
            buttonPasteNext.Enabled = true;
            // set the is paste ok flag to true
            isPasteOk = true;
        }

        private void radioButtonPasteNo_CheckedChanged(object sender, EventArgs e)
        {
            buttonPasteNext.Enabled = true;
            // set the is paste ok flag to true
            isPasteOk = false;
        }

       

        
    }
}
