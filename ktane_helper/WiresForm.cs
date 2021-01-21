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
   public partial class WiresForm : Form
   {
      private static WiresModule wireModule;

      private const String noWireStr = "--No Wire--";
      private const String blackStr = "Black";
      private const String blueStr = "Blue";
      private const String redStr = "Red";
      private const String whiteStr = "White";
      private const String yellowStr = "Yellow";

      private static readonly List<String> comboColorStrings =
         new List<String> { blackStr, blueStr, redStr, whiteStr, yellowStr };

      public WiresForm(BombInfo info)
      {
         InitializeComponent();
         InitializeModule(info);
         InitializeInstructions();
      }

      private void InitializeModule(BombInfo info)
      {
         wireModule = new WiresModule(info);
         ResetComboBoxes();
      }

      private void ResetComboBoxes()
      {
         wireModule.ResetWires();

         blackButton1.Checked = false;
         blueButton1.Checked = false;
         redButton1.Checked = false;
         whiteButton1.Checked = false;
         yellowButton1.Checked = false;

         blackButton2.Checked = false;
         blueButton2.Checked = false;
         redButton2.Checked = false;
         whiteButton2.Checked = false;
         yellowButton2.Checked = false;

         blackButton3.Checked = false;
         blueButton3.Checked = false;
         redButton3.Checked = false;
         whiteButton3.Checked = false;
         yellowButton3.Checked = false;

         blackButton4.Checked = false;
         blueButton4.Checked = false;
         redButton4.Checked = false;
         whiteButton4.Checked = false;
         yellowButton4.Checked = false;

         blackButton5.Checked = false;
         blueButton5.Checked = false;
         redButton5.Checked = false;
         whiteButton5.Checked = false;
         yellowButton5.Checked = false;

         blackButton6.Checked = false;
         blueButton6.Checked = false;
         redButton6.Checked = false;
         whiteButton6.Checked = false;
         yellowButton6.Checked = false;

         ResetDisplayMessages();
      }

      private void ResetDisplayMessages()
      {
         ResetCutMessages();
         messagesRichTextBox.Clear();
         info1Label.Visible = false;
      }

      private void ResetCutMessages()
      {
         cutWire1Label.Visible = false;
         cutWire2Label.Visible = false;
         cutWire3Label.Visible = false;
         cutWire4Label.Visible = false;
         cutWire5Label.Visible = false;
         cutWire6Label.Visible = false;
      }

      private void InitializeInstructions()
      {
         instructionsTextBox.AppendText("● A wire module can have 3-6 wires on it.");

         instructionsTextBox.AppendText("\n● Only the ");
         instructionsTextBox.SelectionFont = new Font(instructionsTextBox.Font, FontStyle.Underline);
         instructionsTextBox.AppendText("one");
         instructionsTextBox.SelectionFont = new Font(instructionsTextBox.Font, FontStyle.Regular);
         instructionsTextBox.AppendText(
            " correct wire needs to be cut to disarm the module.");

         instructionsTextBox.AppendText("\n● Wire ordering begins with the first on the top.");
      }

      public void BombInfoUpdate(object sender, EventArgs e)
      {
         BombInfo info = sender as BombInfo;
         if (info != null)
         {
            wireModule.SerialIsOdd = info.LastSerialDigitIsOdd;
            DisplayAnswers();
         }
      }

      private WiresModule.wireColor GetWireColorFromString(String str)
      {
         WiresModule.wireColor returnColor = WiresModule.wireColor.NoWire;

         if (str == blackStr)
            return WiresModule.wireColor.Black;
         else if (str == blueStr)
            return WiresModule.wireColor.Blue;
         else if (str == redStr)
            return WiresModule.wireColor.Red;
         else if (str == whiteStr)
            return WiresModule.wireColor.White;
         else if (str == yellowStr)
            return WiresModule.wireColor.Yellow;

         return returnColor;
      }

      private void DisplayAnswers()
      {
         ResetDisplayMessages();

         WiresModule.wireSolution solution = wireModule.Solution;
         switch (solution)
         {
            case WiresModule.wireSolution.Wire1:
            {
               cutWire1Label.Visible = true;
               break;
            }
            case WiresModule.wireSolution.Wire2:
            {
               cutWire2Label.Visible = true;
               break;
            }
            case WiresModule.wireSolution.Wire3:
            {
               cutWire3Label.Visible = true;
               break;
            }
            case WiresModule.wireSolution.Wire4:
            {
               cutWire4Label.Visible = true;
               break;
            }
            case WiresModule.wireSolution.Wire5:
            {
               cutWire5Label.Visible = true;
               break;
            }
            case WiresModule.wireSolution.Wire6:
            {
               cutWire6Label.Visible = true;
               break;
            }
            default:
            {
               break;
            }
         }

         String solutionMessage = wireModule.SolutionMessage;
         messagesRichTextBox.Text = solutionMessage;
         if (wireModule.DisplayOddSerialWarning)
         {
            if (!wireModule.SerialIsOdd.HasValue)
            {
               info1Label.Font = new Font(info1Label.Font, FontStyle.Bold);
               info1Label.ForeColor = Color.Red;
            }
            else
            {
               info1Label.Font = new Font(info1Label.Font, FontStyle.Regular);
               info1Label.ForeColor = Color.Black;
            }
            info1Label.Visible = true;
         }
         else
         {
            info1Label.Visible = false;
         }
      }

      // Wire Module
      private class WiresModule
      {
         public enum wireColor
         {
              NoWire
            , Black
            , Blue
            , Red
            , White
            , Yellow
         }

         public enum wireSolution
         {
              NotEnoughWires
            , Wire1
            , Wire2
            , Wire3
            , Wire4
            , Wire5
            , Wire6
         }

         private static readonly int MAX_WIRES = 6;
         private List<wireColor> wires;
         private wireSolution solution;
         private bool displayOddSerialWarning;
         private bool? serialIsOdd;
         private String solutionMessage;

         public WiresModule(BombInfo info)
         {
            wires = new List<wireColor>();
            for (int i = 0; i < MAX_WIRES; ++i)
            {
               wires.Add(wireColor.NoWire);
            }
            solution = wireSolution.NotEnoughWires;
            displayOddSerialWarning = false;

            serialIsOdd = info.LastSerialDigitIsOdd;
         }

         public void ResetWires()
         {
            for (int i = 0; i < wires.Count; ++i)
            {
               wires[i] = wireColor.NoWire;
            }

            solution = wireSolution.NotEnoughWires;
            displayOddSerialWarning = false;
            solutionMessage = "";
         }

         // Solving logic
         private void CalculateSolution()
         {
            displayOddSerialWarning = false;
            switch (GetNumberOfWires())
            {
               case 3:
               {
                  ThreeWireLogic();
                  break;
               }
               case 4:
               {
                  FourWireLogic();
                  break;
               }
               case 5:
               {
                  FiveWireLogic();
                  break;
               }
               case 6:
               {
                  SixWireLogic();
                  break;
               }
               default:
               {
                  solution = wireSolution.NotEnoughWires;
                  solutionMessage = "";
                  break;
               }
            }
         }

         private void ThreeWireLogic()
         {
            // If there are no red wires, cut the second wire
            if (GetNumberOfWiresOfColor(wireColor.Red) == 0)
            {
               SetSolutionFromIndex(GetParticularWireIndex(2));
               solutionMessage = "Cut the second wire";
            }
            // Otherwise, if the last wire is white, cut the last wire
            else if (wires[GetLastWireIndex()] == wireColor.White)
            {
               SetSolutionFromIndex(GetLastWireIndex());
               solutionMessage = "Cut the last wire";
            }
            // Otherwise, if there is more than one blue wire, cut the last blue wire
            else if (GetNumberOfWiresOfColor(wireColor.Blue) > 1)
            {
               SetSolutionFromIndex(GetLastWireIndexOfColor(wireColor.Blue));
               solutionMessage = "Cut the last blue wire";
            }
            // Otherwise, cut the last wire
            else
            {
               SetSolutionFromIndex(GetLastWireIndex());
               solutionMessage = "Cut the last wire";
            }
         }

         private void FourWireLogic()
         {
            int whichStepDidWeGetTo = 0;

            // If there is more than one red wire and the last digit of the serial
            // number is odd, cut the last red wire
            if (GetNumberOfWiresOfColor(wireColor.Red) > 1 &&
                serialIsOdd.HasValue && serialIsOdd.Value)
            {
               SetSolutionFromIndex(GetLastWireIndexOfColor(wireColor.Red));
               solutionMessage = "Cut the last red wire";
               whichStepDidWeGetTo = 1;
            }
            // Otherwise, if the last wire is yellow and there are no red wires,
            // cut the first wire
            else if (wires[GetLastWireIndex()] == wireColor.Yellow &&
                     GetNumberOfWiresOfColor(wireColor.Red) == 0)
            {
               SetSolutionFromIndex(GetParticularWireIndex(1));
               solutionMessage = "Cut the first wire";
               whichStepDidWeGetTo = 2;
            }
            // Otherwise, if there is exactly one blue wire, cut the first wire
            else if (GetNumberOfWiresOfColor(wireColor.Blue) == 1)
            {
               SetSolutionFromIndex(GetParticularWireIndex(1));
               solutionMessage = "Cut the first wire";
               whichStepDidWeGetTo = 3;
            }
            // Otherwise, if there is more than one yellow wire, cut the last wire
            else if (GetNumberOfWiresOfColor(wireColor.Yellow) > 1)
            {
               SetSolutionFromIndex(GetLastWireIndex());
               solutionMessage = "Cut the last wire";
               whichStepDidWeGetTo = 4;
            }
            // Otherwise, cut the second wire
            else
            {
               SetSolutionFromIndex(GetParticularWireIndex(2));
               solutionMessage = "Cut the second wire";
               whichStepDidWeGetTo = 5;
            }

            if (whichStepDidWeGetTo >= 1 &&
                GetNumberOfWiresOfColor(wireColor.Red) > 1)
            {
               displayOddSerialWarning = true;
            }
         }

         private void FiveWireLogic()
         {
            int whichStepDidWeGetTo = 0;

            // If the last wire is black and the last digit of the serial number
            // is odd, cut the fourth wire
            if (wires[GetLastWireIndex()] == wireColor.Black &&
                serialIsOdd.HasValue && serialIsOdd.Value)
            {
               SetSolutionFromIndex(GetParticularWireIndex(4));
               solutionMessage = "Cut the fourth wire";
               whichStepDidWeGetTo = 1;
            }
            // Otherwise, if there is exactly one red wire and there is more
            // than one yellow wire, cut the first wire
            else if (GetNumberOfWiresOfColor(wireColor.Red) == 1 &&
                     GetNumberOfWiresOfColor(wireColor.Yellow) > 1)
            {
               SetSolutionFromIndex(GetParticularWireIndex(1));
               solutionMessage = "Cut the first wire";
               whichStepDidWeGetTo = 2;
            }
            // Otherwise, if there are no black wires, cut the second wire
            else if (GetNumberOfWiresOfColor(wireColor.Black) == 0)
            {
               SetSolutionFromIndex(GetParticularWireIndex(2));
               solutionMessage = "Cut the second wire";
               whichStepDidWeGetTo = 3;
            }
            // Otherwise, cut the first wire
            else
            {
               SetSolutionFromIndex(GetParticularWireIndex(1));
               solutionMessage = "Cut the first wire";
               whichStepDidWeGetTo = 4;
            }

            if (whichStepDidWeGetTo >=1 &&
                wires[GetLastWireIndex()] == wireColor.Black)
            {
               displayOddSerialWarning = true;
            }
         }

         private void SixWireLogic()
         {
            int whichStepDidWeGetTo = 0;

            // If there are no yellow wires and the last digit of the serial
            // number is odd, cut the third wire
            if (GetNumberOfWiresOfColor(wireColor.Yellow) == 0 &&
                serialIsOdd.HasValue && serialIsOdd.Value)
            {
               SetSolutionFromIndex(GetParticularWireIndex(3));
               solutionMessage = "Cut the third wire";
               whichStepDidWeGetTo = 1;
            }
            // Otherwise, if there is exactly one yellow wire and there is more
            // than one white wire, cut the fourth wire
            else if (GetNumberOfWiresOfColor(wireColor.Yellow) == 1 &&
                     GetNumberOfWiresOfColor(wireColor.White) > 1)
            {
               SetSolutionFromIndex(GetParticularWireIndex(4));
               solutionMessage = "Cut the fourth wire";
               whichStepDidWeGetTo = 2;
            }
            // Otherwise, if there are no red wires, cut the last wire
            else if (GetNumberOfWiresOfColor(wireColor.Red) == 0)
            {
               SetSolutionFromIndex(GetLastWireIndex());
               solutionMessage = "Cut the last wire";
               whichStepDidWeGetTo = 3;
            }
            // Otherwise, cut the fourth wire
            else
            {
               SetSolutionFromIndex(GetParticularWireIndex(4));
               solutionMessage = "Cut the fourth wire";
               whichStepDidWeGetTo = 4;
            }

            if (whichStepDidWeGetTo >= 1 &&
                GetNumberOfWiresOfColor(wireColor.Yellow) == 0)
            {
               displayOddSerialWarning = true;
            }
         }

         private int GetNumberOfWires()
         {
            int numberOfWires = 0;
            foreach (wireColor wire in wires)
            {
               if (wire != wireColor.NoWire)
                  numberOfWires++;
            }

            return numberOfWires;
         }

         private int GetNumberOfWiresOfColor(wireColor color)
         {
            int numColorWires = 0;
            foreach (wireColor wire in wires)
            {
               if (wire == color)
                  numColorWires++;
            }

            return numColorWires;
         }

         private int GetParticularWireIndex(int whichWire)
         {
            for (int i = 0; i < wires.Count; ++i)
            {
               if (wires[i] != wireColor.NoWire)
               {
                  whichWire--;
               }

               if (whichWire <= 0)
               {
                  return i;
               }
            }

            return -1;
         }

         private int GetLastWireIndex()
         {
            for (int i = wires.Count - 1; i >= 0; --i)
            {
               if (wires[i] != wireColor.NoWire)
                  return i;
            }

            return -1;
         }

         private int GetLastWireIndexOfColor(wireColor color)
         {
            for (int i = wires.Count - 1; i >= 0; --i)
            {
               if (wires[i] == color)
                  return i;
            }

            return -1;
         }

         private void SetSolutionFromIndex(int index)
         {
            if (index == 0)
               solution = wireSolution.Wire1;
            else if (index == 1)
               solution = wireSolution.Wire2;
            else if (index == 2)
               solution = wireSolution.Wire3;
            else if (index == 3)
               solution = wireSolution.Wire4;
            else if (index == 4)
               solution = wireSolution.Wire5;
            else if (index == 5)
               solution = wireSolution.Wire6;
            else
               solution = wireSolution.NotEnoughWires;
         }

         public wireSolution Solution
         {
            get
            {
               return solution;
            }
         }

         public String SolutionMessage
         {
            get
            {
               return solutionMessage;
            }
         }

         public bool DisplayOddSerialWarning
         {
            get
            {
               return displayOddSerialWarning;
            }
         }

         public bool? SerialIsOdd
         {
            get
            {
               return serialIsOdd;
            }
            set
            {
               serialIsOdd = value;
               CalculateSolution();
            }
         }

         public void UpdateWire(int wireIndex, wireColor color)
         {
            wires[wireIndex] = color;
            CalculateSolution();
         }
      }

      private void resetWiresButton_Click(object sender, EventArgs e)
      {
         ResetComboBoxes();
      }

      private void WiresForm_FormClosing(object sender, FormClosingEventArgs e)
      {
         ((Form1)Owner).RemoveMeFromQueue(this);
      }

      private void blackButton1_CheckedChanged(object sender, EventArgs e)
      {
         if (blackButton1.Checked)
         {
            wireModule.UpdateWire(0, WiresModule.wireColor.Black);
            DisplayAnswers();
         }
      }

      private void blueButton1_CheckedChanged(object sender, EventArgs e)
      {
         if (blueButton1.Checked)
         {
            wireModule.UpdateWire(0, WiresModule.wireColor.Blue);
            DisplayAnswers();
         }
      }

      private void redButton1_CheckedChanged(object sender, EventArgs e)
      {
         if (redButton1.Checked)
         {
            wireModule.UpdateWire(0, WiresModule.wireColor.Red);
            DisplayAnswers();
         }
      }

      private void whiteButton1_CheckedChanged(object sender, EventArgs e)
      {
         if (whiteButton1.Checked)
         {
            wireModule.UpdateWire(0, WiresModule.wireColor.White);
            DisplayAnswers();
         }
      }

      private void yellowButton1_CheckedChanged(object sender, EventArgs e)
      {
         if (yellowButton1.Checked)
         {
            wireModule.UpdateWire(0, WiresModule.wireColor.Yellow);
            DisplayAnswers();
         }
      }

      private void blackButton2_CheckedChanged(object sender, EventArgs e)
      {
         if (blackButton2.Checked)
         {
            wireModule.UpdateWire(1, WiresModule.wireColor.Black);
            DisplayAnswers();
         }
      }

      private void blueButton2_CheckedChanged(object sender, EventArgs e)
      {
         if (blueButton2.Checked)
         {
            wireModule.UpdateWire(1, WiresModule.wireColor.Blue);
            DisplayAnswers();
         }
      }

      private void redButton2_CheckedChanged(object sender, EventArgs e)
      {
         if (redButton2.Checked)
         {
            wireModule.UpdateWire(1, WiresModule.wireColor.Red);
            DisplayAnswers();
         }
      }

      private void whiteButton2_CheckedChanged(object sender, EventArgs e)
      {
         if (whiteButton2.Checked)
         {
            wireModule.UpdateWire(1, WiresModule.wireColor.White);
            DisplayAnswers();
         }
      }

      private void yellowButton2_CheckedChanged(object sender, EventArgs e)
      {
         if (yellowButton2.Checked)
         {
            wireModule.UpdateWire(1, WiresModule.wireColor.Yellow);
            DisplayAnswers();
         }
      }

      private void blackButton3_CheckedChanged(object sender, EventArgs e)
      {
         if (blackButton3.Checked)
         {
            wireModule.UpdateWire(2, WiresModule.wireColor.Black);
            DisplayAnswers();
         }
      }

      private void blueButton3_CheckedChanged(object sender, EventArgs e)
      {
         if (blueButton3.Checked)
         {
            wireModule.UpdateWire(2, WiresModule.wireColor.Blue);
            DisplayAnswers();
         }
      }

      private void redButton3_CheckedChanged(object sender, EventArgs e)
      {
         if (redButton3.Checked)
         {
            wireModule.UpdateWire(2, WiresModule.wireColor.Red);
            DisplayAnswers();
         }
      }

      private void whiteButton3_CheckedChanged(object sender, EventArgs e)
      {
         if (whiteButton3.Checked)
         {
            wireModule.UpdateWire(2, WiresModule.wireColor.White);
            DisplayAnswers();
         }
      }

      private void yellowButton3_CheckedChanged(object sender, EventArgs e)
      {
         if (yellowButton3.Checked)
         {
            wireModule.UpdateWire(2, WiresModule.wireColor.Yellow);
            DisplayAnswers();
         }
      }

      private void blackButton4_CheckedChanged(object sender, EventArgs e)
      {
         if (blackButton4.Checked)
         {
            wireModule.UpdateWire(3, WiresModule.wireColor.Black);
            DisplayAnswers();
         }
      }

      private void blueButton4_CheckedChanged(object sender, EventArgs e)
      {
         if (blueButton4.Checked)
         {
            wireModule.UpdateWire(3, WiresModule.wireColor.Blue);
            DisplayAnswers();
         }
      }

      private void redButton4_CheckedChanged(object sender, EventArgs e)
      {
         if (redButton4.Checked)
         {
            wireModule.UpdateWire(3, WiresModule.wireColor.Red);
            DisplayAnswers();
         }
      }

      private void whiteButton4_CheckedChanged(object sender, EventArgs e)
      {
         if (whiteButton4.Checked)
         {
            wireModule.UpdateWire(3, WiresModule.wireColor.White);
            DisplayAnswers();
         }
      }

      private void yellowButton4_CheckedChanged(object sender, EventArgs e)
      {
         if (yellowButton4.Checked)
         {
            wireModule.UpdateWire(3, WiresModule.wireColor.Yellow);
            DisplayAnswers();
         }
      }

      private void blackButton5_CheckedChanged(object sender, EventArgs e)
      {
         if (blackButton5.Checked)
         {
            wireModule.UpdateWire(4, WiresModule.wireColor.Black);
            DisplayAnswers();
         }
      }

      private void blueButton5_CheckedChanged(object sender, EventArgs e)
      {
         if (blueButton5.Checked)
         {
            wireModule.UpdateWire(4, WiresModule.wireColor.Blue);
            DisplayAnswers();
         }
      }

      private void redButton5_CheckedChanged(object sender, EventArgs e)
      {
         if (redButton5.Checked)
         {
            wireModule.UpdateWire(4, WiresModule.wireColor.Red);
            DisplayAnswers();
         }
      }

      private void whiteButton5_CheckedChanged(object sender, EventArgs e)
      {
         if (whiteButton5.Checked)
         {
            wireModule.UpdateWire(4, WiresModule.wireColor.White);
            DisplayAnswers();
         }
      }

      private void yellowButton5_CheckedChanged(object sender, EventArgs e)
      {
         if (yellowButton5.Checked)
         {
            wireModule.UpdateWire(4, WiresModule.wireColor.Yellow);
            DisplayAnswers();
         }
      }

      private void blackButton6_CheckedChanged(object sender, EventArgs e)
      {
         if (blackButton6.Checked)
         {
            wireModule.UpdateWire(5, WiresModule.wireColor.Black);
            DisplayAnswers();
         }
      }

      private void blueButton6_CheckedChanged(object sender, EventArgs e)
      {
         if (blueButton6.Checked)
         {
            wireModule.UpdateWire(5, WiresModule.wireColor.Blue);
            DisplayAnswers();
         }
      }

      private void redButton6_CheckedChanged(object sender, EventArgs e)
      {
         if (redButton6.Checked)
         {
            wireModule.UpdateWire(5, WiresModule.wireColor.Red);
            DisplayAnswers();
         }
      }

      private void whiteButton6_CheckedChanged(object sender, EventArgs e)
      {
         if (whiteButton6.Checked)
         {
            wireModule.UpdateWire(5, WiresModule.wireColor.White);
            DisplayAnswers();
         }
      }

      private void yellowButton6_CheckedChanged(object sender, EventArgs e)
      {
         if (yellowButton6.Checked)
         {
            wireModule.UpdateWire(5, WiresModule.wireColor.Yellow);
            DisplayAnswers();
         }
      }
   }
}
