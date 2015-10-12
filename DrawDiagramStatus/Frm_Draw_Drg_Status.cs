﻿using System;
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
    public partial class Frm_Draw_Drg_Status : Form
    {
        #region Global Variables
        int numberStatus;
        double [,] matrix;
        string[] status;

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

        #endregion

        #region Public Method
        public Frm_Draw_Drg_Status()
        {
            InitializeComponent();
        }
        #endregion

        #region Private Method
        private void Draw_Diagram_Status_Paint(object sender,
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
            matrix = new double[numberStatus, numberStatus];
            status = new string[numberStatus];
            Random rand = new Random();
            //init matrix
            matrix = new double[5, 5]   {{0, 0.1, 0, 0, 0.9}
                                    ,{0.4, 0, 0, 0.6, 0}
                                    ,{0.2, 0, 0, 0, 0.8}
                                    ,{0, 0, 0.3, 0, 0.7}
                                    ,{0, 0.1, 0.4, 0, .5}};

            ////random
            //for (int i = 0; i < numberStatus; i++)
            //{
            //    for (int j = 0; j < numberStatus; j++)
            //    {
            //        matrix[i, j] = rand.Next(0, 11) * 0.1;
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

        private void CreateCurve(Graphics g, int numberStatus, double[,] matrix)
        {
            SolidBrush myBrush = new SolidBrush(Color.Navy);
            Font myFont = new Font("Times New Roman", 9);
            Pen pn = new Pen(Color.Green, 1);
            for (int i = 0; i < numberStatus; i++)
            {
                for (int j = 0; j < numberStatus; j++)
                {
                    #region curve bottom
                    if (matrix[i, j] > 0 && j > i)
                    {
                        //Draw Curve
                        Rectangle rect = new Rectangle(con.int_x_st + i * con.int_distance_st + con.int_size_st / 2
                                                     , con.int_y_st - ((j - i) * con.int_distance_st / 2) / 2 + con.int_size_st
                                                     , (j - i) * con.int_distance_st
                                                     , (j - i) * con.int_distance_st / 2);
                        g.DrawArc(pn, rect, 0, 180);
                        //Draw rows
                        g.DrawLines(pn, new PointF[] {    new PointF(con.int_x_st + con.int_size_st / 2 + (j + i) * con.int_distance_st/2 - con.size_row
                                                                   , con.int_y_st + ((j - i) * con.int_distance_st / 2) / 2 + con.int_size_st - con.size_row)
                                                        , new PointF(con.int_x_st + con.int_size_st / 2 + (j + i) * con.int_distance_st/2
                                                                   , con.int_y_st + ((j - i) * con.int_distance_st / 2) / 2 + con.int_size_st) 
                                                        , new PointF(con.int_x_st + con.int_size_st / 2 + (j + i) * con.int_distance_st/2 - con.size_row
                                                                   , con.int_y_st + ((j - i) * con.int_distance_st / 2) / 2 + con.int_size_st + con.size_row)}
                        );
                        //Draw value on curve
                        g.DrawString( matrix[i, j].ToString("0.0")
                                    , myFont, myBrush
                                    , con.int_x_st + con.int_size_st / 2 + (j + i) * con.int_distance_st / 2 - con.size_row
                                    , con.int_y_st + ((j - i) * con.int_distance_st / 2) / 2 + con.int_size_st + con.size_row);
                    }
                    #endregion
 
                    #region curve top
                    if (matrix[i, j] > 0 && j < i)
                    {
                        //Draw curves
                        Rectangle rect = new Rectangle(con.int_x_st + j * con.int_distance_st + con.int_size_st / 2
                                                     , con.int_y_st - ((i - j) * con.int_distance_st / 2) / 2
                                                     , (i - j) * con.int_distance_st
                                                     , (i - j) * con.int_distance_st / 2);
                        g.DrawArc(pn, rect, 0, -180);
                        //Draw rows
                        g.DrawLines(pn, new PointF[] {    new PointF(con.int_x_st + (j + i) * con.int_distance_st/2 + con.int_size_st / 2 + con.size_row 
                                                                   ,  con.int_y_st - ((i - j) * con.int_distance_st / 2) / 2 - con.size_row)
                                                        , new PointF(con.int_x_st + (j + i) * con.int_distance_st/2 + con.int_size_st / 2
                                                                   ,  con.int_y_st - ((i - j) * con.int_distance_st / 2) / 2) 
                                                        , new PointF(con.int_x_st + (j + i) * con.int_distance_st/2 + con.int_size_st / 2 + con.size_row
                                                                   ,  con.int_y_st - ((i - j) * con.int_distance_st / 2) / 2 + con.size_row)}
                                    );
                        //Draw value on curve
                        g.DrawString(matrix[i, j].ToString("0.0")
                                    , myFont, myBrush
                                    , con.int_x_st + (j + i) * con.int_distance_st / 2 + con.int_size_st / 2 + con.size_row
                                    , con.int_y_st - ((i - j) * con.int_distance_st / 2) / 2 - con.size_row*4);
                    }
                    #endregion
    
                    #region curve itself
                    if (matrix[i, j] > 0 && j == i)
                    {
                        //Draw curves
                        Rectangle rect = new Rectangle(con.int_x_st + j * con.int_distance_st - con.int_size_st
                                                     , con.int_y_st - ((i - j) * con.int_distance_st / 2) / 2
                                                     , con.int_size_st * 3 / 2
                                                     , con.int_size_st);
                        g.DrawArc(pn, rect, 35, 280);
                        //Draw rows
                        g.DrawLines(pn, new PointF[] {    new PointF(con.int_x_st + j * con.int_distance_st - con.int_size_st - con.size_row + 1
                                                                   ,  con.int_y_st - ((i - j) * con.int_distance_st / 2) / 2 - con.size_row + con.size_st/2)
                                                        , new PointF(con.int_x_st + j * con.int_distance_st - con.int_size_st 
                                                                   ,  con.int_y_st - ((i - j) * con.int_distance_st / 2) / 2 + con.size_st/2) 
                                                        , new PointF(con.int_x_st + j * con.int_distance_st - con.int_size_st + con.size_row +3 
                                                                   ,  con.int_y_st - ((i - j) * con.int_distance_st / 2) / 2 - con.size_row + con.size_st/2) }
                                    );
                        //Draw value on curve
                        g.DrawString(matrix[i, j].ToString("0.0")
                                    , myFont, myBrush
                                    , con.int_x_st + j * con.int_distance_st - con.int_size_st*3/2 - 2
                                    , con.int_y_st - ((i - j) * con.int_distance_st / 2) / 2);
                    }
                    #endregion
                }
            }
        }
        #endregion
    }
}
