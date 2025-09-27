# Variables que podríamos usar en un smartphone o laptop
nivel_bateria = 15  # Porcentaje (0-100)
esta_cargando = False

# Condicional Anidado Doble (doble else)
if nivel_bateria > 20:
    # 1. Batería OK (Condición Externa)
    print("🔋 Batería suficiente. Uso normal.")
    
    # Condición Anidada: ¿Está cargando?
    if esta_cargando:
        print("  🟢 Dispositivo conectado. ¡Carga en progreso!")
    else:
        print("  🟢 Dispositivo desconectado. ¡Todo bien!")

else:
    # 2. Batería Baja (Condición Externa 'else')
    print("🚨 Nivel de batería BAJO. Considera conectar el cargador.")
    
    # Condición Anidada: ¿Está cargando A PESAR de estar baja?
    if esta_cargando:
        print("  ⚠️ Batería baja, pero está cargando. ¡Carga crítica en curso!")
    else:
        print("  🔴 ¡ADVERTENCIA! Batería baja y desconectada. Guarda tu trabajo.")