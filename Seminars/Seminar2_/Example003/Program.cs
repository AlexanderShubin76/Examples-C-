// bool a = 2 >3;
// bool a = true || false; или
// bool a = true && false; и
// int [] array = {1000};
// System.Console.WriteLine(array[0]);
int a = 1234;
string str = a.ToString();
int[] b = new int[str.Length];
for( int i=0; i< str.Length; i++)
{
     b[i] = int.Parse(str[i].ToString());
}
System.Console.WriteLine(b[0]);