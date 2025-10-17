# Mini-Proyecto-PlataformaCD

Descripción del proyecto

El programa Gestión de Tareas es una aplicación de consola desarrollada en C# que permite al usuario registrar, visualizar y administrar sus tareas académicas o personales mediante una estructura de cola (Queue).
El sistema utiliza un menú interactivo que facilita la gestión secuencial de las tareas pendientes, simulando una lista ordenada FIFO (First In, First Out), es decir, la primera tarea en entrar será la primera en realizarse.

Funcionalidades principales

    El programa presenta un menú con las siguientes opciones:

    Agregar Tarea
    Permite registrar una nueva tarea solicitando dos datos:

    Asignatura (solo letras y espacios)

Descripción
    Cada tarea se agrega a la cola con un número de listado automático.

    Realizar Tarea
    Marca la primera tarea en la cola como completada y la elimina de la lista de pendientes.

    Mostrar Siguiente Tarea
    Muestra cuál es la próxima tarea que debe realizarse, sin eliminarla de la cola.

    Mostrar Cantidad de Tareas Pendientes
    Indica cuántas tareas hay actualmente registradas en la cola.

    Mostrar Todas las Tareas
    Muestra todas las tareas pendientes, enumeradas y formateadas con márgenes para una visualización más ordenada.

    Salir del Programa
    Finaliza la ejecución de la aplicación.

Estructuras y conceptos utilizados

    Queue<string> (Cola genérica)
    Se utiliza para almacenar las tareas pendientes, ya que permite un manejo ordenado tipo FIFO.
    Ejemplo:

    Queue<string> tareas = new Queue<string>();


    Funciones modulares
    Cada opción del menú se implementa como una función independiente para mantener un código limpio y fácil de mantener:

    AgregarTarea()

    RealizarTarea()

    SiguienteTarea()

    MostrarCantidad()

    MostrarTareas()

    CerrarPrograma()

    Validaciones de entrada
    Se controla que el usuario no deje campos vacíos y que los datos sean válidos (por ejemplo, la asignatura solo puede contener   letras).

    Uso de bucles do-while y estructuras switch
    Permiten ejecutar el menú de forma continua hasta que el usuario elija salir.

Ejemplo de ejecución

    **** GESTIÓN DE TAREAS ****
    1. Agregar Tarea
    2. Realizar Tarea
    3. Mostrar siguiente Tarea
    4. Mostrar cantidad de Tareas pendientes
    5. Mostrar todas las Tareas por realizar
    6. Salir del programa
    >>> 1

    **** AGREGAR TAREA ****
    Asignatura: Programación
    Descripción de la tarea: Crear código con funciones

    Tarea agregada correctamente.


    Y al listar todas las tareas:

    **** TAREAS PENDIENTES ****
    1: ****Tarea #1 ****   Análisis - Descripción de tarea: Diagrama de flujo
    2: ****Tarea #2 ****   Programación - Descripción de tarea: Código con procedimientos

Tecnologías utilizadas

    Lenguaje: C#

    Entorno: .NET SDK 6.0 o superior

    Plataforma: Aplicación de consola (Console App)

Cómo ejecutar el programa

    Abrir el proyecto en Visual Studio, Visual Studio Code o cualquier entorno compatible con C#.

    Compilar el programa (Ctrl + F5 o dotnet run si usas la terminal).

Interactuar con el menú mediante el teclado numérico.

Autores

    José Alessandro Torres Parodi.
    Jonas Frank Ethelbert Hodgson Cajina.
    Alejandro Enrique Zeledón del Cid.
    Rommel Alexander Muñoz Guerrero.

    Proyecto educativo desarrollado como práctica de programación en C#, orientado al uso de estructuras de datos y validación de entradas de usuario.