Public Class CharacterLimitCommand
    Implements ICommand

    Public executeMethod As Action(Of Object)
    Public canexecuteMethod As Func(Of Object, Boolean)

    Public Sub New(executeMethod As Action(Of Object), canexecuteMethod As Func(Of Object, Boolean))
        Me.executeMethod = executeMethod
        Me.canexecuteMethod = canexecuteMethod
    End Sub

    Public Event CanExecuteChanged As EventHandler Implements ICommand.CanExecuteChanged

    Public Sub Execute(parameter As Object) Implements ICommand.Execute
        executeMethod(parameter)
    End Sub

    Public Function CanExecute(parameter As Object) As Boolean Implements ICommand.CanExecute
        Return True
    End Function
End Class
