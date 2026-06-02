# 🎓 Calculadora de Matrices — *Professor Vector*

> *"Arithmancy was Hermione's favorite subject."* — J.K. Rowling

Aplicación de escritorio desarrollada en **C# / Windows Forms** que permite 
realizar **7 operaciones matriciales** sobre matrices cuadradas de **2×2 hasta 5×5**. 

Inspirada en la profesora **Septima Vector**, quien enseña Aritmancia 
(la rama mágica de las matemáticas) en Hogwarts. 🔢🪄

---

## ✨ Operaciones disponibles

| # | Operación | Descripción |
|---|-----------|-------------|
| 1 | **Suma** | Adición de dos matrices del mismo tamaño |
| 2 | **Resta** | Sustracción de dos matrices del mismo tamaño |
| 3 | **Multiplicación** | Producto matricial |
| 4 | **Inversa** | Matriz inversa (si el determinante ≠ 0) |
| 5 | **Transpuesta** | Intercambio de filas y columnas |
| 6 | **Escalar** | Multiplicación por un número |
| 7 | **Determinante** | Cálculo del determinante |

**Dimensiones soportadas:** 2×2 · 3×3 · 4×4 · 5×5

---

## 🛠️ Stack tecnológico

| Capa | Tecnología |
|------|-----------|
| Lenguaje | **C#** |
| Framework | **.NET Framework 4.6.1** |
| UI | **Windows Forms** |
| IDE recomendado | Visual Studio 2017 o superior |

---

## 📋 Requisitos

- 🪟 **Sistema operativo:** Windows 7 o superior
- 🔧 **.NET Framework 4.6.1** o superior ([descargar aquí](https://dotnet.microsoft.com/download/dotnet-framework/net461))
- 💻 **Visual Studio 2017+** (solo si vas a compilar el código)

---

## 🚀 Cómo correr el proyecto

### Opción A: Desde Visual Studio (recomendado)

1. Clonar el repositorio:
```bash
   git clone https://github.com/AccioData29/professor-vector.git
   cd professor-vector
```
2. Abrir el archivo `ALGEBRA.sln` en **Visual Studio**
3. Presionar **F5** (o el botón ▶ Start) para compilar y ejecutar

### Opción B: Desde la línea de comandos

```bash
msbuild ALGEBRA.csproj /p:Configuration=Debug
```

El ejecutable se generará en: