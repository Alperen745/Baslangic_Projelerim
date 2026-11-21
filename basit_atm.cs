int sifre, adet=0;
        int islem, bakiye = 0, miktar = 0;
        Console.WriteLine("Hesap şifrenizi giriniz: ");
        sifre = Convert.ToInt32(Console.ReadLine());
        if (sifre == 4380)
        {
            Console.WriteLine("Şifre doğru. İşleminize devam ediniz.");

          for(int i = 0; i < 1;)
          {
            System.Console.WriteLine("\nYapmak istediğiniz işlemi giriniz:\nBakiye görüntülemek için '1', \nPara çekmek için '2', \nPara yatırmak için '3',  \nİşleminizi iptal etmek için '4' tuşlayınız.");

            islem = Convert.ToInt32(Console.ReadLine());



            switch(islem)
            {
                case 1:
                    System.Console.WriteLine("Güncel bakiyeniz : "+ bakiye+"TL");
                  
                    break;
                case 2:
                    System.Console.WriteLine("Para çekeceğiniz miktarı giriniz:");
                    miktar = Convert.ToInt32(Console.ReadLine());
                if (bakiye >= miktar)
                    {
                        bakiye = bakiye - miktar;
                        System.Console.WriteLine("işlem sonrası bakiyeniz :"+bakiye+"TL");
                    }
                    else
                    {
                        System.Console.WriteLine("Yetersiz bakiye!");
                    }
                    
                    break;
                case 3:
                    System.Console.WriteLine("Para yatırmak istediğiniz miktarı giriniz:");
                    miktar = Convert.ToInt32(Console.ReadLine());
                    bakiye = bakiye + miktar;
                    System.Console.WriteLine("Para yatırma işlemi başarılı. İşlem sonrası bakiyeniz : "+bakiye+"TL");
                    
                    break;
                case 4:
                    System.Console.WriteLine("işleminiz iptal edildi");
                    i = 1;

                    break;
                default:
                    System.Console.WriteLine("Geçersiz bir seçim yaptınız!");
                    
                    break;
            }
          }
        }
            else 
            {
            Console.WriteLine("Şifre hatalı");
            }