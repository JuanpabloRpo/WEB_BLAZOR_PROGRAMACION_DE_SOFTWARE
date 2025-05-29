# 📚 Librería - Sistema de Gestión de Préstamos y Reservas

**Librería** es una aplicación web desarrollada con **.NET 8**, **Blazor** y **C#**, diseñada para gestionar materiales bibliográficos. Permite a los usuarios registrar reservas, realizar préstamos, y a los bibliotecarios administrar eficientemente la disponibilidad del material.

## 🚀 Funcionalidades Principales

- Registro y autenticación de usuarios.
- Búsqueda y visualización de materiales disponibles.
- Creación y gestión de reservas por parte de los usuarios.
- Aprobación o rechazo de préstamos por parte del bibliotecario.
- Generación automática de préstamos tras la aprobación de reservas.
- Finalización de préstamos una vez entregado el material.
- Visualización del historial de reservas y préstamos por parte del usuario.
- Gestión de materiales por el administrador.

## 👥 Roles de Usuario y Permisos

El sistema cuenta con tres tipos de usuario: **Invitado (Guest)**, **Bibliotecario** y **Administrador**. Cada uno tiene permisos específicos:

- **Invitado (Guest)**  
  - Puede visualizar el catálogo de materiales.
  - Puede consultar la disponibilidad de materiales para realizar reservas.
  - Tiene acceso limitado únicamente a funciones de consulta y solicitud de préstamo.

- **Bibliotecario**  
  - Puede revisar todas las reservas realizadas por los usuarios.
  - Tiene la capacidad de aprobar o rechazar reservas.
  - Puede registrar nuevos materiales en el sistema.

- **Administrador**  
  - Tiene los mismos permisos que el Bibliotecario.
  - Además, puede gestionar usuarios y realizar tareas administrativas avanzadas.

Estos roles permiten un flujo claro de operaciones según el nivel de acceso, garantizando seguridad y control sobre el sistema.

## 🛠️ Tecnologías Utilizadas

- [.NET 8](https://dotnet.microsoft.com/en-us/)
- [Blazor](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor)

## 💻 Requisitos del Sistema

- Visual Studio 2022
- .NET 8 SDK

## ⚙️ Instalación y Ejecución

1. Abre el proyecto en Visual Studio 2022.
2. Restaura los paquetes NuGet (se realiza automáticamente al abrir el proyecto si está configurado).
3. Ejecuta el proyecto usando:
   - `Ctrl + F5` para ejecutar sin depuración.
   - `F5` para ejecutar en modo depuración.

## 📁 Estructura del Proyecto

- **Entities/**: Clases de dominio como `Book`, `Loan`, `User`, etc.
- **Enumerations/**: Enums para definir estados como `LoanStatus`, `MaterialStatus`, etc.
- **Forms/**: Componentes de formulario como `LoginForm`, `RegisterMaterialForm`, etc.
- **Interfaces/**: Servicios que definen la lógica de negocio.
- **Layout/**: Componentes de estructura como `MainLayout` y navegación (`NavMenu`).
- **Pages/**: Páginas del sistema como reserva, préstamo, login, etc.
- **Services/**: Implementaciones de los servicios declarados en Interfaces.
- **Utilities/**: Funcionalidades auxiliares como `Conversor`, `Component`, etc.

## 📦 Estado del Proyecto

La aplicación ya se encuentra en producción. Sin embargo, podrían aplicarse futuras actualizaciones para mejorar la experiencia del usuario o añadir nuevas funcionalidades.

