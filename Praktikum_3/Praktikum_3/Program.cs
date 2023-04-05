using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _VGA;
using _Processor;

namespace Praktikum_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Vivobook();
            laptop1.processor = new Corei5();
            laptop1.vga = new NVIDIA();
            Console.WriteLine("Merk Laptop  : " + laptop1.merk);
            Console.WriteLine("Dengan Tipe  : " + laptop1.tipe);
            Console.WriteLine("BerProcessor : "+ laptop1.processor.merk+ " " + laptop1.processor.tipe);
            Console.WriteLine("BerVGA       : " + laptop1.vga.merk);
            laptop1.Ngoding();//tinggal hapus


            Laptop laptop2 = new IdeaPad();
            laptop2.processor = new Ryzen();
            laptop2.vga = new _VGA.AMD();
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();

            Predator predator = new Predator();
            predator.processor = new Corei7();
            predator.vga = new _VGA.AMD();
            predator.BermainGame();

            ACER acer = new Predator();
            acer.BermainGame();//tinggal hapus
        }
    }


    public class Laptop
    {
        public string merk, tipe;
        public Processor processor { get; set; }
        public VGA vga { get; set; }
        

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} menyala");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} mati");
        }

    }

    class ASUS : Laptop
    {
        public ASUS() {
            base.merk = "ASUS"; 
        }
    }

    class ROG : ASUS
    {
        public ROG() {
            base.tipe = "ROG"; 
        }
    }
    class Vivobook : ASUS
    {
        public Vivobook()
        {
            base.tipe = "VivoBook";

        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }
    
    class ACER : Laptop { 
    
    public ACER() { base.merk = "ACER"; }
    }

    class Swift : ACER
    {
        public Swift() { base.tipe = "Swift"; }
    }
    class Predator : ACER
    {
        public Predator() { base.tipe = "Predator"; }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
        }
    }
    class Lenovo : Laptop
    {
        public Lenovo() { 
            base.merk ="Lenovo"; 
        }
    }

    class IdeaPad : Lenovo
    {
        public IdeaPad() { 
            base.tipe = "IdeaPad"; 
        }
    }
    class Legion : Lenovo
    {
        public Legion()
        {
            base.tipe = "Legion";
        }
    }
}
