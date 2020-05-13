using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using OOD_Project;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOD_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// @\\Client\H$\Year 2 Programming\OOD Project\OOD Project\bin\Debug\OODProject.txt"
    public partial class MainWindow : Window
    {
        ModelContainer db = new ModelContainer();



        List<Stock> allProducts = new List<Stock>();
        List<Margin> allProduct = new List<Margin>();

        public decimal ProfitMarginp { get; private set; }
        public decimal ProfitMargin { get; private set; }
        

        public MainWindow()
        {
            InitializeComponent();
        }


        

        private void LbxProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //issue here
            //Product selectedProduct = LbxProducts.SelectedItem as Product;
            Stock selectedProduct = LbxProducts.SelectedItem as Stock;
            Margin selectedProducts = LbxProducts.SelectedItem as Margin;

            //Null Check
            if (LbxProducts.SelectedItem != null)
            {
                //Get selection


                //Set products listbox to display right information


                //Display products information
                DisplayCaseSize.Text = "Case size                : " + selectedProduct.CaseSize;
                DisplayStockLeft.Text = "Stock left                : " + selectedProduct.StockLeft;
                DisplaySupplier.Text = "Supplier                  : " + selectedProduct.Supplier;
                DisplayOrderDay.Text = "Order Day               : " + selectedProduct.OrderDay;
                
                using (ModelContainer context = new ModelContainer())
                {
                    Margin selectedMargin = context.Margins.FirstOrDefault(p => p.ProductID == selectedProduct.ProductID);
                    DisplayUnitCost.Text = "Unit Cost                 : €" + selectedMargin.UnitCost.ToString("N2");
                    DisplayUnitSell.Text = "Unit Sell                   : €" + selectedMargin.UnitSell.ToString("N2");
                   
                    ProfitMarginp = (((selectedMargin.UnitSell - selectedMargin.UnitCost) / (selectedMargin.UnitSell)) * 100);
                    ProfitMargin = (selectedMargin.UnitSell - selectedMargin.UnitCost);
                    DisplayProfitMargin.Text = "Profit Margin           : €" + ProfitMargin.ToString("N2");
                    DisplayProfitMarginp.Text = "Profit Margin           : %" + ProfitMarginp.ToString("N2");
                }



            }
        }

        //Runs when window loads
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //CbxSection.ItemsSource = Enum.GetNames(typeof(Variation));

            using (ModelContainer context = new ModelContainer())
            {
                //Get Sections from Database and assign to drop down
                CbxSection.ItemsSource = context.Stocks.Select(x => x.Section).Distinct().ToList();
                // Get Products From Database
                allProducts.AddRange(context.Stocks.ToList());
            }
            //Display
            LbxProducts.ItemsSource = allProducts;


        }

        private void CbxSection_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //Check if something is selected
            if (CbxSection.SelectedValue == null)
            {
                // if nothing selected show all
                LbxProducts.ItemsSource = allProducts;
            }
            else
            {
                // filter by section selected in drop down
                LbxProducts.ItemsSource = allProducts.Where(p => p.Section == CbxSection.SelectedValue.ToString()).ToList();
            }

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Your Orders been placed!");
        }
    }
}

