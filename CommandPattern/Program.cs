using CommandPattern.ServicePattern.MacroCommand.Command;
using CommandPattern.ServicePattern.MacroCommand;
using CommandPattern.ServicePattern.TVPatternRealized;
using CommandPattern.Interfaces;

//Паттерн "Команда" (Command) позволяет инкапсулировать запрос на выполнение определенного действия в виде отдельного
//объекта. Этот объект запроса на действие и называется командой. При этом объекты, инициирующие запросы на выполнение
//действия, отделяются от объектов, которые выполняют это действие.


Pult pult = new Pult();
TV tv = new TV();
pult.SetCommand(new TVOnCommand(tv));
pult.PreesButton();
pult.PreesUndo();

Console.WriteLine("=================================");

Programmer programmer = new Programmer();
Tester tester = new Tester();
Marketolog marketolog = new Marketolog();

List<ICommand> commands = new List<ICommand>
        {
            new CodeCommand(programmer),
            new TestCommand(tester),
            new AdvertizeCommand(marketolog)
        };
Manager manager = new Manager();
manager.SetCommand(new MacroCommand(commands));
manager.StartProject();
manager.StopProject();