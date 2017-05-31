using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Text.RegularExpressions;


namespace Memory
{
    class Program
    {
        static string[] zeichen = { "a", "b", "c", "d", "e", "f", "g", "h" };
        static List<int> besezt  = new List<int>();
        static string[] zuordnung1 = { "0","0","0","0","0"};
        static string[] zuordnung2 = { "0", "0", "0", "0", "0" };
        static string[] zuordnung3 = { "0", "0", "0", "0", "0" };
        static string[] zuordnung4 = { "0", "0", "0", "0", "0" };

        static string[] gewaehlt1 = { "?", "?", "?", "?", "?", };
        static string[] gewaehlt2 = { "?", "?", "?", "?", "?", };
        static string[] gewaehlt3 = { "?", "?", "?", "?", "?", };
        static string[] gewaehlt4 = { "?", "?", "?", "?", "?", };

        static bool wahr = true;
        static int nmb = 0;
        static int[] test = {'0', '0','0','0' };
        static int finisch;
        static int temp;
        static int temp2;

       static int tmp1 = 0;
       static int tmp2=0;
        static int tmp3=0;
       static int tmp4=0;
        static void Main(string[] args)
        {
            begin:
            start();
            memory();
            abfrage();
            Console.Clear();
          /*  Console.WriteLine("Möchtest du noch einmal spielen <j|n>");
            if (Console.ReadLine() == "j")
            { goto begin; }
            else
            { Environment.Exit(0); } */
        }

        static void start()
        {
            Console.WriteLine("Wilkommen beim Memory !");
            Thread.Sleep(1000);
            Console.Clear();
        }

        static void memory()
        {
           
             Random zahl1 = new Random();
            /* test[1] = zahl1.Next(1,8);
             test[2] = zahl1.Next(1,8);
             test[3] = zahl1.Next(1,8);
             test[4] = zahl1.Next(1,8);
             test[5] = zahl1.Next(1, 8);
             test[6] = zahl1.Next(1, 8);
             test[7] = zahl1.Next(1, 8);
             test[8] = zahl1.Next(1, 8); 
             
            finisch = 0;
            wahr = true;

            for (int a = 0; a < 5; a++)
            {
                gewaehlt1[a] = "?";
                gewaehlt2[a] = "?";
                gewaehlt3[a] = "?";
                gewaehlt4[a] = "?";

                zuordnung1[a] = "0";
                zuordnung2[a] = "0";
                zuordnung3[a] = "0";
                zuordnung4[a] = "0";
            }
            */

            for (int i = 1; i <= 8; i++)
            {
               
                #region if 1
                if (i == 1)
                    {
                   // Console.WriteLine("for = 1");
                   
                    nmb = 0;
                        while (nmb != 2)
                        { 
                            temp = zahl1.Next(1,5);
                            temp2 = zahl1.Next(1,5);
                          //  Console.WriteLine(temp + "y");
                            //Console.WriteLine(temp2 + "x");
                            wahr = true;
                            //Console.WriteLine("{0} nmb", nmb);
                        if (temp == 1 && wahr)
                            {
                               // Console.WriteLine("1 reihe a");
                                if (temp2 == 1 && zuordnung1[1] == "0") { zuordnung1[1] = zeichen[0];nmb = nmb + 1; wahr = false; }
                                else if (temp2 == 2 && zuordnung1[2] == "0") { zuordnung1[2] = zeichen[0]; nmb = nmb + 1; wahr = false;  }
                                else if (temp2 == 3 && zuordnung1[3] == "0") { zuordnung1[3] = zeichen[0]; nmb = nmb + 1; wahr = false; }
                                else if (temp2 == 4 && zuordnung1[4] == "0") { zuordnung1[4] = zeichen[0]; nmb = nmb + 1; wahr = false; }
                                
                            }

                            else if (temp == 2 && wahr)
                            {
                              //  Console.WriteLine("2 reihe a");

                                if (temp2 == 1 && zuordnung2[1] == "0") { zuordnung2[1] = zeichen[0]; nmb = nmb + 1; wahr = false; }
                                else if (temp2 == 2 && zuordnung2[2] == "0") { zuordnung2[2] = zeichen[0]; nmb = nmb + 1; wahr = false; }
                                else if (temp2 == 3 && zuordnung2[3] == "0") { zuordnung2[3] = zeichen[0]; nmb = nmb + 1; wahr = false; }
                                else if (temp2 == 4 && zuordnung2[4] == "0") { zuordnung2[4] = zeichen[0]; nmb = nmb + 1; wahr = false; }
                                
                            }

                            else if (temp == 3 && wahr)
                            {
                              //  Console.WriteLine("3 Reiehe a");
                                if (temp2 == 1 && zuordnung3[1] == "0") { zuordnung3[1] = zeichen[0]; nmb = nmb + 1; wahr = false; }
                                else if (temp2 == 2 && zuordnung3[2] == "0") { zuordnung3[2] = zeichen[0]; nmb = nmb + 1; wahr = false; }
                                else if (temp2 == 3 && zuordnung3[3] == "0") { zuordnung3[3] = zeichen[0]; nmb = nmb + 1; wahr = false; }
                                else if (temp2 == 4 && zuordnung3[4] == "0") { zuordnung3[4] = zeichen[0]; nmb = nmb + 1; wahr = false; }
                               
                            }

                            else if (temp == 4 && wahr)
                            {
                               // Console.WriteLine("4 Reihe a");
                                if (temp2 == 1 && zuordnung4[1] == "0") { zuordnung4[1] = zeichen[0]; nmb = nmb + 1; wahr = false; }
                                else if (temp2 == 2 && zuordnung4[2] == "0") { zuordnung4[2] = zeichen[0]; nmb = nmb + 1; wahr = false; }
                                else if (temp2 == 3 && zuordnung4[3] == "0") { zuordnung4[3] = zeichen[0]; nmb = nmb + 1; wahr = false; }
                                else if (temp2 == 4 && zuordnung4[4] == "0") { zuordnung4[4] = zeichen[0]; nmb = nmb + 1; wahr = false; }
                                
                            }
                      
                            
                        }


                   /* Console.WriteLine("{0} nmb", nmb);
                    Console.Write("\n {0} {1} {2} {3} ", zuordnung1[1], zuordnung1[2], zuordnung1[3], zuordnung1[4]);
                    Console.Write("\n {0} {1} {2} {3} ", zuordnung2[1], zuordnung2[2], zuordnung2[3], zuordnung2[4]);
                    Console.Write("\n {0} {1} {2} {3} ", zuordnung3[1], zuordnung3[2], zuordnung3[3], zuordnung3[4]);
                    Console.Write("\n {0} {1} {2} {3} ", zuordnung4[1], zuordnung4[2], zuordnung4[3], zuordnung4[4]);
                    Console.Read();*/
                }
                #endregion
                #region if 2
                else if (i == 2)
                    {
                  //  Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                  //  Console.WriteLine("for = 2");
                   //Console.ReadLine();
                    nmb = 0;
                    while (nmb != 2)
                        {
                            temp = zahl1.Next(1, 5);
                           temp2 = zahl1.Next(1, 5);
                            
                        //Console.WriteLine(temp + "y");
                       // Console.WriteLine(temp2 + "x");
                        wahr = true;
                      //  Console.WriteLine("{0} nmb", nmb);
                        if (temp == 1 && wahr)
                            {
                          //  Console.WriteLine("1 reihe b");
                            if (temp2 == 1 && zuordnung1[1] == "0") { zuordnung1[1] = zeichen[1]; nmb = nmb + 1; wahr = false; }
                                else if (temp2 == 2 && zuordnung1[2] == "0") { zuordnung1[2] = zeichen[1]; nmb = nmb + 1; wahr = false; }
                                else if (temp2 == 3 && zuordnung1[3] == "0") { zuordnung1[3] = zeichen[1]; nmb = nmb + 1; wahr = false; }
                                else if (temp2 == 4 && zuordnung1[4] == "0") { zuordnung1[4] = zeichen[1]; nmb = nmb + 1; wahr = false; }

                            }


                            else if (temp == 2 && wahr)
                            {
                          //  Console.WriteLine("2 reihe b");

                            if (temp2 == 1 && zuordnung2[1] == "0") { zuordnung2[1] = zeichen[1]; nmb = nmb + 1; wahr = false; }
                                else if (temp2 == 2 && zuordnung2[2] == "0") { zuordnung2[2] = zeichen[1]; nmb = nmb + 1; wahr = false; }
                                else if (temp2 == 3 && zuordnung2[3] == "0") { zuordnung2[3] = zeichen[1]; nmb = nmb + 1; wahr = false; }
                                else if (temp2 == 4 && zuordnung2[4] == "0") { zuordnung2[4] = zeichen[1]; nmb = nmb + 1; wahr = false; }

                            }

                            else if (temp == 3 && wahr)
                            {
                           // Console.WriteLine("3 reihe b");
                            if (temp2 == 1 && zuordnung3[1] == "0") { zuordnung3[1] = zeichen[1]; nmb = nmb + 1; wahr = false; }
                                else if (temp2 == 2 && zuordnung3[2] == "0") { zuordnung3[2] = zeichen[1]; nmb = nmb + 1; wahr = false; }
                                else if (temp2 == 3 && zuordnung3[3] == "0") { zuordnung3[3] = zeichen[1]; nmb = nmb + 1; wahr = false; }
                                else if (temp2 == 4 && zuordnung3[4] == "0") { zuordnung3[4] = zeichen[1]; nmb = nmb + 1; wahr = false; }

                            }

                            else if (temp == 4 && wahr)
                            {
                            //Console.WriteLine("4 reihe b");
                            if (temp2 == 1 && zuordnung4[1] == "0") { zuordnung4[1] = zeichen[1]; nmb = nmb + 1; wahr = false; }
                                else if (temp2 == 2 && zuordnung4[2] == "0") { zuordnung4[2] = zeichen[1]; nmb = nmb + 1; wahr = false; }
                                else if (temp2 == 3 && zuordnung4[3] == "0") { zuordnung4[3] = zeichen[1]; nmb = nmb + 1; wahr = false; }
                                else if (temp2 == 4 && zuordnung4[4] == "0") { zuordnung4[4] = zeichen[1]; nmb = nmb + 1; wahr = false; }

                            }
                      //  Console.WriteLine("{0} nmb", nmb);

                    }

                  /*  Console.WriteLine("{0} nmb", nmb);
                    Console.Write("\n {0} {1} {2} {3} ", zuordnung1[1], zuordnung1[2], zuordnung1[3], zuordnung1[4]);
                    Console.Write("\n {0} {1} {2} {3} ", zuordnung2[1], zuordnung2[2], zuordnung2[3], zuordnung2[4]);
                    Console.Write("\n {0} {1} {2} {3} ", zuordnung3[1], zuordnung3[2], zuordnung3[3], zuordnung3[4]);
                    Console.Write("\n {0} {1} {2} {3} ", zuordnung4[1], zuordnung4[2], zuordnung4[3], zuordnung4[4]);
                    Console.Read(); */

                }
                #endregion
                #region if 3
                else if (i == 3)
                {
                    //  Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                    //  Console.WriteLine("for = 2");
                    //Console.ReadLine();
                    nmb = 0;
                    while (nmb != 2)
                    {
                        temp = zahl1.Next(1, 5);
                        temp2 = zahl1.Next(1, 5);

                        //Console.WriteLine(temp + "y");
                        // Console.WriteLine(temp2 + "x");
                        wahr = true;
                        //  Console.WriteLine("{0} nmb", nmb);
                        if (temp == 1 && wahr)
                        {
                            //  Console.WriteLine("1 reihe b");
                            if (temp2 == 1 && zuordnung1[1] == "0") { zuordnung1[1] = zeichen[2]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 2 && zuordnung1[2] == "0") { zuordnung1[2] = zeichen[2]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 3 && zuordnung1[3] == "0") { zuordnung1[3] = zeichen[2]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 4 && zuordnung1[4] == "0") { zuordnung1[4] = zeichen[2]; nmb = nmb + 1; wahr = false; }

                        }


                        else if (temp == 2 && wahr)
                        {
                            //  Console.WriteLine("2 reihe b");

                            if (temp2 == 1 && zuordnung2[1] == "0") { zuordnung2[1] = zeichen[2]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 2 && zuordnung2[2] == "0") { zuordnung2[2] = zeichen[2]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 3 && zuordnung2[3] == "0") { zuordnung2[3] = zeichen[2]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 4 && zuordnung2[4] == "0") { zuordnung2[4] = zeichen[2]; nmb = nmb + 1; wahr = false; }

                        }

                        else if (temp == 3 && wahr)
                        {
                            // Console.WriteLine("3 reihe b");
                            if (temp2 == 1 && zuordnung3[1] == "0") { zuordnung3[1] = zeichen[2]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 2 && zuordnung3[2] == "0") { zuordnung3[2] = zeichen[2]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 3 && zuordnung3[3] == "0") { zuordnung3[3] = zeichen[2]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 4 && zuordnung3[4] == "0") { zuordnung3[4] = zeichen[2]; nmb = nmb + 1; wahr = false; }

                        }

                        else if (temp == 4 && wahr)
                        {
                            //Console.WriteLine("4 reihe b");
                            if (temp2 == 1 && zuordnung4[1] == "0") { zuordnung4[1] = zeichen[2]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 2 && zuordnung4[2] == "0") { zuordnung4[2] = zeichen[2]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 3 && zuordnung4[3] == "0") { zuordnung4[3] = zeichen[2]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 4 && zuordnung4[4] == "0") { zuordnung4[4] = zeichen[2]; nmb = nmb + 1; wahr = false; }

                        }
                        //  Console.WriteLine("{0} nmb", nmb);

                    }

    

                }
                #endregion
                #region if 4
                else if (i == 4)
                {
                    //  Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                    //  Console.WriteLine("for = 2");
                    //Console.ReadLine();
                    nmb = 0;
                    while (nmb != 2)
                    {
                        temp = zahl1.Next(1, 5);
                        temp2 = zahl1.Next(1, 5);

                        //Console.WriteLine(temp + "y");
                        // Console.WriteLine(temp2 + "x");
                        wahr = true;
                        //  Console.WriteLine("{0} nmb", nmb);
                        if (temp == 1 && wahr)
                        {
                            //  Console.WriteLine("1 reihe b");
                            if (temp2 == 1 && zuordnung1[1] == "0") { zuordnung1[1] = zeichen[3]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 2 && zuordnung1[2] == "0") { zuordnung1[2] = zeichen[3]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 3 && zuordnung1[3] == "0") { zuordnung1[3] = zeichen[3]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 4 && zuordnung1[4] == "0") { zuordnung1[4] = zeichen[3]; nmb = nmb + 1; wahr = false; }

                        }


                        else if (temp == 2 && wahr)
                        {
                            //  Console.WriteLine("2 reihe b");

                            if (temp2 == 1 && zuordnung2[1] == "0") { zuordnung2[1] = zeichen[3]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 2 && zuordnung2[2] == "0") { zuordnung2[2] = zeichen[3]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 3 && zuordnung2[3] == "0") { zuordnung2[3] = zeichen[3]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 4 && zuordnung2[4] == "0") { zuordnung2[4] = zeichen[3]; nmb = nmb + 1; wahr = false; }

                        }

                        else if (temp == 3 && wahr)
                        {
                            // Console.WriteLine("3 reihe b");
                            if (temp2 == 1 && zuordnung3[1] == "0") { zuordnung3[1] = zeichen[3]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 2 && zuordnung3[2] == "0") { zuordnung3[2] = zeichen[3]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 3 && zuordnung3[3] == "0") { zuordnung3[3] = zeichen[3]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 4 && zuordnung3[4] == "0") { zuordnung3[4] = zeichen[3]; nmb = nmb + 1; wahr = false; }

                        }

                        else if (temp == 4 && wahr)
                        {
                            //Console.WriteLine("4 reihe b");
                            if (temp2 == 1 && zuordnung4[1] == "0") { zuordnung4[1] = zeichen[3]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 2 && zuordnung4[2] == "0") { zuordnung4[2] = zeichen[3]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 3 && zuordnung4[3] == "0") { zuordnung4[3] = zeichen[3]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 4 && zuordnung4[4] == "0") { zuordnung4[4] = zeichen[3]; nmb = nmb + 1; wahr = false; }

                        }
                        //  Console.WriteLine("{0} nmb", nmb);

                    }



                }
                #endregion
                #region if 5
                else if (i == 5)
                {
                    //  Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                    //  Console.WriteLine("for = 2");
                    //Console.ReadLine();
                    nmb = 0;
                    while (nmb != 2)
                    {
                        temp = zahl1.Next(1, 5);
                        temp2 = zahl1.Next(1, 5);

                        //Console.WriteLine(temp + "y");
                        // Console.WriteLine(temp2 + "x");
                        wahr = true;
                        //  Console.WriteLine("{0} nmb", nmb);
                        if (temp == 1 && wahr)
                        {
                            //  Console.WriteLine("1 reihe b");
                            if (temp2 == 1 && zuordnung1[1] == "0") { zuordnung1[1] = zeichen[4]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 2 && zuordnung1[2] == "0") { zuordnung1[2] = zeichen[4]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 3 && zuordnung1[3] == "0") { zuordnung1[3] = zeichen[4]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 4 && zuordnung1[4] == "0") { zuordnung1[4] = zeichen[4]; nmb = nmb + 1; wahr = false; }

                        }


                        else if (temp == 2 && wahr)
                        {
                            //  Console.WriteLine("2 reihe b");

                            if (temp2 == 1 && zuordnung2[1] == "0") { zuordnung2[1] = zeichen[4]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 2 && zuordnung2[2] == "0") { zuordnung2[2] = zeichen[4]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 3 && zuordnung2[3] == "0") { zuordnung2[3] = zeichen[4]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 4 && zuordnung2[4] == "0") { zuordnung2[4] = zeichen[4]; nmb = nmb + 1; wahr = false; }

                        }

                        else if (temp == 3 && wahr)
                        {
                            // Console.WriteLine("3 reihe b");
                            if (temp2 == 1 && zuordnung3[1] == "0") { zuordnung3[1] = zeichen[4]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 2 && zuordnung3[2] == "0") { zuordnung3[2] = zeichen[4]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 3 && zuordnung3[3] == "0") { zuordnung3[3] = zeichen[4]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 4 && zuordnung3[4] == "0") { zuordnung3[4] = zeichen[4]; nmb = nmb + 1; wahr = false; }

                        }

                        else if (temp == 4 && wahr)
                        {
                            //Console.WriteLine("4 reihe b");
                            if (temp2 == 1 && zuordnung4[1] == "0") { zuordnung4[1] = zeichen[4]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 2 && zuordnung4[2] == "0") { zuordnung4[2] = zeichen[4]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 3 && zuordnung4[3] == "0") { zuordnung4[3] = zeichen[4]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 4 && zuordnung4[4] == "0") { zuordnung4[4] = zeichen[4]; nmb = nmb + 1; wahr = false; }

                        }
                        //  Console.WriteLine("{0} nmb", nmb);

                    }



                }
                #endregion
                #region if 6
                else if (i == 6)
                {
                    //  Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                    //  Console.WriteLine("for = 2");
                    //Console.ReadLine();
                    nmb = 0;
                    while (nmb != 2)
                    {
                        temp = zahl1.Next(1, 5);
                        temp2 = zahl1.Next(1, 5);

                        //Console.WriteLine(temp + "y");
                        // Console.WriteLine(temp2 + "x");
                        wahr = true;
                        //  Console.WriteLine("{0} nmb", nmb);
                        if (temp == 1 && wahr)
                        {
                            //  Console.WriteLine("1 reihe b");
                            if (temp2 == 1 && zuordnung1[1] == "0") { zuordnung1[1] = zeichen[5]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 2 && zuordnung1[2] == "0") { zuordnung1[2] = zeichen[5]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 3 && zuordnung1[3] == "0") { zuordnung1[3] = zeichen[5]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 4 && zuordnung1[4] == "0") { zuordnung1[4] = zeichen[5]; nmb = nmb + 1; wahr = false; }

                        }


                        else if (temp == 2 && wahr)
                        {
                            //  Console.WriteLine("2 reihe b");

                            if (temp2 == 1 && zuordnung2[1] == "0") { zuordnung2[1] = zeichen[5]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 2 && zuordnung2[2] == "0") { zuordnung2[2] = zeichen[5]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 3 && zuordnung2[3] == "0") { zuordnung2[3] = zeichen[5]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 4 && zuordnung2[4] == "0") { zuordnung2[4] = zeichen[5]; nmb = nmb + 1; wahr = false; }

                        }

                        else if (temp == 3 && wahr)
                        {
                            // Console.WriteLine("3 reihe b");
                            if (temp2 == 1 && zuordnung3[1] == "0") { zuordnung3[1] = zeichen[5]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 2 && zuordnung3[2] == "0") { zuordnung3[2] = zeichen[5]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 3 && zuordnung3[3] == "0") { zuordnung3[3] = zeichen[5]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 4 && zuordnung3[4] == "0") { zuordnung3[4] = zeichen[5]; nmb = nmb + 1; wahr = false; }

                        }

                        else if (temp == 4 && wahr)
                        {
                            //Console.WriteLine("4 reihe b");
                            if (temp2 == 1 && zuordnung4[1] == "0") { zuordnung4[1] = zeichen[5]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 2 && zuordnung4[2] == "0") { zuordnung4[2] = zeichen[5]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 3 && zuordnung4[3] == "0") { zuordnung4[3] = zeichen[5]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 4 && zuordnung4[4] == "0") { zuordnung4[4] = zeichen[5]; nmb = nmb + 1; wahr = false; }

                        }
                        //  Console.WriteLine("{0} nmb", nmb);

                    }



                }
                #endregion
                #region if 7
                else if (i == 7)
                {
                    //  Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                    //  Console.WriteLine("for = 2");
                    //Console.ReadLine();
                    nmb = 0;
                    while (nmb != 2)
                    {
                        temp = zahl1.Next(1, 5);
                        temp2 = zahl1.Next(1, 5);

                        //Console.WriteLine(temp + "y");
                        // Console.WriteLine(temp2 + "x");
                        wahr = true;
                        //  Console.WriteLine("{0} nmb", nmb);
                        if (temp == 1 && wahr)
                        {
                            //  Console.WriteLine("1 reihe b");
                            if (temp2 == 1 && zuordnung1[1] == "0") { zuordnung1[1] = zeichen[6]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 2 && zuordnung1[2] == "0") { zuordnung1[2] = zeichen[6]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 3 && zuordnung1[3] == "0") { zuordnung1[3] = zeichen[6]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 4 && zuordnung1[4] == "0") { zuordnung1[4] = zeichen[6]; nmb = nmb + 1; wahr = false; }

                        }


                        else if (temp == 2 && wahr)
                        {
                            //  Console.WriteLine("2 reihe b");

                            if (temp2 == 1 && zuordnung2[1] == "0") { zuordnung2[1] = zeichen[6]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 2 && zuordnung2[2] == "0") { zuordnung2[2] = zeichen[6]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 3 && zuordnung2[3] == "0") { zuordnung2[3] = zeichen[6]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 4 && zuordnung2[4] == "0") { zuordnung2[4] = zeichen[6]; nmb = nmb + 1; wahr = false; }

                        }

                        else if (temp == 3 && wahr)
                        {
                            // Console.WriteLine("3 reihe b");
                            if (temp2 == 1 && zuordnung3[1] == "0") { zuordnung3[1] = zeichen[6]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 2 && zuordnung3[2] == "0") { zuordnung3[2] = zeichen[6]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 3 && zuordnung3[3] == "0") { zuordnung3[3] = zeichen[6]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 4 && zuordnung3[4] == "0") { zuordnung3[4] = zeichen[6]; nmb = nmb + 1; wahr = false; }

                        }

                        else if (temp == 4 && wahr)
                        {
                            //Console.WriteLine("4 reihe b");
                            if (temp2 == 1 && zuordnung4[1] == "0") { zuordnung4[1] = zeichen[6]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 2 && zuordnung4[2] == "0") { zuordnung4[2] = zeichen[6]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 3 && zuordnung4[3] == "0") { zuordnung4[3] = zeichen[6]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 4 && zuordnung4[4] == "0") { zuordnung4[4] = zeichen[6]; nmb = nmb + 1; wahr = false; }

                        }
                        //  Console.WriteLine("{0} nmb", nmb);

                    }



                }
                #endregion
                #region if 8
                else if (i == 8)
                {
                    //  Console.WriteLine("$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
                    //  Console.WriteLine("for = 2");
                    //Console.ReadLine();
                    nmb = 0;
                    while (nmb != 2)
                    {
                        temp = zahl1.Next(1, 5);
                        temp2 = zahl1.Next(1, 5);

                        //Console.WriteLine(temp + "y");
                        // Console.WriteLine(temp2 + "x");
                        wahr = true;
                        //  Console.WriteLine("{0} nmb", nmb);
                        if (temp == 1 && wahr)
                        {
                            //  Console.WriteLine("1 reihe b");
                            if (temp2 == 1 && zuordnung1[1] == "0") { zuordnung1[1] = zeichen[7]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 2 && zuordnung1[2] == "0") { zuordnung1[2] = zeichen[7]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 3 && zuordnung1[3] == "0") { zuordnung1[3] = zeichen[7]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 4 && zuordnung1[4] == "0") { zuordnung1[4] = zeichen[7]; nmb = nmb + 1; wahr = false; }

                        }


                        else if (temp == 2 && wahr)
                        {
                            //  Console.WriteLine("2 reihe b");

                            if (temp2 == 1 && zuordnung2[1] == "0") { zuordnung2[1] = zeichen[7]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 2 && zuordnung2[2] == "0") { zuordnung2[2] = zeichen[7]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 3 && zuordnung2[3] == "0") { zuordnung2[3] = zeichen[7]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 4 && zuordnung2[4] == "0") { zuordnung2[4] = zeichen[7]; nmb = nmb + 1; wahr = false; }

                        }

                        else if (temp == 3 && wahr)
                        {
                            // Console.WriteLine("3 reihe b");
                            if (temp2 == 1 && zuordnung3[1] == "0") { zuordnung3[1] = zeichen[7]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 2 && zuordnung3[2] == "0") { zuordnung3[2] = zeichen[7]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 3 && zuordnung3[3] == "0") { zuordnung3[3] = zeichen[7]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 4 && zuordnung3[4] == "0") { zuordnung3[4] = zeichen[7]; nmb = nmb + 1; wahr = false; }

                        }

                        else if (temp == 4 && wahr)
                        {
                            //Console.WriteLine("4 reihe b");
                            if (temp2 == 1 && zuordnung4[1] == "0") { zuordnung4[1] = zeichen[7]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 2 && zuordnung4[2] == "0") { zuordnung4[2] = zeichen[7]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 3 && zuordnung4[3] == "0") { zuordnung4[3] = zeichen[7]; nmb = nmb + 1; wahr = false; }
                            else if (temp2 == 4 && zuordnung4[4] == "0") { zuordnung4[4] = zeichen[7]; nmb = nmb + 1; wahr = false; }

                        }
                        //  Console.WriteLine("{0} nmb", nmb);

                    }



                }
                #endregion



            }
           /*
           
            Console.Write("\n {0} {1} {2} {3} ", zuordnung1[1], zuordnung1[2], zuordnung1[3], zuordnung1[4]);
            Console.Write("\n {0} {1} {2} {3} ", zuordnung2[1], zuordnung2[2], zuordnung2[3], zuordnung2[4]);
            Console.Write("\n {0} {1} {2} {3} ", zuordnung3[1], zuordnung3[2], zuordnung3[3], zuordnung3[4]);
            Console.Write("\n {0} {1} {2} {3} ", zuordnung4[1], zuordnung4[2], zuordnung4[3], zuordnung4[4]);
                     */  

        }

        static void abfrage()
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();

            while (finisch != 8)
            {
              /* if (Console.ReadLine() == "s")
                { break; } */

                string eingabe;
                string eingabe2;
                string c = "";
                string d = "";

                int z1y = 0; int z2y = 0;
                int z1x = 0; int z2x = 0;
                /*
                   Console.Write("\n {0} {1} {2} {3} ", zuordnung1[1], zuordnung1[2], zuordnung1[3], zuordnung1[4]);
                    Console.Write("\n {0} {1} {2} {3} ", zuordnung2[1], zuordnung2[2], zuordnung2[3], zuordnung2[4]);
                    Console.Write("\n {0} {1} {2} {3} ", zuordnung3[1], zuordnung3[2], zuordnung3[3], zuordnung3[4]);
                    Console.Write("\n {0} {1} {2} {3} ", zuordnung4[1], zuordnung4[2], zuordnung4[3], zuordnung4[4]);
                */
                    Console.WriteLine(" "); 
                Regex rgx = new Regex(@"^[1-4]$");

                anfang:
                Console.WriteLine(" . 1 2 3 4--x-->");

                Console.Write(" 1 {0} {1} {2} {3} ", gewaehlt1[1], gewaehlt1[2], gewaehlt1[3], gewaehlt1[4]);
                Console.Write("\n 2 {0} {1} {2} {3} ", gewaehlt2[1], gewaehlt2[2], gewaehlt2[3], gewaehlt2[4]);
                Console.Write("\n 3 {0} {1} {2} {3} ", gewaehlt3[1], gewaehlt3[2], gewaehlt3[3], gewaehlt3[4]);
                Console.Write("\n 4 {0} {1} {2} {3} ", gewaehlt4[1], gewaehlt4[2], gewaehlt4[3], gewaehlt4[4]);
                Console.Write(" \n |");
                Console.Write(" \n y");
                Console.WriteLine(" ");
                Console.WriteLine("\n Sie sind am Zug. Eingabe = [feld1 y| feld 1x| feld2 y| feld2 x]");
                Console.Write("\n Format y1x1y2x2 : ");
                eingabe = Console.ReadLine();
                if (eingabe == "" || eingabe.Length != 4) { Console.Clear(); goto anfang; }
                else 
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (eingabe[i] < 48 || eingabe[i] > 52)
                        { Console.Clear();  goto anfang; }
                    }

                    if (eingabe[0] == eingabe[2] && eingabe[1] == eingabe[3])
                    {
                        Console.Clear();
                        goto anfang;
                    }
                    
                }

                eingabe2 = eingabe;
                for (int i = 0; i < 4; i++)
                {
                    if (i == 0) { z1x = Convert.ToInt32(Convert.ToString(eingabe2[0])); }
                    else if (i == 1) { z1y = Convert.ToInt32(Convert.ToString(eingabe2[1])); }
                    else if (i == 2) { z2x = Convert.ToInt32(Convert.ToString(eingabe2[2])); }
                    else if (i == 3) { z2y = Convert.ToInt32(Convert.ToString(eingabe2[3])); }
                }

                Console.Write("{0} {1} {2} {3} ", z1y, z1x, z2y, z2x);

                if (z1x == 1){ c  = zuordnung1[z1y]; }
                else if (z1x ==2) {  c = zuordnung2[z1y]; }
                else if (z1x == 3) { c = zuordnung3[z1y]; }
                else if (z1x == 4) { c = zuordnung4[z1y]; }

                if (z2x == 1) { d = zuordnung1[z2y]; }
                else if (z2x == 2) { d = zuordnung2[z2y]; }
                else if (z2x == 3) { d = zuordnung3[z2y]; }
                else if (z2x == 4) { d = zuordnung4[z2y]; }
/*
                if (z1x == 1) { c = zuordnung1[z1y]; }
                else if (z1x == 2) { if (gewaehlt2[z1y] == zuordnung2[z1y]) { a = true; } else { gewaehlt2[z1y] = zuordnung2[z1y]; } }
                else if (z1x == 3) { if (gewaehlt3[z1y] == zuordnung3[z1y]) { a = true; } else { gewaehlt3[z1y] = zuordnung3[z1y]; } }
                else if (z1x == 4) { if (gewaehlt4[z1y] == zuordnung4[z1y]) { a = true; } else { gewaehlt4[z1y] = zuordnung4[z1y]; } }

                if (z2x == 1) { if (gewaehlt1[z2y] == zuordnung1[z2y]) { b = true; } else { gewaehlt1[z2y] = zuordnung1[z2y]; } }
                else if (z2x == 2) { if (gewaehlt2[z2y] == zuordnung2[z2y]) { b = true; } else { gewaehlt2[z2y] = zuordnung2[z2y]; } }
                else if (z2x == 3) { if (gewaehlt3[z2y] == zuordnung3[z2y]) { b = true; } else { gewaehlt3[z2y] = zuordnung3[z2y]; } }
                else if (z2x == 4) { if (gewaehlt4[z2y] == zuordnung4[z2y]) { b = true; } else { gewaehlt4[z2y] = zuordnung4[z2y]; } }
               

                if (z2x == 1) { gewaehlt1[z2y] = zuordnung1[z2y]; }
                 else if (z2x == 2) { gewaehlt2[z2y] = zuordnung2[z2y]; }
                 else if (z2x == 3) { gewaehlt3[z2y] = zuordnung3[z2y]; }
                 else if (z2x == 4) { gewaehlt4[z2y] = zuordnung4[z2y]; }*/

                Console.Clear();

               /* Console.Write("\n {0} {1} {2} {3} ", gewaehlt1[1], gewaehlt1[2], gewaehlt1[3], gewaehlt1[4]);
                Console.Write("\n {0} {1} {2} {3} ", gewaehlt2[1], gewaehlt2[2], gewaehlt2[3], gewaehlt2[4]);
                Console.Write("\n {0} {1} {2} {3} ", gewaehlt3[1], gewaehlt3[2], gewaehlt3[3], gewaehlt3[4]);
                Console.Write("\n {0} {1} {2} {3} ", gewaehlt4[1], gewaehlt4[2], gewaehlt4[3], gewaehlt4[4]);
                Thread.Sleep(500); */

                if (c == d)
                {
                    Console.WriteLine("Richtig");
                    
                    if (z1x == 1) { gewaehlt1[z1y] = zuordnung1[z1y]; }
                    else if (z1x == 2) { gewaehlt2[z1y] = zuordnung2[z1y]; }
                    else if (z1x == 3) { gewaehlt3[z1y] = zuordnung3[z1y]; }
                    else if (z1x == 4) { gewaehlt4[z1y] = zuordnung4[z1y]; }

                    if (z2x == 1) { gewaehlt1[z2y] = zuordnung1[z2y]; }
                    else if (z2x == 2) { gewaehlt2[z2y] = zuordnung2[z2y]; }
                    else if (z2x == 3) { gewaehlt3[z2y] = zuordnung3[z2y]; }
                    else if (z2x == 4) { gewaehlt4[z2y] = zuordnung4[z2y]; }
                    /*
                                        Console.Write("\n {0} {1} {2} {3} ", gewaehlt1[1], gewaehlt1[2], gewaehlt1[3], gewaehlt1[4]);
                                        Console.Write("\n {0} {1} {2} {3} ", gewaehlt2[1], gewaehlt2[2], gewaehlt2[3], gewaehlt2[4]);
                                        Console.Write("\n {0} {1} {2} {3} ", gewaehlt3[1], gewaehlt3[2], gewaehlt3[3], gewaehlt3[4]);
                                        Console.Write("\n {0} {1} {2} {3} ", gewaehlt4[1], gewaehlt4[2], gewaehlt4[3], gewaehlt4[4]);
                                        Thread.Sleep(2000); */

                    Console.WriteLine(" . 1 2 3 4--x-->");

                    Console.Write(" 1 {0} {1} {2} {3} ", gewaehlt1[1], gewaehlt1[2], gewaehlt1[3], gewaehlt1[4]);
                    Console.Write("\n 2 {0} {1} {2} {3} ", gewaehlt2[1], gewaehlt2[2], gewaehlt2[3], gewaehlt2[4]);
                    Console.Write("\n 3 {0} {1} {2} {3} ", gewaehlt3[1], gewaehlt3[2], gewaehlt3[3], gewaehlt3[4]);
                    Console.Write("\n 4 {0} {1} {2} {3} ", gewaehlt4[1], gewaehlt4[2], gewaehlt4[3], gewaehlt4[4]);
                    Console.Write(" \n |");
                    Console.Write(" \n y");

                    finisch = finisch + 1; 
                }
                else
                {
                    
                    
                    if (z1x == 1) { gewaehlt1[z1y] = zuordnung1[z1y]; }
                    else if (z1x == 2) { gewaehlt2[z1y] = zuordnung2[z1y]; }
                    else if (z1x == 3) { gewaehlt3[z1y] = zuordnung3[z1y]; }
                    else if (z1x == 4) { gewaehlt4[z1y] = zuordnung4[z1y]; }

                    if (z2x == 1) { gewaehlt1[z2y] = zuordnung1[z2y]; }
                    else if (z2x == 2) { gewaehlt2[z2y] = zuordnung2[z2y]; }
                    else if (z2x == 3) { gewaehlt3[z2y] = zuordnung3[z2y]; }
                    else if (z2x == 4) { gewaehlt4[z2y] = zuordnung4[z2y]; }
                    /*
                                        Console.Write("\n {0} {1} {2} {3} ", gewaehlt1[1], gewaehlt1[2], gewaehlt1[3], gewaehlt1[4]);
                                        Console.Write("\n {0} {1} {2} {3} ", gewaehlt2[1], gewaehlt2[2], gewaehlt2[3], gewaehlt2[4]);
                                        Console.Write("\n {0} {1} {2} {3} ", gewaehlt3[1], gewaehlt3[2], gewaehlt3[3], gewaehlt3[4]);
                                        Console.Write("\n {0} {1} {2} {3} ", gewaehlt4[1], gewaehlt4[2], gewaehlt4[3], gewaehlt4[4]);
                                        Thread.Sleep(2000); */

                    Console.WriteLine(" . 1 2 3 4--x-->");

                    Console.Write(" 1 {0} {1} {2} {3} ", gewaehlt1[1], gewaehlt1[2], gewaehlt1[3], gewaehlt1[4]);
                    Console.Write("\n 2 {0} {1} {2} {3} ", gewaehlt2[1], gewaehlt2[2], gewaehlt2[3], gewaehlt2[4]);
                    Console.Write("\n 3 {0} {1} {2} {3} ", gewaehlt3[1], gewaehlt3[2], gewaehlt3[3], gewaehlt3[4]);
                    Console.Write("\n 4 {0} {1} {2} {3} ", gewaehlt4[1], gewaehlt4[2], gewaehlt4[3], gewaehlt4[4]);
                    Console.Write(" \n |");
                    Console.Write(" \n y");
                    Console.WriteLine("\n ");
                    Console.WriteLine(" Leider Falsch");
                    Thread.Sleep(2000);

                    if (z1x == 1) { gewaehlt1[z1y] = "?"; } 
                    else if (z1x == 2) { gewaehlt2[z1y] = "?"; }
                    else if (z1x == 3) { gewaehlt3[z1y] = "?"; }
                    else if (z1x == 4) { gewaehlt4[z1y] = "?"; }

                    if (z2x == 1) { gewaehlt1[z2y] = "?"; }
                    else if (z2x == 2) { gewaehlt2[z2y] = "?"; }
                    else if (z2x == 3) { gewaehlt3[z2y] = "?"; }
                    else if (z2x == 4) { gewaehlt4[z2y] = "?"; }

                   

                }
                Console.Clear();




            }
            watch.Stop();
            Console.Clear();
            Console.Write("\n {0} {1} {2} {3} ", gewaehlt1[1], gewaehlt1[2], gewaehlt1[3], gewaehlt1[4]);
            Console.Write("\n {0} {1} {2} {3} ", gewaehlt2[1], gewaehlt2[2], gewaehlt2[3], gewaehlt2[4]);
            Console.Write("\n {0} {1} {2} {3} ", gewaehlt3[1], gewaehlt3[2], gewaehlt3[3], gewaehlt3[4]);
            Console.Write("\n {0} {1} {2} {3} ", gewaehlt4[1], gewaehlt4[2], gewaehlt4[3], gewaehlt4[4]);
            Console.WriteLine("\n Fertig !!");
            Console.WriteLine("");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Du hast {0} gebraucht", watch.Elapsed);
            Console.WriteLine("-------[h  m  s]--------------------");

            Thread.Sleep(2000);
            Console.ReadLine();

        }

    }
}
