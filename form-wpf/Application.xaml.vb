Imports Haley.Abstractions
Imports Haley.Models
Imports Haley.Services

Class Application

    'Application-level events, such as Startup, Exit, And DispatcherUnhandledException
    'can be handled In this file.

    Private ts As IThemeService

    Private Sub Application_Startup(sender As Object, e As StartupEventArgs)
        'Getting themeservice
        ts = ThemeService.Singleton

        Register()
    End Sub

    Private Sub Register()
        Dim _asmBuilder = New AssemblyThemeBuilder()
        _asmBuilder.Add("Light", New Uri("pack://application:,,,/form-wpf;component/View/Themes/LightTheme.xaml")).Add("Dark", New Uri("pack://application:,,,/form-wpf;component/View/Themes/DarkTheme.xaml"))

        ts.RegisterGroup(_asmBuilder)
        ts.SetStartupTheme("Dark")
    End Sub
End Class
