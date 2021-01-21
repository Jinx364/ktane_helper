using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace ktane_helper
{
   public partial class Form1 : Form
   {
      public delegate void BombInfoMessage(object obj, EventArgs e);
      public event BombInfoMessage OnBombInfoMessage;
      private static BombInfo bombInfo;

      private static Stopwatch stopWatch;
      bool timerIsRunning;
      private int timerMinutes;
      private int timerSeconds;
      private static TimeSpan bombTimeLeft;
      private static TimeSpan lastStopwatchElapsed;

      // Strike combobox indicies
      private const int ZERO_STRIKES = 0;
      private const int ONE_STRIKE = 1;
      private const int TWO_STRIKES = 2;

      // Number of batteries combobox indicies
      private const int ZERO_BATTERIES = 0;
      private const int ONE_BATTERY = 1;
      private const int TWO_BATTERIES = 2;
      private const int THREE_OR_MORE_BATTERIES = 3;

      // Parallel port combobox indicies
      private const int NO_PARALLEL_PORT = 0;
      private const int YES_PARALLEL_PORT = 1;

      // Last serial digit is odd combobox indicies
      private const int LAST_SERIAL_ODD = 0;
      private const int LAST_SERIAL_EVEN = 1;

      // Serial contains vowel combobox indicies
      private const int SERIAL_HAS_NO_VOWELS = 0;
      private const int SERIAL_HAS_VOWELS = 1;

      private static readonly TimeSpan tickTime = new TimeSpan(0, 0, 0, 0, 10);
      private static readonly TimeSpan oneMinute = new TimeSpan(0, 1, 0);
      private static readonly TimeSpan redTimespan = new TimeSpan(0, 1, 0);
      private const float zeroStrikePenalty = 1F;
      private const float oneStrikePenalty = 1.25F;
      private const float twoStrikePenalty = 1.5F;

      private static readonly Color controlColor = Color.FromArgb(240, 240, 240);
      private static readonly Color indeterminateColor = Color.Gray;

      public Form1()
      {
         InitializeComponent();
         InitializeBomb();
      }

      private void InitializeBomb()
      {
         bombInfo = new BombInfo();
         bombTimeLeft = new TimeSpan();
         lastStopwatchElapsed = new TimeSpan();
         stopWatch = new Stopwatch();
         removeStrikeButton.Enabled = false;
         serialOddEvenComboBox.SelectedIndex = -1;
         numBatteriesComboBox.SelectedIndex = -1;
         serialVowelComboBox.SelectedIndex = -1;
         parallelComboBox.SelectedIndex = -1;
         timerIsRunning = false;
         timerMinutes = 5;
         timerSeconds = 0;
         timerTextBox.Text = "05:00";
         bombTimer.Tick += OnTick;
      }

      private void wiresButton_Click(object sender, EventArgs e)
      {
         var wireForm = new WiresForm(bombInfo);
         OnBombInfoMessage += wireForm.BombInfoUpdate;
         wireForm.Show(this);
      }

      private void buttonButton_Click(object sender, EventArgs e)
      {
         var buttonForm = new ButtonForm(bombInfo);
         OnBombInfoMessage += buttonForm.BombInfoUpdate;
         buttonForm.Show(this);
      }

      private void keypadsButton_Click(object sender, EventArgs e)
      {
         var keypadForm = new KeypadForm();
         keypadForm.Show(this);
      }

      private void simonSaysButton_Click(object sender, EventArgs e)
      {
         var simonSaysForm = new SimonSaysForm(bombInfo);
         OnBombInfoMessage += simonSaysForm.BombInfoUpdate;
         simonSaysForm.Show(this);
      }

      private void whoOnFirstButton_Click(object sender, EventArgs e)
      {
         var whoOnFirstForm = new WhosOnFirstForm();
         whoOnFirstForm.Show(this);
      }

      private void memoryButton_Click(object sender, EventArgs e)
      {
         var memoryForm = new MemoryForm();
         memoryForm.Show(this);
      }

      private void morseButton_Click(object sender, EventArgs e)
      {
         var morseForm = new MorseForm();
         morseForm.Show(this);
      }

      private void complicatedWiresButton_Click(object sender, EventArgs e)
      {
         var complicatedWiresForm = new ComplicatedWiresForm(bombInfo);
         OnBombInfoMessage += complicatedWiresForm.BombInfoUpdate;
         complicatedWiresForm.Show(this);
      }

      private void wireSeqButton_Click(object sender, EventArgs e)
      {
         var wireSequenceForm = new WireSequenceForm();
         wireSequenceForm.Show(this);
      }

      private void mazeButton_Click(object sender, EventArgs e)
      {
         var mazeForm = new MazeForm();
         mazeForm.Show(this);
      }

      private void passwordButton_Click(object sender, EventArgs e)
      {
         var passwordsForm = new PasswordForm();
         passwordsForm.Show(this);
      }

      private void knobButton_Click(object sender, EventArgs e)
      {
         var knobForm = new KnobForm();
         knobForm.Show(this);
      }

      public void RemoveMeFromQueue(Form form)
      {
         if (form is ButtonForm)
            OnBombInfoMessage -= ((ButtonForm)form).BombInfoUpdate;
         else if (form is ComplicatedWiresForm)
            OnBombInfoMessage -= ((ComplicatedWiresForm)form).BombInfoUpdate;
         else if (form is SimonSaysForm)
            OnBombInfoMessage -= ((SimonSaysForm)form).BombInfoUpdate;
         else if (form is WiresForm)
            OnBombInfoMessage -= ((WiresForm)form).BombInfoUpdate;
      }

      private void serialOddEvenComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         switch (serialOddEvenComboBox.SelectedIndex)
         {
            case LAST_SERIAL_ODD:
            {
               bombInfo.LastSerialDigitIsOdd = true;
               break;
            }
            case LAST_SERIAL_EVEN:
            {
               bombInfo.LastSerialDigitIsOdd = false;
               break;
            }
            default:
            {
               bombInfo.LastSerialDigitIsOdd = null;
               break;
            }
         }

         if (OnBombInfoMessage != null)
         {
            OnBombInfoMessage(bombInfo, e);
         }
      }

      private void numBatteriesComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         switch (numBatteriesComboBox.SelectedIndex)
         {
            case ZERO_BATTERIES:
            {
               bombInfo.NumBatteries = 0;
               break;
            }
            case ONE_BATTERY:
            {
               bombInfo.NumBatteries = 1;
               break;
            }
            case TWO_BATTERIES:
            {
               bombInfo.NumBatteries = 2;
               break;
            }
            case THREE_OR_MORE_BATTERIES:
            {
               bombInfo.NumBatteries = 3;
               break;
            }
            default:
            {
               bombInfo.NumBatteries = null;
               break;
            }
         }

         if (OnBombInfoMessage != null)
         {
            OnBombInfoMessage(bombInfo, e);
         }
      }

      private void carCheckBox_CheckedChanged(object sender, EventArgs e)
      {
         bombInfo.CarIndicatorIsLit = carCheckBox.Checked;

         if (OnBombInfoMessage != null)
         {
            OnBombInfoMessage(bombInfo, e);
         }
      }

      private void frkCheckBox_CheckedChanged(object sender, EventArgs e)
      {
         bombInfo.FrkIndicatorIsLit = frkCheckBox.Checked;

         if (OnBombInfoMessage != null)
         {
            OnBombInfoMessage(bombInfo, e);
         }
      }

      private void removeStrikeButton_Click(object sender, EventArgs e)
      {
         bombInfo.NumStrikes--;

         if (bombInfo.NumStrikes <= 0)
         {
            removeStrikeButton.Enabled = false;
         }

         if (bombInfo.NumStrikes < 2)
         {
            addStrikeButton.Enabled = true;
         }

         if (OnBombInfoMessage != null)
         {
            OnBombInfoMessage(bombInfo, e);
         }

         UpdateNumStrikeTextBox();
      }

      private void addStrikeButton_Click(object sender, EventArgs e)
      {
         bombInfo.NumStrikes++;

         if (bombInfo.NumStrikes >= 2)
         {
            addStrikeButton.Enabled = false;
         }

         if (bombInfo.NumStrikes >= 1)
         {
            removeStrikeButton.Enabled = true;
         }

         if (OnBombInfoMessage != null)
         {
            OnBombInfoMessage(bombInfo, e);
         }

         UpdateNumStrikeTextBox();
      }

      private void UpdateNumStrikeTextBox()
      {
         if (bombInfo.NumStrikes == 0)
         {
            numStrikesTextBox.Text = "";
         }
         else if (bombInfo.NumStrikes == 1)
         {
            numStrikesTextBox.Text = "X";
         }
         else if (bombInfo.NumStrikes == 2)
         {
            numStrikesTextBox.Text = "XX";
         }
      }

      private void serialVowelComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         switch (serialVowelComboBox.SelectedIndex)
         {
            case SERIAL_HAS_NO_VOWELS:
            {
               bombInfo.SerialContainsVowel = false;
               break;
            }
            case SERIAL_HAS_VOWELS:
            {
               bombInfo.SerialContainsVowel = true;
               break;
            }
            default:
            {
               bombInfo.SerialContainsVowel = null;
               break;
            }
         }

         if (OnBombInfoMessage != null)
         {
            OnBombInfoMessage(bombInfo, e);
         }
      }

      private void parallelComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         switch (parallelComboBox.SelectedIndex)
         {
            case NO_PARALLEL_PORT:
            {
               bombInfo.HasParallelPort = false;
               break;
            }
            case YES_PARALLEL_PORT:
            {
               bombInfo.HasParallelPort = true;
               break;
            }
            default:
            {
               bombInfo.HasParallelPort = null;
               break;
            }
         }

         if (OnBombInfoMessage != null)
         {
            OnBombInfoMessage(bombInfo, e);
         }
      }

      private void resetInfoButton_Click(object sender, EventArgs e)
      {
         removeStrikeButton.Enabled = false;
         addStrikeButton.Enabled = true;
         serialOddEvenComboBox.SelectedIndex = -1;
         numBatteriesComboBox.SelectedIndex = -1;
         serialVowelComboBox.SelectedIndex = -1;
         parallelComboBox.SelectedIndex = -1;
         carCheckBox.CheckState = CheckState.Indeterminate;
         frkCheckBox.CheckState = CheckState.Indeterminate;

         bombInfo.Reset();
         if (OnBombInfoMessage != null)
         {
            OnBombInfoMessage(bombInfo, e);
         }

         UpdateNumStrikeTextBox();
      }

      private void SetBombTimerDisplay(int minutes, int seconds)
      {
         timerTextBox.BackColor = controlColor;
         timerTextBox.ForeColor = Color.Black;
         timerTextBox.Text = "";

         if (minutes == 0 && seconds == 0)
         {
            return;
         }

         if (minutes >= 10)
         {
            timerTextBox.Text = minutes.ToString() + ":";
         }
         else if (minutes >= 1)
         {
            timerTextBox.Text += "0" + minutes.ToString() + ":";
         }

         if (minutes >= 1)
         {
            if (seconds >= 10)
            {
               timerTextBox.Text += seconds;
            }
            else
            {
               timerTextBox.Text += "0" + seconds.ToString();
            }
         }
         else
         {
            if (seconds >= 10)
            {
               timerTextBox.Text += seconds.ToString();
            }
            else
            {
               timerTextBox.Text += "0" + seconds.ToString();
            }

            timerTextBox.Text += ".00";
         }
      }

      private void SetBombTimerDisplay(TimeSpan timespan)
      {
         if (timespan >= oneMinute)
         {
            timerTextBox.Text = timespan.ToString(@"mm\:ss");
         }
         else
         {
            timerTextBox.Text = timespan.ToString(@"ss\.ff");
         }

         if (timespan <= TimeSpan.Zero)
         {
            timerTextBox.BackColor = Color.Black;
            timerTextBox.ForeColor = Color.White;

            // The timer and stopwatch are slightly off,
            // show 00.00 just to be sure
            timerTextBox.Text = "00.00";
         }
         else if (timespan <= redTimespan)
         {
            timerTextBox.BackColor = Color.Red;
            timerTextBox.ForeColor = Color.White;
         }
         else if (bombInfo.NumStrikes == 2)
         {
            timerTextBox.BackColor = Color.Orange;
            timerTextBox.ForeColor = Color.Black;
         }
         else if (bombInfo.NumStrikes == 1)
         {
            timerTextBox.BackColor = Color.Yellow;
            timerTextBox.ForeColor = Color.Black;
         }
         else
         {
            timerTextBox.BackColor = controlColor;
            timerTextBox.ForeColor = Color.Black;
         }
      }

      private void timerStartButton_Click(object sender, EventArgs e)
      {
         bombTimeLeft = new TimeSpan(0, timerMinutes, timerSeconds);
         bombTimer.Enabled = true;
         timerStartButton.Enabled = false;
         timerIsRunning = true;
         stopWatch.Start();
         lastStopwatchElapsed = TimeSpan.Zero;
      }

      private void timerResetButton_Click(object sender, EventArgs e)
      {
         bombTimer.Enabled = false;
         timerStartButton.Enabled = true;
         timerIsRunning = false;
         stopWatch.Reset();

         SetBombTimerDisplay(timerMinutes, timerSeconds);
         bombTimeLeft = new TimeSpan(0, timerMinutes, timerSeconds);
      }

      public void OnTick(Object source, EventArgs e)
      {
         TimeSpan stopwatchSnapshot = stopWatch.Elapsed;

         float strikePenalty = zeroStrikePenalty;
         if (bombInfo.NumStrikes == 1)
         {
            strikePenalty = oneStrikePenalty;
         }
         else if (bombInfo.NumStrikes == 2)
         {
            strikePenalty = twoStrikePenalty;
         }

         TimeSpan timeElapsed = new TimeSpan((long)(
            (stopwatchSnapshot.Ticks - lastStopwatchElapsed.Ticks) * strikePenalty));
         lastStopwatchElapsed = stopwatchSnapshot;

         bombTimeLeft -= timeElapsed;
         SetBombTimerDisplay(bombTimeLeft);

         if (bombTimeLeft <= TimeSpan.Zero)
         {
            bombTimer.Enabled = false;
            stopWatch.Stop();
         }
      }

      private void IncrementSetTimeBy30Sec()
      {
         if (timerSeconds == 30)
         {
            timerMinutes++;
            timerSeconds = 0;
         }
         else
         {
            timerSeconds = 30;
         }

         if (timerMinutes == 10)
         {
            timerForwardButton.Enabled = false;
         }

         if (timerMinutes >= 1)
         {
            timerBackButton.Enabled = true;
         }
      }

      private void DecrementSetTimeBy30Sec()
      {
         if (timerSeconds == 0)
         {
            timerMinutes--;
            timerSeconds = 30;
         }
         else
         {
            timerSeconds = 0;
         }

         if (timerMinutes == 0 && timerSeconds == 30)
         {
            timerBackButton.Enabled = false;
         }

         if (timerMinutes <= 9)
         {
            timerForwardButton.Enabled = true;
         }
      }

      private void PrintSetTimerText()
      {
         setTimeTextBox.Text = timerMinutes + ":";

         if (timerSeconds >= 10)
         {
            setTimeTextBox.Text += timerSeconds;
         }
         else
         {
            setTimeTextBox.Text += "0" + timerSeconds;
         }
      }

      private void timerBackButton_Click(object sender, EventArgs e)
      {
         DecrementSetTimeBy30Sec();
         PrintSetTimerText();

         if (!timerIsRunning)
         {
            SetBombTimerDisplay(timerMinutes, timerSeconds);
         }
      }

      private void timerForwardButton_Click(object sender, EventArgs e)
      {
         IncrementSetTimeBy30Sec();
         PrintSetTimerText();

         if (!timerIsRunning)
         {
            SetBombTimerDisplay(timerMinutes, timerSeconds);
         }
      }

      private void carCheckBox_Paint(object sender, PaintEventArgs e)
      {
         if (carCheckBox.CheckState == CheckState.Indeterminate)
         {
            System.Windows.Forms.VisualStyles.CheckBoxState state =
               System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal;

            CheckBoxRenderer.DrawCheckBox(e.Graphics,
               new Point(carCheckBox.ClientRectangle.Location.X,
                         carCheckBox.ClientRectangle.Location.Y + 1),
               state);

            e.Graphics.DrawString("?",
               new Font(this.Font.FontFamily, 7.5f, FontStyle.Bold),
               new SolidBrush(indeterminateColor),
               new Point(carCheckBox.ClientRectangle.Location.X + 1,
                         carCheckBox.ClientRectangle.Location.Y + 1));
         }
      }

      private void frkCheckBox_Paint(object sender, PaintEventArgs e)
      {
         if (frkCheckBox.CheckState == CheckState.Indeterminate)
         {
            System.Windows.Forms.VisualStyles.CheckBoxState state =
               System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal;

            CheckBoxRenderer.DrawCheckBox(e.Graphics,
               new Point(frkCheckBox.ClientRectangle.Location.X,
                         frkCheckBox.ClientRectangle.Location.Y + 1),
               state);

            e.Graphics.DrawString("?",
               new Font(this.Font.FontFamily, 7.5f, FontStyle.Bold),
               new SolidBrush(indeterminateColor),
               new Point(frkCheckBox.ClientRectangle.Location.X + 1,
                         frkCheckBox.ClientRectangle.Location.Y + 1));
         }
      }
   }
}
