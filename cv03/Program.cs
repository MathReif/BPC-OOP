double[,] myArray = 
       {
            {1.3, 1.1, 7.5},
            {8, 5.4, 6.2}
       };
var myArray2 = new double[2, 3]
       {
            {1.0, 2.0, 3.0},
            {4.0, 5.0, 6.0}
       };

var myArray3 = new double[2, 2]
       {
            {1.2, 2.1},
            {4.4, 5.1}
       };
var myArray4 = new double[3, 2]
       {
            {7, 8},
            {9, 10},
            {11, 12}
       };
double[,] xd = { { 1.2, 1.5 }, { 1.3, 1.9 } };
double[,] xd3 = { { 1.2, 1.5 }, { 1.3, 1.9 } };

Matrix xd1 = new Matrix(xd);
Matrix xd2 = new Matrix(xd3);

Console.Write(xd1-xd2);
Console.Write(xd1 + xd2);
Console.Write(xd1 * xd2);
Console.Write(xd1 / xd2);