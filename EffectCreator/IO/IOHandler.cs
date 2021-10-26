using EffectCreator.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace EffectCreator.IO {
    public static class IOHandler {
        private static readonly string DEFAULT_DIRECTORY = Directory.GetCurrentDirectory() + @"\Resources\";
        private static readonly string DEFAULT_FILE_NAME = "effects.json";
        private static string customFileName = string.Empty;
        private static string customDirectory = string.Empty;

        private static bool newFile = false; 

        public static List<EffectGroup> LoadJsonObject() {
            string filePath = ActiveFilePath();

            if (File.Exists(filePath) ){
                string jsonText = File.ReadAllText(filePath);
                Root jsonRoot = JsonConvert.DeserializeObject<Root>(jsonText);
                return EffectParser.ParseEffectGroups(jsonRoot);
            }
            else {
                newFile = true;
                return NewJsonObject();
            }
        }

        private static List<EffectGroup> NewJsonObject() {
            List<EffectGroup> effectGroups = new List<EffectGroup>();
            effectGroups.Add(new EffectGroup("New Effect Group", "", 1, TargetType.Area, ParticleType.Blood, SoundType.arrowFire, 1, new IEffect[] { }));
            return effectGroups;
        }

        public static void SaveJsonObject(Root jsonObject) {
            string filePath = ActiveFilePath();
            string contents = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
            StreamWriter writer = new StreamWriter(filePath, false);
            writer.Write(contents);
            writer.Close();
        }

        public static string ActiveFilePath() {
            return (customFileName == string.Empty) ? DEFAULT_DIRECTORY + "\\" + DEFAULT_FILE_NAME : customDirectory + "\\" + customFileName;
        }

        public static string ActiveFileName() {
            return customFileName == string.Empty ? DEFAULT_FILE_NAME : customFileName;
        }

        public static string ActiveDirectory() {
            string fullPath = ActiveFilePath();
            return Path.GetDirectoryName(fullPath);
        }

        private static bool SetFilePath() {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Effect Data|*.json";
            sfd.Title = "Save As";
            sfd.InitialDirectory = ActiveDirectory();
            sfd.ShowDialog();

            if (sfd.FileName != string.Empty) {
                customFileName = Path.GetFileName(sfd.FileName);
                customDirectory = Path.GetDirectoryName(sfd.FileName);
                return true;
            }
            return false;
        }

        private static bool OpenFilePath() {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Effect Data|*.json";
            ofd.Title = "Open File";
            ofd.InitialDirectory = ActiveDirectory();
            ofd.ShowDialog();

            if (ofd.FileName != string.Empty) {
                customFileName = Path.GetFileName(ofd.FileName);
                customDirectory = Path.GetDirectoryName(ofd.FileName);
                return true;
            }
            return false;
        }

        public static void SaveAs(List<EffectGroup> effectGroups) {
            if (SetFilePath()) {
                newFile = false;
                Save(effectGroups);
            }
        }

        public static void Save(List<EffectGroup> effectGroups) {
            if (newFile) {
                SaveAs(effectGroups);
            }
            else {
                Root jsonRoot = EffectSerializer.ConvertToJsonObject(effectGroups);
                SaveJsonObject(jsonRoot);
            }
        }

        public static List<EffectGroup> Open() {
            if (OpenFilePath()) {
                newFile = false;
                return LoadJsonObject();
            }
            return new List<EffectGroup>();
        }

        public static List<EffectGroup> OpenDefault() {
            return LoadJsonObject();
        }

        public static List<EffectGroup> NewFile() {
            newFile = true;
            customFileName = "Untitled";
            customDirectory = DEFAULT_DIRECTORY;
            return NewJsonObject();
        }

        public static bool HandleDirty(List<EffectGroup> effectGroups) {
            string fileName = ActiveFileName();
            frmSaveChangesDialog scd = new frmSaveChangesDialog(fileName);
            scd.ShowDialog();

            if (scd.DialogResult == DialogResult.Yes) {
                Save(effectGroups);
                return true;
            }
            else if (scd.DialogResult == DialogResult.No) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
