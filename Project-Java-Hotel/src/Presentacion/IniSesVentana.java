package Presentacion;

import Datos.BDReservaciones;
import Negocio.Habitaciones;
import Negocio.Huespedes;
import Objetos.OBJHabitaciones;
import Objetos.OBJHuespedes;
import Objetos.OBJReservaciones;
import java.util.ArrayList;
import java.util.Arrays;
import javax.swing.JOptionPane;

public class IniSesVentana extends javax.swing.JFrame {

    Huespedes huespedes = new Huespedes();
    Habitaciones habitaciones = new Habitaciones();
    BDReservaciones bdReservaciones = new BDReservaciones();
    ArrayList<OBJReservaciones> listaReservaciones = bdReservaciones.LeerDesdeArchivoObjetoCSV();


    
    public IniSesVentana() {
        initComponents();
        setLocationRelativeTo(null);
        leer();
        imprimirListaReservaciones(listaReservaciones);

    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        btnAtras = new javax.swing.JButton();
        jPanel2 = new javax.swing.JPanel();
        lblCedula = new javax.swing.JLabel();
        txtCedula = new javax.swing.JTextField();
        lblContraseña = new javax.swing.JLabel();
        passfield = new javax.swing.JPasswordField();
        lblRegistro = new javax.swing.JLabel();
        lblInfo = new javax.swing.JLabel();
        btnIniciarSesion = new javax.swing.JButton();
        jLabel1 = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jPanel1.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        btnAtras.setFont(new java.awt.Font("Arial", 0, 18)); // NOI18N
        btnAtras.setText("Atrás");
        btnAtras.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnAtrasActionPerformed(evt);
            }
        });
        jPanel1.add(btnAtras, new org.netbeans.lib.awtextra.AbsoluteConstraints(30, 580, 120, 40));

        jPanel2.setBackground(new java.awt.Color(255, 255, 255));
        jPanel2.setBorder(javax.swing.BorderFactory.createLineBorder(new java.awt.Color(0, 0, 0)));
        jPanel2.setToolTipText("");
        jPanel2.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        lblCedula.setFont(new java.awt.Font("Arial", 0, 18)); // NOI18N
        lblCedula.setText("Cédula:");
        jPanel2.add(lblCedula, new org.netbeans.lib.awtextra.AbsoluteConstraints(30, 170, -1, -1));

        txtCedula.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtCedulaKeyTyped(evt);
            }
        });
        jPanel2.add(txtCedula, new org.netbeans.lib.awtextra.AbsoluteConstraints(130, 170, 159, -1));

        lblContraseña.setFont(new java.awt.Font("Arial", 0, 18)); // NOI18N
        lblContraseña.setText("Contraseña:");
        jPanel2.add(lblContraseña, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 250, -1, -1));
        jPanel2.add(passfield, new org.netbeans.lib.awtextra.AbsoluteConstraints(130, 250, 159, -1));

        lblRegistro.setFont(new java.awt.Font("Arial", 1, 36)); // NOI18N
        lblRegistro.setText("Inicio de Sesión");
        jPanel2.add(lblRegistro, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 50, -1, -1));

        lblInfo.setFont(new java.awt.Font("Arial", 0, 14)); // NOI18N
        lblInfo.setText("Ingrese sus datos:");
        jPanel2.add(lblInfo, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 130, -1, -1));

        btnIniciarSesion.setBackground(new java.awt.Color(153, 0, 0));
        btnIniciarSesion.setFont(new java.awt.Font("Arial", 0, 24)); // NOI18N
        btnIniciarSesion.setForeground(new java.awt.Color(255, 255, 255));
        btnIniciarSesion.setText("Ingresar");
        btnIniciarSesion.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnIniciarSesionActionPerformed(evt);
            }
        });
        jPanel2.add(btnIniciarSesion, new org.netbeans.lib.awtextra.AbsoluteConstraints(110, 320, 130, 50));

        jPanel1.add(jPanel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(320, 120, 340, 420));

        jLabel1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Imagenes/Untitled design.png"))); // NOI18N
        jPanel1.add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 990, 650));

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

    public void leer() {
        ArrayList<OBJHuespedes> lista = huespedes.LeerHuespedesObjetos();


        System.out.println("Entrando al bucle de recorrido de lista Habitaciones.");
        for (OBJHuespedes huesped : lista) {
            int cedula = huesped.getCedula();
            String contraseña = huesped.getContraseña();

            System.out.println("Cédula: " + cedula + ", Contraseña: " + contraseña);
        }

        ArrayList<OBJHabitaciones> lee = habitaciones.LeerHabitacionesObjetos();


        System.out.println("Entrando al bucle de recorrido de lista Habitaciones.");
        for (OBJHabitaciones habitacion : lee) {
            String linea = habitacion.getPlanta() + ";"
                    + habitacion.getNom_Hab() + ";"
                    + habitacion.getCapacidad() + ";"
                    + habitacion.getTipo() + ";"
                    + habitacion.getPrecio();

            System.out.println(linea);
        }

    }
    
    public void imprimirListaReservaciones(ArrayList<OBJReservaciones> listaReservaciones) {
    System.out.println("Lista de Reservaciones:");
    for (OBJReservaciones reservacion : listaReservaciones) {
        System.out.println("Cedula: " + reservacion.getCedula());
        System.out.println("Nombre Huesped: " + reservacion.getNom_Hues());
        System.out.println("Cantidad de Acompañantes: " + reservacion.getCant_Acom());
        System.out.println("Planta: " + reservacion.getPlanta());
        System.out.println("Nombre Habitación: " + reservacion.getNom_Hab());
        System.out.println("Tipo: " + reservacion.getTipo());
        System.out.println("Precio: " + reservacion.getPrecio());
        System.out.println("Fecha Entrada: " + reservacion.getFecha_Entrada());
        System.out.println("Fecha Salida: " + reservacion.getFecha_Salida());
        System.out.println("----------------------------");
    }
}
    
    
    

    private void btnIniciarSesionActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnIniciarSesionActionPerformed
        ArrayList<OBJHuespedes> lista = huespedes.LeerHuespedesObjetos();

        String cedulaString = txtCedula.getText();

        int Cedula = Integer.parseInt(cedulaString);

        char[] passwordChars = passfield.getPassword();
        String Contraseña = new String(passwordChars);
        // Limpio la matriz de caracteres después de usarla para seguridad.
        Arrays.fill(passwordChars, '0');

        verificarCedulaYContraseña(lista, Cedula, Contraseña);
    }//GEN-LAST:event_btnIniciarSesionActionPerformed

    private void txtCedulaKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtCedulaKeyTyped
        int key = evt.getKeyChar();

        boolean numeros = key >= 48 && key <= 57;

        if (!numeros) {
            evt.consume();
        }

        if (txtCedula.getText().trim().length() == 10) {
            
            evt.consume();
        }
    }//GEN-LAST:event_txtCedulaKeyTyped

    private void btnAtrasActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnAtrasActionPerformed
        this.dispose();
        Inicio Ventana = new Inicio();
        Ventana.setVisible(true);
    }//GEN-LAST:event_btnAtrasActionPerformed

    private void verificarCedulaYContraseña(ArrayList<OBJHuespedes> lista, int Cedula, String Contraseña) {
        OBJHuespedes usuario = null;

        // Buscar el objeto del usuario que ha iniciado sesión
        for (OBJHuespedes huesped : lista) {
            if (huesped.getCedula() == Cedula) {
                usuario = huesped;
                break;
            }
        }

        if (usuario != null) {
            // Validar la contraseña del usuario
            if (usuario.getContraseña().equals(Contraseña)) {
                String rolUsuario = usuario.getRol();
                if (rolUsuario.equals("Administrador")) {
                    this.dispose();
                    AdminVentana Ventana = new AdminVentana();
                    Ventana.setVisible(true);
                    JOptionPane.showMessageDialog(null, "Bienvenido Administrador", "Mensaje", JOptionPane.INFORMATION_MESSAGE);

                } else if (rolUsuario.equals("Huesped")) {
                    this.dispose();
                    ReservasVentana Ventana = new ReservasVentana();
                    Ventana.setCedula(txtCedula.getText());
                    Ventana.setVisible(true);

                } else {
                    JOptionPane.showMessageDialog(null, "El rol del usuario no está definido.", "Error", JOptionPane.ERROR_MESSAGE);
                }
            } else {
                JOptionPane.showMessageDialog(null, "Contraseña incorrecta.", "Error", JOptionPane.ERROR_MESSAGE);
            }
        } else {
            int opcion = JOptionPane.showConfirmDialog(null, "La cédula no está registrada. ¿Desea registrarse?", "Cédula no encontrada", JOptionPane.YES_NO_OPTION);
            if (opcion == JOptionPane.YES_OPTION) {
                this.dispose();
                RegistroVentana Ventana = new RegistroVentana();
                Ventana.setVisible(true);
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
            java.util.logging.Logger.getLogger(IniSesVentana.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(IniSesVentana.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(IniSesVentana.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(IniSesVentana.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new IniSesVentana().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnAtras;
    private javax.swing.JButton btnIniciarSesion;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JLabel lblCedula;
    private javax.swing.JLabel lblContraseña;
    private javax.swing.JLabel lblInfo;
    private javax.swing.JLabel lblRegistro;
    private javax.swing.JPasswordField passfield;
    private javax.swing.JTextField txtCedula;
    // End of variables declaration//GEN-END:variables
}
