using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TextClassificationGUI._1_Controller;
using TextClassificationGUI.Controller;
using TextClassificationGUI.Domain;
using TextClassificationGUI.Foundation;

namespace TextClassificationGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        KnowledgeBuilder nb;
        Knowledge knowledge;
        BagOfWords bof;
        List<string> entries;
        private ObservableData _observableData = new ObservableData();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = _observableData;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            long t1 = TimeUtils.GetNanoseconds();
            nb = new KnowledgeBuilder();
            nb.Train();
            long duration = TimeUtils.GetNanoseconds() - t1;
            trainTimeTextBox.Text = "Time: " + (duration / 1000 / 1000) + "ms";

            knowledge = nb.GetKnowledge();
            bof = knowledge.GetBagOfWords();
            entries = bof.GetEntriesInDictionary();
            _observableData.ObservableDictionaryList = new ObservableCollection<string>(entries);

        }
    }
}
