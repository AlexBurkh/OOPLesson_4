﻿/* Для реализованного класса создать новый класс Creator, который будет являться фабрикой объектов класса здания. 
 * Для этого изменить модификатор доступа к конструкторам класса, 
 * в новый созданный класс добавить перегруженные фабричные методы CreateBuild для создания объектов класса здания. 
 * В классе Creator все методы сделать статическими, конструктор класса сделать закрытым. 
 * Для хранения объектов класса здания в классе Creator использовать хеш-таблицу. 
 * Предусмотреть возможность удаления объекта здания по его уникальному номеру из хеш-таблицы. 
 * Создать тестовый пример, работающий с созданными классами.*/

using System;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
