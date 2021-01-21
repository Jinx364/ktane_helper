namespace ktane_helper
{
   partial class ButtonForm
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
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.neededInfoGroupBox = new System.Windows.Forms.GroupBox();
         this.frkInfoLabel = new System.Windows.Forms.Label();
         this.carInfoLabel = new System.Windows.Forms.Label();
         this.batteryInfoLabel = new System.Windows.Forms.Label();
         this.colorLabel = new System.Windows.Forms.Label();
         this.colorComboBox = new System.Windows.Forms.ComboBox();
         this.textComboBox = new System.Windows.Forms.ComboBox();
         this.textLabel = new System.Windows.Forms.Label();
         this.solutionGroupBox = new System.Windows.Forms.GroupBox();
         this.holdSolutionLabel = new System.Windows.Forms.Label();
         this.pressSolutionLabel = new System.Windows.Forms.Label();
         this.releaseGroupBox = new System.Windows.Forms.GroupBox();
         this.label9 = new System.Windows.Forms.Label();
         this.label10 = new System.Windows.Forms.Label();
         this.label7 = new System.Windows.Forms.Label();
         this.label8 = new System.Windows.Forms.Label();
         this.label5 = new System.Windows.Forms.Label();
         this.label6 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.label3 = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.neededInfoGroupBox.SuspendLayout();
         this.solutionGroupBox.SuspendLayout();
         this.releaseGroupBox.SuspendLayout();
         this.SuspendLayout();
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::ktane_helper.Properties.Resources.button_module;
         this.pictureBox1.Location = new System.Drawing.Point(177, 13);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(133, 133);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         // 
         // neededInfoGroupBox
         // 
         this.neededInfoGroupBox.Controls.Add(this.frkInfoLabel);
         this.neededInfoGroupBox.Controls.Add(this.carInfoLabel);
         this.neededInfoGroupBox.Controls.Add(this.batteryInfoLabel);
         this.neededInfoGroupBox.Location = new System.Drawing.Point(16, 13);
         this.neededInfoGroupBox.Name = "neededInfoGroupBox";
         this.neededInfoGroupBox.Size = new System.Drawing.Size(148, 98);
         this.neededInfoGroupBox.TabIndex = 1;
         this.neededInfoGroupBox.TabStop = false;
         this.neededInfoGroupBox.Text = "Needed Information";
         // 
         // frkInfoLabel
         // 
         this.frkInfoLabel.AutoSize = true;
         this.frkInfoLabel.Location = new System.Drawing.Point(15, 73);
         this.frkInfoLabel.Name = "frkInfoLabel";
         this.frkInfoLabel.Size = new System.Drawing.Size(108, 13);
         this.frkInfoLabel.TabIndex = 2;
         this.frkInfoLabel.Text = "● Is FRK indicator lit?";
         this.frkInfoLabel.Visible = false;
         // 
         // carInfoLabel
         // 
         this.carInfoLabel.AutoSize = true;
         this.carInfoLabel.Location = new System.Drawing.Point(15, 50);
         this.carInfoLabel.Name = "carInfoLabel";
         this.carInfoLabel.Size = new System.Drawing.Size(109, 13);
         this.carInfoLabel.TabIndex = 1;
         this.carInfoLabel.Text = "● Is CAR indicator lit?";
         this.carInfoLabel.Visible = false;
         // 
         // batteryInfoLabel
         // 
         this.batteryInfoLabel.AutoSize = true;
         this.batteryInfoLabel.Location = new System.Drawing.Point(15, 28);
         this.batteryInfoLabel.Name = "batteryInfoLabel";
         this.batteryInfoLabel.Size = new System.Drawing.Size(109, 13);
         this.batteryInfoLabel.TabIndex = 0;
         this.batteryInfoLabel.Text = "● Number of batteries";
         this.batteryInfoLabel.Visible = false;
         // 
         // colorLabel
         // 
         this.colorLabel.AutoSize = true;
         this.colorLabel.Location = new System.Drawing.Point(13, 172);
         this.colorLabel.Name = "colorLabel";
         this.colorLabel.Size = new System.Drawing.Size(79, 13);
         this.colorLabel.TabIndex = 2;
         this.colorLabel.Text = "Color of button:";
         // 
         // colorComboBox
         // 
         this.colorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.colorComboBox.FormattingEnabled = true;
         this.colorComboBox.Location = new System.Drawing.Point(16, 188);
         this.colorComboBox.Name = "colorComboBox";
         this.colorComboBox.Size = new System.Drawing.Size(121, 21);
         this.colorComboBox.TabIndex = 3;
         this.colorComboBox.SelectedIndexChanged += new System.EventHandler(this.colorComboBox_SelectedIndexChanged);
         // 
         // textComboBox
         // 
         this.textComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.textComboBox.FormattingEnabled = true;
         this.textComboBox.Location = new System.Drawing.Point(165, 188);
         this.textComboBox.Name = "textComboBox";
         this.textComboBox.Size = new System.Drawing.Size(121, 21);
         this.textComboBox.TabIndex = 5;
         this.textComboBox.SelectedIndexChanged += new System.EventHandler(this.textComboBox_SelectedIndexChanged);
         // 
         // textLabel
         // 
         this.textLabel.AutoSize = true;
         this.textLabel.Location = new System.Drawing.Point(162, 172);
         this.textLabel.Name = "textLabel";
         this.textLabel.Size = new System.Drawing.Size(79, 13);
         this.textLabel.TabIndex = 4;
         this.textLabel.Text = "Text on button:";
         // 
         // solutionGroupBox
         // 
         this.solutionGroupBox.Controls.Add(this.holdSolutionLabel);
         this.solutionGroupBox.Controls.Add(this.pressSolutionLabel);
         this.solutionGroupBox.Location = new System.Drawing.Point(23, 221);
         this.solutionGroupBox.Name = "solutionGroupBox";
         this.solutionGroupBox.Size = new System.Drawing.Size(287, 80);
         this.solutionGroupBox.TabIndex = 6;
         this.solutionGroupBox.TabStop = false;
         this.solutionGroupBox.Text = "Solution";
         // 
         // holdSolutionLabel
         // 
         this.holdSolutionLabel.AutoSize = true;
         this.holdSolutionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.holdSolutionLabel.ForeColor = System.Drawing.Color.Red;
         this.holdSolutionLabel.Location = new System.Drawing.Point(118, 51);
         this.holdSolutionLabel.Name = "holdSolutionLabel";
         this.holdSolutionLabel.Size = new System.Drawing.Size(49, 16);
         this.holdSolutionLabel.TabIndex = 1;
         this.holdSolutionLabel.Text = "HOLD";
         this.holdSolutionLabel.Visible = false;
         // 
         // pressSolutionLabel
         // 
         this.pressSolutionLabel.AutoSize = true;
         this.pressSolutionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.pressSolutionLabel.ForeColor = System.Drawing.Color.LimeGreen;
         this.pressSolutionLabel.Location = new System.Drawing.Point(6, 25);
         this.pressSolutionLabel.Name = "pressSolutionLabel";
         this.pressSolutionLabel.Size = new System.Drawing.Size(273, 16);
         this.pressSolutionLabel.TabIndex = 0;
         this.pressSolutionLabel.Text = "PRESS AND IMMEDIATELY RELEASE";
         this.pressSolutionLabel.Visible = false;
         // 
         // releaseGroupBox
         // 
         this.releaseGroupBox.Controls.Add(this.label9);
         this.releaseGroupBox.Controls.Add(this.label10);
         this.releaseGroupBox.Controls.Add(this.label7);
         this.releaseGroupBox.Controls.Add(this.label8);
         this.releaseGroupBox.Controls.Add(this.label5);
         this.releaseGroupBox.Controls.Add(this.label6);
         this.releaseGroupBox.Controls.Add(this.label4);
         this.releaseGroupBox.Controls.Add(this.label3);
         this.releaseGroupBox.Location = new System.Drawing.Point(23, 322);
         this.releaseGroupBox.Name = "releaseGroupBox";
         this.releaseGroupBox.Size = new System.Drawing.Size(218, 118);
         this.releaseGroupBox.TabIndex = 7;
         this.releaseGroupBox.TabStop = false;
         this.releaseGroupBox.Text = "Releasing a Held Button";
         // 
         // label9
         // 
         this.label9.AutoSize = true;
         this.label9.BackColor = System.Drawing.SystemColors.Control;
         this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
         this.label9.Location = new System.Drawing.Point(74, 92);
         this.label9.Name = "label9";
         this.label9.Size = new System.Drawing.Size(128, 13);
         this.label9.TabIndex = 7;
         this.label9.Text = "timer has 1 in any position";
         // 
         // label10
         // 
         this.label10.AutoSize = true;
         this.label10.BackColor = System.Drawing.SystemColors.Control;
         this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
         this.label10.Location = new System.Drawing.Point(8, 92);
         this.label10.Name = "label10";
         this.label10.Size = new System.Drawing.Size(62, 13);
         this.label10.TabIndex = 6;
         this.label10.Text = "Other color:";
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.BackColor = System.Drawing.SystemColors.Control;
         this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
         this.label7.Location = new System.Drawing.Point(74, 70);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(128, 13);
         this.label7.TabIndex = 5;
         this.label7.Text = "timer has 5 in any position";
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.BackColor = System.Drawing.Color.Yellow;
         this.label8.ForeColor = System.Drawing.Color.Black;
         this.label8.Location = new System.Drawing.Point(8, 70);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(63, 13);
         this.label8.TabIndex = 4;
         this.label8.Text = "Yellow strip:";
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.BackColor = System.Drawing.SystemColors.Control;
         this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
         this.label5.Location = new System.Drawing.Point(74, 48);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(128, 13);
         this.label5.TabIndex = 3;
         this.label5.Text = "timer has 1 in any position";
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.BackColor = System.Drawing.Color.White;
         this.label6.ForeColor = System.Drawing.Color.Black;
         this.label6.Location = new System.Drawing.Point(8, 48);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(60, 13);
         this.label6.TabIndex = 2;
         this.label6.Text = "White strip:";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.BackColor = System.Drawing.SystemColors.Control;
         this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
         this.label4.Location = new System.Drawing.Point(74, 26);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(128, 13);
         this.label4.TabIndex = 1;
         this.label4.Text = "timer has 4 in any position";
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.BackColor = System.Drawing.Color.CornflowerBlue;
         this.label3.ForeColor = System.Drawing.Color.White;
         this.label3.Location = new System.Drawing.Point(8, 26);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(53, 13);
         this.label3.TabIndex = 0;
         this.label3.Text = "Blue strip:";
         // 
         // ButtonForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(324, 453);
         this.Controls.Add(this.releaseGroupBox);
         this.Controls.Add(this.solutionGroupBox);
         this.Controls.Add(this.textComboBox);
         this.Controls.Add(this.textLabel);
         this.Controls.Add(this.colorComboBox);
         this.Controls.Add(this.colorLabel);
         this.Controls.Add(this.neededInfoGroupBox);
         this.Controls.Add(this.pictureBox1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.Name = "ButtonForm";
         this.Text = "The Button";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ButtonForm_FormClosing);
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.neededInfoGroupBox.ResumeLayout(false);
         this.neededInfoGroupBox.PerformLayout();
         this.solutionGroupBox.ResumeLayout(false);
         this.solutionGroupBox.PerformLayout();
         this.releaseGroupBox.ResumeLayout(false);
         this.releaseGroupBox.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.GroupBox neededInfoGroupBox;
      private System.Windows.Forms.Label batteryInfoLabel;
      private System.Windows.Forms.Label frkInfoLabel;
      private System.Windows.Forms.Label carInfoLabel;
      private System.Windows.Forms.Label colorLabel;
      private System.Windows.Forms.ComboBox colorComboBox;
      private System.Windows.Forms.ComboBox textComboBox;
      private System.Windows.Forms.Label textLabel;
      private System.Windows.Forms.GroupBox solutionGroupBox;
      private System.Windows.Forms.GroupBox releaseGroupBox;
      private System.Windows.Forms.Label holdSolutionLabel;
      private System.Windows.Forms.Label pressSolutionLabel;
      private System.Windows.Forms.Label label9;
      private System.Windows.Forms.Label label10;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.Label label8;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Label label3;
   }
}