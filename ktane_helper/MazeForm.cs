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
   public partial class MazeForm : Form
   {
      private static MazeModule mazeModule;
      private PlacementFlag flag;
      private int whiteLightPosition;
      private int redTrianglePosition;

      private static readonly Color controlColor = Color.FromArgb(0, 240, 240, 240);

      private enum PlacementFlag
      {
           None
         , Circle1
         , Circle2
         , Start
         , End
      }

      public MazeForm()
      {
         InitializeComponent();
         InitializeModule();
         InitializeInstructions();

         flag = PlacementFlag.None;
         whiteLightPosition = 0;
         redTrianglePosition = 0;
      }

      private void InitializeModule()
      {
         mazeModule = new MazeModule();
      }

      private void InitializeInstructions()
      {
         instructionsTextBox.AppendText("● Find the maze with matching circular markings.");
         instructionsTextBox.AppendText("\n● The defuser must navigate the white light to the red triangle using the arrow buttons.");
         instructionsTextBox.AppendText("\n● ");
         instructionsTextBox.SelectionFont = new Font(instructionsTextBox.Font, FontStyle.Bold);
         instructionsTextBox.AppendText("Warning:");
         instructionsTextBox.SelectionFont = new Font(instructionsTextBox.Font, FontStyle.Regular);
         instructionsTextBox.AppendText(" Do not cross the lines shown in the maze. These lines are invisible on the bomb.");
      }

      private void LoadMazeImage()
      {
         int whichMaze = mazeModule.WhichMazeFitsCircles();

         if (whichMaze == 1)
         {
            mazePictureBox.Image = Properties.Resources.maze1;
         }
         else if (whichMaze == 2)
         {
            mazePictureBox.Image = Properties.Resources.maze2;
         }
         else if (whichMaze == 3)
         {
            mazePictureBox.Image = Properties.Resources.maze3;
         }
         else if (whichMaze == 4)
         {
            mazePictureBox.Image = Properties.Resources.maze4;
         }
         else if (whichMaze == 5)
         {
            mazePictureBox.Image = Properties.Resources.maze5;
         }
         else if (whichMaze == 6)
         {
            mazePictureBox.Image = Properties.Resources.maze6;
         }
         else if (whichMaze == 7)
         {
            mazePictureBox.Image = Properties.Resources.maze7;
         }
         else if (whichMaze == 8)
         {
            mazePictureBox.Image = Properties.Resources.maze8;
         }
         else if (whichMaze == 9)
         {
            mazePictureBox.Image = Properties.Resources.maze9;
         }
         else
         {
            mazePictureBox.Image = null;
         }

         mazePictureBox.Invalidate();
      }

      private void MoveWhiteLight(int from, int to)
      {
         Color noWhiteLight  = controlColor;
         Color yesWhiteLight = Color.Yellow;

         if (from == 1)
         {
            button1.BackColor = noWhiteLight;
         }
         else if (from == 2)
         {
            button2.BackColor = noWhiteLight;
         }
         else if (from == 3)
         {
            button3.BackColor = noWhiteLight;
         }
         else if (from == 4)
         {
            button4.BackColor = noWhiteLight;
         }
         else if (from == 5)
         {
            button5.BackColor = noWhiteLight;
         }
         else if (from == 6)
         {
            button6.BackColor = noWhiteLight;
         }
         else if (from == 7)
         {
            button7.BackColor = noWhiteLight;
         }
         else if (from == 8)
         {
            button8.BackColor = noWhiteLight;
         }
         else if (from == 9)
         {
            button9.BackColor = noWhiteLight;
         }
         else if (from == 10)
         {
            button10.BackColor = noWhiteLight;
         }
         else if (from == 11)
         {
            button11.BackColor = noWhiteLight;
         }
         else if (from == 12)
         {
            button12.BackColor = noWhiteLight;
         }
         else if (from == 13)
         {
            button13.BackColor = noWhiteLight;
         }
         else if (from == 14)
         {
            button14.BackColor = noWhiteLight;
         }
         else if (from == 15)
         {
            button15.BackColor = noWhiteLight;
         }
         else if (from == 16)
         {
            button16.BackColor = noWhiteLight;
         }
         else if (from == 17)
         {
            button17.BackColor = noWhiteLight;
         }
         else if (from == 18)
         {
            button18.BackColor = noWhiteLight;
         }
         else if (from == 19)
         {
            button19.BackColor = noWhiteLight;
         }
         else if (from == 20)
         {
            button20.BackColor = noWhiteLight;
         }
         else if (from == 21)
         {
            button21.BackColor = noWhiteLight;
         }
         else if (from == 22)
         {
            button22.BackColor = noWhiteLight;
         }
         else if (from == 23)
         {
            button23.BackColor = noWhiteLight;
         }
         else if (from == 24)
         {
            button24.BackColor = noWhiteLight;
         }
         else if (from == 25)
         {
            button25.BackColor = noWhiteLight;
         }
         else if (from == 26)
         {
            button26.BackColor = noWhiteLight;
         }
         else if (from == 27)
         {
            button27.BackColor = noWhiteLight;
         }
         else if (from == 28)
         {
            button28.BackColor = noWhiteLight;
         }
         else if (from == 29)
         {
            button29.BackColor = noWhiteLight;
         }
         else if (from == 30)
         {
            button30.BackColor = noWhiteLight;
         }
         else if (from == 31)
         {
            button31.BackColor = noWhiteLight;
         }
         else if (from == 32)
         {
            button32.BackColor = noWhiteLight;
         }
         else if (from == 33)
         {
            button33.BackColor = noWhiteLight;
         }
         else if (from == 34)
         {
            button34.BackColor = noWhiteLight;
         }
         else if (from == 35)
         {
            button35.BackColor = noWhiteLight;
         }
         else if (from == 36)
         {
            button36.BackColor = noWhiteLight;
         }

         if (to == 1)
         {
            button1.BackColor = yesWhiteLight;
         }
         else if (to == 2)
         {
            button2.BackColor = yesWhiteLight;
         }
         else if (to == 3)
         {
            button3.BackColor = yesWhiteLight;
         }
         else if (to == 4)
         {
            button4.BackColor = yesWhiteLight;
         }
         else if (to == 5)
         {
            button5.BackColor = yesWhiteLight;
         }
         else if (to == 6)
         {
            button6.BackColor = yesWhiteLight;
         }
         else if (to == 7)
         {
            button7.BackColor = yesWhiteLight;
         }
         else if (to == 8)
         {
            button8.BackColor = yesWhiteLight;
         }
         else if (to == 9)
         {
            button9.BackColor = yesWhiteLight;
         }
         else if (to == 10)
         {
            button10.BackColor = yesWhiteLight;
         }
         else if (to == 11)
         {
            button11.BackColor = yesWhiteLight;
         }
         else if (to == 12)
         {
            button12.BackColor = yesWhiteLight;
         }
         else if (to == 13)
         {
            button13.BackColor = yesWhiteLight;
         }
         else if (to == 14)
         {
            button14.BackColor = yesWhiteLight;
         }
         else if (to == 15)
         {
            button15.BackColor = yesWhiteLight;
         }
         else if (to == 16)
         {
            button16.BackColor = yesWhiteLight;
         }
         else if (to == 17)
         {
            button17.BackColor = yesWhiteLight;
         }
         else if (to == 18)
         {
            button18.BackColor = yesWhiteLight;
         }
         else if (to == 19)
         {
            button19.BackColor = yesWhiteLight;
         }
         else if (to == 20)
         {
            button20.BackColor = yesWhiteLight;
         }
         else if (to == 21)
         {
            button21.BackColor = yesWhiteLight;
         }
         else if (to == 22)
         {
            button22.BackColor = yesWhiteLight;
         }
         else if (to == 23)
         {
            button23.BackColor = yesWhiteLight;
         }
         else if (to == 24)
         {
            button24.BackColor = yesWhiteLight;
         }
         else if (to == 25)
         {
            button25.BackColor = yesWhiteLight;
         }
         else if (to == 26)
         {
            button26.BackColor = yesWhiteLight;
         }
         else if (to == 27)
         {
            button27.BackColor = yesWhiteLight;
         }
         else if (to == 28)
         {
            button28.BackColor = yesWhiteLight;
         }
         else if (to == 29)
         {
            button29.BackColor = yesWhiteLight;
         }
         else if (to == 30)
         {
            button30.BackColor = yesWhiteLight;
         }
         else if (to == 31)
         {
            button31.BackColor = yesWhiteLight;
         }
         else if (to == 32)
         {
            button32.BackColor = yesWhiteLight;
         }
         else if (to == 33)
         {
            button33.BackColor = yesWhiteLight;
         }
         else if (to == 34)
         {
            button34.BackColor = yesWhiteLight;
         }
         else if (to == 35)
         {
            button35.BackColor = yesWhiteLight;
         }
         else if (to == 36)
         {
            button36.BackColor = yesWhiteLight;
         }
      }

      private void MoveRedTriangle(int from, int to)
      {
         Color noRedTriangle  = controlColor;
         Color yesRedTriangle = Color.Red;

         if (from == 1)
         {
            button1.BackColor = noRedTriangle;
         }
         else if (from == 2)
         {
            button2.BackColor = noRedTriangle;
         }
         else if (from == 3)
         {
            button3.BackColor = noRedTriangle;
         }
         else if (from == 4)
         {
            button4.BackColor = noRedTriangle;
         }
         else if (from == 5)
         {
            button5.BackColor = noRedTriangle;
         }
         else if (from == 6)
         {
            button6.BackColor = noRedTriangle;
         }
         else if (from == 7)
         {
            button7.BackColor = noRedTriangle;
         }
         else if (from == 8)
         {
            button8.BackColor = noRedTriangle;
         }
         else if (from == 9)
         {
            button9.BackColor = noRedTriangle;
         }
         else if (from == 10)
         {
            button10.BackColor = noRedTriangle;
         }
         else if (from == 11)
         {
            button11.BackColor = noRedTriangle;
         }
         else if (from == 12)
         {
            button12.BackColor = noRedTriangle;
         }
         else if (from == 13)
         {
            button13.BackColor = noRedTriangle;
         }
         else if (from == 14)
         {
            button14.BackColor = noRedTriangle;
         }
         else if (from == 15)
         {
            button15.BackColor = noRedTriangle;
         }
         else if (from == 16)
         {
            button16.BackColor = noRedTriangle;
         }
         else if (from == 17)
         {
            button17.BackColor = noRedTriangle;
         }
         else if (from == 18)
         {
            button18.BackColor = noRedTriangle;
         }
         else if (from == 19)
         {
            button19.BackColor = noRedTriangle;
         }
         else if (from == 20)
         {
            button20.BackColor = noRedTriangle;
         }
         else if (from == 21)
         {
            button21.BackColor = noRedTriangle;
         }
         else if (from == 22)
         {
            button22.BackColor = noRedTriangle;
         }
         else if (from == 23)
         {
            button23.BackColor = noRedTriangle;
         }
         else if (from == 24)
         {
            button24.BackColor = noRedTriangle;
         }
         else if (from == 25)
         {
            button25.BackColor = noRedTriangle;
         }
         else if (from == 26)
         {
            button26.BackColor = noRedTriangle;
         }
         else if (from == 27)
         {
            button27.BackColor = noRedTriangle;
         }
         else if (from == 28)
         {
            button28.BackColor = noRedTriangle;
         }
         else if (from == 29)
         {
            button29.BackColor = noRedTriangle;
         }
         else if (from == 30)
         {
            button30.BackColor = noRedTriangle;
         }
         else if (from == 31)
         {
            button31.BackColor = noRedTriangle;
         }
         else if (from == 32)
         {
            button32.BackColor = noRedTriangle;
         }
         else if (from == 33)
         {
            button33.BackColor = noRedTriangle;
         }
         else if (from == 34)
         {
            button34.BackColor = noRedTriangle;
         }
         else if (from == 35)
         {
            button35.BackColor = noRedTriangle;
         }
         else if (from == 36)
         {
            button36.BackColor = noRedTriangle;
         }

         if (to == 1)
         {
            button1.BackColor = yesRedTriangle;
         }
         else if (to == 2)
         {
            button2.BackColor = yesRedTriangle;
         }
         else if (to == 3)
         {
            button3.BackColor = yesRedTriangle;
         }
         else if (to == 4)
         {
            button4.BackColor = yesRedTriangle;
         }
         else if (to == 5)
         {
            button5.BackColor = yesRedTriangle;
         }
         else if (to == 6)
         {
            button6.BackColor = yesRedTriangle;
         }
         else if (to == 7)
         {
            button7.BackColor = yesRedTriangle;
         }
         else if (to == 8)
         {
            button8.BackColor = yesRedTriangle;
         }
         else if (to == 9)
         {
            button9.BackColor = yesRedTriangle;
         }
         else if (to == 10)
         {
            button10.BackColor = yesRedTriangle;
         }
         else if (to == 11)
         {
            button11.BackColor = yesRedTriangle;
         }
         else if (to == 12)
         {
            button12.BackColor = yesRedTriangle;
         }
         else if (to == 13)
         {
            button13.BackColor = yesRedTriangle;
         }
         else if (to == 14)
         {
            button14.BackColor = yesRedTriangle;
         }
         else if (to == 15)
         {
            button15.BackColor = yesRedTriangle;
         }
         else if (to == 16)
         {
            button16.BackColor = yesRedTriangle;
         }
         else if (to == 17)
         {
            button17.BackColor = yesRedTriangle;
         }
         else if (to == 18)
         {
            button18.BackColor = yesRedTriangle;
         }
         else if (to == 19)
         {
            button19.BackColor = yesRedTriangle;
         }
         else if (to == 20)
         {
            button20.BackColor = yesRedTriangle;
         }
         else if (to == 21)
         {
            button21.BackColor = yesRedTriangle;
         }
         else if (to == 22)
         {
            button22.BackColor = yesRedTriangle;
         }
         else if (to == 23)
         {
            button23.BackColor = yesRedTriangle;
         }
         else if (to == 24)
         {
            button24.BackColor = yesRedTriangle;
         }
         else if (to == 25)
         {
            button25.BackColor = yesRedTriangle;
         }
         else if (to == 26)
         {
            button26.BackColor = yesRedTriangle;
         }
         else if (to == 27)
         {
            button27.BackColor = yesRedTriangle;
         }
         else if (to == 28)
         {
            button28.BackColor = yesRedTriangle;
         }
         else if (to == 29)
         {
            button29.BackColor = yesRedTriangle;
         }
         else if (to == 30)
         {
            button30.BackColor = yesRedTriangle;
         }
         else if (to == 31)
         {
            button31.BackColor = yesRedTriangle;
         }
         else if (to == 32)
         {
            button32.BackColor = yesRedTriangle;
         }
         else if (to == 33)
         {
            button33.BackColor = yesRedTriangle;
         }
         else if (to == 34)
         {
            button34.BackColor = yesRedTriangle;
         }
         else if (to == 35)
         {
            button35.BackColor = yesRedTriangle;
         }
         else if (to == 36)
         {
            button36.BackColor = yesRedTriangle;
         }
      }

      private class MazeModule
      {
         private int circle1;
         private int circle2;

         private static readonly List<int> maze1Circles =
            new List<int> { 7, 18 };

         private static readonly List<int> maze2Circles =
            new List<int> { 11, 20 };

         private static readonly List<int> maze3Circles =
            new List<int> { 22, 24 };

         private static readonly List<int> maze4Circles =
            new List<int> { 1, 19 };

         private static readonly List<int> maze5Circles =
            new List<int> { 17, 34 };

         private static readonly List<int> maze6Circles =
            new List<int> { 5, 27 };

         private static readonly List<int> maze7Circles =
            new List<int> { 2, 32 };

         private static readonly List<int> maze8Circles =
            new List<int> { 4, 21 };

         private static readonly List<int> maze9Circles =
            new List<int> { 9, 25 };

         public MazeModule()
         {
            circle1 = 0;
            circle2 = 0;
         }

         public int WhichMazeFitsCircles()
         {
            int retVal = 0;
            List<int> fits = new List<int>();

            if (maze1Circles.Contains(circle1) || maze1Circles.Contains(circle2))
            {
               fits.Add(1);
            }
            if (maze2Circles.Contains(circle1) || maze2Circles.Contains(circle2))
            {
               fits.Add(2);
            }
            if (maze3Circles.Contains(circle1) || maze3Circles.Contains(circle2))
            {
               fits.Add(3);
            }
            if (maze4Circles.Contains(circle1) || maze4Circles.Contains(circle2))
            {
               fits.Add(4);
            }
            if (maze5Circles.Contains(circle1) || maze5Circles.Contains(circle2))
            {
               fits.Add(5);
            }
            if (maze6Circles.Contains(circle1) || maze6Circles.Contains(circle2))
            {
               fits.Add(6);
            }
            if (maze7Circles.Contains(circle1) || maze7Circles.Contains(circle2))
            {
               fits.Add(7);
            }
            if (maze8Circles.Contains(circle1) || maze8Circles.Contains(circle2))
            {
               fits.Add(8);
            }
            if (maze9Circles.Contains(circle1) || maze9Circles.Contains(circle2))
            {
               fits.Add(9);
            }

            if (fits.Count == 1)
            {
               retVal = fits[0];
            }

            return retVal;
         }

         public int Circle1
         {
            get
            {
               return circle1;
            }
            set
            {
               circle1 = value;
            }
         }

         public int Circle2
         {
            get
            {
               return circle2;
            }
            set
            {
               circle2 = value;
            }
         }
      }

      private void circle1CheckBox_CheckedChanged(object sender, EventArgs e)
      {
         if (circle1CheckBox.Checked)
         {
            flag = PlacementFlag.Circle1;
            circle2CheckBox.Checked = false;
            whiteLightCheckBox.Checked = false;
            redTriangleCheckBox.Checked = false;
         }
         else if (flag == PlacementFlag.Circle1)
         {
            flag = PlacementFlag.None;
         }
      }

      private void circle2CheckBox_CheckedChanged(object sender, EventArgs e)
      {
         if (circle2CheckBox.Checked)
         {
            flag = PlacementFlag.Circle2;
            circle1CheckBox.Checked = false;
            whiteLightCheckBox.Checked = false;
            redTriangleCheckBox.Checked = false;
         }
         else if (flag == PlacementFlag.Circle2)
         {
            flag = PlacementFlag.None;
         }
      }

      private void whiteLightCheckBox_CheckedChanged(object sender, EventArgs e)
      {
         if (whiteLightCheckBox.Checked)
         {
            flag = PlacementFlag.Start;
            circle1CheckBox.Checked = false;
            circle2CheckBox.Checked = false;
            redTriangleCheckBox.Checked = false;
         }
         else if (flag == PlacementFlag.Start)
         {
            flag = PlacementFlag.None;
         }
      }

      private void redTriangleCheckBox_CheckedChanged(object sender, EventArgs e)
      {
         if (redTriangleCheckBox.Checked)
         {
            flag = PlacementFlag.End;
            circle1CheckBox.Checked = false;
            circle2CheckBox.Checked = false;
            whiteLightCheckBox.Checked = false;
         }
         else if (flag == PlacementFlag.End)
         {
            flag = PlacementFlag.None;
         }
      }

      private void resetButton_Click(object sender, EventArgs e)
      {
         flag = PlacementFlag.None;
         MoveWhiteLight(whiteLightPosition, 0);
         MoveRedTriangle(redTrianglePosition, 0);
         whiteLightPosition = 0;
         redTrianglePosition = 0;
         mazeModule.Circle1 = 0;
         mazeModule.Circle2 = 0;
         circle1CheckBox.Checked = false;
         circle2CheckBox.Checked = false;
         whiteLightCheckBox.Checked = false;
         redTriangleCheckBox.Checked = false;
         mazePictureBox.Image = null;
         mazePictureBox.Invalidate();
      }

      private void button1_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 1;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 1;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 1);
            whiteLightPosition = 1;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 1);
            redTrianglePosition = 1;
         }
      }

      private void button2_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 2;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 2;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 2);
            whiteLightPosition = 2;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 2);
            redTrianglePosition = 2;
         }
      }

      private void button3_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 3;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 3;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 3);
            whiteLightPosition = 3;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 3);
            redTrianglePosition = 3;
         }
      }

      private void button4_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 4;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 4;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 4);
            whiteLightPosition = 4;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 4);
            redTrianglePosition = 4;
         }
      }

      private void button5_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 5;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 5;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 5);
            whiteLightPosition = 5;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 5);
            redTrianglePosition = 5;
         }
      }

      private void button6_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 6;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 6;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 6);
            whiteLightPosition = 6;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 6);
            redTrianglePosition = 6;
         }
      }

      private void button7_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 7;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 7;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 7);
            whiteLightPosition = 7;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 7);
            redTrianglePosition = 7;
         }
      }

      private void button8_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 8;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 8;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 8);
            whiteLightPosition = 8;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 8);
            redTrianglePosition = 8;
         }
      }

      private void button9_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 9;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 9;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 9);
            whiteLightPosition = 9;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 9);
            redTrianglePosition = 9;
         }
      }

      private void button10_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 10;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 10;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 10);
            whiteLightPosition = 10;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 10);
            redTrianglePosition = 10;
         }
      }

      private void button11_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 11;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 11;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 11);
            whiteLightPosition = 11;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 11);
            redTrianglePosition = 11;
         }
      }

      private void button12_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 12;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 12;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 12);
            whiteLightPosition = 12;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 12);
            redTrianglePosition = 12;
         }
      }

      private void button13_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 13;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 13;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 13);
            whiteLightPosition = 13;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 13);
            redTrianglePosition = 13;
         }
      }

      private void button14_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 14;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 14;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 14);
            whiteLightPosition = 14;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 14);
            redTrianglePosition = 14;
         }
      }

      private void button15_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 15;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 15;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 15);
            whiteLightPosition = 15;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 15);
            redTrianglePosition = 15;
         }
      }

      private void button16_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 16;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 16;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 16);
            whiteLightPosition = 16;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 16);
            redTrianglePosition = 16;
         }
      }

      private void button17_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 17;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 17;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 17);
            whiteLightPosition = 17;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 17);
            redTrianglePosition = 17;
         }
      }

      private void button18_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 18;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 18;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 18);
            whiteLightPosition = 18;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 18);
            redTrianglePosition = 18;
         }
      }

      private void button19_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 19;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 19;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 19);
            whiteLightPosition = 19;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 19);
            redTrianglePosition = 19;
         }
      }

      private void button20_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 20;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 20;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 20);
            whiteLightPosition = 20;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 20);
            redTrianglePosition = 20;
         }
      }

      private void button21_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 21;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 21;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 21);
            whiteLightPosition = 21;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 21);
            redTrianglePosition = 21;
         }
      }

      private void button22_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 22;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 22;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 22);
            whiteLightPosition = 22;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 22);
            redTrianglePosition = 22;
         }
      }

      private void button23_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 23;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 23;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 23);
            whiteLightPosition = 23;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 23);
            redTrianglePosition = 23;
         }
      }

      private void button24_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 24;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 24;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 24);
            whiteLightPosition = 24;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 24);
            redTrianglePosition = 24;
         }
      }

      private void button25_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 25;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 25;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 25);
            whiteLightPosition = 25;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 25);
            redTrianglePosition = 25;
         }
      }

      private void button26_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 26;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 26;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 26);
            whiteLightPosition = 26;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 26);
            redTrianglePosition = 26;
         }
      }

      private void button27_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 27;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 27;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 27);
            whiteLightPosition = 27;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 27);
            redTrianglePosition = 27;
         }
      }

      private void button28_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 28;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 28;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 28);
            whiteLightPosition = 28;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 28);
            redTrianglePosition = 28;
         }
      }

      private void button29_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 29;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 29;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 29);
            whiteLightPosition = 29;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 29);
            redTrianglePosition = 29;
         }
      }

      private void button30_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 30;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 30;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 30);
            whiteLightPosition = 30;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 30);
            redTrianglePosition = 30;
         }
      }

      private void button31_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 31;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 31;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 31);
            whiteLightPosition = 31;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 31);
            redTrianglePosition = 31;
         }
      }

      private void button32_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 32;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 32;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 32);
            whiteLightPosition = 32;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 32);
            redTrianglePosition = 32;
         }
      }

      private void button33_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 33;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 33;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 33);
            whiteLightPosition = 33;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 33);
            redTrianglePosition = 33;
         }
      }

      private void button34_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 34;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 34;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 34);
            whiteLightPosition = 34;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 34);
            redTrianglePosition = 34;
         }
      }

      private void button35_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 35;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 35;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 35);
            whiteLightPosition = 35;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 35);
            redTrianglePosition = 35;
         }
      }

      private void button36_Click(object sender, EventArgs e)
      {
         if (flag == PlacementFlag.Circle1)
         {
            mazeModule.Circle1 = 36;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Circle2)
         {
            mazeModule.Circle2 = 36;
            LoadMazeImage();
         }
         else if (flag == PlacementFlag.Start)
         {
            MoveWhiteLight(whiteLightPosition, 36);
            whiteLightPosition = 36;
         }
         else if (flag == PlacementFlag.End)
         {
            MoveRedTriangle(redTrianglePosition, 36);
            redTrianglePosition = 36;
         }
      }
   }
}
