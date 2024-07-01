<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ITMAssessment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim cbSubjectsS As System.Windows.Forms.ComboBox
        Dim btnSearch As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ITMAssessment))
        Me.cbStudType = New System.Windows.Forms.ComboBox()
        Me.cbCourse = New System.Windows.Forms.ComboBox()
        Me.cbYRLVL = New System.Windows.Forms.ComboBox()
        Me.cbSection = New System.Windows.Forms.ComboBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.SubjectCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubjectName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Units = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Schedule = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtStudentName = New System.Windows.Forms.TextBox()
        Me.btnPrint = New Guna.UI2.WinForms.Guna2Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStudentNum = New System.Windows.Forms.TextBox()
        Me.GunaGroupBox2 = New Guna.UI.WinForms.GunaGroupBox()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.lblPrefinal = New System.Windows.Forms.Label()
        Me.lblMidterm = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lblPrelim = New System.Windows.Forms.Label()
        Me.lblUE = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.lblFull = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.cbDCType = New System.Windows.Forms.ComboBox()
        Me.cbDCPercent = New System.Windows.Forms.ComboBox()
        Me.txtDP = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblLabF = New System.Windows.Forms.Label()
        Me.lblIE = New System.Windows.Forms.Label()
        Me.lblLF = New System.Windows.Forms.Label()
        Me.lblMF = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblTF = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        cbSubjectsS = New System.Windows.Forms.ComboBox()
        btnSearch = New System.Windows.Forms.Button()
        Me.GunaGroupBox2.SuspendLayout()
        Me.GunaGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbStudType
        '
        Me.cbStudType.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStudType.FormattingEnabled = True
        Me.cbStudType.Items.AddRange(New Object() {"New", "Old"})
        Me.cbStudType.Location = New System.Drawing.Point(715, 49)
        Me.cbStudType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbStudType.Name = "cbStudType"
        Me.cbStudType.Size = New System.Drawing.Size(110, 35)
        Me.cbStudType.TabIndex = 214
        Me.cbStudType.Text = "New"
        '
        'cbCourse
        '
        Me.cbCourse.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCourse.FormattingEnabled = True
        Me.cbCourse.Items.AddRange(New Object() {"BSIT", "BSCS"})
        Me.cbCourse.Location = New System.Drawing.Point(715, 150)
        Me.cbCourse.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbCourse.Name = "cbCourse"
        Me.cbCourse.Size = New System.Drawing.Size(110, 35)
        Me.cbCourse.TabIndex = 213
        Me.cbCourse.Text = "BSIT"
        '
        'cbYRLVL
        '
        Me.cbYRLVL.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbYRLVL.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        Me.cbYRLVL.Location = New System.Drawing.Point(457, 150)
        Me.cbYRLVL.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbYRLVL.Name = "cbYRLVL"
        Me.cbYRLVL.Size = New System.Drawing.Size(155, 35)
        Me.cbYRLVL.TabIndex = 212
        Me.cbYRLVL.Text = "1st Year"
        '
        'cbSection
        '
        Me.cbSection.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSection.FormattingEnabled = True
        Me.cbSection.Items.AddRange(New Object() {"BSIT-1-1-E1", "BSIT-1-1-E2", "BSIT-1-1-E3", "BSIT-1-2-E1", "BSIT-1-2-E2", "BSIT-1-2-E3", "BSIT-2-1-E1", "BSIT-2-1-E2", "BSIT-2-1-E3"})
        Me.cbSection.Location = New System.Drawing.Point(457, 49)
        Me.cbSection.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbSection.Name = "cbSection"
        Me.cbSection.Size = New System.Drawing.Size(155, 35)
        Me.cbSection.TabIndex = 211
        Me.cbSection.Text = "BSIT-1-1-E1"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.SubjectCode, Me.SubjectName, Me.Units, Me.Schedule})
        Me.ListView1.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(12, 220)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1205, 235)
        Me.ListView1.TabIndex = 210
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'SubjectCode
        '
        Me.SubjectCode.Text = "Subject Code"
        Me.SubjectCode.Width = 198
        '
        'SubjectName
        '
        Me.SubjectName.Text = "Subject Name"
        Me.SubjectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.SubjectName.Width = 364
        '
        'Units
        '
        Me.Units.Text = "Units"
        Me.Units.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Units.Width = 427
        '
        'Schedule
        '
        Me.Schedule.Text = "             Schedule"
        Me.Schedule.Width = 748
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(900, 23)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 24)
        Me.Label2.TabIndex = 208
        Me.Label2.Text = "Academic Year"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(711, 127)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 23)
        Me.Label16.TabIndex = 207
        Me.Label16.Text = "Course"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(453, 127)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 23)
        Me.Label15.TabIndex = 206
        Me.Label15.Text = "Year Level"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Palatino Linotype", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(713, 24)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(112, 23)
        Me.Label14.TabIndex = 205
        Me.Label14.Text = "Student Type"
        '
        'txtStudentName
        '
        Me.txtStudentName.BackColor = System.Drawing.Color.White
        Me.txtStudentName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStudentName.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentName.ForeColor = System.Drawing.Color.Black
        Me.txtStudentName.Location = New System.Drawing.Point(47, 153)
        Me.txtStudentName.Margin = New System.Windows.Forms.Padding(8)
        Me.txtStudentName.MaxLength = 50
        Me.txtStudentName.Name = "txtStudentName"
        Me.txtStudentName.Size = New System.Drawing.Size(323, 32)
        Me.txtStudentName.TabIndex = 204
        Me.txtStudentName.Tag = ""
        '
        'btnPrint
        '
        Me.btnPrint.BorderRadius = 15
        Me.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPrint.FillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnPrint.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.Black
        Me.btnPrint.Location = New System.Drawing.Point(904, 138)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(266, 59)
        Me.btnPrint.TabIndex = 202
        Me.btnPrint.Text = "Print"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(453, 23)
        Me.Label4.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 24)
        Me.Label4.TabIndex = 201
        Me.Label4.Text = "Section"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(43, 121)
        Me.Label3.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 24)
        Me.Label3.TabIndex = 200
        Me.Label3.Text = "Student Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(43, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 24)
        Me.Label1.TabIndex = 199
        Me.Label1.Text = "Student Number"
        '
        'txtStudentNum
        '
        Me.txtStudentNum.BackColor = System.Drawing.Color.White
        Me.txtStudentNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStudentNum.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudentNum.ForeColor = System.Drawing.Color.Black
        Me.txtStudentNum.Location = New System.Drawing.Point(48, 55)
        Me.txtStudentNum.Margin = New System.Windows.Forms.Padding(8)
        Me.txtStudentNum.MaxLength = 5
        Me.txtStudentNum.Name = "txtStudentNum"
        Me.txtStudentNum.Size = New System.Drawing.Size(243, 32)
        Me.txtStudentNum.TabIndex = 198
        Me.txtStudentNum.Tag = ""
        '
        'GunaGroupBox2
        '
        Me.GunaGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.GunaGroupBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GunaGroupBox2.BorderSize = 2
        Me.GunaGroupBox2.Controls.Add(Me.lblFinal)
        Me.GunaGroupBox2.Controls.Add(Me.lblPrefinal)
        Me.GunaGroupBox2.Controls.Add(Me.lblMidterm)
        Me.GunaGroupBox2.Controls.Add(Me.Label28)
        Me.GunaGroupBox2.Controls.Add(Me.Label27)
        Me.GunaGroupBox2.Controls.Add(Me.Label26)
        Me.GunaGroupBox2.Controls.Add(Me.lblPrelim)
        Me.GunaGroupBox2.Controls.Add(Me.lblUE)
        Me.GunaGroupBox2.Controls.Add(Me.Label35)
        Me.GunaGroupBox2.Controls.Add(Me.Label36)
        Me.GunaGroupBox2.Controls.Add(Me.Label38)
        Me.GunaGroupBox2.Controls.Add(Me.Label39)
        Me.GunaGroupBox2.Controls.Add(Me.lblFull)
        Me.GunaGroupBox2.Controls.Add(Me.Label42)
        Me.GunaGroupBox2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox2.ForeColor = System.Drawing.Color.White
        Me.GunaGroupBox2.LineColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GunaGroupBox2.Location = New System.Drawing.Point(862, 487)
        Me.GunaGroupBox2.Name = "GunaGroupBox2"
        Me.GunaGroupBox2.Size = New System.Drawing.Size(355, 339)
        Me.GunaGroupBox2.TabIndex = 216
        Me.GunaGroupBox2.Text = "Payment Scheme"
        Me.GunaGroupBox2.TextLocation = New System.Drawing.Point(10, 8)
        '
        'lblFinal
        '
        Me.lblFinal.AutoSize = True
        Me.lblFinal.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinal.ForeColor = System.Drawing.Color.White
        Me.lblFinal.Location = New System.Drawing.Point(284, 298)
        Me.lblFinal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(49, 28)
        Me.lblFinal.TabIndex = 64
        Me.lblFinal.Text = "0.00"
        '
        'lblPrefinal
        '
        Me.lblPrefinal.AutoSize = True
        Me.lblPrefinal.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrefinal.ForeColor = System.Drawing.Color.White
        Me.lblPrefinal.Location = New System.Drawing.Point(283, 260)
        Me.lblPrefinal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrefinal.Name = "lblPrefinal"
        Me.lblPrefinal.Size = New System.Drawing.Size(49, 28)
        Me.lblPrefinal.TabIndex = 63
        Me.lblPrefinal.Text = "0.00"
        '
        'lblMidterm
        '
        Me.lblMidterm.AutoSize = True
        Me.lblMidterm.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMidterm.ForeColor = System.Drawing.Color.White
        Me.lblMidterm.Location = New System.Drawing.Point(283, 220)
        Me.lblMidterm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMidterm.Name = "lblMidterm"
        Me.lblMidterm.Size = New System.Drawing.Size(49, 28)
        Me.lblMidterm.TabIndex = 62
        Me.lblMidterm.Text = "0.00"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(57, 298)
        Me.Label28.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(54, 28)
        Me.Label28.TabIndex = 61
        Me.Label28.Text = "Final"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(57, 260)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(87, 28)
        Me.Label27.TabIndex = 60
        Me.Label27.Text = "Pre-final"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(57, 220)
        Me.Label26.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(90, 28)
        Me.Label26.TabIndex = 59
        Me.Label26.Text = "Midterm"
        '
        'lblPrelim
        '
        Me.lblPrelim.AutoSize = True
        Me.lblPrelim.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrelim.ForeColor = System.Drawing.Color.White
        Me.lblPrelim.Location = New System.Drawing.Point(283, 184)
        Me.lblPrelim.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrelim.Name = "lblPrelim"
        Me.lblPrelim.Size = New System.Drawing.Size(49, 28)
        Me.lblPrelim.TabIndex = 58
        Me.lblPrelim.Text = "0.00"
        '
        'lblUE
        '
        Me.lblUE.AutoSize = True
        Me.lblUE.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUE.ForeColor = System.Drawing.Color.White
        Me.lblUE.Location = New System.Drawing.Point(283, 145)
        Me.lblUE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUE.Name = "lblUE"
        Me.lblUE.Size = New System.Drawing.Size(49, 28)
        Me.lblUE.TabIndex = 57
        Me.lblUE.Text = "0.00"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label35.Location = New System.Drawing.Point(-55, 57)
        Me.Label35.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(0, 28)
        Me.Label35.TabIndex = 52
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.White
        Me.Label36.Location = New System.Drawing.Point(57, 184)
        Me.Label36.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(69, 28)
        Me.Label36.TabIndex = 56
        Me.Label36.Text = "Prelim"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.White
        Me.Label38.Location = New System.Drawing.Point(57, 145)
        Me.Label38.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(168, 28)
        Me.Label38.TabIndex = 55
        Me.Label38.Text = "Upon Enrollment"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(14, 63)
        Me.Label39.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(130, 28)
        Me.Label39.TabIndex = 51
        Me.Label39.Text = "Full Payment"
        '
        'lblFull
        '
        Me.lblFull.AutoSize = True
        Me.lblFull.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFull.ForeColor = System.Drawing.Color.White
        Me.lblFull.Location = New System.Drawing.Point(283, 67)
        Me.lblFull.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFull.Name = "lblFull"
        Me.lblFull.Size = New System.Drawing.Size(49, 28)
        Me.lblFull.TabIndex = 54
        Me.lblFull.Text = "0.00"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.White
        Me.Label42.Location = New System.Drawing.Point(14, 105)
        Me.Label42.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(120, 28)
        Me.Label42.TabIndex = 53
        Me.Label42.Text = "Installment "
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GunaGroupBox1.BorderSize = 2
        Me.GunaGroupBox1.Controls.Add(Me.cbDCType)
        Me.GunaGroupBox1.Controls.Add(Me.cbDCPercent)
        Me.GunaGroupBox1.Controls.Add(Me.txtDP)
        Me.GunaGroupBox1.Controls.Add(Me.Label25)
        Me.GunaGroupBox1.Controls.Add(Me.lblTotal)
        Me.GunaGroupBox1.Controls.Add(Me.Label18)
        Me.GunaGroupBox1.Controls.Add(Me.lblLabF)
        Me.GunaGroupBox1.Controls.Add(Me.lblIE)
        Me.GunaGroupBox1.Controls.Add(Me.lblLF)
        Me.GunaGroupBox1.Controls.Add(Me.lblMF)
        Me.GunaGroupBox1.Controls.Add(Me.Label17)
        Me.GunaGroupBox1.Controls.Add(Me.Label11)
        Me.GunaGroupBox1.Controls.Add(Me.Label5)
        Me.GunaGroupBox1.Controls.Add(Me.Label7)
        Me.GunaGroupBox1.Controls.Add(Me.Label10)
        Me.GunaGroupBox1.Controls.Add(Me.lblTF)
        Me.GunaGroupBox1.Controls.Add(Me.Label12)
        Me.GunaGroupBox1.Controls.Add(Me.Label13)
        Me.GunaGroupBox1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox1.ForeColor = System.Drawing.Color.White
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GunaGroupBox1.Location = New System.Drawing.Point(12, 487)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(808, 339)
        Me.GunaGroupBox1.TabIndex = 215
        Me.GunaGroupBox1.Text = "Assessment"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'cbDCType
        '
        Me.cbDCType.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDCType.Items.AddRange(New Object() {"Admission", "ROTC", "Athlete", "Government"})
        Me.cbDCType.Location = New System.Drawing.Point(255, 292)
        Me.cbDCType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbDCType.Name = "cbDCType"
        Me.cbDCType.Size = New System.Drawing.Size(137, 35)
        Me.cbDCType.TabIndex = 218
        Me.cbDCType.Text = "Admission"
        '
        'cbDCPercent
        '
        Me.cbDCPercent.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDCPercent.Items.AddRange(New Object() {"30%", "40%", "50%", "60%", "85%", "100%"})
        Me.cbDCPercent.Location = New System.Drawing.Point(407, 291)
        Me.cbDCPercent.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbDCPercent.Name = "cbDCPercent"
        Me.cbDCPercent.Size = New System.Drawing.Size(95, 35)
        Me.cbDCPercent.TabIndex = 217
        Me.cbDCPercent.Text = "30%"
        '
        'txtDP
        '
        Me.txtDP.BackColor = System.Drawing.Color.White
        Me.txtDP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDP.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDP.ForeColor = System.Drawing.Color.Black
        Me.txtDP.Location = New System.Drawing.Point(551, 255)
        Me.txtDP.Margin = New System.Windows.Forms.Padding(8)
        Me.txtDP.MaxLength = 4
        Me.txtDP.Name = "txtDP"
        Me.txtDP.Size = New System.Drawing.Size(206, 32)
        Me.txtDP.TabIndex = 174
        Me.txtDP.Tag = ""
        Me.txtDP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Malgun Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.White
        Me.Label25.Location = New System.Drawing.Point(549, 210)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(208, 37)
        Me.Label25.TabIndex = 62
        Me.Label25.Text = "Down Payment:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Malgun Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(597, 105)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(90, 50)
        Me.lblTotal.TabIndex = 61
        Me.lblTotal.Text = "0.00"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Malgun Gothic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(537, 63)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(213, 32)
        Me.Label18.TabIndex = 60
        Me.Label18.Text = "Total Assessment"
        '
        'lblLabF
        '
        Me.lblLabF.AutoSize = True
        Me.lblLabF.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabF.ForeColor = System.Drawing.Color.White
        Me.lblLabF.Location = New System.Drawing.Point(402, 236)
        Me.lblLabF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLabF.Name = "lblLabF"
        Me.lblLabF.Size = New System.Drawing.Size(47, 27)
        Me.lblLabF.TabIndex = 57
        Me.lblLabF.Text = "0.00"
        '
        'lblIE
        '
        Me.lblIE.AutoSize = True
        Me.lblIE.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIE.ForeColor = System.Drawing.Color.White
        Me.lblIE.Location = New System.Drawing.Point(402, 197)
        Me.lblIE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIE.Name = "lblIE"
        Me.lblIE.Size = New System.Drawing.Size(47, 27)
        Me.lblIE.TabIndex = 56
        Me.lblIE.Text = "0.00"
        '
        'lblLF
        '
        Me.lblLF.AutoSize = True
        Me.lblLF.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLF.ForeColor = System.Drawing.Color.White
        Me.lblLF.Location = New System.Drawing.Point(402, 119)
        Me.lblLF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLF.Name = "lblLF"
        Me.lblLF.Size = New System.Drawing.Size(47, 27)
        Me.lblLF.TabIndex = 55
        Me.lblLF.Text = "0.00"
        '
        'lblMF
        '
        Me.lblMF.AutoSize = True
        Me.lblMF.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMF.ForeColor = System.Drawing.Color.White
        Me.lblMF.Location = New System.Drawing.Point(402, 82)
        Me.lblMF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMF.Name = "lblMF"
        Me.lblMF.Size = New System.Drawing.Size(47, 27)
        Me.lblMF.TabIndex = 54
        Me.lblMF.Text = "0.00"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(46, 300)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(99, 27)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "Discount:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(46, 82)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 27)
        Me.Label11.TabIndex = 47
        Me.Label11.Text = "Misc Fee:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(97, 236)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 27)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Lab Fee:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(97, 197)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 27)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Installment Fee:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(46, 45)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 27)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Tuition Fee:"
        '
        'lblTF
        '
        Me.lblTF.AutoSize = True
        Me.lblTF.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTF.ForeColor = System.Drawing.Color.White
        Me.lblTF.Location = New System.Drawing.Point(402, 45)
        Me.lblTF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTF.Name = "lblTF"
        Me.lblTF.Size = New System.Drawing.Size(47, 27)
        Me.lblTF.TabIndex = 50
        Me.lblTF.Text = "0.00"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(46, 119)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(152, 27)
        Me.Label12.TabIndex = 48
        Me.Label12.Text = "Laboratory Fee:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(46, 158)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 27)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Other Fee:"
        '
        'cbSubjectsS
        '
        cbSubjectsS.Enabled = False
        cbSubjectsS.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        cbSubjectsS.Items.AddRange(New Object() {"2023-2024"})
        cbSubjectsS.Location = New System.Drawing.Point(904, 49)
        cbSubjectsS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        cbSubjectsS.Name = "cbSubjectsS"
        cbSubjectsS.Size = New System.Drawing.Size(266, 35)
        cbSubjectsS.TabIndex = 217
        cbSubjectsS.Text = "               2023-2024"
        '
        'btnSearch
        '
        btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(248, Byte), Integer))
        btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(248, Byte), Integer))
        btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        btnSearch.Location = New System.Drawing.Point(291, 55)
        btnSearch.Margin = New System.Windows.Forms.Padding(5)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New System.Drawing.Size(79, 32)
        btnSearch.TabIndex = 203
        btnSearch.UseVisualStyleBackColor = False
        '
        'ITMAssessment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1258, 875)
        Me.Controls.Add(cbSubjectsS)
        Me.Controls.Add(Me.GunaGroupBox2)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.cbStudType)
        Me.Controls.Add(Me.cbCourse)
        Me.Controls.Add(Me.cbYRLVL)
        Me.Controls.Add(Me.cbSection)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtStudentName)
        Me.Controls.Add(btnSearch)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtStudentNum)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ITMAssessment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ITMAssessment"
        Me.GunaGroupBox2.ResumeLayout(False)
        Me.GunaGroupBox2.PerformLayout()
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbStudType As ComboBox
    Friend WithEvents cbCourse As ComboBox
    Private WithEvents cbYRLVL As ComboBox
    Friend WithEvents cbSection As ComboBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents SubjectCode As ColumnHeader
    Friend WithEvents SubjectName As ColumnHeader
    Friend WithEvents Units As ColumnHeader
    Friend WithEvents Schedule As ColumnHeader
    Friend WithEvents Label2 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtStudentName As TextBox
    Friend WithEvents btnPrint As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtStudentNum As TextBox
    Friend WithEvents GunaGroupBox2 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents lblFinal As Label
    Friend WithEvents lblPrefinal As Label
    Friend WithEvents lblMidterm As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents lblPrelim As Label
    Friend WithEvents lblUE As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents lblFull As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents txtDP As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lblLabF As Label
    Friend WithEvents lblIE As Label
    Friend WithEvents lblLF As Label
    Friend WithEvents lblMF As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblTF As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Private WithEvents cbDCType As ComboBox
    Private WithEvents cbDCPercent As ComboBox
End Class
