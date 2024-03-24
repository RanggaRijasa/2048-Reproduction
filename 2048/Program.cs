using System;

namespace _2048
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("\r\n .----------------.  .----------------.  .----------------.  .----------------. \r\n| .--------------. || .--------------. || .--------------. || .--------------. |\r\n| |    _____     | || |     ____     | || |   _    _     | || |     ____     | |\r\n| |   / ___ `.   | || |   .'    '.   | || |  | |  | |    | || |   .' __ '.   | |\r\n| |  |_/___) |   | || |  |  .--.  |  | || |  | |__| |_   | || |   | (__) |   | |\r\n| |   .'____.'   | || |  | |    | |  | || |  |____   _|  | || |   .`____'.   | |\r\n| |  / /____     | || |  |  `--'  |  | || |      _| |_   | || |  | (____) |  | |\r\n| |  |_______|   | || |   '.____.'   | || |     |_____|  | || |  `.______.'  | |\r\n| |              | || |              | || |              | || |              | |\r\n| '--------------' || '--------------' || '--------------' || '--------------' |\r\n '----------------'  '----------------'  '----------------'  '----------------' \r\n");
            Console.WriteLine();
            Console.WriteLine("\t\t\t_________________________________");
            Console.WriteLine("\t\t\t|     Press any key to start    |");
            Console.WriteLine("\t\t\t|                               |");
            Console.WriteLine("\t\t        | Recreated By Ayam Geprek Rica |");
            Console.WriteLine("\t\t\t_________________________________");
            Console.ReadKey();
            Console.Clear();
            Random rnd = new Random();
            int[,] angkaboard = new int[5, 5];
            int perCent1 = 0;
            int perCent2 = 0;
            int angka1 = 0;
            int angka2 = 0;
            int angka3 = 0;
            int angka4 = 0;
            int score = 0;
            int ceknol = 0;
            int Hscore = 0;
            int counter = 0;
            bool tempatRandomSama = true;

            angka1 = rnd.Next(1, 5);  // random untuk lokasi angka
            angka2 = rnd.Next(1, 5);
            perCent1 = rnd.Next(0, 200); // persentase angka 2 dan 4
            if (perCent1 <= 53)               
            {
                angkaboard[angka1, angka2] = 4;  // 0 - 53
            }
            if (perCent1 >= 54 || perCent1 <= 200)     
            {
                angkaboard[angka1, angka2] = 2;  // 54 - 200
            }

            while (tempatRandomSama == true) // untuk cek lokasi random
            {
                angka3 = rnd.Next(1, 5); // random lokasi angka
                angka4 = rnd.Next(1, 5);
                if (angka1 != angka3 || angka2 != angka4)
                {
                    tempatRandomSama = false;
                }
            }
            perCent2 = rnd.Next(0, 200);
            if (perCent2 <= 53)               
            {
                angkaboard[angka3, angka4] = 4;
            }
            if (perCent2 >= 54 || perCent2 <= 200)     
            {
                angkaboard[angka3, angka4] = 2;
            }

            Board(Hscore, score, Convert.ToString(angkaboard[1, 1]), Convert.ToString(angkaboard[1, 2]), Convert.ToString(angkaboard[1, 3]), Convert.ToString(angkaboard[1, 4]), Convert.ToString(angkaboard[2, 1]), Convert.ToString(angkaboard[2, 2]), Convert.ToString(angkaboard[2, 3]), Convert.ToString(angkaboard[2, 4]), Convert.ToString(angkaboard[3, 1]), Convert.ToString(angkaboard[3, 2]), Convert.ToString(angkaboard[3, 3]), Convert.ToString(angkaboard[3, 4]), Convert.ToString(angkaboard[4, 1]), Convert.ToString(angkaboard[4, 2]), Convert.ToString(angkaboard[4, 3]), Convert.ToString(angkaboard[4, 4]));

            bool kosong = false; //untuk loop pengecekan apakah index random masih kosong

            bool inputSalah = false; //untuk key selain W, A, S, D

            bool bisaNambah = false; //untuk pengecekan apakah sudah ada angka yang ditambah atau belum

            List<bool> bisaGerak = new List<bool>(); //untuk pengecekan apakah ada angka yang bisa jalan atau ditambah

            bool loop = false;

            while (loop == false)
            {
                bisaGerak.Clear();
                inputSalah = false;
                kosong = false;
                char theKey = ' '; //ini untuk controlsnya (pakai : W, A ,S ,D)
                char game = ' ';
                int count1 = 0;
                int count2 = 0;
                bool wasd = true;
                if (ceknol == 16)
                {
                    for (int i = 1; i <= 4; i++)
                    {
                        for (int j = 1; j <= 3; j++)
                        {
                            if (angkaboard[j, i] != angkaboard[j + 1, i]) // cek atas bawah
                            {
                                count1++; // per colom 3
                            }
                            if (angkaboard[i, j] != angkaboard[i, j + 1]) // cek kanan kiri
                            {
                                count2++; // per baris 3
                            }
                        }
                    }
                }
                if (count1 == 12)
                {
                    while (wasd == true)
                    {
                        Console.Clear();
                        Board(Hscore, score, Convert.ToString(angkaboard[1, 1]), Convert.ToString(angkaboard[1, 2]), Convert.ToString(angkaboard[1, 3]), Convert.ToString(angkaboard[1, 4]), Convert.ToString(angkaboard[2, 1]), Convert.ToString(angkaboard[2, 2]), Convert.ToString(angkaboard[2, 3]), Convert.ToString(angkaboard[2, 4]), Convert.ToString(angkaboard[3, 1]), Convert.ToString(angkaboard[3, 2]), Convert.ToString(angkaboard[3, 3]), Convert.ToString(angkaboard[3, 4]), Convert.ToString(angkaboard[4, 1]), Convert.ToString(angkaboard[4, 2]), Convert.ToString(angkaboard[4, 3]), Convert.ToString(angkaboard[4, 4]));
                        theKey = Console.ReadKey().KeyChar;
                        if (theKey == 'a' || theKey == 'A' || theKey == 'd' || theKey == 'D')
                        {
                            wasd = false;
                        }
                    }
                }
                if (count2 == 12)
                {
                    while (wasd == true)
                    {
                        Console.Clear();
                        Board(Hscore, score, Convert.ToString(angkaboard[1, 1]), Convert.ToString(angkaboard[1, 2]), Convert.ToString(angkaboard[1, 3]), Convert.ToString(angkaboard[1, 4]), Convert.ToString(angkaboard[2, 1]), Convert.ToString(angkaboard[2, 2]), Convert.ToString(angkaboard[2, 3]), Convert.ToString(angkaboard[2, 4]), Convert.ToString(angkaboard[3, 1]), Convert.ToString(angkaboard[3, 2]), Convert.ToString(angkaboard[3, 3]), Convert.ToString(angkaboard[3, 4]), Convert.ToString(angkaboard[4, 1]), Convert.ToString(angkaboard[4, 2]), Convert.ToString(angkaboard[4, 3]), Convert.ToString(angkaboard[4, 4]));
                        theKey = Console.ReadKey().KeyChar;
                        if (theKey == 'w' || theKey == 'W' || theKey == 's' || theKey == 'S')
                        {
                            wasd = false;
                        }
                    }
                }
                if (count1 != 12 && count2 != 12)
                {
                    theKey = Console.ReadKey().KeyChar;
                }

                if (theKey == 'w' || theKey == 'W')
                {
                    for (int k = 1; k < 5; k++)
                    {
                        bisaNambah = false;
                        for (int i = 1; i < 4; i++)
                        {
                            for (int l = 1; l < 4; l++)
                            {
                                if (angkaboard[l, k] == 0)
                                {
                                    angkaboard[l, k] = angkaboard[l + 1, k];
                                    if (angkaboard[l + 1, k] != 0)
                                    {
                                        bisaGerak.Add(true);
                                    }
                                    angkaboard[l + 1, k] = 0;
                                }
                            }
                        }
                        if (angkaboard[1, k] == angkaboard[2, k] && angkaboard[1, k] != 0 && angkaboard[2, k] != 0)
                        {
                            bisaGerak.Add(true);
                            bisaNambah = true;
                            score = score + angkaboard[1, k] * 2;
                            angkaboard[1, k] = angkaboard[1, k] * 2;
                            angkaboard[2, k] = 0;
                        }
                        if (angkaboard[2, k] == angkaboard[3, k] && angkaboard[2, k] != 0 && angkaboard[3, k] != 0)
                        {
                            bisaGerak.Add(true);
                            bisaNambah = true;
                            score = score + angkaboard[2, k] * 2;
                            angkaboard[2, k] = angkaboard[2, k] * 2;
                            angkaboard[3, k] = 0;
                        }
                        if (angkaboard[3, k] == angkaboard[4, k] && angkaboard[3, k] != 0 && angkaboard[4, k] != 0)
                        {
                            bisaGerak.Add(true);
                            bisaNambah = true;
                            score = score + angkaboard[3, k] * 2;
                            angkaboard[3, k] = angkaboard[3, k] * 2;
                            angkaboard[4, k] = 0;
                        }
                        for (int i = 1; i < 4; i++)
                        {
                            for (int l = 1; l < 4; l++)
                            {
                                if (angkaboard[l, k] == 0)
                                {
                                    angkaboard[l, k] = angkaboard[l + 1, k];
                                    if (angkaboard[l + 1, k] != 0)
                                    {
                                        bisaGerak.Add(true);
                                    }
                                    angkaboard[l + 1, k] = 0;
                                }
                            }
                        }
                        if (bisaNambah == false)
                        {
                            if (angkaboard[1, k] == angkaboard[2, k] && angkaboard[1, k] != 0 && angkaboard[2, k] != 0)
                            {
                                bisaGerak.Add(true);
                                score = score + angkaboard[1, k] * 2;
                                angkaboard[1, k] = angkaboard[1, k] * 2;
                                angkaboard[2, k] = 0;
                            }
                            if (angkaboard[2, k] == angkaboard[3, k] && angkaboard[2, k] != 0 && angkaboard[3, k] != 0)
                            {
                                bisaGerak.Add(true);
                                score = score + angkaboard[2, k] * 2;
                                angkaboard[2, k] = angkaboard[2, k] * 2;
                                angkaboard[3, k] = 0;
                            }
                            if (angkaboard[3, k] == angkaboard[4, k] && angkaboard[3, k] != 0 && angkaboard[4, k] != 0)
                            {
                                bisaGerak.Add(true);
                                score = score + angkaboard[3, k] * 2;
                                angkaboard[3, k] = angkaboard[3, k] * 2;
                                angkaboard[4, k] = 0;
                            }
                        }
                    }
                }
                else if (theKey == 's' || theKey == 'S')
                {
                    for (int k = 1; k < 5; k++)
                    {
                        bisaNambah = false;
                        for (int i = 1; i < 4; i++)
                        {
                            for (int l = 4; l > 1; l--)
                            {
                                if (angkaboard[l, k] == 0)
                                {
                                    angkaboard[l, k] = angkaboard[l - 1, k];
                                    if (angkaboard[l - 1, k] != 0)
                                    {
                                        bisaGerak.Add(true);
                                    }
                                    angkaboard[l - 1, k] = 0;
                                }
                            }
                        }
                        if (angkaboard[4, k] == angkaboard[3, k] && angkaboard[4, k] != 0 && angkaboard[3, k] != 0)
                        {
                            bisaGerak.Add(true);
                            bisaNambah = true;
                            score = score + angkaboard[4, k] * 2;
                            angkaboard[4, k] = angkaboard[4, k] * 2;
                            angkaboard[3, k] = 0;
                        }
                        if (angkaboard[3, k] == angkaboard[2, k] && angkaboard[3, k] != 0 && angkaboard[2, k] != 0)
                        {
                            bisaGerak.Add(true);
                            bisaNambah = true;
                            score = score + angkaboard[3, k] * 2;
                            angkaboard[3, k] = angkaboard[3, k] * 2;
                            angkaboard[2, k] = 0;
                        }
                        if (angkaboard[2, k] == angkaboard[1, k] && angkaboard[2, k] != 0 && angkaboard[1, k] != 0)
                        {
                            bisaGerak.Add(true);
                            bisaNambah = true;
                            score = score + angkaboard[2, k] * 2;
                            angkaboard[2, k] = angkaboard[2, k] * 2;
                            angkaboard[1, k] = 0;
                        }
                        for (int i = 1; i < 4; i++)
                        {
                            for (int l = 4; l > 1; l--)
                            {
                                if (angkaboard[l, k] == 0)
                                {
                                    angkaboard[l, k] = angkaboard[l - 1, k];
                                    if (angkaboard[l - 1, k] != 0)
                                    {
                                        bisaGerak.Add(true);
                                    }
                                    angkaboard[l - 1, k] = 0;
                                }
                            }
                        }
                        if (bisaNambah == false)
                        {
                            if (angkaboard[4, k] == angkaboard[3, k] && angkaboard[4, k] != 0 && angkaboard[3, k] != 0)
                            {
                                bisaGerak.Add(true);
                                score = score + angkaboard[4, k] * 2;
                                angkaboard[4, k] = angkaboard[4, k] * 2;
                                angkaboard[3, k] = 0;
                            }
                            if (angkaboard[3, k] == angkaboard[2, k] && angkaboard[3, k] != 0 && angkaboard[2, k] != 0)
                            {
                                bisaGerak.Add(true);
                                score = score + angkaboard[3, k] * 2;
                                angkaboard[3, k] = angkaboard[3, k] * 2;
                                angkaboard[2, k] = 0;
                            }
                            if (angkaboard[2, k] == angkaboard[1, k] && angkaboard[2, k] != 0 && angkaboard[1, k] != 0)
                            {
                                bisaGerak.Add(true);
                                score = score + angkaboard[2, k] * 2;
                                angkaboard[2, k] = angkaboard[2, k] * 2;
                                angkaboard[1, k] = 0;
                            }
                        }
                    }
                }
                else if (theKey == 'a' || theKey == 'A')
                {
                    for (int k = 1; k < 5; k++)
                    {
                        bisaNambah = false;
                        for (int i = 1; i < 4; i++)
                        {
                            for (int l = 1; l < 4; l++)
                            {
                                if (angkaboard[k, l] == 0)
                                {
                                    angkaboard[k, l] = angkaboard[k, l + 1];
                                    if (angkaboard[k, l + 1] != 0)
                                    {
                                        bisaGerak.Add(true);
                                    }
                                    angkaboard[k, l + 1] = 0;
                                }
                            }
                        }
                        if (angkaboard[k, 1] == angkaboard[k, 2] && angkaboard[k, 1] != 0 && angkaboard[k, 2] != 0)
                        {
                            bisaGerak.Add(true);
                            bisaNambah = true;
                            score = score + angkaboard[k, 1] * 2;
                            angkaboard[k, 1] = angkaboard[k, 1] * 2;
                            angkaboard[k, 2] = 0;
                        }
                        if (angkaboard[k, 2] == angkaboard[k, 3] && angkaboard[k, 2] != 0 && angkaboard[k, 3] != 0)
                        {
                            bisaGerak.Add(true);
                            bisaNambah = true;
                            score = score + angkaboard[k, 2] * 2;
                            angkaboard[k, 2] = angkaboard[k, 2] * 2;
                            angkaboard[k, 3] = 0;
                        }
                        if (angkaboard[k, 3] == angkaboard[k, 4] && angkaboard[k, 3] != 0 && angkaboard[k, 4] != 0)
                        {
                            bisaGerak.Add(true);
                            bisaNambah = true;
                            score = score + angkaboard[k, 3] * 2;
                            angkaboard[k, 3] = angkaboard[k, 3] * 2;
                            angkaboard[k, 4] = 0;
                        }
                        for (int i = 1; i < 4; i++)
                        {
                            for (int l = 1; l < 4; l++)
                            {
                                if (angkaboard[k, l] == 0)
                                {
                                    angkaboard[k, l] = angkaboard[k, l + 1];
                                    if (angkaboard[k, l + 1] != 0)
                                    {
                                        bisaGerak.Add(true);
                                    }
                                    angkaboard[k, l + 1] = 0;
                                }
                            }
                        }
                        if (bisaNambah == false)
                        {
                            if (angkaboard[k, 1] == angkaboard[k, 2] && angkaboard[k, 1] != 0 && angkaboard[k, 2] != 0)
                            {
                                bisaGerak.Add(true);
                                score = score + angkaboard[k, 1] * 2;
                                angkaboard[k, 1] = angkaboard[k, 1] * 2;
                                angkaboard[k, 2] = 0;
                            }
                            if (angkaboard[k, 2] == angkaboard[k, 3] && angkaboard[k, 2] != 0 && angkaboard[k, 3] != 0)
                            {
                                bisaGerak.Add(true);
                                score = score + angkaboard[k, 2] * 2;
                                angkaboard[k, 2] = angkaboard[k, 2] * 2;
                                angkaboard[k, 3] = 0;
                            }
                            if (angkaboard[k, 3] == angkaboard[k, 4] && angkaboard[k, 3] != 0 && angkaboard[k, 4] != 0)
                            {
                                bisaGerak.Add(true);
                                score = score + angkaboard[k, 3] * 2;
                                angkaboard[k, 3] = angkaboard[k, 3] * 2;
                                angkaboard[k, 4] = 0;
                            }
                        }
                    }
                }
                else if (theKey == 'd' || theKey == 'D')
                {
                    for (int k = 1; k < 5; k++)
                    {
                        bisaNambah = false;
                        for (int i = 1; i < 4; i++)
                        {
                            for (int l = 4; l > 1; l--)
                            {
                                if (angkaboard[k, l] == 0)
                                {
                                    angkaboard[k, l] = angkaboard[k, l - 1];
                                    if (angkaboard[k, l - 1] != 0)
                                    {
                                        bisaGerak.Add(true);
                                    }
                                    angkaboard[k, l - 1] = 0;
                                }
                            }
                        }
                        if (angkaboard[k, 4] == angkaboard[k, 3] && angkaboard[k, 4] != 0 && angkaboard[k, 3] != 0)
                        {
                            bisaGerak.Add(true);
                            bisaNambah = true;
                            score = score + angkaboard[k, 4] * 2;
                            angkaboard[k, 4] = angkaboard[k, 4] * 2;
                            angkaboard[k, 3] = 0;
                        }
                        if (angkaboard[k, 3] == angkaboard[k, 2] && angkaboard[k, 3] != 0 && angkaboard[k, 2] != 0)
                        {
                            bisaGerak.Add(true);
                            bisaNambah = true;
                            score = score + angkaboard[k, 3] * 2;
                            angkaboard[k, 3] = angkaboard[k, 3] * 2;
                            angkaboard[k, 2] = 0;
                        }
                        if (angkaboard[k, 2] == angkaboard[k, 1] && angkaboard[k, 2] != 0 && angkaboard[k, 1] != 0)
                        {
                            bisaGerak.Add(true);
                            bisaNambah = true;
                            score = score + angkaboard[k, 2] * 2;
                            angkaboard[k, 2] = angkaboard[k, 2] * 2;
                            angkaboard[k, 1] = 0;
                        }
                        for (int i = 1; i < 4; i++)
                        {
                            for (int l = 4; l > 1; l--)
                            {
                                if (angkaboard[k, l] == 0)
                                {
                                    angkaboard[k, l] = angkaboard[k, l - 1];
                                    if (angkaboard[k, l - 1] != 0)
                                    {
                                        bisaGerak.Add(true);
                                    }
                                    angkaboard[k, l - 1] = 0;
                                }
                            }
                        }
                        if (bisaNambah == false)
                        {
                            if (angkaboard[k, 4] == angkaboard[k, 3] && angkaboard[k, 4] != 0 && angkaboard[k, 3] != 0)
                            {
                                bisaGerak.Add(true);
                                score = score + angkaboard[k, 4] * 2;
                                angkaboard[k, 4] = angkaboard[k, 4] * 2;
                                angkaboard[k, 3] = 0;
                            }
                            if (angkaboard[k, 3] == angkaboard[k, 2] && angkaboard[k, 3] != 0 && angkaboard[k, 2] != 0)
                            {
                                bisaGerak.Add(true);
                                score = score + angkaboard[k, 3] * 2;
                                angkaboard[k, 3] = angkaboard[k, 3] * 2;
                                angkaboard[k, 2] = 0;
                            }
                            if (angkaboard[k, 2] == angkaboard[k, 1] && angkaboard[k, 2] != 0 && angkaboard[k, 1] != 0)
                            {
                                bisaGerak.Add(true);
                                score = score + angkaboard[k, 2] * 2;
                                angkaboard[k, 2] = angkaboard[k, 2] * 2;
                                angkaboard[k, 1] = 0;
                            }
                        }
                    }
                }
                else if (theKey == 'n' || theKey == 'N')
                {
                    for (int i = 1; i <= 4; i++)
                    {
                        for (int j = 1; j <= 4; j++)
                        {
                            angkaboard[i, j] = 0;
                        }
                    }
                    score = 0;
                    counter = 1;
                    tempatRandomSama = true;
                    angka1 = rnd.Next(1, 5);
                    angka2 = rnd.Next(1, 5);
                    perCent1 = rnd.Next(0, 200);
                    if (perCent1 <= 53)               
                    {
                        angkaboard[angka1, angka2] = 4;
                    }
                    if (perCent1 >= 54 || perCent1 <= 200)     
                    {
                        angkaboard[angka1, angka2] = 2;
                    }
                    while (tempatRandomSama == true)
                    {
                        angka3 = rnd.Next(1, 5);
                        angka4 = rnd.Next(1, 5);
                        if (angka1 != angka3 || angka2 != angka4)
                        {
                            tempatRandomSama = false;
                        }
                    }
                    perCent2 = rnd.Next(0, 200);
                    if (perCent2 <= 53)               
                    {
                        angkaboard[angka3, angka4] = 4;
                    }
                    if (perCent2 >= 54 || perCent2 <= 200)     
                    {
                        angkaboard[angka3, angka4] = 2;
                    }
                }
                else if (theKey == 'e' || theKey == 'E')
                {
                    loop = true;
                }
                else
                {
                    inputSalah = true;
                    Console.Clear();
                }

                if (inputSalah == false && bisaGerak.Count > 0)
                {
                    while (kosong == false)
                    {
                        perCent1 = rnd.Next(0, 200);
                        angka1 = rnd.Next(1, 5);
                        angka2 = rnd.Next(1, 5);
                        if (angkaboard[angka1, angka2] == 0) // cek lokasi kotak yang kosong
                        {
                            kosong = true;
                            if (perCent1 <= 53)               
                            {
                                angkaboard[angka1, angka2] = 4;
                            }
                            else if (perCent1 >= 54 || perCent1 <= 200)     
                            {
                                angkaboard[angka1, angka2] = 2;
                            }
                        }
                    }
                }
                if (counter == 0)
                {
                    Hscore = score;
                }
                else
                {
                    if (score >= Hscore)
                    {
                        counter = 0;
                    }
                }
                Console.Clear();
                Board(Hscore, score, Convert.ToString(angkaboard[1, 1]), Convert.ToString(angkaboard[1, 2]), Convert.ToString(angkaboard[1, 3]), Convert.ToString(angkaboard[1, 4]), Convert.ToString(angkaboard[2, 1]), Convert.ToString(angkaboard[2, 2]), Convert.ToString(angkaboard[2, 3]), Convert.ToString(angkaboard[2, 4]), Convert.ToString(angkaboard[3, 1]), Convert.ToString(angkaboard[3, 2]), Convert.ToString(angkaboard[3, 3]), Convert.ToString(angkaboard[3, 4]), Convert.ToString(angkaboard[4, 1]), Convert.ToString(angkaboard[4, 2]), Convert.ToString(angkaboard[4, 3]), Convert.ToString(angkaboard[4, 4]));

                ceknol = 0;
                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j <= 4; j++)
                    {
                        if (angkaboard[i, j] != 0)
                        {
                            ceknol++;
                        }
                    }
                }
                int cekkalah = 0;
                if (ceknol == 16)
                {
                    for (int i = 1; i <= 4; i++)
                    {
                        for (int j = 1; j <= 4; j++)
                        {
                            if (i != 4) // untuk cek s / keatas
                            {
                                if (angkaboard[i, j] == angkaboard[i + 1, j])
                                {
                                    cekkalah = 1;
                                }
                            }
                            if (i != 1) // untuk cek w / kebawah
                            {
                                if (angkaboard[i, j] == angkaboard[i - 1, j])
                                {
                                    cekkalah = 1;
                                }
                            }
                            if (j != 4) // untuk d kekanan
                            {
                                if (angkaboard[i, j] == angkaboard[i, j + 1])
                                {
                                    cekkalah = 1;
                                }
                            }
                            if (j != 1) // untuk a kekiri
                            {
                                if (angkaboard[i, j] == angkaboard[i, j - 1])
                                {
                                    cekkalah = 1;
                                }
                            }
                        }
                    }
                    bool newgame = true;
                    if (cekkalah == 1)
                    {
                        loop = false;
                    }
                    else
                    {
                        while (newgame == true)
                        {
                            Console.Clear();
                            Board(Hscore, score, Convert.ToString(angkaboard[1, 1]), Convert.ToString(angkaboard[1, 2]), Convert.ToString(angkaboard[1, 3]), Convert.ToString(angkaboard[1, 4]), Convert.ToString(angkaboard[2, 1]), Convert.ToString(angkaboard[2, 2]), Convert.ToString(angkaboard[2, 3]), Convert.ToString(angkaboard[2, 4]), Convert.ToString(angkaboard[3, 1]), Convert.ToString(angkaboard[3, 2]), Convert.ToString(angkaboard[3, 3]), Convert.ToString(angkaboard[3, 4]), Convert.ToString(angkaboard[4, 1]), Convert.ToString(angkaboard[4, 2]), Convert.ToString(angkaboard[4, 3]), Convert.ToString(angkaboard[4, 4]));
                            Console.WriteLine(" GAME OVER!!");
                            game = Console.ReadKey().KeyChar;
                            if (game == 'n' || game == 'N')
                            {
                                for (int i = 1; i <= 4; i++)
                                {
                                    for (int j = 1; j <= 4; j++)
                                    {
                                        angkaboard[i, j] = 0;
                                    }
                                }
                                score = 0;
                                counter = 1;
                                tempatRandomSama = true;
                                angka1 = rnd.Next(1, 5);
                                angka2 = rnd.Next(1, 5);
                                perCent1 = rnd.Next(0, 200);
                                if (perCent1 <= 53)               
                                {
                                    angkaboard[angka1, angka2] = 4;
                                }
                                if (perCent1 >= 54 || perCent1 <= 200)     
                                {
                                    angkaboard[angka1, angka2] = 2;
                                }
                                while (tempatRandomSama == true)
                                {
                                    angka3 = rnd.Next(1, 5);
                                    angka4 = rnd.Next(1, 5);
                                    if (angka1 != angka3 || angka2 != angka4)
                                    {
                                        tempatRandomSama = false;
                                    }
                                }
                                perCent2 = rnd.Next(0, 200);
                                if (perCent2 <= 53)               
                                {
                                    angkaboard[angka3, angka4] = 4;
                                }
                                if (perCent2 >= 54 || perCent2 <= 200)     
                                {
                                    angkaboard[angka3, angka4] = 2;
                                }
                                Console.Clear();
                                Board(Hscore, score, Convert.ToString(angkaboard[1, 1]), Convert.ToString(angkaboard[1, 2]), Convert.ToString(angkaboard[1, 3]), Convert.ToString(angkaboard[1, 4]), Convert.ToString(angkaboard[2, 1]), Convert.ToString(angkaboard[2, 2]), Convert.ToString(angkaboard[2, 3]), Convert.ToString(angkaboard[2, 4]), Convert.ToString(angkaboard[3, 1]), Convert.ToString(angkaboard[3, 2]), Convert.ToString(angkaboard[3, 3]), Convert.ToString(angkaboard[3, 4]), Convert.ToString(angkaboard[4, 1]), Convert.ToString(angkaboard[4, 2]), Convert.ToString(angkaboard[4, 3]), Convert.ToString(angkaboard[4, 4]));
                                newgame = false;
                            }
                            else if (game == 'e' || game == 'E')
                            {
                                newgame = false;
                                loop = true;
                            }
                        }
                    }
                }
            }
        }


        //method untuk boardnya , yang ada slot 1 - 16
        static void Board(int highscore, int score, string one, string two, string three, string four, string five, string six, string seven, string eight, string nine, string ten, string eleven, string twelve, string thirteen, string fourteen, string fiveteen, string sixteen)
        {
            string[] angka = new string[] { one, two, three, four, five, six, seven, eight, nine, ten, eleven, twelve, thirteen, fourteen, fiveteen, sixteen };
            for (int i = 0; i < angka.Length; i++)
            {
                if (angka[i] == "0")
                {
                    angka[i] = "";
                }
            }
            Console.WriteLine("  [N] New Game\t\t\t HIGH SCORE : " + highscore);
            Console.WriteLine("  [E] Exit\t\t\t SCORE      : " + score);
            Console.WriteLine(" ----------------------------------------------------------------");
            Console.WriteLine(" |\t\t|\t\t|\t\t|\t\t|");
            Console.WriteLine(" |\t{0}\t|\t{1}\t|\t{2}\t|\t{3}\t|", angka[0], angka[1], angka[2], angka[3]);
            Console.WriteLine(" |\t\t|\t\t|\t\t|\t\t|");
            Console.WriteLine(" |--------------+---------------+---------------+---------------|");
            Console.WriteLine(" |\t\t|\t\t|\t\t|\t\t|");
            Console.WriteLine(" |\t{0}\t|\t{1}\t|\t{2}\t|\t{3}\t|", angka[4], angka[5], angka[6], angka[7]);
            Console.WriteLine(" |\t\t|\t\t|\t\t|\t\t|");
            Console.WriteLine(" |--------------+---------------+---------------+---------------|");
            Console.WriteLine(" |\t\t|\t\t|\t\t|\t\t|");
            Console.WriteLine(" |\t{0}\t|\t{1}\t|\t{2}\t|\t{3}\t|", angka[8], angka[9], angka[10], angka[11]);
            Console.WriteLine(" |\t\t|\t\t|\t\t|\t\t|");
            Console.WriteLine(" |--------------+---------------+---------------+---------------|");
            Console.WriteLine(" |\t\t|\t\t|\t\t|\t\t|");
            Console.WriteLine(" |\t{0}\t|\t{1}\t|\t{2}\t|\t{3}\t|", angka[12], angka[13], angka[14], angka[15]);
            Console.WriteLine(" |\t\t|\t\t|\t\t|\t\t|");
            Console.WriteLine(" ----------------------------------------------------------------");
        }
    }
}


