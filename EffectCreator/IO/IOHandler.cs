using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;

namespace EffectCreator.IO {
    public static class IOHandler {
        private static readonly string DEFAULT_FILE_PATH = Directory.GetCurrentDirectory() + @"\Resources\effects1.json";
        public static string CustomFilePath { get; private set; } = string.Empty;

        public static Root ParseEffects() {
            string filePath = CustomFilePath == string.Empty ? DEFAULT_FILE_PATH : CustomFilePath;
            string jsonText = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<Root>(jsonText);
        }

        public static void SerializeEffects(Root jsonObject) {
            string filePath = CustomFilePath == string.Empty ? DEFAULT_FILE_PATH : CustomFilePath;
            string contents = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
            StreamWriter writer = new StreamWriter(filePath, false);
            writer.Write(contents);
            writer.Close();
        }
    }
}
