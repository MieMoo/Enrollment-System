<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ITMEnrollment
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim btnSearch As System.Windows.Forms.Button
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ITMEnrollment))
        Dim cbSubjectsS As System.Windows.Forms.ComboBox
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.cbSemester = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbCourse = New System.Windows.Forms.ComboBox()
        Me.cbYRMod = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStudNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLN = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFN = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtMN = New System.Windows.Forms.TextBox()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Guna2DataGridView4 = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Hours = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.btnPrintForm = New Guna.UI2.WinForms.Guna2Button()
        Me.btnEnroll = New Guna.UI2.WinForms.Guna2Button()
        Me.txtEName = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.cbDCType = New System.Windows.Forms.ComboBox()
        Me.cbDCPercent = New System.Windows.Forms.ComboBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblLabF = New System.Windows.Forms.Label()
        Me.lblIE = New System.Windows.Forms.Label()
        Me.lblLF = New System.Windows.Forms.Label()
        Me.lblMF = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblTF = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        btnSearch = New System.Windows.Forms.Button()
        cbSubjectsS = New System.Windows.Forms.ComboBox()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.Guna2DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        btnSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(248, Byte), Integer))
        btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        btnSearch.Cursor = System.Windows.Forms.Cursors.Hand
        btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(248, Byte), Integer))
        btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        btnSearch.Location = New System.Drawing.Point(266, 164)
        btnSearch.Margin = New System.Windows.Forms.Padding(4)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New System.Drawing.Size(52, 32)
        btnSearch.TabIndex = 233
        btnSearch.UseVisualStyleBackColor = False
        '
        'cbSubjectsS
        '
        cbSubjectsS.Enabled = False
        cbSubjectsS.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        cbSubjectsS.Items.AddRange(New Object() {"2023-2024"})
        cbSubjectsS.Location = New System.Drawing.Point(48, 64)
        cbSubjectsS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        cbSubjectsS.Name = "cbSubjectsS"
        cbSubjectsS.Size = New System.Drawing.Size(270, 35)
        cbSubjectsS.TabIndex = 178
        cbSubjectsS.Text = "               2023-2024"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(107, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.Guna2Panel1.BorderRadius = 5
        Me.Guna2Panel1.BorderThickness = 3
        Me.Guna2Panel1.Controls.Add(Me.cbSemester)
        Me.Guna2Panel1.Controls.Add(Me.Label9)
        Me.Guna2Panel1.Controls.Add(Me.Label3)
        Me.Guna2Panel1.Controls.Add(Me.cbCourse)
        Me.Guna2Panel1.Controls.Add(Me.cbYRMod)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.Label2)
        Me.Guna2Panel1.Location = New System.Drawing.Point(342, 12)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.Size = New System.Drawing.Size(346, 246)
        Me.Guna2Panel1.TabIndex = 20
        '
        'cbSemester
        '
        Me.cbSemester.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSemester.FormattingEnabled = True
        Me.cbSemester.Items.AddRange(New Object() {"1st Semester", "2nd Semester"})
        Me.cbSemester.Location = New System.Drawing.Point(151, 186)
        Me.cbSemester.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbSemester.Name = "cbSemester"
        Me.cbSemester.Size = New System.Drawing.Size(154, 28)
        Me.cbSemester.TabIndex = 254
        Me.cbSemester.Text = "1st Semester"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(37, 186)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 20)
        Me.Label9.TabIndex = 253
        Me.Label9.Text = "Semester"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(37, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 20)
        Me.Label3.TabIndex = 252
        Me.Label3.Text = "Course"
        '
        'cbCourse
        '
        Me.cbCourse.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCourse.FormattingEnabled = True
        Me.cbCourse.Items.AddRange(New Object() {"BSIT", "BSCS"})
        Me.cbCourse.Location = New System.Drawing.Point(151, 138)
        Me.cbCourse.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbCourse.Name = "cbCourse"
        Me.cbCourse.Size = New System.Drawing.Size(154, 28)
        Me.cbCourse.TabIndex = 251
        Me.cbCourse.Text = "BSIT"
        '
        'cbYRMod
        '
        Me.cbYRMod.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbYRMod.Items.AddRange(New Object() {"1st Year", "2nd Year", "3rd Year", "4th Year"})
        Me.cbYRMod.Location = New System.Drawing.Point(151, 87)
        Me.cbYRMod.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbYRMod.Name = "cbYRMod"
        Me.cbYRMod.Size = New System.Drawing.Size(154, 28)
        Me.cbYRMod.TabIndex = 250
        Me.cbYRMod.Text = "1st Year"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(19, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Academic Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Malgun Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(37, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Year Level"
        '
        'txtStudNo
        '
        Me.txtStudNo.BackColor = System.Drawing.Color.White
        Me.txtStudNo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStudNo.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudNo.ForeColor = System.Drawing.Color.Black
        Me.txtStudNo.Location = New System.Drawing.Point(48, 164)
        Me.txtStudNo.Margin = New System.Windows.Forms.Padding(8)
        Me.txtStudNo.MaxLength = 5
        Me.txtStudNo.Name = "txtStudNo"
        Me.txtStudNo.Size = New System.Drawing.Size(206, 32)
        Me.txtStudNo.TabIndex = 231
        Me.txtStudNo.Tag = ""
        Me.txtStudNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Malgun Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(101, 336)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 25)
        Me.Label4.TabIndex = 235
        Me.Label4.Text = "Last Name"
        '
        'txtLN
        '
        Me.txtLN.BackColor = System.Drawing.Color.White
        Me.txtLN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLN.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLN.ForeColor = System.Drawing.Color.Black
        Me.txtLN.Location = New System.Drawing.Point(49, 296)
        Me.txtLN.Margin = New System.Windows.Forms.Padding(8)
        Me.txtLN.MaxLength = 30
        Me.txtLN.Name = "txtLN"
        Me.txtLN.Size = New System.Drawing.Size(206, 32)
        Me.txtLN.TabIndex = 234
        Me.txtLN.Tag = ""
        Me.txtLN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Malgun Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label16.Location = New System.Drawing.Point(17, 244)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(172, 31)
        Me.Label16.TabIndex = 236
        Me.Label16.Text = "Student Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Malgun Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label5.Location = New System.Drawing.Point(17, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 31)
        Me.Label5.TabIndex = 237
        Me.Label5.Text = "Student No."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Malgun Gothic", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Location = New System.Drawing.Point(17, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 31)
        Me.Label6.TabIndex = 238
        Me.Label6.Text = "Academic Year"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Malgun Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Silver
        Me.Label7.Location = New System.Drawing.Point(318, 336)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 25)
        Me.Label7.TabIndex = 240
        Me.Label7.Text = "First Name"
        '
        'txtFN
        '
        Me.txtFN.BackColor = System.Drawing.Color.White
        Me.txtFN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFN.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFN.ForeColor = System.Drawing.Color.Black
        Me.txtFN.Location = New System.Drawing.Point(266, 296)
        Me.txtFN.Margin = New System.Windows.Forms.Padding(8)
        Me.txtFN.MaxLength = 35
        Me.txtFN.Name = "txtFN"
        Me.txtFN.Size = New System.Drawing.Size(206, 32)
        Me.txtFN.TabIndex = 239
        Me.txtFN.Tag = ""
        Me.txtFN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Malgun Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Silver
        Me.Label8.Location = New System.Drawing.Point(520, 336)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 25)
        Me.Label8.TabIndex = 242
        Me.Label8.Text = "Middle Name"
        '
        'txtMN
        '
        Me.txtMN.BackColor = System.Drawing.Color.White
        Me.txtMN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMN.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMN.ForeColor = System.Drawing.Color.Black
        Me.txtMN.Location = New System.Drawing.Point(482, 296)
        Me.txtMN.Margin = New System.Windows.Forms.Padding(8)
        Me.txtMN.MaxLength = 20
        Me.txtMN.Name = "txtMN"
        Me.txtMN.Size = New System.Drawing.Size(206, 32)
        Me.txtMN.TabIndex = 241
        Me.txtMN.Tag = ""
        Me.txtMN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Guna2Panel2.Controls.Add(Me.Label10)
        Me.Guna2Panel2.Location = New System.Drawing.Point(-3, 392)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(1249, 26)
        Me.Guna2Panel2.TabIndex = 243
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(514, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(267, 23)
        Me.Label10.TabIndex = 244
        Me.Label10.Text = "Academic Year 2023-2024"
        '
        'Guna2DataGridView4
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView4.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Guna2DataGridView4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Guna2DataGridView4.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Guna2DataGridView4.ColumnHeadersHeight = 20
        Me.Guna2DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.Status, Me.LC, Me.Hours, Me.fee, Me.Total})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Guna2DataGridView4.DefaultCellStyle = DataGridViewCellStyle3
        Me.Guna2DataGridView4.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView4.Location = New System.Drawing.Point(-3, 438)
        Me.Guna2DataGridView4.Name = "Guna2DataGridView4"
        Me.Guna2DataGridView4.RowHeadersVisible = False
        Me.Guna2DataGridView4.RowHeadersWidth = 30
        Me.Guna2DataGridView4.RowTemplate.Height = 24
        Me.Guna2DataGridView4.Size = New System.Drawing.Size(1235, 288)
        Me.Guna2DataGridView4.TabIndex = 244
        Me.Guna2DataGridView4.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView4.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Guna2DataGridView4.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView4.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView4.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Guna2DataGridView4.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView4.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView4.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView4.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Guna2DataGridView4.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView4.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Guna2DataGridView4.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.Guna2DataGridView4.ThemeStyle.HeaderStyle.Height = 20
        Me.Guna2DataGridView4.ThemeStyle.ReadOnly = False
        Me.Guna2DataGridView4.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Guna2DataGridView4.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Guna2DataGridView4.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2DataGridView4.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Guna2DataGridView4.ThemeStyle.RowsStyle.Height = 24
        Me.Guna2DataGridView4.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2DataGridView4.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "Subject Code"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.HeaderText = "Subject Title"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.HeaderText = "Day"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.HeaderText = "Time"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'Status
        '
        Me.Status.HeaderText = "Teacher"
        Me.Status.MinimumWidth = 6
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'LC
        '
        Me.LC.HeaderText = "LC"
        Me.LC.MinimumWidth = 6
        Me.LC.Name = "LC"
        Me.LC.ReadOnly = True
        '
        'Hours
        '
        Me.Hours.HeaderText = "HRS"
        Me.Hours.MinimumWidth = 6
        Me.Hours.Name = "Hours"
        Me.Hours.ReadOnly = True
        '
        'fee
        '
        Me.fee.HeaderText = "Fee"
        Me.fee.MinimumWidth = 6
        Me.fee.Name = "fee"
        Me.fee.ReadOnly = True
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.MinimumWidth = 6
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Malgun Gothic", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Silver
        Me.Label11.Location = New System.Drawing.Point(510, 794)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 25)
        Me.Label11.TabIndex = 246
        Me.Label11.Text = "Units"
        '
        'txtUnits
        '
        Me.txtUnits.BackColor = System.Drawing.Color.White
        Me.txtUnits.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUnits.Font = New System.Drawing.Font("Palatino Linotype", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnits.ForeColor = System.Drawing.Color.Black
        Me.txtUnits.Location = New System.Drawing.Point(578, 791)
        Me.txtUnits.Margin = New System.Windows.Forms.Padding(8)
        Me.txtUnits.MaxLength = 2
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(87, 32)
        Me.txtUnits.TabIndex = 245
        Me.txtUnits.Tag = ""
        Me.txtUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnPrintForm
        '
        Me.btnPrintForm.BorderRadius = 15
        Me.btnPrintForm.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPrintForm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPrintForm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPrintForm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPrintForm.FillColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnPrintForm.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintForm.ForeColor = System.Drawing.Color.Black
        Me.btnPrintForm.Location = New System.Drawing.Point(994, 779)
        Me.btnPrintForm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPrintForm.Name = "btnPrintForm"
        Me.btnPrintForm.Size = New System.Drawing.Size(221, 60)
        Me.btnPrintForm.TabIndex = 248
        Me.btnPrintForm.Text = "PRINT FORM"
        '
        'btnEnroll
        '
        Me.btnEnroll.BorderRadius = 15
        Me.btnEnroll.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEnroll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEnroll.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEnroll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEnroll.FillColor = System.Drawing.Color.FromArgb(CType(CType(116, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnEnroll.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnroll.ForeColor = System.Drawing.Color.Black
        Me.btnEnroll.Location = New System.Drawing.Point(745, 779)
        Me.btnEnroll.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEnroll.Name = "btnEnroll"
        Me.btnEnroll.Size = New System.Drawing.Size(232, 60)
        Me.btnEnroll.TabIndex = 247
        Me.btnEnroll.Text = "ENROLL STUDENT"
        '
        'txtEName
        '
        Me.txtEName.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.txtEName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEName.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEName.ForeColor = System.Drawing.Color.White
        Me.txtEName.LineColor = System.Drawing.Color.IndianRed
        Me.txtEName.LineSize = 2
        Me.txtEName.Location = New System.Drawing.Point(50, 785)
        Me.txtEName.MaxLength = 50
        Me.txtEName.Name = "txtEName"
        Me.txtEName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEName.SelectedText = ""
        Me.txtEName.Size = New System.Drawing.Size(217, 37)
        Me.txtEName.TabIndex = 250
        Me.txtEName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Palatino Linotype", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(66, 825)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(169, 24)
        Me.Label12.TabIndex = 249
        Me.Label12.Text = "Enrollment Officer"
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GunaGroupBox1.BorderSize = 2
        Me.GunaGroupBox1.Controls.Add(Me.cbDCType)
        Me.GunaGroupBox1.Controls.Add(Me.cbDCPercent)
        Me.GunaGroupBox1.Controls.Add(Me.lblTotal)
        Me.GunaGroupBox1.Controls.Add(Me.Label18)
        Me.GunaGroupBox1.Controls.Add(Me.lblLabF)
        Me.GunaGroupBox1.Controls.Add(Me.lblIE)
        Me.GunaGroupBox1.Controls.Add(Me.lblLF)
        Me.GunaGroupBox1.Controls.Add(Me.lblMF)
        Me.GunaGroupBox1.Controls.Add(Me.Label17)
        Me.GunaGroupBox1.Controls.Add(Me.Label13)
        Me.GunaGroupBox1.Controls.Add(Me.Label14)
        Me.GunaGroupBox1.Controls.Add(Me.Label15)
        Me.GunaGroupBox1.Controls.Add(Me.Label19)
        Me.GunaGroupBox1.Controls.Add(Me.lblTF)
        Me.GunaGroupBox1.Controls.Add(Me.Label20)
        Me.GunaGroupBox1.Controls.Add(Me.Label21)
        Me.GunaGroupBox1.Font = New System.Drawing.Font("Malgun Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox1.ForeColor = System.Drawing.Color.White
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(236, Byte), Integer))
        Me.GunaGroupBox1.Location = New System.Drawing.Point(708, 21)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(494, 335)
        Me.GunaGroupBox1.TabIndex = 251
        Me.GunaGroupBox1.Text = "Assessment"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'cbDCType
        '
        Me.cbDCType.Font = New System.Drawing.Font("Malgun Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDCType.Items.AddRange(New Object() {"Admission", "ROTC", "Athlete", "Government"})
        Me.cbDCType.Location = New System.Drawing.Point(132, 272)
        Me.cbDCType.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbDCType.Name = "cbDCType"
        Me.cbDCType.Size = New System.Drawing.Size(137, 31)
        Me.cbDCType.TabIndex = 218
        Me.cbDCType.Text = "Admission"
        '
        'cbDCPercent
        '
        Me.cbDCPercent.Font = New System.Drawing.Font("Malgun Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDCPercent.Items.AddRange(New Object() {"30%", "40%", "50%", "60%", "85%", "100%"})
        Me.cbDCPercent.Location = New System.Drawing.Point(286, 272)
        Me.cbDCPercent.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cbDCPercent.Name = "cbDCPercent"
        Me.cbDCPercent.Size = New System.Drawing.Size(95, 31)
        Me.cbDCPercent.TabIndex = 217
        Me.cbDCPercent.Text = "30%"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Malgun Gothic", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.White
        Me.lblTotal.Location = New System.Drawing.Point(351, 152)
        Me.lblTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(90, 50)
        Me.lblTotal.TabIndex = 61
        Me.lblTotal.Text = "0.00"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Malgun Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(316, 119)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(153, 23)
        Me.Label18.TabIndex = 60
        Me.Label18.Text = "Total Assessment"
        '
        'lblLabF
        '
        Me.lblLabF.AutoSize = True
        Me.lblLabF.Font = New System.Drawing.Font("Malgun Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLabF.ForeColor = System.Drawing.Color.White
        Me.lblLabF.Location = New System.Drawing.Point(255, 223)
        Me.lblLabF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLabF.Name = "lblLabF"
        Me.lblLabF.Size = New System.Drawing.Size(41, 23)
        Me.lblLabF.TabIndex = 57
        Me.lblLabF.Text = "0.00"
        '
        'lblIE
        '
        Me.lblIE.AutoSize = True
        Me.lblIE.Font = New System.Drawing.Font("Malgun Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIE.ForeColor = System.Drawing.Color.White
        Me.lblIE.Location = New System.Drawing.Point(255, 186)
        Me.lblIE.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIE.Name = "lblIE"
        Me.lblIE.Size = New System.Drawing.Size(41, 23)
        Me.lblIE.TabIndex = 56
        Me.lblIE.Text = "0.00"
        '
        'lblLF
        '
        Me.lblLF.AutoSize = True
        Me.lblLF.Font = New System.Drawing.Font("Malgun Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLF.ForeColor = System.Drawing.Color.White
        Me.lblLF.Location = New System.Drawing.Point(255, 119)
        Me.lblLF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLF.Name = "lblLF"
        Me.lblLF.Size = New System.Drawing.Size(41, 23)
        Me.lblLF.TabIndex = 55
        Me.lblLF.Text = "0.00"
        '
        'lblMF
        '
        Me.lblMF.AutoSize = True
        Me.lblMF.Font = New System.Drawing.Font("Malgun Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMF.ForeColor = System.Drawing.Color.White
        Me.lblMF.Location = New System.Drawing.Point(255, 82)
        Me.lblMF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMF.Name = "lblMF"
        Me.lblMF.Size = New System.Drawing.Size(41, 23)
        Me.lblMF.TabIndex = 54
        Me.lblMF.Text = "0.00"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Malgun Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(27, 275)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(81, 23)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "Discount:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Malgun Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(16, 82)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(81, 23)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Misc Fee:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Malgun Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(27, 223)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 23)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "Lab Fee:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Malgun Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(27, 191)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(131, 23)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "Installment Fee:"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Malgun Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(16, 45)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(99, 23)
        Me.Label19.TabIndex = 46
        Me.Label19.Text = "Tuition Fee:"
        '
        'lblTF
        '
        Me.lblTF.AutoSize = True
        Me.lblTF.Font = New System.Drawing.Font("Malgun Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTF.ForeColor = System.Drawing.Color.White
        Me.lblTF.Location = New System.Drawing.Point(255, 45)
        Me.lblTF.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTF.Name = "lblTF"
        Me.lblTF.Size = New System.Drawing.Size(41, 23)
        Me.lblTF.TabIndex = 50
        Me.lblTF.Text = "0.00"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Malgun Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(16, 119)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(128, 23)
        Me.Label20.TabIndex = 48
        Me.Label20.Text = "Laboratory Fee:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Malgun Gothic", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(16, 155)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(93, 23)
        Me.Label21.TabIndex = 49
        Me.Label21.Text = "Other Fee:"
        '
        'ITMEnrollment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(29, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1258, 875)
        Me.Controls.Add(Me.GunaGroupBox1)
        Me.Controls.Add(Me.txtEName)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnPrintForm)
        Me.Controls.Add(Me.btnEnroll)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtUnits)
        Me.Controls.Add(Me.Guna2DataGridView4)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtMN)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtFN)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLN)
        Me.Controls.Add(btnSearch)
        Me.Controls.Add(Me.txtStudNo)
        Me.Controls.Add(cbSubjectsS)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ITMEnrollment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ITMEnrollment"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.Guna2DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtStudNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLN As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtFN As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtMN As TextBox
    Friend WithEvents cbSemester As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cbCourse As ComboBox
    Private WithEvents cbYRMod As ComboBox
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents Guna2DataGridView4 As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents LC As DataGridViewTextBoxColumn
    Friend WithEvents Hours As DataGridViewTextBoxColumn
    Friend WithEvents fee As DataGridViewTextBoxColumn
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents Label11 As Label
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents btnPrintForm As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEnroll As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtEName As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Private WithEvents cbDCType As ComboBox
    Private WithEvents cbDCPercent As ComboBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lblLabF As Label
    Friend WithEvents lblIE As Label
    Friend WithEvents lblLF As Label
    Friend WithEvents lblMF As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents lblTF As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
End Class
