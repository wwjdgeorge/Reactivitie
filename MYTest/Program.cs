// See https://aka.ms/new-console-template for more information
using MYTest;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;


 CardGame cardGame = new CardGame();
cardGame.gameName = "Ace";
cardGame.GetCardValue();
//StringConversion.Main();

List<int> Mylist = new List<int> { 1,2,3,5,6,8};
IEnumerable<int> Mylist2 = from s in Mylist
                           where s % 2 ==0
                           select s;
//foreach (int i in Mylist2)
//{
//    Console.WriteLine(i);    
//}
linqSample.SampleLinq2();
Func<int, bool> isEven = x => x % 2 == 0;

var myNum = new List<int> { 1, 2, 4, 6, 3, 3, 22, 44, 6 };
var numFive= myNum.Where(n => n>5);
//foreach (int i in numFive)
//{
//    Console.WriteLine(i);
//}

var gamelist = new List<Game>
{
    new Game{name="1", Score=10},
     new Game{name="2", Score=11},
      new Game{name="3", Score=13},
       new Game{name="4", Score=14}
};

  List<string> str= gamelist.Select(x => x.name).ToList();


List<StarRating> starRating = gamelist.Select(x => new StarRating
{
    name = x.name,
    Stars= x.Score * 0.5
}).ToList();
Random rnd = new Random();

var SuggestedGame = gamelist.Where(x => x.Score > 5 && x.Score < 20).OrderBy(x => rnd.Next()).Take(3).AddRatingtoName();
    
                               

var score = gamelist.All(x=> x.Score >10  );
 var firstValue= gamelist.FirstOrDefault(x=> x.Score == 10);

IEnumerable<(int hour, int temperature)> hourlyTemperatures = new List<(int, int)> { (1, 23), (2, 26), (3, 20), (4, 24), (5, 30), (6, 22), (7, 24), (8, 20), (9, 25) };

var query = hourlyTemperatures.GroupBy(ht => ht.temperature / 10, ht => ht.hour);

foreach (var group in query)
{
    Console.WriteLine($"Hours when the temperature was in the {group.Key * 10}s: {string.Join(", ", group)}");
}

List<string> name = new List<string> { "A","B","Carol","David"};
IEnumerable<string> STc= name.Where(x => x.StartsWith('c'));



var students = new List<Student>
{
    new Student { Id = 1, Name = "John", Age = 20 },
    new Student { Id = 2, Name = "Alice", Age = 19 }
};
var Results1 = from s in students
               where s.Age > 18
               orderby s.Name ascending
               select s ;

var Resultsr = from s in students
               where s.Age > 18
               group s by s.Class into studerntgrouip
               select studerntgrouip;
var maxS = students.Max(s => s.Age);
var fName= new string[] { "John", "Jane", "Jim", "Jane" };
var lName = new string[] { "Doe", "Smith", "Adams", "John" };
var dis= fName.Distinct();
var dis1 = fName.Union(lName);

IEnumerable<Student> filteredStudents = students;

filteredStudents= filteredStudents.Where(x => x.Age > 18);

ArrayList fruits = new ArrayList(4);
fruits.Add("Mango");
fruits.Add("Orange");
fruits.Add("Apple");
fruits.Add(3.0);
fruits.Add("Banana");
IEnumerable<string> query1 = fruits.OfType<string>().Where(x => x.StartsWith("M"));

// array
int[] nums = new int[5] { 10, 15, 16, 8, 6 };
Array.ForEach(nums, n=> Console.WriteLine(n));

IDictionary<int, string> numberNames = new Dictionary<int, string>();
numberNames.Add(0,"Zero");
numberNames.Add(1, "One"); //adding a key/value using the Add() method
numberNames.Add(2, "Two");
numberNames.Add(3, "Three");
foreach(KeyValuePair<int,string> number in numberNames)
{
    Console.WriteLine("key{0} - Value{1}",number.Key, number.Value);
}
//CardGame cardGame = new CardGame();
//cardGame.GetCArdValue = "Ace";
//cardGame.GetCArdValue();
//enum week
//{
//    monday =1,
//    Tue =2
//}

//Console.WriteLine((int)week.monday);
//Enum.TryParse<week>()

var data = new List<DataPoint>
{
    new DataPoint { Value1 = 1, Value2 = 2 },
    new DataPoint { Value1 = 2, Value2 = 3 },
    new DataPoint { Value1 = 3, Value2 = 4 },
};  

internal class DataPoint
{
    public int Value1 { get; set; }
    public int Value2 { get; set; }
}

public class Student
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
    public string Class { get; set; }
    public string Address { get; set; }
    public List<int> Marks { get; set; }
}
class Teacher { public int ID { get; set; } public string Name { get; set; } public string Address { get; set; } }
public class Game
{
    public string name { get; set; }
    public int Score { get; set; }
}



internal class StarRating
{
    public string name { get; set; }
    public double Stars { get; set; }
}

class PetOwner
{
    public string Name { get; set; }
    public List<String> Pets { get; set; }
}
[Serializable]

public static class helper
{
    public static IEnumerable<Game> AddRatingtoName(this IEnumerable<Game> games)
    {
        foreach (var game in games)
        {
            game.name = $"{game.name} - {game.Score}";
        }
        return games;
    }
}
/*
    namespace redis_demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CacheController : ControllerBase
    {
        private readonly IDatabase _database;
 
        public CacheController(IDatabase database)
        {
            _database = database;
        }
 
        // GET: api/Cache?key=key
        [HttpGet]
        public string Get([FromQuery]string key)
        {
            return _database.StringGet(key);
        }
 
        // POST: api/Cache
        [HttpPost]
        public void Post([FromBody] KeyValuePair<string,string> keyValue)
        {
            _database.StringSet(keyValue.Key, keyValue.Value);
        }
    }
}
*/