string[] ar = {
    "Jack Sparrow",
    "Jack the Ripper",
    "Jean-Claude"
};
if( ar.Any(c=>c.Contains("Jack")))
    Console.WriteLine("この中に一人以上のJackがいる!");
else
    Console.WriteLine("Jackは一人もいません。");
