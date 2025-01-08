using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_ControlesBasicosYEventos
{
    public partial class FrInicio : Form
    {
        public FrInicio()
        {
            InitializeComponent();
        }

        //Un Método especial, que indica cuando se va a ejecutar en su nombre, se va a ejecutar cuando se haga click "Click" en el Botón "BtnSaludar" separado con un guion bajo "_".
        private void BtnMensaje_Click(object sender, EventArgs e)
        {
            //Ahora lo que usaremos será una Clase estática "MessageBox" con su Método "Show()", que sería como el Console.WriteLine(), pero esta vez en Interfaz Gráfica.
            MessageBox.Show("Hola Mundo!");
        }

        //Este Método especial es denominado un "Evento", un Evento es un Método asociado hacia un determinado contexto, que en este caso el determinado contexto es al hacer Click en el Botón.
        //Hablando de Eventos, este concepto está presente en la Programación muchas veces, los "Controles" tienen Eventos también, pero como el botón no solo tiene el Evento de "Click", también está cuando se pasa por encima el mouse hará algo, cuando haces click derecho, etc.
        //Nosotros para ver los Eventos de cada elemento, los Eventos del Botón, debemos hacer click derecho en el Botón e ir a las Propiedades, dentro de la sección de Propiedades aparecerá un rayito "⚡" si ponemos el mouse ahí sin hacer click mostrará un cartel (un Evento) que dirá "Eventos". Vamos ahí, y nos aparecerá todos los Eventos posibles que tiene el Botón.
        //Cuando se puso el Control Botón en el Formulario e hicimos doble click nos aparece un Evento, que ese Evento es uno por defult, es el Evento el cual se espera configurar por estar más relacionado al Botón.
        //Ahora vendrá un Evento del Formulario cuando se inicia la App.
        private void FrInicio_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenido a mi app. :)");
        }

        //Ahora un Evento del Formulario cuando se cierra la app.
        private void FrInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Gracias por usar la app. :)");
        }

        //También si queremos reutilizar el Evento, podemos ir a Eventos y seleccionar el de Click y veremos que habrá opciones de Eventos disponibles, y se puede seleccionar el Evento del Botón.

        //Agregaremos otro botón que salude al usuario
        private void btnSaludar_Click(object sender, EventArgs e)
        {
            //Lo que se hará es gaurdar en una variable, lo que tiene la Propiedad Text el Control llamado "TxtbNombre".
            string nombre = TxtbNombre.Text;
            MessageBox.Show("Hola " + nombre);
        }

    }
}
