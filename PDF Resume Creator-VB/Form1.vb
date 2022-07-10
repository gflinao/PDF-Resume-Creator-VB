Imports System.IO
Imports Newtonsoft.Json
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.draw


Public Class PDFRC
    Private Sub PDFRC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnGen_Click(sender As Object, e As EventArgs) Handles BtnGen.Click

        Dim pathjson As String = "C:\Users\admin\source\repos\PDF Resume Creator-VB\PDF Resume Creator-VB\LinaoJson.json"
        Dim openjson As String = File.ReadAllText(pathjson)
        Dim outpjson As readJson = JsonConvert.DeserializeObject(Of readJson)(openjson)
        Dim PDFc As New Document()
        PdfWriter.GetInstance(PDFc, New FileStream("C:\Users\admin\source\repos\PDF Resume Creator-VB\PDF Resume Creator-VB\Linao_Genrev.pdf", FileMode.Create))

        Dim main_font As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 22, iTextSharp.text.Font.BOLD)
        Dim lessmain_font As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 17, iTextSharp.text.Font.BOLD)
        Dim second_font As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 15, iTextSharp.text.Font.BOLD)
        Dim normal_font As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 12, iTextSharp.text.Font.NORMAL)
        Dim smaller_font As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 10, iTextSharp.text.Font.NORMAL)
        Dim space_font As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 5, iTextSharp.text.Font.NORMAL)
        Dim normal_bold As iTextSharp.text.Font = FontFactory.GetFont(iTextSharp.text.Font.FontFamily.TIMES_ROMAN.ToString(), 12, iTextSharp.text.Font.ITALIC)
        Dim separate As New LineSeparator(2.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_BOTTOM, 1)
        Dim FName As New Paragraph(outpjson.FullName & vbLf, main_font)
        Dim Profile As New Paragraph(vbLf & outpjson.Profile & vbLf & vbLf, normal_font)
        Dim Address As New Paragraph(vbLf & outpjson.RAddress & vbLf)
        Dim PhoneNum As New Paragraph(vbLf & outpjson.PhoneNumber & vbLf)
        Dim EmailAdd As New Paragraph(outpjson.EmailAddress & vbLf & vbLf & vbLf)
        Dim About As New Paragraph(outpjson.AboutHead & vbLf, lessmain_font)
        Dim Educ As New Paragraph(outpjson.EducHead.ToString(), lessmain_font)
        Dim College As New Paragraph(vbLf & outpjson.EducCollege.ToString(), second_font)
        Dim CSchool As New Paragraph(outpjson.EducSchool.ToString(), smaller_font)
        Dim CYear As New Paragraph(outpjson.EducYear.ToString(), normal_bold)
        Dim space As New Paragraph(vbLf, space_font)


        PDFc.Open()
        PDFc.Add(FName)
        PDFc.Add(space)
        PDFc.Add(separate)
        PDFc.Add(separate)
        PDFc.Add(Address)
        PDFc.Add(PhoneNum)
        PDFc.Add(EmailAdd)
        PDFc.Add(About)
        PDFc.Add(Profile)
        PDFc.Add(space)
        PDFc.Add(space)
        PDFc.Add(separate)
        PDFc.Add(Educ)
        PDFc.Add(College)
        PDFc.Add(CSchool)
        PDFc.Add(CYear)


    End Sub

    Public Class readJson
        Public Property FullName As String
        Public Property Profile As String
        Public Property RAddress As String
        Public Property PhoneNumber As String
        Public Property EmailAddress As String
        Public Property AboutHead As String
        Public Property EducHead As String
        Public Property EducCollege As String
        Public Property EducSchool As String
        Public Property EducYear As String

    End Class


End Class

