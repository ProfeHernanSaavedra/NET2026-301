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
using Logica;

namespace PresentacionWPF.Forms
{
    /// <summary>
    /// Lógica de interacción para UcNuevoUsuario.xaml
    /// </summary>
    public partial class UcNuevoUsuario : UserControl
    {
        public UcNuevoUsuario()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            DtFechaNacimiento.DisplayDateEnd = DateTime.Today;
            DtFechaNacimiento.SelectedDate = DateTime.Today;

            CboGrupo.ItemsSource = Enum.GetValues(typeof(Clasificacion));
            CboGrupo.SelectedItem = Clasificacion.Default;

        }

        private void BtnGuardar_Click(object sender, RoutedEventArgs e)
        {
            //capturar los datos del formulario
            string nombre = TxtNombre.Text.Trim();
            string apellido = TxtApellido.Text.Trim();
            int telefono = int.Parse(TxtTelefono.Text.Trim());
            DateTime fechaNacimiento = (DateTime)DtFechaNacimiento.SelectedDate;
            Clasificacion grupo = (Clasificacion)CboGrupo.SelectedItem;

            //Validar los datos
            List<string> errores = new List<string>();

            if (nombre == string.Empty)
            {
                errores.Add("Debe ingresar un nombre para el contacto");
            }

            if (apellido == string.Empty)
            {
                errores.Add("Debe ingresar un apellido para el contacto");
            }

            
            if (errores.Count == 0)
            {
                // guardar los datos en BLL
                Persona nuevaPersona = new Persona();
                nuevaPersona.Nombre = nombre;
                nuevaPersona.Apellido = apellido;
                nuevaPersona.Telefono = telefono;
                nuevaPersona.FechaNacimiento = fechaNacimiento;
                nuevaPersona.Grupo = grupo;

                ContactoBLL cbll = new ContactoBLL();
                cbll.Agregar(nuevaPersona);

                //limpiar datos
                TxtNombre.Text = string.Empty;
                TxtApellido.Text = string.Empty;
                TxtTelefono.Text = string.Empty;
                DtFechaNacimiento.SelectedDate = DateTime.Today;
                CboGrupo.SelectedItem = Clasificacion.Default;
                //mensajes
                MessageBox.Show(nombre+" se agrego correctamente al listado","Nuevo contacto",MessageBoxButton.OK,MessageBoxImage.Information);
            }
            else
            {
                // hay errores
                string mensajesError = string.Join("\n", errores);
                MessageBox.Show(mensajesError,"Error al crear contacto",MessageBoxButton.OK,MessageBoxImage.Error);
                
            }

        }
    }
}
