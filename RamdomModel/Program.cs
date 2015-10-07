using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RamdomModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph g = new Graph();
            g.add_vertex('A', new Dictionary<char, int>() { { 'B', 7 }, { 'C', 8 } });
            g.add_vertex('B', new Dictionary<char, int>() { { 'A', 7 }, { 'F', 2 } });
            g.add_vertex('C', new Dictionary<char, int>() { { 'A', 8 }, { 'F', 6 }, { 'G', 4 } });
            g.add_vertex('D', new Dictionary<char, int>() { { 'F', 8 } });
            g.add_vertex('E', new Dictionary<char, int>() { { 'H', 1 } });
            g.add_vertex('F', new Dictionary<char, int>() { { 'B', 2 }, { 'C', 6 }, { 'D', 8 }, { 'G', 9 }, { 'H', 3 } });
            g.add_vertex('G', new Dictionary<char, int>() { { 'C', 4 }, { 'F', 9 } });
            g.add_vertex('H', new Dictionary<char, int>() { { 'E', 1 }, { 'F', 3 } });

            g.shortest_path('A', 'H').ForEach(x => Console.WriteLine(x));

            return;

            //double[,] L ={
            //    {-1,  5, -1, -1, -1,  3, -1, -1}, 
            //    { 5, -1,  2, -1, -1, -1,  3, -1}, 
            //    {-1,  2, -1,  6, -1, -1, -1, 10}, 
            //    {-1, -1,  6, -1,  3, -1, -1, -1},
            //    {-1, -1, -1,  3, -1,  8, -1,  5}, 
            //    { 3, -1, -1, -1,  8, -1,  7, -1}, 
            //    {-1,  3, -1, -1, -1,  7, -1,  2}, 
            //    {-1, -1, 10, -1,  5, -1,  2, -1} 
            //};

            //Dijkstra d = new Dijkstra(8, L);
            //d.Run();

            //return;

            // Size
            //Console.WriteLine("Nhap kich thuoc ma tran: ");
            //int size = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("Nhap ma tran " + size + "x" + size + ": ");
            //double[,] matrix = ReadMatrix(size);

            //Console.WriteLine();

            //PrintMatrix(matrix);

            //Console.WriteLine("Kiem tra ma tran chuyen: " + IsTransitionMatrix(matrix));
        }

        private static double[,] ReadMatrix(int size)
        {
            var mtr = new double[size, size];
            for (var i = 0; i < size; i++)
            {
                var line = Console.ReadLine();
                var spl = line.Split(' ');
                if (spl.Length != size) throw new FormatException();
                for (var j = 0; j < size; j++)
                    mtr[i, j] = double.Parse(spl[j]);
            }
            return mtr;
        }

        private static void PrintMatrix(double[,] matrix)
        {
            int rowLength = matrix.GetLength(0);
            int colLength = matrix.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", matrix[i, j]));
                }
                Console.Write(Environment.NewLine);
            }
            Console.Write(Environment.NewLine);
        }

        /// <summary>
        /// Kiểm tra có phải là ma trận chuyển hay không
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        private static bool IsTransitionMatrix(double[,] matrix)
        {
            int rowLength = matrix.GetLength(0);
            int colLength = matrix.GetLength(1);

            // Duyệt các hàng
            for (int i = 0; i < rowLength; i++)
            {
                // Tính tổng hàng
                double total = 0;
                for (int j = 0; j < colLength; j++)
                {
                    total += matrix[i, j];
                }

                // Nếu tổng khác 1 thì không phải ma trận chuyển, kết thúc
                if (total != 1.0f)
                    return false;
            }

            return true;
        }

        private static bool IsConnected(int a, int b, double[,] matrix)
        {
            Graph g = new Graph();

            int rowLength = matrix.GetLength(0);
            int colLength = matrix.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                var dic = new Dictionary<char, double>();
                for (int j = 0; j < colLength; j++)
                {
                    dic.Add((char)j, matrix[i, j]);
                }
                //g.add_vertex((char)i, dic);
            }


            return false;
        }
    }
}
