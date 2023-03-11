using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; // 文件流空间
using System.Diagnostics; // process类
using System.Globalization; // time系统时间
using System.Runtime.InteropServices; // lnk快捷方式
using System.IO.Compression; // C#压缩解压

using IWshRuntimeLibrary; // WshShell
using System.Text.RegularExpressions; // 正则表达式 Regex

namespace HwEcAuto
{
    class File
    {
        /***************************************************************/
        // 全局变量区

        string g_currentPath = System.IO.Directory.GetCurrentDirectory();
        string g_myPCName = "小骆";
        /***************************************************************/

        /***************************************************************/
        // 函数区

        public void FileHandle(string path)
        {
            try {
                Process pro = new Process();
                FileInfo file = new FileInfo(path);
                pro.StartInfo.WorkingDirectory = file.Directory.FullName;
                pro.StartInfo.FileName = path;
                pro.StartInfo.CreateNoWindow = false;
                pro.Start();
                pro.WaitForExit();
            } catch(Exception ex) {
                MessageBox.Show("执行失败 错误原因:" + ex.Message + "\n" + path, "Error Tips:");
            }
        }

        public void Show(string str, string tittle)
        {
            if(g_myPCName == System.Environment.GetEnvironmentVariable("ComputerName")) {
                MessageBox.Show(str, tittle);
            }
        }

        public void Show(string str)
        {
            if(g_myPCName == System.Environment.GetEnvironmentVariable("ComputerName")) {
                MessageBox.Show(str);
            }
        }

        public bool Rename(string commonPath, string nameStr)
        {
            if(commonPath == null || nameStr == null) {
                Log("File-->Rename() : Exsit null string");
                return false;
            }
            if(System.IO.File.Exists(commonPath)) { // commonPath是文件路径
                string filePath = System.IO.Path.GetDirectoryName(commonPath);
                System.IO.File.Move(commonPath, filePath + @"\" + nameStr);
            } else if(System.IO.Directory.Exists(commonPath)) { // commonPath是目录路径
                string parentPath = System.IO.Path.GetDirectoryName(commonPath);
                System.IO.Directory.Move(commonPath, parentPath + @"\" + nameStr);
            } else { // commonPath路径不存在
                Log("File-->Rename() : No exsit " + commonPath);
                return false;
            }
            return true;
        }

        public string CutTime(string str)
        {
            if(str == null || str.Length < 10) {
                return null;
            }
            return str.Remove(10, str.Length - 10);
        }

        public int DaysDifference(string beginTime, string endTime)
        {
            if(beginTime == null || endTime == null || beginTime.Length < 10 || endTime.Length < 10) {
                return 0;
            }
            int result;
            try {
                int beginDay = int.Parse(CutStr(beginTime, 9, 2));
                int endDay = int.Parse(CutStr(endTime, 9, 2));
                int beginMonth = int.Parse(CutStr(beginTime, 6, 2));
                int endMonth = int.Parse(CutStr(endTime, 6, 2));
                int beginYear = int.Parse(CutStr(beginTime, 1, 4));
                int endYear = int.Parse(CutStr(endTime, 1, 4));
            
                if((beginYear > endYear) || (beginYear == endYear && beginMonth > endMonth) ||
                    (beginYear == endYear && beginMonth == endMonth && beginDay >= endDay)) {
                     return 0;
                }
                int dayDifference = endDay - beginDay;
                int monthDifference = endMonth - beginMonth;
                int yearDifference = endYear - beginYear;
                result = 365 * yearDifference + 30 * monthDifference + dayDifference;
            } catch(Exception) {
                return 0;
            }
            return result;
        }

        /*
         * 从str的第begin个字符开始取num个字符组成新的字符串
         * 
         */
        public string CutStr(string str, int begin, int num)
        {
            if(str == null) {
                return null;
            }
            begin--;
            int end = begin + num;
            if(begin >= 0 && begin < end && end <= str.Length) {
                string lostStr = str.Remove(end, str.Length - end);
                lostStr = lostStr.Remove(0, begin);
                return lostStr;
            } else {
                Show("Failing to cutting str.", "CutStr");
                return null;
            }
        }

        /*
         * 
         * 返回srcFilePath文件总行数
         */
        public int getMaxLine(string srcFilePath)
        {
            if(System.IO.File.Exists(srcFilePath)) {
                StreamReader sr = new StreamReader(srcFilePath);
                string str = sr.ReadToEnd();
                string[] arrayStr = Regex.Split(str, "\r\n");
                if(arrayStr == null) {
                    return 0;
                }
                sr.Close();
                return arrayStr.Length;
            } else {
                Show("NO " + srcFilePath, "getMaxLine");
                return 0;
            }
        }

        /*
         * 返回srcFilePath文件第line行数据
         * 
         */
        public string getLine(string srcFilePath, int line)
        {
            if(System.IO.File.Exists(srcFilePath)) {
                StreamReader sr = new StreamReader(srcFilePath);
                string str = sr.ReadToEnd();
                string[] arrayStr = Regex.Split(str, "\r\n");
                if(arrayStr == null || line < 1 || line > arrayStr.Length) {
                    Show("NO exsit the line: " + line.ToString(), "getLine");
                    return null;
                }
                string lastMessage = arrayStr[line - 1]; // 获取srcFilePath文件第line行数据
                sr.Close();
                return lastMessage;
            } else {
                Show("NO " + srcFilePath, "getLine");
                return null;
            }
        }

        public void CreateShortcutOnDesktop()
        {
            //添加引用 (COM->Windows Script Host Object Model)，using IWshRuntimeLibrary;
            String shortcutPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "快捷方式名称.lnk");
            if (!System.IO.File.Exists(shortcutPath))
            {
                // 获取当前应用程序目录地址
                String exePath = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
                IWshShell shell = new WshShell();
                // 确定是否已经创建的快捷键被改名了
                foreach (var item in Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory), "*.lnk"))
                {
                    WshShortcut tempShortcut = (WshShortcut)shell.CreateShortcut(item);
                    if (tempShortcut.TargetPath == exePath)
                    {
                        return;
                    }
                }
                WshShortcut shortcut = (WshShortcut)shell.CreateShortcut(shortcutPath);
                shortcut.TargetPath = exePath;
                shortcut.Arguments = ""; // 参数  
                shortcut.Description = "应用程序说明";
                // 程序所在文件夹，在快捷方式图标点击右键可以看到此属性  
                shortcut.WorkingDirectory = Environment.CurrentDirectory;
                shortcut.IconLocation = exePath; // 图标，该图标是应用程序的资源文件  
                //shortcut.Hotkey = "CTRL+SHIFT+W"; // 热键，发现没作用，大概需要注册一下  
                shortcut.WindowStyle = 1;
                shortcut.Save();
            }
        }

        /*
         * 仅能压缩文件，不支持压缩文件夹
         * 
         */
        public void FileCompression(string srcFilePath)
        {
            if(!System.IO.File.Exists(srcFilePath)) {
                Show("非文件路径:" + srcFilePath, "FileCompression");
            }
            StreamReader sr = new StreamReader(srcFilePath);
            //读取出文件中的内容
            string gotData = sr.ReadToEnd();
            //1.压缩文件的后缀名.nice 2.生成文件路径，一般为当前路径，Debug下也可为绝对路径
            FileStream filedata = new FileStream("myCompression.nice", FileMode.Create, FileAccess.Write);
            //将创建的文件流压缩
            GZipStream zip = new GZipStream(filedata, CompressionMode.Compress);
            StreamWriter sw = new StreamWriter(zip);
            //将文件的内容写入到压缩的流当中
            sw.Write(gotData);
            //关闭流
            sw.Close();
            zip.Close();
            sr.Close();
            sw.Close();
            filedata.Close();
        }

        // 压缩文件，支持指定文件压缩产生位置
        public void FileCompression(string srcFilePath, string desDirPath)
        {
            if(!System.IO.File.Exists(srcFilePath)) {
                Show("非文件路径:" + srcFilePath, "FileCompression");
            } else if(!System.IO.Directory.Exists(desDirPath)) {
                Show("非目录路径:" + desDirPath, "FileCompression");
            } else {
                StreamReader sr = new StreamReader(srcFilePath);
                string gotData = sr.ReadToEnd();
                FileStream filedata = new FileStream(Path.GetFileNameWithoutExtension(srcFilePath) + ".nice", FileMode.Create, FileAccess.Write);
                GZipStream zip = new GZipStream(filedata, CompressionMode.Compress);
                StreamWriter sw = new StreamWriter(zip);
                sw.Write(gotData);
                sw.Close();
                zip.Close();
                sr.Close();
                sw.Close();
                filedata.Close();

                string srcCopyFilePath = g_currentPath + @"\" + Path.GetFileNameWithoutExtension(srcFilePath) + ".nice";
                string desCopyFilePath = desDirPath + @"\" + Path.GetFileNameWithoutExtension(srcFilePath) + ".nice";
                System.IO.File.Copy(srcCopyFilePath, desCopyFilePath, true);
                string fileStr = System.IO.File.ReadAllText(desCopyFilePath);
                System.IO.File.Delete(srcCopyFilePath);
            }
        }

        // 压缩文件，支持指定文件压缩产生位置，支持定制专属压缩文件名后缀
        public void FileCompression(string srcFilePath, string desDirPath, string postfix)
        {
            if(!System.IO.File.Exists(srcFilePath)) {
                Show("非文件路径:" + srcFilePath, "FileCompression");
            } else if(!System.IO.Directory.Exists(desDirPath)) {
                Show("非目录路径:" + desDirPath, "FileCompression");
            } else {
                StreamReader sr = new StreamReader(srcFilePath);
                string gotData = sr.ReadToEnd();
                FileStream filedata = new FileStream(Path.GetFileNameWithoutExtension(srcFilePath) + "." + postfix, FileMode.Create, FileAccess.Write);
                GZipStream zip = new GZipStream(filedata, CompressionMode.Compress);
                StreamWriter sw = new StreamWriter(zip);
                sw.Write(gotData);
                sw.Close();
                zip.Close();
                sr.Close();
                sw.Close();
                filedata.Close();

                string srcCopyFilePath = g_currentPath + @"\" + Path.GetFileNameWithoutExtension(srcFilePath) + "." + postfix;
                string desCopyFilePath = desDirPath + @"\" + Path.GetFileNameWithoutExtension(srcFilePath) + "." + postfix;
                System.IO.File.Copy(srcCopyFilePath, desCopyFilePath, true);
                string fileStr = System.IO.File.ReadAllText(desCopyFilePath);
                System.IO.File.Delete(srcCopyFilePath);
            }
        }

        // 仅能解压/压缩文件，不支持解压/压缩文件夹
        public string FileDeCompression(string srcFilePath)
        {
            //将在指定相对路径Debug下，将以压缩的文件变为一个文件流
            FileStream fileCompression = System.IO.File.OpenRead("myCompression.nice");
            //将文件流解压
            GZipStream gzp = new GZipStream(fileCompression, CompressionMode.Decompress);
            //读出文件流
            StreamReader sr = new StreamReader(gzp);
            //读取出解压后的数据
            string gotData = sr.ReadToEnd();

            sr.Close();
            gzp.Close();
            fileCompression.Close();
            return gotData;
        }

        public string GetLnkPath(string lnk)
        {
            Guid CLSID_WshShell = new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8");
            if(lnk != null && System.IO.File.Exists(lnk)) {
                dynamic objWshShell = null, objShortcut = null;
                try {
                    objWshShell = Activator.CreateInstance(Type.GetTypeFromCLSID(CLSID_WshShell));
                    objShortcut = objWshShell.CreateShortcut(lnk);
                    System.Diagnostics.Process.Start(objShortcut.TargetPath);
                    return objShortcut.TargetPath;
                } finally {
                    Marshal.ReleaseComObject(objShortcut);
                    Marshal.ReleaseComObject(objWshShell);
                }
            }
            return null;
        }

        public bool S_Browser(string commonPath)
        {
            if(!System.IO.File.Exists(commonPath) || !System.IO.File.Exists(commonPath)) {
                Show("No file directory.", "Browser");
                return false;
            }
            return Browser(commonPath);
        }

        public bool Browser(string commonPath)
        {
            string browser = null;
            try {
                browser = "explorer.exe"; // 使用微软浏览器
                System.Diagnostics.Process.Start(browser, commonPath);
                return true;
            } catch {
                try {
                    browser = "chrome.exe"; // 默认使用谷歌浏览器
                    System.Diagnostics.Process.Start(browser, commonPath);
                    return true;
                } catch {
                    try {
                        browser = "iexplore.exe"; // 使用IE浏览器
                        System.Diagnostics.Process.Start(browser, commonPath);
                        return true;
                    } catch {
                        Show("您未安装谷歌、微软、IE浏览器", "Browser");
                        return false;
                    }
                }
            }
            
        }

        public bool Log(string filePath, string str)
        {
            if(str == null) {
                return false;
            }
            string parentPath = System.IO.Path.GetDirectoryName(filePath);
            if(!System.IO.Directory.Exists(parentPath)) { // 不存在目录则创建之
                System.IO.Directory.CreateDirectory(parentPath);
            }
            if(!System.IO.File.Exists(filePath)) {
                Show("!!!Log文件不存在，即将创建Log文件", "Log");
                System.IO.File.Create(filePath).Close(); // 不存在文件则新建之
            }
            String format = "yyyy-MM-dd [ddd] hh:mm:ss ffff: ";
            DateTime date = DateTime.Now;
            string time = date.ToString(format, DateTimeFormatInfo.InvariantInfo);
            string fileStr = System.IO.File.ReadAllText(filePath);
            string lostStr = fileStr + time + str + "\r\n";
            System.IO.File.WriteAllText(filePath, lostStr);
            return true;
        }

        public bool Log(string textStr)
        {
            string logPath = g_currentPath + @"\Libcore\log\error.log";
            if(textStr == null) {
                return false;
            }

            if(Log(logPath, textStr)) {
                return true;
            } else {
                return false;
            }
        }

        public string Repalce(string srcFilePath, string desFilePath)
        {
            if(!System.IO.File.Exists(srcFilePath) || !System.IO.File.Exists(desFilePath)) {
                Show("!!!Replace函数的路径未包含文件名,或文件路径不存在", "Repalce");
                return null;
            }
            System.IO.File.Copy(srcFilePath, desFilePath);
            string fileStr = System.IO.File.ReadAllText(desFilePath);
            return fileStr;
        }

        public bool Replace(string srcFilePath, string desFilePath, string srcStr, string desStr)
        {
            if(!System.IO.File.Exists(srcFilePath) || !System.IO.File.Exists(desFilePath)) {
                Show("!!!Replace函数的路径未包含文件名或该路径不存在", "Replace");
                return false ;
            }
            string fileStr = System.IO.File.ReadAllText(srcFilePath);
            string lostStr = fileStr.Replace(srcStr, desStr);
            System.IO.File.WriteAllText(desFilePath, lostStr);
            return true;
        }

        public void CreatFolder(string dirPath, string name)
        {
            if((dirPath == null) || (name == null)) {
                Show("!!!该路径为空", "CreatFolder");
                return;
            }
            string desDirPath = "";
            if(dirPath[dirPath.Length - 1] != System.IO.Path.DirectorySeparatorChar) {
                desDirPath = dirPath + @"\" + name;
            } else {
                desDirPath = dirPath + name;
            }
            // 判断目标目录是否存在如果不存在则新建之
            if(!System.IO.Directory.Exists(desDirPath)) {
                System.IO.Directory.CreateDirectory(desDirPath);
            }
        }

        public void S_CreatFolder(string dirPath, string name)
        {
            if((dirPath == null) || (name == null)) {
                Show("!!!该路径不存在", "CreatFolder");
                return;
            }
            if(!System.IO.File.Exists(dirPath)) {
                Show("!!!该路径不存在", "CreatFolder");
                return;
            }
            string desDirPath = "";
            if(dirPath[dirPath.Length - 1] != System.IO.Path.DirectorySeparatorChar) {
                desDirPath = dirPath + @"\" + name;
            } else {
                desDirPath = dirPath + name;
            }
            // 判断目标目录是否存在如果不存在则新建之
            if(!System.IO.Directory.Exists(desDirPath)) {
                System.IO.Directory.CreateDirectory(desDirPath);
            }
        }
        
        public void CopyDir(string srcPath, string desPath)
        {
            if(desPath == null) {
                return;
            }
            try {
                // 检查目标目录是否以目录分割字符结束如果不是则添加之
                if(desPath[desPath.Length - 1] != System.IO.Path.DirectorySeparatorChar) {
                    desPath += System.IO.Path.DirectorySeparatorChar;
                }

                // 判断目标目录是否存在如果不存在则新建之
                if(!System.IO.Directory.Exists(desPath)) {
                    System.IO.Directory.CreateDirectory(desPath);
                }

                // 得到源目录的文件列表，该里面是包含文件以及目录路径的一个数组
                // 如果你指向copy目标文件下面的文件而不包含目录请使用下面的方法
                string[] fileList = System.IO.Directory.GetFileSystemEntries(srcPath);

                // 遍历所有的文件和目录
                foreach(string file in fileList) {
                    // 先当作目录处理如果存在这个目录就递归Copy该目录下面的文件
                    if(System.IO.Directory.Exists(file)) {
                        CopyDir(file, desPath + System.IO.Path.GetFileName(file));
                    } else { // 否则直接Copy文件
                        System.IO.File.Copy(file, desPath + System.IO.Path.GetFileName(file), true);
                    }
                }
            } catch(Exception e) {
                throw;
            }
        }

        public void CopyDir(string srcPath, string desPath, bool isCopyFolder)
        {
            if(srcPath == null || desPath == null) {
                return;
            }
            try {
                // 检查目标目录是否以目录分割字符结束如果不是则添加之
                if (desPath[desPath.Length - 1] != System.IO.Path.DirectorySeparatorChar) {
                    desPath += System.IO.Path.DirectorySeparatorChar;
                }

                // 判断目标目录是否存在如果不存在则新建之
                if (!System.IO.Directory.Exists(desPath)) {
                    System.IO.Directory.CreateDirectory(desPath);
                }

                string[] fileList;
                // 得到源目录的文件列表，该里面是包含文件以及目录路径的一个数组
                // 如果你指向copy目标文件下面的文件而不包含目录请使用下面的方法
                if(!isCopyFolder) {
                    // 只拷贝文件，不拷贝子文件夹
                    fileList = Directory.GetFiles(srcPath);
                } else {
                    // 既拷贝文件，又拷贝子文件夹
                    fileList = System.IO.Directory.GetFileSystemEntries(srcPath);
                }

                // 遍历所有的文件和目录
                foreach (string file in fileList) {
                    // 先当作目录处理如果存在这个目录就递归Copy该目录下面的文件
                    if (System.IO.Directory.Exists(file)) {
                        if(isCopyFolder) {
                            CopyDir(file, desPath + System.IO.Path.GetFileName(file), true);
                        } else {
                            CopyDir(file, desPath + System.IO.Path.GetFileName(file), false);
                        }
                    } else { // 否则直接Copy文件
                        System.IO.File.Copy(file, desPath + System.IO.Path.GetFileName(file), true);
                    }
                }
            } catch (Exception e) {
                throw;
            }
        }
    }
}
