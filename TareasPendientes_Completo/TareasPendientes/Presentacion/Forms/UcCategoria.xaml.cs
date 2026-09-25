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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Negocio;

namespace Presentacion.Forms
{
    /// <summary>
    /// Lógica de interacción para UcCategoria.xaml
    /// </summary>
    public partial class UcCategoria : UserControl
    {
        CategoriaBLL catBLL = new CategoriaBLL();

        public UcCategoria()
        {
            InitializeComponent();
            ListarCategorias();
        }

        public void ListarCategorias()
        {
            LstCatgoria.ItemsSource = catBLL.GetAll();
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string nombre = TxtNombre.Text.Trim();
                catBLL.Add(nombre);

                MessageBox.Show("Categoria Agregada", "Nueva Categoria", MessageBoxButton.OK, MessageBoxImage.Information);
                TxtNombre.Text = string.Empty;
                ListarCategorias();
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message,"Nueva Categoría",MessageBoxButton.OK,MessageBoxImage.Error);
            }

        }

        private void BtnEliminar_Click(object sender, RoutedEventArgs e)
        {
            string nombre = LstCatgoria.SelectedItem.ToString();

            catBLL.Delete(nombre);
            ListarCategorias();
        }
    }
}
