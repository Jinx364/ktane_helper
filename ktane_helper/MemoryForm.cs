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
   public partial class MemoryForm : Form
   {
      private static MemoryModule memoryModule;
      private int stage;

      public MemoryForm()
      {
         InitializeComponent();
         InitializeModule();
         stage = 1;
      }

      private void InitializeModule()
      {
         memoryModule = new MemoryModule();
      }


      // Memory module
      private class MemoryModule
      {
         public enum NeededInfoEnum
         {
              None
            , Position
            , Label
         }

         private List<StageInfo> memory;

         public MemoryModule()
         {
            memory = new List<StageInfo> { new StageInfo(), new StageInfo(),
               new StageInfo(), new StageInfo(), new StageInfo() };
         }

         public void Reset()
         {
            foreach (StageInfo info in memory)
            {
               info.Reset();
            }
         }

         public void SetDisplayForStage(int display, int stage)
         {
            memory[stage - 1].displayComboIndex = display - 1;
            CalculateSolutionForStage(stage);
         }

         public StageInfo GetStageInfoForStage(int stage)
         {
            return memory[stage - 1];
         }

         private void CalculateSolutionForStage(int stage)
         {
            // STAGE ONE
            if (stage == 1)
            {
               if (memory[stage - 1].displayComboIndex + 1 == 1)
               {
                  // Second position
                  memory[stage - 1].buttonToPress = "second position";
                  memory[stage - 1].infoNeeded = NeededInfoEnum.Label;
                  memory[stage - 1].buttonPosition = 2;
               }
               else if (memory[stage - 1].displayComboIndex + 1 == 2)
               {
                  // Second position
                  memory[stage - 1].buttonToPress = "second position";
                  memory[stage - 1].infoNeeded = NeededInfoEnum.Label;
                  memory[stage - 1].buttonPosition = 2;
               }
               else if (memory[stage - 1].displayComboIndex + 1 == 3)
               {
                  // Third position
                  memory[stage - 1].buttonToPress = "third position";
                  memory[stage - 1].infoNeeded = NeededInfoEnum.Label;
                  memory[stage - 1].buttonPosition = 3;
               }
               else if (memory[stage - 1].displayComboIndex + 1 == 4)
               {
                  // Fourth position
                  memory[stage - 1].buttonToPress = "fourth position";
                  memory[stage - 1].infoNeeded = NeededInfoEnum.Label;
                  memory[stage - 1].buttonPosition = 4;
               }
            }
            // STAGE TWO
            else if (stage == 2)
            {
               if (memory[stage - 1].displayComboIndex + 1 == 1)
               {
                  // Labeled "4"
                  memory[stage - 1].buttonToPress = "labeled '4'";
                  memory[stage - 1].infoNeeded = NeededInfoEnum.Position;
                  memory[stage - 1].buttonLabel = 4;
               }
               else if (memory[stage - 1].displayComboIndex + 1 == 2)
               {
                  // Same position as stage 1
                  memory[stage - 1].buttonToPress =
                     RecallPressString(1, NeededInfoEnum.Position);
                  memory[stage - 1].infoNeeded = NeededInfoEnum.Label;
                  memory[stage - 1].buttonPosition =
                     memory[0].buttonPosition;
               }
               else if (memory[stage - 1].displayComboIndex + 1 == 3)
               {
                  // First position
                  memory[stage - 1].buttonToPress = "first position";
                  memory[stage - 1].infoNeeded = NeededInfoEnum.Label;
                  memory[stage - 1].buttonPosition = 1;
               }
               else if (memory[stage - 1].displayComboIndex + 1 == 4)
               {
                  // Same position as stage 1
                  memory[stage - 1].buttonToPress =
                     RecallPressString(1, NeededInfoEnum.Position);
                  memory[stage - 1].infoNeeded = NeededInfoEnum.Label;
                  memory[stage - 1].buttonPosition =
                     memory[0].buttonPosition;
               }
            }
            // STAGE THREE
            else if (stage == 3)
            {
               if (memory[stage - 1].displayComboIndex + 1 == 1)
               {
                  // Same label as stage 2
                  memory[stage - 1].buttonToPress =
                     RecallPressString(2, NeededInfoEnum.Label);
                  memory[stage - 1].infoNeeded = NeededInfoEnum.Position;
                  memory[stage - 1].buttonLabel =
                     memory[1].buttonLabel;
               }
               else if (memory[stage - 1].displayComboIndex + 1 == 2)
               {
                  // Same label as stage 1
                  memory[stage - 1].buttonToPress =
                     RecallPressString(1, NeededInfoEnum.Label);
                  memory[stage - 1].infoNeeded = NeededInfoEnum.Position;
                  memory[stage - 1].buttonLabel =
                     memory[0].buttonLabel;
               }
               else if (memory[stage - 1].displayComboIndex + 1 == 3)
               {
                  // Third position
                  memory[stage - 1].buttonToPress = "third position";
                  memory[stage - 1].infoNeeded = NeededInfoEnum.Label;
                  memory[stage - 1].buttonPosition = 3;
               }
               else if (memory[stage - 1].displayComboIndex + 1 == 4)
               {
                  // Labeled "4"
                  memory[stage - 1].buttonToPress = "labeled '4'";
                  memory[stage - 1].infoNeeded = NeededInfoEnum.Position;
                  memory[stage - 1].buttonLabel = 4;
               }
            }
            // STAGE FOUR
            else if (stage == 4)
            {
               if (memory[stage - 1].displayComboIndex + 1 == 1)
               {
                  // Same position as stage 1
                  memory[stage - 1].buttonToPress =
                     RecallPressString(1, NeededInfoEnum.Position);
                  memory[stage - 1].infoNeeded = NeededInfoEnum.Label;
                  memory[stage - 1].buttonPosition =
                     memory[0].buttonPosition;
               }
               else if (memory[stage - 1].displayComboIndex + 1 == 2)
               {
                  // First position
                  memory[stage - 1].buttonToPress = "first position";
                  memory[stage - 1].infoNeeded = NeededInfoEnum.Label;
                  memory[stage - 1].buttonPosition = 1;
               }
               else if (memory[stage - 1].displayComboIndex + 1 == 3)
               {
                  // Same position as stage 2
                  memory[stage - 1].buttonToPress =
                     RecallPressString(2, NeededInfoEnum.Position);
                  memory[stage - 1].infoNeeded = NeededInfoEnum.Label;
                  memory[stage - 1].buttonPosition =
                     memory[1].buttonPosition;
               }
               else if (memory[stage - 1].displayComboIndex + 1 == 4)
               {
                  // Same position as stage 2
                  memory[stage - 1].buttonToPress =
                     RecallPressString(2, NeededInfoEnum.Position);
                  memory[stage - 1].infoNeeded = NeededInfoEnum.Label;
                  memory[stage - 1].buttonPosition =
                     memory[1].buttonPosition;
               }
            }
            // STAGE FIVE
            else if (stage == 5)
            {
               if (memory[stage - 1].displayComboIndex + 1 == 1)
               {
                  // Same label as stage 1
                  memory[stage - 1].buttonToPress =
                     RecallPressString(1, NeededInfoEnum.Label);
                  memory[stage - 1].infoNeeded = NeededInfoEnum.None;
                  memory[stage - 1].buttonLabel =
                     memory[0].buttonLabel;
               }
               else if (memory[stage - 1].displayComboIndex + 1 == 2)
               {
                  // Same label as stage 2
                  memory[stage - 1].buttonToPress =
                     RecallPressString(2, NeededInfoEnum.Label);
                  memory[stage - 1].infoNeeded = NeededInfoEnum.None;
                  memory[stage - 1].buttonLabel =
                     memory[1].buttonLabel;
               }
               else if (memory[stage - 1].displayComboIndex + 1 == 3)
               {
                  // Same label as stage 4
                  memory[stage - 1].buttonToPress =
                     RecallPressString(4, NeededInfoEnum.Label);
                  memory[stage - 1].infoNeeded = NeededInfoEnum.None;
                  memory[stage - 1].buttonLabel =
                     memory[3].buttonLabel;
               }
               else if (memory[stage - 1].displayComboIndex + 1 == 4)
               {
                  // Same label as stage 3
                  memory[stage - 1].buttonToPress =
                     RecallPressString(3, NeededInfoEnum.Label);
                  memory[stage - 1].infoNeeded = NeededInfoEnum.None;
                  memory[stage - 1].buttonLabel =
                     memory[2].buttonLabel;
               }
            }
         }

         public void SetNeededInfoForStage(int stage, int neededInfo)
         {
            if (memory[stage - 1].infoNeeded == NeededInfoEnum.Label)
            {
               memory[stage - 1].buttonLabel = neededInfo;
            }
            else if (memory[stage - 1].infoNeeded == NeededInfoEnum.Position)
            {
               memory[stage - 1].buttonPosition = neededInfo;
            }

            memory[stage - 1].infoProvidedIndex = neededInfo - 1;
         }

         private String RecallPressString(int fromStage, NeededInfoEnum info)
         {
            String retStr = "";

            if (info == NeededInfoEnum.Label)
            {
               int label = memory[fromStage - 1].buttonLabel;
               retStr += "labeled '";
               if (label == 1)
               {
                  retStr += '1';
               }
               else if (label == 2)
               {
                  retStr += '2';
               }
               else if (label == 3)
               {
                  retStr += '3';
               }
               else if (label == 4)
               {
                  retStr += '4';
               }

               retStr += "'";
            }
            else if (info == NeededInfoEnum.Position)
            {
               int position = memory[fromStage - 1].buttonPosition;
               if (position == 1)
               {
                  retStr += "first";
               }
               else if (position == 2)
               {
                  retStr += "second";
               }
               else if (position == 3)
               {
                  retStr += "third";
               }
               else if (position == 4)
               {
                  retStr += "fourth";
               }

               retStr += " position";
            }

            return retStr;
         }

         public class StageInfo
         {
            public int displayComboIndex;
            public String buttonToPress;
            public NeededInfoEnum infoNeeded;
            public int infoProvidedIndex;

            public int buttonLabel;
            public int buttonPosition;

            public StageInfo()
            {
               Reset();
            }

            public void Reset()
            {
               displayComboIndex = -1;
               infoProvidedIndex = -1;

               buttonToPress = "";
               infoNeeded = NeededInfoEnum.None;

               buttonLabel = 0;
               buttonPosition = 0;
            }
         }
      }

      private void displayComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         memoryModule.SetDisplayForStage(displayComboBox.SelectedIndex + 1, stage);

         if (stage < 5)
         {
            infoComboBox.Enabled = true;
         }
         else
         {
            infoComboBox.Enabled = false;
         }

         MemoryModule.StageInfo info = memoryModule.GetStageInfoForStage(stage);
         buttonToPressTextBox.Text = info.buttonToPress;

         if (info.infoNeeded == MemoryModule.NeededInfoEnum.Label)
         {
            infoNeededTextBox.Text = "label";
         }
         else if (info.infoNeeded == MemoryModule.NeededInfoEnum.Position)
         {
            infoNeededTextBox.Text = "position";
         }
         else if (info.infoNeeded == MemoryModule.NeededInfoEnum.None)
         {
            infoNeededTextBox.Text = "";
         }
      }

      private void infoComboBox_SelectedIndexChanged(object sender, EventArgs e)
      {
         memoryModule.SetNeededInfoForStage(stage, infoComboBox.SelectedIndex + 1);
         nextStageButton.Enabled = true;
      }

      private void nextStageButton_Click(object sender, EventArgs e)
      {
         stage++;
         OnStageChange();
      }

      private void goBackButton_Click(object sender, EventArgs e)
      {
         stage--;
         OnStageChange();
      }

      private void OnStageChange()
      {
         stageTextBox.Text = stage.ToString();
         MemoryModule.StageInfo info = memoryModule.GetStageInfoForStage(stage);

         displayComboBox.SelectedIndex = info.displayComboIndex;
         if (displayComboBox.SelectedIndex != -1)
         {
            buttonToPressTextBox.Text = info.buttonToPress;

            infoComboBox.SelectedIndex = info.infoProvidedIndex;
            if (infoComboBox.SelectedIndex != -1)
            {
               infoComboBox.SelectedIndex = info.infoProvidedIndex;
               nextStageButton.Enabled = true;
            }
            else
            {
               nextStageButton.Enabled = false;
            }

            if (info.infoNeeded == MemoryModule.NeededInfoEnum.Label)
            {
               infoNeededTextBox.Text = "label";
            }
            else if (info.infoNeeded == MemoryModule.NeededInfoEnum.Position)
            {
               infoNeededTextBox.Text = "position";
            }
            else if (info.infoNeeded == MemoryModule.NeededInfoEnum.None)
            {
               infoNeededTextBox.Text = "";
               nextStageButton.Enabled = false;
            }
         }
         else
         {
            buttonToPressTextBox.Text = "";
            infoNeededTextBox.Text = "";
            infoComboBox.SelectedIndex = -1;
            infoComboBox.Enabled = false;
            nextStageButton.Enabled = false;
         }

         if (stage <= 1)
         {
            goBackButton.Enabled = false;
         }
         else
         {
            goBackButton.Enabled = true;
         }
         if (stage >= 5)
         {
            nextStageButton.Enabled = false;
         }
      }

      private void startOverButton_Click(object sender, EventArgs e)
      {
         DialogResult result = MessageBox.Show(
            "WARNING! This will erase all progress.\nStart over on stage 1?",
            "Are you sure?",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2);

         if (result == DialogResult.OK)
         {
            memoryModule.Reset();
            stage = 1;
            OnStageChange();
         }
      }
   }
}
