# **DETAILS.md**

Este documento describe las decisiones clave tomadas durante el diseño de la API REST para la gestión de inventario básico y proporciona sugerencias para futuras mejoras y escalabilidad.

---

## **Decisiones de diseño clave**

### **1. Diseño basado en Minimal APIs**

Se optó por el uso de **Minimal APIs** de .NET para desarrollar una solución ligera y eficiente.  
**Ventajas:**

- Reducción del boilerplate en comparación con el enfoque basado en controladores.
- Configuración más rápida y directa para aplicaciones pequeñas o medianas.
- Alto rendimiento gracias a su naturaleza simplificada.

### **2. Uso de Entity Framework Core**

Se eligió **Entity Framework Core** como ORM para manejar la persistencia de datos.  
**Ventajas:**

- Simplificación en la creación y gestión de la base de datos mediante migraciones.
- Abstracción de consultas SQL, permitiendo un enfoque orientado a objetos.
- Compatibilidad con múltiples proveedores de bases de datos.

### **3. Estructura modular**

Aunque se trata de una API mínima, se organizó el código en directorios clave (`Controllers`, `Models`, `Data`) para garantizar una separación adecuada de responsabilidades.  
**Ventajas:**

- Facilita la navegación y el mantenimiento del código.
- Proporciona una base sólida para futuras extensiones.

### **4. Validación de datos**

Se implementó validación básica utilizando **Data Annotations** en los modelos de datos para garantizar que las entradas sean correctas antes de llegar a la base de datos.  
**Ventajas:**

- Reduce el riesgo de errores en la persistencia de datos.
- Mejora la calidad del sistema desde el punto de vista del usuario.

### **5. Rutas RESTful**

Las rutas siguen el estándar RESTful, asegurando consistencia en las operaciones CRUD.  
**Ventajas:**

- Hace que la API sea intuitiva y fácil de consumir para desarrolladores.
- Facilita la integración con aplicaciones frontend.

### **6. Uso de una cadena de conexión centralizada**

La cadena de conexión se configuró en el archivo `appsettings.json`, permitiendo flexibilidad en el cambio de entornos (desarrollo, prueba, producción).  
**Ventajas:**

- Simplifica la administración de configuraciones.
- Mejora la seguridad al evitar hardcodear credenciales.

---

## **Sugerencias de mejora y escalabilidad**

### **1. Implementar autenticación y autorización**

- Agregar un sistema de autenticación basado en JWT para proteger las rutas de la API.
- Implementar roles y permisos para restringir ciertas operaciones (por ejemplo, solo administradores pueden eliminar productos).

### **2. Optimizar el rendimiento**

- Implementar paginación, filtrado y búsqueda en las rutas que devuelven grandes conjuntos de datos.
- Usar índices en la base de datos para mejorar el rendimiento de las consultas.

### **3. Registrar y monitorear errores**

Agregar un sistema de registro de errores (por ejemplo, con **Serilog** o **Application Insights**) para:

- Detectar problemas en tiempo real.
- Registrar métricas clave sobre el uso de la API.

### **4. Escalabilidad horizontal**

Para manejar un gran número de solicitudes simultáneas:

- Implementar un balanceador de carga.
- Contenerizar la API usando **Docker** para un despliegue más eficiente.

### **5. Seguridad**

- Validar las entradas del usuario para evitar ataques de inyección SQL o XSS.
- Configurar CORS para permitir solo orígenes confiables.
- Usar HTTPS de forma predeterminada en entornos de producción.

### **6. Pruebas automatizadas**

- Crear pruebas unitarias para verificar la lógica interna.
- Agregar pruebas de integración para validar la interacción entre las rutas y la base de datos.

### **7. Escalabilidad funcional**

- Agregar soporte para categorías de productos.
- Permitir reportes detallados (por ejemplo, entradas/salidas por rango de fechas).

---

## **Conclusión**

El diseño actual proporciona una base funcional y eficiente para una API REST de inventario básico. Con las mejoras sugeridas, el sistema puede evolucionar hacia una solución robusta y escalable que soporte mayores volúmenes de datos y usuarios en entornos de producción.
