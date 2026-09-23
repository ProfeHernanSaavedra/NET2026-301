# 💻 Programación .NET — Sección 301

Repositorio de apoyo para la asignatura de **Programación .NET — Sección 301**.

Aquí se encuentran los ejemplos, ejercicios y proyectos desarrollados durante las clases. El objetivo es que los estudiantes puedan revisar el código, practicar los contenidos vistos y utilizar estos ejemplos como material de apoyo para su aprendizaje.

---

## 👨‍🏫 Profesor

**Hernán Saavedra**

---

# 📚 Contenidos del repositorio

Los proyectos están organizados de manera progresiva, comenzando por los fundamentos de C# y avanzando hacia el desarrollo de pequeñas aplicaciones utilizando **Programación Orientada a Objetos y colecciones**.

| Nº  | Proyecto                                   | Contenido principal              |
| --- | ------------------------------------------ | -------------------------------- |
| 1️⃣ | [MiPrimerProyectoCS](./MiPrimerProyectoCS) | Introducción a C# y .NET         |
| 2️⃣ | [POO](./POO)                               | Programación Orientada a Objetos |
| 3️⃣ | [EjemploColecciones](./EjemploColecciones) | Colecciones y `List<T>`          |
| 4️⃣ | [ProyectoContactos](./ProyectoContactos)   | POO + Colecciones                |
| 5️⃣ | [TareasPendientes](./TareasPendientes)     | Aplicación práctica              |

---

# 🧭 Ruta de aprendizaje

Se recomienda revisar los proyectos siguiendo este orden:

```text
MiPrimerProyectoCS
        │
        ▼
       POO
        │
        ▼
EjemploColecciones
        │
        ▼
ProyectoContactos
        │
        ▼
TareasPendientes
```

Cada proyecto incorpora nuevos conceptos y utiliza conocimientos vistos anteriormente.

---

# 1️⃣ MiPrimerProyectoCS

📂 [Ir al proyecto](./MiPrimerProyectoCS)

Primer acercamiento al desarrollo de aplicaciones utilizando **C# y .NET**.

### Conceptos trabajados

* Estructura básica de un programa en C#.
* Método `Main`.
* Uso de `Console.WriteLine()`.
* Variables.
* Tipos de datos.
* Entrada de información.
* Operadores.
* Estructuras básicas del lenguaje.

Ejemplo:

```csharp
Console.WriteLine("Hola Mundo");

string nombre;

Console.Write("Ingrese su nombre: ");
nombre = Console.ReadLine();

Console.WriteLine("Hola " + nombre);
```

🎯 **Objetivo:** familiarizarse con la sintaxis básica de C# y comprender cómo se ejecuta un programa.

---

# 2️⃣ Programación Orientada a Objetos — POO

📂 [Ir al proyecto](./POO)

Introducción a uno de los conceptos fundamentales del desarrollo de software: la **Programación Orientada a Objetos**.

### Conceptos trabajados

* Clases.
* Objetos.
* Atributos.
* Propiedades.
* Métodos.
* Constructores.
* Instanciación de objetos.

Por ejemplo, una clase permite representar una entidad del mundo real:

```text
PERSONA
│
├── Nombre
├── Edad
├── Correo
│
└── MostrarDatos()
```

En C# podríamos representarla de la siguiente manera:

```csharp
public class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public void MostrarDatos()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {Edad}");
    }
}
```

🎯 **Objetivo:** comprender cómo utilizar clases y objetos para organizar mejor nuestros programas.

---

# 3️⃣ EjemploColecciones

📂 [Ir al proyecto](./EjemploColecciones)

En este proyecto comenzamos a trabajar con **colecciones de objetos**.

Una colección permite almacenar múltiples elementos dentro de una misma estructura.

### Conceptos trabajados

* `List<T>`.
* Agregar elementos.
* Eliminar elementos.
* Recorrer colecciones.
* Buscar elementos.
* Uso de ciclos.
* Colecciones de objetos.

Ejemplo:

```csharp
List<string> nombres = new List<string>();

nombres.Add("Ana");
nombres.Add("Pedro");
nombres.Add("Carlos");

foreach (string nombre in nombres)
{
    Console.WriteLine(nombre);
}
```

🎯 **Objetivo:** aprender a almacenar y administrar conjuntos de información dentro de nuestras aplicaciones.

---

# 4️⃣ ProyectoContactos

📂 [Ir al proyecto](./ProyectoContactos)

Proyecto práctico donde comenzamos a integrar diferentes conceptos vistos anteriormente.

La aplicación permite administrar información relacionada con **contactos**.

### Conceptos aplicados

* Clases.
* Objetos.
* Propiedades.
* Métodos.
* Colecciones.
* Registro de información.
* Búsqueda de información.
* Recorrido de listas.
* Organización del código.

La estructura conceptual de la aplicación es similar a:

```text
CONTACTO
│
├── Nombre
├── Teléfono
├── Correo
│
└── Datos del contacto
        │
        ▼
   List<Contacto>
```

🎯 **Objetivo:** comprender cómo integrar POO y colecciones dentro de una aplicación.

---

# 5️⃣ TareasPendientes

📂 [Ir al proyecto](./TareasPendientes)

Proyecto práctico para administrar una lista de **tareas pendientes**.

Este ejercicio permite aplicar los conceptos estudiados en una situación similar a una aplicación real.

Una tarea puede contener información como:

```text
TAREA
│
├── Descripción
├── Fecha
├── Estado
└── Prioridad
```

### Conceptos aplicados

* Programación Orientada a Objetos.
* Creación de clases.
* Objetos.
* Propiedades.
* Métodos.
* Colecciones.
* Agregar elementos.
* Modificar información.
* Eliminar elementos.
* Buscar información.
* Recorrer listas.

🎯 **Objetivo:** integrar los conocimientos adquiridos para construir una pequeña aplicación funcional.

---

# 🛠️ Tecnologías utilizadas

Durante el curso trabajaremos principalmente con:

* 🔷 **C#**
* 🟣 **.NET**
* 💻 **Visual Studio 2017 o 2022**
* 📦 **NuGet**
* 🌿 **Git**
* 🐙 **GitHub**

---

# 💻 Requisitos

Para trabajar con los proyectos se recomienda tener instalado:

### Visual Studio 2017/2022

Durante la instalación seleccionar la carga de trabajo:

**Desarrollo de escritorio de .NET**

También utilizaremos **Git** para trabajar con los repositorios.

---

# 📥 Clonar el repositorio

Para descargar el repositorio completo:

```bash
git clone https://github.com/ProfeHernanSaavedra/NET2026-301.git
```

Luego ingresar a la carpeta:

```bash
cd NET2026-301
```

---

# 🔄 Actualizar el repositorio

Como durante el semestre se agregarán nuevos ejemplos y proyectos, es recomendable actualizar periódicamente el repositorio.

```bash
git pull
```

Esto descargará los últimos cambios publicados por el profesor.

---

# ▶️ Ejecutar un proyecto

### Opción 1 — Visual Studio

1. Abrir **Visual Studio 2017/2022**.
2. Seleccionar **Abrir un proyecto o una solución**.
3. Ingresar a la carpeta del proyecto.
4. Abrir el archivo `.sln` o `.csproj`.
5. Ejecutar el proyecto.

También puede ejecutarse utilizando:

```text
Ctrl + F5
```

### Opción 2 — Terminal

Ingresar a la carpeta del proyecto y ejecutar:

```bash
dotnet run
```

---

# 📖 Metodología de trabajo

Durante las clases iremos avanzando progresivamente:

```text
Fundamentos de C#
       ↓
Variables y estructuras
       ↓
Programación Orientada a Objetos
       ↓
Clases y Objetos
       ↓
Colecciones
       ↓
Integración de conceptos
       ↓
Proyectos
```

La recomendación es **no limitarse a copiar el código**.

Es importante modificar los ejemplos, probar nuevas opciones y observar qué ocurre cuando cambiamos las instrucciones.

---

# 🎯 Objetivo general

El objetivo de este repositorio es complementar las clases mediante ejemplos prácticos y progresivos.

Más que memorizar instrucciones, buscamos comprender **cómo resolver problemas utilizando programación** y cómo organizar nuestras soluciones mediante las herramientas que proporciona **C# y .NET**.

---

**Programación .NET — Sección 301**
**Profesor Hernán Saavedra**
