using EffectCreator.Forms;
using EffectCreator.Properties;
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

        private static bool newFile = false; 

        public static List<EffectGroup> LoadJsonObject() {
            string jsonText;

            if (File.Exists(ActiveFilePath())) {
                jsonText = File.ReadAllText(ActiveFilePath());
            }
            else if (File.Exists(DefaultFilePath())) {
                jsonText = File.ReadAllText(DefaultFilePath());
                SetActivePathToDefault();
            }
            else {
                newFile = true;
                return NewJsonObject();
            }

            Root jsonRoot = JsonConvert.DeserializeObject<Root>(jsonText);
            return EffectParser.ParseEffectGroups(jsonRoot);
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
            return ActiveDirectory() + "\\" + ActiveFileName();
        }

        public static string ActiveFileName() {
            return Settings.Default.FileName;
        }

        public static string ActiveDirectory() {
            return Settings.Default.DirectoryPath;
        }

        private static string DefaultFilePath() {
            return DEFAULT_DIRECTORY + "//" + DEFAULT_FILE_NAME;
        }

        private static bool SetFilePath() {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Effect Data|*.json";
            sfd.Title = "Save As";
            sfd.InitialDirectory = ActiveDirectory();
            sfd.ShowDialog();

            if (sfd.FileName != string.Empty) {
                SetActivePath(sfd.FileName);
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
                SetActivePath(ofd.FileName);
                return true;
            }
            return false;
        }

        private static void SetActivePath(string path) {
            Settings.Default.FileName = Path.GetFileName(path);
            Settings.Default.DirectoryPath = Path.GetDirectoryName(path);
            Settings.Default.Save();
        }

        private static void SetActivePathToDefault() {
            Settings.Default.FileName = DEFAULT_FILE_NAME ;
            Settings.Default.DirectoryPath = DEFAULT_DIRECTORY;
            Settings.Default.Save();
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
            SetActivePath(ActiveDirectory() + "/Untitled");
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
