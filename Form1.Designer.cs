namespace sqlS
{
    partial class frmAlbum
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnInsertData = new System.Windows.Forms.Button();
            this.btnAmend = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnLastRec = new System.Windows.Forms.Button();
            this.btnNextRec = new System.Windows.Forms.Button();
            this.btnPrevRec = new System.Windows.Forms.Button();
            this.btnFirstRec = new System.Windows.Forms.Button();
            this.lblAlbumID = new System.Windows.Forms.Label();
            this.lblAlbTitle = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtAlbumID = new System.Windows.Forms.TextBox();
            this.txtAlbumTitle = new System.Windows.Forms.TextBox();
            this.txtArtist = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.btnSQL = new System.Windows.Forms.Button();
            this.billMusicDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bill_MusicDataSet = new sqlS.Bill_MusicDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.billMusicDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_MusicDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(490, 53);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(101, 47);
            this.btnDisplay.TabIndex = 1;
            this.btnDisplay.Text = "Display Data";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Visible = false;
            this.btnDisplay.Click += new System.EventHandler(this.BtnDisplay_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitle.Location = new System.Drawing.Point(140, 20);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(345, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Bill\'s Retro Music Store";
            // 
            // btnInsertData
            // 
            this.btnInsertData.Location = new System.Drawing.Point(490, 105);
            this.btnInsertData.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertData.Name = "btnInsertData";
            this.btnInsertData.Size = new System.Drawing.Size(101, 47);
            this.btnInsertData.TabIndex = 3;
            this.btnInsertData.Text = "Insert Data";
            this.btnInsertData.UseVisualStyleBackColor = true;
            this.btnInsertData.Visible = false;
            this.btnInsertData.Click += new System.EventHandler(this.BtnInsertData_Click);
            // 
            // btnAmend
            // 
            this.btnAmend.Location = new System.Drawing.Point(490, 157);
            this.btnAmend.Margin = new System.Windows.Forms.Padding(2);
            this.btnAmend.Name = "btnAmend";
            this.btnAmend.Size = new System.Drawing.Size(101, 47);
            this.btnAmend.TabIndex = 4;
            this.btnAmend.Text = "Amend Record";
            this.btnAmend.UseVisualStyleBackColor = true;
            this.btnAmend.Click += new System.EventHandler(this.btnAmend_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(490, 209);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 47);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(489, 261);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 47);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnLastRec
            // 
            this.btnLastRec.Location = new System.Drawing.Point(370, 262);
            this.btnLastRec.Margin = new System.Windows.Forms.Padding(2);
            this.btnLastRec.Name = "btnLastRec";
            this.btnLastRec.Size = new System.Drawing.Size(101, 47);
            this.btnLastRec.TabIndex = 7;
            this.btnLastRec.Text = "Last Record";
            this.btnLastRec.UseVisualStyleBackColor = true;
            this.btnLastRec.Click += new System.EventHandler(this.btnLastRec_Click);
            // 
            // btnNextRec
            // 
            this.btnNextRec.Location = new System.Drawing.Point(250, 262);
            this.btnNextRec.Margin = new System.Windows.Forms.Padding(2);
            this.btnNextRec.Name = "btnNextRec";
            this.btnNextRec.Size = new System.Drawing.Size(101, 47);
            this.btnNextRec.TabIndex = 8;
            this.btnNextRec.Text = "Next Record";
            this.btnNextRec.UseVisualStyleBackColor = true;
            this.btnNextRec.Click += new System.EventHandler(this.btnNextRec_Click);
            // 
            // btnPrevRec
            // 
            this.btnPrevRec.Location = new System.Drawing.Point(131, 262);
            this.btnPrevRec.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrevRec.Name = "btnPrevRec";
            this.btnPrevRec.Size = new System.Drawing.Size(101, 47);
            this.btnPrevRec.TabIndex = 9;
            this.btnPrevRec.Text = "Previous Record";
            this.btnPrevRec.UseVisualStyleBackColor = true;
            this.btnPrevRec.Click += new System.EventHandler(this.btnPrevRec_Click);
            // 
            // btnFirstRec
            // 
            this.btnFirstRec.Location = new System.Drawing.Point(12, 262);
            this.btnFirstRec.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirstRec.Name = "btnFirstRec";
            this.btnFirstRec.Size = new System.Drawing.Size(101, 47);
            this.btnFirstRec.TabIndex = 10;
            this.btnFirstRec.Text = "First Record";
            this.btnFirstRec.UseVisualStyleBackColor = true;
            this.btnFirstRec.Click += new System.EventHandler(this.btnFirstRec_Click);
            // 
            // lblAlbumID
            // 
            this.lblAlbumID.AutoSize = true;
            this.lblAlbumID.Location = new System.Drawing.Point(129, 84);
            this.lblAlbumID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlbumID.Name = "lblAlbumID";
            this.lblAlbumID.Size = new System.Drawing.Size(50, 13);
            this.lblAlbumID.TabIndex = 11;
            this.lblAlbumID.Text = "Album ID";
            // 
            // lblAlbTitle
            // 
            this.lblAlbTitle.AutoSize = true;
            this.lblAlbTitle.Location = new System.Drawing.Point(129, 110);
            this.lblAlbTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAlbTitle.Name = "lblAlbTitle";
            this.lblAlbTitle.Size = new System.Drawing.Size(59, 13);
            this.lblAlbTitle.TabIndex = 12;
            this.lblAlbTitle.Text = "Album Title";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(129, 136);
            this.lblArtist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(30, 13);
            this.lblArtist.TabIndex = 13;
            this.lblArtist.Text = "Artist";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(129, 162);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 14;
            this.lblGenre.Text = "Genre";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(129, 188);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(31, 13);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Price";
            // 
            // txtAlbumID
            // 
            this.txtAlbumID.Location = new System.Drawing.Point(226, 81);
            this.txtAlbumID.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlbumID.Name = "txtAlbumID";
            this.txtAlbumID.Size = new System.Drawing.Size(76, 20);
            this.txtAlbumID.TabIndex = 16;
            // 
            // txtAlbumTitle
            // 
            this.txtAlbumTitle.Location = new System.Drawing.Point(226, 107);
            this.txtAlbumTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtAlbumTitle.Name = "txtAlbumTitle";
            this.txtAlbumTitle.Size = new System.Drawing.Size(188, 20);
            this.txtAlbumTitle.TabIndex = 17;
            // 
            // txtArtist
            // 
            this.txtArtist.Location = new System.Drawing.Point(226, 133);
            this.txtArtist.Margin = new System.Windows.Forms.Padding(2);
            this.txtArtist.Name = "txtArtist";
            this.txtArtist.Size = new System.Drawing.Size(188, 20);
            this.txtArtist.TabIndex = 18;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(226, 159);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(2);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(151, 20);
            this.txtGenre.TabIndex = 19;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(226, 185);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(114, 20);
            this.txtPrice.TabIndex = 20;
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Location = new System.Drawing.Point(131, 220);
            this.lblRecordCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(0, 13);
            this.lblRecordCount.TabIndex = 22;
            // 
            // btnSQL
            // 
            this.btnSQL.Location = new System.Drawing.Point(12, 81);
            this.btnSQL.Margin = new System.Windows.Forms.Padding(2);
            this.btnSQL.Name = "btnSQL";
            this.btnSQL.Size = new System.Drawing.Size(56, 19);
            this.btnSQL.TabIndex = 24;
            this.btnSQL.Text = "SQL Search";
            this.btnSQL.UseVisualStyleBackColor = true;
            this.btnSQL.Click += new System.EventHandler(this.btnSQL_Click);
            // 
            // billMusicDataSetBindingSource
            // 
            this.billMusicDataSetBindingSource.DataSource = this.bill_MusicDataSet;
            this.billMusicDataSetBindingSource.Position = 0;
            // 
            // bill_MusicDataSet
            // 
            this.bill_MusicDataSet.DataSetName = "Bill_MusicDataSet";
            this.bill_MusicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frmAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 465);
            this.Controls.Add(this.btnSQL);
            this.Controls.Add(this.lblRecordCount);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtArtist);
            this.Controls.Add(this.txtAlbumTitle);
            this.Controls.Add(this.txtAlbumID);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.lblAlbTitle);
            this.Controls.Add(this.lblAlbumID);
            this.Controls.Add(this.btnFirstRec);
            this.Controls.Add(this.btnPrevRec);
            this.Controls.Add(this.btnNextRec);
            this.Controls.Add(this.btnLastRec);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAmend);
            this.Controls.Add(this.btnInsertData);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnDisplay);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAlbum";
            this.Text = "Album";
            this.Load += new System.EventHandler(this.frmAlbum_Load);
            ((System.ComponentModel.ISupportInitialize)(this.billMusicDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bill_MusicDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnInsertData;
        private System.Windows.Forms.Button btnAmend;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnLastRec;
        private System.Windows.Forms.Button btnNextRec;
        private System.Windows.Forms.Button btnPrevRec;
        private System.Windows.Forms.Button btnFirstRec;
        private System.Windows.Forms.Label lblAlbumID;
        private System.Windows.Forms.Label lblAlbTitle;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtAlbumID;
        private System.Windows.Forms.TextBox txtAlbumTitle;
        private System.Windows.Forms.TextBox txtArtist;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Button btnSQL;
        private System.Windows.Forms.BindingSource billMusicDataSetBindingSource;
        private Bill_MusicDataSet bill_MusicDataSet;
    }
}

