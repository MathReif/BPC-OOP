using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


internal class Matrix
{
    private double[,] matrix;

    public Matrix(double[,] matrix)
    {
        this.matrix = matrix;
    }
    private int RowSize
    {
        get
        {
            return matrix.GetLength(0);
        }
    }
    private int ColumnSize
    {
        get
        {
            return matrix.GetLength(1);
        }
    }
    public static Matrix operator +(Matrix a, Matrix b)
    {
        if (a.RowSize != b.RowSize || a.ColumnSize != b.ColumnSize)
        {
            throw new Exception("Incopatible matrix size");
        }
        double[,] resultMatrix = new double[a.RowSize, a.ColumnSize];

        for (int rowIndex = 0; rowIndex < a.RowSize; rowIndex++)
        {
            for (int columnIndex = 0; columnIndex < a.ColumnSize; columnIndex++)
            {
                resultMatrix[rowIndex, columnIndex] = a.matrix[rowIndex, columnIndex] + b.matrix[rowIndex, columnIndex];
            }
        }
        return new Matrix(resultMatrix);
    }

    public static Matrix operator -(Matrix a, Matrix b)
    {
        if (a.RowSize != b.RowSize || a.ColumnSize != b.ColumnSize)
        {
            throw new Exception("Incopatible matrix size");
        }
        double[,] resultMatrix = new double[a.RowSize, a.ColumnSize];

        for (int rowIndex = 0; rowIndex < a.RowSize; rowIndex++)
        {
            for (int columnIndex = 0; columnIndex < a.ColumnSize; columnIndex++)
            {
                resultMatrix[rowIndex, columnIndex] = a.matrix[rowIndex, columnIndex] - b.matrix[rowIndex, columnIndex];
            }
        }
        return new Matrix(resultMatrix);
    }



    public override string ToString()
    {
        int row_num = matrix.GetLength(0);
        int col_num = matrix.GetLength(1);
        string returnString = "";
        for (int i = 0; i < row_num; i++)
        {
            for (int j = 0; j < col_num; j++)
            {
                returnString = returnString + matrix[i, j].ToString() + " ";

            }
            returnString = returnString + "\n";
        }
        return returnString;
    }


}
