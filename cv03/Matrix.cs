using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using static System.Runtime.InteropServices.JavaScript.JSType;


    internal class Matrix
    {
        public double[,] matrix;
        
        public Matrix(double[,] matrix)
        {
            this.matrix = matrix;   
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
        Matrix c = new Matrix(new double[a.matrix.GetLength(0), a.matrix.GetLength(1)]);
        for (int i = 0; i < a.matrix.GetLength(0); i++)
        {
            for (int j = 0; j < a.matrix.GetLength(1); j++)
            {
                c.matrix[i,j] = a.matrix[i, j] - b.matrix[i, j];
            }
        }
        return c;
        }

    public static Matrix operator +(Matrix a, Matrix b)
    {
        Matrix c = new Matrix(new double[a.matrix.GetLength(0), a.matrix.GetLength(1)]);
        for (int i = 0; i < a.matrix.GetLength(0); i++)
        {
            for (int j = 0; j < a.matrix.GetLength(1); j++)
            {
                c.matrix[i, j] = a.matrix[i, j] + b.matrix[i, j];
            }
        }
        return c;
    }

    public static Matrix operator *(Matrix a, Matrix b)
    {
        Matrix c = new Matrix(new double[a.matrix.GetLength(0), a.matrix.GetLength(1)]);
        for (int i = 0; i < a.matrix.GetLength(0); i++)
        {
            for (int j = 0; j < a.matrix.GetLength(1); j++)
            {
                for (int k = 0; k < b.matrix.GetLength(1); k++)
                {
                    c.matrix[i, j] += a.matrix[i, k] * b.matrix[k, j];
                }
            }
        }
        return c;
    }
    public static Matrix operator /(Matrix a, Matrix b)
    {
        Matrix c = new Matrix(new double[a.matrix.GetLength(0), a.matrix.GetLength(1)]);
        for (int i = 0; i < a.matrix.GetLength(0); i++)
        {
            for (int j = 0; j < a.matrix.GetLength(1); j++)
            {
                b.matrix[i, j] = b.matrix[i, j] * (-1);
                for (int k = 0; k < b.matrix.GetLength(1); k++)
                {
                    c.matrix[i, j] += a.matrix[i, k] * b.matrix[k, j];
                }
            }
        }
        return c;
    }
    public override string ToString()
        {
        string woof = "";

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j == 0)
                {
                    woof = woof + matrix[i, j];
                }
                else
                {
                    woof = woof + " " + matrix[i, j];
                }
            }
            woof = woof + "\n";
        }
        
            return woof;
        }
}