using System;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow; 
            Console.WriteLine("Выберите действие");
            Console.ResetColor(); 
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1. Сложение матриц.");
            Console.WriteLine("2. Умножение матриц на число.");
            Console.WriteLine("3. Умножение матриц.");
            Console.WriteLine("4. Возведение матрицы в степень.");
            Console.WriteLine("5. Транспонирование матриц.");
            Console.WriteLine();
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            string Choice = Console.ReadLine();
            Console.ResetColor();

            static void MatrixTransp()
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine();
                Console.WriteLine("Матрица №1");
                Console.WriteLine();
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Введите кол-во рядов матрицы №1 \n");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Magenta;
                int.TryParse(Console.ReadLine(), out int Rows1);
                Console.WriteLine();
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Введите кол-во столбцов матрицы №1 \n");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Magenta;
                int.TryParse(Console.ReadLine(), out int Columns1);
                Console.WriteLine();
                Console.ResetColor();


                int[,] Matrix1 = new int[Rows1, Columns1];
                int[,] MatrixTrans = new int[Columns1, Rows1];

                for (int i = 0; i < Matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < Matrix1.GetLength(1); j++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Введите числа матрицы №1 \n");
                        Console.WriteLine();
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("Rows:" + i + " " + "Columns" + j + "\n");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Matrix1[i, j] = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.ResetColor();
                    }
                }

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Матрица №1");
                Console.WriteLine();
                Console.ResetColor();
                for (int i = 0; i < Matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < Matrix1.GetLength(1); j++)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(Matrix1[i, j] + "\t");
                        Console.ResetColor();
                    }
                    Console.WriteLine("\n");
                }
                int tmp;

                for (int i = 0; i < Matrix1.GetLength(1); i++)
                {
                    for (int j = 0; j < Matrix1.GetLength(0); j++)
                    {
                        MatrixTrans[i, j] = Matrix1[j, i];
                    }
                }

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("Результат \n");

                for (int i = 0; i < Matrix1.GetLength(1); i++)
                {
                    for (int j = 0; j < Matrix1.GetLength(0); j++)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(MatrixTrans[i, j] + "\t");
                        Console.ResetColor();
                    }
                    Console.WriteLine("\n");
                }


            }
            static void MatrixMult()
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine();
                Console.WriteLine("Матрица №1");
                Console.WriteLine();
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Введите кол-во рядов матрицы №1 \n");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Magenta;
                int.TryParse(Console.ReadLine(), out int Rows1);
                Console.WriteLine();
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Введите кол-во столбцов матрицы №1 \n");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Magenta;
                int.TryParse(Console.ReadLine(), out int Columns1);
                Console.WriteLine();
                Console.ResetColor();


                int[,] Matrix1 = new int[Rows1, Columns1];

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine();
                Console.WriteLine("Матрица №2");
                Console.WriteLine();
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Введите кол-во рядов матрицы №2 \n");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Magenta;
                int.TryParse(Console.ReadLine(), out int Rows2);
                Console.WriteLine();
                Console.ResetColor();


                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Введите кол-во столбцов матрицы №2 \n");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Magenta;
                int.TryParse(Console.ReadLine(), out int Columns2);
                Console.WriteLine();
                Console.ResetColor();

                int[,] Matrix2 = new int[Rows2, Columns2];

                if (Columns1 == Rows2)
                {
                    for (int i = 0; i < Matrix1.GetLength(0); i++)
                    {
                        for (int j = 0; j < Matrix1.GetLength(1); j++)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Введите числа матрицы №1");
                            Console.WriteLine();
                            Console.ResetColor();

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Rows:" + i + " " + "Columns" + j + "\n");
                            Console.ResetColor();

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Matrix1[i, j] = int.Parse(Console.ReadLine());
                            Console.ResetColor();
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Матрица №1");
                    Console.WriteLine();
                    Console.ResetColor();
                    for (int i = 0; i < Matrix1.GetLength(0); i++)
                    {
                        for (int j = 0; j < Matrix1.GetLength(1); j++)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(Matrix1[i, j] + "\t");
                            Console.ResetColor();
                        }
                        Console.WriteLine("\n");
                    }

                    for (int i = 0; i < Matrix1.GetLength(0); i++)
                    {
                        for (int j = 0; j < Matrix1.GetLength(1); j++)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Введите числа матрицы №2");
                            Console.WriteLine("\n");
                            Console.ResetColor();

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Rows:" + i + " " + "Columns" + j + "\n");
                            Console.ResetColor();

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Matrix2[i, j] = int.Parse(Console.ReadLine());
                            Console.ResetColor();
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Матрица №2");
                    Console.WriteLine("\n");
                    Console.ResetColor();
                    for (int i = 0; i < Matrix1.GetLength(0); i++)
                    {
                        for (int j = 0; j < Matrix1.GetLength(1); j++)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(Matrix2[i, j] + "\t");
                            Console.ResetColor();
                        }
                        Console.WriteLine("\n");
                    }

                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Произведение");

                    int[,] MatrixCompos = new int[Rows1, Columns2];

                    for (int i = 0; i < Matrix1.GetLength(0); i++)
                    {
                        for (int j = 0; j < Matrix1.GetLength(1); j++)
                        {
                            for (int k = 0; k < Matrix1.GetLength(1); k++)
                            {
                                MatrixCompos[i, j] += Matrix1[i, k] * Matrix2[k, j];
                            }
                        }
                        Console.WriteLine();
                    }

                    for (int i = 0; i < Matrix1.GetLength(0); i++)
                    {
                        for (int j = 0; j < Matrix1.GetLength(1); j++)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(MatrixCompos[i, j] + "\t");
                            Console.ResetColor();
                        }
                        Console.WriteLine("\n");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Матрицы можно перемножать только в том случае," +
                        " когда число столбцов матрицы №1 совпадает с числом строк матрицы №2," +
                        " а число строк матрицы №1 совпадает с числом столбцов матрицы №2.");
                    Console.ResetColor();
                }
            }
            static void MatrixMultNum ()
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine();
                Console.WriteLine("Матрица №1");
                Console.WriteLine();
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Введите кол-во рядов матрицы №1" + "\n");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Magenta;
                int.TryParse(Console.ReadLine(), out int Rows1);
                Console.WriteLine();
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Введите кол-во столбцов матрицы №1" + "\n");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Magenta;
                int.TryParse(Console.ReadLine(), out int Columns1);
                Console.WriteLine();
                Console.ResetColor();


                int[,] Matrix1 = new int[Rows1, Columns1];
                int[,] MatrixRes = new int[Rows1, Columns1];

                for (int i = 0; i < Matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < Matrix1.GetLength(1); j++)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Введите числа матрицы №1");
                        Console.WriteLine("\n");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Rows:" + i + " " + "Columns" + j + "\n");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Matrix1[i, j] = int.Parse(Console.ReadLine());
                        Console.ResetColor();
                    }
                    Console.WriteLine();
                }

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Матрица №1");
                Console.WriteLine();
                Console.ResetColor();
                for (int i = 0; i < Matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < Matrix1.GetLength(1); j++)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(Matrix1[i, j] + "\t");
                        Console.ResetColor();
                    }
                    Console.WriteLine("\n");
                }

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Введите множитель \n");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Magenta;
                int.TryParse(Console.ReadLine(), out int multiplier);
                Console.WriteLine();
                Console.ResetColor();

                for (int i = 0; i < Matrix1.GetLength(1); i++)
                {
                    for (int j = 0; j < Matrix1.GetLength(1); j++)
                    {
                        MatrixRes[i, j] = Matrix1[i, j] * multiplier;
                    }
                }

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Произведение \n");

                for (int i = 0; i < Matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < Matrix1.GetLength(1); j++)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(MatrixRes[i, j] + "\t");
                        Console.ResetColor();
                    }
                    Console.WriteLine("\n");
                }
            }
            static void MatrixAdd()
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine();
                Console.WriteLine("Матрица №1");
                Console.WriteLine();
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Введите кол-во рядов матрицы №1");
                Console.WriteLine();
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Magenta;
                int.TryParse(Console.ReadLine(), out int Rows1);
                Console.WriteLine();
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Введите кол-во столбцов матрицы №1");
                Console.WriteLine();
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Magenta;
                int.TryParse(Console.ReadLine(), out int Columns1);
                Console.ResetColor();


                int[,] Matrix1 = new int[Rows1, Columns1];
                int[,] MatrixSum = new int[Rows1, Columns1];

                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine();
                Console.WriteLine("Матрица №2");
                Console.WriteLine();
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Введите кол-во рядов матрицы №2");
                Console.WriteLine();
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Magenta;
                int.TryParse(Console.ReadLine(), out int Rows2);
                Console.WriteLine();
                Console.ResetColor();


                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Введите кол-во столбцов матрицы №2");
                Console.WriteLine();
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Magenta;
                int.TryParse(Console.ReadLine(), out int Columns2);
                Console.WriteLine();
                Console.ResetColor();




                int[,] Matrix2 = new int[Rows2, Columns2];

                if (Rows1 == Rows2 && Columns1 == Columns2)
                {
                    for (int i = 0; i < Matrix1.GetLength(0); i++)
                    {
                        for (int j = 0; j < Matrix1.GetLength(1); j++)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Введите числа матрицы №1");
                            Console.WriteLine();
                            Console.ResetColor();

                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("Rows:" + i + " " + "Columns" + j + "\n");
                            Console.ResetColor();

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Matrix1[i, j] = int.Parse(Console.ReadLine());
                            Console.ResetColor();
                            Console.WriteLine();
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Матрица №1");
                    Console.WriteLine();
                    Console.ResetColor();
                    for (int i = 0; i < Matrix1.GetLength(0); i++)
                    {
                        for (int j = 0; j < Matrix1.GetLength(1); j++)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(Matrix1[i, j] + "\t");
                            Console.ResetColor();
                        }
                        Console.WriteLine("\n");
                    }

                    for (int i = 0; i < Matrix2.GetLength(0); i++)
                    {
                        for (int j = 0; j < Matrix2.GetLength(1); j++)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine("Введите числа матрицы №2");
                            Console.WriteLine();
                            Console.ResetColor();
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("Rows:" + i + " " + "Columns" + j + "\n");
                            Console.ResetColor();

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Matrix2[i, j] = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Console.ResetColor();
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Матрица №2");
                    Console.WriteLine();
                    for (int i = 0; i < Matrix2.GetLength(0); i++)
                    {
                        for (int j = 0; j < Matrix2.GetLength(1); j++)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(Matrix2[i, j] + "\t");
                            Console.ResetColor();
                        }
                        Console.WriteLine("\n");
                    }


                    for (int i = 0; i < Matrix2.GetLength(1); i++)
                    {
                        for (int j = 0; j < Matrix2.GetLength(1); j++)
                        {
                            MatrixSum[i, j] = (Matrix1[i, j] + Matrix2[i, j]);
                        }
                    }

                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Сумма матриц \n");

                    for (int i = 0; i < Matrix2.GetLength(0); i++)
                    {
                        for (int j = 0; j < Matrix2.GetLength(1); j++)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(MatrixSum[i, j] + "\t");
                            Console.ResetColor();
                        }
                        Console.WriteLine("\n");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Матрицы разных размерностей складывать нельзя");
                    Console.ResetColor();
                }
            }

            switch (Choice)
            {
                case "1":
                  {
                        MatrixAdd();
                        break;
                  }

                case "2":
                    {

                        MatrixMultNum();
                        break;
                    }

                case "3":
                    {
                        MatrixMult();
                          break;
                    }

                case "4":
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine();
                        Console.WriteLine("Матрица №1");
                        Console.WriteLine();
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Введите кол-во рядов матрицы №1 \n");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Magenta;
                        int.TryParse(Console.ReadLine(), out int Rows1);
                        Console.WriteLine();
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Введите кол-во столбцов матрицы №1 \n");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Magenta;
                        int.TryParse(Console.ReadLine(), out int Columns1);
                        Console.WriteLine();
                        Console.ResetColor();


                        int[,] Matrix1 = new int[Rows1, Columns1];
                        int[,] MatrixRes = new int[Rows1, Columns1];

                        for (int i = 0; i < Matrix1.GetLength(0); i++)
                        {
                            for (int j = 0; j < Matrix1.GetLength(1); j++)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine("Введите числа матрицы №1 \n");
                                Console.WriteLine();
                                Console.ResetColor();

                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("Rows:" + i + " " + "Columns" + j + "\n");
                                Console.ResetColor();

                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Matrix1[i, j] = int.Parse(Console.ReadLine());
                                Console.WriteLine();
                                Console.ResetColor();
                            }
                        }

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Матрица №1");
                        Console.WriteLine();
                        Console.ResetColor();
                        for (int i = 0; i < Matrix1.GetLength(0); i++)
                        {
                            for (int j = 0; j < Matrix1.GetLength(1); j++)
                            {
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(Matrix1[i, j] + "\t");
                                Console.ResetColor();
                            }
                            Console.WriteLine("\n");
                        }

                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Введите степень \n");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Magenta;
                        int.TryParse(Console.ReadLine(), out int degree);
                        Console.WriteLine();
                        Console.ResetColor();


                        Console.WriteLine("ЗАДАНИЕ ВЫПОЛНИТЬ НЕ СМОГ");



                        break;
                    }

                case "5":
                    {
                       MatrixTransp();
                        break;
                    }

                  

            }
        }
    }
}






