MyTrees: Sistema de Gestión de Árboles para Reforestación 🌳
Este proyecto es una aplicación web diseñada para apoyar a la Asociación de Amigos de Un Millón de Árboles en su labor de reforestación. Permite gestionar el proceso de registro, venta y seguimiento de árboles, con funcionalidades específicas para administradores, operadores y amigos (usuarios finales).

🚀 Características Principales
1. Autenticación y Autorización
    Inicio de sesión seguro: Usuarios acceden al sistema con credenciales únicas.
    Roles definidos: Acceso diferenciado para Administradores, Operadores y Amigos.
    Restricción de acceso: Páginas protegidas según permisos del rol.

2. Módulo Administrador
    Dashboard informativo:
    Cantidad de Amigos registrados.
    Cantidad de Árboles disponibles y vendidos.
    
3. Gestión de usuarios:
    Crear, editar y eliminar Administradores y Operadores.
    Gestión de árboles:
    Administrar especies (nombre comercial y científico).
    Crear, actualizar, eliminar y asignar árboles a usuarios.
    Seguimiento y auditoría:
    Ver historial de actualizaciones de árboles, incluyendo fotos, tamaño y fechas.

4. Módulo Operador
    - Dashboard informativo:
        Estadísticas similares a las del Administrador.
    - Actualizaciones de árboles:
        Registrar y consultar historial de modificaciones.
    - Adjuntar imágenes y detalles específicos.
        Gestión limitada: Acceso restringido al manejo avanzado de datos.

5. Módulo Amigo
    - Registro de usuario:
        Crear una cuenta con información personal.
    - Catálogo de árboles disponibles:
        Visualizar árboles en estado "Disponible".
    - Compra de árboles:
        Solicitar adquisición de un árbol y cambiar su estado a "Vendido".

Seguimiento personal:
Ver el listado e historial de sus árboles con información detallada.

🔧 Detalles Técnicos
Arquitectura: Implementación basada en el patrón de diseño Modelo Vista Controlador (MVC).

Tecnologías utilizadas:
- Lenguaje del servidor: PHP.
- Framework CSS: Bootstrap, Tailwind.
- Base de datos: MySQL.

Control de versiones: Uso de Git con un historial completo de commits desde el inicio.
Validación de formularios: Cumplimiento de estándares de validación en el front-end y back-end.
Buenas prácticas de desarrollo: Código limpio, bien documentado y organizado.
