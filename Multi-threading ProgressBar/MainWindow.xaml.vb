Imports System.ComponentModel
Class MainWindow

    Dim WithEvents BackgroundWorker1 As BackgroundWorker

    Private Sub Window_Loaded(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles MyBase.Loaded
        Me.BackgroundWorker1 = New BackgroundWorker
        'Enable progress reporting
        BackgroundWorker1.WorkerReportsProgress = True
        'Set the progress state as "normal"
        TaskbarItemInfo.ProgressState = Shell.TaskbarItemProgressState.Normal
        'Start the work
        BackgroundWorker1.RunWorkerAsync()
        'DoWork Event occurs
        'Now control will goes to worker_DoWork Sub because it handles the DoWork Event
    End Sub

    Private Sub worker_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        For i As Integer = 0 To 99 Step 10
            System.Threading.Thread.Sleep(500)
            'Raises the ProgressChanged event passing the value
            CType(sender, System.ComponentModel.BackgroundWorker).ReportProgress(i)
            'Now control will goes to worker_ProgressChanged Sub because it handles the ProgressChanged Event
        Next i
    End Sub

    Private Sub worker_ProgressChanged(ByVal sender As Object, ByVal e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        'Increment the value on progress bars in window
        ProgressBar1.Value = e.ProgressPercentage
        'Increment the value on progress bars in Taskbar
        TaskbarItemInfo.ProgressValue = CDbl(e.ProgressPercentage) / 100
    End Sub

    ' Work completed
    Private Sub worker_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        ProgressBar1.Value = 100
        TaskbarItemInfo.ProgressValue = 1.0
        'Set the progress state as "indeterminate"
        TaskbarItemInfo.ProgressState = Shell.TaskbarItemProgressState.Indeterminate
        'display a message box and keep the result in variable result
        Dim result = MessageBox.Show("The progress completed. Would you like to exit now?", "Message - Progress Completed", MessageBoxButton.YesNo)
        'if result is Yes - Close the application
        If result = MessageBoxResult.Yes Then End
    End Sub

End Class