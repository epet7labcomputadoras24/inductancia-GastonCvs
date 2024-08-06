
Module Program
    Sub Main(args As String())
        Dim XL As Single
        Dim L As Single
        Dim F As Single
        Dim PI As Single
        PI = 3.1415
        Console.Write("De el valor de su inductancia: ")
        L = Console.ReadLine()
        Console.Write("De el valor de su frecuencia: ")
        F = Console.ReadLine()
        XL = (2 * PI * F * L)
        Console.Write("El valor de su XL es de: " & XL)
        Console.ReadLine()
    End Sub
End Module
