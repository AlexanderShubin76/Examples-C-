string path = @"C:\Users\pastu\OneDrive\Desktop\Курс по питон гик брейнс\Курс _С#\Lectures\Lecture_7\Task_1_Factorial";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}
