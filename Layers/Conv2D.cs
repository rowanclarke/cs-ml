using System;
using System.Collections.Generic;
using System.Text;
using MachineLearning.Core;

namespace MachineLearning.Layers
{
    public class Conv2D : Layer
    {
        public Matrix filter;
        public Matrix input;
        public Matrix output;
        public Matrix target;

        public Conv2D(int[] size, int[] filter)
        {
            input = new Matrix(size[0], size[1]);
            this.filter = new Matrix(filter[0], filter[1]);
            output = new Matrix(size[0] - filter[0] + 1, size[1] - filter[1] + 1);
            target = new Matrix(size[0] - filter[0] + 1, size[1] - filter[1] + 1);
        }

        public Conv2D(Matrix input, int[] filter)
        {
            this.input = input;
            this.filter = new Matrix(filter[0], filter[1]);
            this.filter.Randomise();
            output = new Matrix(input.size[0] - filter[0] + 1, input.size[1] - filter[1] + 1);
            target = new Matrix(input.size[0] - filter[0] + 1, input.size[1] - filter[1] + 1);
        }

        public override void Forward()
        {
            Convolution(input, filter, output);
        }

        public override void Backward()
        {
            filter -= rate * Convolution(input, 2 * (output - target));

        }

        public static Matrix Convolution(Matrix input, Matrix filter)
        {
            Matrix matrix = new Matrix(input.size[0] - filter.size[0] + 1, input.size[1] - filter.size[1] + 1);
            Convolution(input, filter, matrix);
            return matrix;
        }

        public static void Convolution(Matrix input, Matrix filter, Matrix output)
        {
            float sum;
            for (int i = 0; i < output.size[0]; i++)
            {
                for (int j = 0; j < output.size[1]; j++)
                {
                    sum = 0;
                    for (int x = 0; x < filter.size[0]; x++)
                    {
                        for (int y = 0; y < filter.size[1]; y++)
                        {
                            sum += input[i + x, j + y] * filter[x, y];
                        }
                    }
                    output[i, j] = sum;
                }
            }
        }

        public static Matrix FullConvolution(Matrix input, Matrix filter)
        {
            Matrix output = new Matrix(input.size[0] + filter.size[0] - 1, input.size[1] + filter.size[1] - 1);
            FullConvolution(input, filter, output);
            return output;
        }

        public static void FullConvolution(Matrix input, Matrix filter, Matrix output)
        {
            
            float sum;
            int xi, yj;
            for (int i = 0; i < output.size[0]; i++)
            {
                for (int j = 0; j < output.size[1]; j++)
                {
                    sum = 0;
                    for (int x = 0; x < filter.size[0]; x++)
                    {
                        for (int y = 0; y < filter.size[1]; y++)
                        {
                            xi = i - x; 
                            yj = j - y;
                            if ((xi >= 0 && yj >= 0) && (xi < input.size[0] && yj < input.size[1]))
                            {
                                sum += input[xi, yj] * filter[x, y];
                            }
                        }
                    }
                    output[i, j] = sum;
                }
            }
        }
    }
}
