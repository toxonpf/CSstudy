namespace lw12
{
    public class lw12
    {
        public static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\toxon\source\repos\toxonpf\CSstudy\lw12\toxonpf.txt";
            try
            {
                if (!File.Exists(fileLocation)) throw new FileNotFoundException("файл не найден");

                string[] lines = File.ReadAllLines(fileLocation);

                List<int> allNums = new List<int>();
                foreach (string line in lines)
                {
                    int[] nums = line.Split(", ").Select(int.Parse).ToArray();
                    allNums.AddRange(nums);
                }

                Console.WriteLine($"Среднее число: {allNums.Average()}");
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Ошибка доступа к файлу: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}