# Conversor de Temperaturas con Menú
print("🌡️ CONVERSOR DE TEMPERATURAS 🌡️")
print("=" * 35)

while True:
    print("\n¿Qué conversión deseas hacer?")
    print("1. Celsius a Fahrenheit y Kelvin")
    print("2. Fahrenheit a Celsius")
    print("3. Kelvin a Celsius")
    print("4. Salir")
    
    opcion = input("Elige una opción (1-4): ")
    
    if opcion == "1":
        # Conversión Celsius a Fahrenheit y Kelvin
        celsius = float(input("Ingrese la temperatura en grados Celsius: "))
        fahrenheit = (celsius * 9 / 5) + 32
        kelvin = celsius + 273.15
        print(f"✅ {celsius}°C = {fahrenheit}°F")
        print(f"✅ {celsius}°C = {kelvin}K")
        
    elif opcion == "2":
        # Conversión Fahrenheit a Celsius
        fahrenheit = float(input("Ingrese la temperatura en grados Fahrenheit: "))
        celsius = (fahrenheit - 32) * 5 / 9
        print(f"✅ {fahrenheit}°F = {celsius}°C")
        
    elif opcion == "3":
        # Conversión Kelvin a Celsius
        kelvin = float(input("Ingrese la temperatura en Kelvin: "))
        celsius = kelvin - 273.15
        print(f"✅ {kelvin}K = {celsius}°C")
        
    elif opcion == "4":
        print("👋 ¡Hasta pronto!")
        break
        
    else:
        print("❌ Opción no válida. Intenta de nuevo.")
    
    # Pausa antes de continuar
    input("\nPresiona Enter para continuar...")