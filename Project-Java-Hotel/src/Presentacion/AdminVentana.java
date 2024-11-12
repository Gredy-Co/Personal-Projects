package Presentacion;

import Objetos.OBJReservaciones;
import java.awt.BorderLayout;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.time.LocalDate;
import java.time.Month;
import java.time.ZoneId;
import java.util.ArrayList;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JOptionPane;
import javax.swing.JPanel;
import javax.swing.JScrollPane;
import javax.swing.JTextArea;
import javax.swing.SwingConstants;
import javax.swing.SwingUtilities;

public class AdminVentana extends javax.swing.JFrame {

    private ArrayList<OBJReservaciones> listaReservaciones;

    public AdminVentana() {
        listaReservaciones = OBJReservaciones.getListaReservaciones();

 
        
        // Configuro ell JFrame
        setTitle("Calendario de Reservas");
        setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        JPanel panelPrincipal = new JPanel(new BorderLayout());
        panelPrincipal.setPreferredSize(new Dimension(400, 400));

        // Creación de mis botones y agregao botones al JPanel
        JPanel panelBotones = new JPanel(new GridLayout(4, 7));
        Font botonFont = new Font("Arial", Font.BOLD, 20); // Tamaño de fuente para los botones
        for (int i = 1; i <= 28; i++) {
            JButton boton = new JButton(String.valueOf(i));
            boton.setFont(botonFont); // Aplicar el tamaño de fuente
            boton.addActionListener(new BotonCalendarioListener(i));
            boton.setPreferredSize(new Dimension(70, 70));
            panelBotones.add(boton);
        }
        panelPrincipal.add(panelBotones, BorderLayout.CENTER);
        
        // Agrego botón para regresar al inicio
        JButton botonInicio = new JButton("Regresar al Inicio");
        botonInicio.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                // Cerrar la ventana actual y abrir una nueva instancia de AdminVentana
                dispose();
                Inicio Ventana = new Inicio();
                Ventana.setVisible(true);
            }
        });

        panelPrincipal.add(botonInicio, BorderLayout.SOUTH);
        
        

        // Agrega el nombre del mes en la esquina superior izquierda
        String mesFebrero = "Febrero";
        JLabel labelMes = new JLabel(mesFebrero.toString());
        labelMes.setVerticalAlignment(SwingConstants.TOP);
        labelMes.setHorizontalAlignment(SwingConstants.LEFT);
        Font mesFont = new Font("Arial", Font.BOLD, 30); // Tamaño de fuente para el nombre del mes
        labelMes.setFont(mesFont); // Aplicar el tamaño de fuente
        panelPrincipal.add(labelMes, BorderLayout.NORTH);

        add(panelPrincipal);

        pack();
        setLocationRelativeTo(null);
        setVisible(true);
    }

    private class BotonCalendarioListener implements ActionListener {

        private int diaSeleccionado;

        public BotonCalendarioListener(int dia) {
            diaSeleccionado = dia;
        }

        @Override
        public void actionPerformed(ActionEvent e) {
            mostrarPersonasHospedadas(diaSeleccionado);
        }
    }

    private void mostrarPersonasHospedadas(int diaSeleccionado) {
        StringBuilder infoHuespedes = new StringBuilder("Huéspedes:\n\n");

        LocalDate fechaSeleccionada = LocalDate.of(2023, 2, diaSeleccionado);

        for (OBJReservaciones reserva : OBJReservaciones.listaReservaciones) {
            LocalDate fechaEntrada = reserva.getFecha_Entrada().toInstant().atZone(ZoneId.systemDefault()).toLocalDate();
            LocalDate fechaSalida = reserva.getFecha_Salida().toInstant().atZone(ZoneId.systemDefault()).toLocalDate();

            // Verificao si la fecha seleccionada está dentro del rango de la reserva
            if (!fechaSeleccionada.isBefore(fechaEntrada) && !fechaSeleccionada.isAfter(fechaSalida)) {
                infoHuespedes.append("Cédula: ").append(reserva.getCedula())
                        .append("\nHuésped: ").append(reserva.getNom_Hues())
                        .append("\nHabitación: ").append(reserva.getNom_Hab())
                        .append("\nPlanta: ").append(reserva.getPlanta())
                        .append("\nDía de entrada: ").append(reserva.getFecha_Entrada().toInstant().atZone(ZoneId.systemDefault()).toLocalDate())
                        .append("\nDía de salida: ").append(reserva.getFecha_Salida().toInstant().atZone(ZoneId.systemDefault()).toLocalDate())
                        .append("\n\n");
            }

        }

        JTextArea textArea = new JTextArea(infoHuespedes.toString());
        textArea.setEditable(false);

        JScrollPane scrollPane = new JScrollPane(textArea);
        scrollPane.setPreferredSize(new Dimension(300, 200));

        JOptionPane.showMessageDialog(this, scrollPane, "Huéspedes: ", JOptionPane.INFORMATION_MESSAGE);
    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 1019, Short.MAX_VALUE)
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGap(0, 421, Short.MAX_VALUE)
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    public static void main(String args[]) {
        SwingUtilities.invokeLater(() -> new AdminVentana());

        /* Set the Nimbus look and feel */
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
            java.util.logging.Logger.getLogger(AdminVentana.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(AdminVentana.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(AdminVentana.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(AdminVentana.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JPanel jPanel1;
    // End of variables declaration//GEN-END:variables
}
