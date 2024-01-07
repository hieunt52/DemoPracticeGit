class Program
{
    static void Main(string[] args)
    {
        DoSomething();
        DoSomethingAgain();
        DoSomethingMore();
        DoSomethingExtraordinary();
        Console.ReadLine();
    }

    private static void DoSomething()
    {
        string address = "HD, Vie";
        string format = "{0} is {1}, lives in {2}, age {3}";
        Console.WriteLine(format, "Hiu", "a good friend", address, 20);
    }

    private static void DoSomethingAgain()
    {
        string address = "HN, VN";
        string format = "{0} is {1}, lives in {2}, age {3}";
        Console.WriteLine(format, "Ms.Hoa", "a neighbour", address, 54);
    }

    private static void DoSomethingMore()
    {
        string address = "ND, VN";
        string format = "{0} is {1}, lives in {2}, age {3}";
        Console.WriteLine(format, "Trung", "my brother", address, 27);
    }

    private static void DoSomethingExtraordinary()
    {
        string address = "HD, VN";
        string format = "{0} is {1}, lives in {2}, age {3}";
        Console.WriteLine(format, "Huong", "my sister", address, 26);
    }
}

//    nguyên tắc dry
//    Nguyên tắc này có nghĩa là đừng có viết lặp bất kỳ lại một đoạn mã nào mà hãy đóng gói nó thành phương thức riêng.Đến khi cần thì chỉ cần gọi tên nó ra.
//    Nguyên tắc này nó giống như tính chất kế thừa trong lập trình hướng đối tượng OOP mà chúng ta đã quá quen thuộc rồi.
