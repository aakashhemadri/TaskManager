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
        private void timer1_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            metroProgressSpinner1.Value = (int)fcpu;
            label1.Text = "CPU - " + ((int)fcpu).ToString() + "%";
            //float fram = pRAM.NextValue();
            //metroProgressSpinner2.Value = (int)fram/1024/1024;
            //label2.Text = "Memory - " + ((int)fram/1024/1024).ToString() + "%";
        }
        #endregion
    }
}
