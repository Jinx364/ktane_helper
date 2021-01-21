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
   public partial class MorseForm : Form
   {
      public MorseForm()
      {
         InitializeComponent();
         InitializeInstructions();
      }

      private void InitializeInstructions()
      {
         instructionsTextBox.AppendText("● Interpret the signal from the flashing light using the Morse Code chart to spell one of the words in the table.");

         instructionsTextBox.AppendText("\n● The signal will loop, with a long gap between repetitions.");

         instructionsTextBox.AppendText("\n● Once the word is identified, set the corresponding frequency and press the transmit (TX) button.");
      }
   }
}
