using System.Threading;

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
            this.num_Number1 = new System.Windows.Forms.NumericUpDown();
            this.num_Number2 = new System.Windows.Forms.NumericUpDown();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.num_Number1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Number2)).BeginInit();
            this.SuspendLayout();
            // 
            // num_Number1
            // 
            this.num_Number1.DecimalPlaces = 2;
            this.num_Number1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_Number1.Location = new System.Drawing.Point(49, 142);
            this.num_Number1.Name = "num_Number1";
            this.num_Number1.Size = new System.Drawing.Size(120, 31);
            this.num_Number1.TabIndex = 0;
            this.num_Number1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.num_Number1_KeyDown);
            this.num_Number1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.num_Number1_KeyPress);
            // 
            // num_Number2
            // 
            this.num_Number2.DecimalPlaces = 2;
            this.num_Number2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_Number2.Location = new System.Drawing.Point(205, 142);
            this.num_Number2.Name = "num_Number2";
            this.num_Number2.Size = new System.Drawing.Size(120, 31);
            this.num_Number2.TabIndex = 1;
            this.num_Number2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.num_Number2_KeyDown);
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Result.Location = new System.Drawing.Point(434, 144);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(70, 25);
            this.lbl_Result.TabIndex = 2;
            this.lbl_Result.Text = "label1";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calculate.Location = new System.Drawing.Point(344, 142);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(75, 31);
            this.btn_Calculate.TabIndex = 3;
            this.btn_Calculate.Text = "=";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "+";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.num_Number2);
            this.Controls.Add(this.num_Number1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "FormsCalculator";
            ((System.ComponentModel.ISupportInitialize)(this.num_Number1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Number2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num_Number1;
        private System.Windows.Forms.NumericUpDown num_Number2;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Label label1;
    }
}

