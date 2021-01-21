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
   public partial class ButtonForm : Form
   {
      private static ButtonModule buttonModule;

      private const String blueStr = "Blue";
      private const String redStr = "Red";
      private const String whiteStr = "White";
      private const String yellowStr = "Yellow";
      private const String noneStr = "None of the above";

      private const String abortStr = "Abort";
      private const String detonateStr = "Detonate";
      private const String holdStr = "Hold";

      private static readonly List<String> comboColorStrings =
         new List<String> { blueStr, redStr, whiteStr, yellowStr, noneStr };

      private static readonly List<String> comboTextStrings =
         new List<String> { abortStr, detonateStr, holdStr, noneStr };

      public ButtonForm(BombInfo info)
      {
         InitializeComponent();
         InitializeModule(info);
      }

      private void InitializeModule(BombInfo info)
      {
         buttonModule = new ButtonModule(info);
         colorComboBox.Items.AddRange(comboColorStrings.ToArray());
         textComboBox.Items.AddRange(comboTextStrings.ToArray());
      }

      private void DisplayAnswers()
      {
         if (buttonModule.TheSolution == ButtonModule.buttonSolution.PressAndRelease)
         {
            holdSolutionLabel.Visible = false;
            pressSolutionLabel.Visible = true;
         }
         else if (buttonModule.TheSolution == ButtonModule.buttonSolution.Hold)
         {
            pressSolutionLabel.Visible = false;
            holdSolutionLabel.Visible = true;
         }
         else
         {
            holdSolutionLabel.Visible = false;
            pressSolutionLabel.Visible = false;
         }
         DisplayNeededInfo();
      }

      private void DisplayNeededInfo()
      {
         if (buttonModule.DisplayBatteryWarning)
         {
            if (!buttonModule.NumBatteries.HasValue)
            {
               batteryInfoLabel.Font = new Font(batteryInfoLabel.Font, FontStyle.Bold);
               batteryInfoLabel.ForeColor = Color.Red;
            }
            else
            {
               batteryInfoLabel.Font = new Font(batteryInfoLabel.Font, FontStyle.Regular);
               batteryInfoLabel.ForeColor = Color.Black;
            }
            batteryInfoLabel.Visible = true;
         }
         else
         {
            batteryInfoLabel.Visible = false;
         }

         if (buttonModule.DisplayCarWarning)
         {
            if (!buttonModule.CarIsLit.HasValue)
            {
               carInfoLabel.Font = new Font(carInfoLabel.Font, FontStyle.Bold);
               carInfoLabel.ForeColor = Color.Red;
            }
            else
            {
               carInfoLabel.Font = new Font(carInfoLabel.Font, FontStyle.Regular);
               carInfoLabel.ForeColor = Color.Black;
            }
            carInfoLabel.Visible = true;
         }
         else
         {
            carInfoLabel.Visible = false;
         }

         if (buttonModule.DisplayFrkWarning)
         {
            if (!buttonModule.FrkIsLit.HasValue)
            {
               frkInfoLabel.Font = new Font(frkInfoLabel.Font, FontStyle.Bold);
               frkInfoLabel.ForeColor = Color.Red;
            }
            else
            {
               frkInfoLabel.Font = new Font(frkInfoLabel.Font, FontStyle.Regular);
               frkInfoLabel.ForeColor = Color.Black;
            }
            frkInfoLabel.Visible = true;
         }
         else
         {
            frkInfoLabel.Visible = false;
         }
      }

      public void BombInfoUpdate(object sender, EventArgs e)
      {
         BombInfo info = sender as BombInfo;
         if (info != null)
         {
            buttonModule.NumBatteries = info.NumBatteries;
            buttonModule.CarIsLit = info.CarIndicatorIsLit;
            buttonModule.FrkIsLit = info.FrkIndicatorIsLit;
            DisplayAnswers();
         }
      }


      // The button module
      private class ButtonModule
      {
         public enum buttonColor
         {
              NotSet
            , Blue
            , Red
            , White
            , Yellow
            , NoneOfAbove
         }

         public enum buttonText
         {
              NotSet
            , Abort
            , Detonate
            , Hold
            , NoneOfAbove
         }

         public enum buttonSolution
         {
              MissingInfo
            , PressAndRelease
            , Hold
         }

         private buttonColor colorOfButton;
         private buttonText textOfButton;
         private buttonSolution theSolution;
         private int? numBatteries;
         private bool? carIsLit;
         private bool? frkIsLit;
         private bool displayBatteryWarning;
         private bool displayCarWarning;
         private bool displayFrkWarning;

         public ButtonModule(BombInfo info)
         {
            numBatteries = info.NumBatteries;
            carIsLit = info.CarIndicatorIsLit;
            frkIsLit = info.FrkIndicatorIsLit;

            colorOfButton = buttonColor.NotSet;
            textOfButton = buttonText.NotSet;
            theSolution = buttonSolution.MissingInfo;

            displayBatteryWarning = false;
            displayCarWarning = false;
            displayFrkWarning = false;
         }

         private void CalculateSolution()
         {
            if (colorOfButton == buttonColor.NotSet ||
                textOfButton == buttonText.NotSet)
            {
               displayBatteryWarning = false;
               displayCarWarning = false;
               displayFrkWarning = false;
               return;
            }

            int whichStepDidWeGetTo = 0;

            // 1. If the button is blue and the button says "Abort", hold
            if (colorOfButton == buttonColor.Blue &&
                textOfButton == buttonText.Abort)
            {
               theSolution = buttonSolution.Hold;
               whichStepDidWeGetTo = 1;
            }
            // 2. If there is more than one battery and the button says
            //    "Detonate", press and release
            else if (numBatteries > 1 && textOfButton == buttonText.Detonate)
            {
               theSolution = buttonSolution.PressAndRelease;
               whichStepDidWeGetTo = 2;
            }
            // 3. If the button is white and CAR is lit, hold
            else if (colorOfButton == buttonColor.White &&
                     carIsLit.HasValue && carIsLit.Value)
            {
               theSolution = buttonSolution.Hold;
               whichStepDidWeGetTo = 3;
            }
            // 4. If more than 2 batteries and FRK is lit, press and release
            else if (numBatteries > 2 &&
                     frkIsLit.HasValue && frkIsLit.Value)
            {
               theSolution = buttonSolution.PressAndRelease;
               whichStepDidWeGetTo = 4;
            }
            // 5. If button is yellow, hold
            else if (colorOfButton == buttonColor.Yellow)
            {
               theSolution = buttonSolution.Hold;
               whichStepDidWeGetTo = 5;
            }
            // 6. If button is red and says "Hold", press and release
            else if (colorOfButton == buttonColor.Red &&
                     textOfButton == buttonText.Hold)
            {
               theSolution = buttonSolution.PressAndRelease;
               whichStepDidWeGetTo = 6;
            }
            // 7. Hold
            else
            {
               theSolution = buttonSolution.Hold;
               whichStepDidWeGetTo = 7;
            }

            // Battery display warning
            if (whichStepDidWeGetTo >= 2 && textOfButton == buttonText.Detonate ||
                whichStepDidWeGetTo >= 4)
            {
               displayBatteryWarning = true;
            }
            else
            {
               displayBatteryWarning = false;
            }

            // CAR display warning
            if (whichStepDidWeGetTo >= 3 && colorOfButton == buttonColor.White)
            {
               displayCarWarning = true;
            }
            else
            {
               displayCarWarning = false;
            }

            // FRK display warning
            if (whichStepDidWeGetTo >= 4 && numBatteries > 2)
            {
               displayFrkWarning = true;
            }
            else
            {
               displayFrkWarning = false;
            }
         }

         public buttonColor ColorOfButton
         {
            get
            {
               return colorOfButton;
            }
            set
            {
               colorOfButton = value;
               CalculateSolution();
            }
         }

         public buttonText TextOfButton
         {
            get
            {
               return textOfButton;
            }
            set
            {
               textOfButton = value;
               CalculateSolution();
            }
         }

         public buttonSolution TheSolution
         {
            get
            {
               return theSolution;
            }
         }

         public int? NumBatteries
         {
            set
            {
               numBatteries = value;
               CalculateSolution();
            }
            get
            {
               return numBatteries;
            }
         }

         public bool? CarIsLit
         {
            set
            {
               carIsLit = value;
               CalculateSolution();
            }
            get
            {
               return carIsLit;
            }
         }

         public bool? FrkIsLit
         {
            set
            {
               frkIsLit = value;
               CalculateSolution();
            }
            get
            {
               return frkIsLit;
            }
         }

         public bool DisplayBatteryWarning
         {
            get
            {
               return displayBatteryWarning;
            }
         }

         public bool DisplayCarWarning
         {
            get
            {
               return displayCarWarning;
            }
         }

         public bool DisplayFrkWarning
         {
            get
            {
               return displayFrkWarning;
            }
         }
      }

      private void colorComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         switch (colorComboBox.SelectedItem.ToString())
         {
            case blueStr:
            {
               buttonModule.ColorOfButton = ButtonModule.buttonColor.Blue;
               break;
            }
            case redStr:
            {
               buttonModule.ColorOfButton = ButtonModule.buttonColor.Red;
               break;
            }
            case whiteStr:
            {
               buttonModule.ColorOfButton = ButtonModule.buttonColor.White;
               break;
            }
            case yellowStr:
            {
               buttonModule.ColorOfButton = ButtonModule.buttonColor.Yellow;
               break;
            }
            default:
            {
               buttonModule.ColorOfButton = ButtonModule.buttonColor.NoneOfAbove;
               break;
            }
         }
         DisplayAnswers();
      }

      private void textComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         switch (textComboBox.SelectedItem.ToString())
         {
            case abortStr:
            {
               buttonModule.TextOfButton = ButtonModule.buttonText.Abort;
               break;
            }
            case detonateStr:
            {
               buttonModule.TextOfButton = ButtonModule.buttonText.Detonate;
               break;
            }
            case holdStr:
            {
               buttonModule.TextOfButton = ButtonModule.buttonText.Hold;
               break;
            }
            default:
            {
               buttonModule.TextOfButton = ButtonModule.buttonText.NoneOfAbove;
               break;
            }
         }
         DisplayAnswers();
      }

      private void ButtonForm_FormClosing(object sender, FormClosingEventArgs e)
      {
         ((Form1)Owner).RemoveMeFromQueue(this);
      }
   }
}
