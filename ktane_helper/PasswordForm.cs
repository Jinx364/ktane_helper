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
   public partial class PasswordForm : Form
   {
      private static PasswordModule passwordModule;

      public PasswordForm()
      {
         InitializeComponent();
         InitializeModule();
         DisplayAnswers();
      }

      private void InitializeModule()
      {
         passwordModule = new PasswordModule();
      }

      private void DisplayAnswers()
      {
         richTextBox1.Clear();
         List<String> answers = passwordModule.PossibleSolutions;

         foreach (String answer in answers)
         {
            if (richTextBox1.TextLength > 0)
            {
               richTextBox1.AppendText(", ");
            }

            richTextBox1.AppendText(answer);
         }
      }

      private class PasswordModule
      {
         private List<char> letters1;
         private List<char> letters2;
         private List<char> letters3;
         private List<char> letters4;
         private List<char> letters5;

         private static readonly List<String> passwords =
            new List<String> { "about", "after", "again", "below", "could",
            "every", "first", "found", "great", "house", "large", "learn",
            "never", "other", "place", "plant", "point", "right", "small",
            "sound", "spell", "still", "study", "their", "there", "these",
            "thing", "think", "three", "water", "where", "which", "world",
            "would", "write"};

         private List<String> possibleSolutions;

         public PasswordModule()
         {
            letters1 = new List<char>();
            letters2 = new List<char>();
            letters3 = new List<char>();
            letters4 = new List<char>();
            letters5 = new List<char>();

            possibleSolutions = new List<String>(passwords);
         }

         private void CalculateSolution()
         {
            possibleSolutions.Clear();
            possibleSolutions.AddRange(passwords);

            // Remove solutions that don't match with typed in letters
            if (letters1.Count > 0)
            {
               RemoveConflicts(1, letters1);
            }
            if (letters2.Count > 0)
            {
               RemoveConflicts(2, letters2);
            }
            if (letters3.Count > 0)
            {
               RemoveConflicts(3, letters3);
            }
            if (letters4.Count > 0)
            {
               RemoveConflicts(4, letters4);
            }
            if (letters5.Count > 0)
            {
               RemoveConflicts(5, letters5);
            }
         }

         private void AddPossible(int position, List<char> letters)
         {
            foreach (char character in letters)
            {
               foreach (String answer in passwords)
               {
                  if (answer[position - 1] == character)
                  {
                     if (!possibleSolutions.Contains(answer))
                     {
                        possibleSolutions.Add(answer);
                     }
                  }
               }
            }
         }

         private void RemoveConflicts(int position, List<char> letters)
         {
            for (int i = possibleSolutions.Count - 1; i >= 0; --i)
            {
               bool removeSolution = true;
               foreach (char character in letters)
               {
                  if (possibleSolutions[i][position - 1] == character)
                  {
                     removeSolution = false;
                     break;
                  }
               }

               if (removeSolution)
               {
                  possibleSolutions.RemoveAt(i);
               }
            }
         }

         public void UpdateRoller1(String letters)
         {
            letters1.Clear();
            foreach (Char character in letters)
            {
               if (Char.IsLetter(character))
               {
                  letters1.Add(Char.ToLower(character));
               }
            }
            CalculateSolution();
         }

         public void UpdateRoller2(String letters)
         {
            letters2.Clear();
            foreach (Char character in letters)
            {
               if (Char.IsLetter(character))
               {
                  letters2.Add(Char.ToLower(character));
               }
            }
            CalculateSolution();
         }

         public void UpdateRoller3(String letters)
         {
            letters3.Clear();
            foreach (Char character in letters)
            {
               if (Char.IsLetter(character))
               {
                  letters3.Add(Char.ToLower(character));
               }
            }
            CalculateSolution();
         }

         public void UpdateRoller4(String letters)
         {
            letters4.Clear();
            foreach (Char character in letters)
            {
               if (Char.IsLetter(character))
               {
                  letters4.Add(Char.ToLower(character));
               }
            }
            CalculateSolution();
         }

         public void UpdateRoller5(String letters)
         {
            letters5.Clear();
            foreach (Char character in letters)
            {
               if (Char.IsLetter(character))
               {
                  letters5.Add(Char.ToLower(character));
               }
            }
            CalculateSolution();
         }

         public List<String> PossibleSolutions
         {
            get
            {
               return possibleSolutions;
            }
         }
      }

      private void firstTextBox_TextChanged(object sender, EventArgs e)
      {
         passwordModule.UpdateRoller1(firstTextBox.Text);
         DisplayAnswers();
      }

      private void secondTextBox_TextChanged(object sender, EventArgs e)
      {
         passwordModule.UpdateRoller2(secondTextBox.Text);
         DisplayAnswers();
      }

      private void thirdTextBox_TextChanged(object sender, EventArgs e)
      {
         passwordModule.UpdateRoller3(thirdTextBox.Text);
         DisplayAnswers();
      }

      private void fourthTextBox_TextChanged(object sender, EventArgs e)
      {
         passwordModule.UpdateRoller4(fourthTextBox.Text);
         DisplayAnswers();
      }

      private void fifthTextBox_TextChanged(object sender, EventArgs e)
      {
         passwordModule.UpdateRoller5(fifthTextBox.Text);
         DisplayAnswers();
      }
   }
}
