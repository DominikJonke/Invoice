using System;

namespace Invoice
{
    public static class Invoice
    {
        const int fullDrum = 500;
        public static double FullLength(int drum)
        {
            int cableSum = 0;
            int diffDrum = 0;

            if(drum > 0 && drum % fullDrum != 0)
            {
                diffDrum = (drum % fullDrum);
                cableSum = (drum - diffDrum);

                return (diffDrum * 3) + (cableSum * 2);
            }
            
            else if (drum > 0 && drum % fullDrum == 0)
            {
                cableSum = (drum) * 2;
                
                return cableSum;
            }

            return -1;
        }

        public static double ConsumedDrums(int cabeldrum)
        {
            int drums = 0;
            int diff = 0;

            if (cabeldrum > 0)
            {
                diff = cabeldrum % fullDrum;
                drums = (cabeldrum - diff) / fullDrum;
            }

            return drums;
        }

        public static double ConsumedRemainingCables(int drums)
        {
            int remainingCable = 0;

            if (drums > 0 && drums % fullDrum != 0)
            {
                remainingCable = drums % fullDrum;
            }

            return remainingCable;
        }
    }
}
