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
   public partial class WhosOnFirstForm : Form
   {
      private static WhosOnFirstModule whosOnFirstModule;

      private const String blankStr = "BLANK";
      private const String ceeStr = "CEE";
      private const String cStr = "C";
      private const String displayStr = "DISPLAY";
      private const String doneStr = "DONE";
      private const String emptyStr = "";
      private const String firstStr = "FIRST";
      private const String holdStr = "HOLD";
      private const String holdOnStr = "HOLD ON";
      private const String leadStr = "LEAD";
      private const String ledStr = "LED";
      private const String leedStr = "LEED";
      private const String leftStr = "LEFT";
      private const String likeStr = "LIKE";
      private const String middleStr = "MIDDLE";
      private const String nextStr = "NEXT";
      private const String noStr = "NO";
      private const String nothingStr = "NOTHING";
      private const String okayStr = "OKAY";
      private const String pressStr = "PRESS";
      private const String readStr = "READ";
      private const String readyStr = "READY";
      private const String redStr = "RED";
      private const String reedStr = "REED";
      private const String rightStr = "RIGHT";
      private const String saysStr = "SAYS";
      private const String seeStr = "SEE";
      private const String sureStr = "SURE";
      private const String theirStr = "THEIR";
      private const String thereStr = "THERE";
      private const String theyareStr = "THEY ARE";
      private const String theyreStr = "THEY'RE";
      private const String uStr = "U";
      private const String uhHuhStr = "UH HUH";
      private const String uhUhStr = "UH UH";
      private const String uhhhStr = "UHHH";
      private const String urStr = "UR";
      private const String waitStr = "WAIT";
      private const String whatStr = "WHAT";
      private const String whatQStr = "WHAT?";
      private const String yesStr = "YES";
      private const String youAreStr = "YOU ARE";
      private const String youreStr = "YOU'RE";
      private const String yourStr = "YOUR";
      private const String youStr = "YOU";

      public WhosOnFirstForm()
      {
         InitializeComponent();
         InitializeModule();
      }

      private void InitializeModule()
      {
         whosOnFirstModule = new WhosOnFirstModule();
      }


      // Who's On First Module
      private class WhosOnFirstModule
      {
         private static readonly List<String> solutionReady =
            new List<String> { yesStr, okayStr, whatStr, middleStr, leftStr,
            pressStr, rightStr, blankStr, readyStr, noStr, firstStr, uhhhStr,
            nothingStr, waitStr };

         private static readonly List<String> solutionFirst =
            new List<String> { leftStr, okayStr, yesStr, middleStr, noStr,
            rightStr, nothingStr, uhhhStr, waitStr, readyStr, blankStr,
            whatStr, pressStr, firstStr };

         private static readonly List<String> solutionNo =
            new List<String> { blankStr, uhhhStr, waitStr, firstStr, whatStr,
            readyStr, rightStr, yesStr, nothingStr, leftStr, pressStr, okayStr,
            noStr, middleStr };

         private static readonly List<String> solutionBlank =
            new List<String> { waitStr, rightStr, okayStr, middleStr, blankStr,
            pressStr, readyStr, nothingStr, noStr, whatStr, leftStr, uhhhStr,
            yesStr, firstStr };

         private static readonly List<String> solutionNothing =
            new List<String> { uhhhStr, rightStr, okayStr, middleStr, yesStr,
            blankStr, noStr, pressStr, leftStr, whatStr, waitStr, firstStr,
            nothingStr, readyStr };

         private static readonly List<String> solutionYes =
            new List<String> { okayStr, rightStr, uhhhStr, middleStr, firstStr,
            whatStr, pressStr, readyStr, nothingStr, yesStr, leftStr, blankStr,
            noStr, waitStr };

         private static readonly List<String> solutionWhat =
            new List<String> { uhhhStr, whatStr, leftStr, nothingStr, readyStr,
            blankStr, middleStr, noStr, okayStr, firstStr, waitStr, yesStr,
            pressStr, rightStr };

         private static readonly List<String> solutionUhhh =
            new List<String> { readyStr, nothingStr, leftStr, whatStr, okayStr,
            yesStr, rightStr, noStr, pressStr, blankStr, uhhhStr, middleStr,
            waitStr, firstStr };

         private static readonly List<String> solutionLeft =
            new List<String> { rightStr, leftStr, firstStr, noStr, middleStr,
            yesStr, blankStr, whatStr, uhhhStr, waitStr, pressStr, readyStr,
            okayStr, nothingStr };

         private static readonly List<String> solutionRight =
            new List<String> { yesStr, nothingStr, readyStr, pressStr, noStr,
            waitStr, whatStr, rightStr, middleStr, leftStr, uhhhStr, blankStr,
            okayStr, firstStr };

         private static readonly List<String> solutionMiddle =
            new List<String> { blankStr, readyStr, okayStr, whatStr, nothingStr,
            pressStr, noStr, waitStr, leftStr, middleStr, rightStr, firstStr,
            uhhhStr, yesStr };

         private static readonly List<String> solutionOkay =
            new List<String> { middleStr, noStr, firstStr, yesStr, uhhhStr,
            nothingStr, waitStr, okayStr, leftStr, readyStr, blankStr,
            pressStr, whatStr, rightStr };

         private static readonly List<String> solutionWait =
            new List<String> { uhhhStr, noStr, blankStr, okayStr, yesStr,
            leftStr, firstStr, pressStr, whatStr, waitStr, nothingStr, readyStr,
            rightStr, middleStr };

         private static readonly List<String> solutionPress =
            new List<String> { rightStr, middleStr, yesStr, readyStr, pressStr,
            okayStr, nothingStr, uhhhStr, blankStr, leftStr, firstStr, whatStr,
            noStr, waitStr };

         private static readonly List<String> solutionYou =
            new List<String> { sureStr, youAreStr, yourStr, youreStr, nextStr,
            uhHuhStr, urStr, holdStr, whatQStr, youStr, uhUhStr, likeStr,
            doneStr, uStr };

         private static readonly List<String> solutionYouAre =
            new List<String> { yourStr, nextStr, likeStr, uhHuhStr, whatQStr,
            doneStr, uhUhStr, holdStr, youStr, uStr, youreStr, sureStr,
            urStr, youAreStr };

         private static readonly List<String> solutionYour =
            new List<String> { uhUhStr, youAreStr, uhHuhStr, yourStr, nextStr,
            urStr, sureStr, uStr, youreStr, youStr, whatQStr, holdStr, likeStr,
            doneStr };

         private static readonly List<String> solutionYoure =
            new List<String> { youStr, youreStr, urStr, nextStr, uhUhStr,
            youAreStr, uStr, yourStr, whatQStr, uhHuhStr, sureStr, doneStr,
            likeStr, holdStr };

         private static readonly List<String> solutionUr =
            new List<String> { doneStr, uStr, urStr, uhHuhStr, whatQStr,
            sureStr, yourStr, holdStr, youreStr, likeStr, nextStr, uhUhStr,
            youAreStr, youStr };

         private static readonly List<String> solutionU =
            new List<String> { uhHuhStr, sureStr, nextStr, whatQStr, youreStr,
            urStr, uhUhStr, doneStr, uStr, youStr, likeStr, holdStr, youAreStr,
            yourStr };

         private static readonly List<String> solutionUhHuh =
            new List<String> { uhHuhStr, yourStr, youAreStr, youStr, doneStr,
            holdStr, uhUhStr, nextStr, sureStr, likeStr, youreStr, urStr,
            uStr, whatQStr };

         private static readonly List<String> solutionUhUh =
            new List<String> { urStr, uStr, youAreStr, youreStr, nextStr,
            uhUhStr, doneStr, youStr, uhHuhStr, likeStr, yourStr, sureStr,
            holdStr, whatQStr };

         private static readonly List<String> solutionWhatQ =
            new List<String> { youStr, holdStr, youreStr, yourStr, uStr,
            doneStr, uhUhStr, likeStr, youAreStr, uhHuhStr, urStr, nextStr,
            whatQStr, sureStr };

         private static readonly List<String> solutionDone =
            new List<String> { sureStr, uhHuhStr, nextStr, whatQStr, yourStr,
            urStr, youreStr, holdStr, likeStr, youStr, uStr, youAreStr,
            uhUhStr, doneStr };

         private static readonly List<String> solutionNext =
            new List<String> { whatQStr, uhHuhStr, uhUhStr, yourStr, holdStr,
            sureStr, nextStr, likeStr, doneStr, youAreStr, urStr, youreStr,
            uStr, youStr };

         private static readonly List<String> solutionHold =
            new List<String> { youAreStr, uStr, doneStr, uhUhStr, youStr,
            urStr, sureStr, whatQStr, youreStr, nextStr, holdStr, uhHuhStr,
            yourStr, likeStr };

         private static readonly List<String> solutionSure =
            new List<String> { youAreStr, doneStr, likeStr, youreStr, youStr,
            holdStr, uhHuhStr, urStr, sureStr, uStr, whatQStr, nextStr,
            yourStr, uhUhStr };

         private static readonly List<String> solutionLike =
            new List<String> { youreStr, nextStr, uStr, urStr, holdStr, doneStr,
            uhUhStr, whatQStr, uhHuhStr, youStr, likeStr, sureStr, youAreStr,
            yourStr };

         public Image GetStepTwoImage(String str)
         {
            Image retImage = null;

            if (str == urStr)
            {
               retImage = Properties.Resources.who_up_left;
            }
            else if (str == firstStr ||
                     str == okayStr ||
                     str == cStr)
            {
               retImage = Properties.Resources.who_up_right;
            }
            else if (str == yesStr ||
                     str == nothingStr ||
                     str == ledStr ||
                     str == theyareStr)
            {
               retImage = Properties.Resources.who_mid_left;
            }
            else if (str == blankStr ||
                     str == readStr ||
                     str == redStr ||
                     str == youStr ||
                     str == yourStr ||
                     str == youreStr ||
                     str == theirStr)
            {
               retImage = Properties.Resources.who_mid_right;
            }
            else if (str == emptyStr ||
                     str == reedStr ||
                     str == leedStr ||
                     str == theyreStr)
            {
               retImage = Properties.Resources.who_down_left;
            }
            else if (str == displayStr ||
                     str == saysStr ||
                     str == noStr ||
                     str == leadStr ||
                     str == holdOnStr ||
                     str == youAreStr ||
                     str == thereStr ||
                     str == seeStr ||
                     str == ceeStr)
            {
               retImage = Properties.Resources.who_down_right;
            }

            return retImage;
         }

         public List<String> GetSolutionList(String str)
         {
            switch (str)
            {
               case readyStr:
                  return solutionReady;
               case firstStr:
                  return solutionFirst;
               case noStr:
                  return solutionNo;
               case blankStr:
                  return solutionBlank;
               case nothingStr:
                  return solutionNothing;
               case yesStr:
                  return solutionYes;
               case whatStr:
                  return solutionWhat;
               case uhhhStr:
                  return solutionUhhh;
               case leftStr:
                  return solutionLeft;
               case rightStr:
                  return solutionRight;
               case middleStr:
                  return solutionMiddle;
               case okayStr:
                  return solutionOkay;
               case waitStr:
                  return solutionWait;
               case pressStr:
                  return solutionPress;
               case youStr:
                  return solutionYou;
               case youAreStr:
                  return solutionYouAre;
               case yourStr:
                  return solutionYour;
               case youreStr:
                  return solutionYoure;
               case urStr:
                  return solutionUr;
               case uStr:
                  return solutionU;
               case uhHuhStr:
                  return solutionUhHuh;
               case uhUhStr:
                  return solutionUhUh;
               case whatQStr:
                  return solutionWhatQ;
               case doneStr:
                  return solutionDone;
               case nextStr:
                  return solutionNext;
               case holdStr:
                  return solutionHold;
               case sureStr:
                  return solutionSure;
               case likeStr:
                  return solutionLike;
               default:
                  break;
            }
            

            return null;
         }
      }

      private void LoadStepTwoImage(Image img)
      {
         step2PictureBox.Image = img;
         step2PictureBox.Invalidate();
      }

      private void ResetTextBox2()
      {
         textBox2.Text = "*perform step 2*";
      }

      private void PrintSolution(List<String> solution)
      {
         solutionRichTextBox.Clear();
         foreach (String str in solution)
         {
            if (solutionRichTextBox.Text.Length > 0)
            {
               solutionRichTextBox.AppendText(", ");
            }

            solutionRichTextBox.AppendText(str);
         }
      }

      private void ZDisplayButton_Click(object sender, EventArgs e)
      {
         textBox1.Text = displayStr;
         LoadStepTwoImage(whosOnFirstModule.GetStepTwoImage(displayStr));
         ResetTextBox2();
         solutionRichTextBox.Clear();
      }

      private void ZFirstButton_Click(object sender, EventArgs e)
      {
         textBox1.Text = firstStr;
         LoadStepTwoImage(whosOnFirstModule.GetStepTwoImage(firstStr));
         ResetTextBox2();
         solutionRichTextBox.Clear();
      }

      private void ZHoldOnButton_Click(object sender, EventArgs e)
      {
         textBox1.Text = holdOnStr;
         LoadStepTwoImage(whosOnFirstModule.GetStepTwoImage(holdOnStr));
         ResetTextBox2();
         solutionRichTextBox.Clear();
      }

      private void ZNoButton_Click(object sender, EventArgs e)
      {
         textBox1.Text = noStr;
         LoadStepTwoImage(whosOnFirstModule.GetStepTwoImage(noStr));
         ResetTextBox2();
         solutionRichTextBox.Clear();
      }

      private void ZOkayButton_Click(object sender, EventArgs e)
      {
         textBox1.Text = okayStr;
         LoadStepTwoImage(whosOnFirstModule.GetStepTwoImage(okayStr));
         ResetTextBox2();
         solutionRichTextBox.Clear();
      }

      private void ZSaysButton_Click(object sender, EventArgs e)
      {
         textBox1.Text = saysStr;
         LoadStepTwoImage(whosOnFirstModule.GetStepTwoImage(saysStr));
         ResetTextBox2();
         solutionRichTextBox.Clear();
      }

      private void ZYesButton_Click(object sender, EventArgs e)
      {
         textBox1.Text = yesStr;
         LoadStepTwoImage(whosOnFirstModule.GetStepTwoImage(yesStr));
         ResetTextBox2();
         solutionRichTextBox.Clear();
      }

      private void ZEmptyButton_Click(object sender, EventArgs e)
      {
         textBox1.Text = emptyStr;
         LoadStepTwoImage(whosOnFirstModule.GetStepTwoImage(emptyStr));
         ResetTextBox2();
         solutionRichTextBox.Clear();
      }

      private void ZBlankButton_Click(object sender, EventArgs e)
      {
         textBox1.Text = blankStr;
         LoadStepTwoImage(whosOnFirstModule.GetStepTwoImage(blankStr));
         ResetTextBox2();
         solutionRichTextBox.Clear();
      }

      private void ZNothingButton_Click(object sender, EventArgs e)
      {
         textBox1.Text = nothingStr;
         LoadStepTwoImage(whosOnFirstModule.GetStepTwoImage(nothingStr));
         ResetTextBox2();
         solutionRichTextBox.Clear();
      }

      private void ZLeadButton_Click(object sender, EventArgs e)
      {
         textBox1.Text = leadStr;
         LoadStepTwoImage(whosOnFirstModule.GetStepTwoImage(leadStr));
         ResetTextBox2();
         solutionRichTextBox.Clear();
      }

      private void ZLedButton_Click(object sender, EventArgs e)
      {
         textBox1.Text = ledStr;
         LoadStepTwoImage(whosOnFirstModule.GetStepTwoImage(ledStr));
         ResetTextBox2();
         solutionRichTextBox.Clear();
      }

      private void ZLeedButton_Click(object sender, EventArgs e)
      {
         textBox1.Text = leedStr;
         LoadStepTwoImage(whosOnFirstModule.GetStepTwoImage(leedStr));
         ResetTextBox2();
         solutionRichTextBox.Clear();
      }

      private void ZReadButton_Click(object sender, EventArgs e)
      {
         textBox1.Text = readStr;
         LoadStepTwoImage(whosOnFirstModule.GetStepTwoImage(readStr));
         ResetTextBox2();
         solutionRichTextBox.Clear();
      }

      private void ZRedButton_Click(object sender, EventArgs e)
      {
         textBox1.Text = redStr;
         LoadStepTwoImage(whosOnFirstModule.GetStepTwoImage(redStr));
         ResetTextBox2();
         solutionRichTextBox.Clear();
      }

      private void ZReedButton_Click(object sender, EventArgs e)
      {
         textBox1.Text = reedStr;
         LoadStepTwoImage(whosOnFirstModule.GetStepTwoImage(reedStr));
         ResetTextBox2();
         solutionRichTextBox.Clear();
      }

      private void ZUrButton_Click(object sender, EventArgs e)
      {
         textBox1.Text = urStr;
         LoadStepTwoImage(whosOnFirstModule.GetStepTwoImage(urStr));
         ResetTextBox2();
         solutionRichTextBox.Clear();
      }

      private void ZYouButton_Click(object sender, EventArgs e)
      {
         textBox1.Text = youStr;
         LoadStepTwoImage(whosOnFirstModule.GetStepTwoImage(youStr));
         ResetTextBox2();
         solutionRichTextBox.Clear();
      }

      private void ZYoureButton_Click(object sender, EventArgs e)
      {
         textBox1.Text = youreStr;
         LoadStepTwoImage(whosOnFirstModule.GetStepTwoImage(youreStr));
         ResetTextBox2();
         solutionRichTextBox.Clear();
      }

      private void ZYouareButton_Click(object sender, EventArgs e)
      {
         textBox1.Text = youAreStr;
         LoadStepTwoImage(whosOnFirstModule.GetStepTwoImage(youAreStr));
         ResetTextBox2();
         solutionRichTextBox.Clear();
      }

      private void ZYourButton_Click(object sender, EventArgs e)
      {
         textBox1.Text = yourStr;
         LoadStepTwoImage(whosOnFirstModule.GetStepTwoImage(yourStr));
         ResetTextBox2();
         solutionRichTextBox.Clear();
      }

      private void ZTheirButton_Click(object sender, EventArgs e)
      {
         textBox1.Text = theirStr;
         LoadStepTwoImage(whosOnFirstModule.GetStepTwoImage(theirStr));
         ResetTextBox2();
         solutionRichTextBox.Clear();
      }

      private void ZThereButton_Click(object sender, EventArgs e)
      {
         textBox1.Text = thereStr;
         LoadStepTwoImage(whosOnFirstModule.GetStepTwoImage(thereStr));
         ResetTextBox2();
         solutionRichTextBox.Clear();
      }

      private void ZTheyreButton_Click(object sender, EventArgs e)
      {
         textBox1.Text = theyreStr;
         LoadStepTwoImage(whosOnFirstModule.GetStepTwoImage(theyreStr));
         ResetTextBox2();
         solutionRichTextBox.Clear();
      }

      private void ZTheyareButton_Click(object sender, EventArgs e)
      {
         textBox1.Text = theyareStr;
         LoadStepTwoImage(whosOnFirstModule.GetStepTwoImage(theyareStr));
         ResetTextBox2();
         solutionRichTextBox.Clear();
      }

      private void ZCButton_Click(object sender, EventArgs e)
      {
         textBox1.Text = cStr;
         LoadStepTwoImage(whosOnFirstModule.GetStepTwoImage(cStr));
         ResetTextBox2();
         solutionRichTextBox.Clear();
      }

      private void ZCeeButton_Click(object sender, EventArgs e)
      {
         textBox1.Text = ceeStr;
         LoadStepTwoImage(whosOnFirstModule.GetStepTwoImage(ceeStr));
         ResetTextBox2();
         solutionRichTextBox.Clear();
      }

      private void ZSeeButton_Click(object sender, EventArgs e)
      {
         textBox1.Text = seeStr;
         LoadStepTwoImage(whosOnFirstModule.GetStepTwoImage(seeStr));
         ResetTextBox2();
         solutionRichTextBox.Clear();
      }

      private void ODoneButton_Click(object sender, EventArgs e)
      {
         textBox2.Text = doneStr;
         PrintSolution(whosOnFirstModule.GetSolutionList(doneStr));
      }

      private void OLikeButton_Click(object sender, EventArgs e)
      {
         textBox2.Text = likeStr;
         PrintSolution(whosOnFirstModule.GetSolutionList(likeStr));
      }

      private void OReadyButton_Click(object sender, EventArgs e)
      {
         textBox2.Text = readyStr;
         PrintSolution(whosOnFirstModule.GetSolutionList(readyStr));
      }

      private void OWaitButton_Click(object sender, EventArgs e)
      {
         textBox2.Text = waitStr;
         PrintSolution(whosOnFirstModule.GetSolutionList(waitStr));
      }

      private void OFirstButton_Click(object sender, EventArgs e)
      {
         textBox2.Text = firstStr;
         PrintSolution(whosOnFirstModule.GetSolutionList(firstStr));
      }

      private void ONextButton_Click(object sender, EventArgs e)
      {
         textBox2.Text = nextStr;
         PrintSolution(whosOnFirstModule.GetSolutionList(nextStr));
      }

      private void ONoButton_Click(object sender, EventArgs e)
      {
         textBox2.Text = noStr;
         PrintSolution(whosOnFirstModule.GetSolutionList(noStr));
      }

      private void OOkayButton_Click(object sender, EventArgs e)
      {
         textBox2.Text = okayStr;
         PrintSolution(whosOnFirstModule.GetSolutionList(okayStr));
      }

      private void OSureButton_Click(object sender, EventArgs e)
      {
         textBox2.Text = sureStr;
         PrintSolution(whosOnFirstModule.GetSolutionList(sureStr));
      }

      private void OYesButton_Click(object sender, EventArgs e)
      {
         textBox2.Text = yesStr;
         PrintSolution(whosOnFirstModule.GetSolutionList(yesStr));
      }

      private void OWhatButton_Click(object sender, EventArgs e)
      {
         textBox2.Text = whatStr;
         PrintSolution(whosOnFirstModule.GetSolutionList(whatStr));
      }

      private void OWhatQButton_Click(object sender, EventArgs e)
      {
         textBox2.Text = whatQStr;
         PrintSolution(whosOnFirstModule.GetSolutionList(whatQStr));
      }

      private void OUButton_Click(object sender, EventArgs e)
      {
         textBox2.Text = uStr;
         PrintSolution(whosOnFirstModule.GetSolutionList(uStr));
      }

      private void OUrButton_Click(object sender, EventArgs e)
      {
         textBox2.Text = urStr;
         PrintSolution(whosOnFirstModule.GetSolutionList(urStr));
      }

      private void OYouButton_Click(object sender, EventArgs e)
      {
         textBox2.Text = youStr;
         PrintSolution(whosOnFirstModule.GetSolutionList(youStr));
      }

      private void OYoureButton_Click(object sender, EventArgs e)
      {
         textBox2.Text = youreStr;
         PrintSolution(whosOnFirstModule.GetSolutionList(youreStr));
      }

      private void OYouareButton_Click(object sender, EventArgs e)
      {
         textBox2.Text = youAreStr;
         PrintSolution(whosOnFirstModule.GetSolutionList(youAreStr));
      }

      private void OYourButton_Click(object sender, EventArgs e)
      {
         textBox2.Text = yourStr;
         PrintSolution(whosOnFirstModule.GetSolutionList(yourStr));
      }

      private void OUhhuhButton_Click(object sender, EventArgs e)
      {
         textBox2.Text = uhHuhStr;
         PrintSolution(whosOnFirstModule.GetSolutionList(uhHuhStr));
      }

      private void OUhUhButton_Click(object sender, EventArgs e)
      {
         textBox2.Text = uhUhStr;
         PrintSolution(whosOnFirstModule.GetSolutionList(uhUhStr));
      }

      private void OUhhhButton_Click(object sender, EventArgs e)
      {
         textBox2.Text = uhhhStr;
         PrintSolution(whosOnFirstModule.GetSolutionList(uhhhStr));
      }

      private void OLeftButton_Click(object sender, EventArgs e)
      {
         textBox2.Text = leftStr;
         PrintSolution(whosOnFirstModule.GetSolutionList(leftStr));
      }

      private void OMiddleButton_Click(object sender, EventArgs e)
      {
         textBox2.Text = middleStr;
         PrintSolution(whosOnFirstModule.GetSolutionList(middleStr));
      }

      private void ORightButton_Click(object sender, EventArgs e)
      {
         textBox2.Text = rightStr;
         PrintSolution(whosOnFirstModule.GetSolutionList(rightStr));
      }

      private void OHoldButton_Click(object sender, EventArgs e)
      {
         textBox2.Text = holdStr;
         PrintSolution(whosOnFirstModule.GetSolutionList(holdStr));
      }

      private void OPressButton_Click(object sender, EventArgs e)
      {
         textBox2.Text = pressStr;
         PrintSolution(whosOnFirstModule.GetSolutionList(pressStr));
      }

      private void OBlankButton_Click(object sender, EventArgs e)
      {
         textBox2.Text = blankStr;
         PrintSolution(whosOnFirstModule.GetSolutionList(blankStr));
      }

      private void ONothingButton_Click(object sender, EventArgs e)
      {
         textBox2.Text = nothingStr;
         PrintSolution(whosOnFirstModule.GetSolutionList(nothingStr));
      }
   }
}
