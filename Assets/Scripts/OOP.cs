using UnityEngine;

public class OOP : MonoBehaviour
{
    private void Start()
    {
        Dog dog = new Dog("Rex");
        dog.MakeSound(); // Rex barks.
        Dog.PrintHowManyDogs(); // There are 1 dogs.

        ISwimming duck = new Duck("Donald");
        duck.Swim(); // Donald swims.
    }

}

#region Задание

/*
        1. Создайте абстрактный класс `Animal` с защищенной переменной `name` и конструктором, 
        который принимает имя животного. Добавьте виртуальный метод `MakeSound`, 
        который будет переопределен в дочерних классах.

        2. Создайте класс `Dog`, который наследует от `Animal`. 
        В этом классе добавьте статическую переменную `dogCount` 
        и конструктор, который увеличивает `dogCount` при создании 
        нового объекта `Dog`. Переопределите метод `MakeSound` для 
        класса `Dog`. Добавьте статический метод `HowManyDogs`, 
        который выводит количество созданных объектов `Dog`.

        3. Создайте интерфейс `ISwimming` с методом `Swim`.

        4. Создайте класс `Duck`, который наследует от `Animal` и реализует интерфейс `ISwimming`. 
        Переопределите метод `MakeSound` и реализуйте метод `Swim` для класса `Duck`.

        5. В главном методе программы создайте объекты `Dog` и `Duck`, вызовите их методы `MakeSound` 
        и `Swim` (для `Duck`), а также статический метод `HowManyDogs` класса `Dog`.

     */

#endregion

# region Ответ

public abstract class Animal
{
    protected string name;

    public Animal(string name)
    {
        this.name = name;
    }

    public virtual void MakeSound()
    {
        Debug.Log($"{name} makes a sound.");
    }
}

public class Dog : Animal
{
    public static int dogCount = 0;

    public Dog(string name) : base(name)
    {
        dogCount++;
    }

    public override void MakeSound()
    {
        Debug.Log($"{name} barks.");
    }

    public static void PrintHowManyDogs()
    {
        Debug.Log($"There are {dogCount} dogs.");
    }
}

public interface ISwimming
{
    void Swim();
}

public class Duck : Animal, ISwimming
{
    public Duck(string name) : base(name) { }

    public override void MakeSound()
    {
        Debug.Log($"{name} quacks.");
    }

    public void Swim()
    {
        Debug.Log($"{name} swims.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Dog dog = new Dog("Rex");
        dog.MakeSound(); // Rex barks.
        Dog.PrintHowManyDogs(); // There are 1 dogs.

        Duck duck = new Duck("Donald");
        duck.MakeSound(); // Donald quacks.
        duck.Swim(); // Donald swims.
    }
}
#endregion
