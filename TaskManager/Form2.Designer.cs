namespace TaskManager
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.metroProgressSpinner2 = new MetroFramework.Controls.MetroProgressSpinner();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.metroProgressSpinner3 = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroProgressSpinner4 = new MetroFramework.Controls.MetroProgressSpinner();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.metroProgressSpinner4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.metroProgressSpinner3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroProgressSpinner1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.metroProgressSpinner2, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 72);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.86555F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.13445F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(587, 454);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroProgressSpinner1.Location = new System.Drawing.Point(53, 66);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(186, 169);
            this.metroProgressSpinner1.Spinning = false;
            this.metroProgressSpinner1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroProgressSpinner1.TabIndex = 0;
            this.metroProgressSpinner1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroProgressSpinner1.UseCustomBackColor = true;
            this.metroProgressSpinner1.UseCustomForeColor = true;
            this.metroProgressSpinner1.UseSelectable = true;
            this.metroProgressSpinner1.UseStyleColors = true;
            this.metroProgressSpinner1.UseWaitCursor = true;
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::TaskManager.Properties.Resources.bg2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(273, 544);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "NEXT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aquamarine;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPU - ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroProgressSpinner2
            // 
            this.metroProgressSpinner2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroProgressSpinner2.CustomBackground = true;
            this.metroProgressSpinner2.Location = new System.Drawing.Point(347, 66);
            this.metroProgressSpinner2.Maximum = 100;
            this.metroProgressSpinner2.Name = "metroProgressSpinner2";
            this.metroProgressSpinner2.Size = new System.Drawing.Size(186, 169);
            this.metroProgressSpinner2.Spinning = false;
            this.metroProgressSpinner2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroProgressSpinner2.TabIndex = 2;
            this.metroProgressSpinner2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroProgressSpinner2.UseCustomBackColor = true;
            this.metroProgressSpinner2.UseCustomForeColor = true;
            this.metroProgressSpinner2.UseSelectable = true;
            this.metroProgressSpinner2.UseStyleColors = true;
            this.metroProgressSpinner2.UseWaitCursor = true;
            this.metroProgressSpinner2.Value = 10;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aquamarine;
            this.label2.Location = new System.Drawing.Point(296, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Memory - ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aquamarine;
            this.label3.Location = new System.Drawing.Point(3, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Disk - ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Aquamarine;
            this.label4.Location = new System.Drawing.Point(296, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "Wi-Fi - ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroProgressSpinner3
            // 
            this.metroProgressSpinner3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroProgressSpinner3.CustomBackground = true;
            this.metroProgressSpinner3.Location = new System.Drawing.Point(53, 282);
            this.metroProgressSpinner3.Maximum = 100;
            this.metroProgressSpinner3.Name = "metroProgressSpinner3";
            this.metroProgressSpinner3.Size = new System.Drawing.Size(186, 169);
            this.metroProgressSpinner3.Spinning = false;
            this.metroProgressSpinner3.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroProgressSpinner3.TabIndex = 6;
            this.metroProgressSpinner3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroProgressSpinner3.UseCustomBackColor = true;
            this.metroProgressSpinner3.UseCustomForeColor = true;
            this.metroProgressSpinner3.UseSelectable = true;
            this.metroProgressSpinner3.UseStyleColors = true;
            this.metroProgressSpinner3.UseWaitCursor = true;
            this.metroProgressSpinner3.Value = 10;
            // 
            // metroProgressSpinner4
            // 
            this.metroProgressSpinner4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.metroProgressSpinner4.CustomBackground = true;
            this.metroProgressSpinner4.Location = new System.Drawing.Point(347, 282);
            this.metroProgressSpinner4.Maximum = 100;
            this.metroProgressSpinner4.Name = "metroProgressSpinner4";
            this.metroProgressSpinner4.Size = new System.Drawing.Size(186, 169);
            this.metroProgressSpinner4.Spinning = false;
            this.metroProgressSpinner4.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroProgressSpinner4.TabIndex = 7;
            this.metroProgressSpinner4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroProgressSpinner4.UseCustomBackColor = true;
            this.metroProgressSpinner4.UseCustomForeColor = true;
            this.metroProgressSpinner4.UseSelectable = true;
            this.metroProgressSpinner4.UseStyleColors = true;
            this.metroProgressSpinner4.UseWaitCursor = true;
            this.metroProgressSpinner4.Value = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 604);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.Aquamarine;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Task Manager";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TransparencyKey = System.Drawing.Color.DimGray;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner4;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner2;
    }
}