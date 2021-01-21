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
   public partial class SimonSaysForm : Form
   {
      private static SimonSaysModule simonSaysModule;

      public SimonSaysForm(BombInfo info)
      {
         InitializeComponent();
         InitializeModule(info);
      }

      private void InitializeModule(BombInfo info)
      {
         simonSaysModule = new SimonSaysModule(info);
         UpdateWarnings();
      }

      public void BombInfoUpdate(object sender, EventArgs e)
      {
         BombInfo info = sender as BombInfo;
         if (info != null)
         {
            simonSaysModule.NumStrikes = info.NumStrikes;
            simonSaysModule.SerialContainsVowel = info.SerialContainsVowel;
            DisplayAnswers();
            UpdateWarnings();
         }
      }

      private void DisplayAnswers()
      {
         solutionRichTextBox.Clear();
         List<SimonSaysModule.SimonColor> solutionSequence =
            simonSaysModule.SolutionSequence;
         foreach (var color in solutionSequence)
         {
            AddTextToSolutionSequence(color);
         }
      }

      private void UpdateWarnings()
      {
         if (!simonSaysModule.SerialContainsVowel.HasValue)
         {
            info2Label.Font = new Font(info2Label.Font, FontStyle.Bold);
            info2Label.ForeColor = Color.Red;
         }
         else
         {
            info2Label.Font = new Font(info2Label.Font, FontStyle.Regular);
            info2Label.ForeColor = Color.Black;
         }
      }

      private void AddTextToBombSequence(SimonSaysModule.SimonColor color)
      {
         if (bombRichTextBox.Text.Length > 0)
         {
            bombRichTextBox.AppendText(", ");
         }

         if (color == SimonSaysModule.SimonColor.Blue)
         {
            bombRichTextBox.AppendText("Blue");
         }
         else if (color == SimonSaysModule.SimonColor.Red)
         {
            bombRichTextBox.AppendText("Red");
         }
         else if (color == SimonSaysModule.SimonColor.Green)
         {
            bombRichTextBox.AppendText("Green");
         }
         else if (color == SimonSaysModule.SimonColor.Yellow)
         {
            bombRichTextBox.AppendText("Yellow");
         }
      }

      private void AddTextToSolutionSequence(SimonSaysModule.SimonColor color)
      {
         if (solutionRichTextBox.Text.Length > 0)
         {
            solutionRichTextBox.AppendText(", ");
         }

         if (color == SimonSaysModule.SimonColor.Blue)
         {
            solutionRichTextBox.AppendText("Blue");
         }
         else if (color == SimonSaysModule.SimonColor.Red)
         {
            solutionRichTextBox.AppendText("Red");
         }
         else if (color == SimonSaysModule.SimonColor.Green)
         {
            solutionRichTextBox.AppendText("Green");
         }
         else if (color == SimonSaysModule.SimonColor.Yellow)
         {
            solutionRichTextBox.AppendText("Yellow");
         }
      }

      private void ResetSequences()
      {
         bombRichTextBox.Clear();
         solutionRichTextBox.Clear();
         simonSaysModule.ResetSequences();
      }


      // Simon Says Module
      private class SimonSaysModule
      {
         public enum SimonColor
         {
              Invalid
            , Blue
            , Green
            , Red
            , Yellow
         }

         private int numStrikes;
         private bool? serialContainsVowel;
         private List<SimonColor> bombSequence;
         private List<SimonColor> solutionSequence;

         public SimonSaysModule(BombInfo info)
         {
            numStrikes = info.NumStrikes;
            serialContainsVowel = info.SerialContainsVowel;
            bombSequence = new List<SimonColor>();
            solutionSequence = new List<SimonColor>();
         }

         public SimonColor GetButtonToPress(SimonColor color)
         {
            // Serial number contains a vowel
            if (serialContainsVowel.HasValue && serialContainsVowel.Value)
            {
               if (numStrikes == 0)
               {
                  if (color == SimonColor.Red)
                     return SimonColor.Blue;
                  else if (color == SimonColor.Blue)
                     return SimonColor.Red;
                  else if (color == SimonColor.Green)
                     return SimonColor.Yellow;
                  else if (color == SimonColor.Yellow)
                     return SimonColor.Green;
               }
               else if (numStrikes == 1)
               {
                  if (color == SimonColor.Red)
                     return SimonColor.Yellow;
                  else if (color == SimonColor.Blue)
                     return SimonColor.Green;
                  else if (color == SimonColor.Green)
                     return SimonColor.Blue;
                  else if (color == SimonColor.Yellow)
                     return SimonColor.Red;
               }
               else if (numStrikes == 2)
               {
                  if (color == SimonColor.Red)
                     return SimonColor.Green;
                  else if (color == SimonColor.Blue)
                     return SimonColor.Red;
                  else if (color == SimonColor.Green)
                     return SimonColor.Yellow;
                  else if (color == SimonColor.Yellow)
                     return SimonColor.Blue;
               }
            }
            // Serial number does NOT contain a vowel
            else
            {
               if (numStrikes == 0)
               {
                  if (color == SimonColor.Red)
                     return SimonColor.Blue;
                  else if (color == SimonColor.Blue)
                     return SimonColor.Yellow;
                  else if (color == SimonColor.Green)
                     return SimonColor.Green;
                  else if (color == SimonColor.Yellow)
                     return SimonColor.Red;
               }
               else if (numStrikes == 1)
               {
                  if (color == SimonColor.Red)
                     return SimonColor.Red;
                  else if (color == SimonColor.Blue)
                     return SimonColor.Blue;
                  else if (color == SimonColor.Green)
                     return SimonColor.Yellow;
                  else if (color == SimonColor.Yellow)
                     return SimonColor.Green;
               }
               else if (numStrikes == 2)
               {
                  if (color == SimonColor.Red)
                     return SimonColor.Yellow;
                  else if (color == SimonColor.Blue)
                     return SimonColor.Green;
                  else if (color == SimonColor.Green)
                     return SimonColor.Blue;
                  else if (color == SimonColor.Yellow)
                     return SimonColor.Red;
               }
            }

            return SimonColor.Invalid;
         }

         public void PressButton(SimonColor color)
         {
            bombSequence.Add(color);
            CalculateSolution();
         }

         private void CalculateSolution()
         {
            solutionSequence.Clear();
            foreach (SimonColor color in bombSequence)
            {
               solutionSequence.Add(GetButtonToPress(color));
            }
         }

         public void ResetSequences()
         {
            bombSequence.Clear();
            solutionSequence.Clear();
         }

         public int NumStrikes
         {
            get
            {
               return numStrikes;
            }
            set
            {
               numStrikes = value;
               CalculateSolution();
            }
         }

         public bool? SerialContainsVowel
         {
            get
            {
               return serialContainsVowel;
            }
            set
            {
               serialContainsVowel = value;
               CalculateSolution();
            }
         }

         public List<SimonColor> SolutionSequence
         {
            get
            {
               return solutionSequence;
            }
         }
      }

      private void blueButton_Click(object sender, EventArgs e)
      {
         AddTextToBombSequence(SimonSaysModule.SimonColor.Blue);
         simonSaysModule.PressButton(SimonSaysModule.SimonColor.Blue);
         DisplayAnswers();
      }

      private void redButton_Click(object sender, EventArgs e)
      {
         AddTextToBombSequence(SimonSaysModule.SimonColor.Red);
         simonSaysModule.PressButton(SimonSaysModule.SimonColor.Red);
         DisplayAnswers();
      }

      private void greenButton_Click(object sender, EventArgs e)
      {
         AddTextToBombSequence(SimonSaysModule.SimonColor.Green);
         simonSaysModule.PressButton(SimonSaysModule.SimonColor.Green);
         DisplayAnswers();
      }

      private void yellowButton_Click(object sender, EventArgs e)
      {
         AddTextToBombSequence(SimonSaysModule.SimonColor.Yellow);
         simonSaysModule.PressButton(SimonSaysModule.SimonColor.Yellow);
         DisplayAnswers();
      }

      private void resetButton_Click(object sender, EventArgs e)
      {
         ResetSequences();
      }

      private void SimonSaysForm_FormClosing(object sender, FormClosingEventArgs e)
      {
         ((Form1)Owner).RemoveMeFromQueue(this);
      }
   }
}
