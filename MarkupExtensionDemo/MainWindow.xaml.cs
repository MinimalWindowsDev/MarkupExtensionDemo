using System.ComponentModel;
using System.Windows;

namespace MarkupExtensionDemo
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private int _clickCount;

        public event PropertyChangedEventHandler PropertyChanged;

        public int ClickCount
        {
            get => _clickCount;
            set
            {
                _clickCount = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(ClickCount)));
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
#if fix_issue_001
                ClickCount += 2;
                MessageBox.Show($"Incremented by 2! New count: {ClickCount}");
#else
            ClickCount += 1;
            MessageBox.Show($"Incremented by 1! New count: {ClickCount}");
#endif
        }
    }
}