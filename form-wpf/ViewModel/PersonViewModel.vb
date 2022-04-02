Imports System.ComponentModel

Namespace ViewModel
    Public Class PersonViewModel
        Implements INotifyPropertyChanged

        Private _person As Person
        Public MyCommand As Command


        Public Sub New()
            MyCommand = New Command(AddressOf ExecuteMethod, AddressOf canExecuteMethod)
        End Sub

        Private Sub ExecuteMethod(parameter As Object)
            MessageBox.Show("Hey show login")
        End Sub
        Private Function canExecuteMethod(parameter As Object) As Boolean
            Return True
        End Function


        Public Property Person() As Person
            Get
                Return _person
            End Get
            Protected Set(value As Person)
                _person = value
            End Set
        End Property

        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Private Sub NotifyPropertyChanged(ByVal info As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(info))
        End Sub

    End Class

End Namespace
