namespace ktane_helper
{
   partial class MemoryForm
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
         this.label2 = new System.Windows.Forms.Label();
         this.label1 = new System.Windows.Forms.Label();
         this.info1Label = new System.Windows.Forms.Label();
         this.pictureBox1 = new System.Windows.Forms.PictureBox();
         this.label3 = new System.Windows.Forms.Label();
         this.stageTextBox = new System.Windows.Forms.TextBox();
         this.goBackButton = new System.Windows.Forms.Button();
         this.startOverButton = new System.Windows.Forms.Button();
         this.label4 = new System.Windows.Forms.Label();
         this.displayComboBox = new System.Windows.Forms.ComboBox();
         this.nextStageButton = new System.Windows.Forms.Button();
         this.label5 = new System.Windows.Forms.Label();
         this.buttonToPressTextBox = new System.Windows.Forms.TextBox();
         this.label6 = new System.Windows.Forms.Label();
         this.infoNeededTextBox = new System.Windows.Forms.TextBox();
         this.label7 = new System.Windows.Forms.Label();
         this.infoComboBox = new System.Windows.Forms.ComboBox();
         this.label8 = new System.Windows.Forms.Label();
         this.neededInfoGroupBox.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.SuspendLayout();
         // 
         // neededInfoGroupBox
         // 
         this.neededInfoGroupBox.Controls.Add(this.label2);
         this.neededInfoGroupBox.Controls.Add(this.label1);
         this.neededInfoGroupBox.Controls.Add(this.info1Label);
         this.neededInfoGroupBox.Location = new System.Drawing.Point(12, 12);
         this.neededInfoGroupBox.Name = "neededInfoGroupBox";
         this.neededInfoGroupBox.Size = new System.Drawing.Size(349, 98);
         this.neededInfoGroupBox.TabIndex = 2;
         this.neededInfoGroupBox.TabStop = false;
         this.neededInfoGroupBox.Text = "Instructions";
         // 
         // label2
         // 
         this.label2.AutoSize = true;
         this.label2.Location = new System.Drawing.Point(15, 73);
         this.label2.Name = "label2";
         this.label2.Size = new System.Drawing.Size(224, 13);
         this.label2.TabIndex = 2;
         this.label2.Text = "● Button positions are ordered from left to right";
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(15, 50);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(324, 13);
         this.label1.TabIndex = 1;
         this.label1.Text = "● Pressing an incorrect button will reset the module back to stage 1";
         // 
         // info1Label
         // 
         this.info1Label.AutoSize = true;
         this.info1Label.Location = new System.Drawing.Point(15, 28);
         this.info1Label.Name = "info1Label";
         this.info1Label.Size = new System.Drawing.Size(325, 13);
         this.info1Label.TabIndex = 0;
         this.info1Label.Text = "● Press the correct button to progress the module to the next stage.";
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::ktane_helper.Properties.Resources.memory_module;
         this.pictureBox1.Location = new System.Drawing.Point(464, 12);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(133, 133);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox1.TabIndex = 3;
         this.pictureBox1.TabStop = false;
         // 
         // label3
         // 
         this.label3.AutoSize = true;
         this.label3.Location = new System.Drawing.Point(27, 141);
         this.label3.Name = "label3";
         this.label3.Size = new System.Drawing.Size(38, 13);
         this.label3.TabIndex = 4;
         this.label3.Text = "Stage:";
         // 
         // stageTextBox
         // 
         this.stageTextBox.Location = new System.Drawing.Point(71, 138);
         this.stageTextBox.Name = "stageTextBox";
         this.stageTextBox.ReadOnly = true;
         this.stageTextBox.Size = new System.Drawing.Size(35, 20);
         this.stageTextBox.TabIndex = 5;
         this.stageTextBox.TabStop = false;
         this.stageTextBox.Text = "1";
         this.stageTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // goBackButton
         // 
         this.goBackButton.Enabled = false;
         this.goBackButton.Location = new System.Drawing.Point(122, 136);
         this.goBackButton.Name = "goBackButton";
         this.goBackButton.Size = new System.Drawing.Size(75, 23);
         this.goBackButton.TabIndex = 4;
         this.goBackButton.Text = "Go back";
         this.goBackButton.UseVisualStyleBackColor = true;
         this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
         // 
         // startOverButton
         // 
         this.startOverButton.Location = new System.Drawing.Point(203, 135);
         this.startOverButton.Name = "startOverButton";
         this.startOverButton.Size = new System.Drawing.Size(75, 23);
         this.startOverButton.TabIndex = 7;
         this.startOverButton.Text = "Start over";
         this.startOverButton.UseVisualStyleBackColor = true;
         this.startOverButton.Click += new System.EventHandler(this.startOverButton_Click);
         // 
         // label4
         // 
         this.label4.AutoSize = true;
         this.label4.Location = new System.Drawing.Point(27, 177);
         this.label4.Name = "label4";
         this.label4.Size = new System.Drawing.Size(114, 13);
         this.label4.TabIndex = 8;
         this.label4.Text = "What is on the display:";
         // 
         // displayComboBox
         // 
         this.displayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.displayComboBox.FormattingEnabled = true;
         this.displayComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
         this.displayComboBox.Location = new System.Drawing.Point(58, 193);
         this.displayComboBox.Name = "displayComboBox";
         this.displayComboBox.Size = new System.Drawing.Size(48, 21);
         this.displayComboBox.TabIndex = 1;
         this.displayComboBox.SelectedIndexChanged += new System.EventHandler(this.displayComboBox_SelectedIndexChanged);
         // 
         // nextStageButton
         // 
         this.nextStageButton.Enabled = false;
         this.nextStageButton.Location = new System.Drawing.Point(30, 337);
         this.nextStageButton.Name = "nextStageButton";
         this.nextStageButton.Size = new System.Drawing.Size(75, 23);
         this.nextStageButton.TabIndex = 3;
         this.nextStageButton.Text = "Next stage";
         this.nextStageButton.UseVisualStyleBackColor = true;
         this.nextStageButton.Click += new System.EventHandler(this.nextStageButton_Click);
         // 
         // label5
         // 
         this.label5.AutoSize = true;
         this.label5.Location = new System.Drawing.Point(27, 242);
         this.label5.Name = "label5";
         this.label5.Size = new System.Drawing.Size(81, 13);
         this.label5.TabIndex = 11;
         this.label5.Text = "Button to press:";
         // 
         // buttonToPressTextBox
         // 
         this.buttonToPressTextBox.Location = new System.Drawing.Point(114, 239);
         this.buttonToPressTextBox.Name = "buttonToPressTextBox";
         this.buttonToPressTextBox.ReadOnly = true;
         this.buttonToPressTextBox.Size = new System.Drawing.Size(195, 20);
         this.buttonToPressTextBox.TabIndex = 12;
         this.buttonToPressTextBox.TabStop = false;
         // 
         // label6
         // 
         this.label6.AutoSize = true;
         this.label6.Location = new System.Drawing.Point(27, 278);
         this.label6.Name = "label6";
         this.label6.Size = new System.Drawing.Size(98, 13);
         this.label6.TabIndex = 13;
         this.label6.Text = "Information needed";
         // 
         // infoNeededTextBox
         // 
         this.infoNeededTextBox.Location = new System.Drawing.Point(136, 284);
         this.infoNeededTextBox.Name = "infoNeededTextBox";
         this.infoNeededTextBox.ReadOnly = true;
         this.infoNeededTextBox.Size = new System.Drawing.Size(175, 20);
         this.infoNeededTextBox.TabIndex = 14;
         this.infoNeededTextBox.TabStop = false;
         // 
         // label7
         // 
         this.label7.AutoSize = true;
         this.label7.Location = new System.Drawing.Point(348, 287);
         this.label7.Name = "label7";
         this.label7.Size = new System.Drawing.Size(106, 13);
         this.label7.TabIndex = 15;
         this.label7.Text = "Information provided:";
         // 
         // infoComboBox
         // 
         this.infoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.infoComboBox.Enabled = false;
         this.infoComboBox.FormattingEnabled = true;
         this.infoComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
         this.infoComboBox.Location = new System.Drawing.Point(460, 283);
         this.infoComboBox.Name = "infoComboBox";
         this.infoComboBox.Size = new System.Drawing.Size(48, 21);
         this.infoComboBox.TabIndex = 2;
         this.infoComboBox.SelectedIndexChanged += new System.EventHandler(this.infoComboBox_SelectedIndexChanged);
         // 
         // label8
         // 
         this.label8.AutoSize = true;
         this.label8.Location = new System.Drawing.Point(27, 291);
         this.label8.Name = "label8";
         this.label8.Size = new System.Drawing.Size(103, 13);
         this.label8.TabIndex = 17;
         this.label8.Text = "from button pressed:";
         // 
         // MemoryForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(609, 421);
         this.Controls.Add(this.label8);
         this.Controls.Add(this.infoComboBox);
         this.Controls.Add(this.label7);
         this.Controls.Add(this.infoNeededTextBox);
         this.Controls.Add(this.label6);
         this.Controls.Add(this.buttonToPressTextBox);
         this.Controls.Add(this.label5);
         this.Controls.Add(this.nextStageButton);
         this.Controls.Add(this.displayComboBox);
         this.Controls.Add(this.label4);
         this.Controls.Add(this.startOverButton);
         this.Controls.Add(this.goBackButton);
         this.Controls.Add(this.stageTextBox);
         this.Controls.Add(this.label3);
         this.Controls.Add(this.pictureBox1);
         this.Controls.Add(this.neededInfoGroupBox);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.Name = "MemoryForm";
         this.Text = "Memory";
         this.neededInfoGroupBox.ResumeLayout(false);
         this.neededInfoGroupBox.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.GroupBox neededInfoGroupBox;
      private System.Windows.Forms.Label label2;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Label info1Label;
      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Label label3;
      private System.Windows.Forms.TextBox stageTextBox;
      private System.Windows.Forms.Button goBackButton;
      private System.Windows.Forms.Button startOverButton;
      private System.Windows.Forms.Label label4;
      private System.Windows.Forms.ComboBox displayComboBox;
      private System.Windows.Forms.Button nextStageButton;
      private System.Windows.Forms.Label label5;
      private System.Windows.Forms.TextBox buttonToPressTextBox;
      private System.Windows.Forms.Label label6;
      private System.Windows.Forms.TextBox infoNeededTextBox;
      private System.Windows.Forms.Label label7;
      private System.Windows.Forms.ComboBox infoComboBox;
      private System.Windows.Forms.Label label8;
   }
}