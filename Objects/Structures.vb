Public Structure OffsetLocation
    Public X, Y As Byte

    Public Sub New(ByVal x As Byte, ByVal y As Byte)
        Me.X = x
        Me.Y = y
    End Sub
End Structure

Public Structure TileArea
    Public X, Y As UInt16
    Public Z As Byte

    Public Sub New(ByVal x As UInt16, ByVal y As UInt16, ByVal z As Byte)
        Me.X = x
        Me.Y = y
        Me.Z = z
    End Sub
End Structure

Public Structure BitmapTileTransformDefinition
    Public Color1 As Color
    Public Color2 As Color
    Public ID As Short

    Public Sub New(ByVal id As Short, ByVal color1 As Color, ByVal color2 As Color)
        Me.ID = id
        Me.Color1 = color1
        Me.Color2 = color2
    End Sub
End Structure

Public Structure Tile
    Public Location As OffsetLocation
    Public Id As UShort
End Structure
