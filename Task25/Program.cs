// Дана строка символов, которая обязательно заканчивается символом точки. Удалить из строки первые буквы каждого слова.

Console.WriteLine("Введите строку");
string text = Console.ReadLine();
int position = text.LastIndexOf(".");
if (position != text.Length - 1)
{
    Console.WriteLine("Отсутсвует точка в конце строки");
    return;
}

string[] s = new string[text.Length];
int count = 0;
for (int i = 0; i < text.Length; i++)
{
    if(text[i] == ' ')
    {
        s[count] = s[count] + " ";
        count++;
    }
    if(text[i] != ' ') 
    {
        if(i == 0 || text[i - 1] == ' ') 
        {
            
        } 
        else
        {
            s[count] = s[count] + text[i];
        }
        
    }
    
}
Console.WriteLine("String without first letters: ");
for (int i = 0; i < s.Length; i++)
{
    Console.Write(s[i]);
}
 

