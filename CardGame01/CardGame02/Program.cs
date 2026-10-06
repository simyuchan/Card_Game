using System;

int playCount = 0;
int completCount = 0;
int[,] box = new int[4, 4];
bool[,] star = new bool[4, 4];

Shuffle(box);

Console.WriteLine("===카드 짝 맞추기 게임===");
Console.WriteLine();
Console.WriteLine(" \t1열\t2열\t3열\t4열");

for (int row = 0; row < 4; row++)
{
    Console.Write($"{row+1}행\t");
    for (int col = 0; col < 4; col++)
    {
        if (star[row, col])
        {
            Console.Write("**\t");
        }
        else
        {
            //Console.Write($"[ {box[row, col]}]\t");
        }
    }
    Console.WriteLine();
}

Console.WriteLine($"시도 횟수: {playCount}/20 | 찾은 쌍: {completCount}/8");
Console.WriteLine();

Console.Write("첫 번째 카드를 선택하세요 (행 열): ");
int inputNumber = int.Parse(Console.ReadLine());

void Shuffle(int[,] box)
{
    int[] numberCount = new int[9];
    bool[] isValue = new bool[16];
    int count = 0;

    while (true)
    { 
        Random random = new Random();

        int number = random.Next(1, 9);   // 1~8
        int index = random.Next(0, 16);   // 0~15
        if (isValue[index])
            continue;
        if (numberCount[number] >= 2)
            continue;
        isValue[index] = true;
        numberCount[number]++;
        count ++;

        box[index / 4, index % 4] = number;

        if (count == 16)
            break;
    }
    for (int i = 0; i < count; i++)
    {
        if (playCount > 20 || 8 < completCount)
            Console.WriteLine("게임 종료");
        return;
    }
}
