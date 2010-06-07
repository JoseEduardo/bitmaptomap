Imports System.Collections.Generic
Imports System.Text
Imports System.IO
Imports System.Xml

Public Class OtbmWriter

#Region "Variables"
    Private fileName As String
    Private filePath As String
    Private fullPath As String
    Private fileStream As FileStream
#End Region

#Region "Constructor"
    Public Sub New(ByVal fileName As String, ByVal filePath As String)
        Me.fileName = fileName
        Me.filePath = filePath
        Me.fullPath = String.Format("{0}{1}", filePath, fileName)
    End Sub
#End Region

#Region "Open and close file stream"
    Public Function OpenStream() As Boolean
        Try
            fileStream = File.OpenWrite(fullPath)
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Sub CloseStream()
        fileStream.Close()
    End Sub
#End Region

#Region "Write basic data"
    Public Sub WriteBytes(ByVal data As Byte(), ByVal unescape As Boolean)
        For Each b As Byte In data
            If unescape AndAlso (b = Constants.NodeStart OrElse b = Constants.NodeEnd OrElse b = Constants.Escape) Then
                fileStream.WriteByte(Constants.Escape)
            End If

            fileStream.WriteByte(b)
        Next
    End Sub

    Public Sub WriteBytes(ByVal data As Byte())
        WriteBytes(data, True)
    End Sub

    Public Sub WriteByte(ByVal value As Byte)
        WriteByte(value, True)
    End Sub

    Public Sub WriteByte(ByVal value As Byte, ByVal unescape As Boolean)
        WriteBytes(New Byte() {value}, unescape)
    End Sub

    Public Sub WriteUInt16(ByVal value As UInt16)
        WriteBytes(BitConverter.GetBytes(value))
    End Sub

    Public Sub WriteUInt32(ByVal value As UInt32)
        WriteUInt32(value, True)
    End Sub

    Public Sub WriteUInt32(ByVal value As UInt32, ByVal unescape As Boolean)
        WriteBytes(BitConverter.GetBytes(value), unescape)
    End Sub

    Public Sub WriteString(ByVal text As String)
        WriteUInt16(CType(text.Length, UInt16)) 'String length
        WriteBytes(Encoding.ASCII.GetBytes(text)) 'String
    End Sub
#End Region

#Region "Write Map data"
    Public Sub WriteNodeStart(ByVal type As NodeType)
        WriteByte(Constants.NodeStart, False)
        WriteByte(CByte(type))
    End Sub

    Public Sub WriteNodeEnd()
        WriteByte(Constants.NodeEnd, False)
    End Sub

    Public Sub WriteAttrType(ByVal at As AttrType)
        WriteByte(CByte(at))
    End Sub

    Public Sub WriteMapHeader(ByVal version As Version, ByVal size As Drawing.Size)
        ' Version, unescaped
        WriteUInt32(0, False)

        ' Root node
        WriteNodeStart(NodeType.RootV1)

        ' Header information
        ' Version
        WriteUInt32(2)
        ' Width
        WriteUInt16(size.Width)
        ' Height
        WriteUInt16(size.Height)

        ' Major version items
        WriteUInt32(CUInt(version.Major))
        ' Minor version items
        WriteUInt32(CUInt(version.Minor))
    End Sub

    Public Sub WriteMapStart(ByVal houseFileName As String, ByVal spawnFileName As String)
        WriteNodeStart(NodeType.MapData)

        WriteAttrType(AttrType.Description)
        WriteString("Created by BitMapToMap: http://tools.tibiaug.com/")

        WriteAttrType(AttrType.ExtHouseFile)
        WriteString(houseFileName)

        WriteAttrType(AttrType.ExpSpawnFile)
        WriteString(spawnFileName)
    End Sub
#End Region

#Region "Static Methods"
    Public Shared Function WriteMap(ByVal baseFileName As String, ByVal filePath As String, ByVal mapAreas As Dictionary(Of TileArea, List(Of Tile)), ByVal version As Version, ByVal size As Drawing.Size)
        'The name of our OTBM map file.
        Dim otbmFileName As String = String.Format("{0}.otbm", baseFileName)
        'Our house and spawn file names.
        Dim houseFileName As String = String.Format("{0}-house.xml", baseFileName)
        Dim spawnFileName As String = String.Format("{0}-spawn.xml", baseFileName)

        Return InternalCreateMap(otbmFileName, filePath, houseFileName, spawnFileName, version, mapAreas, size)
    End Function

    Private Shared Function InternalCreateMap(ByVal otbmFileName As String, ByVal filePath As String, ByVal houseFileName As String, ByVal spawnFileName As String, ByVal version As Version, ByVal mapAreas As Dictionary(Of TileArea, List(Of Tile)), ByVal size As Drawing.Size) As Boolean
        Dim mapWriter As New OtbmWriter(otbmFileName, filePath)
        'Open our file stream
        If Not mapWriter.OpenStream() Then Return False
        'Write our map header
        mapWriter.WriteMapHeader(version, size)
        'Write the spawn file, description, ETC
        mapWriter.WriteMapStart(houseFileName, spawnFileName)

        For Each tArea As TileArea In mapAreas.Keys
            'Write the "Area" for a specific set of tiles. We can place many tiles in a single "Area"
            'We only write the values of bits 9-16 (last byte) of the tiles absolute location for the area
            'Z remains the same
            mapWriter.WriteNodeStart(NodeType.TileArea)
            mapWriter.WriteUInt16(tArea.X)
            mapWriter.WriteUInt16(tArea.Y)
            mapWriter.WriteByte(tArea.Z)

            'Loop through all the tiles assigned to this area, and write them to the file
            For Each t As Tile In mapAreas(tArea)
                'Here, we will write the offset for the tile. The area is the tiles absolute location shifted to 
                'bits 0 - 8 (first byte) and is wrote as a byte
                mapWriter.WriteNodeStart(NodeType.Tile)
                mapWriter.WriteByte(t.Location.X)
                mapWriter.WriteByte(t.Location.Y)

                'Wrie the tiles ID
                mapWriter.WriteAttrType(AttrType.Item)
                mapWriter.WriteUInt16(t.Id)

                'Tile node
                mapWriter.WriteNodeEnd()
            Next


            'Area node
            mapWriter.WriteNodeEnd()
        Next

        mapWriter.WriteNodeEnd()
        'Map Data node
        mapWriter.WriteNodeEnd()
        'Root node
        mapWriter.CloseStream()

        Return True
    End Function
#End Region

End Class

