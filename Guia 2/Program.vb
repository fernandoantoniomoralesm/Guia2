Imports System

Module main
	Sub Main()
		Dim opcion As Integer = 0

		While opcion >= 0 And opcion <= 9
			Console.WriteLine("1-Contar")
			Console.WriteLine("2-Suma")
			Console.WriteLine("3-Adivinanza")
			Console.WriteLine("4-Factorial")
			Console.WriteLine("5-Tablas")
			Console.WriteLine("6-NumerosImpares")
			Console.WriteLine("7-POO1A2019")
			Console.WriteLine("8-Conjuntos")
			Console.WriteLine("9-Cadena inversa")
			Console.WriteLine("Elija una opcion <1-8> o presione cualquier otro numero para salir")
			opcion = Console.ReadLine
			If opcion = 1 Then
				contar()
			End If
			If opcion = 2 Then
				suma()
			End If
			If opcion = 3 Then
				Adivinanza()
			End If
			If opcion = 4 Then

				factorial()
			End If
			If opcion = 5 Then
				Tablas()
			End If
			If opcion = 6 Then
				NumerosImpares()
			End If
			If opcion = 7 Then
				POO1A2019()
			End If
			If opcion = 8 Then
				Conjuntos()
			End If
			If opcion = 9 Then
				inversa()
			End If


		End While
	End Sub

	Sub contar()
		Dim contador As Integer = 1
		Dim cade As String
		Dim total As Integer
		Console.WriteLine("Ingresa palabras.")
		cade = Console.ReadLine()
		contador = cade.Split().Length
		Console.WriteLine("Cantidad de palabras ingresadas: " & contador)
		Console.ReadLine()

		cade = cade.Replace(" ", String.Empty)
		total = cade.Length
		Console.WriteLine("La longitud es: " & total)
		Console.ReadLine()

	End Sub
	Sub suma()
		Dim num As Integer = 1
		Dim num2 As Integer = 3
		Dim suma As Integer = 0
		Dim operador As Integer = 2
		Console.WriteLine("Ingrese un numero: ")
		num = Console.ReadLine
		While num2 < num
			suma = num2 + operador
			num2 = num2 + 1
			operador = operador + 1
			Console.WriteLine("Resultado: " & suma)
			Console.ReadLine()
		End While

	End Sub
	Sub factorial()
		Dim num As Integer
		Dim z As Integer = 1
		Dim fac As Integer
		Console.WriteLine("Escriba un numero")
		num = Console.ReadLine()


		For fac = 1 To num
			z = z * fac
			Console.WriteLine("" & z)
			Console.ReadLine()
		Next

		Console.ReadLine()
	End Sub
	Sub Tablas()
		Dim num, res As Integer
		Console.WriteLine("Ingresa un numero")
		num = Console.ReadLine()

		For i = 1 To 10
			res = num * i
			Console.WriteLine("=" & res)

		Next
		Console.ReadLine()
	End Sub
	Sub NumerosImpares()
		Dim num As Integer
		Dim con As Integer
		For index = 1 To 40
			If index Mod 2 > 0 Then
				num = index
				con = num + 1
				Console.WriteLine("" & num)
			End If
		Next
		Console.ReadLine()
	End Sub
	Sub POO1A2019()
		Dim compas As New List(Of String) From {"Glenda", "Geovany", "Gerardo", "Mauricio", "Kevin"}
		Console.WriteLine("Estudiantes de POO1")
		For Each estudiante As String In compas
			Console.WriteLine(estudiante)
		Next
		Console.ReadLine()
	End Sub
	Sub Conjuntos()
		Dim grupo1 As New List(Of Integer) From {1, 10, 20, 30, 40}
		Dim grupo2 As New List(Of Integer) From {1, 2, 3, 4, 5}
		Dim opcion As Integer = 0
		While opcion = 0 Or opcion > 0 And opcion < 5
			Console.WriteLine("Que operacion desea realizar:")
			Console.WriteLine("1- SUMA:")
			Console.WriteLine("2- RESTA:")
			Console.WriteLine("3- MULTIPLICACION:")
			Console.WriteLine("4- DIVISION:")
			opcion = Console.ReadLine()
			If opcion = 1 Then
				Console.WriteLine("SUMA")
				Console.ReadLine()
				For Each num As Integer In grupo1
					For Each num1 As Integer In grupo2
						Console.WriteLine(num + num1)
						Console.ReadLine()
					Next
				Next
			End If
			If opcion = 2 Then
				Console.WriteLine("RESTA")
				Console.ReadLine()
				For Each num As Integer In grupo1
					For Each num1 As Integer In grupo2
						Console.WriteLine(num - num1)
						Console.ReadLine()
					Next
				Next
			End If
			If opcion = 3 Then
				Console.WriteLine("MULTIPLICACION")
				Console.ReadLine()
				For Each num As Integer In grupo1
					For Each num1 As Integer In grupo2
						Console.WriteLine(num * num1)
						Console.ReadLine()
					Next
				Next
			End If
			If opcion = 4 Then
				Console.WriteLine("DIVISION")
				Console.ReadLine()

				For Each num As Integer In grupo1
					For Each num1 As Integer In grupo2
						Console.WriteLine(num / num1)
						Console.ReadLine()
					Next
				Next
			End If
			Exit While
		End While

	End Sub
	Sub Adivinanza()
		Dim a As New Random
		Dim b As Integer = a.Next(1, 11)
		Dim respuesta As Integer = 0
		Do While respuesta <> b
			Console.WriteLine("Escriba su numero <1-10>: ")
			respuesta = Console.ReadLine()
			If respuesta = b Then
				Console.WriteLine("RESPUESTA CORRECTA: " & b)
			Else
				Console.WriteLine("INCORRECTO. PULSE ENTER PARA SEGUIR INTENTANDO.")
			End If

			Console.ReadLine()
		Loop

	End Sub
	Sub inversa()
		Dim cadena As String
		Console.WriteLine("Escriba una palabra: ")
		cadena = Console.ReadLine()
		For i = 0 To cadena.Length() - 1
			Console.WriteLine(cadena.Reverse(i))
		Next
		Console.ReadLine()
	End Sub
End Module



