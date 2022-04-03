using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLesson4
{
    internal class Building
    {
        private protected int _idBuilding; //id здания, должен быть уникальным
        private static int _lastIdBuilding; //последний использованный id
        private int _hightBuilding; // высота здания
        private int _countFloor; //кол-во этажей
        private int _countApartment; // кол-во квартир
        private int _countEntance; // кол-во подъездов


        internal Building()
        {
            _idBuilding = _lastIdBuilding + 1;
            _lastIdBuilding = _idBuilding;
        }

        //установка и получание параметров
        internal int getIdBuilding()
        {
            return _idBuilding;
        }
        internal void setHightBuilding (int hightBuilding)
        {
            _hightBuilding = hightBuilding;
        }

        internal int getHightBuilding()
        {
            return _hightBuilding;
        }

        internal void setCountFloor(int countFloor)
        {
            _countFloor = countFloor;
        }

        internal int getCountFloor()
        {
            return _countFloor;
        }

        internal void setCountApartment(int countApartment)
        {
            _countApartment = countApartment;
        }

        internal int getCountApartment()
        {
            return _countApartment;
        }

        internal void setCountEntance(int countEntance)
        {
            _countEntance = countEntance;
        }

        internal int getCountEntance()
        {
            return _countEntance;
        }

        //методы вычисления высоты этажа, количества квартир в подъезде, количества квартир на этаже

        internal double CalculatedHightFloor()
        {
            double hightFloor = 0;
            if (_countFloor != 0)hightFloor = (double)_hightBuilding / _countFloor;
            return hightFloor;
        }

        internal double CalculatedNumberApartmentFloor()
        {
            double numberApartmentFloor = 0;
            if (_countFloor != 0) numberApartmentFloor = (double)_countApartment / _countFloor;
            return numberApartmentFloor;
        }

        internal int CalculatedNumberApartmentEntrance()
        {
            int numberApartmentEntrance = 0;
            if (_countEntance != 0) numberApartmentEntrance = _countApartment / _countEntance;
            return numberApartmentEntrance;
        }

        /// <summary>
        /// Создает произвольные параметры для текущего здания
        /// </summary>
        internal void RandomParametrsBuilding()
        {
            var rnd = new Random();
            setHightBuilding(rnd.Next(1,60));
            setCountFloor(rnd.Next(1,20));
            setCountApartment(rnd.Next(1,getCountFloor())); //кол-во квартир не может быть больше кол-ва этажей
            setCountEntance(rnd.Next(1,getCountApartment())); //кол-во подъездов не может быть больше кол-ва квартир
        }

        /// <summary>
        /// Показывает в консоли параметры здания
        /// </summary>
        internal void ShowParametrsBuilding()
        {
            Console.WriteLine($"Текущий id здания: {_idBuilding}");
            Console.WriteLine($"Последний использованный id здания: {_lastIdBuilding}");
            Console.WriteLine($"Высота здания: {_hightBuilding}");
            Console.WriteLine($"Кол-во этажей в здании: {_countFloor}");
            Console.WriteLine($"Кол-во квартир в здании: {_countApartment}");
            Console.WriteLine($"Кол-во подъездов в здании: {_countEntance}");
            Console.WriteLine($"Высота этажа в здании: {CalculatedHightFloor()}");
            Console.WriteLine($"Кол-во квартир на этаже в здании: {CalculatedNumberApartmentFloor()}");
            if (CalculatedNumberApartmentFloor() < 1) Console.WriteLine("Некоторые квартиры имеют несколько этажей.");
            Console.WriteLine($"Кол-во квартир в подъезде в здании: {CalculatedNumberApartmentEntrance()}");
            Console.ReadLine();
        }
    }
}
