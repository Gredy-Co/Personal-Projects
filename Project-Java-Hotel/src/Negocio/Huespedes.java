package Negocio;

import Datos.BDHuespedes;
import Objetos.OBJHuespedes;
import java.util.ArrayList;

public class Huespedes {

    BDHuespedes bdhuespedes = new BDHuespedes();

    // Esta funci�n me permite insertar el nuevo cantante en el archivo csv
    public void InsertarNuevoHuesped(ArrayList<OBJHuespedes> listaHuespedes) {
        StringBuilder datosConcatenados = new StringBuilder();

        for (int i = 0; i < listaHuespedes.size(); i++) {
            OBJHuespedes huesped = listaHuespedes.get(i);
            String datosHuesped = huesped.getCedula() + ";"
                    + huesped.getNombre() + ";"
                    + huesped.getContrase�a() + ";"
                    + huesped.getGenero() + ";"
                    + huesped.getCorreo() + ";"
                    + huesped.getRol();

            datosConcatenados.append(datosHuesped);

            if (i < listaHuespedes.size() - 1) {
                datosConcatenados.append("\n");
            }
        }

        BDHuespedes bdHuespedes = new BDHuespedes();
        bdHuespedes.InsertarEnArchivoCSV(datosConcatenados.toString());
    }

    // Esta funci�n me permite Actualizar los datos de un cantante ya existente 
    public static ArrayList<String> ActualizarDatosArchivoCSV(ArrayList<OBJHuespedes> lista) {
        ArrayList<String> datosActualizados = new ArrayList<>();

        for (OBJHuespedes huesped : lista) {
            String linea = huesped.getCedula() + ";"
                    + huesped.getNombre() + ";"
                    + huesped.getContrase�a() + ";"
                    + huesped.getGenero() + ";"
                    + huesped.getCorreo() + ";"
                    + huesped.getRol();
            datosActualizados.add(linea);
        }

        BDHuespedes bdHuespedes = new BDHuespedes();
        bdHuespedes.ActualizarEnArchivoCSV(datosActualizados);
        return null;
    }

    //En esta funci�n env�o atrav�s de un return a la clase BDCantantes
    public ArrayList<OBJHuespedes> LeerHuespedesObjetos() {
        ArrayList<OBJHuespedes> lista = bdhuespedes.LeerDesdeArchivoObjetoCSV();
        return lista;
    }

}
