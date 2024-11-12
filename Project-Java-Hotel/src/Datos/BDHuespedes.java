package Datos;

import Objetos.OBJHuespedes;
import static Objetos.OBJHuespedes.listaHuespedes;
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;
import java.util.ArrayList;
import javax.swing.JOptionPane;

public class BDHuespedes {

    // Función para insertar a nuevos Huespedes en el archivo CSV
    public void InsertarEnArchivoCSV(String datosUsuario) {
        try {
            FileWriter archivo = new FileWriter("Archivos/Huespedes.csv", true);
            BufferedWriter archi = new BufferedWriter(archivo);
            archi.write(datosUsuario + "\n");
            archi.close();
        } catch (IOException e) {
            JOptionPane.showMessageDialog(null, "Error al escribir en el archivo",
                    "Mensaje de error", JOptionPane.ERROR_MESSAGE);
        }
    }

    // Función para actualizar el archivo csv
    public void ActualizarEnArchivoCSV(ArrayList<String> datosActualizados) {
        try {
            FileWriter archivo = new FileWriter("Archivos/Huespedes.csv", false); // False para Sobreescribir
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
    public ArrayList<OBJHuespedes> LeerDesdeArchivoObjetoCSV() {
        String line = "";
        String csvSplitBy = ";";

        try (BufferedReader br = new BufferedReader(new FileReader("Archivos/Huespedes.csv"))) {
            while ((line = br.readLine()) != null) {

                String[] datos = line.split(csvSplitBy);

                if (datos.length < 6) {
                    // La línea no contiene todos los campos esperados, así que omito el proceso
                    continue;
                }

                int Cedula = Integer.parseInt(datos[0]);
                String Nombre = datos[1];
                String Contraseña = datos[2];
                String Genero = datos[3];
                String Correo = datos[4];
                String Rol = datos[5];

                // Creo un objeto OBJCantantes con los datos leídos
                OBJHuespedes huesped = new OBJHuespedes(Cedula, Nombre, Contraseña, Genero, Correo, Rol);
                listaHuespedes.add(huesped);

            }
        } catch (IOException e) {
            e.printStackTrace();

        }

        return listaHuespedes;
    }

}
