using Newtonsoft.Json;

namespace GameClassLibrary
{
    public class StorageTests
    {
        //Fields

        public List<Test> Data = new();
        public int Length;

        //Initialization and methods

        public StorageTests(string data)
        {
            if (data == string.Empty)
            {
                Data = GetDefaultTests();
                Length = Data.Count;
            }
            else
            {
                Data = JsonConvert.DeserializeObject<List<Test>>(data);
                Length = Data.Count;
            }
        }
        public static List<Test> GetDefaultTests()
        {
            List<Test> defaultData = new()
            {
                new Test("Сколько будет два плюс два умноженное на два?",6),
                new Test("Бревно нужно распилить на 10 частей.Сколько распилов нужно сделать?",9),
                new Test("На двух руках 10 пальцев.Сколько пальцев на 5 руках?",25),
                new Test("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?",60),
                new Test("Пять свечей горело, две потухли. Сколько свечей осталось?",2)
            };
            return defaultData;
        }
        public List<Test> GetSetTest(int testsNumber)
        {
            List<Test> setTest = new();

            foreach (var index in GetRandomIndex(testsNumber))
            {
                setTest.Add(Data[index]);
            }
            return setTest;
        }
        public static int[] GetRandomIndex(int testsNumber)
        {
            int[] array = Enumerable.Range(0, testsNumber).ToArray();
            Random random = new(DateTime.Now.Millisecond);
            array = array.OrderBy(x => random.Next()).ToArray();
            return array;
        }
        public void Add(Test newTest)
        {
            Data.Add(newTest);
            Length++;
        }
        public void Delete(int testNumber)
        {
            Data.RemoveAt(testNumber);
            Length--;
        }

    }
}
