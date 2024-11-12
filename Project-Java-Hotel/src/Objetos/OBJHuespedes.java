package Objetos;

import java.util.ArrayList;

public class OBJHuespedes {

    private int Cedula;
    private String Nombre;
    private String Contrase�a;
    private String Genero;
    private String Correo;
    private String Rol;

    public OBJHuespedes(int Cedula, String Nombre, String Contrase�a, String Genero, String Correo, String Rol) {

        this.Cedula = Cedula;
        this.Nombre = Nombre;
        this.Contrase�a = Contrase�a;
        this.Genero = Genero;
        this.Correo = Correo;
        this.Rol = Rol;

    }

    public static ArrayList<OBJHuespedes> listaHuespedes = new ArrayList<>();

    public int getCedula() {
        return Cedula;
    }

    public void setCedula(int Cedula) {
        this.Cedula = Cedula;
    }

    public String getNombre() {
        return Nombre;
    }

    public void setNombre(String Nombre) {
        this.Nombre = Nombre;
    }

    public String getContrase�a() {
        return Contrase�a;
    }

    public void setContrase�a(String Contrase�a) {
        this.Contrase�a = Contrase�a;
    }

    public String getGenero() {
        return Genero;
    }

    public void setGenero(String Genero) {
        this.Genero = Genero;
    }

    public String getCorreo() {
        return Correo;
    }

    public void setCorreo(String Correo) {
        this.Correo = Correo;
    }

    public String getRol() {
        return Rol;
    }

    public void setRol(String Rol) {
        this.Rol = Rol;
    }

    public static ArrayList<OBJHuespedes> getListaHuespedes() {
        return listaHuespedes;
    }

    public static void setListaHuespedes(ArrayList<OBJHuespedes> listaHuespedes) {
        OBJHuespedes.listaHuespedes = listaHuespedes;
    }

}
