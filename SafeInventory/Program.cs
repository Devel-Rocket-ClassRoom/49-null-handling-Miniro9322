using System;
using System.Collections.Generic;
using System.Linq;

// README.md를 읽고 코드를 작성하세요.

string[] player1Items = null;
string[] player2Items = { };
string[] player3Items = { "검", "방패", "포션" };

Console.WriteLine("=== 플레이어 1 (인벤토리 없음) ===");
Console.WriteLine($"아이템 수: {player1Items?.Count() ?? 0}");
Console.WriteLine($"첫 번째 아이템: {(player1Items?.Length > 0 ? player2Items?[0] : "없음")}");
Console.WriteLine($"마지막 아이템: {(player1Items?.Length > 0 ? player2Items?[^1] : "없음")}");

Console.WriteLine("\n=== 플레이어 2 (빈 인벤토리) ===");
Console.WriteLine($"아이템 수: {player2Items?.Count() ?? 0}");
Console.WriteLine($"첫 번째 아이템: {(player2Items?.Length > 0 ? player2Items?[0] : "없음")}");
Console.WriteLine($"마지막 아이템: {(player2Items?.Length > 0 ? player2Items?[^1] : "없음")}");

Console.WriteLine("\n=== 플레이어 3 (아이템 보유) ===");
Console.WriteLine($"아이템 수: {player3Items?.Count() ?? 0}");
Console.WriteLine($"첫 번째 아이템: {(player3Items?.Length > 0 ? player3Items?[0] : "없음")}");
Console.WriteLine($"마지막 아이템: {(player3Items?.Length > 0 ? player3Items?[^1] : "없음")}");