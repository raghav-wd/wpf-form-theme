Public Class Command : Implements ICommand

    Public executeMethod As Action(Of Object)
    Public canExecuteMethod As Func(Of Object, Boolean)

    Sub New(executeMethod As Action(Of Object), canExecuteMethod As Func(Of Object, Boolean))
        Me.executeMethod = executeMethod
        Me.canExecuteMethod = canExecuteMethod
    End Sub

    Public Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged

    Public Sub Execute(parameter As Object) Implements ICommand.Execute
        executeMethod(parameter)
    End Sub

    Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
        Return True
    End Function
End Class
