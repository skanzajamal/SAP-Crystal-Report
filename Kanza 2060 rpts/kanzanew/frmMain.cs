using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kanzanew
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument rpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
           // CrystalDecisions.CrystalReports.Engine.ReportDocument doc = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            try
            {
                
                //rpt.Load(Application.StartupPath + "/Article_.rpt");
                rpt.Load(@"C:\Users\USER\Desktop\A3\Project Source\kanza 2060 rpts\kanzanew\crpReservation.rpt");
                this.crystalReportViewer1.ReportSource = rpt;
                this.crystalReportViewer1.Refresh();
                
            }
            catch (Exception en)
            {
                MessageBox.Show(en.Message.ToString());
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument rpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            CrystalDecisions.CrystalReports.Engine.ReportDocument doc = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            try
            {

                //rpt.Load(Application.StartupPath + "/Article_.rpt");
                rpt.Load(@"C:\Users\USER\Desktop\A3\Project Source\kanza 2060 rpts\kanzanew\crpCarRental.rpt");
                this.crystalReportViewer1.ReportSource = rpt;
                this.crystalReportViewer1.Refresh();

            }
            catch (Exception en)
            {
                MessageBox.Show(en.Message.ToString());
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CrystalDecisions.CrystalReports.Engine.ReportDocument rpt = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            CrystalDecisions.CrystalReports.Engine.ReportDocument doc = new CrystalDecisions.CrystalReports.Engine.ReportDocument();
            try
            {

                //rpt.Load(Application.StartupPath + "/Article_.rpt");
                rpt.Load(@"C:\Users\USER\Desktop\A3\Project Source\kanza 2060 rpts\kanzanew\crpFoodMenu.rpt");
                this.crystalReportViewer1.ReportSource = rpt;
                this.crystalReportViewer1.Refresh();

            }
            catch (Exception en)
            {
                MessageBox.Show(en.Message.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
