Imports System

Namespace Shapes.VBLibrary

    Public Class Circle
        Inherits Shape

        Private _radius As Double

        Public Sub New(radius As Double)
            _radius = radius
        End Sub

        Public Property Radius As Double
            Get
                Return _radius
            End Get
            Set(value As Double)
                _radius = value
            End Set
        End Property

        Public Overrides Function Area() As Double
            Return Math.PI * Math.Pow(_radius, 2)
        End Function

        Public Function Circumference() As Double
            Return 2 * Math.PI * _radius
        End Function

    End Class

End Namespace
