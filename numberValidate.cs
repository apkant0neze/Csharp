static bool numberValidation(string numInput)
            {
                bool isValid = true;
                //int decimalCounter = 0;
                

                for (int i = 0; i < numInput.Length; i++)
                {
                    if (numInput[i] != '0' && numInput[i] != '1' && numInput[i] != '2' && numInput[i] != '3' && numInput[i] != '4' &&
                        numInput[i] != '5' && numInput[i] != '6' && numInput[i] != '7' && numInput[i] != '8' && numInput[i] != '9' )
                        //&& numInput[i] != '-' && numInput[i] != '.')
                    {
                        isValid = false;
                    }

                    if (isValid == false)
                    {
                        Console.WriteLine("Invalid Entry.");
                        break;
                    }
                
                }

                return isValid;
			}
