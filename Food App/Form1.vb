Public Class Form1
    ' Deklarasi variabel global
    Private totalBayar As Decimal = 0
    Private ppnRate As Decimal = 0.1 ' Contoh PPN 10%
    Private potongan As Decimal = 0
    Private totalKembali As Decimal = 0

    ' Harga setiap item makanan dan minuman
    Private hargaMakanan As New Dictionary(Of String, Decimal) From {
        {"Legendary Chicken Ramen", 39000},
        {"Karaage Ramen", 45000},
        {"Chicken Miso Ramen", 45000},
        {"Salted Egg Ramen", 45000},
        {"Beef Ramen", 47000},
        {"Lele Goreng", 12000},
        {"Soto", 13000}
    }

    Private hargaMinuman As New Dictionary(Of String, Decimal) From {
        {"Breeze All Varian", 24800},
        {"Punch All Varian", 23800},
        {"Yakult All Varian", 19800},
        {"Sparkling All Varian", 11800},
        {"Ice/Hot Tea", 10000},
        {"Ice/Hot Ocha", 4000},
        {"Mineral Water", 8000}
    }

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Isi ComboBox dengan pilihan potongan
        Label1.Text = "APLIKASI RESTORAN RAMEN YA"
        Label1.Font = New Font(Label1.Font, FontStyle.Bold)
        Label2.Text = "Menu Makanan"
        Label3.Text = "Menu Minuman"
        Label4.Text = "Nama"
        Label5.Text = "Jumlah"
        Label6.Text = "Subtotal"
        Label7.Text = "Potongan"
        Label8.Text = "PPN"
        Label9.Text = "Cash Bayar"
        Label10.Text = "Total Bayar"
        Label11.Text = "Kembalian"
        Label12.Text = ""
        Label14.Text = "" ' Subtotal
        Label15.Text = ""
        Label16.Text = ""
        GroupBox1.Text = "Daftar Menu"


        ' Tambahkan event handler untuk MouseEnter dan MouseLeave
        AddHandler Button1.MouseEnter, AddressOf Button1_MouseEnter
        AddHandler Button1.MouseLeave, AddressOf Button1_MouseLeave

        ' Atur warna background dan teks dari Button2
        Button2.BackColor = Color.LightBlue
        Button2.ForeColor = Color.DarkBlue

        AddHandler Button2.MouseEnter, AddressOf Button2_MouseEnter
        AddHandler Button2.MouseLeave, AddressOf Button2_MouseLeave

        ' Atur warna background dan teks dari Button3
        Button3.BackColor = Color.LightBlue ' Warna latar belakang tombol
        Button3.ForeColor = Color.DarkBlue  ' Warna teks tombol

        ' Tambahkan event handler untuk MouseEnter dan MouseLeave
        AddHandler Button3.MouseEnter, AddressOf Button3_MouseEnter
        AddHandler Button3.MouseLeave, AddressOf Button3_MouseLeave

        ' Atur warna background dan teks dari Button4
        Button4.BackColor = Color.LightBlue
        Button4.ForeColor = Color.DarkBlue

        AddHandler Button4.MouseEnter, AddressOf Button4_MouseEnter
        AddHandler Button4.MouseLeave, AddressOf Button4_MouseLeave

        ' Atur warna background dan teks dari Button5
        Button5.BackColor = Color.LightBlue ' Warna latar belakang tombol
        Button5.ForeColor = Color.DarkBlue  ' Warna teks tombol

        ' Tambahkan event handler untuk MouseEnter dan MouseLeave
        AddHandler Button5.MouseEnter, AddressOf Button5_MouseEnter
        AddHandler Button5.MouseLeave, AddressOf Button5_MouseLeave

        ' Menambahkan item makanan dan minuman ke dalam ListBox
        For Each makanan As String In hargaMakanan.Keys
            CheckedListBox1.Items.Add(makanan)
        Next

        For Each minuman As String In hargaMinuman.Keys
            CheckedListBox2.Items.Add(minuman)
        Next

        ComboBox1.Items.Add("Pilih Potongan")
        ComboBox1.Items.Add("5%")
        ComboBox1.Items.Add("20%")
        ComboBox1.Items.Add("25%")
        ComboBox1.Items.Add("30%")
        ComboBox1.Items.Add("35%")
        ComboBox1.Items.Add("40%")
        ComboBox1.Items.Add("45%")
        ComboBox1.Items.Add("50%")
        ComboBox1.SelectedIndex = 0 ' Pilih default 5%

        Button1.Text = "Hitung"
        Button2.Text = "Bersih"
        Button3.Text = "Keluar"
        Button4.Text = "Retur"
        Button5.Text = "Cetak Struk"

        ' Membuat header di ListView columns
        ListView1.Columns.Add("Nama", 110, HorizontalAlignment.Center)
        ListView1.Columns.Add("Item", 110, HorizontalAlignment.Center)
        ListView1.Columns.Add("Harga/Porsi", 110, HorizontalAlignment.Center)
        ListView1.Columns.Add("Jumlah", 110, HorizontalAlignment.Center)
        ListView1.Columns.Add("Subtotal", 110, HorizontalAlignment.Center)
        ListView1.Columns.Add("Potongan", 110, HorizontalAlignment.Center)
        ListView1.Columns.Add("PPN", 110, HorizontalAlignment.Center)
        ListView1.Columns.Add("Total Bayar", 110, HorizontalAlignment.Center)

        ' Setting ListView untuk menampilkan data dan header
        ListView1.View = View.Details
        ListView1.FullRowSelect = True
        ListView1.GridLines = True
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs)
        ' Ubah warna tombol saat kursor berada di atasnya
        Button1.BackColor = Color.DarkBlue
        Button1.ForeColor = Color.White
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs)
        ' Kembalikan warna tombol saat kursor meninggalkan tombol
        Button1.BackColor = Color.LightBlue
        Button1.ForeColor = Color.DarkBlue
    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs)
        ' Ubah warna tombol saat kursor berada di atasnya
        Button2.BackColor = Color.DarkBlue
        Button2.ForeColor = Color.White
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs)
        ' Kembalikan warna tombol saat kursor meninggalkan tombol
        Button2.BackColor = Color.LightBlue
        Button2.ForeColor = Color.DarkBlue
    End Sub

    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs)
        ' Ubah warna tombol saat kursor berada di atasnya
        Button3.BackColor = Color.DarkBlue
        Button3.ForeColor = Color.White
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs)
        ' Kembalikan warna tombol saat kursor meninggalkan tombol
        Button3.BackColor = Color.LightBlue
        Button3.ForeColor = Color.DarkBlue
    End Sub

    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs)
        ' Ubah warna tombol saat kursor berada di atasnya
        Button4.BackColor = Color.DarkBlue
        Button4.ForeColor = Color.White
    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs)
        ' Kembalikan warna tombol saat kursor meninggalkan tombol
        Button4.BackColor = Color.LightBlue
        Button4.ForeColor = Color.DarkBlue
    End Sub

    Private Sub Button5_MouseEnter(sender As Object, e As EventArgs)
        ' Ubah warna tombol saat kursor berada di atasnya
        Button5.BackColor = Color.DarkBlue
        Button5.ForeColor = Color.White
    End Sub

    Private Sub Button5_MouseLeave(sender As Object, e As EventArgs)
        ' Kembalikan warna tombol saat kursor meninggalkan tombol
        Button5.BackColor = Color.LightBlue
        Button5.ForeColor = Color.DarkBlue
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Cek apakah potongan telah dipilih
        If ComboBox1.SelectedIndex = 0 Then
            MessageBox.Show("Pilih potongan dulu sebelum menghitung.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Hitung total sebelum PPN
        totalBayar = 0
        ListView1.Items.Clear()

        ' Menampung subtotal keseluruhan
        Dim subtotalKeseluruhan As Decimal = 0

        ' Menghitung total untuk makanan yang dipilih
        For Each makanan As String In CheckedListBox1.CheckedItems
            Dim qty As Integer = Integer.Parse(TextBox1.Text)
            Dim harga As Decimal = hargaMakanan(makanan)
            Dim subtotal As Decimal = qty * harga
            subtotalKeseluruhan += subtotal
            totalBayar += subtotal

            ' Tambahkan item ke ListView
            Dim item As New ListViewItem(TextBox3.Text) ' Nama pelanggan
            item.SubItems.Add(makanan)
            item.SubItems.Add(harga.ToString("C"))
            item.SubItems.Add(qty.ToString())
            item.SubItems.Add(subtotal.ToString("C"))
            item.SubItems.Add("")
            item.SubItems.Add("")
            item.SubItems.Add("")
            ListView1.Items.Add(item)
        Next

        ' Menghitung total untuk minuman yang dipilih
        For Each minuman As String In CheckedListBox2.CheckedItems
            Dim qty As Integer = Integer.Parse(TextBox1.Text)
            Dim harga As Decimal = hargaMinuman(minuman)
            Dim subtotal As Decimal = qty * harga
            subtotalKeseluruhan += subtotal
            totalBayar += subtotal

            ' Tambahkan item ke ListView
            Dim item As New ListViewItem(TextBox3.Text) ' Nama pelanggan
            item.SubItems.Add(minuman)
            item.SubItems.Add(harga.ToString("C"))
            item.SubItems.Add(qty.ToString())
            item.SubItems.Add(subtotal.ToString("C"))
            item.SubItems.Add("")
            item.SubItems.Add("")
            item.SubItems.Add("")
            ListView1.Items.Add(item)
        Next

        ' Hitung potongan
        Dim selectedPotongan As String = ComboBox1.SelectedItem.ToString().Replace("%", "")
        potongan = (Decimal.Parse(selectedPotongan) / 100) * totalBayar
        totalBayar -= potongan

        ' Hitung PPN berdasarkan total setelah potongan
        Dim ppn As Decimal = totalBayar * ppnRate

        ' Tambah PPN ke total bayar
        totalBayar += ppn

        ' Tampilkan total bayar dan PPN
        Label15.Text = totalBayar.ToString("C")
        Label12.Text = ppn.ToString("C")

        ' Tampilkan harga/porsi dan subtotal keseluruhan di label
        Label14.Text = subtotalKeseluruhan.ToString("C")

        ' Hitung kembalian jika ada uang bayar
        If Not String.IsNullOrEmpty(TextBox2.Text) Then
            Dim uangBayar As Decimal = Decimal.Parse(TextBox2.Text)
            totalKembali = uangBayar - totalBayar
            Label16.Text = totalKembali.ToString("C")
        End If

        ' Tambahkan total bayar, potongan, dan PPN ke ListView
        Dim totalItem As New ListViewItem("Total")
        totalItem.SubItems.Add("") ' Nama pelanggan
        totalItem.SubItems.Add("") ' Nama item (kosong)
        totalItem.SubItems.Add("") ' Harga/porsi (kosong)
        totalItem.SubItems.Add("") ' Jumlah (kosong)
        totalItem.SubItems.Add(potongan.ToString("C")) ' Potongan
        totalItem.SubItems.Add(ppn.ToString("C")) ' PPN
        totalItem.SubItems.Add(totalBayar.ToString("C")) ' Total Bayar
        ListView1.Items.Add(totalItem)
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Logika bersihkan
        totalBayar = 0
        totalKembali = 0
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ComboBox1.SelectedIndex = 0
        CheckedListBox1.ClearSelected()
        CheckedListBox2.ClearSelected()
        ListView1.Items.Clear()
        Label14.Text = ""
        Label15.Text = ""
        Label16.Text = ""
        Label12.Text = ""

        ' Hapus semua item yang dipilih di CheckedListBox
        CheckedListBox1.ClearSelected()
        For i As Integer = 0 To CheckedListBox1.Items.Count - 1
            CheckedListBox1.SetItemChecked(i, False)
        Next

        CheckedListBox2.ClearSelected()
        For i As Integer = 0 To CheckedListBox2.Items.Count - 1
            CheckedListBox2.SetItemChecked(i, False)
        Next

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Logika keluar
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'hapus 1 data
        If ListView1.SelectedItems.Count > 0 Then
            ' Get the item to be removed
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)

            ' Remove from ListView
            ListView1.Items.Remove(selectedItem)

            ' Remove from CheckedListBox
            RemoveItemFromCheckedListBox(selectedItem.SubItems(1).Text)

            ' Recalculate totals
            RecalculateTotals()
        Else
            MessageBox.Show("Silakan pilih data yang ingin dihapus.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Validasi input pembayaran
        Dim uangBayar As Decimal
        If String.IsNullOrEmpty(TextBox2.Text) OrElse Not Decimal.TryParse(TextBox2.Text, uangBayar) Then
            MessageBox.Show("Masukkan jumlah pembayaran yang valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Periksa apakah pembayaran sudah lunas sebelum mencetak struk
        If uangBayar < totalBayar Then
            MessageBox.Show("Lunasi pembayaran terlebih dahulu sebelum mencetak struk.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Buat struk
        Dim strukText As String = GenerateReceipt()

        ' Buat instance dari Form4 dan set teks struk
        Dim struk As New Struk()
        struk.SetReceiptText(strukText)

        ' Tampilkan Form4
        struk.Show()
    End Sub

    Private Function GenerateReceipt() As String
        Dim sb As New System.Text.StringBuilder()

        ' Add header
        sb.AppendLine("RESTORAN RAMEN YA")
        sb.AppendLine("===================================")
        sb.AppendLine($"Nama: {TextBox3.Text}")

        ' Add item details
        sb.AppendLine("Item                    Qty    Harga      Subtotal")
        sb.AppendLine("===================================")

        For Each item As ListViewItem In ListView1.Items
            If item.Text <> "Total" Then
                Dim namaItem As String = item.SubItems(1).Text
                Dim qty As String = item.SubItems(3).Text
                Dim harga As String = item.SubItems(2).Text
                Dim subtotal As String = item.SubItems(4).Text
                sb.AppendLine($"{namaItem.PadRight(24)} {qty.PadRight(5)} {harga.PadRight(10)} {subtotal}")
            End If
        Next

        ' Add totals and other details
        sb.AppendLine("===================================")
        sb.AppendLine($"Subtotal      : {Label14.Text}")
        sb.AppendLine($"Potongan      : {potongan.ToString("C")}")
        sb.AppendLine($"PPN           : {Label12.Text}")
        sb.AppendLine($"Total Bayar   : {Label15.Text}")
        sb.AppendLine($"Cash Bayar    : {TextBox2.Text}")
        sb.AppendLine($"Kembalian     : {Label16.Text}")
        sb.AppendLine("===================================")
        sb.AppendLine("Terima Kasih atas kunjungan Anda!")
        sb.AppendLine("===================================")

        Return sb.ToString()
    End Function

    Private Sub RemoveItemFromCheckedListBox(itemText As String)
        ' Remove the item from CheckedListBox1 if it exists there
        For i As Integer = 0 To CheckedListBox1.Items.Count - 1
            If CheckedListBox1.Items(i).ToString() = itemText Then
                CheckedListBox1.SetItemChecked(i, False)
                Exit Sub
            End If
        Next

        ' Remove the item from CheckedListBox2 if it exists there
        For i As Integer = 0 To CheckedListBox2.Items.Count - 1
            If CheckedListBox2.Items(i).ToString() = itemText Then
                CheckedListBox2.SetItemChecked(i, False)
                Exit Sub
            End If
        Next
    End Sub

    Private Sub RecalculateTotals()
        ' Reset totals
        totalBayar = 0
        Dim subtotalKeseluruhan As Decimal = 0

        ' Recalculate based on remaining items in ListView
        For Each item As ListViewItem In ListView1.Items
            If item.Text <> "Total" Then
                Dim subtotal As Decimal = Decimal.Parse(item.SubItems(4).Text, Globalization.NumberStyles.Currency)
                subtotalKeseluruhan += subtotal
                totalBayar += subtotal
            End If
        Next

        ' Apply discount again
        Dim selectedPotongan As String = ComboBox1.SelectedItem.ToString().Replace("%", "")
        potongan = (Decimal.Parse(selectedPotongan) / 100) * totalBayar
        totalBayar -= potongan

        ' Calculate PPN
        Dim ppn As Decimal = totalBayar * ppnRate
        totalBayar += ppn

        ' Update labels
        Label15.Text = totalBayar.ToString("C")
        Label14.Text = subtotalKeseluruhan.ToString("C")
        Label12.Text = ppn.ToString("C")

        ' Update total in ListView
        For Each item As ListViewItem In ListView1.Items
            If item.Text = "Total" Then
                item.SubItems(4).Text = potongan.ToString("C")
                item.SubItems(5).Text = ppn.ToString("C")
                item.SubItems(6).Text = totalBayar.ToString("C")
            End If
        Next
    End Sub
End Class