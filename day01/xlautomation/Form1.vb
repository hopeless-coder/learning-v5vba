Imports Microsoft.Office.Interop.Excel
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pXLApp As Application
        pXLApp = CreateObject("Excel.Application")
        pXLApp.Visible = True
        Dim pWkBk As Workbook
        'pWkBk = pXLApp.Workbooks.Add()
        pWkBk = pXLApp.Workbooks.Open("D:\\test.xlsx")
        Dim pWkSheet As Worksheet
        pWkSheet = pWkBk.Worksheets.Item(1)

        Dim pRange As Range
        pRange = pWkSheet.UsedRange

        MsgBox(pRange.Cells.Item(1, 2).Value)
        pRange.Value = "Test value from the automation"
        pWkBk.Save()
        pXLApp.Quit()
    End Sub
End Class
