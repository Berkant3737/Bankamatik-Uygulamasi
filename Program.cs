namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            string secim = "";
            double bakiye = 0;
            do
            {
                Console.WriteLine("1-Bakiye Görüntüle\n2-Para Yatırma\n3-Para Çekme\n4-Çıkış\nSeçiminiz");
                secim = Console.ReadLine();
                switch (secim)
                {
                    case "1":
                        Console.WriteLine("Toplam bakiyeniz {0} TL", bakiye);
                        break;
                    case "2":
                        Console.WriteLine("Yatırmak istediğiniz miktarı giriniz");
                        double yatirilan = double.Parse(Console.ReadLine());
                        bakiye += yatirilan;
                        break;
                    case "3":
                        Console.WriteLine("Çekmek istediğiniz miktarı giriniz");
                        double cekilen = double.Parse(Console.ReadLine());
                        
                        if(cekilen > bakiye){
                            Console.WriteLine("Bakiyeniz Yetersiz");
                        }else{
                            bakiye -= cekilen;
                        }
                        break;
                    case "4":
                        Console.WriteLine("Para Çıkış");
                        break;
                    default:
                        Console.WriteLine("Hatalı Seçim");
                        break;

                }
            } while (secim != "4");
            Console.WriteLine("Çıkış Yapıldı");
        }
    }
}