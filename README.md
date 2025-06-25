# Tarea Programada 3 - TP3_Juego_Numeros_Aleatorios-

**Nombre:** Fiorella Portuguez Rojas  
**Carné:** FI22024660
**Repositorio:** [https://github.com/fioportu/TP3_Juego_Numeros_Aleatorios-]

----------------------------------------------------------------------------

## Estructura del Proyecto

Este proyecto fue desarrollado en Visual Studio 2022 como una aplicacion en C# utilizando Entity Framework 6 y .NET Framework. La aplicación es un juego de números aleatorios, y almacena la información 
en una base de datos llamada TP3.

Se han excluido las carpetas `bin/` y `obj/` como se indica en las instrucciones.

---

## Fuentes y recursos utilizados

- https://andresledo.es/csharp/que-es-entity-framework/
- https://learn.microsoft.com/es-es/dotnet/api/system.data.entity.dbcontext?view=entity-framework-6.2.0
- https://es.stackoverflow.com/questions/493543/generar-n%C3%BAmeros-aletorios-reales-entre-1-y-100-en-c
- https://daniccardenas.com/crear-numeros-aleatorios-con-c-sharp/

---

## Prompts y respuestas de IA utilizadas

### ChatGPT (OpenAI)


**Prompt:**  
>  ¿Que es Code First?

**Respuesta Resumida**
> Code First es una metodología de desarrollo en la que la base de datos se crea a partir del código de la aplicación, en lugar de diseñar primero la base de datos y luego generar el código.


**Prompt:**  
>  ¿Cómo crear una relación 1 a muchos en Entity Framework 6 usando Code First?

**Respuesta Resumida**
> Utiliza una colección `ICollection<Numero>` en la clase `Producto` y una propiedad de navegación con el ID en la clase para que EF infiera la relación.


**Prompt:**  
> ¿Cómo conecto Entity Framework 6 usando Code First y hago que se cree automáticamente la base de datos?

**Respuesta resumida:**  
Crea tu clase DbContext  using System.Data.Entity; y  Agrega la cadena de conexión en el archivo App.config
<connectionStrings>
    <add name="Tu nombre de BD" 
         connectionString="Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Tu nombre de BD;Integrated Security=True;" 
         providerName="System.Data.SqlClient" />
  </connectionStrings>
