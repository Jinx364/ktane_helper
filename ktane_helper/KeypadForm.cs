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
   public partial class KeypadForm : Form
   {
      private static KeypadModule keypadModule;
      private static int fullSolution;

      public KeypadForm()
      {
         InitializeComponent();
         InitializeModule();
         fullSolution = 0;
      }

      private void InitializeModule()
      {
         keypadModule = new KeypadModule();
      }

      private void uncheckButton_Click(object sender, EventArgs e)
      {
         checkBox1.Checked  = false;
         checkBox2.Checked  = false;
         checkBox3.Checked  = false;
         checkBox4.Checked  = false;
         checkBox5.Checked  = false;
         checkBox6.Checked  = false;
         checkBox7.Checked  = false;
         checkBox8.Checked  = false;
         checkBox9.Checked  = false;
         checkBox10.Checked = false;
         checkBox11.Checked = false;
         checkBox12.Checked = false;
         checkBox13.Checked = false;
         checkBox14.Checked = false;
         checkBox15.Checked = false;
         checkBox16.Checked = false;
         checkBox17.Checked = false;
         checkBox18.Checked = false;
         checkBox19.Checked = false;
         checkBox20.Checked = false;
         checkBox21.Checked = false;
         checkBox22.Checked = false;
         checkBox23.Checked = false;
         checkBox24.Checked = false;
         checkBox25.Checked = false;
         checkBox26.Checked = false;
         checkBox27.Checked = false;
         DisplayAnswers();
      }

      private void DisplayAnswers()
      {
         List<int> keypadSolution = keypadModule.KeypadSolution;
         int possibleSolution = keypadModule.PossibleSolutionIndex;

         FillSolutionPictureBoxes(GetSolutionImagesFromIndex(possibleSolution));

         if (keypadSolution.Count == 4)
         {
            firstSolPictureBox.Image = GetImageFromIndex(keypadSolution[0]);
            firstSolPictureBox.Invalidate();

            secondSolPictureBox.Image = GetImageFromIndex(keypadSolution[1]);
            secondSolPictureBox.Invalidate();

            thirdSolPictureBox.Image = GetImageFromIndex(keypadSolution[2]);
            thirdSolPictureBox.Invalidate();

            fourthSolPictureBox.Image = GetImageFromIndex(keypadSolution[3]);
            fourthSolPictureBox.Invalidate();
         }
         else
         {
            firstSolPictureBox.Image = null;
            firstSolPictureBox.Invalidate();

            secondSolPictureBox.Image = null;
            secondSolPictureBox.Invalidate();

            thirdSolPictureBox.Image = null;
            thirdSolPictureBox.Invalidate();

            fourthSolPictureBox.Image = null;
            fourthSolPictureBox.Invalidate();
         }
      }

      private List<Image> GetSolutionImagesFromIndex(int index)
      {
         List<Image> images = new List<Image>();

         if (index == 28)
         {
            images.Add(Properties.Resources.keypad1);
            images.Add(Properties.Resources.keypad2);
            images.Add(Properties.Resources.keypad3);
            images.Add(Properties.Resources.keypad4);
            images.Add(Properties.Resources.keypad5);
            images.Add(Properties.Resources.keypad6);
            images.Add(Properties.Resources.keypad7);
            fullSolution = 1;
         }
         else if (index == 29)
         {
            images.Add(Properties.Resources.keypad8);
            images.Add(Properties.Resources.keypad1);
            images.Add(Properties.Resources.keypad7);
            images.Add(Properties.Resources.keypad9);
            images.Add(Properties.Resources.keypad10);
            images.Add(Properties.Resources.keypad6);
            images.Add(Properties.Resources.keypad11);
            fullSolution = 2;
         }
         else if (index == 30)
         {
            images.Add(Properties.Resources.keypad12);
            images.Add(Properties.Resources.keypad13);
            images.Add(Properties.Resources.keypad9);
            images.Add(Properties.Resources.keypad14);
            images.Add(Properties.Resources.keypad15);
            images.Add(Properties.Resources.keypad3);
            images.Add(Properties.Resources.keypad10);
            fullSolution = 3;
         }
         else if (index == 31)
         {
            images.Add(Properties.Resources.keypad16);
            images.Add(Properties.Resources.keypad17);
            images.Add(Properties.Resources.keypad18);
            images.Add(Properties.Resources.keypad5);
            images.Add(Properties.Resources.keypad14);
            images.Add(Properties.Resources.keypad11);
            images.Add(Properties.Resources.keypad19);
            fullSolution = 4;
         }
         else if (index == 32)
         {
            images.Add(Properties.Resources.keypad20);
            images.Add(Properties.Resources.keypad19);
            images.Add(Properties.Resources.keypad18);
            images.Add(Properties.Resources.keypad21);
            images.Add(Properties.Resources.keypad17);
            images.Add(Properties.Resources.keypad22);
            images.Add(Properties.Resources.keypad23);
            fullSolution = 5;
         }
         else if (index == 33)
         {
            images.Add(Properties.Resources.keypad16);
            images.Add(Properties.Resources.keypad8);
            images.Add(Properties.Resources.keypad24);
            images.Add(Properties.Resources.keypad25);
            images.Add(Properties.Resources.keypad20);
            images.Add(Properties.Resources.keypad26);
            images.Add(Properties.Resources.keypad27);
            fullSolution = 6;
         }
         else
         {
            fullSolution = 0;
         }

         return images;
      }

      private void FillSolutionPictureBoxes(List<Image> images)
      {
         if (images.Count != 7)
         {
            fullSolution1PictureBox.Image = null;
            fullSolution2PictureBox.Image = null;
            fullSolution3PictureBox.Image = null;
            fullSolution4PictureBox.Image = null;
            fullSolution5PictureBox.Image = null;
            fullSolution6PictureBox.Image = null;
            fullSolution7PictureBox.Image = null;
         }
         else
         {
            fullSolution1PictureBox.Image = images[0];
            fullSolution2PictureBox.Image = images[1];
            fullSolution3PictureBox.Image = images[2];
            fullSolution4PictureBox.Image = images[3];
            fullSolution5PictureBox.Image = images[4];
            fullSolution6PictureBox.Image = images[5];
            fullSolution7PictureBox.Image = images[6];
         }

         fullSolution1PictureBox.Invalidate();
         fullSolution2PictureBox.Invalidate();
         fullSolution3PictureBox.Invalidate();
         fullSolution4PictureBox.Invalidate();
         fullSolution5PictureBox.Invalidate();
         fullSolution6PictureBox.Invalidate();
         fullSolution7PictureBox.Invalidate();
      }

      private Image GetImageFromIndex(int index)
      {
         Image image;

         switch (index)
         {
            case 1:
               {
                  image = Properties.Resources.keypad1;
                  break;
               }
            case 2:
               {
                  image = Properties.Resources.keypad2;
                  break;
               }
            case 3:
               {
                  image = Properties.Resources.keypad3;
                  break;
               }
            case 4:
               {
                  image = Properties.Resources.keypad4;
                  break;
               }
            case 5:
               {
                  image = Properties.Resources.keypad5;
                  break;
               }
            case 6:
               {
                  image = Properties.Resources.keypad6;
                  break;
               }
            case 7:
               {
                  image = Properties.Resources.keypad7;
                  break;
               }
            case 8:
               {
                  image = Properties.Resources.keypad8;
                  break;
               }
            case 9:
               {
                  image = Properties.Resources.keypad9;
                  break;
               }
            case 10:
               {
                  image = Properties.Resources.keypad10;
                  break;
               }
            case 11:
               {
                  image = Properties.Resources.keypad11;
                  break;
               }
            case 12:
               {
                  image = Properties.Resources.keypad12;
                  break;
               }
            case 13:
               {
                  image = Properties.Resources.keypad13;
                  break;
               }
            case 14:
               {
                  image = Properties.Resources.keypad14;
                  break;
               }
            case 15:
               {
                  image = Properties.Resources.keypad15;
                  break;
               }
            case 16:
               {
                  image = Properties.Resources.keypad16;
                  break;
               }
            case 17:
               {
                  image = Properties.Resources.keypad17;
                  break;
               }
            case 18:
               {
                  image = Properties.Resources.keypad18;
                  break;
               }
            case 19:
               {
                  image = Properties.Resources.keypad19;
                  break;
               }
            case 20:
               {
                  image = Properties.Resources.keypad20;
                  break;
               }
            case 21:
               {
                  image = Properties.Resources.keypad21;
                  break;
               }
            case 22:
               {
                  image = Properties.Resources.keypad22;
                  break;
               }
            case 23:
               {
                  image = Properties.Resources.keypad23;
                  break;
               }
            case 24:
               {
                  image = Properties.Resources.keypad24;
                  break;
               }
            case 25:
               {
                  image = Properties.Resources.keypad25;
                  break;
               }
            case 26:
               {
                  image = Properties.Resources.keypad26;
                  break;
               }
            case 27:
               {
                  image = Properties.Resources.keypad27;
                  break;
               }
            case 28:
               {
                  image = Properties.Resources.keypadSol1;
                  break;
               }
            case 29:
               {
                  image = Properties.Resources.keypadSol2;
                  break;
               }
            case 30:
               {
                  image = Properties.Resources.keypadSol3;
                  break;
               }
            case 31:
               {
                  image = Properties.Resources.keypadSol4;
                  break;
               }
            case 32:
               {
                  image = Properties.Resources.keypadSol5;
                  break;
               }
            case 33:
               {
                  image = Properties.Resources.keypadSol6;
                  break;
               }
            default:
               {
                  image = null;
                  break;
               }
         }

         return image;
      }


      // Keypad module
      private class KeypadModule
      {
         private SortedSet<int> keypadsSeen;
         private List<int> keypadSolution;
         private List<List<int>> possibleSolutions;
         private int possibleSolutionIndex;

         private static readonly List<int> fullSolutionA =
            new List<int> { 1, 2, 3, 4, 5, 6, 7 };

         private static readonly List<int> fullSolutionB =
            new List<int> { 8, 1, 7, 9, 10, 6, 11 };

         private static readonly List<int> fullSolutionC =
            new List<int> { 12, 13, 9, 14, 15, 3, 10 };

         private static readonly List<int> fullSolutionD =
            new List<int> { 16, 17, 18, 5, 14, 11, 19 };

         private static readonly List<int> fullSolutionE =
            new List<int> { 20, 19, 18, 21, 17, 22, 23 };

         private static readonly List<int> fullSolutionF =
            new List<int> { 16, 8, 24, 25, 20, 26, 27 };

         public KeypadModule()
         {
            keypadsSeen = new SortedSet<int>();
            keypadSolution = new List<int>();
            possibleSolutions = new List<List<int>>();
         }

         public void UpdateKeypads(int keypadNumber, bool isChecked)
         {
            if (isChecked)
            {
               keypadsSeen.Add(keypadNumber);
            }
            else
            {
               keypadsSeen.Remove(keypadNumber);
            }

            if (keypadsSeen.Count > 0 && keypadsSeen.Count <= 4)
            {
               CheckPossibleSolutions();
            }
            else
            {
               possibleSolutionIndex = 0;
            }

            if (keypadsSeen.Count == 4)
            {
               CalculateSolution();
            }
            else
            {
               keypadSolution.Clear();
            }
         }

         private void CalculateSolution()
         {
            keypadSolution.Clear();
            if (possibleSolutions.Count == 1)
            {
               foreach (int answer in possibleSolutions[0])
               {
                  if (keypadsSeen.Contains(answer))
                  {
                     keypadSolution.Add(answer);
                  }
               }
            }
         }

         private void CheckPossibleSolutions()
         {
            possibleSolutions.Clear();

            if (CouldBeSolution(fullSolutionA, keypadsSeen))
            {
               possibleSolutions.Add(fullSolutionA);
               possibleSolutionIndex = 28;
            }
            if (CouldBeSolution(fullSolutionB, keypadsSeen))
            {
               possibleSolutions.Add(fullSolutionB);
               possibleSolutionIndex = 29;
            }
            if (CouldBeSolution(fullSolutionC, keypadsSeen))
            {
               possibleSolutions.Add(fullSolutionC);
               possibleSolutionIndex = 30;
            }
            if (CouldBeSolution(fullSolutionD, keypadsSeen))
            {
               possibleSolutions.Add(fullSolutionD);
               possibleSolutionIndex = 31;
            }
            if (CouldBeSolution(fullSolutionE, keypadsSeen))
            {
               possibleSolutions.Add(fullSolutionE);
               possibleSolutionIndex = 32;
            }
            if (CouldBeSolution(fullSolutionF, keypadsSeen))
            {
               possibleSolutions.Add(fullSolutionF);
               possibleSolutionIndex = 33;
            }

            if (possibleSolutions.Count != 1)
            {
               possibleSolutionIndex = 0;
            }
         }

         private bool CouldBeSolution(List<int> solution, SortedSet<int> buttons)
         {
            bool retVal = true;

            foreach (int button in buttons)
            {
               if (!solution.Contains(button))
               {
                  retVal = false;
                  break;
               }
            }

            return retVal;
         }

         public int PossibleSolutionIndex
         {
            get
            {
               return possibleSolutionIndex;
            }
         }

         public List<int> KeypadSolution
         {
            get
            {
               return keypadSolution;
            }
         }
      }


      private void pictureBox1_Click(object sender, EventArgs e)
      {
         checkBox1.Checked = !checkBox1.Checked;
      }

      private void pictureBox2_Click(object sender, EventArgs e)
      {
         checkBox2.Checked = !checkBox2.Checked;
      }

      private void pictureBox3_Click(object sender, EventArgs e)
      {
         checkBox3.Checked = !checkBox3.Checked;
      }

      private void pictureBox4_Click(object sender, EventArgs e)
      {
         checkBox4.Checked = !checkBox4.Checked;
      }

      private void pictureBox5_Click(object sender, EventArgs e)
      {
         checkBox5.Checked = !checkBox5.Checked;
      }

      private void pictureBox6_Click(object sender, EventArgs e)
      {
         checkBox6.Checked = !checkBox6.Checked;
      }

      private void pictureBox7_Click(object sender, EventArgs e)
      {
         checkBox7.Checked = !checkBox7.Checked;
      }

      private void pictureBox8_Click(object sender, EventArgs e)
      {
         checkBox8.Checked = !checkBox8.Checked;
      }

      private void pictureBox9_Click(object sender, EventArgs e)
      {
         checkBox9.Checked = !checkBox9.Checked;
      }

      private void pictureBox10_Click(object sender, EventArgs e)
      {
         checkBox10.Checked = !checkBox10.Checked;
      }

      private void pictureBox11_Click(object sender, EventArgs e)
      {
         checkBox11.Checked = !checkBox11.Checked;
      }

      private void pictureBox12_Click(object sender, EventArgs e)
      {
         checkBox12.Checked = !checkBox12.Checked;
      }

      private void pictureBox13_Click(object sender, EventArgs e)
      {
         checkBox13.Checked = !checkBox13.Checked;
      }

      private void pictureBox14_Click(object sender, EventArgs e)
      {
         checkBox14.Checked = !checkBox14.Checked;
      }

      private void pictureBox15_Click(object sender, EventArgs e)
      {
         checkBox15.Checked = !checkBox15.Checked;
      }

      private void pictureBox16_Click(object sender, EventArgs e)
      {
         checkBox16.Checked = !checkBox16.Checked;
      }

      private void pictureBox17_Click(object sender, EventArgs e)
      {
         checkBox17.Checked = !checkBox17.Checked;
      }

      private void pictureBox18_Click(object sender, EventArgs e)
      {
         checkBox18.Checked = !checkBox18.Checked;
      }

      private void pictureBox19_Click(object sender, EventArgs e)
      {
         checkBox19.Checked = !checkBox19.Checked;
      }

      private void pictureBox20_Click(object sender, EventArgs e)
      {
         checkBox20.Checked = !checkBox20.Checked;
      }

      private void pictureBox21_Click(object sender, EventArgs e)
      {
         checkBox21.Checked = !checkBox21.Checked;
      }

      private void pictureBox22_Click(object sender, EventArgs e)
      {
         checkBox22.Checked = !checkBox22.Checked;
      }

      private void pictureBox23_Click(object sender, EventArgs e)
      {
         checkBox23.Checked = !checkBox23.Checked;
      }

      private void pictureBox24_Click(object sender, EventArgs e)
      {
         checkBox24.Checked = !checkBox24.Checked;
      }

      private void pictureBox25_Click(object sender, EventArgs e)
      {
         checkBox25.Checked = !checkBox25.Checked;
      }

      private void pictureBox26_Click(object sender, EventArgs e)
      {
         checkBox26.Checked = !checkBox26.Checked;
      }

      private void pictureBox27_Click(object sender, EventArgs e)
      {
         checkBox27.Checked = !checkBox27.Checked;
      }

      private void checkBox1_CheckedChanged(object sender, EventArgs e)
      {
         keypadModule.UpdateKeypads(1, checkBox1.Checked);
         DisplayAnswers();
      }

      private void checkBox2_CheckedChanged(object sender, EventArgs e)
      {
         keypadModule.UpdateKeypads(2, checkBox2.Checked);
         DisplayAnswers();
      }

      private void checkBox3_CheckedChanged(object sender, EventArgs e)
      {
         keypadModule.UpdateKeypads(3, checkBox3.Checked);
         DisplayAnswers();
      }

      private void checkBox4_CheckedChanged(object sender, EventArgs e)
      {
         keypadModule.UpdateKeypads(4, checkBox4.Checked);
         DisplayAnswers();
      }

      private void checkBox5_CheckedChanged(object sender, EventArgs e)
      {
         keypadModule.UpdateKeypads(5, checkBox5.Checked);
         DisplayAnswers();
      }

      private void checkBox6_CheckedChanged(object sender, EventArgs e)
      {
         keypadModule.UpdateKeypads(6, checkBox6.Checked);
         DisplayAnswers();
      }

      private void checkBox7_CheckedChanged(object sender, EventArgs e)
      {
         keypadModule.UpdateKeypads(7, checkBox7.Checked);
         DisplayAnswers();
      }

      private void checkBox8_CheckedChanged(object sender, EventArgs e)
      {
         keypadModule.UpdateKeypads(8, checkBox8.Checked);
         DisplayAnswers();
      }

      private void checkBox9_CheckedChanged(object sender, EventArgs e)
      {
         keypadModule.UpdateKeypads(9, checkBox9.Checked);
         DisplayAnswers();
      }

      private void checkBox10_CheckedChanged(object sender, EventArgs e)
      {
         keypadModule.UpdateKeypads(10, checkBox10.Checked);
         DisplayAnswers();
      }

      private void checkBox11_CheckedChanged(object sender, EventArgs e)
      {
         keypadModule.UpdateKeypads(11, checkBox11.Checked);
         DisplayAnswers();
      }

      private void checkBox12_CheckedChanged(object sender, EventArgs e)
      {
         keypadModule.UpdateKeypads(12, checkBox12.Checked);
         DisplayAnswers();
      }

      private void checkBox13_CheckedChanged(object sender, EventArgs e)
      {
         keypadModule.UpdateKeypads(13, checkBox13.Checked);
         DisplayAnswers();
      }

      private void checkBox14_CheckedChanged(object sender, EventArgs e)
      {
         keypadModule.UpdateKeypads(14, checkBox14.Checked);
         DisplayAnswers();
      }

      private void checkBox15_CheckedChanged(object sender, EventArgs e)
      {
         keypadModule.UpdateKeypads(15, checkBox15.Checked);
         DisplayAnswers();
      }

      private void checkBox16_CheckedChanged(object sender, EventArgs e)
      {
         keypadModule.UpdateKeypads(16, checkBox16.Checked);
         DisplayAnswers();
      }

      private void checkBox17_CheckedChanged(object sender, EventArgs e)
      {
         keypadModule.UpdateKeypads(17, checkBox17.Checked);
         DisplayAnswers();
      }

      private void checkBox18_CheckedChanged(object sender, EventArgs e)
      {
         keypadModule.UpdateKeypads(18, checkBox18.Checked);
         DisplayAnswers();
      }

      private void checkBox19_CheckedChanged(object sender, EventArgs e)
      {
         keypadModule.UpdateKeypads(19, checkBox19.Checked);
         DisplayAnswers();
      }

      private void checkBox20_CheckedChanged(object sender, EventArgs e)
      {
         keypadModule.UpdateKeypads(20, checkBox20.Checked);
         DisplayAnswers();
      }

      private void checkBox21_CheckedChanged(object sender, EventArgs e)
      {
         keypadModule.UpdateKeypads(21, checkBox21.Checked);
         DisplayAnswers();
      }

      private void checkBox22_CheckedChanged(object sender, EventArgs e)
      {
         keypadModule.UpdateKeypads(22, checkBox22.Checked);
         DisplayAnswers();
      }

      private void checkBox23_CheckedChanged(object sender, EventArgs e)
      {
         keypadModule.UpdateKeypads(23, checkBox23.Checked);
         DisplayAnswers();
      }

      private void checkBox24_CheckedChanged(object sender, EventArgs e)
      {
         keypadModule.UpdateKeypads(24, checkBox24.Checked);
         DisplayAnswers();
      }

      private void checkBox25_CheckedChanged(object sender, EventArgs e)
      {
         keypadModule.UpdateKeypads(25, checkBox25.Checked);
         DisplayAnswers();
      }

      private void checkBox26_CheckedChanged(object sender, EventArgs e)
      {
         keypadModule.UpdateKeypads(26, checkBox26.Checked);
         DisplayAnswers();
      }

      private void checkBox27_CheckedChanged(object sender, EventArgs e)
      {
         keypadModule.UpdateKeypads(27, checkBox27.Checked);
         DisplayAnswers();
      }

      private void fullSolution1PictureBox_Click(object sender, EventArgs e)
      {
         if (fullSolution == 1)
         {
            checkBox1.Checked = !checkBox1.Checked;
         }
         else if (fullSolution == 2)
         {
            checkBox8.Checked = !checkBox8.Checked;
         }
         else if (fullSolution == 3)
         {
            checkBox12.Checked = !checkBox12.Checked;
         }
         else if (fullSolution == 4)
         {
            checkBox16.Checked = !checkBox16.Checked;
         }
         else if (fullSolution == 5)
         {
            checkBox20.Checked = !checkBox20.Checked;
         }
         else if (fullSolution == 6)
         {
            checkBox16.Checked = !checkBox16.Checked;
         }
      }

      private void fullSolution2PictureBox_Click(object sender, EventArgs e)
      {
         if (fullSolution == 1)
         {
            checkBox2.Checked = !checkBox2.Checked;
         }
         else if (fullSolution == 2)
         {
            checkBox1.Checked = !checkBox1.Checked;
         }
         else if (fullSolution == 3)
         {
            checkBox13.Checked = !checkBox13.Checked;
         }
         else if (fullSolution == 4)
         {
            checkBox17.Checked = !checkBox17.Checked;
         }
         else if (fullSolution == 5)
         {
            checkBox19.Checked = !checkBox19.Checked;
         }
         else if (fullSolution == 6)
         {
            checkBox8.Checked = !checkBox8.Checked;
         }
      }

      private void fullSolution3PictureBox_Click(object sender, EventArgs e)
      {
         if (fullSolution == 1)
         {
            checkBox3.Checked = !checkBox3.Checked;
         }
         else if (fullSolution == 2)
         {
            checkBox7.Checked = !checkBox7.Checked;
         }
         else if (fullSolution == 3)
         {
            checkBox9.Checked = !checkBox9.Checked;
         }
         else if (fullSolution == 4)
         {
            checkBox18.Checked = !checkBox18.Checked;
         }
         else if (fullSolution == 5)
         {
            checkBox18.Checked = !checkBox18.Checked;
         }
         else if (fullSolution == 6)
         {
            checkBox24.Checked = !checkBox24.Checked;
         }
      }

      private void fullSolution4PictureBox_Click(object sender, EventArgs e)
      {
         if (fullSolution == 1)
         {
            checkBox4.Checked = !checkBox4.Checked;
         }
         else if (fullSolution == 2)
         {
            checkBox9.Checked = !checkBox9.Checked;
         }
         else if (fullSolution == 3)
         {
            checkBox14.Checked = !checkBox14.Checked;
         }
         else if (fullSolution == 4)
         {
            checkBox5.Checked = !checkBox5.Checked;
         }
         else if (fullSolution == 5)
         {
            checkBox21.Checked = !checkBox21.Checked;
         }
         else if (fullSolution == 6)
         {
            checkBox25.Checked = !checkBox25.Checked;
         }
      }

      private void fullSolution5PictureBox_Click(object sender, EventArgs e)
      {
         if (fullSolution == 1)
         {
            checkBox5.Checked = !checkBox5.Checked;
         }
         else if (fullSolution == 2)
         {
            checkBox10.Checked = !checkBox10.Checked;
         }
         else if (fullSolution == 3)
         {
            checkBox15.Checked = !checkBox15.Checked;
         }
         else if (fullSolution == 4)
         {
            checkBox14.Checked = !checkBox14.Checked;
         }
         else if (fullSolution == 5)
         {
            checkBox17.Checked = !checkBox17.Checked;
         }
         else if (fullSolution == 6)
         {
            checkBox20.Checked = !checkBox20.Checked;
         }
      }

      private void fullSolution6PictureBox_Click(object sender, EventArgs e)
      {
         if (fullSolution == 1)
         {
            checkBox6.Checked = !checkBox6.Checked;
         }
         else if (fullSolution == 2)
         {
            checkBox6.Checked = !checkBox6.Checked;
         }
         else if (fullSolution == 3)
         {
            checkBox3.Checked = !checkBox3.Checked;
         }
         else if (fullSolution == 4)
         {
            checkBox11.Checked = !checkBox11.Checked;
         }
         else if (fullSolution == 5)
         {
            checkBox22.Checked = !checkBox22.Checked;
         }
         else if (fullSolution == 6)
         {
            checkBox26.Checked = !checkBox26.Checked;
         }
      }

      private void fullSolution7PictureBox_Click(object sender, EventArgs e)
      {
         if (fullSolution == 1)
         {
            checkBox7.Checked = !checkBox7.Checked;
         }
         else if (fullSolution == 2)
         {
            checkBox11.Checked = !checkBox11.Checked;
         }
         else if (fullSolution == 3)
         {
            checkBox10.Checked = !checkBox10.Checked;
         }
         else if (fullSolution == 4)
         {
            checkBox19.Checked = !checkBox19.Checked;
         }
         else if (fullSolution == 5)
         {
            checkBox23.Checked = !checkBox23.Checked;
         }
         else if (fullSolution == 6)
         {
            checkBox27.Checked = !checkBox27.Checked;
         }
      }
   }
}
