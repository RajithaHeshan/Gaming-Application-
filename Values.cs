using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDSA_22._2
{
    public class Values
    {
        public static string playerName { get; set; }
        public static int totalWeight { get; set; }
        public static int userAnswer { get; set; }
        public static int[] parent { get; set; }
        public static int[,] graph { get; set; }
        public static int verticesCount { get; set; }

        public static List<int> uAnswer { get; set; } = new List<int>();
        public static List<int> tDistance { get; set; } = new List<int>();
    }
}
