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
   public partial class WireSequenceForm : Form
   {
      private static WireSequenceModule wireSequenceModule;
      private int redSeq;
      private int blueSeq;
      private int blackSeq;

      public WireSequenceForm()
      {
         InitializeComponent();
         InitializeModule();
         InitializeInstructions();

         redSeq = 1;
         blueSeq = 1;
         blackSeq = 1;

         UpdateAllControls();
      }

      private void UpdateAllControls()
      {
         UpdateRedControls();
         UpdateBlueControls();
         UpdateBlackControls();
      }

      private void UpdateRedControls()
      {
         redOccurTextBox.Text = redSeq.ToString();
         redCutTextBox.Text =
            wireSequenceModule.GetSolution(redSeq, WireSequenceModule.wireColor.Red);

         if (redSeq == 1)
         {
            redPrevButton.Enabled = false;
         }
         else
         {
            redPrevButton.Enabled = true;
         }

         if (redSeq == 9)
         {
            redNextButton.Enabled = false;
         }
         else
         {
            redNextButton.Enabled = true;
         }
      }

      private void UpdateBlueControls()
      {
         blueOccurTextBox.Text = blueSeq.ToString();
         blueCutTextBox.Text =
            wireSequenceModule.GetSolution(blueSeq, WireSequenceModule.wireColor.Blue);

         if (blueSeq == 1)
         {
            bluePrevButton.Enabled = false;
         }
         else
         {
            bluePrevButton.Enabled = true;
         }

         if (blueSeq == 9)
         {
            blueNextButton.Enabled = false;
         }
         else
         {
            blueNextButton.Enabled = true;
         }
      }

      private void UpdateBlackControls()
      {
         blackOccurTextBox.Text = blackSeq.ToString();
         blackCutTextBox.Text =
            wireSequenceModule.GetSolution(blackSeq, WireSequenceModule.wireColor.Black);

         if (blackSeq == 1)
         {
            blackPrevButton.Enabled = false;
         }
         else
         {
            blackPrevButton.Enabled = true;
         }

         if (blackSeq == 9)
         {
            blackNextButton.Enabled = false;
         }
         else
         {
            blackNextButton.Enabled = true;
         }
      }

      private void InitializeModule()
      {
         wireSequenceModule = new WireSequenceModule();
      }

      private void InitializeInstructions()
      {
         instructionsTextBox.AppendText("● Within this module there are several panels with wires on them, but only one panel is visible at a time. Switch to the next panel by using the down button and the previous panel by using the up button.");
         instructionsTextBox.AppendText("\n● Do not switch to the next panel until you are sure that you have cut all necessary wires on the current panel.");
         instructionsTextBox.AppendText("\n● Cut the wires as directed by the following table. Wire occurrences are cumulative over all panels within the module.");
      }

      private class WireSequenceModule
      {
         public enum wireColor
         {
              Invalid
            , Red
            , Blue
            , Black
         }

         private const String aStr = "A";
         private const String bStr = "B";
         private const String cStr = "C";
         private const String abStr = "A or B";
         private const String acStr = "A or C";
         private const String bcStr = "B or C";
         private const String abcStr = "A, B or C";

         private static readonly List<String> redSeq =
            new List<String> { cStr, bStr, aStr, acStr, bStr, acStr, abcStr,
            abStr, bStr };

         private static readonly List<String> blueSeq =
            new List<String> { bStr, acStr, bStr, aStr, bStr, bcStr, cStr,
            acStr, aStr };

         private static readonly List<String> blackSeq =
            new List<String> { abcStr, acStr, bStr, acStr, bStr, bcStr, abStr,
            cStr, cStr };

         public String GetSolution(int seq, wireColor color)
         {
            if (color == wireColor.Red)
               return redSeq[seq - 1];
            else if (color == wireColor.Blue)
               return blueSeq[seq - 1];
            else if (color == wireColor.Black)
               return blackSeq[seq - 1];
            else
               return "";
         }
      }

      private void redPrevButton_Click(object sender, EventArgs e)
      {
         redSeq--;
         UpdateRedControls();
      }

      private void redNextButton_Click(object sender, EventArgs e)
      {
         redSeq++;
         UpdateRedControls();
      }

      private void bluePrevButton_Click(object sender, EventArgs e)
      {
         blueSeq--;
         UpdateBlueControls();
      }

      private void blueNextButton_Click(object sender, EventArgs e)
      {
         blueSeq++;
         UpdateBlueControls();
      }

      private void blackPrevButton_Click(object sender, EventArgs e)
      {
         blackSeq--;
         UpdateBlackControls();
      }

      private void blackNextButton_Click(object sender, EventArgs e)
      {
         blackSeq++;
         UpdateBlackControls();
      }
   }
}
