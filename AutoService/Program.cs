namespace AutoService
{
    class Program
    {
        static void Main(string[] args)
        {

            Worker worker = new Worker("Vlad", 40);
            
            Wheel wheel = new Wheel(50);
            Engine engine = new Engine("X15O36",100.0, 200.25, 300.36);
            Car car = new Car("Opel", "Red");

            worker.foldCar(worker, car, wheel, engine);

            car.ReadyCar(wheel, engine, car);





            

        }
    }
}