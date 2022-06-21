namespace LAtelier.Tennisu.Players;

public class CountryDto
{
    public string Picture { get; set; }
    public string Code { get; set; }
}

public class DataDto
{
    public int Rank { get; set; }
    public int Points { get; set; }
    public int Weight { get; set; }
    public int Height { get; set; }
    public int Age { get; set; }
    public int[] Last { get; set; }
}

public class PlayerDto
{
    public int Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Shortname { get; set; }
    public string Sex { get; set; }
    public CountryDto Country { get; set; }
    public string Picture { get; set; }
    public DataDto Data { get; set; }
}

public class PlayersProvider
{
    public IEnumerable<PlayerDto> GetAll()
    {
        yield return new PlayerDto
        {
            Country = new CountryDto
            {
                Code = "SRB",
                Picture = "https://data.latelier.co/training/tennis_stats/resources/Serbie.png"
            },
            Id = 52,
            Firstname = "Novak",
            Lastname = "Djokovic",
            Shortname = "N.DJO",
            Picture = "https://data.latelier.co/training/tennis_stats/resources/Djokovic.png",
            Sex = "M",
            Data = new DataDto
            {
                Age = 31,
                Height = 188,
                Weight = 80000,
                Last = new int[] { 1, 1, 1, 1, 1 },
                Points = 2542,
                Rank = 2,
            },
        };
        
        yield return new PlayerDto
        {
            Country = new CountryDto
            {
                Code = "USA",
                Picture = "https://data.latelier.co/training/tennis_stats/resources/USA.png"
            },
            Id = 95,
            Firstname = "Venus",
            Lastname = "Williams",
            Shortname = "V.WIL",
            Picture = "https://data.latelier.co/training/tennis_stats/resources/Venus.webp",
            Sex = "F",
            Data = new DataDto
            {
                Age = 38,
                Height = 185,
                Weight = 74000,
                Last = new int[] { 0, 1, 0, 0, 1 },
                Points = 1105,
                Rank = 52,
            },
        };
        
        yield return new PlayerDto
        {
            Country = new CountryDto
            {
                Code = "SUI",
                Picture = "https://data.latelier.co/training/tennis_stats/resources/Suisse.png"
            },
            Id = 65,
            Firstname = "Stan",
            Lastname = "Wawrinka",
            Shortname = "S.WAW",
            Picture = "https://data.latelier.co/training/tennis_stats/resources/Wawrinka.png",
            Sex = "M",
            Data = new DataDto
            {
                Age = 33,
                Height = 183,
                Weight = 81000,
                Last = new int[] { 1, 1, 1, 0, 1 },
                Points = 1784,
                Rank = 21,
            },
        };
        
        yield return new PlayerDto
        {
            Country = new CountryDto
            {
                Code = "USA",
                Picture = "https://data.latelier.co/training/tennis_stats/resources/USA.png"
            },
            Id = 102,
            Firstname = "Serena",
            Lastname = "Williams",
            Shortname = "S.WIL",
            Picture = "https://data.latelier.co/training/tennis_stats/resources/Serena.png",
            Sex = "F",
            Data = new DataDto
            {
                Age = 37,
                Height = 175,
                Weight = 72000,
                Last = new int[] { 0, 1, 1, 1, 0 },
                Points = 3521,
                Rank = 10,
            },
        };
        
        yield return new PlayerDto
        {
            Country = new CountryDto
            {
                Code = "ESP",
                Picture = "https://data.latelier.co/training/tennis_stats/resources/Espagne.png"
            },
            Id = 17,
            Firstname = "Rafael",
            Lastname = "Nadal",
            Shortname = "R.NAD",
            Picture = "https://data.latelier.co/training/tennis_stats/resources/Nadal.png",
            Sex = "M",
            Data = new DataDto
            {
                Age = 33,
                Height = 185,
                Weight = 85000,
                Last = new int[] { 1, 0, 0, 0, 1 },
                Points = 1982,
                Rank = 1,
            },
        };
    }
}

