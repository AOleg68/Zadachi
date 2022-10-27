int sum = 0;
int startNumber = 0;

while (startNumber < 52)
{
   sum = sum + startNumber;
   startNumber += 2;
  
}
startNumber += 1;

Console.WriteLine (sum);