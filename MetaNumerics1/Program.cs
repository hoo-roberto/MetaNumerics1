using System;
using Meta.Numerics.Matrices;

namespace MetaNumerico1
{
    class Program
    {

        static ColumnVector v = new ColumnVector(2.0, 0.0, -1.0);
        static ColumnVector w = new ColumnVector(new double[] { 1.0, -0.5, 1.5 });
        static SquareMatrix A = new SquareMatrix(new double[,] { { 1, -2, 3 }, { 2, -5, 12 }, { 0, 2, -10 } });

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="M"></param>
        public static void PrintMatrix(string name, AnyRectangularMatrix M)
        {
            Console.WriteLine($"{name}=");
            for (int r = 0; r < M.RowCount; r++)
            {
                for (int c = 0; c < M.ColumnCount; c++)
                {
                    Console.Write("{0,10:g4}", M[r, c]);
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            RowVector u = new RowVector(4);
            for (int i = 0; i < u.Dimension; i++) u[i] = i;

            Random rng = new Random();
            RectangularMatrix B = new RectangularMatrix(4, 3);
            for (int r = 0; r < B.RowCount; r++)
            {
                for (int c = 0; c < B.ColumnCount; c++)
                {
                    B[r, c] = rng.Next(10) + 1;
                }
            }

            // Linear combinations of 
            PrintMatrix(" v ", v);
            PrintMatrix(" 2w ", 2.0 * w);

            PrintMatrix(" v+2w ", v + 2.0 * w);


            PrintMatrix(" v + 2 w ", v + 2.0 * w);

            PrintMatrix(" A ", A);
            PrintMatrix(" B ", B);
            // Matrix-vector multiplication
            PrintMatrix(" Av ", A * v);

            // Matrix multiplication
            PrintMatrix(" B A ", B * A);

            SquareMatrix invA = A.Inverse();

            // This should print a unit matrix
            PrintMatrix(" invA", invA);
            PrintMatrix("A * invA", A * invA);


            Console.WriteLine("Hello World!");
        }
    }
}
