Imports System

Namespace Shapes.VBLibrary
    Public Class Square
        Private _length As Double

        Public Sub New(length As Double)
            _length = length
        End Sub

        Public ReadOnly Property Length() As Double
            Get
                Return _length
            End Get
        End Property

        Public Function Area() As Double
            Return Math.Pow(_length, 2)
        End Function

        Public Function Perimeter() As Double
            Return 4 * _length
        End Function
    End Class
End Namespace
