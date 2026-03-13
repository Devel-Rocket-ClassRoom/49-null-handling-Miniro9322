using System;

// README.md를 읽고 아래에 코드를 작성하세요.

int?[] scores = { 3, null, 7, null, 5 };

Console.WriteLine("=== 경기 상태 ===");
for(int i = 0; i < scores.Length; i++)
{
    if (scores[i].HasValue == true)
    {
        Console.WriteLine($"경기 {i + 1}: {scores[i]}점");
    }
    else
    {
        Console.WriteLine($"경기 {i + 1}: 미진행");
    }
}

Console.WriteLine("\n=== 전체 점수 (미진행 = -1) ===");
for (int i = 0; i < scores.Length; i++)
{
    Console.WriteLine($"경기 {i + 1}: {scores[i].GetValueOrDefault(-1)}점");
}

Console.WriteLine("\n=== 통계 ===");
int? count = 0;
int? totalScore = 0;
double? averageScore = 0;
foreach(int? score in scores)
{
    if(score.HasValue == true)
    {
        count++;
    }
    totalScore += score.GetValueOrDefault();
}
averageScore = (double?)totalScore / count;

Console.WriteLine($"진행된 경기 수: {count}");
Console.WriteLine($"총점: {totalScore}");
Console.WriteLine($"평균: {averageScore:f1}");