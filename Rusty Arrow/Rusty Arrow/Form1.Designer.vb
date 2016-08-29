<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRusty
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRusty))
        Me.wall_8 = New System.Windows.Forms.PictureBox()
        Me.wall_5 = New System.Windows.Forms.PictureBox()
        Me.wall_7 = New System.Windows.Forms.PictureBox()
        Me.wall_3 = New System.Windows.Forms.PictureBox()
        Me.wall_2 = New System.Windows.Forms.PictureBox()
        Me.wall_0 = New System.Windows.Forms.PictureBox()
        Me.wall_11 = New System.Windows.Forms.PictureBox()
        Me.wall_10 = New System.Windows.Forms.PictureBox()
        Me.Player = New System.Windows.Forms.PictureBox()
        Me.tmrGeneral = New System.Windows.Forms.Timer(Me.components)
        Me.tmrShootDelay = New System.Windows.Forms.Timer(Me.components)
        Me.wall_9 = New System.Windows.Forms.PictureBox()
        Me.wall_4 = New System.Windows.Forms.PictureBox()
        Me.wall_1 = New System.Windows.Forms.PictureBox()
        Me.wall_6 = New System.Windows.Forms.PictureBox()
        Me.gate_0 = New System.Windows.Forms.PictureBox()
        Me.tmrOpenGate = New System.Windows.Forms.Timer(Me.components)
        Me.tmrMapChange = New System.Windows.Forms.Timer(Me.components)
        Me.gate_2 = New System.Windows.Forms.PictureBox()
        Me.gate_3 = New System.Windows.Forms.PictureBox()
        Me.gate_1 = New System.Windows.Forms.PictureBox()
        Me.wall_12 = New System.Windows.Forms.PictureBox()
        CType(Me.wall_8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall_11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall_10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall_9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gate_0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gate_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gate_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gate_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wall_12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'wall_8
        '
        Me.wall_8.Image = Global.Rusty_Arrow.My.Resources.Resources.stone_wall_green_left_bottom_corner
        resources.ApplyResources(Me.wall_8, "wall_8")
        Me.wall_8.Name = "wall_8"
        Me.wall_8.TabStop = False
        '
        'wall_5
        '
        Me.wall_5.Image = Global.Rusty_Arrow.My.Resources.Resources.stone_wall_green_right_bottom_corner
        resources.ApplyResources(Me.wall_5, "wall_5")
        Me.wall_5.Name = "wall_5"
        Me.wall_5.TabStop = False
        '
        'wall_7
        '
        Me.wall_7.BackgroundImage = Global.Rusty_Arrow.My.Resources.Resources.stone_wall_green_bottom
        resources.ApplyResources(Me.wall_7, "wall_7")
        Me.wall_7.Name = "wall_7"
        Me.wall_7.TabStop = False
        '
        'wall_3
        '
        Me.wall_3.BackgroundImage = Global.Rusty_Arrow.My.Resources.Resources.stone_wall_green_right
        resources.ApplyResources(Me.wall_3, "wall_3")
        Me.wall_3.Name = "wall_3"
        Me.wall_3.TabStop = False
        '
        'wall_2
        '
        Me.wall_2.Image = Global.Rusty_Arrow.My.Resources.Resources.stone_wall_green_right_top_corner
        resources.ApplyResources(Me.wall_2, "wall_2")
        Me.wall_2.Name = "wall_2"
        Me.wall_2.TabStop = False
        '
        'wall_0
        '
        Me.wall_0.BackgroundImage = Global.Rusty_Arrow.My.Resources.Resources.stone_wall_green
        resources.ApplyResources(Me.wall_0, "wall_0")
        Me.wall_0.Name = "wall_0"
        Me.wall_0.TabStop = False
        '
        'wall_11
        '
        Me.wall_11.BackColor = System.Drawing.Color.Transparent
        Me.wall_11.BackgroundImage = Global.Rusty_Arrow.My.Resources.Resources.stone_wall_green_left_top_corner
        resources.ApplyResources(Me.wall_11, "wall_11")
        Me.wall_11.Name = "wall_11"
        Me.wall_11.TabStop = False
        '
        'wall_10
        '
        Me.wall_10.BackgroundImage = Global.Rusty_Arrow.My.Resources.Resources.stone_wall_green_left
        resources.ApplyResources(Me.wall_10, "wall_10")
        Me.wall_10.Name = "wall_10"
        Me.wall_10.TabStop = False
        '
        'Player
        '
        Me.Player.BackColor = System.Drawing.Color.Transparent
        Me.Player.Image = Global.Rusty_Arrow.My.Resources.Resources.knight_shoot_animation
        resources.ApplyResources(Me.Player, "Player")
        Me.Player.Name = "Player"
        Me.Player.TabStop = False
        '
        'tmrGeneral
        '
        Me.tmrGeneral.Enabled = True
        Me.tmrGeneral.Interval = 1
        '
        'tmrShootDelay
        '
        Me.tmrShootDelay.Interval = 1100
        '
        'wall_9
        '
        Me.wall_9.BackgroundImage = Global.Rusty_Arrow.My.Resources.Resources.stone_wall_green_left
        resources.ApplyResources(Me.wall_9, "wall_9")
        Me.wall_9.Name = "wall_9"
        Me.wall_9.TabStop = False
        '
        'wall_4
        '
        Me.wall_4.BackgroundImage = Global.Rusty_Arrow.My.Resources.Resources.stone_wall_green_right
        resources.ApplyResources(Me.wall_4, "wall_4")
        Me.wall_4.Name = "wall_4"
        Me.wall_4.TabStop = False
        '
        'wall_1
        '
        Me.wall_1.BackgroundImage = Global.Rusty_Arrow.My.Resources.Resources.stone_wall_green
        resources.ApplyResources(Me.wall_1, "wall_1")
        Me.wall_1.Name = "wall_1"
        Me.wall_1.TabStop = False
        '
        'wall_6
        '
        Me.wall_6.BackgroundImage = Global.Rusty_Arrow.My.Resources.Resources.stone_wall_green_bottom
        resources.ApplyResources(Me.wall_6, "wall_6")
        Me.wall_6.Name = "wall_6"
        Me.wall_6.TabStop = False
        '
        'gate_0
        '
        Me.gate_0.Image = Global.Rusty_Arrow.My.Resources.Resources.stone_wall_wooden_gate_top
        resources.ApplyResources(Me.gate_0, "gate_0")
        Me.gate_0.Name = "gate_0"
        Me.gate_0.TabStop = False
        '
        'tmrOpenGate
        '
        Me.tmrOpenGate.Interval = 2300
        '
        'tmrMapChange
        '
        Me.tmrMapChange.Interval = 5
        '
        'gate_2
        '
        Me.gate_2.Image = Global.Rusty_Arrow.My.Resources.Resources.stone_wall_wooden_gate_bot
        resources.ApplyResources(Me.gate_2, "gate_2")
        Me.gate_2.Name = "gate_2"
        Me.gate_2.TabStop = False
        '
        'gate_3
        '
        Me.gate_3.Image = Global.Rusty_Arrow.My.Resources.Resources.stone_wall_wooden_gate_left
        resources.ApplyResources(Me.gate_3, "gate_3")
        Me.gate_3.Name = "gate_3"
        Me.gate_3.TabStop = False
        '
        'gate_1
        '
        Me.gate_1.Image = Global.Rusty_Arrow.My.Resources.Resources.stone_wall_wooden_gate_right
        resources.ApplyResources(Me.gate_1, "gate_1")
        Me.gate_1.Name = "gate_1"
        Me.gate_1.TabStop = False
        '
        'wall_12
        '
        Me.wall_12.BackgroundImage = Global.Rusty_Arrow.My.Resources.Resources.Stripes_1
        resources.ApplyResources(Me.wall_12, "wall_12")
        Me.wall_12.Name = "wall_12"
        Me.wall_12.TabStop = False
        '
        'frmRusty
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Rusty_Arrow.My.Resources.Resources.stone_floor_green
        Me.Controls.Add(Me.wall_12)
        Me.Controls.Add(Me.gate_1)
        Me.Controls.Add(Me.gate_3)
        Me.Controls.Add(Me.gate_2)
        Me.Controls.Add(Me.gate_0)
        Me.Controls.Add(Me.wall_6)
        Me.Controls.Add(Me.wall_1)
        Me.Controls.Add(Me.wall_4)
        Me.Controls.Add(Me.wall_9)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.wall_8)
        Me.Controls.Add(Me.wall_5)
        Me.Controls.Add(Me.wall_7)
        Me.Controls.Add(Me.wall_3)
        Me.Controls.Add(Me.wall_2)
        Me.Controls.Add(Me.wall_0)
        Me.Controls.Add(Me.wall_11)
        Me.Controls.Add(Me.wall_10)
        Me.Name = "frmRusty"
        CType(Me.wall_8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall_11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall_10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall_9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gate_0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gate_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gate_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gate_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wall_12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents wall_10 As System.Windows.Forms.PictureBox
    Friend WithEvents wall_11 As System.Windows.Forms.PictureBox
    Friend WithEvents wall_0 As System.Windows.Forms.PictureBox
    Friend WithEvents wall_2 As System.Windows.Forms.PictureBox
    Friend WithEvents wall_3 As System.Windows.Forms.PictureBox
    Friend WithEvents wall_7 As System.Windows.Forms.PictureBox
    Friend WithEvents wall_5 As System.Windows.Forms.PictureBox
    Friend WithEvents wall_8 As System.Windows.Forms.PictureBox
    Friend WithEvents Player As System.Windows.Forms.PictureBox
    Friend WithEvents tmrGeneral As System.Windows.Forms.Timer
    Friend WithEvents tmrShootDelay As System.Windows.Forms.Timer
    Friend WithEvents wall_9 As System.Windows.Forms.PictureBox
    Friend WithEvents wall_4 As System.Windows.Forms.PictureBox
    Friend WithEvents wall_1 As System.Windows.Forms.PictureBox
    Friend WithEvents wall_6 As System.Windows.Forms.PictureBox
    Friend WithEvents gate_0 As System.Windows.Forms.PictureBox
    Friend WithEvents tmrOpenGate As System.Windows.Forms.Timer
    Friend WithEvents tmrMapChange As System.Windows.Forms.Timer
    Friend WithEvents gate_2 As System.Windows.Forms.PictureBox
    Friend WithEvents gate_3 As System.Windows.Forms.PictureBox
    Friend WithEvents gate_1 As System.Windows.Forms.PictureBox
    Friend WithEvents wall_12 As System.Windows.Forms.PictureBox

End Class
