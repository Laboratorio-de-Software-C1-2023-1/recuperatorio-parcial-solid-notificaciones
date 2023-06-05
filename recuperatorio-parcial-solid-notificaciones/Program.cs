using recuperatorio_parcial_solid_notificaciones;

INotificador notificadorEmail = new NotificadorEmail();
notificadorEmail.Notificar("test@test.com", "Le comunicamos que su trámite ha sido dado de alta correctamente");

INotificador notificadorTelefonico = new NotificadorTelefonico();
notificadorTelefonico.Llamar("+551184752297", "Le comunicamos que su trámite ha sido dado de alta correctamente");
