'Program name: Movie Selection Application
'Purpose: 
'By: Katelyn Cooper




<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Movie_Selection


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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Movie_Selection))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.lblTickets = New System.Windows.Forms.Label()
        Me.txtNumberofTickets = New System.Windows.Forms.TextBox()
        Me.lblTotalCost = New System.Windows.Forms.Label()
        Me.radForest = New System.Windows.Forms.RadioButton()
        Me.radAvengers = New System.Windows.Forms.RadioButton()
        Me.radTopGun = New System.Windows.Forms.RadioButton()
        Me.radMartian = New System.Windows.Forms.RadioButton()
        Me.radSpirit = New System.Windows.Forms.RadioButton()
        Me.radIncredible = New System.Windows.Forms.RadioButton()
        Me.radTurbo = New System.Windows.Forms.RadioButton()
        Me.radIndiana = New System.Windows.Forms.RadioButton()
        Me.radBattleship = New System.Windows.Forms.RadioButton()
        Me.radSpider = New System.Windows.Forms.RadioButton()
        Me.radPart1 = New System.Windows.Forms.RadioButton()
        Me.radPart2 = New System.Windows.Forms.RadioButton()
        Me.grpMovies = New System.Windows.Forms.GroupBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.grpMovies.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.BackColor = System.Drawing.Color.Transparent
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(269, 18)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(296, 39)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Movie Selections"
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.BackColor = System.Drawing.Color.Transparent
        Me.lblSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.Location = New System.Drawing.Point(120, 72)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(215, 25)
        Me.lblSelect.TabIndex = 1
        Me.lblSelect.Text = "Choose your Movie"
        '
        'lblTickets
        '
        Me.lblTickets.AutoSize = True
        Me.lblTickets.BackColor = System.Drawing.Color.Transparent
        Me.lblTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTickets.Location = New System.Drawing.Point(412, 72)
        Me.lblTickets.Name = "lblTickets"
        Me.lblTickets.Size = New System.Drawing.Size(216, 25)
        Me.lblTickets.TabIndex = 3
        Me.lblTickets.Text = "How many Tickets?"
        Me.lblTickets.Visible = False
        '
        'txtNumberofTickets
        '
        Me.txtNumberofTickets.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberofTickets.Location = New System.Drawing.Point(634, 66)
        Me.txtNumberofTickets.Name = "txtNumberofTickets"
        Me.txtNumberofTickets.Size = New System.Drawing.Size(74, 31)
        Me.txtNumberofTickets.TabIndex = 4
        Me.txtNumberofTickets.Visible = False
        '
        'lblTotalCost
        '
        Me.lblTotalCost.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCost.Location = New System.Drawing.Point(316, 246)
        Me.lblTotalCost.Name = "lblTotalCost"
        Me.lblTotalCost.Size = New System.Drawing.Size(194, 36)
        Me.lblTotalCost.TabIndex = 5
        Me.lblTotalCost.Text = "total cost of all the tickets"
        Me.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTotalCost.Visible = False
        '
        'radForest
        '
        Me.radForest.AutoSize = True
        Me.radForest.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radForest.Location = New System.Drawing.Point(19, 17)
        Me.radForest.Name = "radForest"
        Me.radForest.Size = New System.Drawing.Size(103, 20)
        Me.radForest.TabIndex = 6
        Me.radForest.Text = "Forest Gump"
        Me.radForest.UseVisualStyleBackColor = True
        '
        'radAvengers
        '
        Me.radAvengers.AutoSize = True
        Me.radAvengers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radAvengers.Location = New System.Drawing.Point(19, 50)
        Me.radAvengers.Name = "radAvengers"
        Me.radAvengers.Size = New System.Drawing.Size(111, 20)
        Me.radAvengers.TabIndex = 7
        Me.radAvengers.Text = "The Avengers"
        Me.radAvengers.UseVisualStyleBackColor = True
        '
        'radTopGun
        '
        Me.radTopGun.AutoSize = True
        Me.radTopGun.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radTopGun.Location = New System.Drawing.Point(19, 88)
        Me.radTopGun.Name = "radTopGun"
        Me.radTopGun.Size = New System.Drawing.Size(78, 20)
        Me.radTopGun.TabIndex = 8
        Me.radTopGun.Text = "Top Gun"
        Me.radTopGun.UseVisualStyleBackColor = True
        '
        'radMartian
        '
        Me.radMartian.AutoSize = True
        Me.radMartian.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMartian.Location = New System.Drawing.Point(153, 17)
        Me.radMartian.Name = "radMartian"
        Me.radMartian.Size = New System.Drawing.Size(97, 20)
        Me.radMartian.TabIndex = 9
        Me.radMartian.Text = "The Martian"
        Me.radMartian.UseVisualStyleBackColor = True
        '
        'radSpirit
        '
        Me.radSpirit.AutoSize = True
        Me.radSpirit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSpirit.Location = New System.Drawing.Point(153, 50)
        Me.radSpirit.Name = "radSpirit"
        Me.radSpirit.Size = New System.Drawing.Size(56, 20)
        Me.radSpirit.TabIndex = 10
        Me.radSpirit.Text = "Spirit"
        Me.radSpirit.UseVisualStyleBackColor = True
        '
        'radIncredible
        '
        Me.radIncredible.AutoSize = True
        Me.radIncredible.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radIncredible.Location = New System.Drawing.Point(153, 90)
        Me.radIncredible.Name = "radIncredible"
        Me.radIncredible.Size = New System.Drawing.Size(119, 20)
        Me.radIncredible.TabIndex = 11
        Me.radIncredible.Text = "The Incredibles"
        Me.radIncredible.UseVisualStyleBackColor = True
        '
        'radTurbo
        '
        Me.radTurbo.AutoSize = True
        Me.radTurbo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radTurbo.Location = New System.Drawing.Point(294, 17)
        Me.radTurbo.Name = "radTurbo"
        Me.radTurbo.Size = New System.Drawing.Size(62, 20)
        Me.radTurbo.TabIndex = 12
        Me.radTurbo.Text = "Turbo"
        Me.radTurbo.UseVisualStyleBackColor = True
        '
        'radIndiana
        '
        Me.radIndiana.AutoSize = True
        Me.radIndiana.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radIndiana.Location = New System.Drawing.Point(294, 50)
        Me.radIndiana.Name = "radIndiana"
        Me.radIndiana.Size = New System.Drawing.Size(110, 20)
        Me.radIndiana.TabIndex = 13
        Me.radIndiana.Text = "Indiana Jones"
        Me.radIndiana.UseVisualStyleBackColor = True
        '
        'radBattleship
        '
        Me.radBattleship.AutoSize = True
        Me.radBattleship.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radBattleship.Location = New System.Drawing.Point(294, 90)
        Me.radBattleship.Name = "radBattleship"
        Me.radBattleship.Size = New System.Drawing.Size(85, 20)
        Me.radBattleship.TabIndex = 14
        Me.radBattleship.Text = "Battleship"
        Me.radBattleship.UseVisualStyleBackColor = True
        '
        'radSpider
        '
        Me.radSpider.AutoSize = True
        Me.radSpider.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radSpider.Location = New System.Drawing.Point(427, 17)
        Me.radSpider.Name = "radSpider"
        Me.radSpider.Size = New System.Drawing.Size(96, 20)
        Me.radSpider.TabIndex = 15
        Me.radSpider.Text = "Spider-Man"
        Me.radSpider.UseVisualStyleBackColor = True
        '
        'radPart1
        '
        Me.radPart1.AutoSize = True
        Me.radPart1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPart1.Location = New System.Drawing.Point(427, 50)
        Me.radPart1.Name = "radPart1"
        Me.radPart1.Size = New System.Drawing.Size(134, 20)
        Me.radPart1.TabIndex = 16
        Me.radPart1.Text = "Harry Potter Part 1"
        Me.radPart1.UseVisualStyleBackColor = True
        '
        'radPart2
        '
        Me.radPart2.AutoSize = True
        Me.radPart2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radPart2.Location = New System.Drawing.Point(427, 88)
        Me.radPart2.Name = "radPart2"
        Me.radPart2.Size = New System.Drawing.Size(134, 20)
        Me.radPart2.TabIndex = 17
        Me.radPart2.Text = "Harry Potter Part 2"
        Me.radPart2.UseVisualStyleBackColor = True
        '
        'grpMovies
        '
        Me.grpMovies.BackColor = System.Drawing.Color.Transparent
        Me.grpMovies.Controls.Add(Me.radPart2)
        Me.grpMovies.Controls.Add(Me.radPart1)
        Me.grpMovies.Controls.Add(Me.radSpider)
        Me.grpMovies.Controls.Add(Me.radBattleship)
        Me.grpMovies.Controls.Add(Me.radIndiana)
        Me.grpMovies.Controls.Add(Me.radTurbo)
        Me.grpMovies.Controls.Add(Me.radIncredible)
        Me.grpMovies.Controls.Add(Me.radSpirit)
        Me.grpMovies.Controls.Add(Me.radMartian)
        Me.grpMovies.Controls.Add(Me.radTopGun)
        Me.grpMovies.Controls.Add(Me.radAvengers)
        Me.grpMovies.Controls.Add(Me.radForest)
        Me.grpMovies.Location = New System.Drawing.Point(123, 96)
        Me.grpMovies.Name = "grpMovies"
        Me.grpMovies.Size = New System.Drawing.Size(584, 118)
        Me.grpMovies.TabIndex = 20
        Me.grpMovies.TabStop = False
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(142, 242)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(150, 40)
        Me.btnCalculate.TabIndex = 21
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(534, 242)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(150, 40)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Movie_Selection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(834, 521)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpMovies)
        Me.Controls.Add(Me.lblTotalCost)
        Me.Controls.Add(Me.txtNumberofTickets)
        Me.Controls.Add(Me.lblTickets)
        Me.Controls.Add(Me.lblSelect)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "Movie_Selection"
        Me.Text = "Movie Theater"
        Me.grpMovies.ResumeLayout(False)
        Me.grpMovies.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblSelect As Label
    Friend WithEvents lblTickets As Label
    Friend WithEvents txtNumberofTickets As TextBox
    Friend WithEvents lblTotalCost As Label

    Private Sub Movie_Selection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'I could not open the coding window without all the above code presenting
        'I just wanted to let you know
        'I did once get it to not show, however it deleted my design window and I had to start over

        lblTotalCost.Text = ""
        lblTickets.Visible = True
        txtNumberofTickets.Visible = True
        btnClear.Visible = False

    End Sub

    Friend WithEvents radForest As RadioButton
    Friend WithEvents radAvengers As RadioButton
    Friend WithEvents radTopGun As RadioButton
    Friend WithEvents radMartian As RadioButton
    Friend WithEvents radSpirit As RadioButton
    Friend WithEvents radIncredible As RadioButton
    Friend WithEvents radTurbo As RadioButton
    Friend WithEvents radIndiana As RadioButton
    Friend WithEvents radBattleship As RadioButton
    Friend WithEvents radSpider As RadioButton
    Friend WithEvents radPart1 As RadioButton
    Friend WithEvents radPart2 As RadioButton
    Friend WithEvents grpMovies As GroupBox
    Friend WithEvents btnCalculate As Button

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intGroup As Integer = 0
        Dim blnIsValid As Boolean = False
        Dim decSenior As Decimal = 10D
        blnIsValid = False
        btnClear.Visible = True

        blnIsValid = ValidateInput()
        If blnIsValid = True Then
            intGroup = Convert.ToInt32(txtNumberofTickets.Text)
            intGroup = Calculates()
        End If
    End Sub

    Private Function Calculates() As Decimal
        Dim intGroup As Integer = 0
        Dim decCost As Decimal
        Dim decTotalcost As Integer
        Dim decGump As Decimal = 12D
        Dim decAvenge As Decimal = 15D
        Dim decTop As Decimal = 8D
        Dim decMartian As Decimal = 10D
        Dim decPartOne As Decimal = 15D
        Dim decSpirit As Decimal = 10D
        Dim decIncredible As Decimal = 8D
        Dim decTurboSpeed As Decimal = 12D
        Dim decJones As Decimal = 10D
        Dim decBattle As Decimal = 15D
        Dim decSpider As Decimal = 12D
        Dim decPartTwo As Decimal = 15D
        Dim decMax As Decimal = 100D
        Dim blnIsValid As Boolean = False


        'input assigned to variable
        intGroup = Convert.ToInt32(txtNumberofTickets.Text)

        If radForest.Checked Then
            decCost = decGump
        ElseIf radAvengers.Checked Then
            decCost = decAvenge
        ElseIf radTopGun.Checked Then
            decCost = decTop
        ElseIf radMartian.Checked Then
            decCost = decMartian
        ElseIf radSpirit.Checked Then
            decCost = decSpirit
        ElseIf radIncredible.Checked Then
            decCost = decIncredible
        ElseIf radTurbo.Checked Then
            decCost = decTurboSpeed
        ElseIf radIndiana.Checked Then
            decCost = decJones
        ElseIf radBattleship.Checked Then
            decCost = decBattle
        ElseIf radSpider.Checked Then
            decCost = decSpider
        ElseIf radPart1.Checked Then
            decCost = decPartOne
        ElseIf radPart2.Checked Then
            decCost = decPartTwo
        End If

        decTotalcost = (decCost * intGroup)
        lblTotalCost.Text = decTotalcost.ToString("C")
        lblTotalCost.Visible = True
        Return decTotalcost
    End Function
    Private Function ValidateInput() As Boolean
        'function validates input
        Dim intNumber As Integer
        Dim blnValid As Boolean = False
        Try
            'converts to integer value
            intNumber = Convert.ToInt32(txtNumberofTickets.Text)
            If intNumber > 0D Then
                blnValid = True
                Return blnValid
            Else
                MsgBox("Please enter a number greater than 0", , "Error")
                Return blnValid
            End If
        Catch Exception As FormatException
            'catch block detects letters, blank entries, etc.
            MsgBox("Please enter a valid amount", , "Error")
        Catch Exception As OverflowException
            'catch block detects number that are too small or large
            MsgBox("Please enter a reasonable amount", , "Error")
        Catch Exception As SystemException
            'catch block detects anything not caught by earlier catch blocks
            MsgBox("Invalid Entry. Please enter a valid number of tickets", , "Error")
        End Try
        'place focus back on textbox
        txtNumberofTickets.Focus()
        txtNumberofTickets.Clear()
        Return blnValid
    End Function

    Friend WithEvents btnClear As Button

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumberofTickets.Clear()
        txtNumberofTickets.Focus()
        lblTotalCost.Text = ""
        btnClear.Visible = False
        radForest.Checked = False
        radAvengers.Checked = False
        radTopGun.Checked = False
        radMartian.Checked = False
        radSpirit.Checked = False
        radIncredible.Checked = False
        radTurbo.Checked = False
        radIndiana.Checked = False
        radBattleship.Checked = False
        radSpider.Checked = False
        radPart1.Checked = False
        radPart2.Checked = False
    End Sub
End Class
