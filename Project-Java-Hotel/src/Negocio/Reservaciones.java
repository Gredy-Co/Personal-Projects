package Negocio;

import Datos.BDHuespedes;
import Datos.BDReservaciones;
import Objetos.OBJHabitaciones;
import Objetos.OBJHuespedes;
import Objetos.OBJReservaciones;
import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.List;

public class Reservaciones {

    BDReservaciones bdreservaciones = new BDReservaciones();
    BDHuespedes bdhuespedes = new BDHuespedes();

    private ArrayList<String> recomendaciones = new ArrayList<>();

    public static ArrayList<String> ActualizarDatosArchivoCSV(ArrayList<OBJReservaciones> lista) {
        ArrayList<String> datosActualizados = new ArrayList<>();
        DateFormat formato = new SimpleDateFormat("dd/MM/yyyy");

        for (OBJReservaciones reservacion : lista) {
            String fechaEn = reservacion.getFecha_Entrada() != null ? formato.format(reservacion.getFecha_Entrada()) : "";
            String fechaSal = reservacion.getFecha_Salida() != null ? formato.format(reservacion.getFecha_Salida()) : "";
            String[] habitaciones = reservacion.getNom_Hab().split(","); // Split the room numbers by comma
            for (String habitacion : habitaciones) { // Iterate over each room number
                String linea = reservacion.getCedula() + ";"
                        + reservacion.getNom_Hues() + ";"
                        + reservacion.getCant_Acom() + ";"
                        + reservacion.getPlanta() + ";"
                        + habitacion.trim() + ";" // Use the current room number
                        + reservacion.getTipo() + ";"
                        + reservacion.getPrecio() + ";"
                        + fechaEn + ";"
                        + fechaSal;
                datosActualizados.add(linea);
            }
        }

        BDReservaciones bdReservaciones = new BDReservaciones();
        bdReservaciones.ActualizarEnArchivoCSV(datosActualizados);
        return null;
    }

    public ArrayList<String> recomendarHabitaciones(int cantPersonas, Date fechaInicio, Date fechaFin) {
        ArrayList<String> recomendaciones = new ArrayList<>();

        ArrayList<ArrayList<OBJHabitaciones>> combinaciones = obtenerCombinacionesHabitaciones(cantPersonas);
        ArrayList<ArrayList<OBJHabitaciones>> combinacionesDisponibles = obtenerCombinacionesDisponibles(combinaciones, fechaInicio, fechaFin);

        for (ArrayList<OBJHabitaciones> combinacion : combinacionesDisponibles) {
            int cantidadTotal = calcularCapacidad(combinacion);

            if (cantidadTotal >= cantPersonas && cantidadTotal <= cantPersonas + 1) {
                String info = generarInformacionCombinacion(combinacion);
                recomendaciones.add(info);
            }
        }

        return recomendaciones;
    }

    public ArrayList<OBJHabitaciones> obtenerHabitacionesRecomendadas(int cantPersonas) {
        ArrayList<OBJHabitaciones> habitacionesRecomendadas = new ArrayList<>();

        if (cantPersonas == 1) {
            habitacionesRecomendadas.addAll(obtenerHabitacionesPorTipo("Junior", 1));
        } else if (cantPersonas <= 3) {
            habitacionesRecomendadas.addAll(obtenerHabitacionesPorTipo("Junior", cantPersonas));
        } else if (cantPersonas <= 10) {
            int habitacionesJunior = cantPersonas / 2;
            int habitacionesEstándar = (cantPersonas - habitacionesJunior) / 2;
            int habitacionesFamiliar = cantPersonas - habitacionesJunior - habitacionesEstándar;

            habitacionesRecomendadas.addAll(obtenerHabitacionesPorTipo("Junior", habitacionesJunior));
            habitacionesRecomendadas.addAll(obtenerHabitacionesPorTipo("Estándar", habitacionesEstándar));
            habitacionesRecomendadas.addAll(obtenerHabitacionesPorTipo("Familiar", habitacionesFamiliar));
        } else {
            habitacionesRecomendadas.addAll(obtenerHabitacionesPorTipo("Estándar", cantPersonas / 2));
            habitacionesRecomendadas.addAll(obtenerHabitacionesPorTipo("Junior", cantPersonas / 2));
            habitacionesRecomendadas.addAll(obtenerHabitacionesPorTipo("Familiar", cantPersonas / 2));
            habitacionesRecomendadas.addAll(obtenerHabitacionesPorTipo("Junior", cantPersonas - 4));
        }

        return habitacionesRecomendadas;
    }

    public ArrayList<ArrayList<OBJHabitaciones>> obtenerCombinacionesHabitaciones(int cantPersonas) {
        ArrayList<OBJHabitaciones> habitacionesRecomendadas = obtenerHabitacionesRecomendadas(cantPersonas);
        ArrayList<ArrayList<OBJHabitaciones>> combinaciones = new ArrayList<>();
        combinarHabitaciones(habitacionesRecomendadas, 0, cantPersonas, new ArrayList<>(), combinaciones);
        return combinaciones;
    }

    public ArrayList<ArrayList<OBJHabitaciones>> obtenerCombinacionesDisponibles(ArrayList<ArrayList<OBJHabitaciones>> combinaciones, Date fechaInicio, Date fechaFin) {
        ArrayList<ArrayList<OBJHabitaciones>> combinacionesDisponibles = new ArrayList<>();

        for (ArrayList<OBJHabitaciones> combinacion : combinaciones) {
            if (verificarHabitacionesDisponibles(combinacion, fechaInicio, fechaFin)) {
                combinacionesDisponibles.add(combinacion);
            }
        }

        return combinacionesDisponibles;
    }

    public String generarInformacionCombinacion(ArrayList<OBJHabitaciones> combinacion) {
        StringBuilder habitaciones = new StringBuilder();
        StringBuilder tipos = new StringBuilder();
        StringBuilder plantas = new StringBuilder();
        int precioTotal = 0;

        for (OBJHabitaciones habitacion : combinacion) {
            if (habitaciones.length() > 0) {
                habitaciones.append(", ");
                tipos.append(", ");
                plantas.append(", ");
            }
            habitaciones.append(habitacion.getNom_Hab());
            tipos.append(habitacion.getTipo());
            plantas.append(habitacion.getPlanta());
            precioTotal += habitacion.getPrecio();
        }

        return "Plantas: " + plantas + " / Habitaciones: " + habitaciones
                + " / Tipo: " + tipos + " / Cantidad: " + calcularCapacidad(combinacion)
                + " / Precio: " + precioTotal;
    }

    public ArrayList<OBJHabitaciones> obtenerHabitacionesPorTipo(String tipo, int cantPersonas) {
        ArrayList<OBJHabitaciones> habitacionesPorTipo = new ArrayList<>();
        for (OBJHabitaciones habitacion : OBJHabitaciones.listaHabitaciones) {
            if (habitacion.getTipo().equals(tipo)) {
                habitacionesPorTipo.add(habitacion);
            }
        }
        return habitacionesPorTipo;
    }

    public void combinarHabitaciones(ArrayList<OBJHabitaciones> habitacionesDisponibles, int indice, int cantPersonas, ArrayList<OBJHabitaciones> habitacionesCombinadas, ArrayList<ArrayList<OBJHabitaciones>> combinaciones) {
        if (calcularCapacidad(habitacionesCombinadas) >= cantPersonas) {
            combinaciones.add(new ArrayList<>(habitacionesCombinadas));
        } else if (indice < habitacionesDisponibles.size()) {
            OBJHabitaciones habitacionActual = habitacionesDisponibles.get(indice);

            ArrayList<OBJHabitaciones> nuevaCombinacion = new ArrayList<>(habitacionesCombinadas);
            nuevaCombinacion.add(habitacionActual);
            combinarHabitaciones(habitacionesDisponibles, indice + 1, cantPersonas, nuevaCombinacion, combinaciones);

            combinarHabitaciones(habitacionesDisponibles, indice + 1, cantPersonas, habitacionesCombinadas, combinaciones);
        }
    }

    public int calcularCapacidad(ArrayList<OBJHabitaciones> habitaciones) {
        int capacidadTotal = 0;
        for (OBJHabitaciones habitacion : habitaciones) {
            capacidadTotal += habitacion.getCapacidad();
        }
        return capacidadTotal;
    }

    private boolean esHabitacionDisponible(OBJHabitaciones habitacion, Date fechaEntrada, Date fechaSalida) {
        for (OBJReservaciones reservacion : OBJReservaciones.listaReservaciones) {
            if (reservacion.getNom_Hab().equals(habitacion.getNom_Hab())
                    && (fechaEntrada.before(reservacion.getFecha_Salida()) && fechaSalida.after(reservacion.getFecha_Entrada()))) {
                return false; // Habitación ocupada en ese periodo
            }
        }
        return true; // Habitación disponible
    }

    public boolean verificarHabitacionesDisponibles(ArrayList<OBJHabitaciones> combinacion, Date fechaInicio, Date fechaFin) {
        for (OBJHabitaciones habitacion : combinacion) {
            String[] habitacionesArray = habitacion.getNom_Hab().split(" y ");
            String[] plantasArray = habitacion.getPlanta().split(" y ");

            for (int i = 0; i < habitacionesArray.length; i++) {
                String habitacionIndividual = habitacionesArray[i].trim();
                String plantaIndividual = plantasArray[i].trim();

                Date fechaEntrada = fechaInicio;
                Date fechaSalida = fechaFin;

                if (!esHabitacionDisponible(habitacion, fechaEntrada, fechaSalida)) {
                    return false; // Al menos una habitación está ocupada en las fechas ingresadas
                }
            }
        }
        return true; // Todas las habitaciones están disponibles en las fechas ingresadas
    }

    //En esta función envío através de un return a la clase BDHabitaciones
    public ArrayList<OBJReservaciones> LeerReservacionesObjetos() {
        ArrayList<OBJReservaciones> lista = bdreservaciones.LeerDesdeArchivoObjetoCSV();
        return lista;
    }

}
