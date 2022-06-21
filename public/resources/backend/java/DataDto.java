public class DataDto {
    public DataDto(int rank, int points, int weight, int height, int age, int[] last) {
        this.rank = rank;
        this.points = points;
        this.weight = weight;
        this.height = height;
        this.age = age;
        this.last = last;
    }

    public int rank;
    public int points;
    public int weight;
    public int height;
    public int age;
    public int[] last;
}