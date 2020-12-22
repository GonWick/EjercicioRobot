<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBoxTest1 = New System.Windows.Forms.GroupBox()
        Me.RadioButtonDiaMartes = New System.Windows.Forms.RadioButton()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButtonLuna = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMarte = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBoxTest2 = New System.Windows.Forms.GroupBox()
        Me.LabelRespuesta = New System.Windows.Forms.Label()
        Me.LabelFraseInfo = New System.Windows.Forms.Label()
        Me.TextBoxFrase = New System.Windows.Forms.TextBox()
        Me.ButtonFrase = New System.Windows.Forms.Button()
        Me.RadioButtonPlaton = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDescartes = New System.Windows.Forms.RadioButton()
        Me.GroupBoxTest1.SuspendLayout()
        Me.GroupBoxTest2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxTest1
        '
        Me.GroupBoxTest1.Controls.Add(Me.RadioButtonDiaMartes)
        Me.GroupBoxTest1.Controls.Add(Me.ButtonSalir)
        Me.GroupBoxTest1.Controls.Add(Me.Label1)
        Me.GroupBoxTest1.Controls.Add(Me.RadioButtonLuna)
        Me.GroupBoxTest1.Controls.Add(Me.RadioButtonMarte)
        Me.GroupBoxTest1.Controls.Add(Me.Button1)
        Me.GroupBoxTest1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBoxTest1.Name = "GroupBoxTest1"
        Me.GroupBoxTest1.Size = New System.Drawing.Size(281, 242)
        Me.GroupBoxTest1.TabIndex = 6
        Me.GroupBoxTest1.TabStop = False
        Me.GroupBoxTest1.Text = "Test 1"
        '
        'RadioButtonDiaMartes
        '
        Me.RadioButtonDiaMartes.AutoSize = True
        Me.RadioButtonDiaMartes.Location = New System.Drawing.Point(117, 76)
        Me.RadioButtonDiaMartes.Name = "RadioButtonDiaMartes"
        Me.RadioButtonDiaMartes.Size = New System.Drawing.Size(68, 19)
        Me.RadioButtonDiaMartes.TabIndex = 11
        Me.RadioButtonDiaMartes.TabStop = True
        Me.RadioButtonDiaMartes.Text = "MARTES"
        Me.RadioButtonDiaMartes.UseVisualStyleBackColor = True
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Image = CType(resources.GetObject("ButtonSalir.Image"), System.Drawing.Image)
        Me.ButtonSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSalir.Location = New System.Drawing.Point(98, 172)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSalir.TabIndex = 10
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "¿ A donde llego el Robot Curiosity en 2012 ?"
        '
        'RadioButtonLuna
        '
        Me.RadioButtonLuna.AutoSize = True
        Me.RadioButtonLuna.Location = New System.Drawing.Point(195, 76)
        Me.RadioButtonLuna.Name = "RadioButtonLuna"
        Me.RadioButtonLuna.Size = New System.Drawing.Size(56, 19)
        Me.RadioButtonLuna.TabIndex = 8
        Me.RadioButtonLuna.TabStop = True
        Me.RadioButtonLuna.Text = "LUNA"
        Me.RadioButtonLuna.UseVisualStyleBackColor = True
        '
        'RadioButtonMarte
        '
        Me.RadioButtonMarte.AutoSize = True
        Me.RadioButtonMarte.Location = New System.Drawing.Point(30, 76)
        Me.RadioButtonMarte.Name = "RadioButtonMarte"
        Me.RadioButtonMarte.Size = New System.Drawing.Size(62, 19)
        Me.RadioButtonMarte.TabIndex = 7
        Me.RadioButtonMarte.TabStop = True
        Me.RadioButtonMarte.Text = "MARTE"
        Me.RadioButtonMarte.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(87, 118)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Comprobar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBoxTest2
        '
        Me.GroupBoxTest2.Controls.Add(Me.LabelRespuesta)
        Me.GroupBoxTest2.Controls.Add(Me.LabelFraseInfo)
        Me.GroupBoxTest2.Controls.Add(Me.TextBoxFrase)
        Me.GroupBoxTest2.Controls.Add(Me.ButtonFrase)
        Me.GroupBoxTest2.Controls.Add(Me.RadioButtonPlaton)
        Me.GroupBoxTest2.Controls.Add(Me.RadioButtonDescartes)
        Me.GroupBoxTest2.Location = New System.Drawing.Point(330, 18)
        Me.GroupBoxTest2.Name = "GroupBoxTest2"
        Me.GroupBoxTest2.Size = New System.Drawing.Size(278, 235)
        Me.GroupBoxTest2.TabIndex = 7
        Me.GroupBoxTest2.TabStop = False
        Me.GroupBoxTest2.Text = "Test 2"
        '
        'LabelRespuesta
        '
        Me.LabelRespuesta.AutoSize = True
        Me.LabelRespuesta.Location = New System.Drawing.Point(27, 199)
        Me.LabelRespuesta.Name = "LabelRespuesta"
        Me.LabelRespuesta.Size = New System.Drawing.Size(78, 15)
        Me.LabelRespuesta.TabIndex = 5
        Me.LabelRespuesta.Text = "Frase Famosa"
        '
        'LabelFraseInfo
        '
        Me.LabelFraseInfo.AutoSize = True
        Me.LabelFraseInfo.Location = New System.Drawing.Point(29, 42)
        Me.LabelFraseInfo.Name = "LabelFraseInfo"
        Me.LabelFraseInfo.Size = New System.Drawing.Size(147, 15)
        Me.LabelFraseInfo.TabIndex = 4
        Me.LabelFraseInfo.Text = "Escriba Descartes o Platón:"
        '
        'TextBoxFrase
        '
        Me.TextBoxFrase.Location = New System.Drawing.Point(29, 72)
        Me.TextBoxFrase.Name = "TextBoxFrase"
        Me.TextBoxFrase.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxFrase.TabIndex = 3
        '
        'ButtonFrase
        '
        Me.ButtonFrase.Location = New System.Drawing.Point(29, 151)
        Me.ButtonFrase.Name = "ButtonFrase"
        Me.ButtonFrase.Size = New System.Drawing.Size(75, 23)
        Me.ButtonFrase.TabIndex = 2
        Me.ButtonFrase.Text = "Ver Frase Famosa"
        Me.ButtonFrase.UseVisualStyleBackColor = True
        '
        'RadioButtonPlaton
        '
        Me.RadioButtonPlaton.AutoSize = True
        Me.RadioButtonPlaton.Location = New System.Drawing.Point(29, 101)
        Me.RadioButtonPlaton.Name = "RadioButtonPlaton"
        Me.RadioButtonPlaton.Size = New System.Drawing.Size(59, 19)
        Me.RadioButtonPlaton.TabIndex = 1
        Me.RadioButtonPlaton.TabStop = True
        Me.RadioButtonPlaton.Text = "Platon"
        Me.RadioButtonPlaton.UseVisualStyleBackColor = True
        '
        'RadioButtonDescartes
        '
        Me.RadioButtonDescartes.AutoSize = True
        Me.RadioButtonDescartes.Location = New System.Drawing.Point(29, 126)
        Me.RadioButtonDescartes.Name = "RadioButtonDescartes"
        Me.RadioButtonDescartes.Size = New System.Drawing.Size(75, 19)
        Me.RadioButtonDescartes.TabIndex = 0
        Me.RadioButtonDescartes.TabStop = True
        Me.RadioButtonDescartes.Text = "Descartes"
        Me.RadioButtonDescartes.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 276)
        Me.Controls.Add(Me.GroupBoxTest2)
        Me.Controls.Add(Me.GroupBoxTest1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EJERCICIO ROBOT"
        Me.GroupBoxTest1.ResumeLayout(False)
        Me.GroupBoxTest1.PerformLayout()
        Me.GroupBoxTest2.ResumeLayout(False)
        Me.GroupBoxTest2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBoxTest1 As GroupBox
    Friend WithEvents RadioButtonDiaMartes As RadioButton
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButtonLuna As RadioButton
    Friend WithEvents RadioButtonMarte As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBoxTest2 As GroupBox
    Friend WithEvents LabelFraseInfo As Label
    Friend WithEvents TextBoxFrase As TextBox
    Friend WithEvents ButtonFrase As Button
    Friend WithEvents RadioButtonPlaton As RadioButton
    Friend WithEvents RadioButtonDescartes As RadioButton
    Friend WithEvents LabelFrase As Label
    Friend WithEvents LabelRespuesta As Label
End Class
