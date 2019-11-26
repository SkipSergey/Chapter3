namespace Chapter3
{
    public class Car: Transport
    {
        //Класс для зодания объекта машина
        public Car(object engine, object transmission, double maxWeight) : base(engine, transmission, maxWeight)
        {
        }

        public override string Move()
        {
            return "Автомобиль едит из города А в город Б";
        }

        public override string Reparing()
        {
            return "Производится ремонт автомобиля";
        }
    }
}