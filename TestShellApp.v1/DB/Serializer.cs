using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TestShellApp.v1
{
    public class Serializer<T>
    {
        static BinaryFormatter bf = new BinaryFormatter();
        string filepath;

        public Serializer(string filepath)
        {
            this.filepath = filepath;
        }

        public void Save(T objects, int AutoIncrement)
        {
            using (FileStream fs = new FileStream(filepath, FileMode.Create, FileAccess.Write))
            {
                fs.Write(BitConverter.GetBytes(AutoIncrement), 0, 4);
                bf.Serialize(fs, objects);
            }
        }

        public T Load(ref int autoincrement)
        {
            if(!File.Exists(filepath))
            {
                var type = typeof(T);
                var ctor = type.GetConstructor(Type.EmptyTypes);
                return (T)ctor.Invoke(null);
            }
            byte[] array = new byte[4];
            using (FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read))
            {
                fs.Read(array, 0, 4);
                autoincrement = BitConverter.ToInt32(array, 0);
                return (T)bf.Deserialize(fs);
            }
        }
    }
}
