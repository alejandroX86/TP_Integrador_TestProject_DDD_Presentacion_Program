Pruebas Unitarias para Selección de Menú en Proyecto Hotel
Este repositorio contiene un proyecto de software desarrollado como parte del Trabajo Práctico de Laboratorio de Software, centrado en la implementación y pruebas unitarias para la capa de presentación que maneja la selección de opciones de menú en un sistema de reservas de hotel.

Descripción del Proyecto
El proyecto utiliza una arquitectura modular que incluye una capa de presentación responsable de mostrar opciones de menú al usuario y procesar su selección mediante un selector de menú. Las pruebas unitarias aseguran que la lógica de selección de menú funcione correctamente y maneje diferentes escenarios de entrada del usuario de manera adecuada.

Componentes Principales
Program.cs
El archivo Program.cs contiene el método Main que inicializa y ejecuta la lógica de selección de menú, mostrando las opciones disponibles y procesando la selección del usuario.

MenuSelector.cs
MenuSelector.cs implementa la interfaz IMenuSelector y contiene la lógica para seleccionar una opción de menú basada en la entrada del usuario.

MenuOption.cs
MenuOption.cs define la clase MenuOption, que representa una opción de menú con su número de opción y descripción asociada.

Menu.cs
Menu.cs gestiona la presentación de las opciones de menú y la interacción con el usuario, utilizando un IMenuSelector para seleccionar y procesar la opción elegida.

Pruebas Unitarias
Las pruebas unitarias están implementadas utilizando XUnit y Moq para simular el comportamiento del selector de menú y verificar su correcto funcionamiento.

MenuTests.cs
MenuTests.cs contiene las pruebas unitarias para verificar el comportamiento de la presentación de menú (ShowMenu) y el procesamiento de selección (ProcessSelection).

ShowMenu_WritesMenuOptionsToConsole: Verifica que las opciones de menú se escriban correctamente en la consola al llamar al método ShowMenu.

ProcessEmptyInput: Asegura que, al no ingresar ninguna opción válida, el sistema seleccione la opción por defecto (1) y muestre el resultado esperado en la consola.

Ejecución de las Pruebas
Para ejecutar las pruebas unitarias:

Clona este repositorio en tu máquina local.
Abre el proyecto en tu entorno de desarrollo preferido (Visual Studio, VS Code, etc.).
Asegúrate de tener las dependencias necesarias instaladas, como XUnit y Moq.
Ejecuta las pruebas desde tu IDE o utilizando el comando dotnet test en la terminal dentro del directorio del proyecto.
Importancia de las Pruebas Unitarias
Las pruebas unitarias son esenciales para garantizar la calidad del software, ya que:

Detectan errores en etapas tempranas del desarrollo.
Evitan regresiones al asegurar que nuevas implementaciones no afecten funcionalidades existentes.
Documentan el comportamiento esperado de las funciones y componentes del sistema.
Facilitan el mantenimiento y la refactorización del código al proporcionar una validación continua de su funcionamiento.
