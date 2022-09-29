using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TextClassificationGUI.Controller;
using TextClassificationGUI.Domain;
using System.Linq;
using TextClassificationGUI.Foundation;
using WpfAppTextClassification.Tools;

namespace TextClassificationGUI._1_Controller
{
    public class ObservableData : Bindable
    {
        private ObservableCollection<string> _observableA;
        private ObservableCollection<string> _observableB;

        public ObservableData()
        {
            FileListBuilder fileListBuilder = new FileListBuilder();
            fileListBuilder.GenerateFileNamesInA();
            fileListBuilder.GenerateFileNamesInB();
            FileLists fileLists = fileListBuilder.GetFileLists();

            _observableA = new ObservableCollection<string>(fileLists.GetA().Select(StringOperations.getFileName));
            _observableB = new ObservableCollection<string>(fileLists.GetB().Select(StringOperations.getFileName));
        }

        public ObservableCollection<string> ObservableA
        {
            get => _observableA;
            set
            {
                _observableA = value;
                PropertyIsChanged();
            }
        }

        public ObservableCollection<string> ObservableB
        {
            get => _observableB;
            set
            {
                _observableB = value;
                PropertyIsChanged();
            }
        }
    }
}
