int[] prices = { 100, 200, 300 };
Console.WriteLine($"定価 {string.Join(',', prices)}");
int[] discountedPrices = prices.Select(c => c * 8 / 10).ToArray();
Console.WriteLine($"2割引価格 {string.Join(',', discountedPrices)}");
