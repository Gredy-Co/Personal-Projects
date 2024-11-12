package Presentacion;

import Datos.BDReservaciones;
import Negocio.Reservaciones;
import static Negocio.Reservaciones.ActualizarDatosArchivoCSV;
import Objetos.OBJHabitaciones;
import Objetos.OBJHuespedes;
import static Objetos.OBJHuespedes.listaHuespedes;
import Objetos.OBJReservaciones;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;
import java.util.HashSet;
import java.util.Set;
import javax.swing.JOptionPane;
import javax.swing.event.ListSelectionEvent;
import javax.swing.event.ListSelectionListener;
import javax.swing.table.DefaultTableModel;

public class ReservasVentana extends javax.swing.JFrame {

    private String cedula;
    private boolean guardar = false;
    Reservaciones reservas = new Reservaciones();
    BDReservaciones reservaciones = new BDReservaciones();

    private ArrayList<String> recomendaciones = new ArrayList<>();

    public ReservasVentana() {
        initComponents();
        seleccion();
        setLocationRelativeTo(null);

        Calendar calendar = Calendar.getInstance();
        calendar.set(Calendar.MONTH, Calendar.FEBRUARY);
        calendar.set(Calendar.DAY_OF_MONTH, 1);
        FechaEnt.setCalendar(calendar);
        FechaSali.setCalendar(calendar);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        btnGuardar = new javax.swing.JButton();
        jLabel1 = new javax.swing.JLabel();
        FechaEnt = new com.toedter.calendar.JDateChooser();
        btnBuscar = new javax.swing.JButton();
        jLabel2 = new javax.swing.JLabel();
        jSpinner1 = new javax.swing.JSpinner();
        jScrollPane1 = new javax.swing.JScrollPane();
        tbMostrar = new javax.swing.JTable();
        FechaSali = new com.toedter.calendar.JDateChooser();
        jLabel3 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        jLabel5 = new javax.swing.JLabel();
        btnAtrás = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jPanel1.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        btnGuardar.setBackground(new java.awt.Color(153, 0, 0));
        btnGuardar.setFont(new java.awt.Font("Arial", 1, 18)); // NOI18N
        btnGuardar.setForeground(new java.awt.Color(255, 255, 255));
        btnGuardar.setText("Confirmar Reservacion");
        btnGuardar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnGuardarActionPerformed(evt);
            }
        });
        jPanel1.add(btnGuardar, new org.netbeans.lib.awtextra.AbsoluteConstraints(720, 480, 240, 50));

        jLabel1.setFont(new java.awt.Font("Arial", 1, 24)); // NOI18N
        jLabel1.setText("Disponibilidad de habitaciones:");
        jPanel1.add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 20, -1, -1));

        FechaEnt.setMaxSelectableDate(new java.util.Date(1677567694000L));
        FechaEnt.setMinSelectableDate(new java.util.Date(1675234894000L));
        jPanel1.add(FechaEnt, new org.netbeans.lib.awtextra.AbsoluteConstraints(350, 70, 130, 30));

        btnBuscar.setBackground(new java.awt.Color(153, 0, 0));
        btnBuscar.setFont(new java.awt.Font("Arial", 1, 14)); // NOI18N
        btnBuscar.setForeground(new java.awt.Color(255, 255, 255));
        btnBuscar.setText("Buscar Habitaciones ");
        btnBuscar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnBuscarActionPerformed(evt);
            }
        });
        jPanel1.add(btnBuscar, new org.netbeans.lib.awtextra.AbsoluteConstraints(730, 60, 190, 40));
        jPanel1.add(jLabel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(820, 20, 140, 20));

        jSpinner1.setModel(new javax.swing.SpinnerNumberModel(1, 1, null, 1));
        jPanel1.add(jSpinner1, new org.netbeans.lib.awtextra.AbsoluteConstraints(210, 70, 80, 30));

        tbMostrar.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null, null},
                {null, null, null, null, null},
                {null, null, null, null, null},
                {null, null, null, null, null}
            },
            new String [] {
                "Planta", "Habitaciones", "Capacidad", "Tipo ", "Precio"
            }
        ) {
            boolean[] canEdit = new boolean [] {
                false, false, false, false, false
            };

            public boolean isCellEditable(int rowIndex, int columnIndex) {
                return canEdit [columnIndex];
            }
        });
        jScrollPane1.setViewportView(tbMostrar);

        jPanel1.add(jScrollPane1, new org.netbeans.lib.awtextra.AbsoluteConstraints(70, 130, 840, 320));

        FechaSali.setMaxSelectableDate(new java.util.Date(1677567694000L));
        FechaSali.setMinSelectableDate(new java.util.Date(1675234894000L));
        jPanel1.add(FechaSali, new org.netbeans.lib.awtextra.AbsoluteConstraints(560, 70, 130, 30));

        jLabel3.setText("Cantidad De Personas:");
        jPanel1.add(jLabel3, new org.netbeans.lib.awtextra.AbsoluteConstraints(80, 80, -1, -1));

        jLabel4.setText("Fecha Salida:");
        jPanel1.add(jLabel4, new org.netbeans.lib.awtextra.AbsoluteConstraints(590, 50, -1, -1));

        jLabel5.setText("Fecha Entrada:");
        jPanel1.add(jLabel5, new org.netbeans.lib.awtextra.AbsoluteConstraints(380, 50, -1, -1));

        btnAtrás.setText("Atrás");
        btnAtrás.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnAtrásActionPerformed(evt);
            }
        });
        jPanel1.add(btnAtrás, new org.netbeans.lib.awtextra.AbsoluteConstraints(30, 500, -1, -1));

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.DEFAULT_SIZE, 990, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, 550, Short.MAX_VALUE)
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    public void setCedula(String cedula) {
        this.cedula = cedula;
        jLabel2.setText(cedula);
    }

    public void reiniciarListaObjeto() {
        OBJHabitaciones.listaHabitaciones = new ArrayList<>();
    }

    private void btnBuscarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnBuscarActionPerformed
        int cantPersonas = (int) jSpinner1.getValue();
        Date fechaEntrada = FechaEnt.getDate();
        Date fechaSalida = FechaSali.getDate();

        // Validar que la fecha de entrada sea menor a la fecha de salida
        if (fechaEntrada.compareTo(fechaSalida) >= 0) {
            // Mostrar un mensaje de error si la fecha de entrada es mayor o igual a la fecha de salida
            JOptionPane.showMessageDialog(this, "La fecha de entrada debe ser menor a la fecha de salida", "Error", JOptionPane.ERROR_MESSAGE);
        } else {
            // Continuar con el proceso si la fecha de entrada es menor a la fecha de salida
            Reservaciones negocio = new Reservaciones();
            ArrayList<String> recomendaciones = negocio.recomendarHabitaciones(cantPersonas, fechaEntrada, fechaSalida);
            mostrarRecomendacionesEnTabla(recomendaciones);
        }
    }//GEN-LAST:event_btnBuscarActionPerformed

    private void seleccion() {

        tbMostrar.getSelectionModel().addListSelectionListener(new ListSelectionListener() {
            @Override
            public void valueChanged(ListSelectionEvent event) {
                if (!event.getValueIsAdjusting()) {
                    int selectedRow = tbMostrar.getSelectedRow();
                    if (selectedRow >= 0) {
                        // Obtén los datos de la fila seleccionada
                        String planta = (String) tbMostrar.getValueAt(selectedRow, 0);
                        String habitacion = (String) tbMostrar.getValueAt(selectedRow, 1);
                        String tipo = (String) tbMostrar.getValueAt(selectedRow, 2);
                        String precio = (String) tbMostrar.getValueAt(selectedRow, 4);
                    }
                }
            }
        });

    }


    private void btnGuardarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnGuardarActionPerformed
        int selectedRow = tbMostrar.getSelectedRow();
        if (selectedRow >= 0) {
            // Obtengo los datos de la fila seleccionada
            int cedulaInt = Integer.parseInt(jLabel2.getText());

            int personaacom = (int) jSpinner1.getValue();

            String planta = (String) tbMostrar.getValueAt(selectedRow, 0);
            String habitacion = (String) tbMostrar.getValueAt(selectedRow, 1);
            String tipo = (String) tbMostrar.getValueAt(selectedRow, 2);
            String precio = (String) tbMostrar.getValueAt(selectedRow, 4);
            int precioInt = Integer.parseInt(precio);

            Date fechaEntradaS = FechaEnt.getDate();
            Date fechaSalidaS = FechaSali.getDate();

            funcionGuardar(cedulaInt, personaacom, planta, habitacion, tipo, precioInt, fechaEntradaS, fechaSalidaS);


            reservaciones.enviarCorreo(cedulaInt); // Llamo al método para enviar el correo
            JOptionPane.showMessageDialog(this, "Reserva realizada con éxito.", "Éxito", JOptionPane.INFORMATION_MESSAGE);

            this.dispose();
            Inicio Ventana = new Inicio();
            Ventana.setVisible(true);
        }


    }//GEN-LAST:event_btnGuardarActionPerformed

    private void btnAtrásActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnAtrásActionPerformed
        this.dispose();
        Inicio Ventana = new Inicio();
        Ventana.setVisible(true);    }//GEN-LAST:event_btnAtrásActionPerformed

    private void funcionGuardar(int cedulaInt, int personaacom, String planta, String habitacion, String tipo, int precioInt, Date fechaEntradaS, Date fechaSalidaS) {
        String nombreHuesped = obtenerNombreHuesped(cedulaInt); // Obtén el nombre del huésped

        OBJReservaciones.listaReservaciones.add(new OBJReservaciones(cedulaInt, nombreHuesped, personaacom, planta, habitacion, tipo, precioInt, fechaEntradaS, fechaSalidaS));

        // Llamo al método InsertarCantante solo una vez después de todas las inserciones
        ActualizarDatosArchivoCSV(OBJReservaciones.listaReservaciones); // Ajusta esto según tu implementación
    }

    private String obtenerNombreHuesped(int cedula) {
        // Itero a través de la lista de OBJHuespedes y busca el nombre correspondiente a la cédula
        for (OBJHuespedes huesped : listaHuespedes) { // Asegúrate de reemplazar "listaHuespedes" con el nombre correcto de tu lista
            if (huesped.getCedula() == cedula) {
                return huesped.getNombre();
            }
        }
        return ""; // Retorno un valor por defecto si la cédula no se encuentra en la lista
    }

    public void mostrarRecomendacionesEnTabla(ArrayList<String> recomendaciones) {
        DefaultTableModel model = (DefaultTableModel) tbMostrar.getModel();
        model.setRowCount(0); // Clear the table

        Set<String> plantasAgregadas = new HashSet<>(); // Conjunto para mantener un registro de plantas

        for (String recomendacion : recomendaciones) {
            String[] columnas = recomendacion.split("/");
            String planta = columnas[0].split(":")[1].trim();

            // Si la planta aún no ha sido agregada, la agregamos al conjunto y a la tabla
            if (!plantasAgregadas.contains(planta)) {
                plantasAgregadas.add(planta);

                Object[] rowData = new Object[5];
                rowData[0] = planta;
                rowData[1] = columnas[1].split(":")[1].trim();
                rowData[2] = columnas[2].split(":")[1].trim();
                rowData[3] = columnas[3].split(":")[1].trim();
                rowData[4] = columnas[4].split(":")[1].trim();

                model.addRow(rowData);
            }
        }

    }

    public static void main(String args[]) {
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(ReservasVentana.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(ReservasVentana.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(ReservasVentana.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(ReservasVentana.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new ReservasVentana().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private com.toedter.calendar.JDateChooser FechaEnt;
    private com.toedter.calendar.JDateChooser FechaSali;
    private javax.swing.JButton btnAtrás;
    private javax.swing.JButton btnBuscar;
    private javax.swing.JButton btnGuardar;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JSpinner jSpinner1;
    private javax.swing.JTable tbMostrar;
    // End of variables declaration//GEN-END:variables
}
