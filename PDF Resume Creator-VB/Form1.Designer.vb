﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PDFRC
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
        Me.RtbV = New System.Windows.Forms.RichTextBox()
        Me.BtnGen = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RtbV
        '
        Me.RtbV.Location = New System.Drawing.Point(102, 32)
        Me.RtbV.Name = "RtbV"
        Me.RtbV.Size = New System.Drawing.Size(464, 512)
        Me.RtbV.TabIndex = 0
        Me.RtbV.Text = ""
        '
        'BtnGen
        '
        Me.BtnGen.Location = New System.Drawing.Point(12, 110)
        Me.BtnGen.Name = "BtnGen"
        Me.BtnGen.Size = New System.Drawing.Size(84, 37)
        Me.BtnGen.TabIndex = 1
        Me.BtnGen.Text = "Generate"
        Me.BtnGen.UseVisualStyleBackColor = True
        '
        'PDFRC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(588, 568)
        Me.Controls.Add(Me.BtnGen)
        Me.Controls.Add(Me.RtbV)
        Me.Name = "PDFRC"
        Me.Text = "Resume Creator"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RtbV As RichTextBox
    Friend WithEvents BtnGen As Button
End Class
