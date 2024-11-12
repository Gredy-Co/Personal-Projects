package Objetos;

import java.util.ArrayList;

public class OBJHabitaciones {

    private String Planta;
    private String Nom_Hab;
    private int Capacidad;
    private String Tipo;
    private int Precio;

    public OBJHabitaciones(String Planta, String Nom_Hab, int Capacidad, String Tipo, int Precio) {

        this.Planta = Planta;
        this.Nom_Hab = Nom_Hab;
        this.Capacidad = Capacidad;
        this.Tipo = Tipo;
        this.Precio = Precio;

    }

    public static ArrayList<OBJHabitaciones> listaHabitaciones = new ArrayList<>();

    public String getPlanta() {
        return Planta;
    }

    public void setPlanta(String Planta) {
        this.Planta = Planta;
    }

    public String getNom_Hab() {
        return Nom_Hab;
    }

    public void setNom_Hab(String Nom_Hab) {
        this.Nom_Hab = Nom_Hab;
    }

    public int getCapacidad() {
        return Capacidad;
    }

    public void setCapacidad(int Capacidad) {
        this.Capacidad = Capacidad;
    }
//

    public String getTipo() {
        return Tipo;
    }

    public void setTipo(String Tipo) {
        this.Tipo = Tipo;
    }

    public int getPrecio() {
        return Precio;
    }

    public void setPrecio(int Precio) {
        this.Precio = Precio;
    }

    public static ArrayList<OBJHabitaciones> getListaHabitaciones() {
        return listaHabitaciones;
    }

    public static void setListaHabitaciones(ArrayList<OBJHabitaciones> listaHabitaciones) {
        OBJHabitaciones.listaHabitaciones = listaHabitaciones;
    }

}
