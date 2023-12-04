namespace AbstractFactory
{
    public interface Chair
    {
        void SitOn();
    }

    public interface Sofa
    {
        void LayOn();
    }

    public interface CoffeeTable
    {
        void DrinkCoffe();
    }


    public class ArtDecoChair : Chair
    {
        public void SitOn()
        {
            Console.WriteLine("Sitting on an Art Deco chair");
        }
    }

    public class VictorianChair : Chair
    {
        public void SitOn()
        {
            Console.WriteLine("Sitting on a Victorian chair");
        }
    }

    public class ModernChair : Chair
    {
        public void SitOn()
        {
            Console.WriteLine("Sitting on a Modern chair");
        }
    }

    public class ArtDecoSofa : Sofa
    {
        public void LayOn()
        {
            Console.WriteLine("laying on an Art Deco sofa");
        }
    }

    public class VictorianSofa : Sofa
    {
        public void LayOn()
        {
            Console.WriteLine("Laying on a Victorian sofa");
        }
    }

    public class ModernSofa : Sofa
    {
        public void LayOn()
        {
            Console.WriteLine("Laying on a Modern sofa");
        }
    }

    public class ArtDecoCoffeeTable : CoffeeTable
    {
        public void DrinkCoffe()
        {
            Console.WriteLine("Drinking coffe on Art Deco coffee table");
        }
    }

    public class VictorianCoffeeTable : CoffeeTable
    {
        public void DrinkCoffe()
        {
            Console.WriteLine("Drinking coffe on Victorian coffee table");
        }
    }

    public class ModernCoffeeTable : CoffeeTable
    {
        public void DrinkCoffe()
        {
            Console.WriteLine("Drinking coffe on Modern coffee table");
        }
    }


    public interface FurnitureFactory
    {
        public Chair createChair();
        public Sofa createSofa();
        public CoffeeTable createCoffeeTable();
    }


    public class ArtDecoFactory : FurnitureFactory
    {
        public Chair createChair()
        {
            return new ArtDecoChair();
        }

        public Sofa createSofa()
        {
            return new ArtDecoSofa();
        }

        public CoffeeTable createCoffeeTable()
        {
            return new ArtDecoCoffeeTable();
        }
    }

    public class VictorianFactory : FurnitureFactory
    {
        public Chair createChair()
        {
            return new VictorianChair();
        }

        public Sofa createSofa()
        {
            return new VictorianSofa();
        }

        public CoffeeTable createCoffeeTable()
        {
            return new VictorianCoffeeTable();
        }
    }

    public class ModernFactory : FurnitureFactory
    {
        public Chair createChair()
        {
            return new ModernChair();
        }

        public Sofa createSofa()
        {
            return new ModernSofa();
        }

        public CoffeeTable createCoffeeTable()
        {
            return new ModernCoffeeTable();
        }
    }

   
    internal class Program
    {
        static void Main()
        {
           
            FurnitureFactory artDecoFactory = new ArtDecoFactory();
            artDecoFactory.createSofa();

            FurnitureFactory victorianFactory = new VictorianFactory();
            victorianFactory.createChair();

            FurnitureFactory modernFactory = new ModernFactory();
            modernFactory.createSofa();
            
        }
    }
}