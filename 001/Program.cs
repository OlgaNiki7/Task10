string[] array = new string[5] {"999", "99", "hello", "world", "cat"};
string[] array1 = new string[array.Length];
void SecondArray(string[] array, string[] array1)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        array1[count] = array[i];
        count++;
        }
    }
}
