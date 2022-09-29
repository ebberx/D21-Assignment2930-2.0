using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using TextClassificationGUI.Controller;
using TextClassificationGUI.Domain;
using TextClassificationGUI.FileIO;
using TextClassificationGUI.Foundation;

namespace Test
{
    [TestClass]
    public class Testing
    {

        [TestMethod]
        public void TestWordItemGetWord()
        {
            // arrange
            string expected = "nice";
            WordItem wI = new WordItem("nice", 0);

            // act
            string actual = wI.GetWord();

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestStringOperationsGetFileName()
        {
            // deprecated - use 
            // arrange
            string expected = "Suduko";
            string path = "c:\\users\\allan\\documents\\Suduko.txt";

            // act
            string actual = StringOperations.getFileName(path);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestFileGetAllFileNames()
        {
            // arrange
            string folderA = "ClassA";
            string fileType = "txt";
            List<string> expected = new List<string>();
            string Path = System.IO.Path.GetFullPath(@"..\..\..\..\res\");

            expected.Add(Path + folderA + "\\bbcsportsfootball." + fileType);
            expected.Add(Path + folderA + "\\dailymirrornfl." + fileType);
            expected.Add(Path + folderA + "\\sunsportsboxing." + fileType);

            // act
            FileAdapter fa = new TextFile(fileType);
            List<string> actual = fa.GetAllFileNames(folderA);

            // assert
            Assert.AreEqual(expected.Count, actual.Count);
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);
            Assert.AreEqual(expected[2], actual[2]);
        }
        [TestMethod]
        public void TestGetFilePathA()
        {
            string Path = System.IO.Path.GetFullPath(@"..\..\..\..\res\");
            // arrange
            string folderA = "ClassA";
            string fileType = "txt";
            string fileName = "filnavn";
            string expected = Path + folderA + "\\filnavn." + fileType;

            // act
            TextFile tf = new TextFile(fileType);
            string actual = tf.GetFilePathA(fileName);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetFileName()
        {
            string BasePath = System.IO.Path.GetFullPath(@"..\..\..\res\");
            string path = BasePath + "ClassB\\Snow White.txt";

            string expected = "Snow White";
            string actual = StringOperations.getFileName(path);

            Assert.AreEqual(expected, actual);
        }



    }
}
