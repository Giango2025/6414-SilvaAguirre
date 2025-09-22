# Programa para calcular promedios de manera secuencial y sencilla
print("📊 CALCULADORA DE PROMEDIOS 📊")
print("=" * 30)

# Solicitar la cantidad de números a promediar
while True:
    try:
        cantidad = int(input("¿Cuántos números quieres promediar? "))
        if cantidad > 0:
            break
        else:
            print("❌ Debe ser un número mayor que 0")
    except ValueError:
        print("❌ Por favor ingresa un número válido")

# Lista para almacenar los números
numeros = []

# Solicitar los números uno por uno
print(f"\nIngresa los {cantidad} números:")
for i in range(cantidad):
    while True:
        try:
            numero = float(input(f"Número {i + 1}: "))
            numeros.append(numero)
            break
        except ValueError:
            print("❌ Ingresa un número válido")

# Calcular el promedio
suma = sum(numeros)
promedio = suma / cantidad

# Mostrar resultados
print("\n" + "=" * 30)
print("📋 RESULTADOS:")
print(f"Números ingresados: {numeros}")
print(f"Suma total: {suma}")
print(f"Cantidad de números: {cantidad}")
print(f"🎯 Promedio: {promedio:.2f}")

# Información adicional
print("\nℹ️  Información adicional:")
print(f"Número mayor: {max(numeros)}")
print(f"Número menor: {min(numeros)}")
print(f"Rango: {max(numeros) - min(numeros):.2f}")