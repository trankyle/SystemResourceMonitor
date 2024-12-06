<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        lblTitle = New Label()
        lblCpuUsage = New Label()
        lblMemoryUsage = New Label()
        progressCpu = New ProgressBar()
        progressMemory = New ProgressBar()
        timerUpdate = New Timer(components)
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.ImageAlign = ContentAlignment.MiddleRight
        lblTitle.Location = New Point(12, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(347, 22)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Real-Time System Resource Monitor"
        lblTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lblCpuUsage
        ' 
        lblCpuUsage.AutoSize = True
        lblCpuUsage.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblCpuUsage.Location = New Point(12, 51)
        lblCpuUsage.Name = "lblCpuUsage"
        lblCpuUsage.Size = New Size(124, 21)
        lblCpuUsage.TabIndex = 1
        lblCpuUsage.Text = "CPU Usage: 0%"
        ' 
        ' lblMemoryUsage
        ' 
        lblMemoryUsage.AutoSize = True
        lblMemoryUsage.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMemoryUsage.Location = New Point(12, 135)
        lblMemoryUsage.Name = "lblMemoryUsage"
        lblMemoryUsage.Size = New Size(157, 21)
        lblMemoryUsage.TabIndex = 2
        lblMemoryUsage.Text = "Memory Usage: 0%"
        ' 
        ' progressCpu
        ' 
        progressCpu.Location = New Point(12, 86)
        progressCpu.Name = "progressCpu"
        progressCpu.Size = New Size(347, 23)
        progressCpu.TabIndex = 3
        ' 
        ' progressMemory
        ' 
        progressMemory.Location = New Point(12, 174)
        progressMemory.Name = "progressMemory"
        progressMemory.Size = New Size(347, 23)
        progressMemory.TabIndex = 4
        ' 
        ' timerUpdate
        ' 
        timerUpdate.Interval = 1000
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(384, 261)
        Controls.Add(progressMemory)
        Controls.Add(progressCpu)
        Controls.Add(lblMemoryUsage)
        Controls.Add(lblCpuUsage)
        Controls.Add(lblTitle)
        Name = "Form1"
        Text = "System Resource Monitor"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCpuUsage As Label
    Friend WithEvents lblMemoryUsage As Label
    Friend WithEvents progressCpu As ProgressBar
    Friend WithEvents progressMemory As ProgressBar


    Friend WithEvents timerUpdate As Timer
End Class
