<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LaunchForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Finish_btn = New System.Windows.Forms.Button()
        Me.OnlineRadioBtn = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NoneRadioBtn = New System.Windows.Forms.RadioButton()
        Me.InternalRadioBtn = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(292, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "How do you want to get the Rom informations and pictures ?"
        '
        'Finish_btn
        '
        Me.Finish_btn.Location = New System.Drawing.Point(218, 59)
        Me.Finish_btn.Name = "Finish_btn"
        Me.Finish_btn.Size = New System.Drawing.Size(75, 23)
        Me.Finish_btn.TabIndex = 2
        Me.Finish_btn.Text = "Finish!"
        Me.Finish_btn.UseVisualStyleBackColor = True
        '
        'OnlineRadioBtn
        '
        Me.OnlineRadioBtn.AutoSize = True
        Me.OnlineRadioBtn.Location = New System.Drawing.Point(4, 3)
        Me.OnlineRadioBtn.Margin = New System.Windows.Forms.Padding(1)
        Me.OnlineRadioBtn.Name = "OnlineRadioBtn"
        Me.OnlineRadioBtn.Size = New System.Drawing.Size(100, 17)
        Me.OnlineRadioBtn.TabIndex = 3
        Me.OnlineRadioBtn.TabStop = True
        Me.OnlineRadioBtn.Text = "Online (Newest)"
        Me.OnlineRadioBtn.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.NoneRadioBtn)
        Me.Panel1.Controls.Add(Me.InternalRadioBtn)
        Me.Panel1.Controls.Add(Me.OnlineRadioBtn)
        Me.Panel1.Location = New System.Drawing.Point(15, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(162, 63)
        Me.Panel1.TabIndex = 4
        '
        'NoneRadioBtn
        '
        Me.NoneRadioBtn.AutoSize = True
        Me.NoneRadioBtn.Location = New System.Drawing.Point(4, 41)
        Me.NoneRadioBtn.Margin = New System.Windows.Forms.Padding(1)
        Me.NoneRadioBtn.Name = "NoneRadioBtn"
        Me.NoneRadioBtn.Size = New System.Drawing.Size(51, 17)
        Me.NoneRadioBtn.TabIndex = 5
        Me.NoneRadioBtn.TabStop = True
        Me.NoneRadioBtn.Text = "None"
        Me.NoneRadioBtn.UseVisualStyleBackColor = True
        '
        'InternalRadioBtn
        '
        Me.InternalRadioBtn.AutoSize = True
        Me.InternalRadioBtn.Location = New System.Drawing.Point(4, 22)
        Me.InternalRadioBtn.Margin = New System.Windows.Forms.Padding(1)
        Me.InternalRadioBtn.Name = "InternalRadioBtn"
        Me.InternalRadioBtn.Size = New System.Drawing.Size(149, 17)
        Me.InternalRadioBtn.TabIndex = 4
        Me.InternalRadioBtn.TabStop = True
        Me.InternalRadioBtn.Text = "Internal (May be outdated)"
        Me.InternalRadioBtn.UseVisualStyleBackColor = True
        '
        'LaunchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(305, 94)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Finish_btn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LaunchForm"
        Me.Opacity = 0R
        Me.ShowIcon = False
        Me.Text = "LaunchForm"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Finish_btn As Button
    Friend WithEvents OnlineRadioBtn As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents NoneRadioBtn As RadioButton
    Friend WithEvents InternalRadioBtn As RadioButton
End Class
