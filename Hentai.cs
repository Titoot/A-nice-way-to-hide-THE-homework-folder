using System;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace DarkSide
{
    class Program
    {

        private static string destinationDirectory = "#Your Dictionary Location#";
        private static string Depression;
        private static string password;
        static void Main(string[] args)
        {
            Console.WriteLine("Depression?");
            try
            {
                Depression = Console.ReadLine();
            }
            catch(IndexOutOfRangeException) 
            {
                Console.WriteLine("baka!");
                Environment.Exit(0);
         
            }
			//little compare function
            if(Depression == "177013") 
            {
                Console.WriteLine("Code?");
                try
                {
                    password = Console.ReadLine();
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Asshole!");
                    Environment.Exit(0);

                }
				//main password compare
                if(password == "#Your password#")
                {
                    int MainTimer = 1;
                    while (MainTimer == 1)
                    {
                        DriveInfo[] Drivers = DriveInfo.GetDrives();
                        for (int k = 0; k < Drivers.Length; k++)
                        {
                            Thread.Sleep(100);
                            Console.WriteLine(Drivers[k]);
                            Console.WriteLine(Drivers[k].DriveType);
                            if (Drivers[k].DriveType == DriveType.Removable)
                            {
                                string DriveName = string.Format(Drivers[k].VolumeLabel);
                                
                                string DriveLetter = string.Format(Drivers[k].Name);
								//Your Flash Drive Name, Change it to your own
                               if (DriveName == "Titoot")
                                {
                                    try
                                    {
                                        
                                            foreach (string f in Directory.GetFiles(DriveLetter, "*.txt"))
                                            {
                                                Console.WriteLine(f);
												//text file name
                                                var passcode = File.ReadAllText(@DriveLetter + @"note.txt");
                                            Console.WriteLine(passcode);
											// the text within it
                                                if (passcode.ToString() == "FlatIsJustice")
                                                {
                                                    Process.Start("explorer.exe",@destinationDirectory);
                                                MainTimer = 0;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Hey! my Guy!");
                                                }

                                            }

                                        
                                    }
                                    catch (System.Exception excpt)
                                    {
                                        Console.WriteLine(excpt.Message);
                                    }

                                }






                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Fuckin Stubborn!");
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Fuck off!");
                Environment.Exit(0);
            }

            
        }
    }
}
