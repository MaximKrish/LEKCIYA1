int[] array = { 12, 23, 77, 43, 54, 57, 86, 77, 78 };

int n = array.Length;
int find = 77;

int index = 0;

while (index < n)
{
if(array[index]== find)
{
    Console.WriteLine(index);
    break;
    //прервать выполнение
}
//index = index +1;
index++;
}
