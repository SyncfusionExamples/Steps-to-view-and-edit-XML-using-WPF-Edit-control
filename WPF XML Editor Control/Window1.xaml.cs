
using System.Windows;
using System.Windows.Media;
using Syncfusion.Windows.Edit;

namespace EditControlDemo
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        #region Constructor

        /// <summary>
        /// Window Constructor and events initialization
        /// </summary>
        public Window1()
        {
            InitializeComponent();
            editControl1.DocumentLanguage = Languages.Custom;
            editControl1.LoadFile("../../Products.xml");
            XMLLanguage xmlLanguage = new XMLLanguage(editControl1);
            xmlLanguage.Lexem = this.Resources["XMLLexems"] as LexemCollection;
            xmlLanguage.Formats = this.Resources["XMLFormats"] as FormatsCollection;
            //Binds the xml language in EditControl
            editControl1.CustomLanguage = xmlLanguage;
        }

        #endregion

        #region Events

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        #endregion
    }

    /// <summary>
    /// XML language class contains implementations related to custom language implementations
    /// </summary>
    public class XMLLanguage : MarkupLanguageBase
    {
        #region Initialization

        /// <summary>
        /// Initializes a new instance of the <see
        /// cref="T:XMLLanguage">XMLLangauge</see> class.
        /// </summary>
        /// <param name="control">represents the EditControl to which to which this instance
        /// has to be hooked</param>
        public XMLLanguage(EditControl control)
            : base(control)
        {
            this.Name = "XML";
            this.FileExtension = "xml";
            this.ApplyColoring = true;
            this.TextForeground = Brushes.Brown;
        }

        #endregion
    }
}
