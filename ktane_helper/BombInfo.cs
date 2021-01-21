using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktane_helper
{
   public class BombInfo
   {
      private int numStrikes;
      private int? numBatteries;

      private bool? lastSerialDigitIsOdd;
      private bool? serialContainsVowel;
      private bool? hasParallelPort;
      private bool? carIndicatorIsLit;
      private bool? frkIndicatorIsLit;

      public void Reset()
      {
         numStrikes = 0;
         numBatteries = null;

         lastSerialDigitIsOdd = null;
         serialContainsVowel = null;
         hasParallelPort = null;
         carIndicatorIsLit = null;
         frkIndicatorIsLit = null;
      }

      public int NumStrikes
      {
         get
         {
            return numStrikes;
         }
         set
         {
            numStrikes = value;
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
         }
      }

      public bool? SerialContainsVowel
      {
         get
         {
            return serialContainsVowel;
         }
         set
         {
            serialContainsVowel = value;
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
         }
      }

      public bool? CarIndicatorIsLit
      {
         get
         {
            return carIndicatorIsLit;
         }
         set
         {
            carIndicatorIsLit = value;
         }
      }

      public bool? FrkIndicatorIsLit
      {
         get
         {
            return frkIndicatorIsLit;
         }
         set
         {
            frkIndicatorIsLit = value;
         }
      }
   }
}
