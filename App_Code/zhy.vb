Imports Microsoft.VisualBasic
Imports System.IO

Public Class zhy
    Shared Function xyj(ByVal add As String) As String ' 输入文件名（包括绝对地址），返回字符串形式的文件内容
        Dim Reader As StreamReader '声明一个StreamReader对象
        Dim filecont As String '声明一个变量保存读出的内容
        Dim content As String = ""
        Reader = File.OpenText(add) '打开文件赋值到StreamReader对象
        Do '按行循环读取文件内容
            filecont = Reader.ReadLine()
            content += filecont + vbCrLf
        Loop Until filecont = ""
        Reader.Close() '关闭StreamReader对象
        Return "<xmp>" & content & "</xmp>"
    End Function

    Shared Function szy(ByVal add As String) As String ' 输入文件名（包括绝对地址），返回字符串形式的文件内容
        Dim fileLines() As String = IO.File.ReadAllLines(add, System.Text.Encoding.Default)
        Dim filelen As Integer = UBound(fileLines)
        Dim lines As String = " "
        Dim i As Integer
        For i = 0 To filelen
            lines = lines & vbCrLf & fileLines(i)
        Next
        Return "<xmp>" & lines & "</xmp>"
    End Function
End Class
