Imports System
Imports System.IO

Public Class Main_Home

    Public Sub Currency_Convertor()

    End Sub

    Private Sub Main_Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' This sets the values of the "Date Of Birth" field so that we ensure that only people of a certain age can use this form. This also keeps
        ' this also updates on a day to day basis.
        dtpDOB.Value = DateAdd(DateInterval.Year, -16, Today.Date)
        dtpDOB.MinDate = DateAdd(DateInterval.Year, -100, Today.Date)
        dtpDOB.MaxDate = DateAdd(DateInterval.Year, -16, Today.Date)

    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles AboutToolStripMenuItem.Click

        ' Shows the "About" Form as a DialogBox. (Meaning you can-not contine using the main form while the about form is still open)
        Main_About.ShowDialog()

    End Sub

    Public Sub btnConvert_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConvert.Click

        ' Currency Variable
        Dim exchangePoundEuro As Single = "1.18"
        Dim exchangeEuroPound As Single = "0.85"
        Dim exchangePoundDollar As Single = "1.6"
        Dim exchangeDollarPound As Single = "0.62"

        ' Companies Commision Value
        Dim commision As String = "5"
        Dim sum As String

        ' Input Variables For Conversion
        Dim inputAmount As Single

        ' Output Values
        Dim outputBasic As Single
        Dim outputCommission As Single
        Dim outputLoss As Single

        ' This "If" statment is checking whether if the "inputAmount" text box has nothing inside before peforming the calucuations.
        If txtInputAmount.Text = "" Then

            MsgBox("Please enter a value to contine!")

        Else

            inputAmount = txtInputAmount.Text

        End If

        ' Perform the calculations / Set Outputs
        If rbPoundEuro.Checked = True Then ' This checks if that the "Radio Button" has been checked.

            ' This is setting the "outputBasic" value to perform the calcuation of timesing the "inputAmount" by the exchange 
            ' value defined by the code.
            outputBasic = inputAmount * exchangePoundEuro
            ' This is setting the "sum" value to take the "inputAmount" and dividing by 100 and the timesing by the commission.
            sum = inputAmount / 100 * commision
            ' This is setting the "outputCommission" by taking the "inputAmount" and timesing by the exchange value and taking away 
            ' the "sum" value which is defined above.
            outputCommission = inputAmount * exchangePoundEuro - sum

            outputLoss = sum

            ' This is setting the string value of the text boxes to output the results of the calculations performed above.
            txtLoss.Text = Format("£" & outputLoss)
            txtOuputBeforeCommission.Text = Format("€" & outputBasic)
            txtOutputAfterCommission.Text = Format("€" & outputCommission)

            btnReset.Enabled = True
            btnSave.Enabled = True

        ElseIf rbEuroPound.Checked Then

            outputBasic = inputAmount * exchangeEuroPound
            sum = inputAmount / 100 * commision
            outputCommission = inputAmount * exchangeEuroPound - sum

            outputLoss = sum
            txtLoss.Text = Format("€" & outputLoss)
            txtOuputBeforeCommission.Text = Format("£" & outputBasic)
            txtOutputAfterCommission.Text = Format("£" & outputCommission)

            btnReset.Enabled = True
            btnSave.Enabled = True

        ElseIf rbPoundDollar.Checked Then

            outputBasic = inputAmount * exchangePoundDollar
            sum = inputAmount / 100 * commision
            outputCommission = inputAmount * exchangePoundDollar - sum

            outputLoss = sum
            txtLoss.Text = Format("£" & outputLoss)
            txtOuputBeforeCommission.Text = Format("$" & outputBasic)
            txtOutputAfterCommission.Text = Format("$" & outputCommission)

            btnReset.Enabled = True
            btnSave.Enabled = True

        ElseIf rbDollarPound.Checked Then

            outputBasic = inputAmount * exchangeDollarPound
            sum = inputAmount / 100 * commision
            outputCommission = inputAmount * exchangeDollarPound - sum

            outputLoss = sum
            txtLoss.Text = Format("$" & outputLoss)
            txtOuputBeforeCommission.Text = Format("£" & outputBasic)
            txtOutputAfterCommission.Text = Format("£" & outputCommission)

            btnReset.Enabled = True
            btnSave.Enabled = True

        End If

    End Sub

    ' This set of fuctions check, if the user is filling in the form then as doing it enables other fields so that the user can use the form. This
    ' also forces that the user must fill out the whole form to be able to use it to the full content.
    Private Sub cmbTitle_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbTitle.TextChanged

        If cmbTitle.Text <> "" Then

            txtuserFirstName.Enabled = True

        Else

            txtuserFirstName.Enabled = False

        End If

    End Sub

    Private Sub txtuserFirstName_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtuserFirstName.TextChanged

        If txtuserFirstName.Text <> "" Then

            txtuserSurname.Enabled = True

        Else

            txtuserSurname.Enabled = False

        End If

    End Sub

    Private Sub dtpDOB_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpDOB.GotFocus

        txtNIN.Enabled = True

    End Sub

    Private Sub txtuserSurname_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtuserSurname.TextChanged

        If txtuserSurname.Text <> "" Then

            dtpDOB.Enabled = True

        Else

            dtpDOB.Enabled = False

        End If

    End Sub

    Private Sub txtNIN_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtNIN.TextChanged

        If txtNIN.Text <> "" Then

            txtHouseNumber.Enabled = True

        Else

            txtHouseNumber.Enabled = False

        End If

    End Sub

    Private Sub txtHouseNumber_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtHouseNumber.TextChanged

        If txtHouseNumber.Text <> "" Then

            txtPostcode.Enabled = True

        Else

            txtPostcode.Enabled = False

        End If

    End Sub

    Private Sub txtPostcode_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtPostcode.TextChanged

        If txtPostcode.Text <> "" Then

            txtStreetName.Enabled = True

        Else

            txtStreetName.Enabled = False

        End If

    End Sub

    Private Sub txtStreetName_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtStreetName.TextChanged

        If txtStreetName.Text <> "" Then

            txtTownCity.Enabled = True

        Else

            txtTownCity.Enabled = False

        End If

    End Sub

    Private Sub txtTownCity_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtTownCity.TextChanged

        If txtTownCity.Text <> "" Then

            txtInputAmount.Enabled = True

            rbPoundEuro.Enabled = True
            rbEuroPound.Enabled = True
            rbPoundDollar.Enabled = True
            rbDollarPound.Enabled = True

        Else

            txtInputAmount.Enabled = False

            rbPoundEuro.Enabled = False
            rbEuroPound.Enabled = False
            rbPoundDollar.Enabled = False
            rbDollarPound.Enabled = False

        End If

    End Sub

    Private Sub txtInputAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInputAmount.TextChanged

        If txtInputAmount.Text <> "" Then

            cbDenominations.Enabled = True

        Else

            cbDenominations.Enabled = False

        End If

    End Sub

    Private Sub cbDenominations_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbDenominations.TextChanged

        If cbDenominations.Text <> "" Then

            btnConvert.Enabled = True

        Else

            btnConvert.Enabled = False

        End If

    End Sub ' End of check functions

    Private Sub Main_Home_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles MyBase.FormClosed

        If btnSave.Enabled = True And btnReset.Enabled = True Then

            Dim userResponse As Integer

            ' Displays a message box to ask the user if they want to save/export there results before closing.
            userResponse = MsgBox("Do you want to save your results before closing?", vbYesNo + vbQuestion + vbDefaultButton2, "Currency Converter - Close")

            If userResponse = vbNo Then

                ' If the user clicks "No" then the application closes.
                Application.Exit()

            ElseIf userResponse = vbYes Then

                ' If the user clicks "Yes" then the application exports the results and then closes the application.
                btnSave.PerformClick()
                Application.Exit()

            End If

        Else

            ' Close The Application
            Application.Exit()

        End If

    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click

        If btnSave.Enabled = True And btnReset.Enabled = True Then

            Dim userResponse As Integer

            ' Displays a message box to ask the user if they want to save/export there results before closing.
            userResponse = MsgBox("Do you want to save your results before closing?", vbYesNo + vbQuestion + vbDefaultButton2, "Currency Converter - Close")

            If userResponse = vbNo Then

                ' If the user clicks "No" then the application closes.
                Application.Exit()

            ElseIf userResponse = vbYes Then

                ' If the user clicks "Yes" then the application exports the results and then closes the application.
                btnSave.PerformClick()
                Application.Exit()

            End If

        Else

            ' Close The Application
            Application.Exit()

        End If

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        ' Restarts/Reloads the application to clear all the fields for a second use.
        Application.Restart()

    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click

        ' User Personsal Information (Input Value)
        Dim userTitle As String
        Dim userForename As String
        Dim userSurname As String
        Dim userDateOfBirth As Date
        Dim userNationalInsuranceNumber As String
        Dim userHouseNumber As String
        Dim userAddress As String
        Dim userPostcode As String
        Dim denominations As String
        Dim exportTime As String

        ' Setting Variables - This sets a value of each variable for calling at a later stage.
        userTitle = cmbTitle.Text
        userForename = txtuserFirstName.Text
        userSurname = txtuserSurname.Text
        userDateOfBirth = dtpDOB.Text
        userNationalInsuranceNumber = txtNIN.Text
        userHouseNumber = txtHouseNumber.Text
        userAddress = txtStreetName.Text & ", " & txtTownCity.Text
        userPostcode = txtPostcode.Text
        denominations = cbDenominations.Text
        exportTime = DateAndTime.Now.ToString("hh:mm dddd, dd MMMM yyyy")

        ' File Name For Exporting - This exports all the data to a text file which then opens up, this is so that the user can
        ' take away there results for further usage. (Output)
        Dim exportFileName As String = "Currency_Converter_Export.txt"

        If File.Exists(exportFileName) Then
            Using write As StreamWriter = File.CreateText(exportFileName)

                write.WriteLine("Date Generated: " & exportTime)
                write.WriteLine(vbCrLf)

                write.WriteLine("Title: " & userTitle)
                write.WriteLine("Forename: " & userForename)
                write.WriteLine("Surname: " & userSurname)
                write.WriteLine("Date Of Birth: " & userDateOfBirth)

                write.WriteLine("National Insurance Number: " & userNationalInsuranceNumber)
                write.WriteLine("House Number: " & userHouseNumber)
                write.WriteLine("Address: " & userAddress)
                write.WriteLine("Postcode: " & userPostcode)

                write.WriteLine("Total Money Before Exchange: " & txtOuputBeforeCommission.Text)
                write.WriteLine("Total After Exchange: " & txtOutputAfterCommission.Text)
                write.WriteLine("Total Commission Charge: " & txtLoss.Text)
                write.WriteLine("In Small Denominations? " & denominations)

                System.Diagnostics.Process.Start(exportFileName)

            End Using
        Else
            Using write As StreamWriter = File.CreateText(exportFileName)

                write.WriteLine("Date Generated: " & exportTime)
                write.WriteLine(vbCrLf)

                write.WriteLine("Title: " & userTitle)
                write.WriteLine("Forename: " & userForename)
                write.WriteLine("Surname: " & userSurname)
                write.WriteLine("Date Of Birth: " & userDateOfBirth)

                write.WriteLine("National Insurance Number: " & userNationalInsuranceNumber)
                write.WriteLine("House Number: " & userHouseNumber)
                write.WriteLine("Address: " & userAddress)
                write.WriteLine("Postcode: " & userPostcode)

                write.WriteLine("Total Money Before Exchange: " & txtOuputBeforeCommission.Text)
                write.WriteLine("Total After Exchange: " & txtOutputAfterCommission.Text)
                write.WriteLine("Total Commission Charge: " & txtLoss.Text)
                write.WriteLine("In Small Denominations? " & denominations)

                System.Diagnostics.Process.Start(exportFileName)

            End Using
        End If
    End Sub

End Class
