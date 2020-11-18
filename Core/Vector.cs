using System;
using System.Collections.Generic;
using System.Text;

namespace MachineLearning.Core
{
    public class Vector
    {
        public float[] vector;
        public int size;
        public Vector(int size) {
            this.size = size;
            vector = new float[size];
        }

        public float this[int index]
        {
            get => vector[index];
            set => vector[index] = value;
        }

        public static Vector operator /(Vector a, Vector b)
        {
            Vector c = new Vector(a.size);
            for (int i = 0; i < a.size; i++)
            {
                c[i] = a[i] / b[i];
            }
            return c;
        }
        public static Vector operator /(float a, Vector b)
        {
            Vector c = new Vector(b.size);
            for (int i = 0; i < b.size; i++)
            {
                c[i] = a / b[i];
            }
            return c;
        }

        public static Vector operator *(Vector a, Vector b)
        {
            Vector c = new Vector(a.size); 
            for (int i = 0; i < a.size; i++)
            {
                c[i] = a[i] * b[i];
            }
            return c;
        }
        public static Vector operator *(float a, Vector b)
        {
            Vector c = new Vector(b.size);
            for (int i = 0; i < b.size; i++)
            {
                c[i] = a * b[i];
            }
            return c;
        }

        public static Vector operator +(Vector a, Vector b)
        {
            Vector c = new Vector(a.size);
            for (int i = 0; i < a.size; i++)
            {
                c[i] = a[i] + b[i];
            }
            return c;
        }
        public static Vector operator +(float a, Vector b)
        {
            Vector c = new Vector(b.size);
            for (int i = 0; i < b.size; i++)
            {
                c[i] = a + b[i];
            }
            return c;
        }

        public static Vector operator -(Vector a, Vector b)
        {
            Vector c = new Vector(a.size);
            for (int i = 0; i < a.size; i++)
            {
                c[i] = a[i] - b[i];
            }
            return c;
        }
        public static Vector operator -(float a, Vector b)
        {
            Vector c = new Vector(b.size);
            for (int i = 0; i < b.size; i++)
            {
                c[i] = a - b[i];
            }
            return c;
        }
    }
}
