using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawDiagramStatus
{
    public partial class Form1 : Form
    {
        int numberStatus;
        int[,] matrix;
        string[] status;

        public Form1()
        {
            InitializeComponent();
        }
        static class con
        {
            //float
            public const double Pi = 3.14159;
            public const float size_st = 25;
            public const float distance_st = 100;
            public const float x_st = 100;
            public const float y_st = 200;
            public const float size_row = 5;

            //int
            public const int int_size_st = 25;
            public const int int_x_st = 100;
            public const int int_y_st = 200;
            public const int int_distance_st = 100;
        }
        private void Form1_Paint(object sender,
           System.Windows.Forms.PaintEventArgs pe)
        {
            initData();
            Graphics g = pe.Graphics;
            CreatePointStatus(g, numberStatus, status);
            CreateCurve(g, numberStatus, matrix);
        }
        private void initData()
        {
            numberStatus = 5;
            matrix = new int[numberStatus, numberStatus];
            status = new string[numberStatus];
            Random rand = new Random();
            //init matrix
            matrix = new int[5, 5]   {{0, 1, 0, 0, 1}
                                    ,{1, 0, 0, 1, 0}
                                    ,{1, 0, 0, 0, 1}
                                    ,{0, 0, 1, 0, 1}
                                    ,{0, 1, 0, 0, 1}};
            ////random
            //for (int i = 0; i < numberStatus; i++)
            //{
            //    for (int j = 0; j < numberStatus; j++)
            //    {
            //        matrix[i, j] = rand.Next(0,2);
            //    }
            //}

            //init status
            for (int i = 0; i < numberStatus; i++)
            {
                status[i] = Convert.ToString(i + 1);
            }
        }

        private void CreatePointStatus(Graphics g, int numberStatus, string[] status)
        {
            SolidBrush myBrush = new SolidBrush(Color.Red);
            Font myFont = new Font("Times New Roman", 11);
            Pen pn = new Pen(Color.Blue, 1);
            for (int i = 0; i < numberStatus; i++)
            {
                g.DrawEllipse(pn, (con.x_st + i * con.distance_st), con.y_st, con.size_st, con.size_st);
                g.DrawString(status[i], myFont, myBrush, (con.x_st + 6 + i * con.distance_st), con.y_st + 5);
            }
        }
        private void CreateCurve(Graphics g, int numberStatus, int[,] matrix)
        {
            Font myFont = new Font("Times New Roman", 11);
            Pen pn = new Pen(Color.Green, 1);
            for (int i = 0; i < numberStatus; i++)
            {
                for (int j = 0; j < numberStatus; j++)
                {
                    // chiều từ i -> j
                    if (matrix[i, j] == 1 && j > i)
                    {
                        Rectangle rect = new Rectangle(con.int_x_st + i * con.int_distance_st + con.int_size_st / 2
                                                     , con.int_y_st - ((j - i) * con.int_distance_st / 2) / 2 + con.int_size_st
                                                     , (j - i) * con.int_distance_st
                                                     , (j - i) * con.int_distance_st / 2);
                        g.DrawArc(pn, rect, 0, 180);
                        //create rows
                        //g.DrawLines(pn, new PointF[] {    new PointF(con.x_st + i*con.distance_st*3/2 - con.size_row + con.size_st/2
                        //                                           , con.int_y_st - ((j - i) * con.int_distance_st) / 2 + con.int_size_st + con.size_row)
                        //                                , new PointF(con.x_st + i*con.distance_st*3/2 + con.size_st/2
                        //                                           ,con.int_y_st - ((j - i) * con.int_distance_st) / 2 + con.int_size_st + con.size_row) 
                        //                                , new PointF(con.x_st + i*con.distance_st*3/2 + con.size_row + con.size_st/2
                        //                                           ,con.int_y_st - ((j - i) * con.int_distance_st) / 2 + con.int_size_st + con.size_row)}
                        //);
                    }

                    // chiều j -> i
                    if (matrix[i, j] == 1 && j < i)
                    {
                        Rectangle rect = new Rectangle(con.int_x_st + j * con.int_distance_st + con.int_size_st / 2
                                                     , con.int_y_st - ((i - j) * con.int_distance_st / 2) / 2
                                                     , (i - j) * con.int_distance_st
                                                     , (i - j) * con.int_distance_st / 2);
                        g.DrawArc(pn, rect, 0, -180);
                        //g.DrawLines(pn, new PointF[] {    new PointF(con.x_st + (i-j)*con.distance_st - con.size_row + con.size_st/2
                        //                                           , con.y_st + con.size_st + con.size_row)
                        //                                , new PointF(con.x_st + (i-j)*con.distance_st + con.size_st/2
                        //                                           , con.y_st + con.size_st) 
                        //                                , new PointF(con.x_st + (i-j)*con.distance_st + con.size_row + con.size_st/2
                        //                                           , con.y_st + con.size_st + con.size_row)}
                        //             );
                    }
                    // i = j
                    if (matrix[i, j] == 1 && j == i)
                    {
                        Rectangle rect = new Rectangle(con.int_x_st + j * con.int_distance_st - con.int_size_st
                                                     , con.int_y_st - ((i - j) * con.int_distance_st / 2) / 2
                                                     , con.int_size_st * 3 / 2
                                                     , con.int_size_st);
                        //g.DrawRectangle(pn, con.int_x_st + j * con.int_distance_st + con.int_size_st 
                        //                             , con.int_y_st - ((i - j) * con.int_distance_st / 2) / 2
                        //                             , con.int_size_st
                        //                             , con.int_size_st);
                        g.DrawArc(pn, rect, 35, 280);
                    }

                }
            }
        }
    }
}
