namespace Tyuiu.ShahabAJ.Sprint1.Task3.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*************************");

            Console.Write("Расстояние до дачи (км) -> ");
            double distance = Convert.ToDouble(Console.ReadLine());

            Console.Write("Расход бензина (литров на 100 км пробега) -> ");
            double fuelConsumption = Convert.ToDouble(Console.ReadLine());

            Console.Write("Цена литра бензина (руб.) -> ");
            double pricePerLiter = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("*************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("*************************");

            double result = ds.TravelCost(distance, fuelConsumption, pricePerLiter);
            Console.WriteLine($"Поездка на дачу и обратно обойдется в {result} руб.");

            Console.ReadKey();
        }
    }
}