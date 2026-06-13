# 🎸 RockVault — Biblioteca de Música Rock

Proyecto ASP.NET Core MVC (.NET 9) con tema visual de música rock y
paleta de colores fluorescentes (rosa neón, verde neón, amarillo neón
y cian neón) sobre fondo casi negro.

## Cómo ejecutarlo

Requiere tener instalado el [.NET 9 SDK](https://dotnet.microsoft.com/download).

```bash
cd RockVault
dotnet run
```

Luego abre la URL que muestre la consola (algo como `https://localhost:5001`).

## Estructura

- `Controllers/HomeController.cs` — controlador con las acciones `Index`, `Privacy` y `Error`.
- `Views/Home/Index.cshtml` — página principal (hero, ficha del proyecto, disco de vinilo animado y ecualizador).
- `Views/Home/Privacy.cshtml` — página de privacidad.
- `Views/Shared/_Layout.cshtml` — layout con header, navegación y footer.
- `wwwroot/css/site.css` — toda la temática visual (colores, tipografías y animaciones).

## Qué personalizar

1. **Nombre del proyecto / logo**: busca `🎸 RockVault` en `_Layout.cshtml` y cámbialo por el nombre de tu proyecto.
2. **Ficha del proyecto** (Curso, Fase, Integrantes, Estado): edítalo directamente en `Views/Home/Index.cshtml`, dentro de `.pass-card`.
3. **Botón de contacto (WhatsApp)**: en `_Layout.cshtml`, reemplaza el número `50200000000` por tu número real (formato internacional sin signos `+` ni espacios) y ajusta el mensaje en el parámetro `text=`.
4. **Colores fluorescentes**: todos definidos como variables CSS al inicio de `site.css` (`--neon-pink`, `--neon-green`, `--neon-yellow`, `--neon-cyan`). Cambia los valores hexadecimales para ajustar la paleta.
5. **Tipografías**: `Anton` (títulos grandes), `Space Grotesk` (texto) y `Space Mono` (etiquetas/ficha), cargadas desde Google Fonts en `site.css`.

## Detalles de diseño

- El título principal tiene una animación de "parpadeo" tipo letrero de neón.
- El disco de vinilo gira lentamente y el ecualizador simula barras de audio en movimiento.
- Las animaciones se desactivan automáticamente si el usuario tiene activada la preferencia de "reducir movimiento" en su sistema.
