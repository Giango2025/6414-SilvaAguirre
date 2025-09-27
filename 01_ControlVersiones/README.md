# 💾 Control de Versiones con Git: Comandos y Flujo de Trabajo

Este documento contiene la referencia rápida y el flujo de trabajo estándar utilizado en este repositorio. El objetivo es mantener un historial limpio, organizado y colaborativo.

---

## 💻 1. Comandos Básicos de Git

### 🚀 Inicialización y Seguimiento
```bash
git init                            # Inicializar repositorio local
git status                          # Mostrar archivos nuevos/modificados
git add .                           # Añadir todos los archivos al área de preparación (Staging Area)
📝 Commits e Historial
Bash

git commit -m "descripción"         # Registrar cambios con descripción clara
git log                             # Mostrar historial completo de commits
git log --oneline                   # Historial resumido (solo hash y mensaje)
🌐 Repositorios Remotos
Bash

git push origin main                # Enviar cambios locales a GitHub
git pull origin main                # Traer y fusionar los cambios remotos