class Utilities
    {
        public static int ReadInteger(string displayString)
        {
            int numberOfErrors = 0;
            int number = 0;
            bool repeatInput = false;

            do
            {
                try
                {
                    Console.Write(displayString);
                    number = Convert.ToInt32(Console.ReadLine());
                    repeatInput = false;

                }
                catch (FormatException)
                {
                    if (numberOfErrors == 2)
                    {
                        Console.WriteLine("You're having problems.  Press any key to exit.");
                        Console.ReadKey();
                        System.Environment.Exit(0);
                    }

                    Console.WriteLine("Input must be a numeric value.\n");
                    repeatInput = true;
                    numberOfErrors++;

                }
                catch (OverflowException)
                {
                    if (numberOfErrors == 2)
                    {
                        Console.WriteLine("You're having problems.  Press any key to exit.");
                        Console.ReadKey();
                        System.Environment.Exit(0);
                    }

                    Console.WriteLine("Value was too large!\n");
                    repeatInput = true;
                    numberOfErrors++;
                }
                catch (IndexOutOfRangeException)
                {
                    if (numberOfErrors == 2)
                    {
                        Console.WriteLine("You're having problems.  Press any key to exit.");
                        Console.ReadKey();
                        System.Environment.Exit(0);
                    }

                    Console.WriteLine("Your entered number is out of range.\n");
                    repeatInput = true;
                    numberOfErrors++;

                }

            } while (repeatInput == true);


            return number;
        }

        public static int ValidateEntry(string prompt, int maxIndex)
        {
            bool validEntry = false;
            int entry;
            do
            {
                entry = ReadInteger(prompt) - 1;
                if(entry <= maxIndex && entry != -1)
                {
                    validEntry = true;
                }
            } while (validEntry == false);
            return entry;
        }
        
	}
