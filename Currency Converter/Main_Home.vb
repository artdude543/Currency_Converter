Imports System
Imports System.IO

Public Class Main_Home

    Public Sub Currency_Convertor()

    End Sub

    Public Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        ' Currency Variable
        Dim exchangePoundEuro As Single = "1.19"
        Dim exchangeEuroPound As Single = "0.84"
        Dim exchangePoundDollar As Single = "1.6"
        Dim exchangeDollarPound As Single = "0.62"

        ' Companies Commision Value
        Dim commision As String = 5
        Dim sum As String

        ' Input Variables For Conversion
        Dim inputAmount As Single

        ' Output Values
        Dim outputBasic As Single
        Dim outputCommission As Single
        Dim outputLoss As Single

        ' Set Variables

        If txtInputAmount.Text = "" Then
            MsgBox("Please enter a value to contine!")
        Else
            inputAmount = txtInputAmount.Text
        End If

        ' Perform the calculations / Set Outputs
        If rbPoundEuro.Checked = True Then

            outputBasic = inputAmount * exchangePoundEuro
            sum = inputAmount / 100 * commision
            outputCommission = inputAmount * exchangePoundEuro - sum

            outputLoss = sum
            txtLoss.Text = Format("£" & outputLoss)
            txtOuputBeforeCommission.Text = Format("€" & outputBasic)
            txtOutputAfterCommission.Text = Format("€" & outputCommission)

        ElseIf rbEuroPound.Checked Then

            outputBasic = inputAmount * exchangeEuroPound
            sum = inputAmount / 100 * commision
            outputCommission = inputAmount * exchangeEuroPound - sum

            outputLoss = sum
            txtLoss.Text = Format("€" & outputLoss)
            txtOuputBeforeCommission.Text = Format("£" & outputBasic)
            txtOutputAfterCommission.Text = Format("£" & outputCommission)

        ElseIf rbPoundDollar.Checked Then

            outputBasic = inputAmount * exchangePoundDollar
            sum = inputAmount / 100 * commision
            outputCommission = inputAmount * exchangePoundDollar - sum

            outputLoss = sum
            txtLoss.Text = Format("£" & outputLoss)
            txtOuputBeforeCommission.Text = Format("$" & outputBasic)
            txtOutputAfterCommission.Text = Format("$" & outputCommission)

        ElseIf rbDollarPound.Checked Then

            outputBasic = inputAmount * exchangeDollarPound
            sum = inputAmount / 100 * commision
            outputCommission = inputAmount * exchangeDollarPound - sum

            outputLoss = sum
            txtLoss.Text = Format("$" & outputLoss)
            txtOuputBeforeCommission.Text = Format("£" & outputBasic)
            txtOutputAfterCommission.Text = Format("£" & outputCommission)

        End If

    End Sub

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click

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

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        ' Restarts/Reloads the application to clear all the fields for a second use.
        Application.Restart()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

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

        ' File Name For Exporting - This exports all the data to a text file which then opens up, this is so that the user can
        ' take away there results for further usage. (Output)
        Dim exportFileName As String = "Currency_Converter_Export.txt"

        If File.Exists(exportFileName) Then
            Using write As StreamWriter = File.CreateText(exportFileName)
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
