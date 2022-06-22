<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ConectarButton = New System.Windows.Forms.Button()
        Me.SeuIPLabel = New System.Windows.Forms.Label()
        Me.IPExternoLabel = New System.Windows.Forms.Label()
        Me.SeuIPTextBox = New System.Windows.Forms.TextBox()
        Me.IPExternoTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'ConectarButton
        '
        Me.ConectarButton.BackColor = System.Drawing.Color.Aqua
        Me.ConectarButton.Location = New System.Drawing.Point(137, 129)
        Me.ConectarButton.Name = "ConectarButton"
        Me.ConectarButton.Size = New System.Drawing.Size(104, 46)
        Me.ConectarButton.TabIndex = 0
        Me.ConectarButton.Text = "CONECTAR"
        Me.ConectarButton.UseVisualStyleBackColor = False
        '
        'SeuIPLabel
        '
        Me.SeuIPLabel.AutoSize = True
        Me.SeuIPLabel.Location = New System.Drawing.Point(64, 36)
        Me.SeuIPLabel.Name = "SeuIPLabel"
        Me.SeuIPLabel.Size = New System.Drawing.Size(39, 15)
        Me.SeuIPLabel.TabIndex = 1
        Me.SeuIPLabel.Text = "Seu IP"
        '
        'IPExternoLabel
        '
        Me.IPExternoLabel.AutoSize = True
        Me.IPExternoLabel.Location = New System.Drawing.Point(43, 79)
        Me.IPExternoLabel.Name = "IPExternoLabel"
        Me.IPExternoLabel.Size = New System.Drawing.Size(60, 15)
        Me.IPExternoLabel.TabIndex = 2
        Me.IPExternoLabel.Text = "IP externo"
        '
        'SeuIPTextBox
        '
        Me.SeuIPTextBox.Location = New System.Drawing.Point(109, 33)
        Me.SeuIPTextBox.Name = "SeuIPTextBox"
        Me.SeuIPTextBox.Size = New System.Drawing.Size(176, 23)
        Me.SeuIPTextBox.TabIndex = 3
        '
        'IPExternoTextBox
        '
        Me.IPExternoTextBox.Location = New System.Drawing.Point(109, 76)
        Me.IPExternoTextBox.Name = "IPExternoTextBox"
        Me.IPExternoTextBox.Size = New System.Drawing.Size(176, 23)
        Me.IPExternoTextBox.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Salmon
        Me.ClientSize = New System.Drawing.Size(382, 187)
        Me.Controls.Add(Me.IPExternoTextBox)
        Me.Controls.Add(Me.SeuIPTextBox)
        Me.Controls.Add(Me.IPExternoLabel)
        Me.Controls.Add(Me.SeuIPLabel)
        Me.Controls.Add(Me.ConectarButton)
        Me.Name = "Form1"
        Me.Text = "Acesso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ConectarButton As Button
    Friend WithEvents SeuIPLabel As Label
    Friend WithEvents IPExternoLabel As Label
    Friend WithEvents SeuIPTextBox As TextBox
    Friend WithEvents IPExternoTextBox As TextBox
End Class
