Imports Microsoft.Office.Interop.Excel

Module Module1

    Sub Main()
        Dim pXlApp As Application = CreateObject("Excel.Application")
        Dim pXlWkBk As Workbook = pXlApp.Workbooks.Open("D:\\testexcelautomation.xlsx")
        ' pXlApp.Visible = True
        If pXlWkBk Is Nothing Then
            Console.WriteLine("we have not opened the workbook")
        Else
            Console.WriteLine("we have connected to the workbook")
            Dim xlSheet As Worksheet = pXlWkBk.Worksheets.Item(1)
            Dim xlRange As Range = xlSheet.Cells(1, 1)
            Console.WriteLine(xlRange.Value.ToString())
            xlRange.Value = "this is the changed value from automation"
            pXlWkBk.Save()
            pXlWkBk.Close()
        End If
        pXlApp.Quit()
        Console.ReadLine()

    End Sub

End Module
