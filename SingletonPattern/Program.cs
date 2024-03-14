using SingletonPattern.Service;

//Computer computer = new Computer();
//computer.Launch("Windows 8");
//Console.WriteLine(computer.OS.Name);
//computer.OS = OS.GetInstance("Windows 10");
//Console.WriteLine(computer.OS.Name);

(new Thread(() =>
{
    Computer comp2 = new Computer();
    comp2.OS = OS.GetInstance("Windows 10");
    Console.WriteLine(comp2.OS.Name);

})).Start();

Computer comp = new Computer();
comp.Launch("Windows 8.1");
Console.WriteLine(comp.OS.Name);


(new Thread(() =>
{
    Singleton singleton1 = Singleton.GetInstance();
    Console.WriteLine(singleton1.Name);
})).Start();

Singleton singleton2 = Singleton.GetInstance();
Console.WriteLine(singleton2.Name);