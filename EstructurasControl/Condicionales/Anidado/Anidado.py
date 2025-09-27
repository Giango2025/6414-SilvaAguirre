# Variables que podríamos usar en un contexto diario
estado_tienda = "abierta"
saldo_cuenta = 55.00
coste_articulo = 45.99

# Condicional anidado
if estado_tienda == "abierta":
    print("La tienda está abierta. ¡Puedes intentar comprar!")
    
    # Condición anidada: verificar si hay suficiente dinero
    if saldo_cuenta >= coste_articulo:
        print("✅ Saldo suficiente. ¡Compra realizada con éxito!")
        saldo_restante = saldo_cuenta - coste_articulo
        print(f"Tu nuevo saldo es: ${saldo_restante:.2f}")
    else:
        print("❌ Saldo insuficiente. No se puede completar la compra.")
        print(f"Necesitas ${coste_articulo - saldo_cuenta:.2f} más.")
        
else:
    print("La tienda está cerrada. Vuelve más tarde.")