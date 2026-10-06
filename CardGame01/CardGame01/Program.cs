using System;

Console.WriteLine("===카드 짝 맞추기 게임===");
Console.WriteLine();
Console.WriteLine(" \t1열\t2열\t3열\t4열");
Console.WriteLine($"1행\t{1}\t{1}\t{1}\t{1}");
Console.WriteLine($"2행\t{1}\t{1}\t{1}\t{1}");
Console.WriteLine($"3행\t{1}\t{1}\t{1}\t{1}");
Console.WriteLine($"4행\t{1}\t{1}\t{1}\t{1}");
Console.WriteLine($"시도 횟수: {0}/{20} | 찾은 쌍: {0}/{8}");
Console.WriteLine();
Console.Write("첫 번째 카드를 선택하세요 (행 열): ");
int inputNumber = int.Parse(Console.ReadLine());



/*int[,] box = new int[4, 4];
box[0, 0] = 1;
box[0, 1] = 2;
box[0, 2] = 3;
box[0, 3] = 4;
box[0, 4] = 5;
box[1, 0] = 6;
*/
