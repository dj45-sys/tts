using System.Windows;
using System.Speech.Synthesis;

namespace tts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        SpeechSynthesizer speechSynthesizerObj;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            speechSynthesizerObj = new SpeechSynthesizer();
            //Asynchronously speaks the contents present in RichTextBox1   
            speechSynthesizerObj.SpeakAsync(InputTTS.Text);
        }
    }
}
