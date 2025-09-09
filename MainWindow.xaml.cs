using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ContractClaimSystem
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
        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Claim Submitted (Prototype Only)");
        }

        private void UploadDocument_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Document Uploaded (Prototype Only)");
        }

        private void ApproveClaim_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Claim Approved (Prototype Only)");
        }
    }
}
