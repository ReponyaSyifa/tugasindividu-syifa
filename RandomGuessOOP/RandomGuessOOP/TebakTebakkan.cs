using System;

namespace RandomGuessOOP
{
    class TebakTebakkan
    {
        /*public int PlayerScore { get; set; }
        public int ComputerScore { get; set; }
        public int AngkaRahasia { get; set;  }
        public int Chance { get; set; }
        public int TebakkanAngka { get; set; }

        public TebakTebakkan()
        {

        }

        public TebakTebakkan(int playerScore, int computerScore, int angkaRahasia, int chance, int tebakkanAngka)
        {
            PlayerScore = playerScore;
            ComputerScore = computerScore;
            AngkaRahasia = angkaRahasia;
            Chance = chance;
            TebakkanAngka = tebakkanAngka;
        }*/

        public void RandomGuessing()
        {
            int playerScore = 0, computerScore = 0;
            int angkaRahasia = 0, chance = 1, tebakAngka = 0;
            
            for (int ronde = 1; ronde <= 10; ronde++) //looping
            {
                System.Random random = new System.Random();
                angkaRahasia = random.Next(1, 10);
                Console.WriteLine("Ronde: " + ronde);
                Console.WriteLine("Hint: hati-hati dalam input tebak angka! ");
                Console.WriteLine("================================================\n");
                
                try
                {
                    Console.WriteLine("(Pikirkan angka dari 1-10)");
                    Console.Write("Input angka tebakkan Anda: ");
                    string a = Console.ReadLine();
                    tebakAngka = int.Parse(a);
                    
                    do //decision
                    {
                        //angkaRahasia = random.Next(1, 10);
                        if (tebakAngka < angkaRahasia)
                        {
                            Console.WriteLine("\nMaaf, tebakkanmu terlalu kecil");
                        }
                        if (tebakAngka > angkaRahasia)
                        {
                            Console.WriteLine("\nMaaf, tebakkanmu terlalu besar");
                        }
                        if (chance == 1)
                        {
                            try
                            {
                                Console.Write("Nyawamu tinggal 2 lagi, Tebak Lagi: ");
                                string b = Console.ReadLine();
                                tebakAngka = int.Parse(b);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Tipe Input Salah. Tipe inputan berupa ANGKA\n");
                                Console.WriteLine("================================================\n");
                            }
                            chance++; //operator increment
                        }
                        else if (chance > 1)
                        {
                            try
                            {
                                Console.Write("Nyawamu tinggal tinggal 1 lagi, Tebak Lagi: ");
                                string b = Console.ReadLine();
                                tebakAngka = int.Parse(b);
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Tipe Input Salah. Tipe inputan berupa ANGKA\n");
                                Console.WriteLine("================================================");
                            }
                            chance++; //operator increment
                        }
                    } while (angkaRahasia != tebakAngka && chance < 3);
                    
                    if (angkaRahasia == tebakAngka)
                    {
                        Console.WriteLine("\nYeay! Benar");
                        playerScore += 1; //operator artmatika
                        Console.WriteLine("Yow! Angka Rahasianya: " + angkaRahasia+"\n");
                        Console.WriteLine("================================================");
                    }
                    else
                    {
                        Console.WriteLine("\nHuu! Salah");
                        computerScore += 1;
                        Console.WriteLine("Sstt! Angka Rahasianya itu: " + angkaRahasia+ "\n");
                        Console.WriteLine("================================================");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Tipe Input Salah. Tipe inputan berupa ANGKA\n");
                    Console.WriteLine("================================================");
                }
            }
            Console.Clear();
            
            Console.WriteLine("\n=================== END GAME ===================");
            Console.WriteLine("================================================");
            Console.WriteLine("Total Computer Score: " + computerScore);
            Console.WriteLine("================================================");
            ScorringCategory(playerScore); //panggil method non-void scorringCategory
            Console.WriteLine("\n============== THANKS FOR PLAYING ==============");
            Console.WriteLine("================================================");
            
        }

        static int ScorringCategory(int playerScore) //method non-void scorringCategory
        {
            String[] hadiah = { "Tepuk Tangan", "Thumbs Up", "Thumbs Down" };
            if (playerScore == 10)
            {
                Console.WriteLine("\nWew! Hebat!! Skor Kamu: " + playerScore);
                Console.WriteLine("Kamu dapat hadiah: " + hadiah[0]);
            }
            else if (playerScore >= 7 && playerScore <= 9)
            {
                Console.WriteLine("\nPro sekali dalam menebak! Skor kamu: " + playerScore);
                Console.WriteLine("Kamu dapat hadiah: " + hadiah[1]);
            }
            else if (playerScore < 7)
            {
                Console.WriteLine("\nNewbie! Skor kamu: " + playerScore);
                Console.WriteLine("Kamu dapat hadiah: " + hadiah[2]);
            }
            return playerScore;
        }        
        
    }
}
