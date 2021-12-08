/*Використовуючи інтерфейси або спадкування реалізуйте еволюцію: дисковий телефон -> 
 * кнопочний телефон –>
 * мобільний телефон з чорно-> 
 * білим екраном – >
 * мобільний телефон з кольоровим екраном – >
 * смартфон. (краще спадкування)
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        class SmartPhone : ColorPhone
        {
            string operatingSystem;
            public SmartPhone(string model, string operatingSystem) : base(model)
            {
                this.operatingSystem = operatingSystem;
            }
            public void Browsing(string website)
            {
                Console.WriteLine($"You visit {website}");
            }
        }

        class BNWPhone : ButtonPhone
        {
            string model;
            string melodie;

            public BNWPhone(string model, string melodie)
            {
                this.model = model;
                this.melodie = melodie;
            }
            public BNWPhone(string model) : this(model, "Hello World")
            { }
            public BNWPhone() : this("Motorolla Razor") { }

            public void PlayGames()
            {
                Console.WriteLine("Playing snakes...(Press something to end)");
                Console.ReadKey();
                Console.WriteLine("\nGame ended");
            }
        }

        class ButtonPhone : DiskPhone
        {
            private bool isCalling;

            public ButtonPhone()
            {
                isCalling = false;
            }

            public new void Call(int[] number)
            {
                string num = "";
                for (int i = number.Length - 1; i >= 0; i--)
                {
                    num = number[i] + num;
                }
                Call(num);
            }
            public void Call(string number)
            {
                Console.WriteLine($"Calling {number}...");
                Console.WriteLine("*Call*");
                isCalling = true;
            }
            public void EndCall()
            {
                if (isCalling)
                {
                    isCalling = false;
                    Console.WriteLine("Call is ended");
                }
                else
                {
                    Console.WriteLine("Phone is not calling");
                }
            }
        }

        class ColorPhone : BNWPhone
        {
            string wallpaper;

            public ColorPhone(string model, string wallpaper, string melodie) : base(model, melodie)
            {
                this.wallpaper = wallpaper;
            }
            public ColorPhone(string model, string wallpaper) : this(model, wallpaper, "Hello World") { }
            public ColorPhone(string model) : this(model, "Blue Sky") { }
            public ColorPhone() : this("Nokia 3300") { }

            public void PlayGames(string gameName)
            {
                Console.WriteLine($"Playing {gameName}...(Press something to end)");
                Console.ReadKey();
                Console.WriteLine("\nGame ended");
            }
            public void WatchVideo()
            {
                Console.WriteLine($"Watching video...(Press something to end)");
                Console.ReadKey();
                Console.WriteLine("\nVideo ended");
            }
            public void ListenMusic(string music)
            {
                Console.WriteLine($"Listening {music}...(Press something to end)");
                Console.ReadKey();
                Console.WriteLine("\nMusic stopped");
            }
        }

        class DiskPhone
        {
            public void Call(int[] number)
            {
                Console.WriteLine("Calling...");
                Console.WriteLine("No one respond");
            }
        }


        static void Main(string[] args)
        {
            DiskPhone disk = new DiskPhone();
            ButtonPhone button = new ButtonPhone();
            BNWPhone blacknwhite = new BNWPhone();
            ColorPhone phone = new ColorPhone();
            SmartPhone iphone = new SmartPhone("Iphone 25", "IOS 69");

            int[] number = { 8, 8, 0, 0, 5, 5, 5, 3, 5, 3, 5 };

            Console.WriteLine(disk);
            disk.Call(number);

            Console.WriteLine("\n" + button);
            button.Call(number);
            button.EndCall();
            button.EndCall();

            Console.WriteLine("\n" + blacknwhite);
            blacknwhite.Call(number);
            blacknwhite.EndCall();
            blacknwhite.EndCall();
            blacknwhite.PlayGames();

            Console.WriteLine("\n" + phone);
            phone.Call(number);
            phone.EndCall();
            phone.EndCall();
            phone.PlayGames();
            phone.ListenMusic("Billie Jean");
            phone.WatchVideo();
            phone.PlayGames("GTA: San Andreas");

            Console.WriteLine("\n" + iphone);
            iphone.Call(number);
            iphone.EndCall();
            iphone.EndCall();
            iphone.PlayGames();
            iphone.ListenMusic("Billie Jean");
            iphone.WatchVideo();
            iphone.PlayGames("GTA: San Andreas");
            iphone.Browsing("dut.edu.ua");


            Console.ReadLine();
        }
    }
}