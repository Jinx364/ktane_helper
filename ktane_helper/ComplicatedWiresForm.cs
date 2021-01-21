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
   public partial class ComplicatedWiresForm : Form
   {
      private static ComplicatedWiresModule complicatedWiresModule;

      public ComplicatedWiresForm(BombInfo info)
      {
         InitializeComponent();
         InitializeModule(info);
      }

      private void InitializeModule(BombInfo info)
      {
         complicatedWiresModule = new ComplicatedWiresModule(info);
      }
      
      public void BombInfoUpdate(object sender, EventArgs e)
      {
         BombInfo info = sender as BombInfo;
         if (info != null)
         {
            complicatedWiresModule.NumBatteries = info.NumBatteries;
            complicatedWiresModule.LastSerialDigitIsOdd = info.LastSerialDigitIsOdd;
            complicatedWiresModule.HasParallelPort = info.HasParallelPort;
            DisplayAnswers();
         }
      }

      private void DisplayWarnings()
      {
         List<ComplicatedWiresModule.DisplayWarning> warnings =
            complicatedWiresModule.GetWarningsToDisplay();

         if (warnings.Contains(ComplicatedWiresModule.DisplayWarning.Batteries))
         {
            if (!complicatedWiresModule.NumBatteries.HasValue)
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

         if (warnings.Contains(ComplicatedWiresModule.DisplayWarning.ParallelPort))
         {
            if (!complicatedWiresModule.HasParallelPort.HasValue)
            {
               parallelInfoLabel.Font = new Font(parallelInfoLabel.Font, FontStyle.Bold);
               parallelInfoLabel.ForeColor = Color.Red;
            }
            else
            {
               parallelInfoLabel.Font = new Font(parallelInfoLabel.Font, FontStyle.Regular);
               parallelInfoLabel.ForeColor = Color.Black;
            }
            parallelInfoLabel.Visible = true;
         }
         else
         {
            parallelInfoLabel.Visible = false;
         }

         if (warnings.Contains(ComplicatedWiresModule.DisplayWarning.SerialIsEven))
         {
            if (!complicatedWiresModule.LastSerialDigitIsOdd.HasValue)
            {
               serialInfoLabel.Font = new Font(serialInfoLabel.Font, FontStyle.Bold);
               serialInfoLabel.ForeColor = Color.Red;
            }
            else
            {
               serialInfoLabel.Font = new Font(serialInfoLabel.Font, FontStyle.Regular);
               serialInfoLabel.ForeColor = Color.Black;
            }
            serialInfoLabel.Visible = true;
         }
         else
         {
            serialInfoLabel.Visible = false;
         }
      }

      private void DisplayAnswers()
      {
         for (int i = 1; i < 7; ++i)
         {
            DisplayAnswerForWire(i);
         }
      }

      private void DisplayAnswerForWire(int whichWire)
      {
         ComplicatedWiresModule.Wire wireInfo =
            complicatedWiresModule.GetWire(whichWire);

         if (whichWire == 1)
         {
            if (wireInfo.shouldBeCut)
            {
               richTextBox1.Clear();
               richTextBox1.SelectionColor = Color.Red;
               richTextBox1.AppendText("CUT");
            }
            else
            {
               richTextBox1.Clear();
               richTextBox1.SelectionColor = Color.LimeGreen;
               richTextBox1.AppendText("DON'T\nCUT");
            }
         }
         else if (whichWire == 2)
         {
            if (wireInfo.shouldBeCut)
            {
               richTextBox2.Clear();
               richTextBox2.SelectionColor = Color.Red;
               richTextBox2.AppendText("CUT");
            }
            else
            {
               richTextBox2.Clear();
               richTextBox2.SelectionColor = Color.LimeGreen;
               richTextBox2.AppendText("DON'T\nCUT");
            }
         }
         else if (whichWire == 3)
         {
            if (wireInfo.shouldBeCut)
            {
               richTextBox3.Clear();
               richTextBox3.SelectionColor = Color.Red;
               richTextBox3.AppendText("CUT");
            }
            else
            {
               richTextBox3.Clear();
               richTextBox3.SelectionColor = Color.LimeGreen;
               richTextBox3.AppendText("DON'T\nCUT");
            }
         }
         else if (whichWire == 4)
         {
            if (wireInfo.shouldBeCut)
            {
               richTextBox4.Clear();
               richTextBox4.SelectionColor = Color.Red;
               richTextBox4.AppendText("CUT");
            }
            else
            {
               richTextBox4.Clear();
               richTextBox4.SelectionColor = Color.LimeGreen;
               richTextBox4.AppendText("DON'T\nCUT");
            }
         }
         else if (whichWire == 5)
         {
            if (wireInfo.shouldBeCut)
            {
               richTextBox5.Clear();
               richTextBox5.SelectionColor = Color.Red;
               richTextBox5.AppendText("CUT");
            }
            else
            {
               richTextBox5.Clear();
               richTextBox5.SelectionColor = Color.LimeGreen;
               richTextBox5.AppendText("DON'T\nCUT");
            }
         }
         else if (whichWire == 6)
         {
            if (wireInfo.shouldBeCut)
            {
               richTextBox6.Clear();
               richTextBox6.SelectionColor = Color.Red;
               richTextBox6.AppendText("CUT");
            }
            else
            {
               richTextBox6.Clear();
               richTextBox6.SelectionColor = Color.LimeGreen;
               richTextBox6.AppendText("DON'T\nCUT");
            }
         }

         DisplayWarnings();
      }

      private class ComplicatedWiresModule
      {
         private int? numBatteries;
         private bool? hasParallelPort;
         private bool? lastSerialDigitIsOdd;
         private List<Wire> wires;
         private List<DisplayWarning> warningsToDisplay;

         public enum DisplayWarning
         {
              None
            , SerialIsEven
            , ParallelPort
            , Batteries
         }

         public ComplicatedWiresModule(BombInfo info)
         {
            numBatteries = info.NumBatteries;
            lastSerialDigitIsOdd = info.LastSerialDigitIsOdd;
            hasParallelPort = info.HasParallelPort;
            wires = new List<Wire> { new Wire(), new Wire(), new Wire(),
               new Wire(), new Wire(), new Wire() };
            warningsToDisplay = new List<DisplayWarning> { DisplayWarning.None,
               DisplayWarning.None, DisplayWarning.None, DisplayWarning.None,
               DisplayWarning.None, DisplayWarning.None };
         }

         public Wire GetWire(int whichWire)
         {
            return wires[whichWire - 1];
         }

         public List<DisplayWarning> GetWarningsToDisplay()
         {
            return warningsToDisplay;
         }

         public void UpdateWire(int whichWire, Wire wireInfo)
         {
            wires[whichWire - 1].ledIsOn = wireInfo.ledIsOn;
            wires[whichWire - 1].hasRedColoring = wireInfo.hasRedColoring;
            wires[whichWire - 1].hasBlueColoring = wireInfo.hasBlueColoring;
            wires[whichWire - 1].hasStarSymbol = wireInfo.hasStarSymbol;

            CalculateSolutionForWire(whichWire);
         }

         private void CalculateSolutionForWire(int whichWire)
         {
            if (wires[whichWire - 1].ledIsOn &&
                wires[whichWire - 1].hasRedColoring &&
                wires[whichWire - 1].hasBlueColoring &&
                wires[whichWire - 1].hasStarSymbol)
            {
               wires[whichWire - 1].shouldBeCut = false;
               warningsToDisplay[whichWire - 1] = DisplayWarning.None;
            }
            else if (!wires[whichWire - 1].ledIsOn &&
                     wires[whichWire - 1].hasRedColoring &&
                     wires[whichWire - 1].hasBlueColoring &&
                     wires[whichWire - 1].hasStarSymbol)
            {
               wires[whichWire - 1].shouldBeCut = CutIfParallelPort();
               warningsToDisplay[whichWire - 1] = DisplayWarning.ParallelPort;
            }
            else if (wires[whichWire - 1].ledIsOn &&
                     !wires[whichWire - 1].hasRedColoring &&
                     wires[whichWire - 1].hasBlueColoring &&
                     wires[whichWire - 1].hasStarSymbol)
            {
               wires[whichWire - 1].shouldBeCut = CutIfParallelPort();
               warningsToDisplay[whichWire - 1] = DisplayWarning.ParallelPort;
            }
            else if (wires[whichWire - 1].ledIsOn &&
                     wires[whichWire - 1].hasRedColoring &&
                     !wires[whichWire - 1].hasBlueColoring &&
                     wires[whichWire - 1].hasStarSymbol)
            {
               wires[whichWire - 1].shouldBeCut = CutIfTwoOrMoreBatteries();
               warningsToDisplay[whichWire - 1] = DisplayWarning.Batteries;
            }
            else if (wires[whichWire - 1].ledIsOn &&
                     wires[whichWire - 1].hasRedColoring &&
                     wires[whichWire - 1].hasBlueColoring &&
                     !wires[whichWire - 1].hasStarSymbol)
            {
               wires[whichWire - 1].shouldBeCut = CutIfSerialIsEven();
               warningsToDisplay[whichWire - 1] = DisplayWarning.SerialIsEven;
            }
            else if (!wires[whichWire - 1].ledIsOn &&
                     !wires[whichWire - 1].hasRedColoring &&
                     wires[whichWire - 1].hasBlueColoring &&
                     wires[whichWire - 1].hasStarSymbol)
            {
               wires[whichWire - 1].shouldBeCut = false;
               warningsToDisplay[whichWire - 1] = DisplayWarning.None;
            }
            else if (!wires[whichWire - 1].ledIsOn &&
                     wires[whichWire - 1].hasRedColoring &&
                     !wires[whichWire - 1].hasBlueColoring &&
                     wires[whichWire - 1].hasStarSymbol)
            {
               wires[whichWire - 1].shouldBeCut = true;
               warningsToDisplay[whichWire - 1] = DisplayWarning.None;
            }
            else if (!wires[whichWire - 1].ledIsOn &&
                     wires[whichWire - 1].hasRedColoring &&
                     wires[whichWire - 1].hasBlueColoring &&
                     !wires[whichWire - 1].hasStarSymbol)
            {
               wires[whichWire - 1].shouldBeCut = CutIfSerialIsEven();
               warningsToDisplay[whichWire - 1] = DisplayWarning.SerialIsEven;
            }
            else if (wires[whichWire - 1].ledIsOn &&
                     !wires[whichWire - 1].hasRedColoring &&
                     !wires[whichWire - 1].hasBlueColoring &&
                     wires[whichWire - 1].hasStarSymbol)
            {
               wires[whichWire - 1].shouldBeCut = CutIfTwoOrMoreBatteries();
               warningsToDisplay[whichWire - 1] = DisplayWarning.Batteries;
            }
            else if (wires[whichWire - 1].ledIsOn &&
                     !wires[whichWire - 1].hasRedColoring &&
                     wires[whichWire - 1].hasBlueColoring &&
                     !wires[whichWire - 1].hasStarSymbol)
            {
               wires[whichWire - 1].shouldBeCut = CutIfParallelPort();
               warningsToDisplay[whichWire - 1] = DisplayWarning.ParallelPort;
            }
            else if (wires[whichWire - 1].ledIsOn &&
                     wires[whichWire - 1].hasRedColoring &&
                     !wires[whichWire - 1].hasBlueColoring &&
                     !wires[whichWire - 1].hasStarSymbol)
            {
               wires[whichWire - 1].shouldBeCut = CutIfTwoOrMoreBatteries();
               warningsToDisplay[whichWire - 1] = DisplayWarning.Batteries;
            }
            else if (wires[whichWire - 1].ledIsOn &&
                     !wires[whichWire - 1].hasRedColoring &&
                     !wires[whichWire - 1].hasBlueColoring &&
                     !wires[whichWire - 1].hasStarSymbol)
            {
               wires[whichWire - 1].shouldBeCut = false;
               warningsToDisplay[whichWire - 1] = DisplayWarning.None;
            }
            else if (!wires[whichWire - 1].ledIsOn &&
                     wires[whichWire - 1].hasRedColoring &&
                     !wires[whichWire - 1].hasBlueColoring &&
                     !wires[whichWire - 1].hasStarSymbol)
            {
               wires[whichWire - 1].shouldBeCut = CutIfSerialIsEven();
               warningsToDisplay[whichWire - 1] = DisplayWarning.SerialIsEven;
            }
            else if (!wires[whichWire - 1].ledIsOn &&
                     !wires[whichWire - 1].hasRedColoring &&
                     wires[whichWire - 1].hasBlueColoring &&
                     !wires[whichWire - 1].hasStarSymbol)
            {
               wires[whichWire - 1].shouldBeCut = CutIfSerialIsEven();
               warningsToDisplay[whichWire - 1] = DisplayWarning.SerialIsEven;
            }
            else if (!wires[whichWire - 1].ledIsOn &&
                     !wires[whichWire - 1].hasRedColoring &&
                     !wires[whichWire - 1].hasBlueColoring &&
                     wires[whichWire - 1].hasStarSymbol)
            {
               wires[whichWire - 1].shouldBeCut = true;
               warningsToDisplay[whichWire - 1] = DisplayWarning.None;
            }
            else if (!wires[whichWire - 1].ledIsOn &&
                     !wires[whichWire - 1].hasRedColoring &&
                     !wires[whichWire - 1].hasBlueColoring &&
                     !wires[whichWire - 1].hasStarSymbol)
            {
               wires[whichWire - 1].shouldBeCut = true;
               warningsToDisplay[whichWire - 1] = DisplayWarning.None;
            }
         }

         private bool CutIfSerialIsEven()
         {
            if (lastSerialDigitIsOdd.HasValue && !lastSerialDigitIsOdd.Value)
            {
               return true;
            }
            else
            {
               return false;
            }
         }

         private bool CutIfParallelPort()
         {
            if (hasParallelPort.HasValue && hasParallelPort.Value)
            {
               return true;
            }
            else
            {
               return false;
            }
         }

         private bool CutIfTwoOrMoreBatteries()
         {
            if (numBatteries.HasValue && numBatteries.Value >= 2)
            {
               return true;
            }
            else
            {
               return false;
            }
         }

         private void CalculateSolutionForAllWires()
         {
            for (int i = 1; i < 7; ++i)
            {
               CalculateSolutionForWire(i);
            }
         }

         public int? NumBatteries
         {
            get
            {
               return numBatteries;
            }
            set
            {
               numBatteries = value;
               CalculateSolutionForAllWires();
            }
         }

         public bool? HasParallelPort
         {
            get
            {
               return hasParallelPort;
            }
            set
            {
               hasParallelPort = value;
               CalculateSolutionForAllWires();
            }
         }

         public bool? LastSerialDigitIsOdd
         {
            get
            {
               return lastSerialDigitIsOdd;
            }
            set
            {
               lastSerialDigitIsOdd = value;
               CalculateSolutionForAllWires();
            }
         }

         public class Wire
         {
            public bool ledIsOn;
            public bool hasBlueColoring;
            public bool hasRedColoring;
            public bool hasStarSymbol;
            public bool shouldBeCut;

            public Wire()
            {
               ledIsOn = false;
               hasBlueColoring = false;
               hasRedColoring = false;
               hasStarSymbol = false;
               shouldBeCut = true;
            }
         }
      }

      private ComplicatedWiresModule.Wire GetWireStatus(int whichWire)
      {
         ComplicatedWiresModule.Wire wireInfo = new ComplicatedWiresModule.Wire();

         if (whichWire == 1)
         {
            if (led1CheckBox.Checked)
               wireInfo.ledIsOn = true;
            if (red1CheckBox.Checked)
               wireInfo.hasRedColoring = true;
            if (blue1CheckBox.Checked)
               wireInfo.hasBlueColoring = true;
            if (star1CheckBox.Checked)
               wireInfo.hasStarSymbol = true;
         }
         else if (whichWire == 2)
         {
            if (led2CheckBox.Checked)
               wireInfo.ledIsOn = true;
            if (red2CheckBox.Checked)
               wireInfo.hasRedColoring = true;
            if (blue2CheckBox.Checked)
               wireInfo.hasBlueColoring = true;
            if (star2CheckBox.Checked)
               wireInfo.hasStarSymbol = true;
         }
         else if (whichWire == 3)
         {
            if (led3CheckBox.Checked)
               wireInfo.ledIsOn = true;
            if (red3CheckBox.Checked)
               wireInfo.hasRedColoring = true;
            if (blue3CheckBox.Checked)
               wireInfo.hasBlueColoring = true;
            if (star3CheckBox.Checked)
               wireInfo.hasStarSymbol = true;
         }
         else if (whichWire == 4)
         {
            if (led4CheckBox.Checked)
               wireInfo.ledIsOn = true;
            if (red4CheckBox.Checked)
               wireInfo.hasRedColoring = true;
            if (blue4CheckBox.Checked)
               wireInfo.hasBlueColoring = true;
            if (star4CheckBox.Checked)
               wireInfo.hasStarSymbol = true;
         }
         else if (whichWire == 5)
         {
            if (led5CheckBox.Checked)
               wireInfo.ledIsOn = true;
            if (red5CheckBox.Checked)
               wireInfo.hasRedColoring = true;
            if (blue5CheckBox.Checked)
               wireInfo.hasBlueColoring = true;
            if (star5CheckBox.Checked)
               wireInfo.hasStarSymbol = true;
         }
         else if (whichWire == 6)
         {
            if (led6CheckBox.Checked)
               wireInfo.ledIsOn = true;
            if (red6CheckBox.Checked)
               wireInfo.hasRedColoring = true;
            if (blue6CheckBox.Checked)
               wireInfo.hasBlueColoring = true;
            if (star6CheckBox.Checked)
               wireInfo.hasStarSymbol = true;
         }

         return wireInfo;
      }

      private void led1CheckBox_CheckedChanged(object sender, EventArgs e)
      {
         complicatedWiresModule.UpdateWire(1, GetWireStatus(1));
         DisplayAnswerForWire(1);
      }

      private void red1CheckBox_CheckedChanged(object sender, EventArgs e)
      {
         complicatedWiresModule.UpdateWire(1, GetWireStatus(1));
         DisplayAnswerForWire(1);
      }

      private void blue1CheckBox_CheckedChanged(object sender, EventArgs e)
      {
         complicatedWiresModule.UpdateWire(1, GetWireStatus(1));
         DisplayAnswerForWire(1);
      }

      private void star1CheckBox_CheckedChanged(object sender, EventArgs e)
      {
         complicatedWiresModule.UpdateWire(1, GetWireStatus(1));
         DisplayAnswerForWire(1);
      }

      private void led2CheckBox_CheckedChanged(object sender, EventArgs e)
      {
         complicatedWiresModule.UpdateWire(2, GetWireStatus(2));
         DisplayAnswerForWire(2);
      }

      private void red2CheckBox_CheckedChanged(object sender, EventArgs e)
      {
         complicatedWiresModule.UpdateWire(2, GetWireStatus(2));
         DisplayAnswerForWire(2);
      }

      private void blue2CheckBox_CheckedChanged(object sender, EventArgs e)
      {
         complicatedWiresModule.UpdateWire(2, GetWireStatus(2));
         DisplayAnswerForWire(2);
      }

      private void star2CheckBox_CheckedChanged(object sender, EventArgs e)
      {
         complicatedWiresModule.UpdateWire(2, GetWireStatus(2));
         DisplayAnswerForWire(2);
      }

      private void led3CheckBox_CheckedChanged(object sender, EventArgs e)
      {
         complicatedWiresModule.UpdateWire(3, GetWireStatus(3));
         DisplayAnswerForWire(3);
      }

      private void red3CheckBox_CheckedChanged(object sender, EventArgs e)
      {
         complicatedWiresModule.UpdateWire(3, GetWireStatus(3));
         DisplayAnswerForWire(3);
      }

      private void blue3CheckBox_CheckedChanged(object sender, EventArgs e)
      {
         complicatedWiresModule.UpdateWire(3, GetWireStatus(3));
         DisplayAnswerForWire(3);
      }

      private void star3CheckBox_CheckedChanged(object sender, EventArgs e)
      {
         complicatedWiresModule.UpdateWire(3, GetWireStatus(3));
         DisplayAnswerForWire(3);
      }

      private void led4CheckBox_CheckedChanged(object sender, EventArgs e)
      {
         complicatedWiresModule.UpdateWire(4, GetWireStatus(4));
         DisplayAnswerForWire(4);
      }

      private void red4CheckBox_CheckedChanged(object sender, EventArgs e)
      {
         complicatedWiresModule.UpdateWire(4, GetWireStatus(4));
         DisplayAnswerForWire(4);
      }

      private void blue4CheckBox_CheckedChanged(object sender, EventArgs e)
      {
         complicatedWiresModule.UpdateWire(4, GetWireStatus(4));
         DisplayAnswerForWire(4);
      }

      private void star4CheckBox_CheckedChanged(object sender, EventArgs e)
      {
         complicatedWiresModule.UpdateWire(4, GetWireStatus(4));
         DisplayAnswerForWire(4);
      }

      private void led5CheckBox_CheckedChanged(object sender, EventArgs e)
      {
         complicatedWiresModule.UpdateWire(5, GetWireStatus(5));
         DisplayAnswerForWire(5);
      }

      private void red5CheckBox_CheckedChanged(object sender, EventArgs e)
      {
         complicatedWiresModule.UpdateWire(5, GetWireStatus(5));
         DisplayAnswerForWire(5);
      }

      private void blue5CheckBox_CheckedChanged(object sender, EventArgs e)
      {
         complicatedWiresModule.UpdateWire(5, GetWireStatus(5));
         DisplayAnswerForWire(5);
      }

      private void star5CheckBox_CheckedChanged(object sender, EventArgs e)
      {
         complicatedWiresModule.UpdateWire(5, GetWireStatus(5));
         DisplayAnswerForWire(5);
      }

      private void led6CheckBox_CheckedChanged(object sender, EventArgs e)
      {
         complicatedWiresModule.UpdateWire(6, GetWireStatus(6));
         DisplayAnswerForWire(6);
      }

      private void red6CheckBox_CheckedChanged(object sender, EventArgs e)
      {
         complicatedWiresModule.UpdateWire(6, GetWireStatus(6));
         DisplayAnswerForWire(6);
      }

      private void blue6CheckBox_CheckedChanged(object sender, EventArgs e)
      {
         complicatedWiresModule.UpdateWire(6, GetWireStatus(6));
         DisplayAnswerForWire(6);
      }

      private void star6CheckBox_CheckedChanged(object sender, EventArgs e)
      {
         complicatedWiresModule.UpdateWire(6, GetWireStatus(6));
         DisplayAnswerForWire(6);
      }

      private void ComplicatedWiresForm_FormClosing(object sender, FormClosingEventArgs e)
      {
         ((Form1)Owner).RemoveMeFromQueue(this);
      }
   }
}
