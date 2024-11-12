package Objetos;

import java.util.ArrayList;
import java.util.Date;

public class OBJReservaciones {

    private int Cedula;
    private String Nom_Hues;
    private int Cant_Acom;
    private String Planta;
    private String Nom_Hab;
    private String Tipo;
    private int Precio;
    private Date Fecha_Entrada;
    private Date Fecha_Salida;

    public OBJReservaciones(int Cedula, String Nom_Hues, int Cant_Acom, String Planta, String Nom_Hab, String Tipo, int Precio, Date Fecha_Entrada, Date Fecha_Salida) {

        this.Cedula = Cedula;
        this.Nom_Hues = Nom_Hues;
        this.Cant_Acom = Cant_Acom;
        this.Planta = Planta;
        this.Nom_Hab = Nom_Hab;
        this.Tipo = Tipo;
        this.Precio = Precio;
        this.Fecha_Entrada = Fecha_Entrada;
        this.Fecha_Salida = Fecha_Salida;
    }

    public static ArrayList<OBJReservaciones> listaReservaciones = new ArrayList<>();

    public int getCedula() {
        return Cedula;
    }

    public void setCedula(int Cedula) {
        this.Cedula = Cedula;
    }

    public String getNom_Hues() {
        return Nom_Hues;
    }

    public void setNom_Hues(String Nom_Hues) {
        this.Nom_Hues = Nom_Hues;
    }

    public int getCant_Acom() {
        return Cant_Acom;
    }

    public void setCant_Acom(int Cant_Acom) {
        this.Cant_Acom = Cant_Acom;
    }

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

    public Date getFecha_Entrada() {
        return Fecha_Entrada;
    }

    public void setFecha_Entrada(Date Fecha_Entrada) {
        this.Fecha_Entrada = Fecha_Entrada;
    }

    public Date getFecha_Salida() {
        return Fecha_Salida;
    }

    public void setFecha_Salida(Date Fecha_Salida) {
        this.Fecha_Salida = Fecha_Salida;
    }

    public static ArrayList<OBJReservaciones> getListaReservaciones() {
        return listaReservaciones;
    }

    public static void setListaReservaciones(ArrayList<OBJReservaciones> listaReservaciones) {
        OBJReservaciones.listaReservaciones = listaReservaciones;
    }

}
