string pangram = "The quick brown fox jumps over the lazy dog";
string[] arr= pangram.Split(" ");
string[] revArr=new string[arr.Length];
for(int i=0;i<arr.Length;i++)
{
    char[] chunks = arr[i].ToCharArray();
    Array.Reverse(chunks);
    revArr[i]=new string(chunks);
}
string result=String.Join(" ", revArr);
Console.Write(result);