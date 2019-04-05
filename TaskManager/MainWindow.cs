using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class MainWindow : MetroFramework.Forms.MetroForm
    {
        #region User Defined Variables.
        public static string newprocpathandparm, mcname;
        //public static frmnewprcdetails objnewprocess;
        public System.Threading.Timer t = null;
        public System.Threading.Timer tclr = null;
        public bool erroccured = false;
        private System.Windows.Forms.MenuItem menuItem17;
        public Hashtable presentprocdetails;
        public Process[] processes = null;
        #endregion
        #region User defined Methods.
        private void LoadAllProcessesOnStartup()
        {
            Process[] processes = null;
            try
            {
                processes = Process.GetProcesses(mcname);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Application.Exit();
                return;
            }
            int threadscount = 0;
            foreach (Process p in processes)
            {
                try
                {
                    string[] prcdetails = new string[] { p.ProcessName, p.Id.ToString(), p.StartTime.ToShortTimeString(), p.TotalProcessorTime.Duration().Hours.ToString() + ":" + p.TotalProcessorTime.Duration().Minutes.ToString() + ":" + p.TotalProcessorTime.Duration().Seconds.ToString(), (p.WorkingSet / 1024).ToString() + "k", (p.PeakWorkingSet / 1024).ToString() + "k", p.HandleCount.ToString(), p.Threads.Count.ToString() };
                    ListViewItem proc = new ListViewItem(prcdetails);
                    metroListView1.Items.Add(proc);
                    threadscount += p.Threads.Count;
                }
                catch { }
            }
            statusProcesses.Text = "Processes : " + processes.Length.ToString();
            statusThreads.Text = "Threads : " + (threadscount + 1).ToString();
        }
        private void LoadAllProcesses(object temp)
        {
            try
            {
                presentprocdetails.Clear();
                processes = Process.GetProcesses(mcname);
                bool runningproccountchanged = false;
                Hashtable lvprocesses = null;
                int threadscount = 0;
                foreach (Process p in processes)
                {
                    try
                    {
                        string[] prcdetails = new string[] { p.ProcessName, p.Id.ToString(), p.StartTime.ToShortTimeString(), p.TotalProcessorTime.Duration().Hours.ToString() + ":" + p.TotalProcessorTime.Duration().Minutes.ToString() + ":" + p.TotalProcessorTime.Duration().Seconds.ToString(), (p.WorkingSet / 1024).ToString() + "k", (p.PeakWorkingSet / 1024).ToString() + "k", p.HandleCount.ToString(), p.Threads.Count.ToString() };
                        presentprocdetails.Add(prcdetails[1], prcdetails[0].ToString() + "#" + prcdetails[2].ToString() + "#" + prcdetails[3].ToString() + "#" + prcdetails[4].ToString() + "#" + prcdetails[5].ToString() + "#" + prcdetails[6].ToString() + "#" + prcdetails[7].ToString());
                        threadscount += p.Threads.Count;
                    }
                    catch { }
                }
                if ((processes.Length != metroListView1.Items.Count) || erroccured)
                {
                    runningproccountchanged = true;
                    lvprocesses = new Hashtable();
                    foreach (ListViewItem item in metroListView1.Items)
                    {
                        lvprocesses.Add(item.SubItems[1].Text, "");
                    }
                }
                if (runningproccountchanged || erroccured)
                {
                    erroccured = false;
                    foreach (Process p in Process.GetProcesses(mcname))
                    {
                        try
                        {
                            if (!lvprocesses.Contains(p.Id.ToString()))
                            {
                                string[] newprcdetails = new string[] { p.ProcessName, p.Id.ToString(), p.StartTime.ToShortTimeString(), p.TotalProcessorTime.Duration().Hours.ToString() + ":" + p.TotalProcessorTime.Duration().Minutes.ToString() + ":" + p.TotalProcessorTime.Duration().Seconds.ToString(), (p.WorkingSet / 1024).ToString() + "k", (p.PeakWorkingSet / 1024).ToString() + "k", p.HandleCount.ToString(), p.Threads.Count.ToString() };
                                ListViewItem newprocess = new ListViewItem(newprcdetails);
                                metroListView1.Items.Add(newprocess);
                            }
                            IDictionaryEnumerator enlvprocesses = lvprocesses.GetEnumerator();
                            while (enlvprocesses.MoveNext())
                            {
                                if (!presentprocdetails.Contains(enlvprocesses.Key))
                                {
                                    foreach (ListViewItem item in metroListView1.Items)
                                    {
                                        if (item.SubItems[1].Text.ToString().ToUpper() == enlvprocesses.Key.ToString().ToUpper())
                                        {
                                            metroListView1.Items.Remove(item);
                                        }
                                    }
                                }
                            }
                        }
                        catch { }
                    }
                }
                IDictionaryEnumerator enpresentprodetails = presentprocdetails.GetEnumerator();
                bool valchanged = false;
                while (enpresentprodetails.MoveNext())
                {
                    foreach (ListViewItem item in metroListView1.Items)
                    {
                        if (item.SubItems[1].Text.ToString().ToUpper() == enpresentprodetails.Key.ToString().ToUpper())
                        {
                            string[] presentprocessdetails = enpresentprodetails.Value.ToString().Split('#');
                            if (item.SubItems[3].Text.ToString() != presentprocessdetails[2].ToString())
                            {
                                valchanged = true;
                                item.SubItems[3].Text = presentprocessdetails[2].ToString();
                            }
                            if (item.SubItems[4].Text.ToString() != presentprocessdetails[3].ToString())
                            {
                                valchanged = true;
                                item.SubItems[4].Text = presentprocessdetails[3].ToString();
                            }
                            if (item.SubItems[5].Text.ToString() != presentprocessdetails[4].ToString())
                            {
                                valchanged = true;
                                item.SubItems[5].Text = presentprocessdetails[4].ToString();
                            }
                            if (item.SubItems[6].Text.ToString() != presentprocessdetails[5].ToString())
                            {
                                valchanged = true;
                                item.SubItems[6].Text = presentprocessdetails[5].ToString();
                            }
                            if (item.SubItems[7].Text.ToString() != presentprocessdetails[6].ToString())
                            {
                                valchanged = true;
                                item.SubItems[7].Text = presentprocessdetails[6].ToString();
                            }
                            if (menuItem17.Checked)
                            {
                                valchanged = false;
                            }
                            if (valchanged)
                            {
                                item.ForeColor = Color.Red;
                                valchanged = false;
                            }
                            else
                            {
                                item.ForeColor = Color.Black;
                            }
                            break;
                        }
                    }
                }
                statusProcesses.Text = "Processes : " + processes.Length.ToString();
                statusThreads.Text = "Threads : " + (threadscount + 1).ToString();
            }
            catch { }
        }
        private void SetProcessPriority(MenuItem item)
        {
        }
        private void LoadAllMemoryDetails(object temp)
        {

        }
        #endregion
        #region Windows Forms generated code.
        public MainWindow()
        {
            InitializeComponent();
        }

        private void statusStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            timer1.Start();
            mcname = ".";
            presentprocdetails = new Hashtable();
            LoadAllProcessesOnStartup();
            System.Threading.TimerCallback timerDelegate =
                new System.Threading.TimerCallback(this.LoadAllProcesses);
            t = new System.Threading.Timer(timerDelegate, null, 1000, 1000);
        }

        private void darkButton2_Click(object sender, EventArgs e)
        {
            Program.c = 2;
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            Program.c = 1;
        }

        private void darkButton5_Click(object sender, EventArgs e)
        {
            Program.c = 5;
        }

        private void darkButton3_Click(object sender, EventArgs e)
        {
            Program.c = 3;
        }

        private void darkButton4_Click(object sender, EventArgs e)
        {
            Program.c = 4;
        }

        private void darkButton6_Click(object sender, EventArgs e)
        {
            Program.c = 6;
        }
        #endregion
        /*#region Cleanup
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        #endregion*/
        private void timer1_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();
            float fwifi = pWifi.NextValue();
            float fdisk = pDisk.NextValue();
            float fether = 1;
            float fgpu = 1;
            metroProgressSpinner1.Value = (int)fcpu;
            metroProgressSpinner2.Value = (int)fram;
            metroProgressSpinner3.Value = (int)fwifi%100;
            metroProgressSpinner4.Value = (int)fdisk % 100;
            label1.Text = "CPU - " + ((int)fcpu).ToString() + "%";
            label2.Text = "Memory - " + ((int)fram).ToString() + "%";
            label3.Text = "Wi-Fi - " + ((int)fwifi).ToString() + "%";
            label4.Text = "Disk - " + ((int)fwifi).ToString() + "%";
            chart6.Visible = false;
            chart5.Visible = false;
            chart4.Visible = false;
            chart3.Visible = false;
            chart2.Visible = false;
            chart1.Series["CPU"].Points.AddY(fcpu);
            if (Program.c == 1)
            {
                //chart1.Series["CPU"].Points.Clear();
                //chart1.Refresh();
                chart3.Visible = false;
                chart2.Visible = false;
                chart1.Visible = true;
                chart1.Series["CPU"].Points.AddY(fcpu);
            }
            else if (Program.c == 2)
            {
                //chart1.Refresh();
                chart1.Visible = false;
                chart3.Visible = false;
                chart2.Visible = true;
                chart2.Series["CPU"].Points.AddY(fram);
            }
            else if (Program.c == 5)
            {
                //chart1.Refresh();
                chart1.Visible = false;
                chart2.Visible = false;
                chart3.Visible = true;
                chart3.Series["CPU"].Points.AddY(fwifi);
            }
            else if (Program.c == 3)
            {
                //chart1.Refresh();
                chart1.Visible = false;
                chart2.Visible = false;
                chart3.Visible = false;
                chart4.Visible = true;
                chart4.Series["CPU"].Points.AddY(fdisk);
            }
            else if (Program.c == 4)
            {
                //chart1.Refresh();
                chart1.Visible = false;
                chart2.Visible = false;
                chart3.Visible = false;
                chart4.Visible = false;
                chart5.Visible = true;
                chart5.Series["CPU"].Points.AddY(fether);
            }
            else if (Program.c == 6)
            {
                //chart1.Refresh();
                chart1.Visible = false;
                chart2.Visible = false;
                chart3.Visible = false;
                chart4.Visible = false;
                chart5.Visible = false;
                chart6.Visible = true;
                chart6.Series["CPU"].Points.AddY(fgpu);
            }
            //float fram = pRAM.NextValue();
            //metroProgressSpinner2.Value = (int)fram/1024/1024;
            //label2.Text = "Memory - " + ((int)fram/1024/1024).ToString() + "%";
        }

    }
}
