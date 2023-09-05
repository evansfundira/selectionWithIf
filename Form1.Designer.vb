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
        btnGreet = New Button()
        Label1 = New Label()
        txtCountry = New TextBox()
        SuspendLayout()
        ' 
        ' btnGreet
        ' 
        btnGreet.Location = New Point(338, 252)
        btnGreet.Name = "btnGreet"
        btnGreet.Size = New Size(94, 29)
        btnGreet.TabIndex = 0
        btnGreet.Text = "Greet!"
        btnGreet.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(125, 116)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 20)
        Label1.TabIndex = 1
        Label1.Text = "Enter your country"
        ' 
        ' txtCountry
        ' 
        txtCountry.Location = New Point(279, 109)
        txtCountry.Name = "txtCountry"
        txtCountry.Size = New Size(250, 27)
        txtCountry.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtCountry)
        Controls.Add(Label1)
        Controls.Add(btnGreet)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnGreet As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCountry As TextBox
End Class
