/*
    How to remove duplicate characters from a string?
    The user will input a string and the method should remove multiple occurrences of characters in the string

    input: csharpcorner, output: csharpone
*/
class Program{

    static void Main(string[] args){
        Console.WriteLine("Please enter a string: ");
        string UserInput = Console.ReadLine();
        Console.WriteLine("You entered: "+ UserInput);

        RemoveDuplicates(UserInput);
    }

    public static void RemoveDuplicates(string str){
        string RemovedDuplicates = "";

        for(int i=0; i<str.Length; i++){
            if(!RemovedDuplicates.Contains(str[i])){
                RemovedDuplicates += str[i];
            }
        }
        Console.WriteLine(RemovedDuplicates);
    }
}

