/* Для реализованного класса создать новый класс Creator, который будет являться фабрикой объектов класса здания. 
 * Для этого изменить модификатор доступа к конструкторам класса, 
 * в новый созданный класс добавить перегруженные фабричные методы CreateBuild для создания объектов класса здания. 
 * В классе Creator все методы сделать статическими, конструктор класса сделать закрытым. 
 * Для хранения объектов класса здания в классе Creator использовать хеш-таблицу. 
 * Предусмотреть возможность удаления объекта здания по его уникальному номеру из хеш-таблицы. 
 * Создать тестовый пример, работающий с созданными классами.*/

using System;
using Buildings;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BuildingFactory.CreateBuilding(40, 4, 40, 5);
            BuildingFactory.CreateBuilding(30, 40, 4);

            foreach (Building building in BuildingFactory.Buildings.Values)
            {
                Console.WriteLine($"===================================================\n" +
                                  $"Здание № {building.Id}\n" +
                                  $"Высота: {building.Height}\n" +
                                  $"Число квартир: {building.NumOfFlats}\n" +
                                  $"Квартир на этаже: {building.CountFlatsOnFloor()}\n");
            }

            BuildingFactory.Buildings.Remove(1);
        }
    }
}
