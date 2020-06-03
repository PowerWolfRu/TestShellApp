using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;


namespace TestShellApp.v1
{
    public class TestDB
    {
        List<Test> tests = new List<Test>();

        public List<Test> allTest { get => tests; }
        int AutoIncrementTest = 1;
        string filename = "test.all";
        
        DataContractJsonSerializer json = 
            new DataContractJsonSerializer(typeof(List<Test>));

        public static TestDB instance;

        public static TestDB GetInstance()
        {
            if (instance == null)
                instance = new TestDB();
            return instance;
        }


        public ArrayTests GetTests() => new ArrayTests(tests);

        public void SaveTest()
        {
            using(FileStream fs = File.OpenWrite(filename))
            {
                fs.Write(BitConverter.GetBytes(AutoIncrementTest), 0, 4);
                json.WriteObject(fs, tests);
            }
        }

        public List<Test> GetTest()
        {
            return tests.Select(s => s)?.ToList();
        }

        public TestDB()
        {
            if (!File.Exists(filename))
                return;
            using(FileStream fs = File.OpenRead(filename))
            {
                byte[] array = new byte[4];
                fs.Read(array, 0, 4);
                AutoIncrementTest = BitConverter.ToInt32(array, 0);
                tests = (List<Test>)json.ReadObject(fs);
            }
        }

        public Test AddTest()
        {
            var test = new Test { ID = AutoIncrementTest++ };
            tests.Add(test);
            return test;
        }
    }
}
