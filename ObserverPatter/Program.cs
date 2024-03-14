using ObserverPatter.Service;
//Реализовать паттерн Observer где есть издатель и несколько подписчиков. При изменении состоянии издателя все подписчики должны быть уведомлениы
Publisher publisher = new Publisher();

var subscriber = new Subscriber("One sub");
var subscriber2 = new Subscriber("Two sub");

publisher.AddObserver(subscriber);
publisher.AddObserver(subscriber2);
publisher.ChangeState();

publisher.RemoveObserver(subscriber);
publisher.ChangeState();