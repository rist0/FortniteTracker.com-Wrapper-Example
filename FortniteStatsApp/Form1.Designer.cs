namespace FortniteStatsApp
{
    partial class Form1
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
            Telerik.WinControls.UI.CartesianArea cartesianArea2 = new Telerik.WinControls.UI.CartesianArea();
            this.chart = new Telerik.WinControls.UI.RadChartView();
            this.gbInput = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemoveSelectedUsers = new System.Windows.Forms.Button();
            this.btnClearUsernameList = new System.Windows.Forms.Button();
            this.lbUsernames = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClearUsername = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnAddUsername = new System.Windows.Forms.Button();
            this.gbLogs = new System.Windows.Forms.GroupBox();
            this.txtLogs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMode = new System.Windows.Forms.ComboBox();
            this.btnStop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.gbInput.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbLogs.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart
            // 
            this.chart.AreaDesign = cartesianArea2;
            this.chart.Location = new System.Drawing.Point(12, 144);
            this.chart.Name = "chart";
            this.chart.ShowGrid = false;
            this.chart.Size = new System.Drawing.Size(1239, 353);
            this.chart.TabIndex = 0;
            this.chart.Text = "radChartView1";
            // 
            // gbInput
            // 
            this.gbInput.Controls.Add(this.groupBox3);
            this.gbInput.Controls.Add(this.groupBox2);
            this.gbInput.Controls.Add(this.groupBox1);
            this.gbInput.Location = new System.Drawing.Point(12, 12);
            this.gbInput.Name = "gbInput";
            this.gbInput.Size = new System.Drawing.Size(1239, 126);
            this.gbInput.TabIndex = 1;
            this.gbInput.TabStop = false;
            this.gbInput.Text = "Input";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnStop);
            this.groupBox3.Controls.Add(this.cbMode);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Location = new System.Drawing.Point(598, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(624, 95);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Start App";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(486, 69);
            this.button1.TabIndex = 0;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemoveSelectedUsers);
            this.groupBox2.Controls.Add(this.btnClearUsernameList);
            this.groupBox2.Controls.Add(this.lbUsernames);
            this.groupBox2.Location = new System.Drawing.Point(15, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(314, 95);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Username list";
            // 
            // btnRemoveSelectedUsers
            // 
            this.btnRemoveSelectedUsers.Location = new System.Drawing.Point(233, 65);
            this.btnRemoveSelectedUsers.Name = "btnRemoveSelectedUsers";
            this.btnRemoveSelectedUsers.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveSelectedUsers.TabIndex = 1;
            this.btnRemoveSelectedUsers.Text = "Remove";
            this.btnRemoveSelectedUsers.UseVisualStyleBackColor = true;
            this.btnRemoveSelectedUsers.Click += new System.EventHandler(this.btnRemoveSelectedUsers_Click);
            // 
            // btnClearUsernameList
            // 
            this.btnClearUsernameList.Location = new System.Drawing.Point(233, 19);
            this.btnClearUsernameList.Name = "btnClearUsernameList";
            this.btnClearUsernameList.Size = new System.Drawing.Size(75, 23);
            this.btnClearUsernameList.TabIndex = 1;
            this.btnClearUsernameList.Text = "Clear";
            this.btnClearUsernameList.UseVisualStyleBackColor = true;
            this.btnClearUsernameList.Click += new System.EventHandler(this.btnClearUsernameList_Click);
            // 
            // lbUsernames
            // 
            this.lbUsernames.FormattingEnabled = true;
            this.lbUsernames.Location = new System.Drawing.Point(18, 19);
            this.lbUsernames.Name = "lbUsernames";
            this.lbUsernames.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbUsernames.Size = new System.Drawing.Size(209, 69);
            this.lbUsernames.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearUsername);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.btnAddUsername);
            this.groupBox1.Location = new System.Drawing.Point(370, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 95);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Username";
            // 
            // btnClearUsername
            // 
            this.btnClearUsername.Location = new System.Drawing.Point(19, 55);
            this.btnClearUsername.Name = "btnClearUsername";
            this.btnClearUsername.Size = new System.Drawing.Size(75, 23);
            this.btnClearUsername.TabIndex = 2;
            this.btnClearUsername.Text = "Clear";
            this.btnClearUsername.UseVisualStyleBackColor = true;
            this.btnClearUsername.Click += new System.EventHandler(this.btnClearUsername_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(19, 29);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(160, 20);
            this.txtUsername.TabIndex = 1;
            // 
            // btnAddUsername
            // 
            this.btnAddUsername.Location = new System.Drawing.Point(104, 55);
            this.btnAddUsername.Name = "btnAddUsername";
            this.btnAddUsername.Size = new System.Drawing.Size(75, 23);
            this.btnAddUsername.TabIndex = 2;
            this.btnAddUsername.Text = "Add";
            this.btnAddUsername.UseVisualStyleBackColor = true;
            this.btnAddUsername.Click += new System.EventHandler(this.btnAddUsername_Click);
            // 
            // gbLogs
            // 
            this.gbLogs.Controls.Add(this.txtLogs);
            this.gbLogs.Location = new System.Drawing.Point(12, 503);
            this.gbLogs.Name = "gbLogs";
            this.gbLogs.Size = new System.Drawing.Size(1239, 118);
            this.gbLogs.TabIndex = 2;
            this.gbLogs.TabStop = false;
            this.gbLogs.Text = "Logs";
            // 
            // txtLogs
            // 
            this.txtLogs.Location = new System.Drawing.Point(6, 19);
            this.txtLogs.Multiline = true;
            this.txtLogs.Name = "txtLogs";
            this.txtLogs.ReadOnly = true;
            this.txtLogs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLogs.Size = new System.Drawing.Size(1227, 93);
            this.txtLogs.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(494, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mode:";
            // 
            // cbMode
            // 
            this.cbMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMode.FormattingEnabled = true;
            this.cbMode.Items.AddRange(new object[] {
            "Solo",
            "Duo",
            "Squad",
            "Lifetime"});
            this.cbMode.Location = new System.Drawing.Point(497, 35);
            this.cbMode.Name = "cbMode";
            this.cbMode.Size = new System.Drawing.Size(121, 21);
            this.cbMode.TabIndex = 2;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(497, 63);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(121, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "STOP";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 633);
            this.Controls.Add(this.gbLogs);
            this.Controls.Add(this.gbInput);
            this.Controls.Add(this.chart);
            this.Name = "Form1";
            this.Text = "Fortnite stats";
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.gbInput.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbLogs.ResumeLayout(false);
            this.gbLogs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadChartView chart;
        private System.Windows.Forms.GroupBox gbInput;
        private System.Windows.Forms.GroupBox gbLogs;
        private System.Windows.Forms.ListBox lbUsernames;
        private System.Windows.Forms.Button btnAddUsername;
        private System.Windows.Forms.Button btnClearUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLogs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemoveSelectedUsers;
        private System.Windows.Forms.Button btnClearUsernameList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStop;
    }
}

