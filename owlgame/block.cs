using System;
using System.Drawing;
using System.Collections.Generic;
using System.Text;

namespace owlgame
{
    class block
    {
        public block(int x,int y) 
        {
            curx = x;
            cury = y;
            colorblock = boxcolors[rander.Next(3)];
            int no = rander.Next(No);
            for (int i = 0; i < size; ++i)
                for (int j = 0; j < size; ++j)
                    matblock[i, j] = blockbox[no, i, j];
        }
        
        public int[,] matblock = new int[size, size];         // 盒子矩阵
        public Color colorblock;
        public int curx,cury;                                 // 盒子的起点
        public static int size = 5;                           // 盒子矩阵的维数
        private const int No = 7;                             // 盒子的种数        
        private Random rander = new Random();                 // 随机选盒器
        private static Color[] boxcolors ={                   // 预定义盒子颜色
            Color.Red,Color.Yellow,Color.Blue
        }; 
        private static int[,,] blockbox ={                     // 预定义的盒子
            {
                {0,0,0,0,0},
                {0,0,0,0,0},
                {1,1,1,1,0},
                {0,0,0,0,0},
                {0,0,0,0,0}
            },
            
            {
                {0,0,0,0,0},
                {0,0,1,0,0},
                {0,1,1,1,0},
                {0,0,0,0,0},
                {0,0,0,0,0}
            },
            
            {
                {0,0,0,0,0},
                {0,1,1,0,0},
                {0,0,1,1,0},
                {0,0,0,0,0},
                {0,0,0,0,0}
            },
            
            {
                {0,0,0,0,0},
                {0,0,1,1,0},
                {0,1,1,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0}
            },
            
            {
                {0,0,0,0,0},
                {0,1,1,0,0},
                {0,0,1,0,0},
                {0,0,1,0,0},
                {0,0,0,0,0}
            },
            
            {
                {0,0,0,0,0},
                {0,0,1,1,0},
                {0,0,1,0,0},
                {0,0,1,0,0},
                {0,0,0,0,0}
            },
            
            {
                {0,0,0,0,0},
                {0,0,1,1,0},
                {0,0,1,1,0},
                {0,0,0,0,0},
                {0,0,0,0,0}
            }
         };
    }
}
