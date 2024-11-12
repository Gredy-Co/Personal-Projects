package Negocio;

import Datos.BDHabitaciones;
import Objetos.OBJHabitaciones;
import java.util.ArrayList;

public class Habitaciones {

    BDHabitaciones bdhabitaciones = new BDHabitaciones();

    // Esta función me permite Actualizar los datos de una Habitación  
    public static ArrayList<String> ActualizarDatosArchivoCSV(ArrayList<OBJHabitaciones> lista) {
        ArrayList<String> datosActualizados = new ArrayList<>();

        for (OBJHabitaciones habitacion : lista) {
            String linea = habitacion.getPlanta() + ";"
                    + habitacion.getNom_Hab() + ";"
                    + habitacion.getCapacidad() + ";"
                    + habitacion.getTipo() + ";"
                    + habitacion.getPrecio();

            datosActualizados.add(linea);
        }

        BDHabitaciones bdHuespedes = new BDHabitaciones();
        bdHuespedes.ActualizarEnArchivoCSV(datosActualizados);
        return null;
    }

    //En esta función envío através de un return a la clase BDHabitaciones
    public ArrayList<OBJHabitaciones> LeerHabitacionesObjetos() {
        ArrayList<OBJHabitaciones> lista = bdhabitaciones.LeerDesdeArchivoObjetoCSV();
        return lista;
    }

}
