﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace EffectCreator.IO {
    public static class IOHandler {
        private static readonly string DEFAULT_DIRECTORY = Directory.GetCurrentDirectory() + @"\Resources\";
        private static readonly string DEFAULT_FILE_PATH = DEFAULT_DIRECTORY + @"effects1.json";
        private static string customFilePath = string.Empty;

        public static List<EffectGroup> LoadJsonObject() {
            string filePath = (customFilePath == string.Empty) ? DEFAULT_FILE_PATH : customFilePath;

            if (File.Exists(filePath) ){
                string jsonText = File.ReadAllText(filePath);
                return EffectParser.ParseEffectGroups(JsonConvert.DeserializeObject<Root>(jsonText));
            }
            else {
                MessageBox.Show($"The path {filePath} does not exist. An empty file will be created", "File not found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return NewJsonObject();
            }
        }

        private static List<EffectGroup> NewJsonObject() {
            List<EffectGroup> effectGroups = new List<EffectGroup>();
            effectGroups.Add(new EffectGroup("New Effect Group", "", 1, TargetType.Area, ParticleType.Blood, SoundType.arrowFire, 1, new IEffect[] { }));
            return effectGroups;
        }

        public static void SaveJsonObject(Root jsonObject) {
            string filePath = customFilePath == string.Empty ? DEFAULT_FILE_PATH : customFilePath;
            string contents = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
            StreamWriter writer = new StreamWriter(filePath, false);
            writer.Write(contents);
            writer.Close();
        }

        private static void SetFilePath() {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Effect Data|*.json";
            sfd.Title = "Save As";
            sfd.InitialDirectory = DEFAULT_DIRECTORY;

            sfd.ShowDialog();

            if (sfd.FileName != string.Empty) {
                customFilePath = sfd.FileName;
            }
        }

        private static void OpenFilePath() {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Effect Data|*.json";
            ofd.Title = "Open File";
            ofd.InitialDirectory = DEFAULT_DIRECTORY;

            ofd.ShowDialog();

            if (ofd.FileName != string.Empty) {
                customFilePath = ofd.FileName;
            }
        }

        public static void SaveAs(List<EffectGroup> effectGroups) {
            SetFilePath();
            Save(effectGroups);
        }

        public static void Save(List<EffectGroup> effectGroups) {
            EffectSerializer.SaveEffectGroups(effectGroups);
        }

        public static List<EffectGroup> Open() {
            OpenFilePath();
            return LoadJsonObject();
        }

        public static List<EffectGroup> OpenDefault() {
            return LoadJsonObject();
        }

        public static List<EffectGroup> NewFile() {
            return NewJsonObject();
        }
    }
}
