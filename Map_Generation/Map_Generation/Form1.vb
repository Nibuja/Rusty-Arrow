Public Class frmGeneration
    'MAP GENERATION FORM
    'Test Project for Map Generation (Rusty Arrow)
    'AUTHOR: Anton Winkler
    'DATE: 04.09.2016 13:51 MEZ

    Dim Room_Nr, room_size As Integer

    'Creates a new Location in given direction of the given point
    Function New_Location(ByVal direction As Integer, ByVal old_loc As Point) As Point
        New_Location = old_loc
        Select Case direction
            Case 0
                New_Location.X = old_loc.X - 21
            Case 1
                New_Location.Y = old_loc.Y + 21
            Case 2
                New_Location.X = old_loc.X + 21
            Case 3
                New_Location.Y = old_loc.Y - 21
        End Select
    End Function

    'Tests if there is already another room in given direction of the given point
    Function Search_Rooms(ByVal direction As Integer, ByVal old_loc As Point) As Boolean
        Dim test As Boolean = False
        Dim Test_box As PictureBox = New PictureBox
        Test_box.Size = New Size(2, 2)
        Test_box.Location = New_Location(direction, old_loc)
        Me.Controls.Add(Test_box)
        Dim Next_room As PictureBox
        Dim next_name As String
        Dim Index As Integer = 0
        Do
            Dim new_name As String = "room_" + CStr(Index)
            Dim Test_Room As PictureBox = CType(Me.Controls(new_name), PictureBox)
            If Test_box.Bounds.IntersectsWith(Test_Room.Bounds) Then
                test = True
            End If
            next_name = "room_" + CStr(Index + 1)
            Next_room = CType(Me.Controls(next_name), PictureBox)
            Index += 1
        Loop Until (Next_room Is Nothing)
        Me.Controls.Remove(Test_box)
        Return test
    End Function

    'Tests if the start room is a neightbour room
    Function Search_Start_Room(ByVal new_room As PictureBox, ByVal start_room As PictureBox) As Boolean
        Dim test As Boolean = False
        For Index As Integer = 0 To 3
            Dim Test_box As PictureBox = New PictureBox
            Test_box.Size = New Size(2, 2)
            Test_box.Location = New_Location(Index, new_room.Location)
            Me.Controls.Add(Test_box)
            If Test_box.Bounds.IntersectsWith(start_room.Bounds) Then
                test = True
            End If
            Me.Controls.Remove(Test_box)
        Next
        Return test
    End Function

    'Test for same special rooms
    Function Same_Room(ByVal test_room As PictureBox, ByVal rooms() As Integer) As Boolean
        Dim test As Boolean = False
        For Each number In rooms
            Dim new_name As String = "room_" + CStr(number)
            Dim new_room As PictureBox = CType(Me.Controls(new_name), PictureBox)
            If new_room.Bounds.IntersectsWith(test_room.Bounds) Then
                test = True
            End If
        Next
        Return test
    End Function

    'Main Sub for generating the map, room by room; repeats itself with decreasing chance of new connections
    Sub Create_Map(ByVal chance As Integer, ByVal last_room As PictureBox, ByVal direction As Integer)
        Dim new_chance As Integer
        Dim directions As Integer() = {0, 0, 0, 0}
        Dim new_room As PictureBox = New PictureBox
        new_room.Size = New Size(20, 20)
        new_room.Location = New_Location(direction, last_room.Location)
        new_room.BackColor = Color.DarkRed
        new_room.Name = "room_" + CStr(Room_Nr)
        Me.Controls.Add(new_room)
        Room_Nr += 1
        For Index_1 As Integer = 0 To 3
            Randomize()
            new_chance = CInt(Int((100 * Rnd()) + (50 - chance)))
            chance += room_size
            If new_chance > 50 Then
                Dim tester As Boolean = False
                Do
                    Randomize()
                    Dim direction_chance As Integer = CInt(Int((4 * Rnd()) + 1))
                    If Not (directions(direction_chance - 1) = 1) Then
                        directions(direction_chance - 1) = 1
                        tester = True
                        If Search_Rooms(direction_chance - 1, new_room.Location) = False Then
                            Create_Map(chance, new_room, direction_chance - 1)
                        End If
                    End If
                Loop Until tester = True
            End If
        Next
    End Sub

    'Deletes all old rooms
    Sub Delete_all()
        Dim next_name As String
        Dim next_room As PictureBox
        Dim Index As Integer
        Do
            Dim new_name As String = "room_" + CStr(Index)
            Dim Test_Room As PictureBox = CType(Me.Controls(new_name), PictureBox)
            Me.Controls.Remove(Test_Room)
            next_name = "room_" + CStr(Index + 1)
            next_room = CType(Me.Controls(next_name), PictureBox)
            Index += 1
        Loop Until (next_room Is Nothing)
    End Sub

    'Generates a random Color
    Function Random_Color() As Color
        Dim MyAlpha As Integer
        Dim MyRed As Integer
        Dim MyGreen As Integer
        Dim MyBlue As Integer
        MyAlpha = 254
        Randomize()
        MyRed = CInt(Int((254 * Rnd()) + 0))
        Randomize()
        MyGreen = CInt(Int((254 * Rnd()) + 0))
        Randomize()
        MyBlue = CInt(Int((254 * Rnd()) + 0))

        Random_Color = Color.FromArgb(MyAlpha, MyRed, MyGreen, MyBlue)
    End Function

    Private Sub btnGenerator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerator.Click
        'Check, if there is a wrong input
        If TextBox1.Text = Nothing Or TextBox1.Text = "0" Then
            TextBox1.Text = "5"
        End If
        'Reset to standard
        room_size = CInt(TextBox1.Text)
        Room_Nr = 0
        Delete_all()
        'Start the generation from every side
        Create_Map(0, room_0, 0)
        Create_Map(0, room_0, 1)
        Create_Map(0, room_0, 2)
        Create_Map(0, room_0, 3)
        'Make the start room visible (by creating a new one on same place)
        room_0.BringToFront()
        Dim start_room As PictureBox = New PictureBox
        start_room.Location = room_0.Location
        start_room.BackColor = Color.PaleVioletRed
        start_room.Size = New Size(20, 20)
        start_room.Name = "start_room"
        Me.Controls.Add(start_room)
        start_room.BringToFront()
        btnGenerator.Text = CStr(Room_Nr)
        'After generation create random special rooms
        Dim special_rooms As Integer() = {0, 0, 0, 0, 0}
        Dim test As Boolean = True
        Dim random, Index As Integer
        Dim special_room As PictureBox
        Dim special_name As String
        Index = 0
        Do
            Randomize()
            'Create a random number and search the corresponding room
            random = CInt(Int((Room_Nr - 1) * Rnd()) + 1)
            special_name = "room_" + CStr(random)
            special_room = CType(Me.Controls(special_name), PictureBox)
            'Check if the room is already special or next to the start room
            If Search_Start_Room(special_room, start_room) = False And Not (special_room.Bounds.IntersectsWith(start_room.Bounds)) Then
                If Same_Room(special_room, special_rooms) = False Then
                    special_rooms(Index) = random
                    special_room.BackColor = Color.DarkSalmon
                    special_room.BringToFront()
                    Index += 1
                End If
            End If
        Loop Until Index = 5
        'Just a test for the save of the special rooms
        Label1.Text = CStr(special_rooms(0)) + "," + CStr(special_rooms(1)) + "," + CStr(special_rooms(2)) + "," + CStr(special_rooms(3)) + "," + CStr(special_rooms(4))

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        'btnGenerator.BackColor = Random_Color()


    End Sub
End Class
