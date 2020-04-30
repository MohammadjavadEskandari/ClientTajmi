using ClientTajmi.Services;
using ClientTajmi.ViewModel;
using Newtonsoft.Json;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientTajmi
{
    public partial class FrmSyncTable : Form
    {
        public FrmSyncTable()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int total = 100;
            for (int i = 0; i <= total; i++)
            {
                backgroundWorker1.ReportProgress((i * 100) / total);



            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage <= 100)
            {
                radProgressBar1.Value1 = e.ProgressPercentage;


            }


        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();

        }

        private void radButton1_Click(object sender, EventArgs e)
        {



            RequestService req = new RequestService();
            List<GetDataViewModel> data = req.GetNewDate(TxtSrvUrl.Text, TxtSrvDatabaseCnn.Text,
                TxtSrvTableName.Text, TxtSrvPrimaryKey.Text);

        }

        private void FrmSyncTable_Load(object sender, EventArgs e)
        {
            ConfigModel Cn = new ConfigModel();
            string root = Application.StartupPath + @"\ConfigWebservice.txt";
            string ssss = File.ReadAllText(root);
            Cn = JsonConvert.DeserializeObject<ConfigModel>(File.ReadAllText(root));

            TxtSrvUrl.Text = Cn.TxtSrvUrl;
            TxtSrvDatabaseCnn.Text = Cn.TxtSrvDatabaseCnn;
            TxtSrvTableName.Text = Cn.TxtSrvDatabaseCnn;
            TxtSrvPrimaryKey.Text = Cn.TxtSrvTableName;
        }
    }
}
