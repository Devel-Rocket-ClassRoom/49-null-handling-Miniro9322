using System;

// README.md를 읽고 아래에 코드를 작성하세요.
Setting userSetting = new Setting(null, null, "English", null);
Setting profileSetting = new Setting("프로필유저", null, "Korean", null);
Setting staticSetting = new Setting(null, null, "Japanese", 70);
Setting defaultSetting = new Setting("Player", "localhost", "Korean", 50);


string? playerName = userSetting._name ?? profileSetting._name ?? staticSetting._name ?? defaultSetting._name;
string? playerServer = userSetting._server ?? profileSetting._server ?? staticSetting._server ?? defaultSetting._server;
string? playerLanguage = userSetting._language ?? profileSetting._language ?? staticSetting._language ?? defaultSetting._language;
int? playerVolume = userSetting._volume ?? profileSetting._volume ?? staticSetting._volume ?? defaultSetting._volume;

string? nameCash = null;
string? serverCash = null;
string? languageCash = null;
int? volumeCash = null;


Console.WriteLine("=== 설정 결정 ===");
Console.WriteLine($"플레이어 이름: {playerName} (프로필 설정에서 가져옴)");
Console.WriteLine($"서버 주소: {playerServer} (기본값에서 가져옴)");
Console.WriteLine($"언어: {playerLanguage} (사용자 설정에서 가져옴)");
Console.WriteLine($"볼륨: {playerVolume} (전역 설정에서 가져옴)");

Console.WriteLine("\n=== 설정 결정 ===");
Console.WriteLine("캐시 시작 전: null");
nameCash ??= playerName;
Console.WriteLine($"첫 번째 ??= 적용 후: {nameCash}");
nameCash ??= playerServer;
Console.WriteLine($"두 번째 ??= 적용 후: {nameCash}");

Console.WriteLine("\n=== 최종 설정 ===");
serverCash ??= playerServer;
languageCash ??= playerLanguage;
volumeCash ??= playerVolume;
Console.WriteLine($"플레이어 이름: {nameCash} (프로필 설정에서 가져옴)");
Console.WriteLine($"서버 주소: {serverCash} (기본값에서 가져옴)");
Console.WriteLine($"언어: {languageCash} (사용자 설정에서 가져옴)");
Console.WriteLine($"볼륨: {volumeCash} (전역 설정에서 가져옴)");

struct Setting
{
    public string? _name;
    public string? _server;
    public string? _language;
    public int? _volume;

    public Setting(string? name, string? server, string?  language, int? volume)
    {
        _name = name;
        _server = server;
        _language = language;
        _volume = volume;
    }
}