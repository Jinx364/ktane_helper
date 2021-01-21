namespace ktane_helper
{
   partial class SimonSaysForm
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
         this.neededInfoGroupBox = new System.Windows.Forms.GroupBox();
         this.info2Label = new System.Windows.Forms.Label();
         this.info1Label = new System.Windows.Forms.Label();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.blueButton = new System.Windows.Forms.Button();
         this.redButton = new System.Windows.Forms.Button();
         this.yellowButton = new System.Windows.Forms.Button();
         this.greenButton = new System.Windows.Forms.Button();
         this.bombGroupBox = new System.Windows.Forms.GroupBox();
         this.bombRichTextBox = new System.Windows.Forms.RichTextBox();
         this.solutionGroupBox = new System.Windows.Forms.GroupBox();
         this.solutionRichTextBox = new System.Windows.Forms.RichTextBox();
         this.resetButton = new System.Windows.Forms.Button();
         this.neededInfoGroupBox.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.bombGroupBox.SuspendLayout();
         this.solutionGroupBox.SuspendLayout();
         this.SuspendLayout();
         // 
         // neededInfoGroupBox
         // 
         this.neededInfoGroupBox.Controls.Add(this.info2Label);
         this.neededInfoGroupBox.Controls.Add(this.info1Label);
         this.neededInfoGroupBox.Location = new System.Drawing.Point(12, 12);
         this.neededInfoGroupBox.Name = "neededInfoGroupBox";
         this.neededInfoGroupBox.Size = new System.Drawing.Size(216, 74);
         this.neededInfoGroupBox.TabIndex = 2;
         this.neededInfoGroupBox.TabStop = false;
         this.neededInfoGroupBox.Text = "Needed Information";
         // 
         // info2Label
         // 
         this.info2Label.AutoSize = true;
         this.info2Label.Location = new System.Drawing.Point(15, 50);
         this.info2Label.Name = "info2Label";
         this.info2Label.Size = new System.Drawing.Size(153, 13);
         this.info2Label.TabIndex = 1;
         this.info2Label.Text = "● Does serial contain a vowel?";
         // 
         // info1Label
         // 
         this.info1Label.AutoSize = true;
         this.info1Label.Location = new System.Drawing.Point(15, 28);
         this.info1Label.Name = "info1Label";
         this.info1Label.Size = new System.Drawing.Size(99, 13);
         this.info1Label.TabIndex = 0;
         this.info1Label.Text = "● Number of strikes";
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::ktane_helper.Properties.Resources.simonsays_module;
         this.pictureBox1.Location = new System.Drawing.Point(423, 12);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(133, 133);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox1.TabIndex = 3;
         this.pictureBox1.TabStop = false;
         // 
         // blueButton
         // 
         this.blueButton.BackColor = System.Drawing.Color.Blue;
         this.blueButton.ForeColor = System.Drawing.Color.White;
         this.blueButton.Location = new System.Drawing.Point(116, 109);
         this.blueButton.Name = "blueButton";
         this.blueButton.Size = new System.Drawing.Size(75, 23);
         this.blueButton.TabIndex = 4;
         this.blueButton.Text = "Blue";
         this.blueButton.UseVisualStyleBackColor = false;
         this.blueButton.Click += new System.EventHandler(this.blueButton_Click);
         // 
         // redButton
         // 
         this.redButton.BackColor = System.Drawing.Color.Red;
         this.redButton.ForeColor = System.Drawing.Color.White;
         this.redButton.Location = new System.Drawing.Point(72, 138);
         this.redButton.Name = "redButton";
         this.redButton.Size = new System.Drawing.Size(75, 23);
         this.redButton.TabIndex = 5;
         this.redButton.Text = "Red";
         this.redButton.UseVisualStyleBackColor = false;
         this.redButton.Click += new System.EventHandler(this.redButton_Click);
         // 
         // yellowButton
         // 
         this.yellowButton.BackColor = System.Drawing.Color.Yellow;
         this.yellowButton.Location = new System.Drawing.Point(153, 138);
         this.yellowButton.Name = "yellowButton";
         this.yellowButton.Size = new System.Drawing.Size(75, 23);
         this.yellowButton.TabIndex = 6;
         this.yellowButton.Text = "Yellow";
         this.yellowButton.UseVisualStyleBackColor = false;
         this.yellowButton.Click += new System.EventHandler(this.yellowButton_Click);
         // 
         // greenButton
         // 
         this.greenButton.BackColor = System.Drawing.Color.LimeGreen;
         this.greenButton.ForeColor = System.Drawing.Color.White;
         this.greenButton.Location = new System.Drawing.Point(116, 167);
         this.greenButton.Name = "greenButton";
         this.greenButton.Size = new System.Drawing.Size(75, 23);
         this.greenButton.TabIndex = 7;
         this.greenButton.Text = "Green";
         this.greenButton.UseVisualStyleBackColor = false;
         this.greenButton.Click += new System.EventHandler(this.greenButton_Click);
         // 
         // bombGroupBox
         // 
         this.bombGroupBox.Controls.Add(this.bombRichTextBox);
         this.bombGroupBox.Location = new System.Drawing.Point(20, 205);
         this.bombGroupBox.Name = "bombGroupBox";
         this.bombGroupBox.Size = new System.Drawing.Size(535, 107);
         this.bombGroupBox.TabIndex = 8;
         this.bombGroupBox.TabStop = false;
         this.bombGroupBox.Text = "Bomb Sequence";
         // 
         // bombRichTextBox
         // 
         this.bombRichTextBox.Location = new System.Drawing.Point(10, 19);
         this.bombRichTextBox.Name = "bombRichTextBox";
         this.bombRichTextBox.ReadOnly = true;
         this.bombRichTextBox.Size = new System.Drawing.Size(519, 82);
         this.bombRichTextBox.TabIndex = 0;
         this.bombRichTextBox.Text = "";
         // 
         // solutionGroupBox
         // 
         this.solutionGroupBox.Controls.Add(this.solutionRichTextBox);
         this.solutionGroupBox.Location = new System.Drawing.Point(20, 321);
         this.solutionGroupBox.Name = "solutionGroupBox";
         this.solutionGroupBox.Size = new System.Drawing.Size(535, 107);
         this.solutionGroupBox.TabIndex = 9;
         this.solutionGroupBox.TabStop = false;
         this.solutionGroupBox.Text = "Solution Sequence";
         // 
         // solutionRichTextBox
         // 
         this.solutionRichTextBox.Location = new System.Drawing.Point(10, 19);
         this.solutionRichTextBox.Name = "solutionRichTextBox";
         this.solutionRichTextBox.ReadOnly = true;
         this.solutionRichTextBox.Size = new System.Drawing.Size(519, 82);
         this.solutionRichTextBox.TabIndex = 0;
         this.solutionRichTextBox.Text = "";
         // 
         // resetButton
         // 
         this.resetButton.Location = new System.Drawing.Point(288, 132);
         this.resetButton.Name = "resetButton";
         this.resetButton.Size = new System.Drawing.Size(75, 34);
         this.resetButton.TabIndex = 10;
         this.resetButton.Text = "Reset Sequence";
         this.resetButton.UseVisualStyleBackColor = true;
         this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
         // 
         // SimonSaysForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(568, 440);
         this.Controls.Add(this.resetButton);
         this.Controls.Add(this.solutionGroupBox);
         this.Controls.Add(this.bombGroupBox);
         this.Controls.Add(this.greenButton);
         this.Controls.Add(this.yellowButton);
         this.Controls.Add(this.redButton);
         this.Controls.Add(this.blueButton);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.neededInfoGroupBox);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.Name = "SimonSaysForm";
         this.Text = "Simon Says";
         this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SimonSaysForm_FormClosing);
         this.neededInfoGroupBox.ResumeLayout(false);
         this.neededInfoGroupBox.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.bombGroupBox.ResumeLayout(false);
         this.solutionGroupBox.ResumeLayout(false);
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.GroupBox neededInfoGroupBox;
      private System.Windows.Forms.Label info2Label;
      private System.Windows.Forms.Label info1Label;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Button blueButton;
      private System.Windows.Forms.Button redButton;
      private System.Windows.Forms.Button yellowButton;
      private System.Windows.Forms.Button greenButton;
      private System.Windows.Forms.GroupBox bombGroupBox;
      private System.Windows.Forms.RichTextBox bombRichTextBox;
      private System.Windows.Forms.GroupBox solutionGroupBox;
      private System.Windows.Forms.RichTextBox solutionRichTextBox;
      private System.Windows.Forms.Button resetButton;
   }
}