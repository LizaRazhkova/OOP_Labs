using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.IO.MemoryMappedFiles;
using static System.Console;
namespace Lab13
{
    public static class BEALog
    {
        private static StreamWriter writer = new StreamWriter("bealogfile.txt", true);
        public static void WriteMessage(string message) => writer.WriteLine(message + ' ' + DateTime.Now.ToString());
        public static void SearchDateDay(string day)
        {
            writer.Close();
            string x, y = "";
            bool space = false;
            StreamReader reader = new StreamReader("bealogfile.txt");
            while (reader.EndOfStream == false)
            {
                x = reader.ReadLine();
                int i = x.Length - 1;
                while (true)
                {
                    if (x[i] == ' ')
                        if (space == false)
                            space = true;
                        else break;
                    y = x[i] + y;
                    i--;
                }
                if (y.Substring(0, 2) == day)
                    WriteLine(x);
                y = "";
                space = false;
            }
            reader.Close();
            writer = new StreamWriter("bealogfile.txt", true);
        }
        public static void SearchPartTime(string parttime)
        {
            DateTime time1, time2, time3;
            int j = 0;
            while (parttime[j] != '-') j++;
            time1 = DateTime.Parse(parttime.Substring(0, j));
            time2 = DateTime.Parse(parttime.Substring(j + 1, parttime.Length - j - 1));
            writer.Close();
            string x, y = "";
            StreamReader reader = new StreamReader("bealogfile.txt");
            while (reader.EndOfStream == false)
            {
                x = reader.ReadLine();
                int i = x.Length - 1;
                while (true)
                {
                    if (x[i] == ' ')
                        break;
                    y = x[i] + y;
                    i--;
                }
                time3 = DateTime.Parse(y);
                if ((time3 >= time1) && (time3 <= time2))
                    WriteLine(x);
                y = "";
            }
            reader.Close();
            writer = new StreamWriter("bealogfile.txt", true);
        }
        public static void SearchWord(string word)
        {
            writer.Close();
            string x;
            StreamReader reader = new StreamReader("bealogfile.txt");
            while (reader.EndOfStream == false)
                if ((x = reader.ReadLine()).Contains(word) == true)
                    WriteLine(x);
            reader.Close();
            writer = new StreamWriter("bealogfile.txt", true);
        }
        public static void Close() => writer.Close();
    }
    public class BEADiskInfo
    {
        private DriveInfo info;
        public BEADiskInfo(string name)
        {
            BEALog.WriteMessage("Action: создание объекта для получения информации о диске через " + GetType().Name);
            try
            {
                info = new DriveInfo(name);
                if (info.IsReady == false)
                    throw new Exception("Disk not exist");
            }
            catch (Exception ex)
            {
                BEALog.WriteMessage("Error: " + ex.Message);
                WriteLine(ex.Message);
            }
        }
        public string FreeMemory
        {
            get
            {
                BEALog.WriteMessage("Info: получение информации о свободном месте на диске " + info.Name);
                if (info.IsReady == true)
                {
                    long x = info.AvailableFreeSpace;
                    if (x > 1024 * 1024 * 1024)
                        return "Free Space: " + (x / 1024 / 1024 / 1024).ToString() + " gb";
                    else if (x > 1024 * 1024)
                        return "Free Space: " + (x / 1024 / 1024).ToString() + " mb";
                    else if (x > 1024)
                        return "Free Space: " + (x / 1024).ToString() + " kb";
                    else return "Free Space: " + x.ToString() + " b";
                }
                else return "Disk not exist";
            }
        }
        public string FileInfo
        {
            get
            {
                BEALog.WriteMessage("Info: получение информации о типе файловой системы на диске " + info.Name);
                if (info.IsReady == true)
                {
                    return "File system type: " + info.DriveFormat;
                }
                else return "Disk not exist";
            }
        }
        public string GlobalInfo
        {
            get
            {
                BEALog.WriteMessage("Info: получение информации о всех дисках");
                string ret = "";
                char disk = 'A';
                while ((disk >= 'A') && (disk <= 'Z'))
                {
                    try
                    {
                        DriveInfo driveInfo = new DriveInfo(disk + ":\\");
                        if (driveInfo.IsReady == false)
                            throw null;
                        ret += "Disk Name: " + driveInfo.Name + '\n';
                        ret += "Total Space: ";
                        long x = driveInfo.TotalSize;
                        if (x > 1024 * 1024 * 1024)
                            ret += (x / 1024 / 1024 / 1024).ToString() + " gb\n";
                        else if (x > 1024 * 1024)
                            ret += (x / 1024 / 1024).ToString() + " mb\n";
                        else if (x > 1024)
                            ret += (x / 1024).ToString() + " kb\n";
                        else ret += x.ToString() + " b\n";
                        ret += "Free Space: ";
                        x = driveInfo.AvailableFreeSpace;
                        if (x > 1024 * 1024 * 1024)
                            ret += (x / 1024 / 1024 / 1024).ToString() + " gb\n";
                        else if (x > 1024 * 1024)
                            ret += (x / 1024 / 1024).ToString() + " mb\n";
                        else if (x > 1024)
                            ret += (x / 1024).ToString() + " kb\n";
                        else ret += x.ToString() + " b\n";
                        ret += "Volume Label: " + driveInfo.VolumeLabel + '\n';
                    }
                    catch { };
                    disk++;
                }
                return ret;
            }
        }

    }
    public class BEAFileInfo
    {
        private FileInfo info;
        public BEAFileInfo(string name)
        {
            BEALog.WriteMessage("Action: создание объекта для получения информации о файле через " + GetType().Name);
            try
            {
                info = new FileInfo(name);
                if (info.Exists == false)
                    throw new Exception("File not exist");
            }
            catch (Exception ex)
            {
                BEALog.WriteMessage("Error: " + ex.Message);
                WriteLine(ex.Message);
            }
        }
        public string FullPath
        {
            get
            {
                BEALog.WriteMessage("Info: получение информации о пути к файлу " + info.Name);
                if (info.Exists == true)
                    return "Full Path: " + info.FullName;
                else return "File not exist";
            }
        }
        public string FileInfo
        {
            get
            {
                BEALog.WriteMessage("Info: получение информации о файле(размер, расширение, имя) " + info.Name);
                if (info.Exists == true)
                {
                    string ret = "";
                    long x = info.Length;
                    ret += "File Size: ";
                    if (x > 1024 * 1024 * 1024)
                        ret += (x / 1024 / 1024 / 1024).ToString() + " gb\n";
                    else if (x > 1024 * 1024)
                        ret += (x / 1024 / 1024).ToString() + " mb\n";
                    else if (x > 1024)
                        ret += (x / 1024).ToString() + " kb\n";
                    else ret += x.ToString() + " b\n";
                    ret += "File Extension: " + info.Extension + '\n';
                    ret += "File Name: " + info.Name;
                    return ret;
                }
                else return "File not exist";
            }
        }
        public string CreateTime
        {
            get
            {
                BEALog.WriteMessage("Info: получение информации о времени создания файла " + info.Name);
                if (info.Exists == true)
                    return "Create Time: " + info.CreationTime.ToString();
                else return "File not exist";
            }
        }
    }
    public class BEADirInfo
    {
        private DirectoryInfo info;
        public BEADirInfo(string name)
        {
            BEALog.WriteMessage("Action: создание объекта для получения информации о директории через " + GetType().Name);
            try
            {
                info = new DirectoryInfo(name);
                if (info.Exists == false)
                    throw new Exception("Directory not exist");
            }
            catch (Exception ex)
            {
                BEALog.WriteMessage("Error: " + ex.Message);
                WriteLine(ex.Message);
            }
        }
        public string FilesCount
        {
            get
            {
                BEALog.WriteMessage("Info: получение информации о количестве файлов " + info.Name);
                if (info.Exists == true)
                    return "Files Count: " + info.GetFiles().Count().ToString();
                else return "Directory not exist";
            }
        }
        public string CreateTime
        {
            get
            {
                BEALog.WriteMessage("Info: получение информации о времени создания директория " + info.Name);
                if (info.Exists == true)
                    return "Create Time: " + info.CreationTime.ToString();
                else return "Directory not exist";
            }
        }
        public string DirectoryCount
        {
            get
            {
                BEALog.WriteMessage("Info: получение информации о количестве директориев " + info.Name);
                if (info.Exists == true)
                   return "Directories Count: " + info.GetDirectories().Count().ToString();
                else return "Directory not exist";
            }
        }
        public string ParentDirectories
        {
            get
            {
                BEALog.WriteMessage("Info: получение информации о родительских директориях у " + info.Name);
                if (info.Exists == true)
                {
                    string ret = "";
                    DirectoryInfo info1 = new DirectoryInfo(info.FullName);
                    while (info1.Parent != null)
                    {
                        ret += info1.Parent.Name + ' ';
                        info1 = info1.Parent;
                    }
                    return "Parent Directories: " + ret;
                }
                else return "Directory not exist";
            }
        }
    }
    public static class BEAFileManager
    {
        private static DriveInfo drive;
        private static DirectoryInfo directory, logdirectory, bufdirectory;
        private static FileInfo logfile, buffile;
        private static ZipArchive zip;
        public static void GetDrive(string DriveName)
        {
            BEALog.WriteMessage("Action: получение диска в управление файловым менеджером");
            try
            {
                drive = new DriveInfo(DriveName);
                if (drive.IsReady == false)
                    throw new DriveNotFoundException("Диск не существует");
                BEALog.WriteMessage("Info: использование диска " + drive.Name);
                WriteLine("File Manager");
                WriteLine("Drive " + drive.Name + '\\');
                DirectoryInfo y = new DirectoryInfo(drive.Name);
                foreach (DirectoryInfo x in y.GetDirectories())
                {
                    try
                    {
                        if ((x.GetFiles() == null) && (x.GetDirectories() == null))
                            WriteLine('\t' + x.Name);
                        else WriteLine('\t' + x.Name + '\\');
                    }
                    catch (Exception ex)
                    { WriteLine('\t' + ex.Message); }
                }
                foreach (FileInfo x in y.GetFiles())
                    WriteLine('\t' + x.Name);
                DirectoryInfo inspect = Directory.CreateDirectory(y.FullName + "BEAInspect");
                logdirectory = inspect;
                directory = logdirectory;
                logfile = new FileInfo(inspect.FullName + '\\' + "beadirinfo.txt");
                StreamWriter text = File.CreateText(inspect.FullName + '\\' + "beadirinfo.txt");
                text.WriteLine("Hello BEAFileManager");
                text.Close();
            }
            catch (DriveNotFoundException ex)
            {
                BEALog.WriteMessage("Error: диск " + DriveName + " не существует");
                WriteLine(ex.Message);
                drive = null;
            }
        }
        public static void CreateDirectory(string DirName)
        {
            if ((drive == null) && (directory == null))
                BEALog.WriteMessage("Error: файловый менеджер не использует корневого каталога (зайдите в диск или директорий)");
            else
            {
                if (drive != null)
                {
                    BEALog.WriteMessage("Action: создание папки на диске " + drive.Name);
                    directory = Directory.CreateDirectory(drive.Name + DirName);
                }
                if (directory != null)
                {
                    BEALog.WriteMessage("Action: создание папки в " + directory.FullName);
                    directory = Directory.CreateDirectory(drive.Name + DirName);
                }
            }
        }
        public static void CopyToDirectory(string from, string filesextension)
        {
            BEALog.WriteMessage("Info: попытка копирования файла(-ов)");
            if (filesextension[0] != '.')
                BEALog.WriteMessage("Error: типа " + filesextension + " не существует");
            {
                try
                {
                    bufdirectory = new DirectoryInfo(from);
                    if (logdirectory == null)
                        throw new DirectoryNotFoundException("Объект directory не задан");
                    if (bufdirectory.GetFiles().Where(y => y.Extension == filesextension) == null)
                        BEALog.WriteMessage("Error: файлы типа " + filesextension + " не найдены в " + from);
                    else
                    {
                        BEALog.WriteMessage("Action: копирование файла(-ов) расширения " + filesextension + " из " + from);
                        foreach (FileInfo x in bufdirectory.GetFiles().Where(y => y.Extension == filesextension))
                        {
                            try
                            {
                                buffile = x.CopyTo(from + "\\BEACopy" + filesextension);
                                buffile.MoveTo(directory.FullName + '\\' + x.Name + filesextension);
                            }
                            catch(Exception ex)
                            {
                                BEALog.WriteMessage("Error: файл уже существует");
                                WriteLine(ex.Message);
                            };
                        }
                    }
                }
                catch (DirectoryNotFoundException ex)
                {
                    if (ex.Message == "Объект directory не задан")
                        BEALog.WriteMessage("Error: " + ex.Message);
                    else BEALog.WriteMessage("Error: требуемый директорий не найден");
                    WriteLine(ex.Message);
                }
            }
        }
        public static void MoveToDirectory(string what)
        {
            BEALog.WriteMessage("Info: попытка перемещения файла(-ов)");
            try
            {
                bufdirectory = new DirectoryInfo(what);
                bufdirectory.MoveTo(directory.FullName + '\\' + bufdirectory.Name);
            }
            catch (DirectoryNotFoundException ex)
            {
                BEALog.WriteMessage("Error: директорий " + what + "не существует");
                WriteLine(ex.Message);
            }
            catch
            {
                BEALog.WriteMessage("Error: directory не задан");
                WriteLine("directory не задан");
            }
        }
        public static void GetDir(string DirPath)
        {
            BEALog.WriteMessage("Action: получение директория в управление файловым менеджером");
            try
            {
                directory = new DirectoryInfo(DirPath);
            }
            catch (DirectoryNotFoundException ex)
            {
                BEALog.WriteMessage("Error: " + DirPath + " не существует");
                WriteLine(ex.Message); }
        }
        public static void LogToDirectory() => directory = logdirectory;
        public static void Ziping(string what)
        {
            try
            {
                bufdirectory = new DirectoryInfo(what);
                ZipFile.CreateFromDirectory(bufdirectory.FullName, bufdirectory.FullName + ".zip");
                zip = new ZipArchive(File.Open(bufdirectory.FullName + ".zip", FileMode.Open));
            }
            catch (Exception ex)
            { WriteLine(ex.Message); }
        }
        public static void UnZiping(string where)
        {
            try
            {
                bufdirectory = new DirectoryInfo(where);
                foreach (ZipArchiveEntry x in zip.Entries)
                    x.ExtractToFile(bufdirectory.FullName + '\\' + x.Name);
            }
            catch (Exception ex)
            { WriteLine(ex.Message); }
        }
    }
    class Program
    {
        public static void Main()
        {
            BEADiskInfo diskC = new BEADiskInfo("Z:\\");
            WriteLine(diskC.FreeMemory);
            WriteLine(diskC.FileInfo);
            WriteLine(diskC.GlobalInfo);
            BEAFileInfo file = new BEAFileInfo("Lab13.exe");
            WriteLine(file.FullPath);
            WriteLine(file.FileInfo);
            WriteLine(file.CreateTime);
            BEADirInfo dir = new BEADirInfo("D:\\C#\\OOP_Labs");
            WriteLine(dir.DirectoryCount);
            WriteLine(dir.FilesCount);
            WriteLine(dir.CreateTime);
            WriteLine(dir.ParentDirectories);
            BEAFileManager.GetDrive("Z:\\");
            BEAFileManager.CopyToDirectory("C:\\cygwin64", "ico");
            BEAFileManager.GetDrive("C:\\");
            BEAFileManager.CreateDirectory("BEAFile");
            BEAFileManager.CopyToDirectory("C:\\cygwin64", ".ico");
            BEAFileManager.LogToDirectory();
            BEAFileManager.MoveToDirectory("C:\\BEAFile");
            BEAFileManager.Ziping("C:\\BEAInspect\\BEAFile");
            BEAFileManager.UnZiping("C:\\BEAInspect");
            BEALog.SearchWord("Error");
            BEALog.SearchDateDay("20");
            BEALog.SearchPartTime("15:00-18:00");
            BEALog.Close();
            ReadKey();
        }
    }
}
