public class PlayerDto {
    public PlayerDto(int id, String firstname, String lastname, String shortname, String sex, CountryDto country, String picture, DataDto data){
        this.id = id;
        this.firstname = firstname;
        this.lastname = lastname;
        this.shortname = shortname;
        this.sex = sex;
        this.country = country;
        this.picture = picture;
        this.data = data;
    }

    public int id;
    public String firstname;
    public String lastname;
    public String shortname;
    public String sex;
    public CountryDto country;
    public String picture;
    public DataDto data;
}