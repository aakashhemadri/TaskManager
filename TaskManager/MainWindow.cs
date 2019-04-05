using System;
using System.Drawing;
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
        private System.Windows.Forms.MenuItem menuItem17 = null;
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
                    string[] prcdetails = new string[] { p.ProcessName, p.Id.ToString(), p.StartTime.ToShortTimeString(), p.TotalProcessorTime.Duration().Hours.ToString() + ":" + p.TotalProcessorTime.Duration().Minutes.ToString() + ":" + p.TotalProcessorTime.Duration().Seconds.ToString(), (p.WorkingSet64 / 1024).ToString() + "k", (p.PeakWorkingSet64 / 1024).ToString() + "k", p.HandleCount.ToString(), p.Threads.Count.ToString() };
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
                        string[] prcdetails = new string[] { p.ProcessName, p.Id.ToString(), p.StartTime.ToShortTimeString(), p.TotalProcessorTime.Duration().Hours.ToString() + ":" + p.TotalProcessorTime.Duration().Minutes.ToString() + ":" + p.TotalProcessorTime.Duration().Seconds.ToString(), (p.WorkingSet64 / 1024).ToString() + "k", (p.PeakWorkingSet64 / 1024).ToString() + "k", p.HandleCount.ToString(), p.Threads.Count.ToString() };
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
                                string[] newprcdetails = new string[] { p.ProcessName, p.Id.ToString(), p.StartTime.ToShortTimeString(), p.TotalProcessorTime.Duration().Hours.ToString() + ":" + p.TotalProcessorTime.Duration().Minutes.ToString() + ":" + p.TotalProcessorTime.Duration().Seconds.ToString(), (p.WorkingSet64 / 1024).ToString() + "k", (p.PeakWorkingSet64 / 1024).ToString() + "k", p.HandleCount.ToString(), p.Threads.Count.ToString() };
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
            try
            {
                int selectedpid = Convert.ToInt32(metroListView1.SelectedItems[0].SubItems[1].Text.ToString());
                Process selectedprocess = Process.GetProcessById(selectedpid, mcname);
                if (item.Text.ToUpper() == "HIGH")
                    selectedprocess.PriorityClass = ProcessPriorityClass.High;
                else if (item.Text.ToUpper() == "LOW")
                    selectedprocess.PriorityClass = ProcessPriorityClass.Idle;
                else if (item.Text.ToUpper() == "REAL-TIME")
                    selectedprocess.PriorityClass = ProcessPriorityClass.RealTime;
                else if (item.Text.ToUpper() == "ABOVE NORMAL")
                    selectedprocess.PriorityClass = ProcessPriorityClass.AboveNormal;
                else if (item.Text.ToUpper() == "BELOW NORMAL")
                    selectedprocess.PriorityClass = ProcessPriorityClass.BelowNormal;
                else if (item.Text.ToUpper() == "NORMAL")
                    selectedprocess.PriorityClass = ProcessPriorityClass.Normal;
                foreach (MenuItem mnuitem in menuItem10.MenuItems)
                {
                    mnuitem.Checked = false;
                }
                item.Checked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunNewTask form = new RunNewTask();
            form.Show();
        }

        private void endProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (metroListView1.SelectedItems.Count >= 1)
            {
                try
                {
                    int selectedpid = Convert.ToInt32(metroListView1.SelectedItems[0].SubItems[1].Text.ToString());
                    Process.GetProcessById(selectedpid, mcname).Kill();
                }
                catch
                {
                    erroccured = true;
                }
            }
        }

        private void eXitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*
            if (metroTabControl1.SelectedIndex == 1)
            {
                System.Threading.TimerCallback timerDelegate =
                    new System.Threading.TimerCallback(this.LoadAllMemoryDetails);
                tclr = new System.Threading.Timer(timerDelegate, null, 0, 1000);
            }
            else
            {
                tclr.Dispose();
            }
            */
        }

        private void menuItem9_Click(object sender, EventArgs e)
        {
            endProcessToolStripMenuItem_Click(sender, e);
        }

        private void menuItem11_Click(object sender, System.EventArgs e)
        {
            SetProcessPriority(menuItem11);
        }

        private void menuItem15_Click(object sender, System.EventArgs e)
        {
            SetProcessPriority(menuItem15);
        }

        private void menuItem16_Click(object sender, System.EventArgs e)
        {
            SetProcessPriority(menuItem16);
        }

        private void menuItem12_Click(object sender, System.EventArgs e)
        {
            SetProcessPriority(menuItem12);
        }
        private void menuItem13_Click(object sender, System.EventArgs e)
        {
            SetProcessPriority(menuItem13);
        }

        private void menuItem14_Click(object sender, System.EventArgs e)
        {
            SetProcessPriority(menuItem14);
        }

        private void menuItem10_Popup(object sender, System.EventArgs e)
        {
            try
            {
                int selectedpid = Convert.ToInt32(metroListView1.SelectedItems[0].SubItems[1].Text.ToString());
                Process selectedprocess = Process.GetProcessById(selectedpid, mcname);
                string priority = selectedprocess.PriorityClass.ToString();
                foreach (MenuItem mnuitem in menuItem10.MenuItems)
                {
                    string mnutext = mnuitem.Text.ToUpper().Replace(" ", "");
                    if (mnutext == "LOW")
                        mnutext = "IDLE";
                    if (mnutext != priority.ToUpper())
                        mnuitem.Checked = false;
                    else
                    {
                        mnuitem.Checked = true;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lvcxtmnu_Popup(object sender, EventArgs e)
        {

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

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

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
            metroProgressSpinner3.Value = (int)fwifi % 100;
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
        #endregion
    }
}
