# Variables de ejemplo
usuario_logueado = True
rol_usuario = "administrador"
pagina_a_visitar = "panel_de_configuracion"

# Condicional Anidado Simple
print(f"Intentando acceder a: {pagina_a_visitar}")

# 1. Condición Externa: Verificar la sesión (el requisito principal)
if usuario_logueado:
    print("✅ Usuario autenticado. Verificando permisos...")
    
    # 2. Condición Anidada: Verificar el permiso específico
    if rol_usuario == "administrador":
        print("🎉 ¡Acceso concedido! Bienvenido al panel de administración.")
    else:
        # El 'else' pertenece solo al 'if' anidado
        print("❌ Permiso denegado. Se requiere ser 'administrador' para esta página.")
        
else:
    # El 'else' pertenece al 'if' externo
    print("🛑 Acceso denegado. Debes iniciar sesión primero.")