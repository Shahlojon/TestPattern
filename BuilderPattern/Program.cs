﻿//Строитель(Builder) - шаблон проектирования, который инкапсулирует создание объекта и позволяет разделить его на различные этапы.


// содаем объект пекаря
using BuilderPattern.Service;

Baker baker = new Baker();
// создаем билдер для ржаного хлеба
BreadBuilder builder = new RyeBreadBuilder();
// выпекаем
Bread ryeBread = baker.Bake(builder);
Console.WriteLine(ryeBread.ToString());
// оздаем билдер для пшеничного хлеба
builder = new WheatBreadBuilder();
Bread wheatBread = baker.Bake(builder);
Console.WriteLine(wheatBread.ToString());