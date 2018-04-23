Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows

Namespace DXSample
	''' <summary>
	''' Interaction logic for MainWindow.xaml
	''' </summary>
	Partial Public Class MainWindow
		Inherits Window
		Private privateTestEntities As TestDBEntities
		Private Property TestEntities() As TestDBEntities
			Get
				Return privateTestEntities
			End Get
			Set(ByVal value As TestDBEntities)
				privateTestEntities = value
			End Set
		End Property
		Public Sub New()
			InitializeComponent()
			TestEntities = New TestDBEntities()
			For Each item As TestTable In TestEntities.TestTables
				DataContext = item
				Exit For
			Next item
		End Sub

		Private Sub OnEditValueChanged(ByVal sender As Object, ByVal e As DevExpress.Xpf.Editors.EditValueChangedEventArgs)
			TestEntities.SaveChanges()
		End Sub
	End Class
End Namespace
