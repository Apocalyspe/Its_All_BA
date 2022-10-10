namespace L2PCourseApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CourseListBox = new System.Windows.Forms.ListBox();
            this.DetailPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MasterSuiteRB = new System.Windows.Forms.RadioButton();
            this.ExecutiveSuiteRB = new System.Windows.Forms.RadioButton();
            this.JuniorSuiteRB = new System.Windows.Forms.RadioButton();
            this.DigiCertCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AttendeesTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Courses = new System.Windows.Forms.Label();
            this.LocationsListBox = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SummaryButton = new System.Windows.Forms.Button();
            this.BookButton = new System.Windows.Forms.Button();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.DetailPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // CourseListBox
            // 
            this.CourseListBox.BackColor = System.Drawing.Color.White;
            this.CourseListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CourseListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseListBox.FormattingEnabled = true;
            this.CourseListBox.ItemHeight = 29;
            this.CourseListBox.Items.AddRange(new object[] {
            "C# Fundamentals\t\t2 Days         €900",
            "C# Basic for Beginners\t4 Days         €1500",
            "C# Intermediate\t\t4 Days         €1800",
            "C# Advanced Topics\t2 Days         €2300",
            "ASP .NET with C# Part A\t5 Days         €1250",
            "ASP .NET with C# Part B\t5 Days         €1250"});
            this.CourseListBox.Location = new System.Drawing.Point(31, 83);
            this.CourseListBox.Name = "CourseListBox";
            this.CourseListBox.Size = new System.Drawing.Size(540, 234);
            this.CourseListBox.TabIndex = 0;
            // 
            // DetailPanel
            // 
            this.DetailPanel.BackColor = System.Drawing.Color.White;
            this.DetailPanel.Controls.Add(this.panel1);
            this.DetailPanel.Controls.Add(this.DigiCertCheckBox);
            this.DetailPanel.Controls.Add(this.pictureBox1);
            this.DetailPanel.Controls.Add(this.label6);
            this.DetailPanel.Controls.Add(this.AttendeesTextBox);
            this.DetailPanel.Controls.Add(this.label5);
            this.DetailPanel.Controls.Add(this.label4);
            this.DetailPanel.Controls.Add(this.label3);
            this.DetailPanel.Controls.Add(this.label2);
            this.DetailPanel.Controls.Add(this.label1);
            this.DetailPanel.Controls.Add(this.Courses);
            this.DetailPanel.Controls.Add(this.LocationsListBox);
            this.DetailPanel.Controls.Add(this.CourseListBox);
            this.DetailPanel.Location = new System.Drawing.Point(220, 54);
            this.DetailPanel.Name = "DetailPanel";
            this.DetailPanel.Size = new System.Drawing.Size(1795, 390);
            this.DetailPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.MasterSuiteRB);
            this.panel1.Controls.Add(this.ExecutiveSuiteRB);
            this.panel1.Controls.Add(this.JuniorSuiteRB);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(1417, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 164);
            this.panel1.TabIndex = 2;
            // 
            // MasterSuiteRB
            // 
            this.MasterSuiteRB.AutoSize = true;
            this.MasterSuiteRB.Location = new System.Drawing.Point(13, 21);
            this.MasterSuiteRB.Name = "MasterSuiteRB";
            this.MasterSuiteRB.Size = new System.Drawing.Size(315, 33);
            this.MasterSuiteRB.TabIndex = 9;
            this.MasterSuiteRB.Text = "Master Suite           €99.99";
            this.MasterSuiteRB.UseVisualStyleBackColor = true;
            // 
            // ExecutiveSuiteRB
            // 
            this.ExecutiveSuiteRB.AutoSize = true;
            this.ExecutiveSuiteRB.Location = new System.Drawing.Point(13, 60);
            this.ExecutiveSuiteRB.Name = "ExecutiveSuiteRB";
            this.ExecutiveSuiteRB.Size = new System.Drawing.Size(315, 33);
            this.ExecutiveSuiteRB.TabIndex = 10;
            this.ExecutiveSuiteRB.Text = "Executive Suite      €69.99";
            this.ExecutiveSuiteRB.UseVisualStyleBackColor = true;
            // 
            // JuniorSuiteRB
            // 
            this.JuniorSuiteRB.AutoSize = true;
            this.JuniorSuiteRB.Location = new System.Drawing.Point(13, 99);
            this.JuniorSuiteRB.Name = "JuniorSuiteRB";
            this.JuniorSuiteRB.Size = new System.Drawing.Size(314, 33);
            this.JuniorSuiteRB.TabIndex = 11;
            this.JuniorSuiteRB.Text = "Junior Suite            €49.99";
            this.JuniorSuiteRB.UseVisualStyleBackColor = true;
            // 
            // DigiCertCheckBox
            // 
            this.DigiCertCheckBox.AutoSize = true;
            this.DigiCertCheckBox.Location = new System.Drawing.Point(1463, 288);
            this.DigiCertCheckBox.Name = "DigiCertCheckBox";
            this.DigiCertCheckBox.Size = new System.Drawing.Size(282, 29);
            this.DigiCertCheckBox.TabIndex = 14;
            this.DigiCertCheckBox.Text = "Include Digital Certificate";
            this.DigiCertCheckBox.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1182, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1529, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Upgrades";
            // 
            // AttendeesTextBox
            // 
            this.AttendeesTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AttendeesTextBox.Location = new System.Drawing.Point(1193, 81);
            this.AttendeesTextBox.Name = "AttendeesTextBox";
            this.AttendeesTextBox.Size = new System.Drawing.Size(181, 31);
            this.AttendeesTextBox.TabIndex = 8;
            this.AttendeesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(614, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Locations";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(964, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fees per Day";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1209, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Attendees";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Training Days";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(485, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fees";
            // 
            // Courses
            // 
            this.Courses.BackColor = System.Drawing.SystemColors.Window;
            this.Courses.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Courses.Location = new System.Drawing.Point(26, 31);
            this.Courses.Name = "Courses";
            this.Courses.Size = new System.Drawing.Size(112, 31);
            this.Courses.TabIndex = 2;
            this.Courses.Text = "Courses";
            // 
            // LocationsListBox
            // 
            this.LocationsListBox.BackColor = System.Drawing.Color.White;
            this.LocationsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LocationsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LocationsListBox.FormattingEnabled = true;
            this.LocationsListBox.ItemHeight = 29;
            this.LocationsListBox.Items.AddRange(new object[] {
            "Belmullet\t\t\t         €219.99",
            "Clifden\t\t\t         €119.99",
            "Cork\t\t\t         €1149.99",
            "Dublin\t\t\t         €179.99",
            "Killarney\t\t\t         €149.99",
            "Letterkenny\t\t         €89.99",
            "Sligo\t\t\t         €119.99"});
            this.LocationsListBox.Location = new System.Drawing.Point(619, 83);
            this.LocationsListBox.Name = "LocationsListBox";
            this.LocationsListBox.Size = new System.Drawing.Size(514, 234);
            this.LocationsListBox.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.ExitButton);
            this.panel2.Controls.Add(this.ClearButton);
            this.panel2.Controls.Add(this.SummaryButton);
            this.panel2.Controls.Add(this.BookButton);
            this.panel2.Controls.Add(this.DisplayButton);
            this.panel2.Location = new System.Drawing.Point(1585, 488);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 490);
            this.panel2.TabIndex = 2;
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(116, 373);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(221, 53);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(116, 294);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(221, 53);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // SummaryButton
            // 
            this.SummaryButton.Location = new System.Drawing.Point(116, 215);
            this.SummaryButton.Name = "SummaryButton";
            this.SummaryButton.Size = new System.Drawing.Size(221, 53);
            this.SummaryButton.TabIndex = 2;
            this.SummaryButton.Text = "Summary";
            this.SummaryButton.UseVisualStyleBackColor = true;
            // 
            // BookButton
            // 
            this.BookButton.Location = new System.Drawing.Point(116, 134);
            this.BookButton.Name = "BookButton";
            this.BookButton.Size = new System.Drawing.Size(221, 53);
            this.BookButton.TabIndex = 1;
            this.BookButton.Text = "Book";
            this.BookButton.UseVisualStyleBackColor = true;
            // 
            // DisplayButton
            // 
            this.DisplayButton.Location = new System.Drawing.Point(116, 53);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(221, 53);
            this.DisplayButton.TabIndex = 0;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.ResultLabel);
            this.panel3.Location = new System.Drawing.Point(220, 488);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1291, 490);
            this.panel3.TabIndex = 3;
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(68, 53);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(0, 25);
            this.ResultLabel.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2157, 1121);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DetailPanel);
            this.Name = "Form1";
            this.Text = "L2P Ltd.";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DetailPanel.ResumeLayout(false);
            this.DetailPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox CourseListBox;
        private System.Windows.Forms.Panel DetailPanel;
        private System.Windows.Forms.ListBox LocationsListBox;
        private System.Windows.Forms.Label Courses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton JuniorSuiteRB;
        private System.Windows.Forms.RadioButton ExecutiveSuiteRB;
        private System.Windows.Forms.RadioButton MasterSuiteRB;
        private System.Windows.Forms.TextBox AttendeesTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox DigiCertCheckBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SummaryButton;
        private System.Windows.Forms.Button BookButton;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label ResultLabel;
    }
}

