# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Build & Run

This is a .NET Framework 4.6.1 Windows Forms project. Build with MSBuild or Visual Studio:

```
msbuild ALGEBRA.csproj /p:Configuration=Debug
```

Output goes to `bin\Debug\ALGEBRA.exe`. There is no test framework or lint tooling configured.

## Architecture

Single-form WinForms desktop application — a matrix calculator ("Calculadora de Matrices").

**Entry point:** `Program.cs` → instantiates and runs `Form1`.

**Form1.cs / Form1.Designer.cs:** The only meaningful UI. `Form1.cs` contains `inicializarFormulario()` which populates two dropdowns at startup:
- `cmbOperaciones` — 7 operations: Suma, Resta, Multiplicación, Inversa, Transpuesta, Escalar, Determinante
- `cmbDimension` — matrix sizes: 2x2, 3x3, 4x4, 5x5

**Current state:** UI shell is defined but the application is incomplete — button event handlers (`btnCalcular`, `btnLimpiar`, `btnSalir`), matrix input fields, calculation logic, and result display are not yet implemented.

**Language:** All UI labels, variable names, and code comments are in Spanish.
