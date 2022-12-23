string[] danceClub = { "Hanako", "Misa", "Eriko" };
string[] ikebanaClub = { "Eriko", "Misuzu", "Misa", "Michie" };

Console.WriteLine($"ダンスクラブと生け花クラブのどちらかに所属しているのは{string.Join(',', danceClub.Union(ikebanaClub))}。");
