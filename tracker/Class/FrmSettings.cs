using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dev_Note_Assistant;
using Guna.UI2.WinForms;
namespace tracker.Class
{
    public partial class FrmSettings : Form
    {
        public FrmSettings()
        {
            InitializeComponent();
            MyTools.MoveControl(PnlTopBar, this); //تحريك
            FormSettings = this;

        }

        ClsTrackingPrograms trackingPrograms = new ClsTrackingPrograms();

      public static FrmSettings FormSettings;

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PicClose_Click(object sender, EventArgs e) // أغلاق 
        {
            this.Opacity = 0;
        }

        private void chk_VS_CheckedChanged(object sender, EventArgs e) //checkBoxs
        {
            int index = 0;
            var chk = (Guna2CheckBox)sender;
            int.TryParse(chk.Tag?.ToString().Trim() ,out index );

            // Dictionary
            var list_Chk = trackingPrograms.TrackedPrograms; 
        }

        private void btnAddAppTrager_Click(object sender, EventArgs e) // إضافة برنامج لتتبعه
        {
            string NameProgram = TxtAppTrager.Text.ToLower().Trim();
            if (string.IsNullOrEmpty(NameProgram))
            {
                MessageBox.Show("أدخل اسم البرنامج أولا", "لا يمكن الإضافة", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($" لتتبعه {NameProgram} تم إضافة برنامج ", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClsTrackingPrograms.NewTrackedPrograms_ = NameProgram;
        }
    }
}
