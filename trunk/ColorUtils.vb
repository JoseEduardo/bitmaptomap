Public Module ColorUtils
    Public Function ColorizeImage(ByVal Bmp As Bitmap, ByVal p As ProgressBar) As Bitmap
        'A list of 30 different which we will use to colorize the image
        Static UseColors() As Color = { _
                           Color.Black, Color.Red, Color.Maroon, Color.Salmon, Color.Firebrick, _
                           Color.Green, Color.Lime, Color.DarkGreen, Color.LightGreen, _
                           Color.Blue, Color.DarkBlue, Color.SkyBlue, Color.LightBlue, _
                           Color.Yellow, Color.Khaki, Color.Goldenrod, Color.DarkKhaki, _
                           Color.Orange, Color.DarkOrange, Color.OrangeRed, _
                           Color.Purple, Color.MediumPurple, Color.Magenta, _
                           Color.Chocolate, Color.Brown, Color.Sienna, _
                           Color.White, Color.Gray, Color.DimGray, Color.Black, Color.Silver, _
                           Color.Aqua, Color.HotPink, Color.Pink, Color.Beige, Color.WhiteSmoke, Color.Wheat, Color.Coral, Color.Cornsilk, Color.Pink, Color.LightYellow}

        'Static UseColors() As Color = {Color.Pink, Color.Red, Color.Maroon, _
        '                               Color.Salmon, Color.Orange, Color.DarkOrange, _
        '                               Color.LightYellow, Color.Yellow, Color.DarkGoldenrod, _
        '                               Color.LightGreen, Color.Green, Color.DarkGreen, _
        '                               Color.LightBlue, Color.Blue, Color.DarkBlue, _
        '                               Color.Indigo, _
        '                               Color.Violet, Color.DarkViolet}

        'This is a dictionary we will use so we dont go through the
        'mess of trying to calculate what to change a certain color 
        'too more than once
        Static RememberDictionary As New Dictionary(Of Color, Color)

        p.Maximum = Bmp.Width * Bmp.Height
        For x = 0 To Bmp.Width - 1
            For y = 0 To Bmp.Height - 1
                Dim TempColor As Color = Bmp.GetPixel(x, y)
                If UseColors.Contains(TempColor) Then
                    'This color is present in our list of colors to replace with
                    'Do nothing with it
                ElseIf RememberDictionary.ContainsKey(TempColor) Then
                    'This color has already been calculated, so we'll
                    'set it to the image
                    Bmp.SetPixel(x, y, RememberDictionary(TempColor))
                Else
                    'Calculate the color to replace this one with
                    Dim LowestDif As Integer = 256 * 3 'Make this the biggest difference possible, since we just narrow it
                    Dim ClosestColor As Color
                    For Each C As Color In UseColors
                        Dim TempDif As Integer = ColorDifference(TempColor, C)
                        If TempDif < LowestDif Then
                            LowestDif = TempDif
                            ClosestColor = C
                        End If
                    Next

                    'Set the new found color to the image, and save it to the dictionary
                    Bmp.SetPixel(x, y, ClosestColor)
                    RememberDictionary.Add(TempColor, ClosestColor)
                End If

                'Update the progressbar
                p.Value += 1
                p.Invalidate()
            Next
            'Do this to keep our message loop alive
            Application.DoEvents()
        Next

        'Reset the progressbar
        p.Maximum = 100
        p.Value = 0
        Return Bmp
    End Function

    Public Function ColorBetween(ByVal check As Color, ByVal td As BitmapTileTransformDefinition) As Boolean
        'We will overlay Color1 on Color2 for every visible
        'Alpha value possible (1-255), get those colors
        'And see if any match our check color
        For alpha As Double = 1 To 255
            Dim ResultRGB As Integer = td.Color1.ToArgb + (1 - alpha) * td.Color2.ToArgb
            Dim ResultColor As Color = Color.FromArgb(ResultRGB)
            If check = ResultColor Then Return True
        Next

        Return (check = td.Color1 OrElse check = td.Color2)
    End Function


    Public Function ColorDifference(ByVal Color1 As Color, ByVal Color2 As Color) As Integer
        Return Math.Abs(CInt(Color1.R) - CInt(Color2.R)) + Math.Abs(CInt(Color1.G) - CInt(Color2.G)) + Math.Abs(CInt(Color1.B) - CInt(Color2.B))
    End Function

    'This is a algorythm made by me to help normalize the colors on the image
    'Not complete, unused.
    Public Function ImageFilter(ByVal bmp As Bitmap) As Bitmap

        Dim TempR, TempG, TempB, DivCount, Weight As Double
        Dim TempPixel1, TempPixel2 As Color
        Dim TempImage As New Bitmap(bmp.Width, bmp.Height)
        Dim R As Double = 1
        'For i = 1 To 10

        For X As Integer = 0 To bmp.Width - 1
            For Y As Integer = 0 To bmp.Height - 1
                TempPixel1 = bmp.GetPixel(X, Y)
                TempR = Math.Pow(TempPixel1.R, 2) * 6
                TempG = Math.Pow(TempPixel1.G, 2) * 6
                TempB = Math.Pow(TempPixel1.B, 2) * 6
                DivCount = 6


                For Xt As Integer = Math.Max(0, X - R) To Math.Min(bmp.Width - 1, X + R)

                    For Yt As Integer = Math.Max(0, Y - R) To Math.Min(bmp.Height - 1, Y + R)
                        Weight = Math.Sqrt(Math.Pow(Math.Abs(Yt - Y), 2) + Math.Pow(Math.Abs(Xt - X), 2))
                        Weight = R + (R / 2) - Weight
                        TempPixel2 = bmp.GetPixel(Xt, Yt)
                        TempR += Math.Pow(TempPixel2.R, 2) * Weight
                        TempG += Math.Pow(TempPixel2.G, 2) * Weight
                        TempB += Math.Pow(TempPixel2.B, 2) * Weight
                        DivCount += Weight
                    Next

                Next

                bmp.SetPixel(X, Y, Color.FromArgb(Math.Min(Math.Sqrt(TempR / DivCount), 255), Math.Min(Math.Sqrt(TempG / DivCount), 255), Math.Min(Math.Sqrt(TempB / DivCount), 255)))
            Next
        Next
        'Next

        Return bmp
    End Function
End Module
