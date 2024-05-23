using BlankADMI.Setups;
using NITHdmis.Template;
using System.Windows;

namespace BlankADMI
{
    /// <summary>
    /// Interaction logic for the instrument window
    /// </summary>
    public partial class InstrumentWindow : Window
    {
        private ISetup Setup;

        public InstrumentWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This method will be called when the window finished loading. A good moment to call a setup
        /// </summary>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Setup = new DefaultSetup(this);
            Setup.Setup();
        }
    }
}