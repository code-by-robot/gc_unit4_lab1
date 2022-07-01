Console.WriteLine("Word Reverser! ");
bool runProgram = true;

//Main Program
while (runProgram == true)
{
    Console.WriteLine("Enter word(s) to be reversed: ");
    string[] userinput = Console.ReadLine().Split(' ');
    string output = "";

    foreach (string word in userinput)
    {
        output += reverseIt(word) + " ";
    }

    Console.WriteLine(output);

    runProgram = checkLoop("Would you like to reverse something else? y/n");
}



//Methods

//reverses order of letters in strings that are only letters
static string reverseIt(string word)
{
    //Set up
    Stack<string> stackOfLetters = new Stack<string>();
    string output = "";
    bool charCheck = true;

    //Loop over each letter
    foreach (char letter in word)
    {
        charCheck = char.IsLetter(letter);
        //if not a letter, break out of loop
        if (charCheck == false)
        {
            break;
        }
        stackOfLetters.Push(letter.ToString());
    }
    // if all are letters, pop each letter off of the stack
    if(charCheck == true)
    {
        while (stackOfLetters.Count > 0)
        {
            output += (stackOfLetters.Pop());
        }
    }
    // return original word if there is a non-letter in the string
    else
    {
        output = word;
    }
    
    return output;
}

//Check to continue loop
static bool checkLoop(string message)
{
    while (true)
    {
        Console.WriteLine(message);
        string input = Console.ReadLine();
        if (input.ToLower().Trim() == "y")
        {
            return true;
            break;
        }
        else if (input.ToLower().Trim() == "n")
        {
            return false;
            break;
        }
        else
        {
            Console.WriteLine("Please enter y or n.");
        }
    }
}

//Method testing
//Console.WriteLine(reverseIt("apple"));