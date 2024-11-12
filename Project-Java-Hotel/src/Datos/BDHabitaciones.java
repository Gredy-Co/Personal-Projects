package Datos;

import Objetos.OBJHabitaciones;
import static Objetos.OBJHabitaciones.listaHabitaciones;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import javax.swing.JOptionPane;

public class BDHabitaciones {

    // Función para actualizar el archivo csv
    public void ActualizarEnArchivoCSV(ArrayList<String> datosActualizados) {
        try {
            FileWriter archivo = new FileWriter("Archivos/Habitaciones.csv", false); // False para Sobreescribir
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

    public ArrayList<OBJHabitaciones> LeerDesdeArchivoObjetoCSV() {
        String line = "";
        String csvSplitBy = ";";

        try (BufferedReader br = new BufferedReader(new FileReader("Archivos/Habitaciones.csv"))) {
            while ((line = br.readLine()) != null) {
                String[] datos = line.split(csvSplitBy);

                if (datos.length < 5) {
                    // La línea no contiene todos los campos esperados, así que omito el proceso
                    continue;
                }

                String Planta = datos[0];
                String Nom_Hab = datos[1];
                int Capacidad = 0;  // Valor por defecto si hay un problema
                if (!datos[2].isEmpty()) {
                    Capacidad = Integer.parseInt(datos[2]);
                }
                String Tipo = datos[3];
                int Precio = 0;  // Valor por defecto si hay un problema
                if (!datos[4].isEmpty()) {
                    Precio = Integer.parseInt(datos[4]);
                }

                // Creo un objeto OBJHabitaciones con los datos leídos
                OBJHabitaciones habitacion = new OBJHabitaciones(Planta, Nom_Hab, Capacidad, Tipo, Precio);
                listaHabitaciones.add(habitacion);
            }
        } catch (IOException e) {
            e.printStackTrace();
        }

        return listaHabitaciones;
    }
}
