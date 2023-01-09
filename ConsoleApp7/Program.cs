using System.IO; /*IO=input output*/
namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo di = new DirectoryInfo("c:\\Program Files");
            var dirList = di.GetDirectories();          
            foreach (var folder in dirList)
            {
                Console.WriteLine(folder.Name + folder.GetFiles().Length);
                Console.ForegroundColor = ConsoleColor.Red;
                Dön(folder);
            }            
        }
        static void Dön(DirectoryInfo di)
        {
            try
            {
                
                var dirList = di.GetDirectories();
                foreach (var folder in dirList)
                {
                    Console.WriteLine("_ " + folder.Name + "Byte: " + folder.GetFiles().Length);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Dön(folder);
                }
            }
            catch (Exception)
            {
              
            }
            
        }
        private static long GetFileSizeBytes(DirectoryInfo di)
        {
            throw new NotImplementedException();
        }
        
       
    }
}