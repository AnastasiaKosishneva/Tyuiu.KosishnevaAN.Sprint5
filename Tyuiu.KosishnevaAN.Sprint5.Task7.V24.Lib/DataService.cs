using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.KosishnevaAN.Sprint5.Task7.V24.Lib
{
    public class DataService : ISprint5Task7V24
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask7V24.txt";
            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (((line[i] == 'П') && (line[i+1] == 'р') && (line[i+2] == 'и') && (line[i+3] == 'в') && (line[i+4] == 'е') && (line[i+5] == 'т')) || ((line[i] == 'м') && (line[i+1] == 'о') && (line[i+2] == 'я')) || ((line[i] == 'п') && (line[i+1] == 'е') && (line[i+2] == 'р') && (line[i+3] == 'в') && (line[i+4] == 'а') && (line[i+5] == 'я')) || ((line[i] == 'п') && (line[i+1] == 'р') && (line[i+2] == 'о') && (line[i+3] == 'г') && (line[i+4] == 'р') && (line[i+5] == 'а') && (line[i+6] == 'м') && (line[i+7] == 'м') && (line[i+8] == 'а')))
                        {
                            strLine += 'с' + 'л' + 'о' + 'в' + 'о';
                        }
                    }
                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    strLine = "";
                }
            }
            return pathSaveFile;

        }
    }
}
