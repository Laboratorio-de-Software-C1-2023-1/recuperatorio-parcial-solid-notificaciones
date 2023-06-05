using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recuperatorio_parcial_solid_notificaciones
{
    public class NotificadorEmail : INotificador
    {
        private ConectorEmail conector;
        public NotificadorEmail()
        {
            this.conector = new ConectorEmail();
        }
        public void Notificar(String destinatario, String mensaje)
        {
            this.conector.Enviar(destinatario, mensaje);
        }
        public void Llamar(string destinatario, string mensaje)
        {
            throw new NotImplementedException();
        }
    }
}
