using System;
using System.Windows;
using System.Windows.Controls;
using Negocio;

namespace Presentacion.Forms
{
    public partial class UcTarea : UserControl
    {
        public UcTarea()
        {
            InitializeComponent();
            CmbCategoria.ItemsSource = new CategoriaBLL().GetAll();
        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CmbCategoria.SelectedValue == null)
                    throw new ArgumentException("Seleccione una categoría. Si no existe, créela en Categorías.");
                new TareaBLL().Add(TxtTitulo.Text, TxtCuerpo.Text,
                    DtpVencimiento.SelectedDate, (int)CmbCategoria.SelectedValue);
                MessageBox.Show("Tarea guardada correctamente.", "Nueva tarea");
                TxtTitulo.Clear();
                TxtCuerpo.Clear();
                DtpVencimiento.SelectedDate = null;
                CmbCategoria.SelectedIndex = -1;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Nueva tarea", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar la tarea: " + ex.Message,
                    "Nueva tarea", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
