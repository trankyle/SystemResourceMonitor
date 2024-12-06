Imports System.Diagnostics
Public Class Form1
    Private cpuCounter As PerformanceCounter
    Private ramCounter As PerformanceCounter
    Private Sub progressCpu_Click(sender As Object, e As EventArgs) Handles progressCpu.Click

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize CPU and RAM PerformanceCounters
        cpuCounter = New PerformanceCounter("Processor", "% Processor Time", "_Total")
        ramCounter = New PerformanceCounter("Memory", "Available MBytes")

        ' Start the timer
        timerUpdate.Start()
    End Sub
    Private Sub timerUpdate_Tick(sender As Object, e As EventArgs) Handles timerUpdate.Tick
        ' Get current CPU usage
        Dim cpuUsage As Single = cpuCounter.NextValue()

        ' Get total physical memory and available memory
        Dim totalMemory As Single = My.Computer.Info.TotalPhysicalMemory / (1024 * 1024)
        Dim availableMemory As Single = ramCounter.NextValue()
        Dim usedMemory As Single = totalMemory - availableMemory
        Dim memoryUsage As Single = (usedMemory / totalMemory) * 100

        ' Update labels
        lblCpuUsage.Text = $"CPU Usage: {Math.Round(cpuUsage)}%"
        lblMemoryUsage.Text = $"Memory Usage: {Math.Round(memoryUsage)}%"

        ' Update progress bars
        progressCpu.Value = Math.Min(100, Math.Round(cpuUsage))
        progressMemory.Value = Math.Min(100, Math.Round(memoryUsage))
    End Sub

    Private Sub lblMemoryUsage_Click(sender As Object, e As EventArgs) Handles lblMemoryUsage.Click

    End Sub
End Class
