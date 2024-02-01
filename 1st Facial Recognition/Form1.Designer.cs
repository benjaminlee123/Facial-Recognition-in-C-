namespace _1st_Facial_Recognition
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDetect = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDateTime = new System.Windows.Forms.Label();
            this.txtShowDateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(474, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "AddStudentRecord";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDetect
            // 
            this.btnDetect.Location = new System.Drawing.Point(149, 282);
            this.btnDetect.Name = "btnDetect";
            this.btnDetect.Size = new System.Drawing.Size(474, 66);
            this.btnDetect.TabIndex = 1;
            this.btnDetect.Text = "Detect Face";
            this.btnDetect.UseVisualStyleBackColor = true;
            this.btnDetect.Click += new System.EventHandler(this.btnDetect_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.Location = new System.Drawing.Point(493, 43);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(84, 20);
            this.lblDateTime.TabIndex = 2;
            this.lblDateTime.Text = "Date Time:";
            // 
            // txtShowDateTime
            // 
            this.txtShowDateTime.BackColor = System.Drawing.SystemColors.Control;
            this.txtShowDateTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtShowDateTime.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowDateTime.Location = new System.Drawing.Point(593, 40);
            this.txtShowDateTime.Name = "txtShowDateTime";
            this.txtShowDateTime.Size = new System.Drawing.Size(185, 26);
            this.txtShowDateTime.TabIndex = 3;
            this.txtShowDateTime.TextChanged += new System.EventHandler(this.txtShowDateTime_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 442);
            this.Controls.Add(this.txtShowDateTime);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.btnDetect);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDetect;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.TextBox txtShowDateTime;
    }
}

