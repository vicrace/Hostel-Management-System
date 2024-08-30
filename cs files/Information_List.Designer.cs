namespace Assignment_Defaultt
{
    partial class Information_List
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
            this.lblStudentSearch = new System.Windows.Forms.Label();
            this.cmbStudentSearch = new System.Windows.Forms.ComboBox();
            this.btnHostelSearch = new System.Windows.Forms.Button();
            this.btnStudentSearch = new System.Windows.Forms.Button();
            this.tbxHostelSearch = new System.Windows.Forms.TextBox();
            this.tbxStudentSearch = new System.Windows.Forms.TextBox();
            this.lblStdInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHostelInfo = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.cmbHostel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvStudentList = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studySemesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostelRoomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostelFloorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgvHostelList = new System.Windows.Forms.DataGridView();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomOccupantDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hostelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHostelList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentSearch
            // 
            this.lblStudentSearch.AutoSize = true;
            this.lblStudentSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentSearch.ForeColor = System.Drawing.Color.White;
            this.lblStudentSearch.Location = new System.Drawing.Point(42, 17);
            this.lblStudentSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentSearch.Name = "lblStudentSearch";
            this.lblStudentSearch.Size = new System.Drawing.Size(185, 25);
            this.lblStudentSearch.TabIndex = 25;
            this.lblStudentSearch.Text = "Search Parameter";
            // 
            // cmbStudentSearch
            // 
            this.cmbStudentSearch.FormattingEnabled = true;
            this.cmbStudentSearch.Items.AddRange(new object[] {
            "NAME",
            "ID",
            "SEMESTER",
            "ROOM",
            "FLOOR",
            "ALL"});
            this.cmbStudentSearch.Location = new System.Drawing.Point(248, 12);
            this.cmbStudentSearch.Margin = new System.Windows.Forms.Padding(4);
            this.cmbStudentSearch.Name = "cmbStudentSearch";
            this.cmbStudentSearch.Size = new System.Drawing.Size(180, 33);
            this.cmbStudentSearch.TabIndex = 24;
            // 
            // btnHostelSearch
            // 
            this.btnHostelSearch.BackColor = System.Drawing.SystemColors.Menu;
            this.btnHostelSearch.Location = new System.Drawing.Point(1016, 62);
            this.btnHostelSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnHostelSearch.Name = "btnHostelSearch";
            this.btnHostelSearch.Size = new System.Drawing.Size(140, 37);
            this.btnHostelSearch.TabIndex = 21;
            this.btnHostelSearch.Text = "Search";
            this.btnHostelSearch.UseVisualStyleBackColor = false;
            this.btnHostelSearch.Click += new System.EventHandler(this.btnHostelSearch_Click);
            // 
            // btnStudentSearch
            // 
            this.btnStudentSearch.BackColor = System.Drawing.SystemColors.Menu;
            this.btnStudentSearch.Location = new System.Drawing.Point(404, 63);
            this.btnStudentSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnStudentSearch.Name = "btnStudentSearch";
            this.btnStudentSearch.Size = new System.Drawing.Size(140, 37);
            this.btnStudentSearch.TabIndex = 20;
            this.btnStudentSearch.Text = "Search";
            this.btnStudentSearch.UseVisualStyleBackColor = false;
            this.btnStudentSearch.Click += new System.EventHandler(this.btnStudentSearch_Click);
            // 
            // tbxHostelSearch
            // 
            this.tbxHostelSearch.Location = new System.Drawing.Point(626, 63);
            this.tbxHostelSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbxHostelSearch.Name = "tbxHostelSearch";
            this.tbxHostelSearch.Size = new System.Drawing.Size(360, 31);
            this.tbxHostelSearch.TabIndex = 19;
            // 
            // tbxStudentSearch
            // 
            this.tbxStudentSearch.Location = new System.Drawing.Point(46, 63);
            this.tbxStudentSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbxStudentSearch.Name = "tbxStudentSearch";
            this.tbxStudentSearch.Size = new System.Drawing.Size(342, 31);
            this.tbxStudentSearch.TabIndex = 18;
            // 
            // lblStdInfo
            // 
            this.lblStdInfo.AutoSize = true;
            this.lblStdInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblStdInfo.ForeColor = System.Drawing.Color.White;
            this.lblStdInfo.Location = new System.Drawing.Point(42, 158);
            this.lblStdInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStdInfo.Name = "lblStdInfo";
            this.lblStdInfo.Size = new System.Drawing.Size(198, 25);
            this.lblStdInfo.TabIndex = 17;
            this.lblStdInfo.Text = "Student Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(666, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 16;
            // 
            // lblHostelInfo
            // 
            this.lblHostelInfo.AutoSize = true;
            this.lblHostelInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblHostelInfo.ForeColor = System.Drawing.Color.White;
            this.lblHostelInfo.Location = new System.Drawing.Point(620, 158);
            this.lblHostelInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHostelInfo.Name = "lblHostelInfo";
            this.lblHostelInfo.Size = new System.Drawing.Size(240, 25);
            this.lblHostelInfo.TabIndex = 15;
            this.lblHostelInfo.Text = "Hostel Room Infomation";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.Menu;
            this.btnReturn.Location = new System.Drawing.Point(1182, 642);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(112, 37);
            this.btnReturn.TabIndex = 26;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // cmbHostel
            // 
            this.cmbHostel.FormattingEnabled = true;
            this.cmbHostel.Items.AddRange(new object[] {
            "ALL",
            "VACANT",
            "OCCUPIED",
            "ROOM NUM"});
            this.cmbHostel.Location = new System.Drawing.Point(818, 12);
            this.cmbHostel.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHostel.Name = "cmbHostel";
            this.cmbHostel.Size = new System.Drawing.Size(168, 33);
            this.cmbHostel.TabIndex = 98;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(620, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 25);
            this.label1.TabIndex = 97;
            this.label1.Text = "Search Parameter";
            // 
            // dgvStudentList
            // 
            this.dgvStudentList.AllowUserToAddRows = false;
            this.dgvStudentList.AllowUserToDeleteRows = false;
            this.dgvStudentList.AutoGenerateColumns = false;
            this.dgvStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.studySemesterDataGridViewTextBoxColumn,
            this.hostelRoomDataGridViewTextBoxColumn,
            this.hostelFloorDataGridViewTextBoxColumn});
            this.dgvStudentList.DataSource = this.studentBindingSource;
            this.dgvStudentList.Location = new System.Drawing.Point(42, 188);
            this.dgvStudentList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStudentList.Name = "dgvStudentList";
            this.dgvStudentList.ReadOnly = true;
            this.dgvStudentList.RowHeadersWidth = 51;
            this.dgvStudentList.RowTemplate.Height = 24;
            this.dgvStudentList.Size = new System.Drawing.Size(502, 488);
            this.dgvStudentList.TabIndex = 99;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // studySemesterDataGridViewTextBoxColumn
            // 
            this.studySemesterDataGridViewTextBoxColumn.DataPropertyName = "StudySemester";
            this.studySemesterDataGridViewTextBoxColumn.HeaderText = "StudySemester";
            this.studySemesterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studySemesterDataGridViewTextBoxColumn.Name = "studySemesterDataGridViewTextBoxColumn";
            this.studySemesterDataGridViewTextBoxColumn.ReadOnly = true;
            this.studySemesterDataGridViewTextBoxColumn.Width = 125;
            // 
            // hostelRoomDataGridViewTextBoxColumn
            // 
            this.hostelRoomDataGridViewTextBoxColumn.DataPropertyName = "HostelRoom";
            this.hostelRoomDataGridViewTextBoxColumn.HeaderText = "HostelRoom";
            this.hostelRoomDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hostelRoomDataGridViewTextBoxColumn.Name = "hostelRoomDataGridViewTextBoxColumn";
            this.hostelRoomDataGridViewTextBoxColumn.ReadOnly = true;
            this.hostelRoomDataGridViewTextBoxColumn.Width = 125;
            // 
            // hostelFloorDataGridViewTextBoxColumn
            // 
            this.hostelFloorDataGridViewTextBoxColumn.DataPropertyName = "HostelFloor";
            this.hostelFloorDataGridViewTextBoxColumn.HeaderText = "HostelFloor";
            this.hostelFloorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hostelFloorDataGridViewTextBoxColumn.Name = "hostelFloorDataGridViewTextBoxColumn";
            this.hostelFloorDataGridViewTextBoxColumn.ReadOnly = true;
            this.hostelFloorDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Assignment_Defaultt.Student);
            // 
            // dgvHostelList
            // 
            this.dgvHostelList.AllowUserToAddRows = false;
            this.dgvHostelList.AllowUserToDeleteRows = false;
            this.dgvHostelList.AutoGenerateColumns = false;
            this.dgvHostelList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHostelList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNumberDataGridViewTextBoxColumn,
            this.roomOccupantDataGridViewTextBoxColumn,
            this.roomStatusDataGridViewCheckBoxColumn});
            this.dgvHostelList.DataSource = this.hostelBindingSource;
            this.dgvHostelList.Location = new System.Drawing.Point(626, 190);
            this.dgvHostelList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHostelList.Name = "dgvHostelList";
            this.dgvHostelList.ReadOnly = true;
            this.dgvHostelList.RowHeadersWidth = 51;
            this.dgvHostelList.RowTemplate.Height = 24;
            this.dgvHostelList.Size = new System.Drawing.Size(532, 488);
            this.dgvHostelList.TabIndex = 100;
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            this.roomNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomNumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomOccupantDataGridViewTextBoxColumn
            // 
            this.roomOccupantDataGridViewTextBoxColumn.DataPropertyName = "RoomOccupant";
            this.roomOccupantDataGridViewTextBoxColumn.HeaderText = "RoomOccupant";
            this.roomOccupantDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomOccupantDataGridViewTextBoxColumn.Name = "roomOccupantDataGridViewTextBoxColumn";
            this.roomOccupantDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomOccupantDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomStatusDataGridViewCheckBoxColumn
            // 
            this.roomStatusDataGridViewCheckBoxColumn.DataPropertyName = "RoomStatus";
            this.roomStatusDataGridViewCheckBoxColumn.HeaderText = "RoomStatus";
            this.roomStatusDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.roomStatusDataGridViewCheckBoxColumn.Name = "roomStatusDataGridViewCheckBoxColumn";
            this.roomStatusDataGridViewCheckBoxColumn.ReadOnly = true;
            this.roomStatusDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.roomStatusDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.roomStatusDataGridViewCheckBoxColumn.Width = 125;
            // 
            // hostelBindingSource
            // 
            this.hostelBindingSource.DataSource = typeof(Assignment_Defaultt.Hostel);
            // 
            // Information_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = global::Assignment_Defaultt.Properties.Resources.solid;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1328, 696);
            this.Controls.Add(this.dgvHostelList);
            this.Controls.Add(this.dgvStudentList);
            this.Controls.Add(this.cmbHostel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblStudentSearch);
            this.Controls.Add(this.cmbStudentSearch);
            this.Controls.Add(this.btnHostelSearch);
            this.Controls.Add(this.btnStudentSearch);
            this.Controls.Add(this.tbxHostelSearch);
            this.Controls.Add(this.tbxStudentSearch);
            this.Controls.Add(this.lblStdInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHostelInfo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Information_List";
            this.Text = "Information_List";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Information_List_FormClosing);
            this.Load += new System.EventHandler(this.Information_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHostelList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentSearch;
        private System.Windows.Forms.ComboBox cmbStudentSearch;
        private System.Windows.Forms.Button btnHostelSearch;
        private System.Windows.Forms.Button btnStudentSearch;
        private System.Windows.Forms.TextBox tbxHostelSearch;
        private System.Windows.Forms.TextBox tbxStudentSearch;
        private System.Windows.Forms.Label lblStdInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHostelInfo;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox cmbHostel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStudentList;
        private System.Windows.Forms.DataGridView dgvHostelList;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomOccupantDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomStatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource hostelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studySemesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostelRoomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hostelFloorDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentBindingSource;
    }
}