/*
    How to find if the given string is a palindrome or not?
    The user will input a string and we need to print “Palindrome” or “Not Palindrome” 
    based on whether the input string is a palindrome or not.
   
    input: madam, output: Palindrome
    input: step on no pets, output: Palindrome
    input: book, output: Not Palindrome
    if we pass an integer as a string parameter then also this method will give the correct output
    input: 1221, output: Palindrome
*/

// class Program{

//     static void Main(string[] args){
//         Console.WriteLine("Please enter a string: ");
//         string UserInput = Console.ReadLine();
//         Console.WriteLine("You entered: "+ UserInput);

//         Palindrome(UserInput);
//     }

//     public static void Palindrome(string str){
//         Char[] str1 = str.ToCharArray();
        
//         Array.Reverse(str1);

//         string str2 = new string(str1);

//         if(str.Equals(str2, StringComparison.OrdinalIgnoreCase)){
//             Console.WriteLine("Palindorome");
//         }else{
//             Console.WriteLine("Not Palindorome");
//         }
//     }
// }

