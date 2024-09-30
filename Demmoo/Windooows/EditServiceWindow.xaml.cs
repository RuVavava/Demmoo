using Demmoo.DB;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Demmoo.Windooows
{
    /// <summary>
    /// Логика взаимодействия для EditServiceWindow.xaml
    /// </summary>
    public partial class EditServiceWindow : Window
    {
        public static List<Service> services { get; set; }
        Service contextservise;

        public EditServiceWindow(Service services)
        {
            InitializeComponent();
            contextservise = services;
            this.DataContext = this;

            NameServiceTB.Text = contextservise.Title;
            CostServiceTB.Text = contextservise.Cost.ToString();
            TimeServiceTB.Text = contextservise.DurationInSeconds.ToString();
            SaleServiceTB.Text = contextservise.Discount.ToString();
            DegrServiceTB.Text += contextservise.Description;

        }
    }
}
