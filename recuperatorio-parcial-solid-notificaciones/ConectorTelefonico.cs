using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recuperatorio_parcial_solid_notificaciones
{
    public class ConectorTelefonico
    {
        public void Enviar(String destinatario, String mensaje)
        {
            //Este método se conecta a un servidor de VoIP y
            //realiza el llamado telefónico automáticamente.
            //A modo de ejemplo realiza una impresión por pantalla,
            //no es necesario modificar este método para el ejercicio
            Console.WriteLine("Se realizó el envío del mensaje " + mensaje + " por Telefono a " + destinatario);
        }
    }
}
