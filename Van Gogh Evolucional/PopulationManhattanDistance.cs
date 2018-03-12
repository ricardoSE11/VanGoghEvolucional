using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Van_Gogh_Evolucional
{

    class PopulationManhattanDistance
    {

        //Variables
        public List<int[]> manhattanListRed = new List<int[]>();
        public List<int[]> manhattanListGreen = new List<int[]>();
        public List<int[]> manhattanListBlue = new List<int[]>();
        //Class contructor 
        public PopulationManhattanDistance()
        {
        }

        public void manhattanDistance(int[] vector1R, int[] vector1G, int[] vector1B,int[] vector2R, int[] vector2G, int[] vector2B)
        {
            int distanceRed=0;
            int distanceGreen=0;
            int distanceBlue=0;

            for (int i=0;i<255;i++)
            {
                distanceRed += Math.Abs(vector1R[i] - vector2R[i]);
                distanceGreen += Math.Abs(vector1G[i] - vector2G[i]);
                distanceBlue += Math.Abs(vector1B[i] - vector2B[i]);
            }
        }
    }
}
