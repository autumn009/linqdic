string[] danceClub = { "Hanako", "Misa", "Eriko" };
string[] ikebanaClub = { "Eriko", "Misuzu", "Misa", "Michie" };

Console.WriteLine($"ダンスクラブと生け花クラブの両方に所属しているのは{string.Join(',',danceClub.Intersect(ikebanaClub))}。");
//Console.WriteLine($"ダンスクラブと生け花クラブの両方に所属しているのは{string.Join(',', ikebanaClub.Intersect(danceClub))}。");
