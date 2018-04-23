using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace DXSample {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        TestDBEntities TestEntities { get; set; }
        public MainWindow() {
            InitializeComponent();
            TestEntities = new TestDBEntities();
            foreach(TestTable item in TestEntities.TestTables) {
                DataContext = item;
                break;
            }
        }

        private void OnEditValueChanged(object sender, DevExpress.Xpf.Editors.EditValueChangedEventArgs e) {
            TestEntities.SaveChanges();
        }
    }
}
