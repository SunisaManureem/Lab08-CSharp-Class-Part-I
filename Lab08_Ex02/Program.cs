using System;

public class Program
{
    public static void Main()
    {
        Person p = new Person();
        p.Name = "Rambo";  // ใช้ property
        p.Id = "1987";     // ใช้ property
        p.Income = 2500;   // ใช้ property

        // แสดงประเภทของ p
        System.Console.WriteLine($"Type of p is {p.GetType()}");

        // แสดงประเภทของสมาชิก
        System.Console.WriteLine($"p.Name = {p.Name}\ttype = {p.Name.GetType()}");
        System.Console.WriteLine($"p.Id = {p.Id}\ttype = {p.Id.GetType()}");
        System.Console.WriteLine($"p.Income = {p.Income}\ttype = {p.Income.GetType()}");
    }
}

public class Person
{
    // ใช้ public properties เพื่อให้เข้าถึงได้จากภายนอก
    public string Name { get; set; }
    public string Id { get; set; }
    public int Income { get; set; }
}
