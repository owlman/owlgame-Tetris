using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace owlgame
{
    class gameController
    {
        // game interface:
        public gameController(Panel v) 
        {
            view = v;
            lineNo = rowNo * v.Height / v.Width;
            bw = v.Width / rowNo;
            bh = v.Height / lineNo;
            map = new List<int[]>();
            now = new block(rowNo / 2 - 2, 0);            
            for (int i = 0; i < lineNo; ++i)
                map.Add(new int[rowNo]);  
            initMap();
            wait = new block(rowNo / 2 - 2, 0);
        }
        public void initMap()
        {            
            for (int i = 0; i < lineNo; ++i)
                for (int j = 0; j < rowNo; ++j)
                {
                    if (j < 2 || j > rowNo - 3 || i > lineNo - 3)
                         map[i][j] = 2;
                }
        }      

       public bool down(int i)
        {
            if (i < 1)
                i = 1;
            int newy = now.cury + 1*i;
            if (test(now.curx, newy, now.matblock))
            {
                now.cury = newy;
                Invalidateblock();
                return true;
            }
            return false; 
        }
        public void move(bool sign) 
        {
            int newx;
            if (sign)
                newx = now.curx + 1;
            else 
                newx = now.curx - 1;
            if (newx >= 0 && newx+block.size <= rowNo
                && test(newx,now.cury,now.matblock))
            { 
                now.curx = newx;
                Invalidateblock();
            }
        }
        public void transpose()
        {
            block temp = new block(now.curx, now.cury);
            temp.colorblock = now.colorblock;
            for (int i = 0; i < block.size; ++i)
                for (int j = block.size-1; j >= 0; --j)
                    temp.matblock[j, i] =  now.matblock[i, block.size-1 - j];
            if (temp.curx >=0 && temp.curx+block.size <= rowNo
                && test(temp.curx, temp.cury, temp.matblock))
            {
                now = temp;
                Invalidateblock();
            }
        }
        private void Invalidateblock()
        {
            for (int i = 0; i < 2*block.size; ++i)
                for (int j = 0; j < 2 * block.size; ++j)
                {
                       Rectangle rect = new Rectangle
                        (
                            (j + now.curx-4) * bw,
                            (i + now.cury-4) * bh,
                            bw, bh
                        );
                        view.Invalidate(rect);
                    
                }
        }
        public bool test(int mi,int mj,int[,]m) 
        {
            for (int j = 0; j < block.size; ++j)
                for (int i = 0; i < block.size; ++i)
                   if (map[mj+j][mi+i]>=1 && m[j,i]==1)
                       return false;
            return true;
        }
        public void draw(PaintEventArgs e) 
        {            
            Pen pen = new Pen(view.BackColor);
            SolidBrush brush = new SolidBrush(Color.AliceBlue);
            for (int i = 0; i < lineNo; ++i)
                for (int j = 0; j < rowNo; ++j)
                {
                    if (map[i][j] == 1)
                    {
                        Rectangle rect = new Rectangle
                            (
                                view.ClientRectangle.X + j * bw,
                                view.ClientRectangle.Y + i * bh,
                                bw, bh
                            );
                        e.Graphics.FillRectangle(brush, rect);
                        e.Graphics.DrawRectangle(pen, rect);
                    }
                    if (map[i][j] == 2)
                    {
                        Color t = brush.Color;
                        brush.Color = Color.Gray;
                        Rectangle rect = new Rectangle
                            (
                                view.ClientRectangle.X + j * bw,
                                view.ClientRectangle.Y + i * bh,
                                bw, bh
                            );
                        e.Graphics.FillRectangle(brush, rect);
                        e.Graphics.DrawRectangle(pen, rect);
                        brush.Color = t;
                    }

                }
            brush.Color = now.colorblock;
            for (int i = 0; i < block.size; ++i)
                for (int j = 0; j < block.size; ++j)
                {
                    if (now.matblock[i, j] == 1)
                    {
                        Rectangle rect = new Rectangle
                        (
                            (j + now.curx) * bw,
                            (i + now.cury) * bh,
                            bw, bh
                        );
                        e.Graphics.FillRectangle(brush, rect);
                        e.Graphics.DrawRectangle(pen, rect);
                    }
                }
            pen.Dispose();
            brush.Dispose();

        }
        public void putblock()
        {                         ;
        for (int i = 0; i < block.size; ++i)
                for (int j = 0; j < block.size; ++j) 
                    if (now.matblock[i,j] == 1)
                        map[i+now.cury][j+now.curx] = now.matblock[i,j];
        }
        public void clearLine() 
        {
            bool isclear = false;
            for (int i = 0; i < lineNo - 2; ++i)
            {
                isclear = true;
                for (int j = 2; j < rowNo - 2; ++j)
                    if (map[i][j] != 1)
                    {
                        isclear = false;
                        break;
                    }
                if (isclear)
                {
                    map.RemoveAt(i);
                    map.Insert(0, new int[rowNo]);
                    initMap();
                }
            }
        }
        public void startnext()
        {
            now = wait;
            wait = new block(rowNo / 2 - 2, 0);
        }
        public void drawwait(PictureBox box, PaintEventArgs e)
        {
            Pen pen = new Pen(view.BackColor);
            SolidBrush brush = new SolidBrush(wait.colorblock);
            for (int i = 0; i < block.size; ++i)
                for (int j = 0; j < block.size; ++j)
                {
                    if (wait.matblock[i, j] == 1)
                    {
                        Rectangle rect = new Rectangle
                        (
                            box.Width/4 + j*bw,
                            box.Height/9 + i*bh,
                            bw, bh
                        );
                        e.Graphics.FillRectangle(brush, rect);
                        e.Graphics.DrawRectangle(pen, rect);
                    }
                }
            pen.Dispose();
            brush.Dispose();
        }
        public bool fall()
        {
            for (int i = 3; i < rowNo-2; ++i)
            {
                if (map[2][i] == 1)
                    return true;
            }
            return false;
        }

        // game data:
        private block now;
        private block wait;
        private List<int[]> map;
        private Panel view;
        private int bw;
        private int bh;
        private const int rowNo = 20;
        private int lineNo;
            
     }
}