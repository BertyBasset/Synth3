using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace UI.Code {
    public class  Json<T> where T : new()  {

        static string saveFolder = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)??"";

        public static void SaveFile(string FileName, T obj) {
            var s = JsonSerializer.Serialize<T>(obj);
            System.IO.File.WriteAllText(saveFolder + "\\" + FileName, s);
        }
        public static T Load(string FileName) {
            if (!System.IO.File.Exists(saveFolder + "\\" + FileName))
                return new T();

            var rv= JsonSerializer.Deserialize<T>(System.IO.File.ReadAllText(saveFolder + "\\" + FileName));
            return rv ?? new T();
        }
    }
}
