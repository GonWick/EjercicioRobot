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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RadioButtonMarte = New System.Windows.Forms.RadioButton()
        Me.RadioButtonLuna = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonSalir = New System.Windows.Forms.Button()
        Me.RadioButtonVenus = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(91, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Comprobar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RadioButtonMarte
        '
        Me.RadioButtonMarte.AutoSize = True
        Me.RadioButtonMarte.Location = New System.Drawing.Point(34, 41)
        Me.RadioButtonMarte.Name = "RadioButtonMarte"
        Me.RadioButtonMarte.Size = New System.Drawing.Size(62, 19)
        Me.RadioButtonMarte.TabIndex = 1
        Me.RadioButtonMarte.TabStop = True
        Me.RadioButtonMarte.Text = "MARTE"
        Me.RadioButtonMarte.UseVisualStyleBackColor = True
        '
        'RadioButtonLuna
        '
        Me.RadioButtonLuna.AutoSize = True
        Me.RadioButtonLuna.Location = New System.Drawing.Point(199, 41)
        Me.RadioButtonLuna.Name = "RadioButtonLuna"
        Me.RadioButtonLuna.Size = New System.Drawing.Size(56, 19)
        Me.RadioButtonLuna.TabIndex = 2
        Me.RadioButtonLuna.TabStop = True
        Me.RadioButtonLuna.Text = "LUNA"
        Me.RadioButtonLuna.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "A donde llego el Robot Curiosity en 2012"
        '
        'ButtonSalir
        '
        Me.ButtonSalir.Image = CType(resources.GetObject("ButtonSalir.Image"), System.Drawing.Image)
        Me.ButtonSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonSalir.Location = New System.Drawing.Point(102, 137)
        Me.ButtonSalir.Name = "ButtonSalir"
        Me.ButtonSalir.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSalir.TabIndex = 4
        Me.ButtonSalir.Text = "Salir"
        Me.ButtonSalir.UseVisualStyleBackColor = True
        '
        'RadioButtonVenus
        '
        Me.RadioButtonVenus.AutoSize = True
        Me.RadioButtonVenus.Location = New System.Drawing.Point(121, 41)
        Me.RadioButtonVenus.Name = "RadioButtonVenus"
        Me.RadioButtonVenus.Size = New System.Drawing.Size(61, 19)
        Me.RadioButtonVenus.TabIndex = 5
        Me.RadioButtonVenus.TabStop = True
        Me.RadioButtonVenus.Text = "VENUS"
        Me.RadioButtonVenus.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 181)
        Me.Controls.Add(Me.RadioButtonVenus)
        Me.Controls.Add(Me.ButtonSalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RadioButtonLuna)
        Me.Controls.Add(Me.RadioButtonMarte)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EJERCICIO ROBOT"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents RadioButtonMarte As RadioButton
    Friend WithEvents RadioButtonLuna As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonSalir As Button
    Friend WithEvents RadioButtonVenus As RadioButton
End Class
