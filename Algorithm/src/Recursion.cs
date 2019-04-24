using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithm
{
    /// <summary>
    /// 递归算法
    /// </summary>
    public class Recursion
    {
        // 二维数组存储初始化数据
        int[][] D = new int[6][];
        int[][] tempArray = new int[6][];

        int num = 5;
        // 临时最大值
        int[] tempMax = new int[5];
        //
        

        public Recursion()
        {
            D[1] = new int[] { 7 };
            D[2] = new int[] { 3, 8 };
            D[3] = new int[] { 8, 1, 0 };
            D[4] = new int[] { 2, 7, 4, 4 };
            D[5] = new int[] { 4, 5, 2, 6, 5 };
            // 初始值为边界值
            tempMax = D[5];
            for (int a = num ; a >= 1; --a)
            {
                tempArray[a] = new int[a];
                for (int b = 0; b < a; ++b)
                {
                    tempArray[a][b] = -1;
                }

            }
                
        }

        /// <summary>
        /// 在上面的数字三角形中寻找一条从顶部到底边的路径，使得路径上所经过的数字之和最大。
        /// 路径上的每一步都只能往左下或 右下走。只需要求出这个最大和即可，不必给出具体路径
        /// </summary>
        public int Start()
        {
            return MaxSum(1, 0);
            
        }
        public int StartWithCache()
        {
            return MaxSumWithCache();
        }
        
        /// <summary>
        /// 求最大路径值
        /// </summary>
        /// <param name="i">行</param>
        /// <param name="j">列</param>
        /// <returns></returns>
        public int MaxSum(int i,int j)
        {

            if (i == num)
                return D[i][j];
            int x = MaxSum(i + 1, j);
            int y = MaxSum(i + 1, j + 1);
            
            int max =  Math.Max(x, y) + D[i][j];

            Console.WriteLine($"Curr Row: {i} Column: {j},The Max:{max}");
            return max;
        }

        public int MaxSumV1(int i, int j)
        {
            if(tempArray[i][j] != -1)
            {
                return tempArray[i][j];
            }
            if (i == num)
                return D[i][j];
            int x = MaxSumV1(i + 1, j);
            int y = MaxSumV1(i + 1, j + 1);

            tempArray[i][j] = Math.Max(x, y) + D[i][j]; 
            Console.WriteLine($"Curr Row: {i} Column: {j},The Max:{tempArray[i][j]}");
            return tempArray[i][j];
        }

        public int MaxSumWithCache()
        {
            for(int a=num-1;a>=1;--a)
                for(int b = 0; b < a; ++b)
                {
                    tempMax[b] = Math.Max(tempMax[b], tempMax[b + 1]) + D[a][b];
                }
            return tempMax[0];
        }
    }
}
