Imports Haley.Abstractions
Imports Haley.Models
Imports Haley.Services

Class MainWindow
    Private ts As IThemeService

    Public Sub New()
        'Getting themeservice
        ts = ThemeService.Singleton
        InitializeComponent()
        cbxTheme.SelectedItem = ts.StartupTheme 'initializing cbx from start theme
    End Sub

    Private Sub cbxTheme_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)
        Dim newTheme As ComboBoxItem = cbxTheme.SelectedItem
        ts.ChangeTheme(newTheme?.Content)
    End Sub

    Private Sub RichTextBox_TextChanged(sender As Object, e As TextChangedEventArgs)
        'Me.txtBTextLimit.Text = "dskf"
        'MessageBox.Show("richtext")
    End Sub
End Class
