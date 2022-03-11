
namespace FormsCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Today = new System.Windows.Forms.Label();
            this.lbl_NearestBDay = new System.Windows.Forms.Label();
            this.lb_Persons = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_BirthDate = new System.Windows.Forms.Label();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.date_Birthday = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dnes je";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nejbližší narozeniny";
            // 
            // lbl_Today
            // 
            this.lbl_Today.Location = new System.Drawing.Point(223, 21);
            this.lbl_Today.Name = "lbl_Today";
            this.lbl_Today.Size = new System.Drawing.Size(205, 18);
            this.lbl_Today.TabIndex = 2;
            this.lbl_Today.Text = "label3";
            // 
            // lbl_NearestBDay
            // 
            this.lbl_NearestBDay.Location = new System.Drawing.Point(223, 50);
            this.lbl_NearestBDay.Name = "lbl_NearestBDay";
            this.lbl_NearestBDay.Size = new System.Drawing.Size(205, 18);
            this.lbl_NearestBDay.TabIndex = 3;
            this.lbl_NearestBDay.Text = "label4";
            // 
            // lb_Persons
            // 
            this.lb_Persons.FormattingEnabled = true;
            this.lb_Persons.Location = new System.Drawing.Point(15, 106);
            this.lb_Persons.Name = "lb_Persons";
            this.lb_Persons.Size = new System.Drawing.Size(187, 290);
            this.lb_Persons.TabIndex = 4;
            this.lb_Persons.SelectedIndexChanged += new System.EventHandler(this.lb_Persons_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(223, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Narozeniny";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(223, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Věk";
            // 
            // lbl_BirthDate
            // 
            this.lbl_BirthDate.Location = new System.Drawing.Point(309, 106);
            this.lbl_BirthDate.Name = "lbl_BirthDate";
            this.lbl_BirthDate.Size = new System.Drawing.Size(119, 18);
            this.lbl_BirthDate.TabIndex = 7;
            this.lbl_BirthDate.Text = "lbl";
            // 
            // lbl_Age
            // 
            this.lbl_Age.Location = new System.Drawing.Point(309, 136);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(119, 18);
            this.lbl_Age.TabIndex = 8;
            this.lbl_Age.Text = "lbl";
            // 
            // date_Birthday
            // 
            this.date_Birthday.Location = new System.Drawing.Point(214, 234);
            this.date_Birthday.Name = "date_Birthday";
            this.date_Birthday.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Přidat";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(241, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 41);
            this.button2.TabIndex = 11;
            this.button2.Text = "Odebrat";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 481);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.date_Birthday);
            this.Controls.Add(this.lbl_Age);
            this.Controls.Add(this.lbl_BirthDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb_Persons);
            this.Controls.Add(this.lbl_NearestBDay);
            this.Controls.Add(this.lbl_Today);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Today;
        private System.Windows.Forms.Label lbl_NearestBDay;
        private System.Windows.Forms.ListBox lb_Persons;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_BirthDate;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.MonthCalendar date_Birthday;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

