using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RamdomModel
{
    class RandomModelProgram
    {
        private double[,] mMatrix;
        private bool[] mUnvisited;
        private bool[,] mConnectedNodes; // Ma trận lưu tồn tại đường đi giữa các node, nếu 1 đi được tới 2 thì mConnectedNodes[1, 2] = true, ngược lại false

        public void run()
        {
            // Size
            //Console.WriteLine("Nhap kich thuoc ma tran: ");
            //int size = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("Nhap ma tran " + size + "x" + size + ": ");
            //mMatrix = ReadMatrix(size);

            //Console.WriteLine();

            //PrintMatrix(mMatrix);

            TestValue();
            int node;

            Console.WriteLine("Kiem tra ma tran chuyen: " + IsTransitionMatrix(mMatrix));


            checkConnectionBetweenNodes();            
            PrintMatrix(mConnectedNodes);
            
            Console.WriteLine("Kiem tra lien thong giua node 1 va 2: " + IsConnected(0, 1));
            DSStateType(mMatrix);
            Console.WriteLine("Nhap vao trang thai kiem tra tinh hoi quy");
            node = Convert.ToInt32(Console.ReadLine());
            TinhHoiQuy(node,mMatrix);
            Console.WriteLine("Ket thuc chuong trinh");
            Console.ReadKey();
        }

        private void TestValue()
        {
            int size = 7;
            mMatrix = new double[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    mMatrix[i, j] = 0;
                }
            }

            mMatrix[0, 0] = 0.7;
            mMatrix[0, 2] = 0.3;

            mMatrix[1, 0] = 0.2;
            mMatrix[1, 1] = 0.8;

            mMatrix[2, 1] = 0.3;
            mMatrix[2, 3] = 0.7;

            mMatrix[3, 3] = 0.4;
            mMatrix[3, 4] = 0.4;
            mMatrix[3, 6] = 0.2;

            mMatrix[4, 4] = 0.5;
            mMatrix[4, 5] = 0.5;

            mMatrix[5, 3] = 0.2;
            mMatrix[5, 5] = 0.8;

            mMatrix[6, 6] = 1;
        }

        private double[,] ReadMatrix(int size)
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

        private void PrintMatrix(double[,] matrix)
        {
            int size = matrix.GetLength(0);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(string.Format("{0} ", matrix[i, j]));
                }
                Console.Write(Environment.NewLine);
            }
            Console.Write(Environment.NewLine);
        }

        private void PrintList(List<int> ds)
        {
            foreach (int item in ds)
            {
                Console.Write(string.Format(" {0} ",item));
            }
            Console.WriteLine();
        }

        private void PrintMatrix(bool[,] matrix)
        {
            int size = matrix.GetLength(0);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(string.Format("{0} ", matrix[i, j] ? 1 : 0));
                }
                Console.Write(Environment.NewLine);
            }            
        }

        /// <summary>
        /// Kiểm tra có phải là ma trận chuyển hay không
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        private bool IsTransitionMatrix(double[,] matrix)
        {
            int size = matrix.GetLength(0);            

            // Duyệt các hàng
            for (int i = 0; i < size; i++)
            {
                // Tính tổng hàng
                double total = 0;
                for (int j = 0; j < size; j++)
                {
                    // Nếu tồn tại phần tử < 0 thì không phải ma trận chuyển
                    if (matrix[i, j] < 0)
                        return false;

                    total += matrix[i, j];
                }

                // Nếu tổng khác 1 thì không phải ma trận chuyển, kết thúc
                if (total != 1.0f)
                    return false;
            }

            return true;
        }

        private bool IsConnected(int a, int b)
        {           
            return mConnectedNodes[a, b] && mConnectedNodes[b, a];
        }

        private void checkConnectionBetweenNodes()
        {
            int matrixSize = mMatrix.GetLength(0);
            mUnvisited = new bool[matrixSize];

            // Khởi tạo ma trận lưu tồn tại đường đi từ đỉnh này tới đỉnh kia
            mConnectedNodes = new bool[matrixSize, matrixSize];
            for (int i = 0; i < matrixSize; i++)
                for (int j = 0; j < matrixSize; j++)
                    mConnectedNodes[i, j] = false;

            // Duyệt tất cả phần tử, không cần nếu đã có đỉnh xác định
            for (int i = 0; i < matrixSize; i++)
            {
                ResetUnvisited(matrixSize);
                DFS(i, i);
            }
        }

        private void ResetUnvisited(int matrixSize)
        {
            for (int i = 0; i < matrixSize; i++)
                mUnvisited[i] = true;
        }

        private void DFS(int currentNode, int startNode)
        {
            int nearlyNode;
            int matrixSize = mMatrix.GetLength(0);

            // Lưu tồn tại đường đi giữa node bắt đầu và node đang xét
            mConnectedNodes[startNode, currentNode] = true;

            mUnvisited[currentNode] = false;
            for (nearlyNode = 0; nearlyNode < matrixSize; nearlyNode++)
            {
                if (mMatrix[currentNode, nearlyNode] > 0 && mUnvisited[nearlyNode])
                    DFS(nearlyNode, startNode);                
            }
        }

        private void DSStateType(double[,] matrix)
        {
            List<int> list;
            Console.WriteLine("danh sach cac loai trang thai la: ");
            for (int a = 0; a < matrix.GetLength(0); a++)
            {
                list = new List<int>();
                list.Add(a);
                for (int b = 0; b < matrix.GetLength(1); b++)
                {
                    if (IsConnected(a, b) == true && a!=b)
                    {
                        list.Add(b);
                    }
                }

                PrintList(list);
            }
        }

        private void TinhHoiQuy(int p,double[,] inputMatrix)
        {
            for (int i = 0; i < inputMatrix.GetLength(0); i++)
            {
                if (IsConnected(p, i) == false)
                {
                    Console.WriteLine("Nut {0} la trang thai chuyen", p);
                }
                else
                {
                    Console.WriteLine("Nut {0} la trang thai hoi quy",p);
                }
            }
        }
    }
}
