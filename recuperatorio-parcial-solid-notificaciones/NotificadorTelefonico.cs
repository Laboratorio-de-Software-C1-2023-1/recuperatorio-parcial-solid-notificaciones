using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recuperatorio_parcial_solid_notificaciones
{
    public class NotificadorTelefonico : INotificador
    {
        private ConectorTelefonico conector;
        public NotificadorTelefonico()
        {
            this.conector = new ConectorTelefonico();
        }
        public void Notificar(string destinatario, string mensaje)
        {
            throw new NotImplementedException();
        }
        public void Llamar(String destinatario, String mensaje)
        {
            this.conector.Enviar(destinatario, mensaje);
        }
    }
}
