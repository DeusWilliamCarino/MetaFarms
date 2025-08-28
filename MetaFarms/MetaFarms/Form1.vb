Public Class Form1
    Dim strQuery = ""
    Dim IDMarket As Integer
    Dim IDAnimal As Integer
    Dim IDFeed As Integer
    Dim IDAgeGroup As Integer
    Dim IDTransaction As Integer
    Dim IDGender As Integer


    Private Sub frmPet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dbConnection()
        strQuery = "SELECT t.transaction_id, t.buyer_name, t.sale_price, t.date_of_transaction, m.market_desc, a.animal_name from transaction t join route_to_market m on t.market_id=m.market_id join animal_type a on t.animal_id=a.animal_id"
        displayRecords(strQuery, DGMetaFarms)

        CBSelectInput.Items.Add("Transaction Info")
        CBSelectInput.Items.Add("Animal Type Info")
        CBSelectInput.Items.Add("Age Group Info")
        CBSelectInput.Items.Add("Feed Type Info")
        CBSelectInput.Items.Add("Gender Info")
        CBSelectInput.Items.Add("Route To Market Info")

        CBSelectOutput.Items.Add("Transaction List")
        CBSelectOutput.Items.Add("Animal Type List")
        CBSelectOutput.Items.Add("Age Group List")
        CBSelectOutput.Items.Add("Feed Type List")
        CBSelectOutput.Items.Add("Gender List")
        CBSelectOutput.Items.Add("Route to Market List")

        CBSelectInput.SelectedIndex = 0
        CBSelectOutput.SelectedIndex = 0
        BtnDelete.Enabled = False
        BtnUpdate.Enabled = False
    End Sub
    Private Sub CBSelectInput_IndexChange(sender As Object, e As EventArgs) Handles CBSelectInput.SelectedIndexChanged
        If CBSelectInput.Text = "Age Group Info" Then
            InputFeildShow(3)
            Clear()
        ElseIf CBSelectInput.Text = "Feed Type Info" Then
            InputFeildShow(2)
            Clear()
        ElseIf CBSelectInput.Text = "Gender Info" Then
            InputFeildShow(5)
            Clear()
        ElseIf CBSelectInput.Text = "Route To Market Info" Then
            InputFeildShow(4)
            Clear()
        ElseIf CBSelectInput.Text = "Transaction Info" Then
            InputFeildShow(0)
            Clear()
        ElseIf CBSelectInput.Text = "Animal Type Info" Then
            InputFeildShow(1)
            Clear()
        End If
    End Sub

    Private Sub CBSelectOutput_IndexChange(sender As Object, e As EventArgs) Handles CBSelectOutput.SelectedIndexChanged
        If CBSelectOutput.Text = "Feed Type List" Then
            strQuery = "SELECT f.feed_id, f.feed_name, a.age_desc from feed_type f join age_group a on f.age_id=a.age_id"
            displayRecords(strQuery, DGMetaFarms)
        ElseIf CBSelectOutput.Text = "Gender List" Then
            strQuery = "SELECT *from gender"
            displayRecords(strQuery, DGMetaFarms)
        ElseIf CBSelectOutput.Text = "Route to Market List" Then
            strQuery = "SELECT *from route_to_market"
            displayRecords(strQuery, DGMetaFarms)
        ElseIf CBSelectOutput.Text = "Transaction List" Then
            strQuery = "SELECT t.transaction_id, t.buyer_name, t.sale_price, t.date_of_transaction, m.market_desc, a.animal_name from transaction t join route_to_market m on t.market_id=m.market_id join animal_type a on t.animal_id=a.animal_id"
            displayRecords(strQuery, DGMetaFarms)
        ElseIf CBSelectOutput.Text = "Age Group List" Then
            strQuery = "SELECT *from age_group"
            displayRecords(strQuery, DGMetaFarms)
        ElseIf CBSelectOutput.Text = "Animal Type List" Then
            strQuery = "SELECT a.animal_id, a.animal_name, a.price, f.feed_name, g.gender_name from animal_type a join feed_type f on a.feed_id=f.feed_id join gender g on a.gender_id=g.gender_id"
            displayRecords(strQuery, DGMetaFarms)
        End If

    End Sub
    Private Sub InputFeildShow(ByVal val)
        If val = 0 Then
            Visibleall()
            DefaultLbl()
        ElseIf val = 1 Then
            Invisibleall()
            lblInformation1.Visible = True
            lblInformation2.Visible = True
            lblInformation3.Visible = True
            lblInformation4.Visible = True
            lblInformation5.Visible = True

            lblInformation1.Text = "Animal ID"
            lblInformation2.Text = "Animal Name"
            lblInformation3.Text = "Price"
            lblInformation4.Text = "Feed Name"
            lblInformation5.Text = "Gender"

            txtData1.Visible = True
            txtData2.Visible = True
            txtData3.Visible = True
            txtData4.Visible = True
            txtData5.Visible = True
        ElseIf val = 2 Then
            Invisibleall()
            lblInformation1.Visible = True
            lblInformation2.Visible = True
            lblInformation3.Visible = True

            lblInformation1.Text = "Feed ID"
            lblInformation2.Text = "Feed Name"
            lblInformation3.Text = "Age"

            txtData1.Visible = True
            txtData2.Visible = True
            txtData3.Visible = True
        ElseIf val = 3 Then
            Invisibleall()
            lblInformation1.Visible = True
            lblInformation2.Visible = True
            lblInformation3.Visible = True

            lblInformation1.Text = "Age ID"
            lblInformation2.Text = "Age_Desc"
            lblInformation3.Text = "Intake Levels"

            txtData1.Visible = True
            txtData2.Visible = True
            txtData3.Visible = True
        ElseIf val = 4 Then
            Invisibleall()
            lblInformation1.Visible = True
            lblInformation2.Visible = True

            lblInformation1.Text = "Market ID"
            lblInformation2.Text = "Market Desc"

            txtData1.Visible = True
            txtData2.Visible = True
        ElseIf val = 5 Then
            Invisibleall()
            lblInformation1.Visible = True
            lblInformation2.Visible = True

            lblInformation1.Text = "Gender ID"
            lblInformation2.Text = "Gender"

            txtData1.Visible = True
            txtData2.Visible = True
        End If

    End Sub


    Private Sub Invisibleall()

        lblInformation1.Visible = False
        lblInformation2.Visible = False
        lblInformation3.Visible = False
        lblInformation4.Visible = False
        lblInformation5.Visible = False
        lblInformation6.Visible = False

        txtData1.Visible = False
        txtData2.Visible = False
        txtData3.Visible = False
        txtData4.Visible = False
        txtData5.Visible = False
        txtData6.Visible = False

    End Sub
    Private Sub Visibleall()

        lblInformation1.Visible = True
        lblInformation2.Visible = True
        lblInformation3.Visible = True
        lblInformation4.Visible = True
        lblInformation5.Visible = True
        lblInformation6.Visible = True

        txtData1.Visible = True
        txtData2.Visible = True
        txtData3.Visible = True
        txtData4.Visible = True
        txtData5.Visible = True
        txtData6.Visible = True

    End Sub
    Private Sub DefaultLbl()
        lblInformation1.Text = "Transaction ID"
        lblInformation2.Text = "Buyer Name"
        lblInformation3.Text = "Sale Price"
        lblInformation4.Text = "Date of Transaction"
        lblInformation5.Text = "Market"
        lblInformation6.Text = "Animal ID"
    End Sub

    Private Sub Clear()
        txtData1.Clear()
        txtData2.Clear()
        txtData3.Clear()
        txtData4.Clear()
        txtData5.Clear()
        txtData6.Clear()
        
    End Sub



    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        If CBSelectInput.Text = "Age Group Info" Then
            strQuery = "Insert into age_group values(" & txtData1.Text & ",'" & txtData2.Text & "','" & txtData3.Text & "')"
            SQLManager(strQuery)
            strQuery = "SELECT *from age_group"
            displayRecords(strQuery, DGMetaFarms)
            Clear()
        ElseIf CBSelectInput.Text = "Feed Type Info" Then
            strQuery = "Select age_id from age_group where age_desc='" & txtData3.Text & "'"
            IDAgeGroup = IdSearch(strQuery)
            strQuery = "Insert into feed_type values(" & txtData1.Text & ",'" & txtData2.Text & "'," & IDAgeGroup & ")"
            SQLManager(strQuery)
            strQuery = "SELECT f.feed_id, f.feed_name, a.age_desc from feed_type f join age_group a on f.age_id=a.age_id"
            displayRecords(strQuery, DGMetaFarms)
            Clear()
        ElseIf CBSelectInput.Text = "Gender Info" Then
            strQuery = "Insert into gender values(" & txtData1.Text & ",'" & txtData2.Text & "')"
            SQLManager(strQuery)
            strQuery = "SELECT *from gender"
            displayRecords(strQuery, DGMetaFarms)
            Clear()
        ElseIf CBSelectInput.Text = "Route To Market Info" Then
            strQuery = "Insert into route_to_market values(" & txtData1.Text & ",'" & txtData2.Text & "')"
            SQLManager(strQuery)
            strQuery = "SELECT *from route_to_market"
            displayRecords(strQuery, DGMetaFarms)
            Clear()
        ElseIf CBSelectInput.Text = "Transaction Info" Then
            strQuery = "SELECT market_id from route_to_market where market_desc='" & txtData5.Text & "'"
            IDMarket = IdSearch(strQuery)
            strQuery = "SELECT animal_id from animal_type where animal_name='" & txtData6.Text & "'"
            IDAnimal = IdSearch(strQuery)
            strQuery = "Insert into transaction values(" & txtData1.Text & ",'" & txtData2.Text & "'," & txtData3.Text & ",'" & txtData4.Text & "'," & IDMarket & "," & IDAnimal & ")"
            SQLManager(strQuery)
            strQuery = "SELECT t.transaction_id, t.buyer_name, t.sale_price, t.date_of_transaction, m.market_desc, a.animal_name from transaction t join route_to_market m on t.market_id=m.market_id join animal_type a on t.animal_id=a.animal_id"
            displayRecords(strQuery, DGMetaFarms)
            Clear()
        ElseIf CBSelectInput.Text = "Animal Type Info" Then
            strQuery = "SELECT feed_id from feed_type where feed_name='" & txtData4.Text & "'"
            IDFeed = IdSearch(strQuery)
            strQuery = "SELECT gender_id from gender where Gender_name='" & txtData5.Text & "'"
            IDGender = IdSearch(strQuery)
            strQuery = "Insert into animal_type values(" & txtData1.Text & ",'" & txtData2.Text & "','" & txtData3.Text & "'," & IDFeed & "," & IDGender & ")"
            SQLManager(strQuery)
            strQuery = "SELECT a.animal_id, a.animal_name, a.price, f.feed_name, g.gender_name from animal_type a join feed_type f on a.feed_id=f.feed_id join gender g on a.gender_id=g.gender_id"
            displayRecords(strQuery, DGMetaFarms)
            Clear()
        End If
        
    End Sub


    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If CBSelectInput.Text = "Feed Type Info" Then
            strQuery = "Delete from feed_type where Feed_id=" & txtData1.Text & ""
            SQLManager(strQuery)
            strQuery = "SELECT f.feed_id, f.feed_name, a.age_desc from feed_type f join age_group a on f.age_id=a.age_id"
            displayRecords(strQuery, DGMetaFarms)
            Clear()
        ElseIf CBSelectInput.Text = "Gender Info" Then
            strQuery = "Delete from gender where gender_id=" & txtData1.Text & ""
            SQLManager(strQuery)
            strQuery = "SELECT *from gender"
            displayRecords(strQuery, DGMetaFarms)
            Clear()
        ElseIf CBSelectInput.Text = "Route to Market Info" Then
            strQuery = "Delete from route_to_market where market_id=" & txtData1.Text & ""
            SQLManager(strQuery)
            strQuery = "SELECT *from route_to_market"
            displayRecords(strQuery, DGMetaFarms)
            Clear()
        ElseIf CBSelectInput.Text = "Transaction Info" Then
            strQuery = "Delete from transaction where transaction_id=" & txtData1.Text & ""
            SQLManager(strQuery)
            strQuery = "SELECT t.transaction_id, t.buyer_name, t.sale_price, t.date_of_transaction, m.market_desc, a.animal_name from transaction t join route_to_market m on t.market_id=m.market_id join animal_type a on t.animal_id=a.animal_id"
            displayRecords(strQuery, DGMetaFarms)
            Clear()
        ElseIf CBSelectInput.Text = "Age Group Info" Then
            strQuery = "Delete from age_group where age_id=" & txtData1.Text & ""
            SQLManager(strQuery)
            strQuery = "SELECT *from age_group"
            displayRecords(strQuery, DGMetaFarms)
            Clear()
        ElseIf CBSelectInput.Text = "Animal Type Info" Then
            strQuery = "Delete from animal_type where animal_id=" & txtData1.Text & ""
            SQLManager(strQuery)
            strQuery = "SELECT a.animal_id, a.animal_name, a.price, f.feed_name, g.gender_name from animal_type a join feed_type f on a.feed_id=f.feed_id join gender g on a.gender_id=g.gender_id"
            displayRecords(strQuery, DGMetaFarms)
            Clear()
        End If
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If CBSelectInput.Text = "Gender Info" Then
            strQuery = "Update gender set gender_name='" & txtData2.Text & "' where gender_id=" & txtData1.Text & ""
            SQLManager(strQuery)
            strQuery = "SELECT *from gender"
            displayRecords(strQuery, DGMetaFarms)
            Clear()
        ElseIf CBSelectInput.Text = "Route To Market Info" Then
            strQuery = "update route_to_market set market_desc='" & txtData2.Text & "'where market_id=" & txtData1.Text & ""
            SQLManager(strQuery)
            strQuery = "SELECT *from route_to_market"
            displayRecords(strQuery, DGMetaFarms)
        ElseIf CBSelectInput.Text = "Age Group Info" Then
            strQuery = "update age_group set age_desc='" & txtData2.Text & "', intake_levels='" & txtData3.Text & "' where age_id=" & txtData1.Text & ""
            SQLManager(strQuery)
            strQuery = "SELECT *from age_group"
            displayRecords(strQuery, DGMetaFarms)
            Clear()
        ElseIf CBSelectInput.Text = "Animal Type Info" Then
            strQuery = "SELECT feed_id from feed_type where feed_name='" & txtData4.Text & "'"
            IDFeed = IdSearch(strQuery)
            strQuery = "SELECT gender_id from gender where Gender_name='" & txtData5.Text & "'"
            IDGender = IdSearch(strQuery)
            strQuery = "update animal_type set animal_name='" & txtData2.Text & "', price='" & txtData3.Text & "', feed_id=" & IDFeed & ", gender_id=" & IDGender & " where animal_id=" & txtData1.Text & ""
            SQLManager(strQuery)
            strQuery = "SELECT a.animal_id, a.animal_name, a.price, f.feed_name, g.gender_name from animal_type a join feed_type f on a.feed_id=f.feed_id join gender g on a.gender_id=g.gender_id"
            displayRecords(strQuery, DGMetaFarms)
            Clear()
        ElseIf CBSelectInput.Text = "Feed Type Info" Then
            strQuery = "Select age_id from age_group where age_desc='" & txtData3.Text & "'"
            IDAgeGroup = IdSearch(strQuery)
            strQuery = "update feed_type set feed_name='" & txtData2.Text & "', age_id=" & IDAgeGroup & " where feed_id=" & txtData1.Text & ""
            SQLManager(strQuery)
            strQuery = "SELECT f.feed_id, f.feed_name, a.age_desc from feed_type f join age_group a on f.age_id=a.age_id"
            displayRecords(strQuery, DGMetaFarms)
            Clear()
        ElseIf CBSelectInput.Text = "Transaction Info" Then
            strQuery = "SELECT market_id from route_to_market where market_desc='" & txtData5.Text & "'"
            IDMarket = IdSearch(strQuery)
            strQuery = "SELECT animal_id from animal_type where animal_name='" & txtData6.Text & "'"
            IDAnimal = IdSearch(strQuery)
            strQuery = "update transaction set buyer_name='" & txtData2.Text & "', sale_price=" & txtData3.Text & ", date_of_transaction='" & txtData4.Text & "', market_id=" & IDMarket & ", animal_id=" & IDAnimal & " where transaction_id=" & txtData1.Text & ""
            SQLManager(strQuery)
            strQuery = "SELECT t.transaction_id, t.buyer_name, t.sale_price, t.date_of_transaction, m.market_desc, a.animal_name from transaction t join route_to_market m on t.market_id=m.market_id join animal_type a on t.animal_id=a.animal_id"
            displayRecords(strQuery, DGMetaFarms)
            Clear()
        End If
    End Sub


    Private Sub ChckBDelete_CheckedChanged(sender As Object, e As EventArgs) Handles ChckBDelete.CheckedChanged
        If ChckBDelete.CheckState = CheckState.Unchecked Then

            txtData2.Enabled = True
            txtData3.Enabled = True
            txtData4.Enabled = True
            txtData5.Enabled = True
            txtData6.Enabled = True

            BtnAdd.Enabled = True
            BtnDelete.Enabled = False
            ChckBUpdate.Enabled = True
        ElseIf ChckBDelete.CheckState = CheckState.Checked Then

            txtData2.Enabled = False
            txtData3.Enabled = False
            txtData4.Enabled = False
            txtData5.Enabled = False
            txtData6.Enabled = False

            BtnAdd.Enabled = False
            ChckBUpdate.Enabled = False
            BtnDelete.Enabled = True
        End If

    End Sub

    Private Sub ChckBUpdate_CheckedChanged(sender As Object, e As EventArgs) Handles ChckBUpdate.CheckedChanged
        If ChckBUpdate.CheckState = CheckState.Checked Then
            BtnAdd.Enabled = False
            ChckBDelete.Enabled = False
            BtnUpdate.Enabled = True
        ElseIf ChckBUpdate.CheckState = CheckState.Unchecked Then
            BtnAdd.Enabled = True
            ChckBDelete.Enabled = True
            BtnUpdate.Enabled = False
        End If
    End Sub

  
End Class

