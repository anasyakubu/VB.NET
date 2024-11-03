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
        Me.btn1 = New System.Windows.Forms.Button()
        Me.BtnVariable = New System.Windows.Forms.Button()
        Me.DataType = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(144, 119)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(304, 116)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "go"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'BtnVariable
        '
        Me.BtnVariable.Location = New System.Drawing.Point(504, 125)
        Me.BtnVariable.Name = "BtnVariable"
        Me.BtnVariable.Size = New System.Drawing.Size(303, 99)
        Me.BtnVariable.TabIndex = 1
        Me.BtnVariable.Text = "Variable Demonstration"
        Me.BtnVariable.UseVisualStyleBackColor = True
        '
        'DataType
        '
        Me.DataType.Location = New System.Drawing.Point(148, 271)
        Me.DataType.Name = "DataType"
        Me.DataType.Size = New System.Drawing.Size(299, 115)
        Me.DataType.TabIndex = 2
        Me.DataType.Text = "Data Types"
        Me.DataType.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 527)
        Me.Controls.Add(Me.DataType)
        Me.Controls.Add(Me.BtnVariable)
        Me.Controls.Add(Me.btn1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn1 As Button
    Friend WithEvents BtnVariable As Button
    Friend WithEvents DataType As Button
End Class
