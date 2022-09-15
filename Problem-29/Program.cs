int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,1000);
}
int count = array.Length;
int position = 0;
while (position < count)
{
    System.Console.Write(array[position] + " ");
    position++;
}