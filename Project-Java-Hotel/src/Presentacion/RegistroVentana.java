package Presentacion;

import Negocio.Huespedes;
import Objetos.OBJHuespedes;
import java.util.ArrayList;
import java.util.Arrays;
import javax.swing.JOptionPane;

public class RegistroVentana extends javax.swing.JFrame {

    Huespedes huespedes = new Huespedes();

    public RegistroVentana() {
        initComponents();
        setLocationRelativeTo(null);

    }

    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        btnGroup = new javax.swing.ButtonGroup();
        jPanel1 = new javax.swing.JPanel();
        jPanel2 = new javax.swing.JPanel();
        lblCedula = new javax.swing.JLabel();
        txtCedula = new javax.swing.JTextField();
        lblNombre = new javax.swing.JLabel();
        txtNombre = new javax.swing.JTextField();
        lblApellidos = new javax.swing.JLabel();
        txtApellidos = new javax.swing.JTextField();
        lblContraseña = new javax.swing.JLabel();
        passfield = new javax.swing.JPasswordField();
        lblGenero = new javax.swing.JLabel();
        rbtFemenino = new javax.swing.JRadioButton();
        rbtMasculino = new javax.swing.JRadioButton();
        rbtnodef = new javax.swing.JRadioButton();
        lblCorreo = new javax.swing.JLabel();
        txtCorreo = new javax.swing.JTextField();
        lblRegistro = new javax.swing.JLabel();
        lblInfo = new javax.swing.JLabel();
        btnRegistrar = new javax.swing.JButton();
        btnAtrás = new javax.swing.JButton();
        lblFondo = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jPanel1.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        jPanel2.setBackground(new java.awt.Color(204, 204, 255));
        jPanel2.setBorder(javax.swing.BorderFactory.createCompoundBorder());
        jPanel2.setToolTipText("");
        jPanel2.setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        lblCedula.setFont(new java.awt.Font("Arial", 0, 18)); // NOI18N
        lblCedula.setText("Cédula:");
        jPanel2.add(lblCedula, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 130, -1, -1));

        txtCedula.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtCedulaKeyTyped(evt);
            }
        });
        jPanel2.add(txtCedula, new org.netbeans.lib.awtextra.AbsoluteConstraints(130, 130, 159, -1));

        lblNombre.setFont(new java.awt.Font("Arial", 0, 18)); // NOI18N
        lblNombre.setText("Nombre:");
        jPanel2.add(lblNombre, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 180, -1, -1));

        txtNombre.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtNombreKeyTyped(evt);
            }
        });
        jPanel2.add(txtNombre, new org.netbeans.lib.awtextra.AbsoluteConstraints(130, 180, 159, -1));

        lblApellidos.setFont(new java.awt.Font("Arial", 0, 18)); // NOI18N
        lblApellidos.setText("Apellidos:");
        jPanel2.add(lblApellidos, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 230, -1, -1));

        txtApellidos.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtApellidosKeyTyped(evt);
            }
        });
        jPanel2.add(txtApellidos, new org.netbeans.lib.awtextra.AbsoluteConstraints(130, 230, 159, -1));

        lblContraseña.setFont(new java.awt.Font("Arial", 0, 18)); // NOI18N
        lblContraseña.setText("Contraseña:");
        jPanel2.add(lblContraseña, new org.netbeans.lib.awtextra.AbsoluteConstraints(30, 280, -1, -1));
        jPanel2.add(passfield, new org.netbeans.lib.awtextra.AbsoluteConstraints(130, 280, 159, -1));

        lblGenero.setFont(new java.awt.Font("Arial", 0, 18)); // NOI18N
        lblGenero.setText("Genero:");
        jPanel2.add(lblGenero, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 340, -1, 20));

        btnGroup.add(rbtFemenino);
        rbtFemenino.setSelected(true);
        rbtFemenino.setText("Femenino");
        jPanel2.add(rbtFemenino, new org.netbeans.lib.awtextra.AbsoluteConstraints(80, 340, -1, -1));

        btnGroup.add(rbtMasculino);
        rbtMasculino.setText("Masculino");
        jPanel2.add(rbtMasculino, new org.netbeans.lib.awtextra.AbsoluteConstraints(160, 340, -1, -1));

        btnGroup.add(rbtnodef);
        rbtnodef.setText("No Definido");
        jPanel2.add(rbtnodef, new org.netbeans.lib.awtextra.AbsoluteConstraints(240, 340, -1, -1));

        lblCorreo.setFont(new java.awt.Font("Arial", 0, 18)); // NOI18N
        lblCorreo.setText("Correo Electrónico:");
        jPanel2.add(lblCorreo, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 390, -1, -1));
        jPanel2.add(txtCorreo, new org.netbeans.lib.awtextra.AbsoluteConstraints(170, 390, 148, -1));

        lblRegistro.setFont(new java.awt.Font("Arial", 1, 36)); // NOI18N
        lblRegistro.setText("Registro");
        jPanel2.add(lblRegistro, new org.netbeans.lib.awtextra.AbsoluteConstraints(101, 28, -1, -1));

        lblInfo.setFont(new java.awt.Font("Arial", 0, 14)); // NOI18N
        lblInfo.setText("Ingrese sus datos:");
        jPanel2.add(lblInfo, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 90, -1, -1));

        btnRegistrar.setBackground(new java.awt.Color(153, 0, 0));
        btnRegistrar.setFont(new java.awt.Font("Arial", 1, 18)); // NOI18N
        btnRegistrar.setForeground(new java.awt.Color(255, 255, 255));
        btnRegistrar.setText("Registrar");
        btnRegistrar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnRegistrarActionPerformed(evt);
            }
        });
        jPanel2.add(btnRegistrar, new org.netbeans.lib.awtextra.AbsoluteConstraints(100, 450, 130, 50));

        btnAtrás.setText("Atrás");
        btnAtrás.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnAtrásActionPerformed(evt);
            }
        });
        jPanel2.add(btnAtrás, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 510, -1, -1));

        jPanel1.add(jPanel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 0, 340, 550));

        lblFondo.setIcon(new javax.swing.ImageIcon(getClass().getResource("/Imagenes/fondo (1).jpg"))); // NOI18N
        jPanel1.add(lblFondo, new org.netbeans.lib.awtextra.AbsoluteConstraints(120, 0, 870, 550));

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

    //Para limpiar la lista del objeto. 
    public void reiniciarListaObjeto() {
        OBJHuespedes.listaHuespedes = new ArrayList<>();
    }

    private void btnRegistrarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnRegistrarActionPerformed
        String cedulaString = txtCedula.getText().trim();
        String Nombre = txtNombre.getText().trim();
        String Apellido = txtApellidos.getText().trim();
        char[] PasswordChars = passfield.getPassword();
        String Correo = txtCorreo.getText().trim();
        String Rol = "Huesped";

        // Verifico si los campos obligatorios están vacíos
        if (cedulaString.isEmpty() || Nombre.isEmpty() || Apellido.isEmpty()
                || PasswordChars.length == 0 || Correo.isEmpty()) {
            JOptionPane.showMessageDialog(this, "Por favor, complete todos los campos obligatorios.", "Error", JOptionPane.ERROR_MESSAGE);
            return; // Sale del método sin continuar con el registro
        }

        int Cedula = Integer.parseInt(cedulaString);
        String Contraseña = new String(PasswordChars);
        Arrays.fill(PasswordChars, '0'); // Limpia la matriz de caracteres después de usarla para seguridad

        String Genero = "";
        if (rbtFemenino.isSelected()) {
            Genero = rbtFemenino.getActionCommand();
        } else if (rbtMasculino.isSelected()) {
            Genero = rbtMasculino.getActionCommand();
        } else if (rbtnodef.isSelected()) {
            Genero = rbtnodef.getActionCommand();
        } else {
            JOptionPane.showMessageDialog(this, "Por favor, seleccione un género.", "Error", JOptionPane.ERROR_MESSAGE);
            return; // Sale del método si no se ha seleccionado un género
        }

        // Resto del código para obtener el valor de "Rol"
        ArrayList<OBJHuespedes> lista = huespedes.LeerHuespedesObjetos();

        // Validar si la cedula ya existe en la lista
        for (OBJHuespedes huesped : lista) {
            if (huesped.getCedula() == Cedula) {
                JOptionPane.showMessageDialog(null, "La cédula ya existe en la lista de huéspedes.",
                        "Error", JOptionPane.ERROR_MESSAGE);
                return;
            }
        }

        Huespedes huespedes = new Huespedes();

        reiniciarListaObjeto();

        OBJHuespedes.listaHuespedes.add(new OBJHuespedes(Cedula, Nombre, Contraseña, Genero, Correo, Rol));

        // Llamo al método InsertarCantante solo una vez después de todas las inserciones
        huespedes.InsertarNuevoHuesped(OBJHuespedes.listaHuespedes);

        JOptionPane.showMessageDialog(this, "Te has registrado con éxito.", "Éxito", JOptionPane.INFORMATION_MESSAGE);

        // Cierro la ventana una vez se insertó el artista 
        this.dispose();
        Inicio Ventana = new Inicio();
        Ventana.setVisible(true);
    }//GEN-LAST:event_btnRegistrarActionPerformed

    private void txtNombreKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtNombreKeyTyped
        int key = evt.getKeyChar();

        boolean mayusculas = key >= 65 && key <= 90;
        boolean minusculas = key >= 97 && key <= 122;
        boolean espacio = key == 32;

        if (!(minusculas || mayusculas || espacio)) {
            evt.consume();
        }
    }//GEN-LAST:event_txtNombreKeyTyped

    private void txtApellidosKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtApellidosKeyTyped
        int key = evt.getKeyChar();

        boolean mayusculas = key >= 65 && key <= 90;
        boolean minusculas = key >= 97 && key <= 122;
        boolean espacio = key == 32;

        if (!(minusculas || mayusculas || espacio)) {
            evt.consume();
        }
    }//GEN-LAST:event_txtApellidosKeyTyped

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

    private void btnAtrásActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnAtrásActionPerformed
        this.dispose();
        Inicio Ventana = new Inicio();
        Ventana.setVisible(true);
    }//GEN-LAST:event_btnAtrásActionPerformed

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
            java.util.logging.Logger.getLogger(RegistroVentana.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(RegistroVentana.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(RegistroVentana.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(RegistroVentana.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new RegistroVentana().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnAtrás;
    private javax.swing.ButtonGroup btnGroup;
    private javax.swing.JButton btnRegistrar;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    private javax.swing.JLabel lblApellidos;
    private javax.swing.JLabel lblCedula;
    private javax.swing.JLabel lblContraseña;
    private javax.swing.JLabel lblCorreo;
    private javax.swing.JLabel lblFondo;
    private javax.swing.JLabel lblGenero;
    private javax.swing.JLabel lblInfo;
    private javax.swing.JLabel lblNombre;
    private javax.swing.JLabel lblRegistro;
    private javax.swing.JPasswordField passfield;
    private javax.swing.JRadioButton rbtFemenino;
    private javax.swing.JRadioButton rbtMasculino;
    private javax.swing.JRadioButton rbtnodef;
    private javax.swing.JTextField txtApellidos;
    private javax.swing.JTextField txtCedula;
    private javax.swing.JTextField txtCorreo;
    private javax.swing.JTextField txtNombre;
    // End of variables declaration//GEN-END:variables
}
