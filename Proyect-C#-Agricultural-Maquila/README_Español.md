# Sistema de Gestión de Producción Piñera

Este sistema permite gestionar el proceso de producción y empaque de piña para exportación en la empresa. Está diseñado para que empleados puedan administrar todo el flujo de producción, desde la recepción y limpieza de la fruta, hasta el empaque y despacho, con roles específicos para administrador y digitador.

## Características del Proyecto

- **Lenguaje de programación**: C# en Visual Studio.
- **Base de Datos**: SQL Server 2019 o superior.
- **Interfaz gráfica**: Proyecto desarrollado exclusivamente con interfaz gráfica.

## Funcionalidades Principales

### 1. Login Seguro
- **Usuario y Contraseña**: Contraseñas encriptadas.
- **Roles**: Permite el acceso restringido a las secciones según el rol (Administrador o Digitador).
  
### 2. Módulo de Administrador
- **CRUD Proveedores, Fincas, Tipos y Variedades de Fruto**: Gestión completa de información de proveedores y tipos de producto.

### 3. Módulo de Digitador
- **CRUD Boleta de Cosecha e Inmersión**: Gestión de la documentación y registros de ingreso de fruta.
- **Empaque y Palletizado**: Asignación de tamaños a frutas y cálculo de cajas y pallets.
  
### 4. Reportes
- **Visualización y gráficos**: Generación de reportes con gráficos, como:
  - Cajas y pallets empacados en un día específico.
  - Procedencia de la fruta.
  - Registros de fruta rechazada y bitácora de movimientos.

## Proceso de Producción y Empaque
- **Ingreso de Fruta**: Registro de los bines desde la finca hasta la planta empacadora.
- **Limpieza**: Inmersión de los bines en agua y químicos, con registro de fecha y hora.
- **Empaque y Palletizado**: Distribución de fruta en cajas y organización en pallets para exportación.
- **Bitácora**: Registro de cada movimiento para control y auditoría.

## Roles de Usuario
- **Administrador**: Acceso completo y control sobre usuarios y parámetros del sistema.
- **Digitador**: Gestiona datos de ingreso de fruta y empacado.

---
