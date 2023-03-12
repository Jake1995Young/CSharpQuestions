/*
    How to reverse the order of words in a given string?
    The user will input a sentence and we need to reverse the sequence of words in the sentence.

    input: Welcome to Csharp corner, output: corner Csharp to Welcome
*/
// class Program{

//     static void Main(string[] args){
//         Console.WriteLine("Please enter a string: ");
//         string UserInput = Console.ReadLine();
//         Console.WriteLine("You entered: "+ UserInput);

//         ReverseWordOrder(UserInput);
//     }

//     public static void ReverseWordOrder(string str){
//         char[] charArray = str.ToCharArray();
        
//         Array.Reverse(charArray);
        
//         string ReversedString = new string(charArray);
        
//         string ReverseWordOrder = string.Join(" ", ReversedString
//             .Split(' ')
//             .Select(x => new String(x.Reverse().ToArray())));
        
//         Console.WriteLine("Reversed Word Order is: " + ReverseWordOrder);
//     }

// }

