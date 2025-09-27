# Variables de ejemplo (se pueden cambiar para probar diferentes resultados)
tipo_vehiculo = "coche" # Puede ser "coche", "moto", "camion"
antiguedad_vehiculo = 15  # Años de antigüedad
tiene_pegatina_ambiental = True

# Condicional Anidado Múltiple
print(f"Evaluando vehículo: {tipo_vehiculo} con {antiguedad_vehiculo} años.")

# 1. Condición Externa: Tipo de vehículo (la decisión más general)
if tipo_vehiculo == "coche":
    print("🚗 Es un coche. Verificando antigüedad...")
    
    # 2. Condición Anidada 1: Antigüedad del vehículo (el primer filtro específico)
    if antiguedad_vehiculo < 10:
        print("  ✅ Coche Moderno (menos de 10 años). Puede circular sin restricciones.")
        
    # 3. Condición Anidada 2 (Elif): Rango de antigüedad intermedio
    elif antiguedad_vehiculo <= 20:
        print("  🟡 Coche Intermedio (10-20 años). Revisando pegatina...")
        
        # 4. Condición Anidada Múltiple: Si está en el rango intermedio, 
        #    se requiere un tercer nivel de verificación: la pegatina.
        if tiene_pegatina_ambiental:
            print("    ✅ Permiso: Tiene pegatina ambiental. ¡Puede circular!")
        else:
            print("    ❌ Restricción: ¡No tiene pegatina! Circulación limitada.")
            
    # 5. Condición Anidada 3 (Else): Coche Clásico o muy antiguo
    else:
        print("  🛑 Coche Clásico (más de 20 años). Acceso restringido a zonas especiales.")

# Condición Externa (Else): Cualquier otro tipo de vehículo (moto, camión, etc.)
else:
    print(f"🛵/🚛 Es un vehículo diferente a 'coche' ({tipo_vehiculo}). Aplicar normativa específica.")