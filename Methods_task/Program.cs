namespace Methods_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string password = "Narm1n@Bagirova";
            //bool isValid = ValidatePassword(password);
            //Console.WriteLine($"Password is valid:{isValid}");
            string input = " Games of App Store  ";
            string oldvalue = "App";
            string newValue = "Play";
            string result = Replace(input, oldvalue, newValue);
            Console.WriteLine($"Replaced: '{result}'");
            string trimmed = Trim(input);
            Console.WriteLine($"Trimmed: '{trimmed}'"); 
            string substring = CustomSubstring(input, 0, 6);
            Console.WriteLine($"Substring: '{substring}'");


        }
        #region task1
        //static bool ValidatePassword(string password)
        //{
        //    if (password.Length < 8)
        //    {
        //        Console.WriteLine("Password must be at least 8 characters long.");
        //        return false;
        //    }
        //    if (!char.IsUpper(password[0]))
        //    {
        //        Console.WriteLine("Password must start with an uppercase letter.");
        //        return false;
        //    }

        //    bool hasDigit = false;
        //    bool hasSpecialChar = false;

        //    foreach (char c in password)
        //    {
        //        if (char.IsDigit(c))
        //            hasDigit = true;
        //        else if (!char.IsLetterOrDigit(c))
        //            hasSpecialChar = true;

        //        if (hasDigit && hasSpecialChar)
        //            break;
        //    }
        //    if (!hasDigit)
        //    {
        //        Console.WriteLine("Password must contain at least one digit.");
        //        return false;
        //    }

        //    if (!hasSpecialChar)
        //    {
        //        Console.WriteLine("Password must contain at least one special character.");
        //        return false;
        //    }
        //    return hasDigit && hasSpecialChar;
        //}
        #endregion

        #region task2 
        static string Replace(string input, string oldValue, string newValue)
        {
            if (input == null || oldValue == null || newValue == null)
                return null;

            string result = "";
            int index = 0;

            while (true)
            {
                int foundIndex = input.IndexOf(oldValue, index);
                if (foundIndex==-1)
                {
                    result += input.Substring(index);
                    break;
                }

                result += input.Substring(index, foundIndex - index);
                result += newValue;
                index = foundIndex + oldValue.Length;
            }
            return result;
        }
        static string CustomSubstring(string input, int startIndex, int length)
        {
            if (input == null || startIndex < 0 || length < 0 || startIndex + length > input.Length)
                return ""; 

            char[] result = new char[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = input[startIndex + i];
            }
            return new string(result);
        }
        static string Trim(string input)
        {
            int start = 0;
            int end = input.Length - 1;

            while (start <= end && char.IsWhiteSpace(input[start]))
            {
                start++;
            }

            while (end >= start && char.IsWhiteSpace(input[end]))
            {
                end--;
            }

            return input.Substring(start, end - start + 1);
        }
        #endregion
    }

}