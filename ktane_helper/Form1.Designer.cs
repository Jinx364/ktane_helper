namespace ktane_helper
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
         this.verificationLabel = new System.Windows.Forms.Label();
         this.versionGroupBox = new System.Windows.Forms.GroupBox();
         this.infoGroupBox = new System.Windows.Forms.GroupBox();
         this.addStrikeButton = new System.Windows.Forms.Button();
         this.removeStrikeButton = new System.Windows.Forms.Button();
         this.numStrikesTextBox = new System.Windows.Forms.TextBox();
         this.resetInfoButton = new System.Windows.Forms.Button();
         this.indicatorGroupBox = new System.Windows.Forms.GroupBox();
         this.frkCheckBox = new System.Windows.Forms.CheckBox();
         this.carCheckBox = new System.Windows.Forms.CheckBox();
         this.parallelPictureBox = new System.Windows.Forms.PictureBox();
         this.parallelComboBox = new System.Windows.Forms.ComboBox();
         this.parallelLabel = new System.Windows.Forms.Label();
         this.serialVowelComboBox = new System.Windows.Forms.ComboBox();
         this.serialVowelLabel = new System.Windows.Forms.Label();
         this.numBatteriesComboBox = new System.Windows.Forms.ComboBox();
         this.numBatteriesLabel = new System.Windows.Forms.Label();
         this.serialOddEvenComboBox = new System.Windows.Forms.ComboBox();
         this.serialIsOddlabel = new System.Windows.Forms.Label();
         this.numStrikesLabel = new System.Windows.Forms.Label();
         this.moduleGroupBox = new System.Windows.Forms.GroupBox();
         this.passwordButton = new System.Windows.Forms.Button();
         this.mazeButton = new System.Windows.Forms.Button();
         this.wireSeqButton = new System.Windows.Forms.Button();
         this.complicatedWiresButton = new System.Windows.Forms.Button();
         this.morseButton = new System.Windows.Forms.Button();
         this.memoryButton = new System.Windows.Forms.Button();
         this.whoOnFirstButton = new System.Windows.Forms.Button();
         this.simonSaysButton = new System.Windows.Forms.Button();
         this.keypadsButton = new System.Windows.Forms.Button();
         this.buttonButton = new System.Windows.Forms.Button();
         this.wiresButton = new System.Windows.Forms.Button();
         this.needyGroupBox = new System.Windows.Forms.GroupBox();
         this.knobButton = new System.Windows.Forms.Button();
         this.bombTimer = new System.Windows.Forms.Timer(this.components);
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.timerForwardButton = new System.Windows.Forms.Button();
         this.timerBackButton = new System.Windows.Forms.Button();
         this.timerResetButton = new System.Windows.Forms.Button();
         this.timerStartButton = new System.Windows.Forms.Button();
         this.setTimeTextBox = new System.Windows.Forms.TextBox();
         this.label1 = new System.Windows.Forms.Label();
         this.timerTextBox = new System.Windows.Forms.TextBox();
         this.versionGroupBox.SuspendLayout();
         this.infoGroupBox.SuspendLayout();
         this.indicatorGroupBox.SuspendLayout();
         ((System.ComponentModel.ISupportInitialize)(this.parallelPictureBox)).BeginInit();
         this.moduleGroupBox.SuspendLayout();
         this.needyGroupBox.SuspendLayout();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // verificationLabel
         // 
         this.verificationLabel.AutoSize = true;
         this.verificationLabel.Location = new System.Drawing.Point(6, 16);
         this.verificationLabel.Name = "verificationLabel";
         this.verificationLabel.Size = new System.Drawing.Size(111, 13);
         this.verificationLabel.TabIndex = 0;
         this.verificationLabel.Text = "Verification Code: 241";
         // 
         // versionGroupBox
         // 
         this.versionGroupBox.Controls.Add(this.verificationLabel);
         this.versionGroupBox.Location = new System.Drawing.Point(449, 462);
         this.versionGroupBox.Name = "versionGroupBox";
         this.versionGroupBox.Size = new System.Drawing.Size(131, 38);
         this.versionGroupBox.TabIndex = 1;
         this.versionGroupBox.TabStop = false;
         this.versionGroupBox.Text = "For use with Version 1";
         // 
         // infoGroupBox
         // 
         this.infoGroupBox.Controls.Add(this.addStrikeButton);
         this.infoGroupBox.Controls.Add(this.removeStrikeButton);
         this.infoGroupBox.Controls.Add(this.numStrikesTextBox);
         this.infoGroupBox.Controls.Add(this.resetInfoButton);
         this.infoGroupBox.Controls.Add(this.indicatorGroupBox);
         this.infoGroupBox.Controls.Add(this.parallelPictureBox);
         this.infoGroupBox.Controls.Add(this.parallelComboBox);
         this.infoGroupBox.Controls.Add(this.parallelLabel);
         this.infoGroupBox.Controls.Add(this.serialVowelComboBox);
         this.infoGroupBox.Controls.Add(this.serialVowelLabel);
         this.infoGroupBox.Controls.Add(this.numBatteriesComboBox);
         this.infoGroupBox.Controls.Add(this.numBatteriesLabel);
         this.infoGroupBox.Controls.Add(this.serialOddEvenComboBox);
         this.infoGroupBox.Controls.Add(this.serialIsOddlabel);
         this.infoGroupBox.Controls.Add(this.numStrikesLabel);
         this.infoGroupBox.Location = new System.Drawing.Point(12, 12);
         this.infoGroupBox.Name = "infoGroupBox";
         this.infoGroupBox.Size = new System.Drawing.Size(569, 146);
         this.infoGroupBox.TabIndex = 2;
         this.infoGroupBox.TabStop = false;
         this.infoGroupBox.Text = "Information about the bomb";
         // 
         // addStrikeButton
         // 
         this.addStrikeButton.Location = new System.Drawing.Point(89, 43);
         this.addStrikeButton.Name = "addStrikeButton";
         this.addStrikeButton.Size = new System.Drawing.Size(30, 23);
         this.addStrikeButton.TabIndex = 14;
         this.addStrikeButton.Text = "+";
         this.addStrikeButton.UseVisualStyleBackColor = true;
         this.addStrikeButton.Click += new System.EventHandler(this.addStrikeButton_Click);
         // 
         // removeStrikeButton
         // 
         this.removeStrikeButton.Location = new System.Drawing.Point(9, 43);
         this.removeStrikeButton.Name = "removeStrikeButton";
         this.removeStrikeButton.Size = new System.Drawing.Size(30, 23);
         this.removeStrikeButton.TabIndex = 10;
         this.removeStrikeButton.Text = "-";
         this.removeStrikeButton.UseVisualStyleBackColor = true;
         this.removeStrikeButton.Click += new System.EventHandler(this.removeStrikeButton_Click);
         // 
         // numStrikesTextBox
         // 
         this.numStrikesTextBox.Location = new System.Drawing.Point(45, 44);
         this.numStrikesTextBox.Name = "numStrikesTextBox";
         this.numStrikesTextBox.ReadOnly = true;
         this.numStrikesTextBox.Size = new System.Drawing.Size(38, 20);
         this.numStrikesTextBox.TabIndex = 13;
         this.numStrikesTextBox.TabStop = false;
         this.numStrikesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // resetInfoButton
         // 
         this.resetInfoButton.Location = new System.Drawing.Point(479, 117);
         this.resetInfoButton.Name = "resetInfoButton";
         this.resetInfoButton.Size = new System.Drawing.Size(75, 23);
         this.resetInfoButton.TabIndex = 12;
         this.resetInfoButton.Text = "Reset Info";
         this.resetInfoButton.UseVisualStyleBackColor = true;
         this.resetInfoButton.Click += new System.EventHandler(this.resetInfoButton_Click);
         // 
         // indicatorGroupBox
         // 
         this.indicatorGroupBox.Controls.Add(this.frkCheckBox);
         this.indicatorGroupBox.Controls.Add(this.carCheckBox);
         this.indicatorGroupBox.Location = new System.Drawing.Point(470, 19);
         this.indicatorGroupBox.Name = "indicatorGroupBox";
         this.indicatorGroupBox.Size = new System.Drawing.Size(89, 79);
         this.indicatorGroupBox.TabIndex = 11;
         this.indicatorGroupBox.TabStop = false;
         this.indicatorGroupBox.Text = "Lit Indicators";
         // 
         // frkCheckBox
         // 
         this.frkCheckBox.AutoSize = true;
         this.frkCheckBox.Checked = true;
         this.frkCheckBox.CheckState = System.Windows.Forms.CheckState.Indeterminate;
         this.frkCheckBox.Location = new System.Drawing.Point(6, 49);
         this.frkCheckBox.Name = "frkCheckBox";
         this.frkCheckBox.Size = new System.Drawing.Size(47, 17);
         this.frkCheckBox.TabIndex = 1;
         this.frkCheckBox.Text = "FRK";
         this.frkCheckBox.UseVisualStyleBackColor = true;
         this.frkCheckBox.CheckedChanged += new System.EventHandler(this.frkCheckBox_CheckedChanged);
         this.frkCheckBox.Paint += new System.Windows.Forms.PaintEventHandler(this.frkCheckBox_Paint);
         // 
         // carCheckBox
         // 
         this.carCheckBox.AutoSize = true;
         this.carCheckBox.Checked = true;
         this.carCheckBox.CheckState = System.Windows.Forms.CheckState.Indeterminate;
         this.carCheckBox.Location = new System.Drawing.Point(6, 24);
         this.carCheckBox.Name = "carCheckBox";
         this.carCheckBox.Size = new System.Drawing.Size(48, 17);
         this.carCheckBox.TabIndex = 0;
         this.carCheckBox.Text = "CAR";
         this.carCheckBox.UseVisualStyleBackColor = true;
         this.carCheckBox.CheckedChanged += new System.EventHandler(this.carCheckBox_CheckedChanged);
         this.carCheckBox.Paint += new System.Windows.Forms.PaintEventHandler(this.carCheckBox_Paint);
         // 
         // parallelPictureBox
         // 
         this.parallelPictureBox.Image = global::ktane_helper.Properties.Resources.parallel_port;
         this.parallelPictureBox.Location = new System.Drawing.Point(283, 68);
         this.parallelPictureBox.Name = "parallelPictureBox";
         this.parallelPictureBox.Size = new System.Drawing.Size(156, 39);
         this.parallelPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
         this.parallelPictureBox.TabIndex = 10;
         this.parallelPictureBox.TabStop = false;
         // 
         // parallelComboBox
         // 
         this.parallelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.parallelComboBox.FormattingEnabled = true;
         this.parallelComboBox.Items.AddRange(new object[] {
            "No",
            "Yes"});
         this.parallelComboBox.Location = new System.Drawing.Point(283, 41);
         this.parallelComboBox.Name = "parallelComboBox";
         this.parallelComboBox.Size = new System.Drawing.Size(121, 21);
         this.parallelComboBox.TabIndex = 9;
         this.parallelComboBox.SelectedIndexChanged += new System.EventHandler(this.parallelComboBox_SelectedIndexChanged);
         // 
         // parallelLabel
         // 
         this.parallelLabel.AutoSize = true;
         this.parallelLabel.Location = new System.Drawing.Point(286, 25);
         this.parallelLabel.Name = "parallelLabel";
         this.parallelLabel.Size = new System.Drawing.Size(89, 13);
         this.parallelLabel.TabIndex = 8;
         this.parallelLabel.Text = "Has parallel port?";
         // 
         // serialVowelComboBox
         // 
         this.serialVowelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.serialVowelComboBox.FormattingEnabled = true;
         this.serialVowelComboBox.Items.AddRange(new object[] {
            "No",
            "Yes"});
         this.serialVowelComboBox.Location = new System.Drawing.Point(144, 101);
         this.serialVowelComboBox.Name = "serialVowelComboBox";
         this.serialVowelComboBox.Size = new System.Drawing.Size(121, 21);
         this.serialVowelComboBox.TabIndex = 7;
         this.serialVowelComboBox.SelectedIndexChanged += new System.EventHandler(this.serialVowelComboBox_SelectedIndexChanged);
         // 
         // serialVowelLabel
         // 
         this.serialVowelLabel.AutoSize = true;
         this.serialVowelLabel.Location = new System.Drawing.Point(141, 85);
         this.serialVowelLabel.Name = "serialVowelLabel";
         this.serialVowelLabel.Size = new System.Drawing.Size(119, 13);
         this.serialVowelLabel.TabIndex = 6;
         this.serialVowelLabel.Text = "Serial contains a vowel:";
         // 
         // numBatteriesComboBox
         // 
         this.numBatteriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.numBatteriesComboBox.FormattingEnabled = true;
         this.numBatteriesComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3 or more"});
         this.numBatteriesComboBox.Location = new System.Drawing.Point(144, 41);
         this.numBatteriesComboBox.Name = "numBatteriesComboBox";
         this.numBatteriesComboBox.Size = new System.Drawing.Size(121, 21);
         this.numBatteriesComboBox.TabIndex = 5;
         this.numBatteriesComboBox.SelectedIndexChanged += new System.EventHandler(this.numBatteriesComboBox_SelectedIndexChanged);
         // 
         // numBatteriesLabel
         // 
         this.numBatteriesLabel.AutoSize = true;
         this.numBatteriesLabel.Location = new System.Drawing.Point(141, 25);
         this.numBatteriesLabel.Name = "numBatteriesLabel";
         this.numBatteriesLabel.Size = new System.Drawing.Size(102, 13);
         this.numBatteriesLabel.TabIndex = 4;
         this.numBatteriesLabel.Text = "Number of batteries:";
         // 
         // serialOddEvenComboBox
         // 
         this.serialOddEvenComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
         this.serialOddEvenComboBox.FormattingEnabled = true;
         this.serialOddEvenComboBox.Items.AddRange(new object[] {
            "Odd",
            "Even"});
         this.serialOddEvenComboBox.Location = new System.Drawing.Point(9, 101);
         this.serialOddEvenComboBox.Name = "serialOddEvenComboBox";
         this.serialOddEvenComboBox.Size = new System.Drawing.Size(121, 21);
         this.serialOddEvenComboBox.TabIndex = 3;
         this.serialOddEvenComboBox.SelectedIndexChanged += new System.EventHandler(this.serialOddEvenComboBox_SelectedIndexChanged);
         // 
         // serialIsOddlabel
         // 
         this.serialIsOddlabel.AutoSize = true;
         this.serialIsOddlabel.Location = new System.Drawing.Point(6, 85);
         this.serialIsOddlabel.Name = "serialIsOddlabel";
         this.serialIsOddlabel.Size = new System.Drawing.Size(101, 13);
         this.serialIsOddlabel.TabIndex = 2;
         this.serialIsOddlabel.Text = "Last digit of serial is:";
         // 
         // numStrikesLabel
         // 
         this.numStrikesLabel.AutoSize = true;
         this.numStrikesLabel.Location = new System.Drawing.Point(13, 25);
         this.numStrikesLabel.Name = "numStrikesLabel";
         this.numStrikesLabel.Size = new System.Drawing.Size(64, 13);
         this.numStrikesLabel.TabIndex = 1;
         this.numStrikesLabel.Text = "# of Strikes:";
         // 
         // moduleGroupBox
         // 
         this.moduleGroupBox.Controls.Add(this.passwordButton);
         this.moduleGroupBox.Controls.Add(this.mazeButton);
         this.moduleGroupBox.Controls.Add(this.wireSeqButton);
         this.moduleGroupBox.Controls.Add(this.complicatedWiresButton);
         this.moduleGroupBox.Controls.Add(this.morseButton);
         this.moduleGroupBox.Controls.Add(this.memoryButton);
         this.moduleGroupBox.Controls.Add(this.whoOnFirstButton);
         this.moduleGroupBox.Controls.Add(this.simonSaysButton);
         this.moduleGroupBox.Controls.Add(this.keypadsButton);
         this.moduleGroupBox.Controls.Add(this.buttonButton);
         this.moduleGroupBox.Controls.Add(this.wiresButton);
         this.moduleGroupBox.Location = new System.Drawing.Point(12, 179);
         this.moduleGroupBox.Name = "moduleGroupBox";
         this.moduleGroupBox.Size = new System.Drawing.Size(359, 157);
         this.moduleGroupBox.TabIndex = 3;
         this.moduleGroupBox.TabStop = false;
         this.moduleGroupBox.Text = "Modules";
         // 
         // passwordButton
         // 
         this.passwordButton.Location = new System.Drawing.Point(182, 105);
         this.passwordButton.Name = "passwordButton";
         this.passwordButton.Size = new System.Drawing.Size(77, 37);
         this.passwordButton.TabIndex = 10;
         this.passwordButton.Text = "Passwords";
         this.passwordButton.UseVisualStyleBackColor = true;
         this.passwordButton.Click += new System.EventHandler(this.passwordButton_Click);
         // 
         // mazeButton
         // 
         this.mazeButton.Location = new System.Drawing.Point(99, 105);
         this.mazeButton.Name = "mazeButton";
         this.mazeButton.Size = new System.Drawing.Size(77, 37);
         this.mazeButton.TabIndex = 9;
         this.mazeButton.Text = "Mazes";
         this.mazeButton.UseVisualStyleBackColor = true;
         this.mazeButton.Click += new System.EventHandler(this.mazeButton_Click);
         // 
         // wireSeqButton
         // 
         this.wireSeqButton.Location = new System.Drawing.Point(16, 105);
         this.wireSeqButton.Name = "wireSeqButton";
         this.wireSeqButton.Size = new System.Drawing.Size(77, 37);
         this.wireSeqButton.TabIndex = 8;
         this.wireSeqButton.Text = "Wire Sequences";
         this.wireSeqButton.UseVisualStyleBackColor = true;
         this.wireSeqButton.Click += new System.EventHandler(this.wireSeqButton_Click);
         // 
         // complicatedWiresButton
         // 
         this.complicatedWiresButton.Location = new System.Drawing.Point(265, 62);
         this.complicatedWiresButton.Name = "complicatedWiresButton";
         this.complicatedWiresButton.Size = new System.Drawing.Size(77, 37);
         this.complicatedWiresButton.TabIndex = 7;
         this.complicatedWiresButton.Text = "Complicated Wires";
         this.complicatedWiresButton.UseVisualStyleBackColor = true;
         this.complicatedWiresButton.Click += new System.EventHandler(this.complicatedWiresButton_Click);
         // 
         // morseButton
         // 
         this.morseButton.Location = new System.Drawing.Point(182, 62);
         this.morseButton.Name = "morseButton";
         this.morseButton.Size = new System.Drawing.Size(77, 37);
         this.morseButton.TabIndex = 6;
         this.morseButton.Text = "Morse Code";
         this.morseButton.UseVisualStyleBackColor = true;
         this.morseButton.Click += new System.EventHandler(this.morseButton_Click);
         // 
         // memoryButton
         // 
         this.memoryButton.Location = new System.Drawing.Point(99, 62);
         this.memoryButton.Name = "memoryButton";
         this.memoryButton.Size = new System.Drawing.Size(77, 37);
         this.memoryButton.TabIndex = 5;
         this.memoryButton.Text = "Memory";
         this.memoryButton.UseVisualStyleBackColor = true;
         this.memoryButton.Click += new System.EventHandler(this.memoryButton_Click);
         // 
         // whoOnFirstButton
         // 
         this.whoOnFirstButton.Location = new System.Drawing.Point(16, 62);
         this.whoOnFirstButton.Name = "whoOnFirstButton";
         this.whoOnFirstButton.Size = new System.Drawing.Size(77, 37);
         this.whoOnFirstButton.TabIndex = 4;
         this.whoOnFirstButton.Text = "Who\'s on First";
         this.whoOnFirstButton.UseVisualStyleBackColor = true;
         this.whoOnFirstButton.Click += new System.EventHandler(this.whoOnFirstButton_Click);
         // 
         // simonSaysButton
         // 
         this.simonSaysButton.Location = new System.Drawing.Point(265, 19);
         this.simonSaysButton.Name = "simonSaysButton";
         this.simonSaysButton.Size = new System.Drawing.Size(77, 37);
         this.simonSaysButton.TabIndex = 3;
         this.simonSaysButton.Text = "Simon Says";
         this.simonSaysButton.UseVisualStyleBackColor = true;
         this.simonSaysButton.Click += new System.EventHandler(this.simonSaysButton_Click);
         // 
         // keypadsButton
         // 
         this.keypadsButton.Location = new System.Drawing.Point(182, 19);
         this.keypadsButton.Name = "keypadsButton";
         this.keypadsButton.Size = new System.Drawing.Size(77, 37);
         this.keypadsButton.TabIndex = 2;
         this.keypadsButton.Text = "Keypads";
         this.keypadsButton.UseVisualStyleBackColor = true;
         this.keypadsButton.Click += new System.EventHandler(this.keypadsButton_Click);
         // 
         // buttonButton
         // 
         this.buttonButton.Location = new System.Drawing.Point(99, 19);
         this.buttonButton.Name = "buttonButton";
         this.buttonButton.Size = new System.Drawing.Size(77, 37);
         this.buttonButton.TabIndex = 1;
         this.buttonButton.Text = "The Button";
         this.buttonButton.UseVisualStyleBackColor = true;
         this.buttonButton.Click += new System.EventHandler(this.buttonButton_Click);
         // 
         // wiresButton
         // 
         this.wiresButton.Location = new System.Drawing.Point(16, 19);
         this.wiresButton.Name = "wiresButton";
         this.wiresButton.Size = new System.Drawing.Size(77, 37);
         this.wiresButton.TabIndex = 0;
         this.wiresButton.Text = "Wires";
         this.wiresButton.UseVisualStyleBackColor = true;
         this.wiresButton.Click += new System.EventHandler(this.wiresButton_Click);
         // 
         // needyGroupBox
         // 
         this.needyGroupBox.Controls.Add(this.knobButton);
         this.needyGroupBox.Location = new System.Drawing.Point(377, 179);
         this.needyGroupBox.Name = "needyGroupBox";
         this.needyGroupBox.Size = new System.Drawing.Size(107, 68);
         this.needyGroupBox.TabIndex = 4;
         this.needyGroupBox.TabStop = false;
         this.needyGroupBox.Text = "Needy Modules";
         // 
         // knobButton
         // 
         this.knobButton.Location = new System.Drawing.Point(16, 19);
         this.knobButton.Name = "knobButton";
         this.knobButton.Size = new System.Drawing.Size(77, 37);
         this.knobButton.TabIndex = 11;
         this.knobButton.Text = "Knobs";
         this.knobButton.UseVisualStyleBackColor = true;
         this.knobButton.Click += new System.EventHandler(this.knobButton_Click);
         // 
         // bombTimer
         // 
         this.bombTimer.Interval = 10;
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.timerForwardButton);
         this.groupBox1.Controls.Add(this.timerBackButton);
         this.groupBox1.Controls.Add(this.timerResetButton);
         this.groupBox1.Controls.Add(this.timerStartButton);
         this.groupBox1.Controls.Add(this.setTimeTextBox);
         this.groupBox1.Controls.Add(this.label1);
         this.groupBox1.Controls.Add(this.timerTextBox);
         this.groupBox1.Location = new System.Drawing.Point(12, 351);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(265, 139);
         this.groupBox1.TabIndex = 5;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Bomb timer";
         // 
         // timerForwardButton
         // 
         this.timerForwardButton.Location = new System.Drawing.Point(113, 101);
         this.timerForwardButton.Name = "timerForwardButton";
         this.timerForwardButton.Size = new System.Drawing.Size(30, 23);
         this.timerForwardButton.TabIndex = 9;
         this.timerForwardButton.Text = "→";
         this.timerForwardButton.UseVisualStyleBackColor = true;
         this.timerForwardButton.Click += new System.EventHandler(this.timerForwardButton_Click);
         // 
         // timerBackButton
         // 
         this.timerBackButton.Location = new System.Drawing.Point(8, 101);
         this.timerBackButton.Name = "timerBackButton";
         this.timerBackButton.Size = new System.Drawing.Size(30, 23);
         this.timerBackButton.TabIndex = 8;
         this.timerBackButton.Text = "←";
         this.timerBackButton.UseVisualStyleBackColor = true;
         this.timerBackButton.Click += new System.EventHandler(this.timerBackButton_Click);
         // 
         // timerResetButton
         // 
         this.timerResetButton.Location = new System.Drawing.Point(168, 103);
         this.timerResetButton.Name = "timerResetButton";
         this.timerResetButton.Size = new System.Drawing.Size(75, 23);
         this.timerResetButton.TabIndex = 7;
         this.timerResetButton.Text = "Reset";
         this.timerResetButton.UseVisualStyleBackColor = true;
         this.timerResetButton.Click += new System.EventHandler(this.timerResetButton_Click);
         // 
         // timerStartButton
         // 
         this.timerStartButton.Location = new System.Drawing.Point(168, 74);
         this.timerStartButton.Name = "timerStartButton";
         this.timerStartButton.Size = new System.Drawing.Size(75, 23);
         this.timerStartButton.TabIndex = 5;
         this.timerStartButton.Text = "Start";
         this.timerStartButton.UseVisualStyleBackColor = true;
         this.timerStartButton.Click += new System.EventHandler(this.timerStartButton_Click);
         // 
         // setTimeTextBox
         // 
         this.setTimeTextBox.Location = new System.Drawing.Point(44, 103);
         this.setTimeTextBox.Name = "setTimeTextBox";
         this.setTimeTextBox.ReadOnly = true;
         this.setTimeTextBox.Size = new System.Drawing.Size(63, 20);
         this.setTimeTextBox.TabIndex = 3;
         this.setTimeTextBox.Text = "5:00";
         this.setTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // label1
         // 
         this.label1.AutoSize = true;
         this.label1.Location = new System.Drawing.Point(6, 80);
         this.label1.Name = "label1";
         this.label1.Size = new System.Drawing.Size(48, 13);
         this.label1.TabIndex = 1;
         this.label1.Text = "Set time:";
         // 
         // timerTextBox
         // 
         this.timerTextBox.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.timerTextBox.Location = new System.Drawing.Point(85, 19);
         this.timerTextBox.Name = "timerTextBox";
         this.timerTextBox.ReadOnly = true;
         this.timerTextBox.Size = new System.Drawing.Size(100, 39);
         this.timerTextBox.TabIndex = 0;
         this.timerTextBox.TabStop = false;
         this.timerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
         // 
         // Form1
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(592, 512);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.needyGroupBox);
         this.Controls.Add(this.moduleGroupBox);
         this.Controls.Add(this.infoGroupBox);
         this.Controls.Add(this.versionGroupBox);
         this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
         this.MaximizeBox = false;
         this.Name = "Form1";
         this.Text = "Keep Talking and Nobody Explodes Helper";
         this.versionGroupBox.ResumeLayout(false);
         this.versionGroupBox.PerformLayout();
         this.infoGroupBox.ResumeLayout(false);
         this.infoGroupBox.PerformLayout();
         this.indicatorGroupBox.ResumeLayout(false);
         this.indicatorGroupBox.PerformLayout();
         ((System.ComponentModel.ISupportInitialize)(this.parallelPictureBox)).EndInit();
         this.moduleGroupBox.ResumeLayout(false);
         this.needyGroupBox.ResumeLayout(false);
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Label verificationLabel;
      private System.Windows.Forms.GroupBox versionGroupBox;
      private System.Windows.Forms.GroupBox infoGroupBox;
      private System.Windows.Forms.GroupBox moduleGroupBox;
      private System.Windows.Forms.GroupBox needyGroupBox;
      private System.Windows.Forms.Label numStrikesLabel;
      private System.Windows.Forms.Button wiresButton;
      private System.Windows.Forms.Button simonSaysButton;
      private System.Windows.Forms.Button keypadsButton;
      private System.Windows.Forms.Button buttonButton;
      private System.Windows.Forms.Button whoOnFirstButton;
      private System.Windows.Forms.Button morseButton;
      private System.Windows.Forms.Button memoryButton;
      private System.Windows.Forms.Button complicatedWiresButton;
      private System.Windows.Forms.Button wireSeqButton;
      private System.Windows.Forms.Button passwordButton;
      private System.Windows.Forms.Button mazeButton;
      private System.Windows.Forms.Button knobButton;
      private System.Windows.Forms.Label serialIsOddlabel;
      private System.Windows.Forms.ComboBox serialOddEvenComboBox;
      private System.Windows.Forms.ComboBox numBatteriesComboBox;
      private System.Windows.Forms.Label numBatteriesLabel;
      private System.Windows.Forms.Label serialVowelLabel;
      private System.Windows.Forms.ComboBox serialVowelComboBox;
      private System.Windows.Forms.ComboBox parallelComboBox;
      private System.Windows.Forms.Label parallelLabel;
      private System.Windows.Forms.PictureBox parallelPictureBox;
      private System.Windows.Forms.GroupBox indicatorGroupBox;
      private System.Windows.Forms.CheckBox frkCheckBox;
      private System.Windows.Forms.CheckBox carCheckBox;
      private System.Windows.Forms.Button resetInfoButton;
      private System.Windows.Forms.Timer bombTimer;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.TextBox timerTextBox;
      private System.Windows.Forms.TextBox setTimeTextBox;
      private System.Windows.Forms.Label label1;
      private System.Windows.Forms.Button timerResetButton;
      private System.Windows.Forms.Button timerStartButton;
      private System.Windows.Forms.Button timerBackButton;
      private System.Windows.Forms.Button timerForwardButton;
      private System.Windows.Forms.TextBox numStrikesTextBox;
      private System.Windows.Forms.Button addStrikeButton;
      private System.Windows.Forms.Button removeStrikeButton;
   }
}

