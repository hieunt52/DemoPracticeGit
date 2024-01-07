using System;
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    class Program
    {
        static void Main()
        {
            Person person1 = new Person("TH", 20);
            Console.WriteLine("person1 Name = {0} Age = {1}", person1.Name, person1.Age);


            Person person2 = person1;


            person2.Name = "NA";
            person2.Age = 19;

            Console.WriteLine("person2 Name = {0} Age = {1}", person2.Name, person2.Age);
        }
    }
}
//   nguyên tắc đầu tiên trong solid là Single responsibility priciple
//   nếu ta tạo quá nhiều chức vụ trong class stdudent thì ta phải đưa rất nhiều phương thức vào trong một lớp
//   gây ra hiện tượng cồng kềnh khó đọc và sửa code vì vậy ta nên tạo ra một lớp trừu tượng có phương thức
//   nên tạo từng class riêng có chức năng sửa chữa riêng sẽ không ảnh hưởng đến các class còn lại