using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RutonyChat {
    public static class RutonyBotFunctions {

        public static string GetScriptDirectory(string scriptname) {

            return Directory.GetCurrentDirectory();
        }

        public static void FileExists(string filename) {

            if (!File.Exists(filename)) {
                using (StreamWriter sw = File.AppendText(filename)) { }
            }

        }

        public static bool FileHasString(string filename, string text) {

            try {
                string[] lines = File.ReadAllLines(filename);

                foreach (string strLine in lines) {
                    if (text == strLine) {
                        return true;
                    }
                }
            } catch {
                return false;
            }

            return false;
        }

        public static void FileAddString(string filename, string text) {

            try {
                using (StreamWriter sw = File.AppendText(filename)) {
                    sw.WriteLine(text);
                }
            } catch {

            }
        }

        public static void FileClear(string filename) {

            try {
                using (var fs = new FileStream(filename, FileMode.Truncate)) { }
            } catch {

            }
        }

        public static int FileLength(string filename) {

            try {
                string[] lines = File.ReadAllLines(filename);
                return lines.Length;
            } catch { }

            return 0;
        }

        public static string FileStringAt(string filename, int ind) {

            try {
                string[] lines = File.ReadAllLines(filename);

                if (lines.Length < ind) {
                    return "";
                } else {
                    return lines[ind];
                }

            } catch { }

            return "";
        }
    }
}
