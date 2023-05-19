Public Class Form1
    Private Sub BooksBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LibraryDataSet.members' table. You can move, or remove it, as needed.
        Me.MembersTableAdapter.Fill(Me.LibraryDataSet.members)
        'TODO: This line of code loads data into the 'LibraryDataSet.publishers' table. You can move, or remove it, as needed.
        Me.PublishersTableAdapter.Fill(Me.LibraryDataSet.publishers)
        'TODO: This line of code loads data into the 'LibraryDataSet.librarians' table. You can move, or remove it, as needed.
        Me.LibrariansTableAdapter.Fill(Me.LibraryDataSet.librarians)
        'TODO: This line of code loads data into the 'LibraryDataSet.issues' table. You can move, or remove it, as needed.
        Me.IssuesTableAdapter.Fill(Me.LibraryDataSet.issues)
        'TODO: This line of code loads data into the 'LibraryDataSet.books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.LibraryDataSet.books)

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Me.Validate()
        Me.BooksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LibraryDataSet)
        MessageBox.Show("Saved Data!")
    End Sub

    Private Sub button2_Click(sender As Object, e As EventArgs) Handles button2.Click
        For Each _control As Control In Me.Controls
            If TypeOf (_control) Is TextBox Then
                _control.Text = String.Empty
            End If
        Next
        MessageBox.Show("Cleared all Search Fields!")
    End Sub
    'SEARCH FIELDS'
    Private Sub book1_TextChanged(sender As Object, e As EventArgs) Handles book1.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = BooksDataGridView.DataSource
        bs.Filter = "Convert(BookID, 'System.String') LIKE '" & book1.Text & "%'"
        BooksDataGridView.DataSource = bs
    End Sub

    Private Sub book2_TextChanged(sender As Object, e As EventArgs) Handles book2.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = BooksDataGridView.DataSource
        bs.Filter = "Convert(ISBN, 'System.String') LIKE '" & book2.Text & "%'"
        BooksDataGridView.DataSource = bs
    End Sub

    Private Sub book3_TextChanged(sender As Object, e As EventArgs) Handles book3.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = BooksDataGridView.DataSource
        bs.Filter = "BookTitle like '%" & book3.Text & "%'"
        BooksDataGridView.DataSource = bs
    End Sub

    Private Sub book4_TextChanged(sender As Object, e As EventArgs) Handles book4.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = BooksDataGridView.DataSource
        bs.Filter = "BookAuthor like '%" & book4.Text & "%'"
        BooksDataGridView.DataSource = bs
    End Sub

    Private Sub book5_TextChanged(sender As Object, e As EventArgs) Handles book5.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = BooksDataGridView.DataSource
        bs.Filter = "PublisherName like '%" & book5.Text & "%'"
        BooksDataGridView.DataSource = bs
    End Sub

    Private Sub librarian1_TextChanged(sender As Object, e As EventArgs) Handles librarian1.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = LibrariansDataGridView.DataSource
        bs.Filter = "Convert(LibrarianID, 'System.String') LIKE '" & librarian1.Text & "%'"
        LibrariansDataGridView.DataSource = bs
    End Sub

    Private Sub librarian2_TextChanged(sender As Object, e As EventArgs) Handles librarian2.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = LibrariansDataGridView.DataSource
        bs.Filter = "LibrarianName like '%" & librarian2.Text & "%'"
        LibrariansDataGridView.DataSource = bs
    End Sub

    Private Sub librarian3_TextChanged(sender As Object, e As EventArgs) Handles librarian3.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = LibrariansDataGridView.DataSource
        bs.Filter = "LibrarianGender like '" & librarian3.Text & "%'"
        LibrariansDataGridView.DataSource = bs
    End Sub

    Private Sub librarian4_TextChanged(sender As Object, e As EventArgs) Handles librarian4.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = LibrariansDataGridView.DataSource
        bs.Filter = "LibrarianAddress like '%" & librarian4.Text & "%'"
        LibrariansDataGridView.DataSource = bs
    End Sub

    Private Sub publisher1_TextChanged(sender As Object, e As EventArgs) Handles publisher1.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = PublishersDataGridView.DataSource
        bs.Filter = "Convert(PublisherID, 'System.String') LIKE '" & publisher1.Text & "%'"
        PublishersDataGridView.DataSource = bs
    End Sub

    Private Sub publisher2_TextChanged(sender As Object, e As EventArgs) Handles publisher2.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = PublishersDataGridView.DataSource
        bs.Filter = "PublisherName like '%" & publisher2.Text & "%'"
        PublishersDataGridView.DataSource = bs
    End Sub

    Private Sub publisher3_TextChanged(sender As Object, e As EventArgs) Handles publisher3.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = PublishersDataGridView.DataSource
        bs.Filter = "PublisherAddress like '%" & publisher3.Text & "%'"
        PublishersDataGridView.DataSource = bs
    End Sub

    Private Sub issue1_TextChanged(sender As Object, e As EventArgs) Handles issue1.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = IssuesDataGridView.DataSource
        bs.Filter = "Convert(IssueID, 'System.String') LIKE '" & issue1.Text & "%'"
        IssuesDataGridView.DataSource = bs
    End Sub

    Private Sub issue2_TextChanged(sender As Object, e As EventArgs) Handles issue2.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = IssuesDataGridView.DataSource
        bs.Filter = "Convert(BookID, 'System.String') LIKE '" & issue2.Text & "%'"
        IssuesDataGridView.DataSource = bs
    End Sub

    Private Sub issue3_TextChanged(sender As Object, e As EventArgs) Handles issue3.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = IssuesDataGridView.DataSource
        bs.Filter = "Convert(ISBN, 'System.String') LIKE '" & issue3.Text & "%'"
        IssuesDataGridView.DataSource = bs
    End Sub

    Private Sub issue4_TextChanged(sender As Object, e As EventArgs) Handles issue4.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = IssuesDataGridView.DataSource
        bs.Filter = "Convert(MemberID, 'System.String') LIKE '" & issue4.Text & "%'"
        IssuesDataGridView.DataSource = bs
    End Sub

    Private Sub issue5_TextChanged(sender As Object, e As EventArgs) Handles issue5.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = IssuesDataGridView.DataSource
        bs.Filter = "MemberName like '%" & issue5.Text & "%'"
        IssuesDataGridView.DataSource = bs
    End Sub

    Private Sub member1_TextChanged(sender As Object, e As EventArgs) Handles member1.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = MembersDataGridView.DataSource
        bs.Filter = "Convert(MemberID, 'System.String') LIKE '" & member1.Text & "%'"
        MembersDataGridView.DataSource = bs
    End Sub

    Private Sub member2_TextChanged(sender As Object, e As EventArgs) Handles member2.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = MembersDataGridView.DataSource
        bs.Filter = "MemberName like '%" & member2.Text & "%'"
        MembersDataGridView.DataSource = bs
    End Sub

    Private Sub member3_TextChanged(sender As Object, e As EventArgs) Handles member3.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = MembersDataGridView.DataSource
        bs.Filter = "MemberGender like '" & member3.Text & "%'"
        MembersDataGridView.DataSource = bs
    End Sub

    Private Sub member4_TextChanged(sender As Object, e As EventArgs) Handles member4.TextChanged
        Dim bs As BindingSource = New BindingSource()
        bs.DataSource = MembersDataGridView.DataSource
        bs.Filter = "MemberAddress like '%" & member4.Text & "%'"
        MembersDataGridView.DataSource = bs
    End Sub
End Class
