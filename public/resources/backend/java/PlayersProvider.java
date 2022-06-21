import java.util.stream.Stream;

public class PlayersProvider {
    public Stream<PlayerDto> getAllPlayers() {
        return Stream.of(
            new PlayerDto(52, "Novak", "Djokovic", "N.DJO", "M", new CountryDto("SRB", "https://data.latelier.co/training/tennis_stats/resources/Serbie.png"), "https://data.latelier.co/training/tennis_stats/resources/Djokovic.png", new DataDto(2, 2542, 80000, 188, 31, new int[] { 1, 1, 1, 1, 1 })),
            new PlayerDto(95, "Venus", "Williams", "V.WIL", "F", new CountryDto("USA", "https://data.latelier.co/training/tennis_stats/resources/USA.png"), "https://data.latelier.co/training/tennis_stats/resources/Venus.webp", new DataDto(52, 1105, 74000, 185, 38, new int[] { 0, 1, 0, 0, 1 })),
            new PlayerDto(65, "Stan", "Wawrinka", "S.WAW", "M", new CountryDto("SUI", "https://data.latelier.co/training/tennis_stats/resources/Suisse.png"), "https://data.latelier.co/training/tennis_stats/resources/Wawrinka.png", new DataDto(21, 1784, 81000, 183, 33, new int[] { 1, 1, 1, 0, 1 })),
            new PlayerDto(102, "Serena", "Williams", "S.WIL", "F", new CountryDto("USA", "https://data.latelier.co/training/tennis_stats/resources/USA.png"), "https://data.latelier.co/training/tennis_stats/resources/Serena.png", new DataDto(10, 3521, 72000, 175, 37, new int[] { 0, 1, 1, 1, 0 })),
            new PlayerDto(17, "Rafael", "Nadal", "R.NAD", "M", new CountryDto("ESP", "https://data.latelier.co/training/tennis_stats/resources/Espagne.png"), "https://data.latelier.co/training/tennis_stats/resources/Nadal.png", new DataDto(1, 1982, 85000, 185, 33, new int[] { 1, 0, 0, 0, 1 }))
        );
    }
}