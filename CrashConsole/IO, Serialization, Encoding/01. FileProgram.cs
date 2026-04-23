/* Files
 * File Methods: 
   1. File.Create
   2. File.Exists()
   3. File.Copy(): File.Copy(fileNameWithPath, newFileNameWithPath)
   4. File.Move(): File.Move(currentFileNameWithPath, newFileNameWithPath);
   5. File.Delete(): File.Delete(fileNameWithPath);
   6. File.Open()
   7. File.OpenRead()
   8. File.OpenWrite()
   9. File.WriteAllText()
   10. File.WriteAllLines()
   11. File.ReadAllLines()
   12. File.ReadAllText()
 */
public class ProgramFile
{
    public static void MainFile()
    {
        string filePath = "D:\\newTest.txt";
        if (!File.Exists(filePath))
        {
            File.Create(filePath).Close();
            Console.WriteLine("File created");
        }
        else
        {
            Console.WriteLine("File already exists");
        }
    }
}