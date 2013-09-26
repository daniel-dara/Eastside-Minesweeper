Public Class MineTile
    Private _mine As Boolean
    Private _mark As Integer
    Private _x As Integer
    Private _y As Integer
    Private _surroundingmines As Integer
    Private _clicked As Boolean

    Public Property Mine() As Boolean
        Get
            Return _mine
        End Get
        Set(ByVal value As Boolean)
            _mine = value
        End Set
    End Property

    Public Property Mark() As Integer
        Get
            Return _mark
        End Get
        Set(ByVal value As Integer)
            _mark = value
        End Set
    End Property

    Public Property X() As Integer
        Get
            Return _x
        End Get
        Set(ByVal value As Integer)
            _x = value
        End Set
    End Property

    Public Property Y() As Integer
        Get
            Return _y
        End Get
        Set(ByVal value As Integer)
            _y = value
        End Set
    End Property

    Public Property SurroundingMines() As Integer
        Get
            Return _surroundingmines
        End Get
        Set(ByVal value As Integer)
            _surroundingmines = value
        End Set
    End Property

    Public Property Clicked() As Boolean
        Get
            Return _clicked
        End Get
        Set(ByVal value As Boolean)
            _clicked = value
        End Set
    End Property

    Public Sub New()
        _mine = False
        _mark = 0
        _x = 0
        _y = 0
        _surroundingmines = 0
        _clicked = False
    End Sub

    Public Sub New(ByVal Mine As Boolean, ByVal Mark As Integer, ByVal tX As Integer, ByVal tY As Integer, Optional ByVal Clicked As Boolean = False)
        _mine = Mine
        _mark = Mark
        _x = tX
        _y = tY
        _clicked = Clicked
    End Sub
End Class
