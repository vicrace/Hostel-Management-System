namespace Assignment_Defaultt
{
    partial class Modify_Information
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
            this.dgvHostelList = new System.Windows.Forms.DataGridView();
            this.dgvStudentList = new System.Windows.Forms.DataGridView();
            this.btnHostelModify = new System.Windows.Forms.Button();
            this.tbxRoomOccupant = new System.Windows.Forms.TextBox();
            this.lblRoomOccupant = new System.Windows.Forms.Label();
            this.btnStudentModify = new System.Windows.Forms.Button();
            this.tbxStudentName = new System.Windows.Forms.TextBox();
            this.tbxStudentID = new System.Windows.Forms.TextBox();
            this.cmbStudentSem = new System.Windows.Forms.ComboBox();
            this.lblStudentSemester = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.btnHostelSearch = new System.Windows.Forms.Button();
            this.btnStudentSearch = new System.Windows.Forms.Button();
            this.tbxHostelSearch = new System.Windows.Forms.TextBox();
            this.tbxStudentSearch = new System.Windows.Forms.TextBox();
            this.lblStudentInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHostelInfo = new System.Windows.Forms.Label();
            this.lblStudentSearch = new System.Windows.Forms.Label();
            this.cmbStudentSearch = new System.Windows.Forms.ComboBox();
            this.lblHostelSearch = new System.Windows.Forms.Label();
            this.cmbHostelSearch = new System.Windows.Forms.ComboBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.hostelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHostelList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHostelList
            // 
            this.dgvHostelList.AllowUserToAddRows = false;
            this.dgvHostelList.AllowUserToDeleteRows = false;
            this.dgvHostelList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHostelList.Location = new System.Drawing.Point(339, 106);
            this.dgvHostelList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvHostelList.Name = "dgvHostelList";
            this.dgvHostelList.ReadOnly = true;
            this.dgvHostelList.RowHeadersWidth = 51;
            this.dgvHostelList.RowTemplate.Height = 24;
            this.dgvHostelList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHostelList.Size = new System.Drawing.Size(262, 152);
            this.dgvHostelList.TabIndex = 66;
            this.dgvHostelList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvHostelList_CellClick);
            // 
            // dgvStudentList
            // 
            this.dgvStudentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentList.Location = new System.Drawing.Point(18, 106);
            this.dgvStudentList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvStudentList.Name = "dgvStudentList";
            this.dgvStudentList.RowHeadersWidth = 51;
            this.dgvStudentList.RowTemplate.Height = 24;
            this.dgvStudentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudentList.Size = new System.Drawing.Size(251, 152);
            this.dgvStudentList.TabIndex = 65;
            this.dgvStudentList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvStudentList_CellClick);
            // 
            // btnHostelModify
            // 
            this.btnHostelModify.BackColor = System.Drawing.SystemColors.Menu;
            this.btnHostelModify.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHostelModify.Location = new System.Drawing.Point(545, 371);
            this.btnHostelModify.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHostelModify.Name = "btnHostelModify";
            this.btnHostelModify.Size = new System.Drawing.Size(66, 28);
            this.btnHostelModify.TabIndex = 62;
            this.btnHostelModify.Text = "Modify";
            this.btnHostelModify.UseVisualStyleBackColor = false;
            this.btnHostelModify.Click += new System.EventHandler(this.btnHostelModify_Click);
            // 
            // tbxRoomOccupant
            // 
            this.tbxRoomOccupant.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRoomOccupant.Location = new System.Drawing.Point(442, 271);
            this.tbxRoomOccupant.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbxRoomOccupant.Name = "tbxRoomOccupant";
            this.tbxRoomOccupant.Size = new System.Drawing.Size(153, 21);
            this.tbxRoomOccupant.TabIndex = 61;
            // 
            // lblRoomOccupant
            // 
            this.lblRoomOccupant.AutoSize = true;
            this.lblRoomOccupant.BackColor = System.Drawing.Color.Transparent;
            this.lblRoomOccupant.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomOccupant.ForeColor = System.Drawing.Color.White;
            this.lblRoomOccupant.Location = new System.Drawing.Point(343, 274);
            this.lblRoomOccupant.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRoomOccupant.Name = "lblRoomOccupant";
            this.lblRoomOccupant.Size = new System.Drawing.Size(86, 15);
            this.lblRoomOccupant.TabIndex = 56;
            this.lblRoomOccupant.Text = "Room Occupant";
            // 
            // btnStudentModify
            // 
            this.btnStudentModify.BackColor = System.Drawing.SystemColors.Menu;
            this.btnStudentModify.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentModify.Location = new System.Drawing.Point(203, 371);
            this.btnStudentModify.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnStudentModify.Name = "btnStudentModify";
            this.btnStudentModify.Size = new System.Drawing.Size(66, 28);
            this.btnStudentModify.TabIndex = 55;
            this.btnStudentModify.Text = "Modify";
            this.btnStudentModify.UseVisualStyleBackColor = false;
            this.btnStudentModify.Click += new System.EventHandler(this.btnStudentModify_Click);
            // 
            // tbxStudentName
            // 
            this.tbxStudentName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxStudentName.Location = new System.Drawing.Point(100, 274);
            this.tbxStudentName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbxStudentName.Name = "tbxStudentName";
            this.tbxStudentName.Size = new System.Drawing.Size(169, 21);
            this.tbxStudentName.TabIndex = 54;
            // 
            // tbxStudentID
            // 
            this.tbxStudentID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxStudentID.Location = new System.Drawing.Point(101, 303);
            this.tbxStudentID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbxStudentID.Name = "tbxStudentID";
            this.tbxStudentID.Size = new System.Drawing.Size(168, 21);
            this.tbxStudentID.TabIndex = 53;
            // 
            // cmbStudentSem
            // 
            this.cmbStudentSem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStudentSem.FormattingEnabled = true;
            this.cmbStudentSem.Items.AddRange(new object[] {
            "Y1S1",
            "Y1S2",
            "Y2S1",
            "Y2S2",
            "Y3S1",
            "Y3S2"});
            this.cmbStudentSem.Location = new System.Drawing.Point(101, 331);
            this.cmbStudentSem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbStudentSem.Name = "cmbStudentSem";
            this.cmbStudentSem.Size = new System.Drawing.Size(168, 23);
            this.cmbStudentSem.TabIndex = 52;
            // 
            // lblStudentSemester
            // 
            this.lblStudentSemester.AutoSize = true;
            this.lblStudentSemester.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentSemester.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentSemester.ForeColor = System.Drawing.Color.White;
            this.lblStudentSemester.Location = new System.Drawing.Point(16, 331);
            this.lblStudentSemester.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentSemester.Name = "lblStudentSemester";
            this.lblStudentSemester.Size = new System.Drawing.Size(82, 15);
            this.lblStudentSemester.TabIndex = 51;
            this.lblStudentSemester.Text = "Study Semester";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentID.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentID.ForeColor = System.Drawing.Color.White;
            this.lblStudentID.Location = new System.Drawing.Point(16, 303);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(83, 15);
            this.lblStudentID.TabIndex = 50;
            this.lblStudentID.Text = "Registration No";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentName.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.ForeColor = System.Drawing.Color.White;
            this.lblStudentName.Location = new System.Drawing.Point(16, 274);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(75, 15);
            this.lblStudentName.TabIndex = 49;
            this.lblStudentName.Text = "Student Name";
            // 
            // btnHostelSearch
            // 
            this.btnHostelSearch.BackColor = System.Drawing.SystemColors.Menu;
            this.btnHostelSearch.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHostelSearch.Location = new System.Drawing.Point(545, 41);
            this.btnHostelSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnHostelSearch.Name = "btnHostelSearch";
            this.btnHostelSearch.Size = new System.Drawing.Size(56, 22);
            this.btnHostelSearch.TabIndex = 46;
            this.btnHostelSearch.Text = "Search";
            this.btnHostelSearch.UseVisualStyleBackColor = false;
            this.btnHostelSearch.Click += new System.EventHandler(this.btnHostelSearch_Click);
            // 
            // btnStudentSearch
            // 
            this.btnStudentSearch.BackColor = System.Drawing.SystemColors.Menu;
            this.btnStudentSearch.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentSearch.Location = new System.Drawing.Point(218, 41);
            this.btnStudentSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnStudentSearch.Name = "btnStudentSearch";
            this.btnStudentSearch.Size = new System.Drawing.Size(51, 22);
            this.btnStudentSearch.TabIndex = 45;
            this.btnStudentSearch.Text = "Search";
            this.btnStudentSearch.UseVisualStyleBackColor = false;
            this.btnStudentSearch.Click += new System.EventHandler(this.BtnStudentSearch_Click);
            // 
            // tbxHostelSearch
            // 
            this.tbxHostelSearch.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHostelSearch.Location = new System.Drawing.Point(339, 42);
            this.tbxHostelSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbxHostelSearch.Name = "tbxHostelSearch";
            this.tbxHostelSearch.Size = new System.Drawing.Size(200, 21);
            this.tbxHostelSearch.TabIndex = 44;
            // 
            // tbxStudentSearch
            // 
            this.tbxStudentSearch.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxStudentSearch.Location = new System.Drawing.Point(16, 41);
            this.tbxStudentSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbxStudentSearch.Name = "tbxStudentSearch";
            this.tbxStudentSearch.Size = new System.Drawing.Size(198, 21);
            this.tbxStudentSearch.TabIndex = 43;
            // 
            // lblStudentInfo
            // 
            this.lblStudentInfo.AutoSize = true;
            this.lblStudentInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentInfo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentInfo.ForeColor = System.Drawing.Color.White;
            this.lblStudentInfo.Location = new System.Drawing.Point(16, 89);
            this.lblStudentInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentInfo.Name = "lblStudentInfo";
            this.lblStudentInfo.Size = new System.Drawing.Size(104, 15);
            this.lblStudentInfo.TabIndex = 42;
            this.lblStudentInfo.Text = "Student Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(364, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 41;
            // 
            // lblHostelInfo
            // 
            this.lblHostelInfo.AutoSize = true;
            this.lblHostelInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblHostelInfo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostelInfo.ForeColor = System.Drawing.Color.White;
            this.lblHostelInfo.Location = new System.Drawing.Point(343, 89);
            this.lblHostelInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHostelInfo.Name = "lblHostelInfo";
            this.lblHostelInfo.Size = new System.Drawing.Size(127, 15);
            this.lblHostelInfo.TabIndex = 40;
            this.lblHostelInfo.Text = "Hostel Room Infomation";
            // 
            // lblStudentSearch
            // 
            this.lblStudentSearch.AutoSize = true;
            this.lblStudentSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblStudentSearch.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentSearch.ForeColor = System.Drawing.Color.White;
            this.lblStudentSearch.Location = new System.Drawing.Point(16, 16);
            this.lblStudentSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudentSearch.Name = "lblStudentSearch";
            this.lblStudentSearch.Size = new System.Drawing.Size(89, 15);
            this.lblStudentSearch.TabIndex = 68;
            this.lblStudentSearch.Text = "Search Parameter";
            // 
            // cmbStudentSearch
            // 
            this.cmbStudentSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudentSearch.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStudentSearch.FormattingEnabled = true;
            this.cmbStudentSearch.Items.AddRange(new object[] {
            "NAME",
            "SEMESTER",
            "ID",
            "ROOM",
            "FLOOR",
            "ALL"});
            this.cmbStudentSearch.Location = new System.Drawing.Point(119, 14);
            this.cmbStudentSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbStudentSearch.Name = "cmbStudentSearch";
            this.cmbStudentSearch.Size = new System.Drawing.Size(95, 23);
            this.cmbStudentSearch.TabIndex = 67;
            // 
            // lblHostelSearch
            // 
            this.lblHostelSearch.AutoSize = true;
            this.lblHostelSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblHostelSearch.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostelSearch.ForeColor = System.Drawing.Color.White;
            this.lblHostelSearch.Location = new System.Drawing.Point(336, 16);
            this.lblHostelSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHostelSearch.Name = "lblHostelSearch";
            this.lblHostelSearch.Size = new System.Drawing.Size(89, 15);
            this.lblHostelSearch.TabIndex = 70;
            this.lblHostelSearch.Text = "Search Parameter";
            // 
            // cmbHostelSearch
            // 
            this.cmbHostelSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHostelSearch.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHostelSearch.FormattingEnabled = true;
            this.cmbHostelSearch.Items.AddRange(new object[] {
            "ALL",
            "VACANT",
            "OCCUPIED",
            "ROOM NUM"});
            this.cmbHostelSearch.Location = new System.Drawing.Point(442, 14);
            this.cmbHostelSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmbHostelSearch.Name = "cmbHostelSearch";
            this.cmbHostelSearch.Size = new System.Drawing.Size(97, 23);
            this.cmbHostelSearch.TabIndex = 69;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.Menu;
            this.btnReturn.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(545, 342);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(66, 24);
            this.btnReturn.TabIndex = 71;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // hostelBindingSource
            // 
            this.hostelBindingSource.DataSource = typeof(Assignment_Defaultt.Hostel);
            // 
            // bookingBindingSource
            // 
            this.bookingBindingSource.DataSource = typeof(Assignment_Defaultt.Booking);
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(Assignment_Defaultt.Student);
            // 
            // Modify_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = global::Assignment_Defaultt.Properties.Resources.solid;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 420);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblHostelSearch);
            this.Controls.Add(this.cmbHostelSearch);
            this.Controls.Add(this.lblStudentSearch);
            this.Controls.Add(this.cmbStudentSearch);
            this.Controls.Add(this.dgvHostelList);
            this.Controls.Add(this.dgvStudentList);
            this.Controls.Add(this.btnHostelModify);
            this.Controls.Add(this.tbxRoomOccupant);
            this.Controls.Add(this.lblRoomOccupant);
            this.Controls.Add(this.btnStudentModify);
            this.Controls.Add(this.tbxStudentName);
            this.Controls.Add(this.tbxStudentID);
            this.Controls.Add(this.cmbStudentSem);
            this.Controls.Add(this.lblStudentSemester);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.btnHostelSearch);
            this.Controls.Add(this.btnStudentSearch);
            this.Controls.Add(this.tbxHostelSearch);
            this.Controls.Add(this.tbxStudentSearch);
            this.Controls.Add(this.lblStudentInfo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHostelInfo);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Modify_Information";
            this.Text = "Modify_Information";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Modify_Information_FormClosing);
            this.Load += new System.EventHandler(this.Modify_Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHostelList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hostelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHostelList;
        private System.Windows.Forms.DataGridView dgvStudentList;
        private System.Windows.Forms.Button btnHostelModify;
        private System.Windows.Forms.TextBox tbxRoomOccupant;
        private System.Windows.Forms.Label lblRoomOccupant;
        private System.Windows.Forms.Button btnStudentModify;
        private System.Windows.Forms.TextBox tbxStudentName;
        private System.Windows.Forms.TextBox tbxStudentID;
        private System.Windows.Forms.ComboBox cmbStudentSem;
        private System.Windows.Forms.Label lblStudentSemester;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Button btnHostelSearch;
        private System.Windows.Forms.Button btnStudentSearch;
        private System.Windows.Forms.TextBox tbxHostelSearch;
        private System.Windows.Forms.TextBox tbxStudentSearch;
        private System.Windows.Forms.Label lblStudentInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHostelInfo;
        private System.Windows.Forms.Label lblStudentSearch;
        private System.Windows.Forms.ComboBox cmbStudentSearch;
        private System.Windows.Forms.Label lblHostelSearch;
        private System.Windows.Forms.ComboBox cmbHostelSearch;
        private System.Windows.Forms.BindingSource hostelBindingSource;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.BindingSource bookingBindingSource;
    }
}