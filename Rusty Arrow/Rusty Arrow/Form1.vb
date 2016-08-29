Public Class frmRusty
    Dim strName, strProj_1, strProj_2, strProj_3 As String
    Dim animation_val, arrow_count, size_value, map_data(), player_data() As Integer
    Dim doors As Boolean

    Function random_string() As String
        Dim strUnique, strTemp, characters As String
        Dim intRandom As Integer
        characters = "abcdefghijklmnopjrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
        strUnique = ""

        For intIndex As Integer = 0 To 5
            Randomize()
            intRandom = CInt(Int((51 * Rnd()) + 1))
            strTemp = Microsoft.VisualBasic.Left(characters, intRandom)
            strTemp = Microsoft.VisualBasic.Right(strTemp, 1)
            strUnique += strTemp
        Next
        Return strUnique
    End Function

    Function AreSameImage(ByVal I1 As Image, ByVal I2 As Image) As Boolean
        Dim BM1 As Bitmap = I1
        Dim BM2 As Bitmap = I2
        For X = 0 To BM1.Width - 1
            For y = 0 To BM2.Height - 1
                If BM1.GetPixel(X, y) <> BM2.GetPixel(X, y) Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    Function TestIntersection(ByVal name As String, ByVal count As Integer, ByVal player As PictureBox) As Boolean
        TestIntersection = False
        For Index As Integer = 0 To count
            Dim new_name As String = name + CStr(Index)
            Dim obstacle As PictureBox = CType(Me.Controls(new_name), PictureBox)
            If player.Bounds.IntersectsWith(obstacle.Bounds) Then
                Return True
            End If
        Next
    End Function

    'Create a new Timer for each projectile to seperate different types
    Sub Fly_Mechanism(ByVal direction As Integer, ByVal count As Integer, ByVal speed As Integer, ByVal origin As Point, ByVal image As Image)
        'Create a universal projectile
        strName = random_string()
        Dim projectile_size As Size = image.Size
        Dim test_projectile As PictureBox
        test_projectile = New PictureBox
        test_projectile.Location = origin
        test_projectile.Image = image
        test_projectile.Size = projectile_size
        test_projectile.BackColor = Color.Transparent
        test_projectile.SizeMode = PictureBoxSizeMode.CenterImage
        test_projectile.Name = strName
        Me.Controls.Add(test_projectile)
        test_projectile.BringToFront()

        'Create a new timer to move the projectile
        If count = 1 Then
            Dim tmrTemp_1 As Timer
            tmrTemp_1 = New Timer
            tmrTemp_1.Interval = 10
            tmrTemp_1.Enabled = True
            AddHandler tmrTemp_1.Tick, AddressOf Me.tmrTemp_1_tick
            strProj_1 = strName
        ElseIf count = 2 Then
            Dim tmrTemp_2 As Timer
            tmrTemp_2 = New Timer
            tmrTemp_2.Interval = 10
            tmrTemp_2.Enabled = True
            AddHandler tmrTemp_2.Tick, AddressOf Me.tmrTemp_2_tick
            strProj_2 = strName
        ElseIf count = 3 Then
            Dim tmrTemp_3 As Timer
            tmrTemp_3 = New Timer
            tmrTemp_3.Interval = 10
            tmrTemp_3.Enabled = True
            AddHandler tmrTemp_3.Tick, AddressOf Me.tmrTemp_3_tick
            strProj_3 = strName
        End If
    End Sub

    Friend WithEvents tmrTemp_1 As System.Windows.Forms.Timer
    Private Sub tmrTemp_1_tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTemp_1.Tick
        Dim projectile As PictureBox = CType(Me.Controls(strProj_1), PictureBox)
        Dim Loc As Point
        Loc = New Point(projectile.Location.X + 2, projectile.Location.Y)
        projectile.Location = Loc
    End Sub

    Friend WithEvents tmrTemp_2 As System.Windows.Forms.Timer
    Private Sub tmrTemp_2_tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTemp_2.Tick
        Dim projectile As PictureBox = CType(Me.Controls(strProj_2), PictureBox)
        Dim Loc As Point
        Loc = New Point(projectile.Location.X + 2, projectile.Location.Y)
        projectile.Location = Loc
    End Sub

    Friend WithEvents tmrTemp_3 As System.Windows.Forms.Timer
    Private Sub tmrTemp_3_tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTemp_3.Tick
        Dim projectile As PictureBox = CType(Me.Controls(strProj_3), PictureBox)
        Dim Loc As Point
        Loc = New Point(projectile.Location.X + 2, projectile.Location.Y)
        projectile.Location = Loc
    End Sub

    Sub MapChange(ByVal something As String)
        'Coming Soon
        'All Map Change and creation is done here
        MsgBox(something)
        size_value += 1
        tmrMapChange.Enabled = True
        If map_data(0) > 0 Then



    End Sub

    Sub MapCreation()
        If map_data(0) > 0 Then





        End If



    End Sub

    Private Sub frmRusty_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        '/Move the Player with WASD
        Dim Loc As Point
        Dim imgAni As Image = My.Resources.knight_shoot_animation
        If e.KeyCode = Keys.A Or e.KeyCode = Keys.D Or e.KeyCode = Keys.S Or e.KeyCode = Keys.W Then
            If Not (animation_val = 2) Then
                animation_val = 1
            End If
        End If

        If Not (tmrShootDelay.Enabled = True) Then

            If e.KeyCode = Keys.A Then
                Loc = New Point(Player.Location.X - 3, Player.Location.Y)
                Player.Location = Loc
            ElseIf e.KeyCode = Keys.D Then
                Loc = New Point(Player.Location.X + 3, Player.Location.Y)
                Player.Location = Loc
            ElseIf e.KeyCode = Keys.S Then
                Loc = New Point(Player.Location.X, Player.Location.Y + 3)
                Player.Location = Loc
            ElseIf e.KeyCode = Keys.W Then
                Loc = New Point(Player.Location.X, Player.Location.Y - 3)
                Player.Location = Loc
            End If
            If e.KeyCode = Keys.Space Then
                animation_val = 2
                tmrGeneral.Enabled = False
                tmrGeneral.Enabled = True
                tmrGeneral.Interval = 1
                tmrShootDelay.Enabled = True
            End If

            If TestIntersection("wall_", 11, Player) = True Then
                Player.Location = New Point(200, 200)
            End If

            If Player.Bounds.IntersectsWith(gate_0.Bounds) And doors = True And tmrOpenGate.Enabled = False Then
                gate_0.Image = My.Resources.stone_wall_wooden_gate_open
                tmrOpenGate.Enabled = True
            End If

            Player.BringToFront()

        End If

    End Sub

    Private Sub frmRusty_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If (e.KeyCode = Keys.A Or e.KeyCode = Keys.D Or e.KeyCode = Keys.S Or e.KeyCode = Keys.W) And Not (tmrGeneral.Interval = 1450) Then
            tmrGeneral.Interval = 1
            animation_val = 0
            tmrGeneral.Enabled = False
            tmrGeneral.Enabled = True
        ElseIf e.KeyCode = Keys.Space Then
            tmrGeneral.Interval = 1450
            animation_val = 0
            tmrGeneral.Enabled = False
            tmrGeneral.Enabled = True
        End If
    End Sub


    Private Sub tmrGeneral_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGeneral.Tick

        If animation_val = 0 Then
            Player.Image = My.Resources.knight_basic_2
            tmrGeneral.Interval = 1
        ElseIf animation_val = 1 Then
            Player.Image = My.Resources.knight_walk_animation
            tmrGeneral.Interval = 1000
        ElseIf animation_val = 2 Then
            Player.Image = My.Resources.knight_shoot_animation
            tmrGeneral.Interval = 1450
        End If

    End Sub

    Private Sub Player_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Player.Click
        'MsgBox(random_string())
        doors = True
        gate_0.Image = My.Resources.stone_wall_wooden_gate_top

        'Test-Start for Map Change
        Dim count, location_value, rest As Integer
        count = 0
        location_value = 70
        For Index As Integer = 0 To 10
            Dim stripe As PictureBox = New PictureBox
            Dim box_location As Point
            rest = Index Mod 2
            If rest = 1 Then
                box_location = New Point(location_value * Index, 580)
            Else
                box_location = New Point(location_value * Index, 0)
            End If
            Dim name As String = "black_box_" + CStr(Index)
            stripe.Location = box_location
            stripe.BackColor = Color.Black
            stripe.Size = New Size(location_value, 0)
            stripe.Name = name
            Me.Controls.Add(stripe)
            stripe.BringToFront()
        Next
        tmrMapChange.Enabled = True
        size_value = 0
    End Sub


    Private Sub tmrShootDelay_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrShootDelay.Tick
        If arrow_count = 4 Then
            arrow_count = 1
        End If
        Fly_Mechanism(2, arrow_count, 2, (New Point(Player.Location.X + 15, Player.Location.Y + 19)), (My.Resources.arrow_basic_fly_animation))
        tmrShootDelay.Enabled = False
        arrow_count += 1
    End Sub

    Private Sub frmRusty_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        arrow_count = 1
        doors = True
        ReDim player_data(5)
        'Alive(f=0/t=1); Direction(t=0,r=1,b=2,l=3); Level(0-30); Health(0-100%), Mana(0-100%); StatusEffects(0-6)
        player_data(0) = 1
        player_data(1) = 0
        player_data(2) = 1
        player_data(3) = 100
        player_data(4) = 100
        player_data(5) = 0


        ReDim map_data(9)
        'Floor(0-X); MapType(0-X); MapStyle(0-X); Visited(f=0/t=1); Doors(0-4); Entrence(0-4); Objects(0-X); Enemies(f=0/t=1); EnemyCount(0-X); EnemyType(0-X)
        'MapType(0 = Empty; 1 = Quest; 2 = Treasure; 3 = Fighting; 4 = Arena; 5 = Boss; 6 = Other)
        map_data(0) = 1
        map_data(1) = 0
        map_data(2) = 1
        map_data(3) = 0
        map_data(4) = 4
        map_data(5) = 1
        map_data(6) = 0
        map_data(7) = 0
        map_data(8) = 0
        map_data(9) = 0


    End Sub

    Private Sub tmrOpenGate_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrOpenGate.Tick
        tmrOpenGate.Enabled = False
        gate_0.Image = My.Resources.stone_wall_wooden_gate_top_6
        doors = False
    End Sub

    Private Sub tmrMapChange_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMapChange.Tick
        Dim rest As Integer
        If size_value <= 580 Then
            For Index As Integer = 0 To 10
                Dim name As String = "black_box_" + CStr(Index)
                Dim black_box As PictureBox = CType(Me.Controls(name), PictureBox)
                Dim size As Size = New Size(black_box.Size.Width, size_value)
                Dim location As Point = New Point(black_box.Location.X, black_box.Location.Y - 7)
                rest = Index Mod 2
                If rest = 1 Then
                    black_box.Location = location
                End If
                black_box.Size = size
            Next
            size_value += 7
        ElseIf size_value = 581 Then
            tmrMapChange.Enabled = False
            MapChange("something is done here!")
        ElseIf size_value > 581 And size_value <= 1160 Then
            For Index As Integer = 0 To 10
                Dim name As String = "black_box_" + CStr(Index)
                Dim black_box As PictureBox = CType(Me.Controls(name), PictureBox)
                Dim size As Size = New Size(black_box.Size.Width, 1160 - size_value)
                Dim location_1 As Point = New Point(black_box.Location.X, 0)
                Dim location_2 As Point = New Point(black_box.Location.X, black_box.Location.Y + 7)
                rest = Index Mod 2
                If rest = 1 Then
                    black_box.Location = location_1
                Else
                    black_box.Location = location_2
                End If
                black_box.Size = size
            Next
            size_value += 7
        Else
            tmrMapChange.Enabled = False
            size_value = 0
            For Index As Integer = 0 To 10
                Dim name As String = "black_box_" + CStr(Index)
                Dim black_box As PictureBox = CType(Me.Controls(name), PictureBox)
                Me.Controls.Remove(black_box)
            Next
        End If
    End Sub
End Class
