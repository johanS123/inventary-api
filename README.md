# **Inventary API con EF Core**

Una API construida con .NET que utiliza Entity Framework Core para manejar las entidades `Product`, `Entry`, `Exit` y `StatusProduct`. Esta API sigue una estructura basada en controladores para facilitar la organización y escalabilidad.

## **Características**
- CRUD para entidades:
  - **Product**: Productos disponibles en el sistema.
  - **Entry**: Entradas de productos al inventario.
  - **Exit**: Salidas de productos del inventario.
  - **StatusProduct**: Estados asociados a los productos.
- Conexión a bases de datos mediante **Entity Framework Core**.
- Rutas organizadas en controladores para mantener un código limpio y modular.

---

## **Requisitos**
- **.NET 7.0 SDK** o superior
- **SQL Server** (u otro proveedor compatible con EF Core)
- Editor de código como **Visual Studio**, **Visual Studio Code** o equivalente.

---

## **Configuración**

### 1. **Clonar el repositorio**
```bash
git clone https://github.com/tu_usuario/tu_repositorio.git
cd Inventary
```

### 2. **Configurar la base de datos**
Actualiza la cadena de conexión en `appsettings.json`:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=MinimalApiEfCore;User Id=sa;Password=your_password;"
}
```

### 3. **Instalar dependencias**
Restaura las dependencias del proyecto:
```bash
dotnet restore
```

### 4. **Aplicar migraciones**
Genera y aplica las migraciones para configurar la base de datos:
```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### 5. **Ejecutar la API**
Inicia el servidor de desarrollo:
```bash
dotnet run
```

## **Rutas de la API**

### Product  
| Método | Endpoint         | Descripción                         |  
|--------|------------------|-------------------------------------|  
| GET    | `/api/product`   | Obtiene una lista de todos los productos. | 
| POST   | `/api/product`   | Crea un nuevo producto.
| GET    | `/api/product/{id}`| Obtiene un producto específico por ID.|  
| PUT    | `/api/product/{id}`| Actualiza la información de un producto. |  
| DELETE | `/api/product/{id}`| Elimina un producto por ID.           |  

### Entry  
| Método | Endpoint         | Descripción                         |  
|--------|------------------|-------------------------------------|  
| GET    | `/api/entry`   | Obtiene una lista de todos las entradas. | 
| POST   | `/api/entry`   | Crea una nueva entrada.

### Exit  
| Método | Endpoint         | Descripción                         |  
|--------|------------------|-------------------------------------|  
| GET    | `/api/exit`      | Obtiene una lista de todos las salidas.| 
| POST   | `/api/exit`      | Crea una nueva salida.                                
 
### StatusProduct  
| Método | Endpoint         | Descripción                         |  
|--------|------------------|-------------------------------------|  
| GET    | `/api/statusproduct`  | Obtiene una lista de todos los estados.| 
| POST   | `/api/statusproduct`  | Crea un nuevo estado.                                
 

## **Estructura del proyecto**
```mathematica
Inventary/
├── Controllers/
│   ├── ProductController.cs
│   ├── EntryController.cs
│   ├── ExitController.cs
│   └── StatusProductController.cs
├── Data/
│   └── ApplicationDbContext.cs
├── Models/
│   ├── Product.cs
│   ├── Entry.cs
│   ├── Exit.cs
│   └── StatusProduct.cs
├── appsettings.json
├── Program.cs
└── README.md
```
