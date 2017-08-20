namespace TaskManagerOS
{
    partial class CreateNewTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateNewTask));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showMessage = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.openTextbox = new MetroFramework.Controls.MetroTextBox();
            this.btnBrowse = new MetroFramework.Controls.MetroButton();
            this.btnOpen = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // showMessage
            // 
            this.showMessage.AutoSize = true;
            this.showMessage.FontSize = MetroFramework.MetroLabelSize.Small;
            this.showMessage.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.showMessage.Location = new System.Drawing.Point(142, 82);
            this.showMessage.Name = "showMessage";
            this.showMessage.Size = new System.Drawing.Size(85, 17);
            this.showMessage.TabIndex = 1;
            this.showMessage.Text = "metroLabel1";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(33, 162);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 20);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Open : ";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // openTextbox
            // 
            this.openTextbox.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.openTextbox.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.openTextbox.Location = new System.Drawing.Point(117, 162);
            this.openTextbox.Name = "openTextbox";
            this.openTextbox.Size = new System.Drawing.Size(241, 23);
            this.openTextbox.TabIndex = 3;
            this.openTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.openTextbox_KeyDown);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Highlight = true;
            this.btnBrowse.Location = new System.Drawing.Point(370, 162);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.Style = MetroFramework.MetroColorStyle.Black;
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Highlight = true;
            this.btnOpen.Location = new System.Drawing.Point(201, 213);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(97, 23);
            this.btnOpen.Style = MetroFramework.MetroColorStyle.Black;
            this.btnOpen.TabIndex = 5;
            this.btnOpen.Text = "Open";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // CreateNewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(477, 253);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.openTextbox);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.showMessage);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateNewTask";
            this.Padding = new System.Windows.Forms.Padding(29, 79, 29, 26);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Create New Task";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.CreateNewTask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel showMessage;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox openTextbox;
        private MetroFramework.Controls.MetroButton btnBrowse;
        private MetroFramework.Controls.MetroButton btnOpen;
    }
}