namespace ktane_helper
{
   partial class PasswordForm
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
         this.label1 = new System.Windows.Forms.Label();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.firstTextBox = new System.Windows.Forms.TextBox();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.richTextBox1 = new System.Windows.Forms.RichTextBox();
         this.groupBox3 = new System.Windows.Forms.GroupBox();
         this.secondTextBox = new System.Windows.Forms.TextBox();
         this.groupBox4 = new System.Windows.Forms.GroupBox();
         this.thirdTextBox = new System.Windows.Forms.TextBox();
         this.groupBox5 = new System.Windows.Forms.GroupBox();
         this.fourthTextBox = new System.Windows.Forms.TextBox();
         this.groupBox6 = new System.Windows.Forms.GroupBox();
         this.fifthTextBox = new System.Windows.Forms.TextBox();
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
         this.groupBox1.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.groupBox3.SuspendLayout();
         this.groupBox4.SuspendLayout();
         this.groupBox5.SuspendLayout();
         this.groupBox6.SuspendLayout();
         this.SuspendLayout();
         // 
         // pictureBox1
         // 
         this.pictureBox1.Image = global::ktane_helper.Properties.Resources.password_module;
         this.pictureBox1.Location = new System.Drawing.Point(490, 12);
         this.pictureBox1.Name = "pictureBox1";
         this.pictureBox1.Size = new System.Drawing.Size(133, 133);
         this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.pictureBox1.TabIndex = 0;
         this.pictureBox1.TabStop = false;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(24, 32);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(244, 13);
         this.label1.TabIndex = 1;
         this.label1.Text = "Type all of the letters into the corresponding boxes";
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.firstTextBox);
         this.groupBox1.Location = new System.Drawing.Point(27, 172);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(115, 50);
         this.groupBox1.TabIndex = 2;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "First letters";
         // 
         // firstTextBox
         // 
         this.firstTextBox.Location = new System.Drawing.Point(6, 19);
         this.firstTextBox.Name = "firstTextBox";
         this.firstTextBox.Size = new System.Drawing.Size(100, 20);
         this.firstTextBox.TabIndex = 0;
         this.firstTextBox.TextChanged += new System.EventHandler(this.firstTextBox_TextChanged);
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.richTextBox1);
         this.groupBox2.Location = new System.Drawing.Point(27, 249);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(449, 107);
         this.groupBox2.TabIndex = 0;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Possible solutions";
         // 
         // richTextBox1
         // 
         this.richTextBox1.Location = new System.Drawing.Point(15, 19);
         this.richTextBox1.Name = "richTextBox1";
         this.richTextBox1.ReadOnly = true;
         this.richTextBox1.Size = new System.Drawing.Size(428, 82);
         this.richTextBox1.TabIndex = 0;
         this.richTextBox1.TabStop = false;
         this.richTextBox1.Text = "";
         // 
         // groupBox3
         // 
         this.groupBox3.Controls.Add(this.secondTextBox);
         this.groupBox3.Location = new System.Drawing.Point(148, 172);
         this.groupBox3.Name = "groupBox3";
         this.groupBox3.Size = new System.Drawing.Size(115, 50);
         this.groupBox3.TabIndex = 3;
         this.groupBox3.TabStop = false;
         this.groupBox3.Text = "Second letters";
         // 
         // secondTextBox
         // 
         this.secondTextBox.Location = new System.Drawing.Point(6, 19);
         this.secondTextBox.Name = "secondTextBox";
         this.secondTextBox.Size = new System.Drawing.Size(100, 20);
         this.secondTextBox.TabIndex = 0;
         this.secondTextBox.TextChanged += new System.EventHandler(this.secondTextBox_TextChanged);
         // 
         // groupBox4
         // 
         this.groupBox4.Controls.Add(this.thirdTextBox);
         this.groupBox4.Location = new System.Drawing.Point(269, 172);
         this.groupBox4.Name = "groupBox4";
         this.groupBox4.Size = new System.Drawing.Size(115, 50);
         this.groupBox4.TabIndex = 4;
         this.groupBox4.TabStop = false;
         this.groupBox4.Text = "Third letters";
         // 
         // thirdTextBox
         // 
         this.thirdTextBox.Location = new System.Drawing.Point(6, 19);
         this.thirdTextBox.Name = "thirdTextBox";
         this.thirdTextBox.Size = new System.Drawing.Size(100, 20);
         this.thirdTextBox.TabIndex = 0;
         this.thirdTextBox.TextChanged += new System.EventHandler(this.thirdTextBox_TextChanged);
         // 
         // groupBox5
         // 
         this.groupBox5.Controls.Add(this.fourthTextBox);
         this.groupBox5.Location = new System.Drawing.Point(390, 172);
         this.groupBox5.Name = "groupBox5";
         this.groupBox5.Size = new System.Drawing.Size(115, 50);
         this.groupBox5.TabIndex = 5;
         this.groupBox5.TabStop = false;
         this.groupBox5.Text = "Fourth letters";
         // 
         // fourthTextBox
         // 
         this.fourthTextBox.Location = new System.Drawing.Point(6, 19);
         this.fourthTextBox.Name = "fourthTextBox";
         this.fourthTextBox.Size = new System.Drawing.Size(100, 20);
         this.fourthTextBox.TabIndex = 0;
         this.fourthTextBox.TextChanged += new System.EventHandler(this.fourthTextBox_TextChanged);
         // 
         // groupBox6
         // 
         this.groupBox6.Controls.Add(this.fifthTextBox);
         this.groupBox6.Location = new System.Drawing.Point(511, 172);
         this.groupBox6.Name = "groupBox6";
         this.groupBox6.Size = new System.Drawing.Size(115, 50);
         this.groupBox6.TabIndex = 6;
         this.groupBox6.TabStop = false;
         this.groupBox6.Text = "Fifth letters";
         // 
         // fifthTextBox
         // 
         this.fifthTextBox.Location = new System.Drawing.Point(6, 19);
         this.fifthTextBox.Name = "fifthTextBox";
         this.fifthTextBox.Size = new System.Drawing.Size(100, 20);
         this.fifthTextBox.TabIndex = 0;
         this.fifthTextBox.TextChanged += new System.EventHandler(this.fifthTextBox_TextChanged);
         // 
         // PasswordForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(635, 383);
         this.Controls.Add(this.groupBox6);
         this.Controls.Add(this.groupBox5);
         this.Controls.Add(this.groupBox4);
         this.Controls.Add(this.groupBox3);
         this.Controls.Add(this.groupBox2);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.label1);
         this.Controls.Add(this.pictureBox1);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
         this.MaximizeBox = false;
         this.Name = "PasswordForm";
         this.Text = "Passwords";
         ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.groupBox2.ResumeLayout(false);
         this.groupBox3.ResumeLayout(false);
         this.groupBox3.PerformLayout();
         this.groupBox4.ResumeLayout(false);
         this.groupBox4.PerformLayout();
         this.groupBox5.ResumeLayout(false);
         this.groupBox5.PerformLayout();
         this.groupBox6.ResumeLayout(false);
         this.groupBox6.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.PictureBox pictureBox1;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.TextBox firstTextBox;
      private System.Windows.Forms.GroupBox groupBox2;
      private System.Windows.Forms.RichTextBox richTextBox1;
      private System.Windows.Forms.GroupBox groupBox3;
      private System.Windows.Forms.TextBox secondTextBox;
      private System.Windows.Forms.GroupBox groupBox4;
      private System.Windows.Forms.TextBox thirdTextBox;
      private System.Windows.Forms.GroupBox groupBox5;
      private System.Windows.Forms.TextBox fourthTextBox;
      private System.Windows.Forms.GroupBox groupBox6;
      private System.Windows.Forms.TextBox fifthTextBox;
   }
}