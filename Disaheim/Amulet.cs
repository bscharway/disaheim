using System;
namespace Disaheim
{
    public class Amulet: Merchandise
    {
        // Auto implementation of properties
        public string Design { get; set; }
        public Level Quality { get; set; }
        private static double lowQualityValue;
        private static double mediumQualityValue;
        private static double highQualityValue;

        // Making of the stereotypes LowQualityValue, mediumQualityValue and highQualityValue
        public  static void LowQualityValue()
        {
            lowQualityValue = 12.5;
        }

        public static void MediumQualityValue()
        {
           mediumQualityValue = 20.0;
        }

        public static void HighQualityValue()
        {
            highQualityValue = 27.5;
        }

        //---------------------------------------------------------------------
        // Constuctor overloading with 3, 2 and 1 arguments
        public Amulet(string ItemId, Level Quality, string Design) 
        {
            this.ItemId = ItemId;
            this.Quality = Quality;
            this.Design = Design;
        }
        public Amulet(string ItemId, Level Quality) 
        {
            this.ItemId = ItemId;
            this.Quality = Quality;
            Design = "";
        }
        public Amulet(string ItemId) 
        {
            this.ItemId = ItemId;
            Quality = Level.medium;
            Design = "";
        }

        //--------------------------------------------------------------------

        public double GetValue()
        {
            double val = 0;

                switch (this.Quality)
                {
                    case Level.low:
                        val = 12.5;
                        break;

                    case Level.medium:
                        val = 20.0;
                        break;

                    case Level.high:
                        val = 27.5;
                        break;
                }
            
            return val;
        }

        //---------------------------------------------------------------------

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }



    }
}


