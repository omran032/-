using Dev_Note_Assistant;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tracker.Class;

namespace tracker
{
    public partial class FormTimer : Form
    {
        public FormTimer()
        {
            InitializeComponent();
            
            MyTools.MoveControl(this,this); // تحريك الفورم

            settings = new FrmSettings();
            settings.Opacity = 0 ;
            MyTools.ShowForm(settings);
        }
        FrmSettings settings;

        private void Form1_Load(object sender, EventArgs e)
        {
              Timer.Start();
        }


        private int seconds = 0;
        private int secondsBreak = 0;

        int check = 1;

        private void Timer_Tick(object sender, EventArgs e) // المؤقت
        {
                check = 0;
            //هل فاتح برامج معينة  ؟
               if (WindowTracker.IsVisualStudioActive()) 
                {
                    seconds++;
                    lblTime.Text = TimeSpan.FromSeconds(seconds).ToString(@"hh\:mm\:ss");
                    lblTime.ForeColor = Color.Crimson;
                    lblTimerBreak.ForeColor = Color.Black;
                }
                else
                {
                    secondsBreak++;
                    lblTimerBreak.Text = TimeSpan.FromSeconds(secondsBreak).ToString(@"hh\:mm\:ss");
                    lblTimerBreak.ForeColor = Color.Crimson;
                    lblTime.ForeColor = Color.Black;
                }
           
          
        }

        #region [[[  إظهار و إخفاء الواجهة  ]]]

        private void CMS_btnShow_Click(object sender, EventArgs e) // إظهار الفورم
        {
            this.Opacity= 1;
        }

        private void CMS_btnHide_Click(object sender, EventArgs e)
        {
            this.Opacity= 0.05;
        }

        private void CMSHide005_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.05;
        }

        private void CMS_01_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
        }

        private void CMS_02_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.2;
        }

        #endregion

        private void CMS_StopTimer_Click(object sender, EventArgs e) // ايقاف المؤقت
        {
            Timer.Stop();
        }

        private void CMS_StartTimer_Click(object sender, EventArgs e) // تشغيل المؤقت
        {
            Timer.Start();
        }

        private void CMS_RestartBreak_Click(object sender, EventArgs e) // تصفير مؤقت الاستراحة
        {
            secondsBreak = 0;
        }

        private void CMS_RestartWork_Click(object sender, EventArgs e) // تصفير مؤقت العمل
        {
            seconds= 0;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e) // زرالاغلاق
        {
            Application.Exit();
        }

        private void CMS_Settings_Click(object sender, EventArgs e) //عرض الإعدادات
        {
            MyTools.ShowForm(settings);
            settings.Opacity = 1;
        }
    }
}
