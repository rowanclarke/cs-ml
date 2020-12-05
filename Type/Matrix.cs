using System;
using System.Text;

namespace MachineLearning.Type
{
    public class Matrix
    {
        public double[,] matrix;
        public int[] size;
        public Matrix(int i, int j)
        {
            size = new int[] { i, j };
            matrix = new double[i, j];
        }

        public void Randomise()
        {
            Random random = new Random();
            for (int i = 0; i < size[0]; i++)
            {
                for (int j = 0; j < size[1]; j++)
                {
                    matrix[i, j] = random.NextDouble();
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < size[0]; i++)
            {
                for (int j = 0; j < size[1]; j++)
                {
                    sb.Append(matrix[i, j].ToString()).Append(" ");
                }
                sb.AppendLine();
            }
            return sb.ToString();
        }

        public double this[int i, int j]
        {
            get => matrix[i, j];
            set => matrix[i, j] = value;
        }

        public static Matrix operator *(double a, Matrix b)
        {
            Matrix matrix = new Matrix(b.size[0], b.size[1]);
            for (int i = 0; i < b.size[0]; i++)
            {
                for (int j = 0; j < b.size[1]; j++)
                {
                    matrix[i, j] = a * b[i, j];
                }
            }
            return matrix;
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            Matrix matrix = new Matrix(a.size[0], a.size[1]);
            for (int i = 0; i < a.size[0]; i++)
            {
                for (int j = 0; j < a.size[1]; j++)
                {
                    matrix[i, j] = a[i, j] + b[i, j];
                }
            }
            return matrix;
        }
        public static Matrix operator +(double a, Matrix b)
        {
            Matrix matrix = new Matrix(b.size[0], b.size[1]);
            for (int i = 0; i < b.size[0]; i++)
            {
                for (int j = 0; j < b.size[1]; j++)
                {
                    matrix[i, j] = a + b[i, j];
                }
            }
            return matrix;
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            Matrix matrix = new Matrix(a.size[0], a.size[1]);
            for (int i = 0; i < a.size[0]; i++)
            {
                for (int j = 0; j < a.size[1]; j++)
                {
                    matrix[i, j] = a[i, j] - b[i, j];
                }
            }
            return matrix;
        }
        public static Matrix operator -(double a, Matrix b)
        {
            Matrix matrix = new Matrix(b.size[0], b.size[1]);
            for (int i = 0; i < b.size[0]; i++)
            {
                for (int j = 0; j < b.size[1]; j++)
                {
                    matrix[i, j] = a - b[i, j];
                }
            }
            return matrix;
        }
    }
}
