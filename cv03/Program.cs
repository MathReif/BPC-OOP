// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var myArray = new double[2, 3]
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
Matrix matica = new Matrix(myArray);
Matrix matica2 = new Matrix(myArray2);

Console.WriteLine(Matica1 + Matica2);