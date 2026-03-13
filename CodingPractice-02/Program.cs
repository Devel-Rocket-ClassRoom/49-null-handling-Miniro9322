using System;
using System.Collections.Generic;

// README.md를 읽고 코드를 작성하세요.

//1-1
string name = null;
name ??= "이름 없음";
Console.WriteLine(name);

name ??= "새 이름";
Console.WriteLine(name);

//1-2
string playerName = null;

if (playerName == null)
{
    playerName = "플레이어";
}

Console.WriteLine(playerName);

//1-3
List<string> _items = null;

_items ??= new List<string>();
_items.Add("검");

_items ??= new List<string>();
_items.Add("방패");

Console.WriteLine($"아이템 수: {_items.Count}");
foreach (string item in _items)
{
    Console.WriteLine($"- {item}");
}

//2-1
string message = null;
int? length = message?.Length;
Console.WriteLine($"길이: {length}");

message = "안녕하세요";
length = message?.Length;
Console.WriteLine($"길이: {length}");

//2-2
string text = null;

int? safeLen = text?.Length;

if (safeLen == null)
{
    Console.WriteLine("텍스트가 없습니다.");
}

//2-3
name = null;
string upper = name?.ToUpper();
Console.WriteLine($"대문자: {upper}");

name = "hello";
upper = name?.ToUpper();
Console.WriteLine($"대문자: {upper}");

//2-4
text = null;
string result = text?.ToUpper()?.Trim();
Console.WriteLine($"결과: {result}");

text = "  hello  ";
result = text?.ToUpper()?.Trim();
Console.WriteLine($"결과: {result}");

//2-5
List<string> items = null;
int? count = items?.Count;
Console.WriteLine($"아이템 수: {count}");

items = new List<string> { "사과", "바나나" };
count = items?.Count;
Console.WriteLine($"아이템 수: {count}");

//2-6
text = null;
char? firstChar = text?[0];
Console.WriteLine($"첫 글자: {firstChar}");

text = "Hello";
firstChar = text?[0];
Console.WriteLine($"첫 글자: {firstChar}");

//3-1
message = null;
length = message?.Length ?? 0;
Console.WriteLine($"길이: {length}");

message = "Hello";
length = message?.Length ?? 0;
Console.WriteLine($"길이: {length}");

//3-2
List<string> names = null;

count = names?.Count ?? 0;
Console.WriteLine($"이름 수: {count}");

names = new List<string> { "Kim", "Lee", "Park" };
count = names?.Count ?? 0;
Console.WriteLine($"이름 수: {count}");

//3-3
playerName = null;
int? playerLevel = null;
List<string> inventory = null;

string displayName = playerName ?? "Unknown";
int level = playerLevel ?? 1;
int itemCount = inventory?.Count ?? 0;

Console.WriteLine($"플레이어: {displayName}");
Console.WriteLine($"레벨: {level}");
Console.WriteLine($"인벤토리 아이템: {itemCount}개");