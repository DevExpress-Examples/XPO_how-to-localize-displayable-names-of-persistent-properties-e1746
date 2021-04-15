Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports System.Threading
Imports System.Globalization

Namespace LocalizableDisplayName
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			' test German (Germany) culture)
			Thread.CurrentThread.CurrentCulture = New CultureInfo("de-DE")
			Thread.CurrentThread.CurrentUICulture = New CultureInfo("de-DE")

			' init XPO data layer
			XpoDefault.DataLayer = XpoDefault.GetDataLayer(AutoCreateOption.DatabaseAndSchema)

			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Form1())
		End Sub
	End Class
End Namespace