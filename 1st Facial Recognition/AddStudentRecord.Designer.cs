namespace _1st_Facial_Recognition
{
    partial class AddStudentRecord
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.imageBox5 = new Emgu.CV.UI.ImageBox();
            this.imageBox7 = new Emgu.CV.UI.ImageBox();
            this.imageBox8 = new Emgu.CV.UI.ImageBox();
            this.imageBox9 = new Emgu.CV.UI.ImageBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TbMobileNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.TbPassword = new System.Windows.Forms.TextBox();
            this.TbLastName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TbStudentId = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.TbFirstName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.admissionNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extractedfeaturesDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.usersInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingFacilityDataSet = new _1st_Facial_Recognition.BookingFacilityDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.usersInfoTableAdapter = new _1st_Facial_Recognition.BookingFacilityDataSetTableAdapters.UsersInfoTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox9)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingFacilityDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imageBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 573);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "First Step";
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.Color.Transparent;
            this.imageBox1.Location = new System.Drawing.Point(19, 140);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(501, 407);
            this.imageBox1.TabIndex = 4;
            this.imageBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 19);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(375, 102);
            this.button1.TabIndex = 3;
            this.button1.Text = "1. Start Camera and Detection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.imageBox5);
            this.groupBox3.Controls.Add(this.imageBox7);
            this.groupBox3.Controls.Add(this.imageBox8);
            this.groupBox3.Controls.Add(this.imageBox9);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Location = new System.Drawing.Point(577, 58);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(418, 293);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Second Step";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Nose";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Mouth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Eyes";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Face";
            // 
            // imageBox5
            // 
            this.imageBox5.BackColor = System.Drawing.Color.Transparent;
            this.imageBox5.Location = new System.Drawing.Point(303, 41);
            this.imageBox5.Name = "imageBox5";
            this.imageBox5.Size = new System.Drawing.Size(100, 100);
            this.imageBox5.TabIndex = 19;
            this.imageBox5.TabStop = false;
            // 
            // imageBox7
            // 
            this.imageBox7.BackColor = System.Drawing.Color.Transparent;
            this.imageBox7.Location = new System.Drawing.Point(278, 182);
            this.imageBox7.Name = "imageBox7";
            this.imageBox7.Size = new System.Drawing.Size(100, 100);
            this.imageBox7.TabIndex = 18;
            this.imageBox7.TabStop = false;
            // 
            // imageBox8
            // 
            this.imageBox8.BackColor = System.Drawing.Color.Transparent;
            this.imageBox8.Location = new System.Drawing.Point(154, 182);
            this.imageBox8.Name = "imageBox8";
            this.imageBox8.Size = new System.Drawing.Size(100, 100);
            this.imageBox8.TabIndex = 17;
            this.imageBox8.TabStop = false;
            // 
            // imageBox9
            // 
            this.imageBox9.BackColor = System.Drawing.Color.Transparent;
            this.imageBox9.Location = new System.Drawing.Point(29, 182);
            this.imageBox9.Name = "imageBox9";
            this.imageBox9.Size = new System.Drawing.Size(100, 100);
            this.imageBox9.TabIndex = 16;
            this.imageBox9.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(10, 39);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(282, 102);
            this.button3.TabIndex = 15;
            this.button3.Text = "2. Extract Features";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TbMobileNo);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.TbEmail);
            this.groupBox4.Controls.Add(this.TbPassword);
            this.groupBox4.Controls.Add(this.TbLastName);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.TbStudentId);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.button4);
            this.groupBox4.Controls.Add(this.TbFirstName);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Location = new System.Drawing.Point(577, 357);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(417, 274);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Final Step";
            // 
            // TbMobileNo
            // 
            this.TbMobileNo.Location = new System.Drawing.Point(69, 194);
            this.TbMobileNo.Name = "TbMobileNo";
            this.TbMobileNo.Size = new System.Drawing.Size(338, 20);
            this.TbMobileNo.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "MobileNo";
            // 
            // TbEmail
            // 
            this.TbEmail.Location = new System.Drawing.Point(69, 165);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(338, 20);
            this.TbEmail.TabIndex = 27;
            // 
            // TbPassword
            // 
            this.TbPassword.Location = new System.Drawing.Point(69, 136);
            this.TbPassword.Name = "TbPassword";
            this.TbPassword.Size = new System.Drawing.Size(338, 20);
            this.TbPassword.TabIndex = 26;
            // 
            // TbLastName
            // 
            this.TbLastName.Location = new System.Drawing.Point(69, 106);
            this.TbLastName.Name = "TbLastName";
            this.TbLastName.Size = new System.Drawing.Size(338, 20);
            this.TbLastName.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 168);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Email";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Password";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "LastName";
            // 
            // TbStudentId
            // 
            this.TbStudentId.Location = new System.Drawing.Point(69, 76);
            this.TbStudentId.Name = "TbStudentId";
            this.TbStudentId.Size = new System.Drawing.Size(339, 20);
            this.TbStudentId.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "StudentID:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(145, 221);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 46);
            this.button4.TabIndex = 19;
            this.button4.Text = "3. Save Student to the database";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // TbFirstName
            // 
            this.TbFirstName.Location = new System.Drawing.Point(69, 46);
            this.TbFirstName.Name = "TbFirstName";
            this.TbFirstName.Size = new System.Drawing.Size(339, 20);
            this.TbFirstName.TabIndex = 18;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 13);
            this.label16.TabIndex = 17;
            this.label16.Text = "FirstName";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.closeProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1007, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // closeProgramToolStripMenuItem
            // 
            this.closeProgramToolStripMenuItem.Name = "closeProgramToolStripMenuItem";
            this.closeProgramToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.closeProgramToolStripMenuItem.Text = "Close Program";
            this.closeProgramToolStripMenuItem.Click += new System.EventHandler(this.closeProgramToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.admissionNoDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.extractedfeaturesDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.usersInfoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(45, 673);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(922, 262);
            this.dataGridView1.TabIndex = 25;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // admissionNoDataGridViewTextBoxColumn
            // 
            this.admissionNoDataGridViewTextBoxColumn.DataPropertyName = "AdmissionNo";
            this.admissionNoDataGridViewTextBoxColumn.HeaderText = "AdmissionNo";
            this.admissionNoDataGridViewTextBoxColumn.Name = "admissionNoDataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "MobileNo";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "MobileNo";
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            // 
            // extractedfeaturesDataGridViewImageColumn
            // 
            this.extractedfeaturesDataGridViewImageColumn.DataPropertyName = "extractedfeatures";
            this.extractedfeaturesDataGridViewImageColumn.HeaderText = "extractedfeatures";
            this.extractedfeaturesDataGridViewImageColumn.Name = "extractedfeaturesDataGridViewImageColumn";
            // 
            // usersInfoBindingSource
            // 
            this.usersInfoBindingSource.DataMember = "UsersInfo";
            this.usersInfoBindingSource.DataSource = this.bookingFacilityDataSet;
            // 
            // bookingFacilityDataSet
            // 
            this.bookingFacilityDataSet.DataSetName = "BookingFacilityDataSet";
            this.bookingFacilityDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(175, 802);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(8, 8);
            this.dataGridView2.TabIndex = 26;
            // 
            // usersInfoTableAdapter
            // 
            this.usersInfoTableAdapter.ClearBeforeFill = true;
            // 
            // AddStudentRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 965);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddStudentRecord";
            this.Text = "AddStudentRecord";
            this.Load += new System.EventHandler(this.AddStudentRecord_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox9)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingFacilityDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TbMobileNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.TextBox TbPassword;
        private System.Windows.Forms.TextBox TbLastName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TbStudentId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox TbFirstName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeProgramToolStripMenuItem;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Emgu.CV.UI.ImageBox imageBox5;
        private Emgu.CV.UI.ImageBox imageBox7;
        private Emgu.CV.UI.ImageBox imageBox8;
        private Emgu.CV.UI.ImageBox imageBox9;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private BookingFacilityDataSet bookingFacilityDataSet;
        private System.Windows.Forms.BindingSource usersInfoBindingSource;
        private BookingFacilityDataSetTableAdapters.UsersInfoTableAdapter usersInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn admissionNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn extractedfeaturesDataGridViewImageColumn;
    }
}