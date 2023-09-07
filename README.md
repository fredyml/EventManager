# Prueba Técnica - Registro de Eventos

Este proyecto está dividido en dos partes: el frontend y el backend.

- **Frontend:** Desarrollado en Angular.
- **Backend:** Desarrollado en .NET 6 con una arquitectura limpia.

## Requisitos previos

- Node.js y Angular CLI para el frontend.
- .NET SDK 6 para el backend.
- SQL Server para la base de datos.

## Base de datos

La base de datos está implementada en SQL Server. En el repositorio del backend, encontrarás un archivo llamado `BaseDeDatosPruebaTecnica`. Este archivo es un backup de la base de datos y deberá ser restaurado en tu instancia local de SQL Server antes de ejecutar el proyecto. La cadena de conexión se ajusta en el appsetting

## Cómo correr el proyecto

### Frontend:

1. Navega a la carpeta del frontend en una terminal.
2. Ejecuta `ng serve --o`. Esto iniciará el servidor de desarrollo de Angular y abrirá el proyecto en una ventana de tu navegador predeterminado.

### Backend:

Para correr el backend desde Visual Studio Code:

1. Abre la carpeta del backend en VS Code.
2. Asegúrate de tener la extensión C# para Visual Studio Code.
3. Abre una terminal en VS Code.
4. Navega a la carpeta del proyecto donde se encuentra el archivo `.csproj`.
5. Ejecuta el comando `dotnet watch run`. Esto iniciará el servidor backend y se recargará automáticamente si haces cambios en el código.

> **Nota:** Tanto el frontend como el backend deben estar corriendo al mismo tiempo para que el sistema funcione correctamente.

## Arquitectura y características adicionales

### Arquitectura limpia

El backend utiliza una arquitectura limpia, lo que garantiza la separación de responsabilidades y hace que el código sea más mantenible y escalable.

### Filtro de errores

Se ha implementado un filtro global en el backend para capturar y manejar errores de manera uniforme.

### Registro de logs

El sistema utiliza NLog para registrar eventos y errores. Esto ayuda a rastrear y diagnosticar problemas en tiempo de ejecución.

## Conclusión

Esperamos que esta guía te sea útil para correr y entender el proyecto. Si tienes alguna pregunta o inquietud, no dudes en ponerte en contacto.

¡Gracias por utilizar nuestro sistema!
