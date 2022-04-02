Imports System.ComponentModel

Public Class Person
    Implements INotifyPropertyChanged

    Private _firstName As String
    Public Property FirstName() As String
        Get
            Return _firstName
        End Get
        Protected Set(value As String)
            _firstName = value
            NotifyPropertyChanged(_firstName)
        End Set
    End Property
    Private _lastName As String
    Public Property LastName() As String
        Get
            Return _lastName
        End Get
        Protected Set(value As String)
            _lastName = value
            NotifyPropertyChanged(_lastName)
        End Set
    End Property
    Private _email As String
    Public Property Email() As String
        Get
            Return _email
        End Get
        Protected Set(value As String)
            _email = value
            NotifyPropertyChanged(_email)
        End Set
    End Property
    Private _country As String
    Public Property Country() As String
        Get
            Return _country
        End Get
        Protected Set(value As String)
            _country = value
            NotifyPropertyChanged(_country)
        End Set
    End Property
    Private _description As String

    Public Property Description() As String
        Get
            Return _description
        End Get
        Protected Set(value As String)
            _description = value
            NotifyPropertyChanged(_description)
        End Set
    End Property

    Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

    Private Sub NotifyPropertyChanged(ByVal info As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(info))
    End Sub

End Class
