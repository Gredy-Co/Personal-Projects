package Datos;

import Objetos.OBJHuespedes;
import Objetos.OBJReservaciones;
import static Objetos.OBJReservaciones.listaReservaciones;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.Properties;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.mail.Authenticator;
import javax.mail.Message;
import javax.mail.MessagingException;
import javax.mail.PasswordAuthentication;
import javax.mail.Session;
import javax.mail.Transport;
import javax.mail.internet.AddressException;
import javax.mail.internet.InternetAddress;
import javax.mail.internet.MimeMessage;
import javax.swing.JOptionPane;

public class BDReservaciones {

    private static String emailFrom = "greddymendoza2@gmail.com";
    private static String passwordFrom = "zqyhpmpmcjhctpji";

    private Properties mProperties = new Properties();
    private Session mSession;
    private MimeMessage mCorreo;
    private BDHuespedes bdhuespedes = new BDHuespedes();

    // Función para actualizar el archivo csv
    public void ActualizarEnArchivoCSV(ArrayList<String> datosActualizados) {
        try {
            FileWriter archivo = new FileWriter("Archivos/Reservaciones.csv", false); // False para Sobreescribir
            BufferedWriter archi = new BufferedWriter(archivo);
            for (String linea : datosActualizados) {
                archi.write(linea + "\n");
            }
            archi.close();
        } catch (IOException e) {
            JOptionPane.showMessageDialog(null, "Error al escribir en el archivo",
                    "Mensaje de error", JOptionPane.ERROR_MESSAGE);
        }
    }

    // Esta función permite meter los datos en un arreglo 
    public ArrayList<OBJReservaciones> LeerDesdeArchivoObjetoCSV() {
        String line = "";
        String csvSplitBy = ";";

        try (BufferedReader br = new BufferedReader(new FileReader("Archivos/Reservaciones.csv"))) {
            while ((line = br.readLine()) != null) {

                String[] datos = line.split(csvSplitBy);

                if (datos.length < 7) {
                    // La línea no contiene todos los campos esperados, así que omito el proceso
                    continue;
                }

                int Cedula = Integer.parseInt(datos[0]);
                String Nom_Hues = datos[1];
                int Cant_Acom = Integer.parseInt(datos[2]);
                String Planta = datos[3];
                String Nom_Hab = datos[4];
                String Tipo = datos[5];
                int Precio = Integer.parseInt(datos[6]);

                Date fechaE = null;
                Date fechaS = null;

                if (datos.length >= 7 && !datos[7].isEmpty()) {
                    fechaE = new SimpleDateFormat("dd/MM/yyyy").parse(datos[7]);
                }
                if (datos.length >= 8 && !datos[8].isEmpty()) {
                    fechaS = new SimpleDateFormat("dd/MM/yyyy").parse(datos[8]);
                }

                // Creo un objeto OBJReservaciones con los datos leídos
                OBJReservaciones cantante = new OBJReservaciones(Cedula, Nom_Hues, Cant_Acom, Planta, Nom_Hab, Tipo, Precio, fechaE, fechaS);
                listaReservaciones.add(cantante);

            }
        } catch (IOException e) {
            e.printStackTrace();

        } catch (ParseException e) {
            e.printStackTrace();
        }

        return listaReservaciones;
    }

    //Aquí creo el cuerpo del correo, con los datos de las habitaciones que reservó
    public void enviarCorreo(int cedulaInt) {
        for (OBJHuespedes huesped : bdhuespedes.LeerDesdeArchivoObjetoCSV()) {
            if (huesped.getCedula() == cedulaInt) {
                String destinatario = huesped.getCorreo();
                String nombreHuesped = huesped.getNombre();

                // Obtenengo los detalles de la reserva
                ArrayList<String> detallesReserva = ObtenerDetallesReserva(cedulaInt);

                // Construyo el contenido del correo
                String asunto = "Confirmación de reserva en el Hotel";
                String mensaje = "Estimado(a) " + nombreHuesped + ",\n\n"
                        + "Su reserva ha sido confirmada. A continuación, se detallan los datos de su reserva:\n\n"
                        + "Detalles de la reserva:\n" + String.join("\n", detallesReserva) + "\n\n"
                        + "¡Esperamos que disfrute su estadía en nuestro hotel!\n\n"
                        + "Saludos,\n"
                        + "El equipo del Hotel";

                enviarCorreo(destinatario, asunto, mensaje);
                break; // Terminar el bucle después de encontrar el huésped
            }
        }
    }

    //Aquí se envía el correo a la bandeja de entrada del huesped
    private void enviarCorreo(String destinatario, String asunto, String mensaje) {
        // Configuración de las propiedades para el servidor de correo saliente (SMTP)
        mProperties.put("mail.smtp.host", "smtp.gmail.com"); // Cambia esto al servidor SMTP que uses
        mProperties.put("mail.smtp.ssl.trust", "smtp.gmail.com"); // Cambia esto al servidor SMTP que uses
        mProperties.setProperty("mail.smtp.starttls.enable", "true"); // Habilitar TLS
        mProperties.setProperty("mail.smtp.port", "587"); // Puerto SMTP (generalmente 587 para TLS)
        mProperties.setProperty("mail.smtp.user", "");
        mProperties.setProperty("mail.smtp.ssl.protocols", "TLSv1.2"); // Cambio en el protocolo TLS
        mProperties.setProperty("mail.smtp.auth", "true"); // Autenticación requerida

        mSession = Session.getDefaultInstance(mProperties);

        try {
            mCorreo = new MimeMessage(mSession);
            mCorreo.setFrom(new InternetAddress(emailFrom));
            mCorreo.setRecipient(Message.RecipientType.TO, new InternetAddress(destinatario));
            mCorreo.setSubject(asunto);
            mCorreo.setText(mensaje, "ISO-8859-1", "html");

            // Enviar el correo
            Transport mTransport = mSession.getTransport("smtp");
            mTransport.connect(emailFrom, passwordFrom);
            mTransport.sendMessage(mCorreo, mCorreo.getRecipients(Message.RecipientType.TO));
            mTransport.close();

            System.out.println("Correo enviado exitosamente a: " + destinatario);
        } catch (MessagingException ex) {
            Logger.getLogger(BDReservaciones.class.getName()).log(Level.SEVERE, null, ex);
        }
    }

    public ArrayList<String> ObtenerDetallesReserva(int cedulaInt) {
        ArrayList<String> detallesReserva = new ArrayList<>();

        for (OBJReservaciones reserva : listaReservaciones) {
            if (reserva.getCedula() == cedulaInt) {
                String detalle = "Planta: " + reserva.getPlanta()
                        + ", Habitación: " + reserva.getNom_Hab()
                        + ", Tipo: " + reserva.getTipo()
                        + ", Precio Total: " + reserva.getPrecio() + "$"
                        + ", Fecha de Entrada: " + new SimpleDateFormat("dd/MM/yyyy").format(reserva.getFecha_Entrada())
                        + ", Fecha de Salida: " + new SimpleDateFormat("dd/MM/yyyy").format(reserva.getFecha_Salida());
                detallesReserva.add(detalle);
            }
        }

        return detallesReserva;
    }

}
