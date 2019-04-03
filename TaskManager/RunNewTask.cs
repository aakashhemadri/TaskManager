using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Diagnostics;

namespace TaskManager
{
    public partial class RunNewTask : MetroForm
    {
        public RunNewTask()
        {
            InitializeComponent();
        }

        private void RunNewTask_Load(object sender, EventArgs e)
        {
            
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            MainWindow.newprocpathandparm = metroTextBox1.Text.Trim();
            if (MainWindow.newprocpathandparm.Length != 0)
            {
                if (MainWindow.newprocpathandparm.IndexOf("\\") == -1)
                {
                    string[] newprocdetails = MainWindow.newprocpathandparm.Split(' ');
                    if (newprocdetails.Length > 1)
                    {
                        Process newprocess = Process.Start(newprocdetails[0].ToString(), newprocdetails[1].ToString());
                    }
                    else
                    {
                        Process newprocess = Process.Start(newprocdetails[0].ToString());
                    }
                }
                else
                {
                    string procname = MainWindow.newprocpathandparm.Substring(MainWindow.newprocpathandparm.LastIndexOf("\\") + 1);
                    string[] newprocdetails = procname.Split(' ');
                    if (newprocdetails.Length > 1)
                    {
                        Process newprocess = Process.Start(MainWindow.newprocpathandparm.Replace(newprocdetails[1].ToString(), ""), newprocdetails[1].ToString());
                    }
                    else
                    {
                        Process newprocess = Process.Start(MainWindow.newprocpathandparm);
                    }

                }
            }
                this.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            MainWindow.newprocpathandparm = "";
            this.Close();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.CheckFileExists = false;
                openFileDialog1.ShowDialog();
                metroTextBox1.Text = openFileDialog1.FileName;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
