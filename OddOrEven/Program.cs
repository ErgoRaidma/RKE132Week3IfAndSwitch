

Console.WriteLine("Enter a number");
int userNum = Convert.ToInt32(Console.ReadLine());

//kas kasutaja arv on paaris või paaritu

int resault = userNum % 2;

if(resault != 0)//!= tähendab, et ei ole võrdne
{
    Console.WriteLine("User number is odd.");
}else
{
    Console.WriteLine("User number is even");
}