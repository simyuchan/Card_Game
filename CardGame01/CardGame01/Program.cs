using System;

int playCount = 0;
int completCount = 0;
int[,] box = new int[4, 4];
bool[,] star = new bool[4, 4];

Shuffle(box);

while (playCount > 20 || 8 < completCount)
{
    Console.Clear();
    Console.WriteLine("===카드 짝 맞추기 게임===");
    Console.WriteLine();
    Console.WriteLine(" \t1열\t2열\t3열\t4열");
    for (int row = 0; row < 4; row++)
    {
        Console.Write($"{row + 1}행\t");
        for (int col = 0; col < 4; col++)
        {
            if (star[row, col] == true)
            {
                Console.Write($"[ {box[row, col]}]\t");
            }
            else
            {
                Console.Write("**\t");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine($"시도 횟수: {playCount}/20 | 찾은 쌍: {completCount}/8");
    Console.WriteLine();

    Console.Write("첫 번째 카드를 선택하세요 (행): ");
    int row1 = int.Parse(Console.ReadLine()) -1;
    Console.Write("첫 번째 카드를 선택하세요 (열): ");
    int col1 = int.Parse(Console.ReadLine()) -1;
    Console.WriteLine();

    if (star[row1, col1] == true)
    {
        Console.WriteLine("이미 오픈된 카드입니다.");
    }

    if ((row1 == row2 && col1 == col2)
    {

    }

/*Console.Write("두 번째 카드를 선택하세요 (행): ");
int row2 = int.Parse(Console.ReadLine());
Console.Write("두 번째 카드를 선택하세요 (열): ");
int col2 = int.Parse(Console.ReadLine());*/

    Console.WriteLine("게임 종료");
}




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
        count++;

        box[index / 4, index % 4] = number;

        if (count == 16)
            break;
    }
}
