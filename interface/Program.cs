using malEjemplo;

class Program {
    static void Main(String[] args) {
        Console.WriteLine("Hello World");

        ZTE miZTE = new ZTE("700", 2023, 2000, 4);
        miZTE.llamar();
        miZTE.pagarConNFC();

        Iphone15 miIphone15 = new Iphone15("Apple", 2020, 15000, 6);

        Xiaomi miXiaomi = new Xiaomi("Xiaomi", 2021, 5000, 8);
    }
}