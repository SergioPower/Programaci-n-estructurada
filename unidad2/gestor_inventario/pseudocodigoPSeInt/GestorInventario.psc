Algoritmo GestorDeInventario
	Definir  productos[5] Como Caracter
    Definir  precios[5] Como Real
    Definir  cantidades[5] Como Entero
    Definir  menu, i, opcion, siNo, totalInventario, totalProducto Como Entero
	Definir  nombre Como Caracter
	Definir  inventarioLleno, inventarioVacio, encontrado Como Logico
		
	Para i <- 1 Hasta 5 Hacer
		productos[i] <- ""
		precios[i] <- 0
		cantidades[i] <- 0
	Fin Para
		
	inventarioLleno <- Falso
	inventarioVacio <- Verdadero
		
	Escribir "Bienvenido al inventario"

		
	Repetir
		Escribir "Ingrese el número de opción: 1.- Agregar  2.- Modificar  3.- Consultar  4.- Salir  5.- Eliminar"
		Leer menu
			
		Segun menu Hacer
				
			Caso 1:
				Si inventarioLleno Entonces
					Escribir "Inventario lleno, elimine un producto para agregar uno nuevo."
				Sino
					Repetir
						Escribir "¿En qué espacio quieres almacenar el producto? (capacidad 5)"
						Leer i
						
						Si productos[i] = "" Entonces
							Escribir "Ingresa el nombre del producto:"
							Leer nombre
							productos[i] <- nombre
							
							Escribir "Ingresa el precio unitario:"
							Leer precios[i]
							
							Escribir "Ingresa la cantidad:"
							Leer cantidades[i]
							
							inventarioVacio <- Falso
							Escribir productos[i], " agregado al inventario."
								
							Si productos[1] <> "" Y productos[2] <> "" Y productos[3] <> "" Y productos[4] <> "" Y productos[5] <> "" Entonces
								inventarioLleno <- Verdadero
							Fin Si
						Sino
							Escribir "Ya está registrado ese producto."
						Fin Si
							
						Escribir "¿Desea agregar otro producto? (1.- Sí, 2.- No)"
						Leer siNo
					Hasta Que siNo = 2
				Fin Si
							
			Caso 2:
				Repetir
					Escribir "Escribe el nombre del producto a modificar:"
					Leer nombre
					
					encontrado <- Falso
					Para i <- 1 Hasta 5 Hacer
						Si productos[i] = nombre Entonces
							encontrado <- Verdadero
							Salir Para
						Fin Si
					Fin Para
					
					Si encontrado Entonces
						Escribir "¿Desea cambiar el precio (1) o la cantidad (2)?"
						Leer opcion
						Si opcion = 1 Entonces
							Escribir "Ingresa el nuevo precio:"
							Leer precios[i]
						Sino Si opcion = 2 Entonces
							Escribir "Ingresa la nueva cantidad:"
							Leer cantidades[i]
						Fin Si											
						Escribir productos[i], " actualizado."
					Sino
						Escribir "Producto no encontrado."
					Fin Si
						
					Escribir "¿Desea modificar otro producto? (1.- Sí, 2.- No)"
					Leer siNo
				Hasta Que siNo = 2
					
			Caso 3:
				totalInventario <- 0
				Para i <- 1 Hasta 5 Hacer
					Si productos[i] <> "" Entonces
						totalProducto <- precios[i] * cantidades[i]
						totalInventario <- totalInventario + totalProducto
						Escribir "Producto: ", productos[i], " Precio: ", precios[i], " Cantidad: ", cantidades[i]
						Escribir "Valor total del producto: ", totalProducto
					Fin Si
				Fin Para
				Escribir "Valor total del inventario: ", totalInventario
				
			Caso 4:
				Escribir "¿Desea salir? (1.- No, 2.- Sí)"
				Leer siNo
				Si siNo = 2 Entonces
					Salir
				Fin Si
				
			Caso 5:
				Repetir
					Escribir "Escribe el nombre del producto a eliminar:"
					Leer nombre
					encontrado <- Falso
					Para i <- 1 Hasta 5 Hacer
						Si productos[i] = nombre Entonces
							encontrado <- Verdadero
							Salir Para
						Fin Si
					Fin Para
						
					Si encontrado Entonces
						productos[i] <- ""
						precios[i] <- 0
						cantidades[i] <- 0
						inventarioLleno <- Falso
						Escribir "Producto eliminado."
					Sino
						Escribir "Producto no encontrado."
					Fin Si
					Escribir "¿Desea eliminar otro producto? (1.- Sí, 2.- No)"
					Leer siNo
				Hasta Que siNo = 2
				
			Fin Segun
		Hasta Que menu = 4
			
		Escribir "Fin del programa."
FinAlgoritmo
