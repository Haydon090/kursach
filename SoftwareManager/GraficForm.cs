using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts.Charts;


namespace SoftwareManager
{
    public partial class GraficForm : Form
    {
        List<SoftwareInstallation> ListAll = new List<SoftwareInstallation>();
        public GraficForm(List<SoftwareInstallation> all)
        {
            ListAll = all;
            InitializeComponent();
        }

        private void GraficForm_Load(object sender, EventArgs e)
        {
            int count = 0;
            List<string> list = new List<string>();
            foreach(SoftwareInstallation install in ListAll)
            {
                if (!list.Contains( install.InstallDate) && !string.IsNullOrEmpty(install.InstallDate))
                {
                    list.Add(install.InstallDate);
                }
            }

            foreach (string date in list)
            {
                count = ListAll.Where(i => i.InstallDate == date.ToString()).Count();
                chart1.Series["Series1"].Points.AddXY(date, count);
            }

          
          


        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
