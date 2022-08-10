string? yesNo = "";
while (yesNo!.ToLower() != "yes" && yesNo.ToLower() != "no")
{
  Console.Write("Введёте сами строки массива? (yes/no): ");
  yesNo = Console.ReadLine();
}

string[] arrayStrings = new string[]  {};

if (yesNo.ToLower() == "yes") 
{
  int num = InputNumbers("Введите количество элементов массива: ");
  arrayStrings = new string[num];
  for (int i = 0; i < arrayStrings.Length; i++)
  {
    Console.Write($" Введите {i+1} строку: ");
    arrayStrings[i] = Console.ReadLine()!;
  }
}
else 
{
  arrayStrings = new string[]  {"hello", "2", "world", ":-)"};
}

int lengthLimit = 3;

int numbersItems = CheckArray(arrayStrings, lengthLimit);

string[] newArrayStrings = new string[numbersItems];

FillNewArray(arrayStrings, newArrayStrings, lengthLimit);

Console.WriteLine($"{PrintArray(newArrayStrings)}");

void FillNewArray(string[] oldArray, string[] newArray, int lengthLimit)
{
  int temp = 0;
  for (int i = 0; i < oldArray.Length; i++)
  {
    if (oldArray[i].Length <= lengthLimit)
    {
      newArray[temp] = oldArray[i];
      temp++;
    }
  }
}

int CheckArray(string[] array, int lengthLimit)
{
  int result = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i].Length <= lengthLimit) result++;
  }
  return result;
}

string PrintArray(string[] array)
{ 
  string result = string.Empty;
  result = "[ ";
  for (int i = 0; i < array.Length; i++)
  {
    result += $"{array[i],1}";
    if (i < array.Length - 1) result += ", ";
  }
  result += " ]";
  return result;
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
