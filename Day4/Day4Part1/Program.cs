Console.WriteLine(new List<List<string>>(){File.ReadAllLines("input.txt").ToList()}.Select(j => new{matches = j.Select(r => r.Split(":")[1]).Select((r, index) => new{winning = r.Split("|")[0].Split(" ").Where(t => int.TryParse(t , out _)).Select(t => int.Parse(t)), numbers = r.Split("|")[1].Split(" ").Where(t => int.TryParse(t , out _)).Select(t => int.Parse(t)),index}).Select(r => new{matches = r.numbers.Aggregate(0, (previous, current) => r.winning.Contains(current) ? (previous + 1) : previous), r.index}), j}).First().matches.Aggregate(0, (previous, current) => previous + (int)Math.Pow(2, current.matches-1)));