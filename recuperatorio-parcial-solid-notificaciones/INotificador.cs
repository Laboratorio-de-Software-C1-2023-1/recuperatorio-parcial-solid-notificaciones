using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recuperatorio_parcial_solid_notificaciones
{
    public interface INotificador
    {
        public void Notificar(String destinatario, String mensaje);
        public void Llamar(String destinatario, String mensaje);
    }
}
