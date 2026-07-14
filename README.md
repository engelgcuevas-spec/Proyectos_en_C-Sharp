# 🐍 Snake Console Game (C#)

¡Un clásico juego de Snake (la ondita/gusanito) desarrollado completamente en C# para la consola de comandos! Este proyecto utiliza programación orientada a objetos para separar las responsabilidades del mapa (`Lienzo`), el personaje (`Serpiente`) y los objetivos (`Comida`).

## 🚀 Características actuales
- **Movimiento fluido:** Controlado mediante las flechas del teclado en tiempo real.
- **Mecánica de crecimiento:** El gusanito incrementa su tamaño de forma dinámica cada vez que come una fruta (`O`).
- **Renderizado limpio:** Optimizado para borrar únicamente el rastro de la cola vieja, evitando el parpadeo molesto de la consola (`Console.Clear()`).

## 🛠️ Cómo jugar
1. Clona este repositorio o copia el código fuente en un proyecto de Consola de .NET.
2. Ejecuta la aplicación.
3. Utiliza las **Flechas del Teclado** (Arriba, Abajo, Izquierda, Derecha) para dirigir al gusanito.
4. Presiona **Escape (ESC)** en cualquier momento para salir del juego.

## 📈 Próximas mejoras (Backlog)
- [ ] Sistema de colisión con los bordes (Game Over).
- [ ] Sistema de auto-colisión (no morderse la cola).
- [ ] Contador de puntuación en tiempo real.
- [ ] Incremento de velocidad dinámico conforme aumenta la puntuación.
