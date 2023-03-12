// /*
//     How to count the occurrence of each character in a string?
//     The user will input a string and we need to find the count of each character of the string and display it on console. We won’t be counting space character.

//     input: hello world;
//     output: 
//         h – 1
//         e – 1
//         l – 3
//         o – 2
//         w – 1
//         r – 1
//         d – 1
// */
// class Program{

//     static void Main(string[] args){
//         Console.WriteLine("Please enter a string: ");
//         string UserInput = Console.ReadLine();
//         Console.WriteLine("You entered: "+ UserInput);

//         CharOccurence(UserInput);
//     }

//     public static void CharOccurence(string str){

//        Dictionary<char, int> CharCount = new Dictionary<char, int>();

//        foreach(var character in str){
//         if(character != ' '){
//             if(!CharCount.ContainsKey(character)){
//                 CharCount.Add(character, 1);
//             }else{
//                 CharCount[character] ++;
//             }
//         }
//        }

//        foreach(var character in CharCount){
//             Console.WriteLine("{0} : {1}", character.Key, character.Value);
//        }
//     }
// }

