Control de Versiones - Fundamentos de Algoritmos
📋 Descripción
Este directorio contiene recursos, ejemplos y documentación sobre el sistema de control de versiones Git, utilizado para gestionar y trackear los cambios en el código a lo largo del desarrollo del proyecto.

🗂️ Estructura de Carpetas
text
01_ControlVersiones/
│
├── README.md           # Este archivo - Documentación principal
├── ejemplos/           # Carpeta con ejemplos visuales
│   ├── commits/        # Capturas de commits realizados
│   ├── logs/           # Ejemplos de historial de cambios
│   └── ramas/          # Visualización del flujo de ramas
└── recursos/           # Material adicional de referencia
💻 Comandos Git Utilizados
⚙️ Configuración Inicial
bash
# Configurar usuario y email (obligatorio para commits)
git config --global user.name "Tu Nombre"
git config --global user.email "tu.email@ejemplo.com"

# Configurar editor por defecto
git config --global core.editor "code --wait"

# Ver configuración
git config --list
📦 Inicialización del Repositorio
bash
# Iniciar repositorio local
git init

# Ver estado de los archivos
git status

# Añadir archivos al staging area
git add nombre_archivo.ext    # Archivo específico
git add .                     # Todos los archivos

# Realizar commit
git commit -m "Mensaje descriptivo del cambio"

# Ver historial de commits
git log
git log --oneline --graph --all  # Vista compacta con gráfico
🔗 Conexión con Repositorio Remoto (GitHub)
bash
# Añadir repositorio remoto
git remote add origin https://github.com/usuario/6414-LlanosBardales.git

# Ver remotos configurados
git remote -v

# Subir cambios al remoto
git push -u origin main

# Traer cambios del remoto
git pull origin main

# Clonar repositorio existente
git clone https://github.com/usuario/6414-LlanosBardales.git
🌿 Manejo de Ramas (Branches)
bash
# Crear nueva rama
git branch nombre-rama

# Cambiar entre ramas
git checkout nombre-rama
git switch nombre-rama      # Comando más moderno

# Crear y cambiar a nueva rama
git checkout -b nombre-rama

# Listar ramas
git branch                  # Ramas locales
git branch -a               # Todas las ramas (locales y remotas)

# Fusionar ramas
git merge nombre-rama

# Eliminar rama
git branch -d nombre-rama   # Eliminación segura
git branch -D nombre-rama   # Eliminación forzada
🔄 Flujo de Trabajo Típico
bash
# 1. Actualizar repositorio local
git pull origin main

# 2. Crear rama para nueva funcionalidad
git checkout -b feature/nueva-funcionalidad

# 3. Realizar cambios y commits
git add .
git commit -m "Implementar nueva funcionalidad"

# 4. Subir rama al remoto
git push -u origin feature/nueva-funcionalidad

# 5. Fusionar con rama principal (después de revisión)
git checkout main
git merge feature/nueva-funcionalidad
git push origin main
📊 Estados de Archivos en Git
text
Working Directory → Staging Area → Repository
     (Modificado)     (Preparado)    (Confirmado)
Modificado: Cambios realizados pero no preparados para commit

Preparado: Cambios añadidos al staging area listos para commit

Confirmado: Cambios guardados en el repositorio local

🚫 Manejo de Errores Comunes
Deshacer cambios no commitados
bash
# Descartar cambios en working directory
git checkout -- nombre_archivo.ext

# Quitar archivos del staging area
git reset HEAD nombre_archivo.ext
Modificar último commit
bash
# Añadir cambios olvidados al último commit
git commit --amend -m "Nuevo mensaje"
Revertir commits
bash
# Deshacer commit específico (crea nuevo commit)
git revert <commit-hash>

# Revertir a commit anterior (elimina commits posteriores)
git reset --hard <commit-hash>
📋 Buenas Prácticas
Mensajes de Commit
✨ Usar mensajes descriptivos en presente imperativo

🎯 Especificar el tipo de cambio: feat, fix, docs, style, refactor, test, chore

📝 Ejemplo: feat: añadir funcionalidad de login con validación

Flujo de Trabajo
🔄 Hacer pull regularmente para mantener local actualizado

🌿 Trabajar en ramas separadas para cada funcionalidad

✅ Testear cambios antes de commitear

📤 Hacer push frecuente para evitar conflictos

🖼️ Ejemplos Visuales
En la carpeta ejemplos/ encontrarás:

Capturas de pantalla de comandos ejecutados

Visualización del historial de commits (git log)

Diagramas de flujo de ramas

Ejemplos de resolución de conflictos

📚 Recursos Adicionales
Documentación oficial de Git

GitHub Guides

Git Cheat Sheet

Visual Git Guide