Imports System
Imports System.Xml
Public Class Main
    'The name of our exported map file, taken from image name
    Dim mapName As String = ""

    'This is a list of points on out "Dropper" image which is shown when we are selecting
    'A color from the picture. These positions will be filled with the color we are currently
    'Hovered over. this lets the user better know what they have selected.
    'Making this static in the onPaint where it is used caused a program freeze,
    'Or it would be done that way
    Dim FillPoints() As Drawing.Point = {New Drawing.Point(2, 28), _
                            New Drawing.Point(2, 29), New Drawing.Point(3, 27), New Drawing.Point(3, 28), _
                            New Drawing.Point(3, 29), New Drawing.Point(4, 26), New Drawing.Point(4, 27), _
                            New Drawing.Point(4, 28), New Drawing.Point(5, 25), New Drawing.Point(5, 26), _
                            New Drawing.Point(5, 27), New Drawing.Point(6, 24), New Drawing.Point(6, 25), _
                            New Drawing.Point(6, 26), New Drawing.Point(7, 23), New Drawing.Point(7, 24), _
                            New Drawing.Point(7, 25), New Drawing.Point(8, 22), New Drawing.Point(8, 23), _
                            New Drawing.Point(8, 24), New Drawing.Point(9, 21), New Drawing.Point(9, 22), _
                            New Drawing.Point(9, 23), New Drawing.Point(10, 20), New Drawing.Point(10, 21), _
                            New Drawing.Point(10, 22), New Drawing.Point(11, 19), New Drawing.Point(11, 20), _
                            New Drawing.Point(11, 21), New Drawing.Point(12, 18), New Drawing.Point(12, 19), _
                            New Drawing.Point(12, 20), New Drawing.Point(13, 17), New Drawing.Point(13, 18), _
                            New Drawing.Point(13, 19), New Drawing.Point(14, 16), New Drawing.Point(14, 17), _
                            New Drawing.Point(14, 18), New Drawing.Point(15, 15), New Drawing.Point(15, 16), _
                            New Drawing.Point(15, 17), New Drawing.Point(16, 14), New Drawing.Point(16, 15), _
                            New Drawing.Point(16, 16), New Drawing.Point(17, 13), New Drawing.Point(17, 14), _
                            New Drawing.Point(17, 15), New Drawing.Point(18, 12), New Drawing.Point(18, 13), _
                            New Drawing.Point(18, 14), New Drawing.Point(19, 12), New Drawing.Point(19, 13), _
                            New Drawing.Point(20, 10), New Drawing.Point(20, 11), New Drawing.Point(21, 9), _
                            New Drawing.Point(21, 10), New Drawing.Point(21, 11), New Drawing.Point(22, 8), _
                            New Drawing.Point(22, 9), New Drawing.Point(22, 10), New Drawing.Point(23, 5), _
                            New Drawing.Point(23, 6), New Drawing.Point(23, 7), New Drawing.Point(23, 8), _
                            New Drawing.Point(23, 9), New Drawing.Point(24, 3), New Drawing.Point(24, 4), _
                            New Drawing.Point(24, 5), New Drawing.Point(24, 6), New Drawing.Point(24, 7), _
                            New Drawing.Point(24, 8), New Drawing.Point(25, 2), New Drawing.Point(25, 3), _
                            New Drawing.Point(25, 4), New Drawing.Point(25, 5), New Drawing.Point(25, 6), _
                            New Drawing.Point(25, 7), New Drawing.Point(25, 8), New Drawing.Point(26, 2), _
                            New Drawing.Point(26, 3), New Drawing.Point(26, 4), New Drawing.Point(26, 5), _
                            New Drawing.Point(26, 6), New Drawing.Point(26, 7), New Drawing.Point(26, 8), _
                            New Drawing.Point(27, 2), New Drawing.Point(27, 3), New Drawing.Point(27, 4), _
                            New Drawing.Point(27, 5), New Drawing.Point(27, 6), New Drawing.Point(27, 7), _
                            New Drawing.Point(28, 2), New Drawing.Point(28, 3), New Drawing.Point(28, 4), _
                            New Drawing.Point(28, 5), New Drawing.Point(28, 6), New Drawing.Point(28, 7), _
                            New Drawing.Point(29, 3), New Drawing.Point(29, 4), New Drawing.Point(29, 5), _
                            New Drawing.Point(29, 6)}

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DefAction.SelectedIndex = 0
        ControlsSetEnabled(New Control() {Me.Load}, False)

        'Recrusively add a mouseDown handler to every single control on this form
        AddUniversalMouseDownHandler(Me)
    End Sub

    Private Sub AddUniversalMouseDownHandler(ByVal cont As Control)
        For Each C As Control In cont.Controls
            AddHandler C.MouseDown, AddressOf ClearColorSelection
            AddUniversalMouseDownHandler(C)
        Next
    End Sub

    Private Sub ControlsSetEnabled(ByVal ignore As Control(), ByVal enabled As Boolean)
        For Each C As Control In Me.Controls
            If Not ignore.Contains(C) Then
                C.Enabled = enabled
            End If
        Next
    End Sub

#Region "Loading the image/Disabling and enabling controls when needed"
    Private Sub Load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Load.Click
        LoadFile.Title = "Load Image"
        LoadFile.Filter = "Image Files|*.jpeg;*.jpg;*.gif;*.bmp;*.png"
        LoadFile.FileName = ""
        LoadFile.ShowDialog(Me)

        If LoadFile.FileName <> "" Then
            Try
                'Make the mapName this files name, without the extension
                Dim ExtensionStarts As Integer = LoadFile.SafeFileName.LastIndexOf(".")
                mapName = LoadFile.SafeFileName.Remove(ExtensionStarts)

                'Set the path of this image to the default path on our folder browser
                Dim RemoveNameStarts As Integer = LoadFile.FileName.LastIndexOf(LoadFile.SafeFileName)
                SelectFolder.SelectedPath = LoadFile.FileName.Remove(RemoveNameStarts)

                'Load the image to the image box
                Imagebx.Image = Bitmap.FromFile(LoadFile.FileName)
                Imagebx.Invalidate()
                ControlsSetEnabled(New Control() {}, True)
            Catch ex As Exception
                MsgBox("Please select a valid image file.")
            End Try
        End If
    End Sub

    Private Sub Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear.Click
        Imagebx.Image = Nothing
        Imagebx.Invalidate()
    End Sub

    Private Sub Imagebx_Invalidated(ByVal sender As Object, ByVal e As System.Windows.Forms.InvalidateEventArgs) Handles Imagebx.Invalidated
        If Imagebx.Image Is Nothing Then
            Imagebx.Size = New Size(0, 0)
            ControlsSetEnabled(New Control() {Me.Load}, False)
        End If
    End Sub
#End Region

#Region "Colorizing"
    Private Sub Colorize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Colorize.Click
        Try
            ControlsSetEnabled(New Control() {Me.actionProgress}, False)
            Imagebx.Image = ColorizeImage(Imagebx.Image, Me.actionProgress)
            ControlsSetEnabled(New Control() {}, True)
        Catch ex As Exception
            MsgBox(ex.ToString)
            ControlsSetEnabled(New Control() {}, True)
        End Try
        Imagebx.Invalidate()
    End Sub
#End Region

#Region "Adding/Removing Color Definitions"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Item As ListViewItem

        If DefAction.SelectedIndex = 0 Then
            'Adding an item
            Item = New ListViewItem(AddID.Value)
            Item.SubItems.Add(Color1.BackColor.ToArgb)
            Item.SubItems.Add(Color2.BackColor.ToArgb)
        Else
            'Ignoring a color
            Item = New ListViewItem("Ignore")
            Item.SubItems.Add(Color1.BackColor.ToArgb)
            Item.SubItems.Add(0)
        End If

        ColorKey.Items.Add(Item)
    End Sub

    Private Sub DefAction_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefAction.SelectedIndexChanged
        'Enable/disable the itemID box and the color2 selector
        If DefAction.SelectedIndex = 1 Then
            Color2.Enabled = False
            Color2Dialog.Enabled = False
            AddID.Enabled = False
        Else
            Color2.Enabled = True
            Color2Dialog.Enabled = True
            AddID.Enabled = True
        End If
    End Sub
#End Region

#Region "Color Selector / Image dragging"
    'Variables
    Private SelectColorFor As Control = Nothing
    Private FillColor As Color
    Private CursorSpot As Drawing.Point
    Private DragStart As Drawing.Point

    Private Sub ClearColorSelection(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        'Stop color selection if we dont click the image box
        If sender IsNot Imagebx Then SelectColorFor = Nothing
    End Sub

    Private Sub Color1Dialog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Color1Dialog.Click
        ColorDialog.Color = Color1.BackColor
        ColorDialog.ShowDialog()

        If ColorDialog.Color <> Nothing Then
            Color1.BackColor = ColorDialog.Color
        End If
    End Sub

    Private Sub Color2Dialog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Color2Dialog.Click
        ColorDialog.Color = Color2.BackColor
        ColorDialog.ShowDialog()

        If ColorDialog.Color <> Nothing Then
            Color2.BackColor = ColorDialog.Color
        End If
    End Sub

    Private Sub Color1ANDColor2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Color1.Click, Color2.Click
        'Set the "SelectColorFor" for the color buttons which was clicked
        SelectColorFor = sender
    End Sub

    Private Sub Imagebx_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Imagebx.MouseEnter
        'If we are selecting a color, show the cross
        If SelectColorFor IsNot Nothing Then
            Cursor = Cursors.Cross
        End If
    End Sub
    Private Sub Imagebx_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Imagebx.Paint
        'If we are selecting a color, and the image has the mosue over it,
        'Draw the dropper with the color we are hovered over
        If Cursor = Cursors.Cross Then
            Dim dropper As Bitmap = My.Resources.Dropper
            For Each p As Point In FillPoints
                dropper.SetPixel(p.X, p.Y, FillColor)
            Next
            e.Graphics.DrawImage(dropper, CursorSpot)
        End If
    End Sub

    Private Sub Imagebx_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Imagebx.MouseUp
        'Set the back color of the button we are choosing for
        If SelectColorFor IsNot Nothing Then
            If Imagebx.Image IsNot Nothing Then
                Dim Bmp As New Bitmap(Imagebx.Image)
                If e.Y < Bmp.Height And e.X < Bmp.Width Then
                    SelectColorFor.BackColor = FillColor
                End If
            End If
        End If

        SelectColorFor = Nothing
        Imagebx.Invalidate()
        Cursor = Cursors.Default
    End Sub

    Private Sub Imagebx_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Imagebx.MouseLeave
        'Hide the cross since we are not over the image
        Cursor = Cursors.Default
    End Sub

    Private Sub Imagebx_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Imagebx.MouseDown
        'Since we arent selecting a color, set the start point for dragging
        If e.Button = Windows.Forms.MouseButtons.Left And SelectColorFor Is Nothing Then
            DragStart = New Point(e.X, e.Y)
        End If
    End Sub

    Private Sub Imagebx_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Imagebx.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left And SelectColorFor Is Nothing Then
            'Drag the image since we are not selecting a color
            Dim DeltaX As Integer = (DragStart.X - e.X)
            Dim DeltaY As Integer = (DragStart.Y - e.Y)

            Panel1.AutoScrollPosition = _
            New Drawing.Point((DeltaX - Panel1.AutoScrollPosition.X), _
                              (DeltaY - Panel1.AutoScrollPosition.Y))
        ElseIf SelectColorFor IsNot Nothing Then
            'Update the color to fill the dropper with
            CursorSpot = New Drawing.Point(e.X + 2, e.Y - 34)
            FillColor = New Bitmap(Imagebx.Image).GetPixel(e.X, e.Y)
            Imagebx.Invalidate()
        End If
    End Sub
#End Region

#Region "Editing our image"
    Private Sub RotateLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RotateLeft.Click
        If Imagebx.Image IsNot Nothing Then
            'Flip the image 270 degrees clockwise (360 - 90 = 270, so this is like 90 degrees counter-clockwise)
            Imagebx.Image.RotateFlip(RotateFlipType.Rotate270FlipNone)
            'Size the image box to fit it
            Imagebx.Size = Imagebx.Image.Size
            'Refresh the image box, only the area within the new size gets refreshed automatically
            Imagebx.Refresh()
        End If
    End Sub

    Private Sub RotateRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RotateRight.Click
        If Imagebx.Image IsNot Nothing Then
            'Flip the image 90 degrees clockwise
            Imagebx.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
            'Size the image box to fit it
            Imagebx.Size = Imagebx.Image.Size
            'Refresh the image box, only the area within the new size gets refreshed automatically
            Imagebx.Refresh()
        End If
    End Sub

    Private Sub Flip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Flip.Click
        'declare our images we'll use for flipping. Lets us avoid comparing current image, etc
        'Alternatively, we could just set a variable defining which flip image we are using, but this way
        'is funner
        Static FlipTo As Image = My.Resources.FlipRight
        Static OldFlip As Image = My.Resources.FlipLeft

        If Imagebx.Image IsNot Nothing Then
            'Change our buttons image
            Flip.Image = FlipTo
            'Make our "OldFlip" what we want to flip to next time, by giving FlipTo its value
            FlipTo = OldFlip
            'Make OldFlip into our current image, so we'll know what to use the time after next
            OldFlip = Flip.Image

            'Flip the image on its X axis
            Imagebx.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
            'Size the image box to fit it
            Imagebx.Size = Imagebx.Image.Size
            'Refresh the image box, only the area within the new size gets refreshed automatically
            Imagebx.Refresh()
        End If
    End Sub
#End Region

#Region "Saving our map"
    Private Sub Export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Export.Click
        If ColorKey.Items.Count = 0 Then MsgBox("Please define a color key first!", MsgBoxStyle.OkOnly) : Exit Sub

        'Select the path to save at
        SelectFolder.ShowDialog()
        Dim Path As String = SelectFolder.SelectedPath

        'A dictionary of different tiles, assigned to areas
        Dim TileDict As New Dictionary(Of TileArea, List(Of Tile))

        'A list of colors to ignore
        Dim IgnoreColors As New List(Of Color)

        Dim TempD As BitmapTileTransformDefinition
        Dim Bmp As New Bitmap(Imagebx.Image)
        Dim Size As New System.Drawing.Size(0, 0)

        'Disable controls
        ControlsSetEnabled(New Control() {Me.actionProgress}, False)

        'Maximum for the progress bar is the number of times we loop in total
        'We increment 1 for each loop
        Me.actionProgress.Maximum = ColorKey.Items.Count * 2 * Bmp.Width * Bmp.Height

        'Make a list of ignored colors
        For Each I As ListViewItem In ColorKey.Items
            If I.SubItems.Item(0).Text = "Ignore" Then
                IgnoreColors.Add(Color.FromArgb(CInt(I.SubItems.Item(1).Text)))
            End If

            'Update our progressbar
            Me.actionProgress.Value += 1
            Me.actionProgress.Invalidate()
        Next

        For Each I As ListViewItem In ColorKey.Items
            If I.SubItems.Item(0).Text <> "Ignore" Then

                TempD = New BitmapTileTransformDefinition(CShort(I.SubItems.Item(0).Text), Color.FromArgb(CInt(I.SubItems.Item(1).Text)), Color.FromArgb(CInt(I.SubItems.Item(2).Text)))

                For x = 0 To Bmp.Width - 1
                    For y = 0 To Bmp.Height - 1
                        If Not IgnoreColors.Contains(Bmp.GetPixel(x, y)) AndAlso ColorBetween(Bmp.GetPixel(x, y), TempD) Then
                            Dim TempTile As New Tile()
                            'The Absolute X and Y positions
                            Dim AbsX As Integer = 22 + x + XOff.Value
                            Dim AbsY As Integer = 20 + y + YOff.Value

                            'Set the bounds of our map
                            Size.Width = Math.Max(Size.Width, AbsX)
                            Size.Height = Math.Max(Size.Height, AbsY)

                            'The tiles area. More info is in the OtbmWriter class
                            Dim TempArea As New TileArea(CType(AbsX And &HFF00, UInt16), _
                                                        CType(AbsY And &HFF00, UInt16), _
                                                        7)
                            'The tiles location. More info in the OtbmWriter class
                            TempTile.Location = New OffsetLocation(CByte(AbsX And &HFF), _
                                                                CByte(AbsY And &HFF))

                            'Set our tile ID
                            TempTile.Id = TempD.ID

                            'Assign this tile to a corresponding area in the dictionary
                            'We can have multiple tiles per area. More info is in the OtbmWriter class
                            If TileDict.Keys.Contains(TempArea) Then
                                'Area already present, add the tile
                                TileDict(TempArea).Add(TempTile)
                            Else
                                'Area not present, add it and then add the tile too it
                                TileDict.Add(TempArea, New List(Of Tile))
                                TileDict(TempArea).Add(TempTile)
                            End If
                        End If

                        'Update our progressbar
                        Me.actionProgress.Value += 1
                        Me.actionProgress.Invalidate()
                    Next
                    'Keep our messageloop pumping
                    Application.DoEvents()
                Next

            End If
        Next

        If Not OtbmWriter.WriteMap(mapName, Path, TileDict, New System.Version(&H3, &H10), Size) Then
            MsgBox("Could not open the filestream! Export Failed!", MsgBoxStyle.Critical)
        End If

        'Reset our progressbar
        Me.actionProgress.Maximum = 100
        Me.actionProgress.Value = 0

        'Enable controls
        ControlsSetEnabled(New Control() {Me.actionProgress}, True)
    End Sub
#End Region
End Class
