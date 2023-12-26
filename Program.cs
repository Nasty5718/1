public abstract class Ship
{
    public decimal Speed { get; set; } // свойство скорости в надводном положении
    public int Crew { get; set; } // свойство Экипаж
}
//Группируем по теме Надводный ход
public class SailingShip : Ship
{
    public int NumberOfMasts { get; set; } // свойство Парусника (Кол-во матч)
    public int NumberOfDesks { get; set;} // (Кол-во палуб)
}
public class Submarine : Ship
{
    public decimal SpeedUnderwater { get; set; } //свойство Подводной лодки (скорость в подводном положении)
    public int EmergencySurfacingTime { get; set; } //свойство времени аварийного всплытия на поверхность
}

public class DieselShip : Ship
{
    public int EnginePower { get; set; } //свойство Корабля с дизельной СУ (Мощность)
    public decimal Range { get; set; } //свойство Дальность хода
}
public class NuclearShip : Ship
{
    public int EnginePower { get; set; } //свойство Корабля с атомной СУ (Мощность)
    public string ReactorModel { get; set; } //свойство Марка реактора
}

public class Steamship : Ship
{
    public decimal WheelDiameter { get; set; } //свойство Парахода (Диаметр колес)
}