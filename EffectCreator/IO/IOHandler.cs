using Newtonsoft.Json;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace EffectCreator.IO {
    public static class IOHandler {
        private static readonly string DEFAULT_DIRECTORY = Directory.GetCurrentDirectory() + @"\Resources\";
        private static readonly string DEFAULT_FILE_PATH = DEFAULT_DIRECTORY + @"effects1.json";
        private static string customFilePath = string.Empty;

        public static Root ParseEffects() {
            string filePath = customFilePath == string.Empty ? DEFAULT_FILE_PATH : customFilePath;

            if (File.Exists(filePath) ){
                string jsonText = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<Root>(jsonText);
            }
            else {
                return null;
            }
        }

        public static void SerializeEffects(Root jsonObject) {
            string filePath = customFilePath == string.Empty ? DEFAULT_FILE_PATH : customFilePath;
            string contents = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
            StreamWriter writer = new StreamWriter(filePath, false);
            writer.Write(contents);
            writer.Close();
        }

        public static void SetFilePath() {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Effect Data|*.json";
            sfd.Title = "Save As";
            sfd.InitialDirectory = DEFAULT_DIRECTORY;

            sfd.ShowDialog();
            customFilePath = sfd.FileName;
        }
    }
}
