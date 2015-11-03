using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Biblioteka1;

namespace Biblioteka1Tests
{
    [TestClass]
    public class ZipManagerTest
    {
        [TestMethod]
        public void CompressFileToZipAndCheckZipFileExists()
        {
            string dirName = "dir";
            string zipPath = "archive.zip";

            Directory.CreateDirectory(dirName);

            ZipManager zipManager = new ZipManager();

            zipManager.CompressToZip(dirName, zipPath);

            Assert.IsTrue(File.Exists(zipPath));

            Directory.Delete(dirName);
            File.Delete(zipPath);
        }

        [TestMethod]
        public void CompressFileToZipAndCheckContentOfThisArchive()
        {
            string dirName = "dir";
            string filePath = dirName + @"\testfile.txt";
            string zipPath = "archive.zip";

            Directory.CreateDirectory(dirName);

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("This");
                sw.WriteLine("is some text");
                sw.WriteLine("to test");
                sw.WriteLine("Reading");
            }
            ZipManager zipManager = new ZipManager();

            zipManager.CompressToZip(dirName, zipPath);

            Assert.IsTrue(File.Exists(zipPath));

            Directory.Delete(dirName);
            File.Delete(zipPath);
        }
    }
}
