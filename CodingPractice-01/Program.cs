using System;

// README.md를 읽고 코드를 작성하세요.

//1
int number = 0;
string text = "";
string nothing = null;

Console.WriteLine(number);
Console.WriteLine(text);
Console.WriteLine(nothing);

//2
string name = null;
Console.WriteLine(name == null);

//3-1
int? nullableInt = null;
double? nullableDouble = null;
bool? nullableBool = null;

Nullable<int> anotherInt = null;
Nullable<double> anotherDouble = null;

Console.WriteLine(nullableInt);
Console.WriteLine(nullableDouble);
Console.WriteLine(nullableBool);

//3-2
int? score = null;

Console.WriteLine($"score.HasValue: {score.HasValue}");

score = 95;
Console.WriteLine($"score.HasValue: {score.HasValue}");
Console.WriteLine($"score.Value: {score.Value}");

//3-3
int? empty = null;

if (empty.HasValue)
{
    Console.WriteLine($"값: {empty.Value}");
}
else
{
    Console.WriteLine("값이 없습니다.");
}

//3-4
int? level = null;

int defaultLevel = level.GetValueOrDefault();
Console.WriteLine($"기본값 사용: {defaultLevel}");

int customDefault = level.GetValueOrDefault(1);
Console.WriteLine($"커스텀 기본값: {customDefault}");

level = 50;
Console.WriteLine($"값이 있을 때: {level.GetValueOrDefault()}");

//3-5
number = 42;
int? nullable = number;

int back = (int)nullable;

Console.WriteLine($"nullable: {nullable}");
Console.WriteLine($"back: {back}");

//4-1
string message = null;
string result = message ?? "기본 메시지";
Console.WriteLine(result);

message = "안녕하세요";
result = message ?? "기본 메시지";
Console.WriteLine(result);

//4-2
string input = null;
string output;

if (input == null)
{
    output = "기본값";
}
else
{
    output = input;
}
Console.WriteLine($"if문 결과: {output}");

output = input ?? "기본값";
Console.WriteLine($"?? 연산자 결과: {output}");

//4-3
score = null;
int defaultScore = score ?? -1;
Console.WriteLine($"점수: {defaultScore}");

int? health = null;
int actualHealth = health ?? default(int);
Console.WriteLine($"체력: {actualHealth}");

//4-4
string first = null;
string second = null;
string third = "세 번째 값";

result = first ?? second ?? third;
Console.WriteLine(result);