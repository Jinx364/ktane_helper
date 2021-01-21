namespace ktane_helper
{
   partial class WireSequenceForm
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
         this.instructionGroupBox = new System.Windows.Forms.GroupBox();
         this.instructionsTextBox = new System.Windows.Forms.RichTextBox();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.groupBox3 = new System.Windows.Forms.GroupBox();
         this.label1 = new System.Windows.Forms.Label();
         this.redOccurTextBox = new System.Windows.Forms.TextBox();
         this.label2 = new System.Windows.Forms.Label();
         this.redCutTextBox = new System.Windows.Forms.TextBox();
         this.redPrevButton = new System.Windows.Forms.Button();
         this.redNextButton = new System.Windows.Forms.Button();
         this.blueNextButton = new System.Windows.Forms.Button();
         this.bluePrevButton = new System.Windows.Forms.Button();
         this.blueCutTextBox = new System.Windows.Forms.TextBox();
         this.label3 = new System.Windows.Forms.Label();
         this.label4 = new System.Windows.Forms.Label();
         this.blackNextButton = new System.Windows.Forms.Button();
         this.blackPrevButton = new System.Windows.Forms.Button();
         this.blackCutTextBox = new System.Windows.Forms.TextBox();
         this.label5 = new System.Windows.Forms.Label();
         this.blackOccurTextBox = new System.Windows.Forms.TextBox();
         this.label6 = new System.Windows.Forms.Label();
         this.blueOccurTextBox = new System.Windows.Forms.TextBox();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.instructionGroupBox.SuspendLayout();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.groupBox3.SuspendLayout();
         this.SuspendLayout();
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::ktane_helper.Properties.Resources.wire_sequences_module;
         this.pictureBox1.Location = new System.Drawing.Point(487, 12);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(133, 133);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         // 
         // instructionGroupBox
         // 
         this.instructionGroupBox.Controls.Add(this.instructionsTextBox);
         this.instructionGroupBox.Location = new System.Drawing.Point(12, 12);
         this.instructionGroupBox.Name = "instructionGroupBox";
         this.instructionGroupBox.Size = new System.Drawing.Size(356, 145);
         this.instructionGroupBox.TabIndex = 1;
         this.instructionGroupBox.TabStop = false;
         this.instructionGroupBox.Text = "Instructions";
         // 
         // instructionsTextBox
         // 
         this.instructionsTextBox.Location = new System.Drawing.Point(6, 19);
         this.instructionsTextBox.Name = "instructionsTextBox";
         this.instructionsTextBox.ReadOnly = true;
         this.instructionsTextBox.Size = new System.Drawing.Size(344, 120);
         this.instructionsTextBox.TabIndex = 0;
         this.instructionsTextBox.TabStop = false;
         this.instructionsTextBox.Text = "";
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.redNextButton);
         this.groupBox1.Controls.Add(this.redPrevButton);
         this.groupBox1.Controls.Add(this.redCutTextBox);
         this.groupBox1.Controls.Add(this.label2);
         this.groupBox1.Controls.Add(this.redOccurTextBox);
         this.groupBox1.Controls.Add(this.label1);
         this.groupBox1.Location = new System.Drawing.Point(18, 184);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(180, 176);
         this.groupBox1.TabIndex = 2;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Red Wire Occurrences";
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.blueNextButton);
         this.groupBox2.Controls.Add(this.label4);
         this.groupBox2.Controls.Add(this.bluePrevButton);
         this.groupBox2.Controls.Add(this.blueOccurTextBox);
         this.groupBox2.Controls.Add(this.blueCutTextBox);
         this.groupBox2.Controls.Add(this.label3);
         this.groupBox2.Location = new System.Drawing.Point(204, 184);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(180, 176);
         this.groupBox2.TabIndex = 3;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Blue Wire Occurrences";
         // 
         // groupBox3
         // 
         this.groupBox3.Controls.Add(this.blackNextButton);
         this.groupBox3.Controls.Add(this.label6);
         this.groupBox3.Controls.Add(this.blackPrevButton);
         this.groupBox3.Controls.Add(this.blackOccurTextBox);
         this.groupBox3.Controls.Add(this.blackCutTextBox);
         this.groupBox3.Controls.Add(this.label5);
         this.groupBox3.Location = new System.Drawing.Point(390, 184);
         this.groupBox3.Name = "groupBox3";
         this.groupBox3.Size = new System.Drawing.Size(180, 176);
         this.groupBox3.TabIndex = 4;
         this.groupBox3.TabStop = false;
         this.groupBox3.Text = "Black Wire Occurrences";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(6, 27);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(91, 13);
         this.label1.TabIndex = 0;
         this.label1.Text = "Wire Occurrence:";
         // 
         // redOccurTextBox
         // 
         this.redOccurTextBox.Location = new System.Drawing.Point(35, 43);
         this.redOccurTextBox.Name = "redOccurTextBox";
         this.redOccurTextBox.ReadOnly = true;
         this.redOccurTextBox.Size = new System.Drawing.Size(71, 20);
         this.redOccurTextBox.TabIndex = 1;
         this.redOccurTextBox.TabStop = false;
         this.redOccurTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(6, 66);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(100, 13);
         this.label2.TabIndex = 2;
         this.label2.Text = "Cut if connected to:";
         // 
         // redCutTextBox
         // 
         this.redCutTextBox.Location = new System.Drawing.Point(35, 82);
         this.redCutTextBox.Name = "redCutTextBox";
         this.redCutTextBox.ReadOnly = true;
         this.redCutTextBox.Size = new System.Drawing.Size(100, 20);
         this.redCutTextBox.TabIndex = 3;
         this.redCutTextBox.TabStop = false;
         this.redCutTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // redPrevButton
         // 
         this.redPrevButton.Location = new System.Drawing.Point(9, 129);
         this.redPrevButton.Name = "redPrevButton";
         this.redPrevButton.Size = new System.Drawing.Size(75, 23);
         this.redPrevButton.TabIndex = 4;
         this.redPrevButton.Text = "← Prev";
         this.redPrevButton.UseVisualStyleBackColor = true;
         this.redPrevButton.Click += new System.EventHandler(this.redPrevButton_Click);
         // 
         // redNextButton
         // 
         this.redNextButton.Location = new System.Drawing.Point(90, 129);
         this.redNextButton.Name = "redNextButton";
         this.redNextButton.Size = new System.Drawing.Size(75, 23);
         this.redNextButton.TabIndex = 5;
         this.redNextButton.Text = "Next →";
         this.redNextButton.UseVisualStyleBackColor = true;
         this.redNextButton.Click += new System.EventHandler(this.redNextButton_Click);
         // 
         // blueNextButton
         // 
         this.blueNextButton.Location = new System.Drawing.Point(90, 129);
         this.blueNextButton.Name = "blueNextButton";
         this.blueNextButton.Size = new System.Drawing.Size(75, 23);
         this.blueNextButton.TabIndex = 11;
         this.blueNextButton.Text = "Next →";
         this.blueNextButton.UseVisualStyleBackColor = true;
         this.blueNextButton.Click += new System.EventHandler(this.blueNextButton_Click);
         // 
         // bluePrevButton
         // 
         this.bluePrevButton.Location = new System.Drawing.Point(9, 129);
         this.bluePrevButton.Name = "bluePrevButton";
         this.bluePrevButton.Size = new System.Drawing.Size(75, 23);
         this.bluePrevButton.TabIndex = 10;
         this.bluePrevButton.Text = "← Prev";
         this.bluePrevButton.UseVisualStyleBackColor = true;
         this.bluePrevButton.Click += new System.EventHandler(this.bluePrevButton_Click);
         // 
         // blueCutTextBox
         // 
         this.blueCutTextBox.Location = new System.Drawing.Point(35, 82);
         this.blueCutTextBox.Name = "blueCutTextBox";
         this.blueCutTextBox.ReadOnly = true;
         this.blueCutTextBox.Size = new System.Drawing.Size(100, 20);
         this.blueCutTextBox.TabIndex = 9;
         this.blueCutTextBox.TabStop = false;
         this.blueCutTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(6, 66);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(100, 13);
         this.label3.TabIndex = 8;
         this.label3.Text = "Cut if connected to:";
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(6, 27);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(91, 13);
         this.label4.TabIndex = 6;
         this.label4.Text = "Wire Occurrence:";
         // 
         // blackNextButton
         // 
         this.blackNextButton.Location = new System.Drawing.Point(90, 129);
         this.blackNextButton.Name = "blackNextButton";
         this.blackNextButton.Size = new System.Drawing.Size(75, 23);
         this.blackNextButton.TabIndex = 17;
         this.blackNextButton.Text = "Next →";
         this.blackNextButton.UseVisualStyleBackColor = true;
         this.blackNextButton.Click += new System.EventHandler(this.blackNextButton_Click);
         // 
         // blackPrevButton
         // 
         this.blackPrevButton.Location = new System.Drawing.Point(9, 129);
         this.blackPrevButton.Name = "blackPrevButton";
         this.blackPrevButton.Size = new System.Drawing.Size(75, 23);
         this.blackPrevButton.TabIndex = 16;
         this.blackPrevButton.Text = "← Prev";
         this.blackPrevButton.UseVisualStyleBackColor = true;
         this.blackPrevButton.Click += new System.EventHandler(this.blackPrevButton_Click);
         // 
         // blackCutTextBox
         // 
         this.blackCutTextBox.Location = new System.Drawing.Point(35, 82);
         this.blackCutTextBox.Name = "blackCutTextBox";
         this.blackCutTextBox.ReadOnly = true;
         this.blackCutTextBox.Size = new System.Drawing.Size(100, 20);
         this.blackCutTextBox.TabIndex = 15;
         this.blackCutTextBox.TabStop = false;
         this.blackCutTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(6, 66);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(100, 13);
         this.label5.TabIndex = 14;
         this.label5.Text = "Cut if connected to:";
         // 
         // blackOccurTextBox
         // 
         this.blackOccurTextBox.Location = new System.Drawing.Point(35, 43);
         this.blackOccurTextBox.Name = "blackOccurTextBox";
         this.blackOccurTextBox.ReadOnly = true;
         this.blackOccurTextBox.Size = new System.Drawing.Size(71, 20);
         this.blackOccurTextBox.TabIndex = 13;
         this.blackOccurTextBox.TabStop = false;
         this.blackOccurTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(6, 27);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(91, 13);
         this.label6.TabIndex = 12;
         this.label6.Text = "Wire Occurrence:";
         // 
         // blueOccurTextBox
         // 
         this.blueOccurTextBox.Location = new System.Drawing.Point(35, 43);
         this.blueOccurTextBox.Name = "blueOccurTextBox";
         this.blueOccurTextBox.ReadOnly = true;
         this.blueOccurTextBox.Size = new System.Drawing.Size(71, 20);
         this.blueOccurTextBox.TabIndex = 7;
         this.blueOccurTextBox.TabStop = false;
         this.blueOccurTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // WireSequenceForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(632, 386);
         this.Controls.Add(this.groupBox3);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.instructionGroupBox);
         this.Controls.Add(this.pictureBox1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.Name = "WireSequenceForm";
         this.Text = "Wire Sequences";
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.instructionGroupBox.ResumeLayout(false);
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.groupBox2.ResumeLayout(false);
         this.groupBox2.PerformLayout();
         this.groupBox3.ResumeLayout(false);
         this.groupBox3.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.GroupBox instructionGroupBox;
      private System.Windows.Forms.RichTextBox instructionsTextBox;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.GroupBox groupBox3;
      private System.Windows.Forms.TextBox redOccurTextBox;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.TextBox redCutTextBox;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Button redNextButton;
      private System.Windows.Forms.Button redPrevButton;
      private System.Windows.Forms.Button blueNextButton;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.Button bluePrevButton;
      private System.Windows.Forms.TextBox blueCutTextBox;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.Button blackNextButton;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.Button blackPrevButton;
      private System.Windows.Forms.TextBox blackOccurTextBox;
      private System.Windows.Forms.TextBox blackCutTextBox;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.TextBox blueOccurTextBox;
   }
}