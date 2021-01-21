using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ktane_helper
{
   public partial class KnobForm : Form
   {
      private static KnobModule knobModule;

      public KnobForm()
      {
         InitializeComponent();
         InitializeModule();
         InitializeInstructions();
      }

      private void InitializeModule()
      {
         knobModule = new KnobModule();
         ResetRadioButtons();
      }

      private void InitializeInstructions()
      {
         instructionsTextBox.AppendText("● The knob can be turned to one of four different positions.");
         instructionsTextBox.AppendText("\n● The knob must be in the correct position when this module's timer hits zero.");
         instructionsTextBox.AppendText("\n● The correct position can be determined by the on/off configuration of the twelve LEDs.");
         instructionsTextBox.AppendText("\n● Knob positions are relative to the \"UP\" label, which may be rotated.");
      }

      private void UpdateAnswers()
      {
         answerTextBox.Text = knobModule.GetSolutionString();
      }

      private class KnobModule
      {
         public enum LitState
         {
              Unknown
            , Lit
            , NotLit
         }

         private List<LitState> litLeds;

         private static readonly List<bool> upAnswer1 = new List<bool>
            { false, false, true,  false, true,  true,
              true,  true,  true,  true,  false, true };

         private static readonly List<bool> upAnswer2 = new List<bool>
            { true,  false, true,  false, true,  false,
              false, true,  true,  false, true,  true };

         private static readonly List<bool> downAnswer1 = new List<bool>
            { false, true,  true,  false, false, true,
              true,  true,  true,  true,  false, true };

         private static readonly List<bool> downAnswer2 = new List<bool>
            { true,  false, true,  false, true,  false,
              false, true,  false, false, false, true };

         private static readonly List<bool> leftAnswer1 = new List<bool>
            { false, false, false, false, true,  false,
              true,  false, false, true,  true,  true };

         private static readonly List<bool> leftAnswer2 = new List<bool>
            { false, false, false, false, true,  false,
              false, false, false, true,  true,  false };

         private static readonly List<bool> rightAnswer1 = new List<bool>
            { true,  false, true,  true,  true,  true,
              true,  true,  true,  false, true,  false };

         private static readonly List<bool> rightAnswer2 = new List<bool>
            { true,  false, true,  true,  false, false,
              true,  true,  true,  false, true,  false };

         private static readonly List<List<bool>> upAnswers = new List<List<bool>>
            { upAnswer1, upAnswer2 };

         private static readonly List<List<bool>> downAnswers = new List<List<bool>>
            { downAnswer1, downAnswer2 };

         private static readonly List<List<bool>> leftAnswers = new List<List<bool>>
            { leftAnswer1, leftAnswer2 };

         private static readonly List<List<bool>> rightAnswers = new List<List<bool>>
            { rightAnswer1, rightAnswer2 };

         public KnobModule()
         {
            litLeds = new List<LitState>
               { LitState.Unknown, LitState.Unknown, LitState.Unknown,
                 LitState.Unknown, LitState.Unknown, LitState.Unknown,
                 LitState.Unknown, LitState.Unknown, LitState.Unknown,
                 LitState.Unknown, LitState.Unknown, LitState.Unknown };
         }

         public void UpdateLed(int position, bool value)
         {
            if (value)
            {
               litLeds[position - 1] = LitState.Lit;
            }
            else
            {
               litLeds[position - 1] = LitState.NotLit;
            }
         }

         public void ResetLeds()
         {
            for (int i = 0; i < litLeds.Count; ++i)
            {
               litLeds[i] = LitState.Unknown;
            }
         }

         public String GetSolutionString()
         {
            List<String> solutions = new List<String>();

            if (CouldBeUp())
            {
               solutions.Add("Up");
            }
            if (CouldBeDown())
            {
               solutions.Add("Down");
            }
            if (CouldBeLeft())
            {
               solutions.Add("Left");
            }
            if (CouldBeRight())
            {
               solutions.Add("Right");
            }

            if (solutions.Count == 1)
            {
               return solutions[0];
            }
            return String.Empty;
         }

         private bool CouldBeUp()
         {
            bool retVal = false;

            foreach (List<bool> answer in upAnswers)
            {
               bool thisAnswer = true;
               for (int i = 0; i < litLeds.Count; ++i)
               {
                  if (litLeds[i] == LitState.Lit && answer[i] == false ||
                      litLeds[i] == LitState.NotLit && answer[i] == true)
                  {
                     thisAnswer = false;
                     break;
                  }
               }

               if (thisAnswer)
               {
                  retVal = true;
                  break;
               }
            }

            return retVal;
         }

         private bool CouldBeDown()
         {
            bool retVal = false;

            foreach (List<bool> answer in downAnswers)
            {
               bool thisAnswer = true;
               for (int i = 0; i < litLeds.Count; ++i)
               {
                  if (litLeds[i] == LitState.Lit && answer[i] == false ||
                      litLeds[i] == LitState.NotLit && answer[i] == true)
                  {
                     thisAnswer = false;
                     break;
                  }
               }

               if (thisAnswer)
               {
                  retVal = true;
                  break;
               }
            }

            return retVal;
         }

         private bool CouldBeLeft()
         {
            bool retVal = false;

            foreach (List<bool> answer in leftAnswers)
            {
               bool thisAnswer = true;
               for (int i = 0; i < litLeds.Count; ++i)
               {
                  if (litLeds[i] == LitState.Lit && answer[i] == false ||
                      litLeds[i] == LitState.NotLit && answer[i] == true)
                  {
                     thisAnswer = false;
                     break;
                  }
               }

               if (thisAnswer)
               {
                  retVal = true;
                  break;
               }
            }

            return retVal;
         }

         private bool CouldBeRight()
         {
            bool retVal = false;

            foreach (List<bool> answer in rightAnswers)
            {
               bool thisAnswer = true;
               for (int i = 0; i < litLeds.Count; ++i)
               {
                  if (litLeds[i] == LitState.Lit && answer[i] == false ||
                      litLeds[i] == LitState.NotLit && answer[i] == true)
                  {
                     thisAnswer = false;
                     break;
                  }
               }

               if (thisAnswer)
               {
                  retVal = true;
                  break;
               }
            }

            return retVal;
         }
      }

      private void button1_Click(object sender, EventArgs e)
      {
         ResetRadioButtons();
      }

      private void ResetRadioButtons()
      {
         radioButton1On.Checked = false;
         radioButton1Off.Checked = false;
         radioButton2On.Checked = false;
         radioButton2Off.Checked = false;
         radioButton3On.Checked = false;
         radioButton3Off.Checked = false;
         radioButton4On.Checked = false;
         radioButton4Off.Checked = false;
         radioButton5On.Checked = false;
         radioButton5Off.Checked = false;
         radioButton6On.Checked = false;
         radioButton6Off.Checked = false;
         radioButton7On.Checked = false;
         radioButton7Off.Checked = false;
         radioButton8On.Checked = false;
         radioButton8Off.Checked = false;
         radioButton9On.Checked = false;
         radioButton9Off.Checked = false;
         radioButton10On.Checked = false;
         radioButton10Off.Checked = false;
         radioButton11On.Checked = false;
         radioButton11Off.Checked = false;
         radioButton12On.Checked = false;
         radioButton12Off.Checked = false;

         knobModule.ResetLeds();
         UpdateAnswers();
      }

      private void radioButton1On_CheckedChanged(object sender, EventArgs e)
      {
         knobModule.UpdateLed(1, radioButton1On.Checked);
         UpdateAnswers();
      }

      private void radioButton1Off_CheckedChanged(object sender, EventArgs e)
      {
         knobModule.UpdateLed(1, !radioButton1Off.Checked);
         UpdateAnswers();
      }

      private void radioButton2On_CheckedChanged(object sender, EventArgs e)
      {
         knobModule.UpdateLed(2, radioButton2On.Checked);
         UpdateAnswers();
      }

      private void radioButton2Off_CheckedChanged(object sender, EventArgs e)
      {
         knobModule.UpdateLed(2, !radioButton2Off.Checked);
         UpdateAnswers();
      }

      private void radioButton3On_CheckedChanged(object sender, EventArgs e)
      {
         knobModule.UpdateLed(3, radioButton3On.Checked);
         UpdateAnswers();
      }

      private void radioButton3Off_CheckedChanged(object sender, EventArgs e)
      {
         knobModule.UpdateLed(3, !radioButton3Off.Checked);
         UpdateAnswers();
      }

      private void radioButton4On_CheckedChanged(object sender, EventArgs e)
      {
         knobModule.UpdateLed(4, radioButton4On.Checked);
         UpdateAnswers();
      }

      private void radioButton4Off_CheckedChanged(object sender, EventArgs e)
      {
         knobModule.UpdateLed(4, !radioButton4Off.Checked);
         UpdateAnswers();
      }

      private void radioButton5On_CheckedChanged(object sender, EventArgs e)
      {
         knobModule.UpdateLed(5, radioButton5On.Checked);
         UpdateAnswers();
      }

      private void radioButton5Off_CheckedChanged(object sender, EventArgs e)
      {
         knobModule.UpdateLed(5, !radioButton5Off.Checked);
         UpdateAnswers();
      }

      private void radioButton6On_CheckedChanged(object sender, EventArgs e)
      {
         knobModule.UpdateLed(6, radioButton6On.Checked);
         UpdateAnswers();
      }

      private void radioButton6Off_CheckedChanged(object sender, EventArgs e)
      {
         knobModule.UpdateLed(6, !radioButton6Off.Checked);
         UpdateAnswers();
      }

      private void radioButton7On_CheckedChanged(object sender, EventArgs e)
      {
         knobModule.UpdateLed(7, radioButton7On.Checked);
         UpdateAnswers();
      }

      private void radioButton7Off_CheckedChanged(object sender, EventArgs e)
      {
         knobModule.UpdateLed(7, !radioButton7Off.Checked);
         UpdateAnswers();
      }

      private void radioButton8On_CheckedChanged(object sender, EventArgs e)
      {
         knobModule.UpdateLed(8, radioButton8On.Checked);
         UpdateAnswers();
      }

      private void radioButton8Off_CheckedChanged(object sender, EventArgs e)
      {
         knobModule.UpdateLed(8, !radioButton8Off.Checked);
         UpdateAnswers();
      }

      private void radioButton9On_CheckedChanged(object sender, EventArgs e)
      {
         knobModule.UpdateLed(9, radioButton9On.Checked);
         UpdateAnswers();
      }

      private void radioButton9Off_CheckedChanged(object sender, EventArgs e)
      {
         knobModule.UpdateLed(9, !radioButton9Off.Checked);
         UpdateAnswers();
      }

      private void radioButton10On_CheckedChanged(object sender, EventArgs e)
      {
         knobModule.UpdateLed(10, radioButton10On.Checked);
         UpdateAnswers();
      }

      private void radioButton10Off_CheckedChanged(object sender, EventArgs e)
      {
         knobModule.UpdateLed(10, !radioButton10Off.Checked);
         UpdateAnswers();
      }

      private void radioButton11On_CheckedChanged(object sender, EventArgs e)
      {
         knobModule.UpdateLed(11, radioButton11On.Checked);
         UpdateAnswers();
      }

      private void radioButton11Off_CheckedChanged(object sender, EventArgs e)
      {
         knobModule.UpdateLed(11, !radioButton11Off.Checked);
         UpdateAnswers();
      }

      private void radioButton12On_CheckedChanged(object sender, EventArgs e)
      {
         knobModule.UpdateLed(12, radioButton12On.Checked);
         UpdateAnswers();
      }

      private void radioButton12Off_CheckedChanged(object sender, EventArgs e)
      {
         knobModule.UpdateLed(12, !radioButton12Off.Checked);
         UpdateAnswers();
      }
   }
}
