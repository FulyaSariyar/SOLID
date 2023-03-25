using Single_Responsibility_Principle;

namespace Single_Responsibility_Principle_NotIdealCode;

class Database
{
    public void Connect()
    {
        //...
        Console.WriteLine("Veritabanı bağlantısı sağlanmıştır.");
    }
    public void Disconnect()
    {
        //...
        Console.WriteLine("Veritabanı bağlantısı kesilmiştir.");
    }
    public string State { get; set; }
    public List<Person> GetPersons()
    {
        return new() {
            new(){ Name = "Alpaçino", Surname = "GodFather" },
            new(){ Name = "Alpaçino", Surname = "Skyface" },
            new(){ Name = "Apollonia", Surname = "Vitelli Corleone" }
        };
    }
}