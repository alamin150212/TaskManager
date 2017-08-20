namespace TaskManagerOS
{
    partial class TaskManager
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Apps", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Background Process", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runNewTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabProcess = new System.Windows.Forms.TabPage();
            this.btnEndTask = new MetroFramework.Controls.MetroButton();
            this.listViewProcess = new System.Windows.Forms.ListView();
            this.NameProcess = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPerformance = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCPU = new System.Windows.Forms.TabPage();
            this.chartCPU = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.CPU = new CircularProgressBar.CircularProgressBar();
            this.tabMemory = new System.Windows.Forms.TabPage();
            this.chartMemory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.Memory = new CircularProgressBar.CircularProgressBar();
            this.tabDisk = new System.Windows.Forms.TabPage();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pMemory = new System.Diagnostics.PerformanceCounter();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabProcess.SuspendLayout();
            this.tabPerformance.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCPU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPU)).BeginInit();
            this.tabMemory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMemory)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(26, 79);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(505, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runNewTaskToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // runNewTaskToolStripMenuItem
            // 
            this.runNewTaskToolStripMenuItem.Name = "runNewTaskToolStripMenuItem";
            this.runNewTaskToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.runNewTaskToolStripMenuItem.Text = "Run New Task";
            this.runNewTaskToolStripMenuItem.Click += new System.EventHandler(this.runNewTaskToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabProcess);
            this.tabControl.Controls.Add(this.tabPerformance);
            this.tabControl.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(26, 120);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(530, 497);
            this.tabControl.TabIndex = 1;
            // 
            // tabProcess
            // 
            this.tabProcess.Controls.Add(this.btnEndTask);
            this.tabProcess.Controls.Add(this.listViewProcess);
            this.tabProcess.Location = new System.Drawing.Point(4, 29);
            this.tabProcess.Name = "tabProcess";
            this.tabProcess.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcess.Size = new System.Drawing.Size(522, 464);
            this.tabProcess.TabIndex = 0;
            this.tabProcess.Text = "Processes";
            this.tabProcess.UseVisualStyleBackColor = true;
            // 
            // btnEndTask
            // 
            this.btnEndTask.Location = new System.Drawing.Point(395, 436);
            this.btnEndTask.Name = "btnEndTask";
            this.btnEndTask.Size = new System.Drawing.Size(103, 23);
            this.btnEndTask.TabIndex = 1;
            this.btnEndTask.Text = "End Task";
            this.btnEndTask.UseSelectable = true;
            this.btnEndTask.Click += new System.EventHandler(this.btnEndTask_Click);
            // 
            // listViewProcess
            // 
            this.listViewProcess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameProcess});
            listViewGroup1.Header = "Apps";
            listViewGroup1.Name = "listViewApp";
            listViewGroup2.Header = "Background Process";
            listViewGroup2.Name = "listViewBackground";
            this.listViewProcess.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.listViewProcess.Location = new System.Drawing.Point(-1, 0);
            this.listViewProcess.Name = "listViewProcess";
            this.listViewProcess.Size = new System.Drawing.Size(523, 429);
            this.listViewProcess.TabIndex = 0;
            this.listViewProcess.UseCompatibleStateImageBehavior = false;
            this.listViewProcess.View = System.Windows.Forms.View.Details;
            this.listViewProcess.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listViewProcess_ColumnClick);
            // 
            // NameProcess
            // 
            this.NameProcess.Text = "Process Name";
            this.NameProcess.Width = 519;
            // 
            // tabPerformance
            // 
            this.tabPerformance.Controls.Add(this.tabControl1);
            this.tabPerformance.Location = new System.Drawing.Point(4, 29);
            this.tabPerformance.Name = "tabPerformance";
            this.tabPerformance.Padding = new System.Windows.Forms.Padding(3);
            this.tabPerformance.Size = new System.Drawing.Size(522, 464);
            this.tabPerformance.TabIndex = 1;
            this.tabPerformance.Text = "Performance";
            this.tabPerformance.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCPU);
            this.tabControl1.Controls.Add(this.tabMemory);
            this.tabControl1.Controls.Add(this.tabDisk);
            this.tabControl1.Location = new System.Drawing.Point(-4, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(530, 468);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCPU
            // 
            this.tabCPU.Controls.Add(this.chartCPU);
            this.tabCPU.Controls.Add(this.label1);
            this.tabCPU.Controls.Add(this.CPU);
            this.tabCPU.Location = new System.Drawing.Point(4, 29);
            this.tabCPU.Name = "tabCPU";
            this.tabCPU.Padding = new System.Windows.Forms.Padding(3);
            this.tabCPU.Size = new System.Drawing.Size(522, 435);
            this.tabCPU.TabIndex = 0;
            this.tabCPU.Text = "CPU";
            this.tabCPU.UseVisualStyleBackColor = true;
            // 
            // chartCPU
            // 
            chartArea1.Name = "ChartArea1";
            this.chartCPU.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartCPU.Legends.Add(legend1);
            this.chartCPU.Location = new System.Drawing.Point(11, 207);
            this.chartCPU.Name = "chartCPU";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            this.chartCPU.Series.Add(series1);
            this.chartCPU.Size = new System.Drawing.Size(502, 225);
            this.chartCPU.TabIndex = 4;
            this.chartCPU.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPU";
            // 
            // CPU
            // 
            this.CPU.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.CPU.AnimationSpeed = 500;
            this.CPU.BackColor = System.Drawing.Color.Transparent;
            this.CPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPU.ForeColor = System.Drawing.Color.Black;
            this.CPU.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CPU.InnerMargin = 2;
            this.CPU.InnerWidth = -1;
            this.CPU.Location = new System.Drawing.Point(341, 37);
            this.CPU.MarqueeAnimationSpeed = 2000;
            this.CPU.Name = "CPU";
            this.CPU.OuterColor = System.Drawing.Color.Gray;
            this.CPU.OuterMargin = -25;
            this.CPU.OuterWidth = 26;
            this.CPU.ProgressColor = System.Drawing.Color.SeaGreen;
            this.CPU.ProgressWidth = 25;
            this.CPU.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPU.Size = new System.Drawing.Size(160, 151);
            this.CPU.StartAngle = 270;
            this.CPU.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CPU.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.CPU.SubscriptText = "";
            this.CPU.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.CPU.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.CPU.SuperscriptText = "";
            this.CPU.TabIndex = 0;
            this.CPU.TextMargin = new System.Windows.Forms.Padding(8);
            this.CPU.Value = 68;
            // 
            // tabMemory
            // 
            this.tabMemory.Controls.Add(this.chartMemory);
            this.tabMemory.Controls.Add(this.label2);
            this.tabMemory.Controls.Add(this.Memory);
            this.tabMemory.Location = new System.Drawing.Point(4, 29);
            this.tabMemory.Name = "tabMemory";
            this.tabMemory.Padding = new System.Windows.Forms.Padding(3);
            this.tabMemory.Size = new System.Drawing.Size(522, 435);
            this.tabMemory.TabIndex = 1;
            this.tabMemory.Text = "Memory";
            this.tabMemory.UseVisualStyleBackColor = true;
            // 
            // chartMemory
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMemory.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMemory.Legends.Add(legend2);
            this.chartMemory.Location = new System.Drawing.Point(6, 204);
            this.chartMemory.Name = "chartMemory";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series2.Legend = "Legend1";
            series2.Name = "Memory";
            this.chartMemory.Series.Add(series2);
            this.chartMemory.Size = new System.Drawing.Size(502, 225);
            this.chartMemory.TabIndex = 3;
            this.chartMemory.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 47);
            this.label2.TabIndex = 2;
            this.label2.Text = "Memory";
            // 
            // Memory
            // 
            this.Memory.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Memory.AnimationSpeed = 500;
            this.Memory.BackColor = System.Drawing.Color.Transparent;
            this.Memory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Memory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Memory.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Memory.InnerMargin = 2;
            this.Memory.InnerWidth = -1;
            this.Memory.Location = new System.Drawing.Point(338, 34);
            this.Memory.MarqueeAnimationSpeed = 2000;
            this.Memory.Name = "Memory";
            this.Memory.OuterColor = System.Drawing.Color.Gray;
            this.Memory.OuterMargin = -25;
            this.Memory.OuterWidth = 26;
            this.Memory.ProgressColor = System.Drawing.Color.ForestGreen;
            this.Memory.ProgressWidth = 25;
            this.Memory.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.Memory.Size = new System.Drawing.Size(163, 150);
            this.Memory.StartAngle = 270;
            this.Memory.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Memory.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Memory.SubscriptText = "";
            this.Memory.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Memory.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Memory.SuperscriptText = "";
            this.Memory.TabIndex = 0;
            this.Memory.TextMargin = new System.Windows.Forms.Padding(8);
            this.Memory.Value = 68;
            // 
            // tabDisk
            // 
            this.tabDisk.Location = new System.Drawing.Point(4, 29);
            this.tabDisk.Name = "tabDisk";
            this.tabDisk.Size = new System.Drawing.Size(522, 435);
            this.tabDisk.TabIndex = 2;
            this.tabDisk.Text = "Disk";
            this.tabDisk.UseVisualStyleBackColor = true;
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pMemory
            // 
            this.pMemory.CategoryName = "Memory";
            this.pMemory.CounterName = "% Committed Bytes In Use";
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 617);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TaskManager";
            this.Padding = new System.Windows.Forms.Padding(26, 79, 26, 26);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Task Manager";
            this.Load += new System.EventHandler(this.TaskManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabProcess.ResumeLayout(false);
            this.tabPerformance.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabCPU.ResumeLayout(false);
            this.tabCPU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCPU)).EndInit();
            this.tabMemory.ResumeLayout(false);
            this.tabMemory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pMemory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runNewTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPerformance;
        private System.Windows.Forms.TabPage tabProcess;
        private MetroFramework.Controls.MetroButton btnEndTask;
        private System.Windows.Forms.ColumnHeader NameProcess;
        private System.Windows.Forms.ListView listViewProcess;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCPU;
        private System.Windows.Forms.TabPage tabMemory;
        private CircularProgressBar.CircularProgressBar CPU;
        private System.Windows.Forms.TabPage tabDisk;
        private System.Windows.Forms.Label label1;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.Label label2;
        private CircularProgressBar.CircularProgressBar Memory;
        public System.Windows.Forms.Timer timer;
        private System.Diagnostics.PerformanceCounter pMemory;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMemory;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCPU;
    }
}

