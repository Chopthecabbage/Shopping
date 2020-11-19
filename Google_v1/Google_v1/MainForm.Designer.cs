namespace Google_v1
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnRanking = new System.Windows.Forms.RadioButton();
            this.rbtnLowPrice = new System.Windows.Forms.RadioButton();
            this.rbtnSalesVolume = new System.Windows.Forms.RadioButton();
            this.rbtnHighPrice = new System.Windows.Forms.RadioButton();
            this.rbtnLatest = new System.Windows.Forms.RadioButton();
            this.ListBoxReset_btn = new System.Windows.Forms.Button();
            this.lblWarning_v1 = new System.Windows.Forms.Label();
            this.btnWindowClose = new System.Windows.Forms.Button();
            this.lblTitleAuction = new System.Windows.Forms.Label();
            this.lblTitleTmon = new System.Windows.Forms.Label();
            this.lblResultAuction = new System.Windows.Forms.Label();
            this.lbxAuction = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblResultTmon = new System.Windows.Forms.Label();
            this.lbxTmon = new System.Windows.Forms.ListBox();
            this.lblTitleGmarket = new System.Windows.Forms.Label();
            this.lblResultGmarket = new System.Windows.Forms.Label();
            this.lbxGmarket = new System.Windows.Forms.ListBox();
            this.lblTitleWemakeprice = new System.Windows.Forms.Label();
            this.lblResultWemakeprice = new System.Windows.Forms.Label();
            this.lbxWemakeprice = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHide = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnAuction = new System.Windows.Forms.RadioButton();
            this.rbtnGmarket = new System.Windows.Forms.RadioButton();
            this.rbtnTmon = new System.Windows.Forms.RadioButton();
            this.rbtnWemakeprice = new System.Windows.Forms.RadioButton();
            this.lblResultImage = new System.Windows.Forms.Label();
            this.btnDialog = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblWarning_v2 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SaddleBrown;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1471, 59);
            this.label1.TabIndex = 2;
            this.label1.Text = "옥션 / G마켓 / 티몬 / 위메프 검색 ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tbxSearch);
            this.groupBox3.ForeColor = System.Drawing.Color.BlueViolet;
            this.groupBox3.Location = new System.Drawing.Point(12, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 122);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "검색 옵션";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Azure;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "검색어 입력";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxSearch
            // 
            this.tbxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxSearch.Font = new System.Drawing.Font("휴먼모음T", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tbxSearch.Location = new System.Drawing.Point(12, 70);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(4);
            this.tbxSearch.Multiline = true;
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(201, 34);
            this.tbxSearch.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnRanking);
            this.groupBox1.Controls.Add(this.rbtnLowPrice);
            this.groupBox1.Controls.Add(this.rbtnSalesVolume);
            this.groupBox1.Controls.Add(this.rbtnHighPrice);
            this.groupBox1.Controls.Add(this.rbtnLatest);
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 344);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 158);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "쇼핑몰 검색 종류";
            // 
            // rbtnRanking
            // 
            this.rbtnRanking.AutoSize = true;
            this.rbtnRanking.Checked = true;
            this.rbtnRanking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbtnRanking.Location = new System.Drawing.Point(20, 32);
            this.rbtnRanking.Name = "rbtnRanking";
            this.rbtnRanking.Size = new System.Drawing.Size(173, 24);
            this.rbtnRanking.TabIndex = 55;
            this.rbtnRanking.TabStop = true;
            this.rbtnRanking.Text = "랭킹순 (위메프 → 추천순)";
            this.rbtnRanking.UseVisualStyleBackColor = true;
            // 
            // rbtnLowPrice
            // 
            this.rbtnLowPrice.AutoSize = true;
            this.rbtnLowPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbtnLowPrice.Location = new System.Drawing.Point(20, 74);
            this.rbtnLowPrice.Name = "rbtnLowPrice";
            this.rbtnLowPrice.Size = new System.Drawing.Size(87, 24);
            this.rbtnLowPrice.TabIndex = 55;
            this.rbtnLowPrice.Text = "낮은가격순";
            this.rbtnLowPrice.UseVisualStyleBackColor = true;
            // 
            // rbtnSalesVolume
            // 
            this.rbtnSalesVolume.AutoSize = true;
            this.rbtnSalesVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbtnSalesVolume.Location = new System.Drawing.Point(20, 118);
            this.rbtnSalesVolume.Name = "rbtnSalesVolume";
            this.rbtnSalesVolume.Size = new System.Drawing.Size(75, 24);
            this.rbtnSalesVolume.TabIndex = 55;
            this.rbtnSalesVolume.Text = "판매량순";
            this.rbtnSalesVolume.UseVisualStyleBackColor = true;
            // 
            // rbtnHighPrice
            // 
            this.rbtnHighPrice.AutoSize = true;
            this.rbtnHighPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbtnHighPrice.Location = new System.Drawing.Point(120, 74);
            this.rbtnHighPrice.Name = "rbtnHighPrice";
            this.rbtnHighPrice.Size = new System.Drawing.Size(87, 24);
            this.rbtnHighPrice.TabIndex = 5;
            this.rbtnHighPrice.Text = "높은가격순";
            this.rbtnHighPrice.UseVisualStyleBackColor = true;
            // 
            // rbtnLatest
            // 
            this.rbtnLatest.AutoSize = true;
            this.rbtnLatest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbtnLatest.Location = new System.Drawing.Point(120, 118);
            this.rbtnLatest.Name = "rbtnLatest";
            this.rbtnLatest.Size = new System.Drawing.Size(63, 24);
            this.rbtnLatest.TabIndex = 7;
            this.rbtnLatest.Text = "최신순";
            this.rbtnLatest.UseVisualStyleBackColor = true;
            // 
            // ListBoxReset_btn
            // 
            this.ListBoxReset_btn.BackColor = System.Drawing.Color.YellowGreen;
            this.ListBoxReset_btn.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ListBoxReset_btn.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ListBoxReset_btn.Location = new System.Drawing.Point(11, 660);
            this.ListBoxReset_btn.Name = "ListBoxReset_btn";
            this.ListBoxReset_btn.Size = new System.Drawing.Size(220, 62);
            this.ListBoxReset_btn.TabIndex = 39;
            this.ListBoxReset_btn.Text = "리스트박스 선택 초기화";
            this.ListBoxReset_btn.UseVisualStyleBackColor = false;
            this.ListBoxReset_btn.Click += new System.EventHandler(this.ListBoxReset_btn_Click);
            // 
            // lblWarning_v1
            // 
            this.lblWarning_v1.BackColor = System.Drawing.SystemColors.Info;
            this.lblWarning_v1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWarning_v1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning_v1.ForeColor = System.Drawing.Color.Red;
            this.lblWarning_v1.Location = new System.Drawing.Point(12, 742);
            this.lblWarning_v1.Name = "lblWarning_v1";
            this.lblWarning_v1.Size = new System.Drawing.Size(219, 23);
            this.lblWarning_v1.TabIndex = 40;
            this.lblWarning_v1.Text = "* 주의 : 모든 크롬 창을 닫습니다.";
            this.lblWarning_v1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnWindowClose
            // 
            this.btnWindowClose.BackColor = System.Drawing.Color.Azure;
            this.btnWindowClose.Font = new System.Drawing.Font("휴먼둥근헤드라인", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnWindowClose.ForeColor = System.Drawing.Color.SlateBlue;
            this.btnWindowClose.Location = new System.Drawing.Point(12, 768);
            this.btnWindowClose.Name = "btnWindowClose";
            this.btnWindowClose.Size = new System.Drawing.Size(220, 54);
            this.btnWindowClose.TabIndex = 41;
            this.btnWindowClose.Text = "열린 창 닫기";
            this.btnWindowClose.UseVisualStyleBackColor = false;
            this.btnWindowClose.Click += new System.EventHandler(this.btnWindowClose_Click);
            // 
            // lblTitleAuction
            // 
            this.lblTitleAuction.BackColor = System.Drawing.Color.Crimson;
            this.lblTitleAuction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitleAuction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitleAuction.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleAuction.Location = new System.Drawing.Point(258, 59);
            this.lblTitleAuction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleAuction.Name = "lblTitleAuction";
            this.lblTitleAuction.Size = new System.Drawing.Size(586, 50);
            this.lblTitleAuction.TabIndex = 42;
            this.lblTitleAuction.Text = "옥션";
            this.lblTitleAuction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitleTmon
            // 
            this.lblTitleTmon.BackColor = System.Drawing.Color.HotPink;
            this.lblTitleTmon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitleTmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitleTmon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleTmon.Location = new System.Drawing.Point(885, 59);
            this.lblTitleTmon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleTmon.Name = "lblTitleTmon";
            this.lblTitleTmon.Size = new System.Drawing.Size(586, 50);
            this.lblTitleTmon.TabIndex = 43;
            this.lblTitleTmon.Text = "티몬";
            this.lblTitleTmon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultAuction
            // 
            this.lblResultAuction.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblResultAuction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResultAuction.Location = new System.Drawing.Point(258, 124);
            this.lblResultAuction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultAuction.Name = "lblResultAuction";
            this.lblResultAuction.Size = new System.Drawing.Size(586, 33);
            this.lblResultAuction.TabIndex = 44;
            this.lblResultAuction.Text = "옥션 랭킹순 검색 결과";
            this.lblResultAuction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxAuction
            // 
            this.lbxAuction.FormattingEnabled = true;
            this.lbxAuction.HorizontalExtent = 1000;
            this.lbxAuction.HorizontalScrollbar = true;
            this.lbxAuction.ItemHeight = 12;
            this.lbxAuction.Location = new System.Drawing.Point(258, 169);
            this.lbxAuction.Name = "lbxAuction";
            this.lbxAuction.Size = new System.Drawing.Size(586, 304);
            this.lbxAuction.TabIndex = 45;
            this.lbxAuction.SelectedIndexChanged += new System.EventHandler(this.lbxAuction_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.PapayaWhip;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("휴먼엑스포", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(12, 244);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(220, 65);
            this.btnSearch.TabIndex = 46;
            this.btnSearch.Text = "검색 실행";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // lblResultTmon
            // 
            this.lblResultTmon.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblResultTmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResultTmon.Location = new System.Drawing.Point(885, 124);
            this.lblResultTmon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultTmon.Name = "lblResultTmon";
            this.lblResultTmon.Size = new System.Drawing.Size(586, 33);
            this.lblResultTmon.TabIndex = 47;
            this.lblResultTmon.Text = "티몬 랭킹순 검색 결과";
            this.lblResultTmon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxTmon
            // 
            this.lbxTmon.FormattingEnabled = true;
            this.lbxTmon.HorizontalExtent = 1000;
            this.lbxTmon.HorizontalScrollbar = true;
            this.lbxTmon.ItemHeight = 12;
            this.lbxTmon.Location = new System.Drawing.Point(885, 169);
            this.lbxTmon.Name = "lbxTmon";
            this.lbxTmon.Size = new System.Drawing.Size(586, 304);
            this.lbxTmon.TabIndex = 48;
            this.lbxTmon.SelectedIndexChanged += new System.EventHandler(this.lbxTmon_SelectedIndexChanged);
            // 
            // lblTitleGmarket
            // 
            this.lblTitleGmarket.BackColor = System.Drawing.Color.ForestGreen;
            this.lblTitleGmarket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitleGmarket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitleGmarket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleGmarket.Location = new System.Drawing.Point(258, 493);
            this.lblTitleGmarket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleGmarket.Name = "lblTitleGmarket";
            this.lblTitleGmarket.Size = new System.Drawing.Size(586, 50);
            this.lblTitleGmarket.TabIndex = 49;
            this.lblTitleGmarket.Text = "G마켓";
            this.lblTitleGmarket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultGmarket
            // 
            this.lblResultGmarket.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblResultGmarket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResultGmarket.Location = new System.Drawing.Point(258, 556);
            this.lblResultGmarket.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultGmarket.Name = "lblResultGmarket";
            this.lblResultGmarket.Size = new System.Drawing.Size(586, 33);
            this.lblResultGmarket.TabIndex = 50;
            this.lblResultGmarket.Text = "G마켓 랭킹순 검색 결과";
            this.lblResultGmarket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxGmarket
            // 
            this.lbxGmarket.FormattingEnabled = true;
            this.lbxGmarket.HorizontalExtent = 1000;
            this.lbxGmarket.HorizontalScrollbar = true;
            this.lbxGmarket.ItemHeight = 12;
            this.lbxGmarket.Location = new System.Drawing.Point(258, 617);
            this.lbxGmarket.Name = "lbxGmarket";
            this.lbxGmarket.Size = new System.Drawing.Size(586, 304);
            this.lbxGmarket.TabIndex = 51;
            this.lbxGmarket.SelectedIndexChanged += new System.EventHandler(this.lbxGmarket_SelectedIndexChanged);
            // 
            // lblTitleWemakeprice
            // 
            this.lblTitleWemakeprice.BackColor = System.Drawing.Color.OrangeRed;
            this.lblTitleWemakeprice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitleWemakeprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitleWemakeprice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitleWemakeprice.Location = new System.Drawing.Point(885, 493);
            this.lblTitleWemakeprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleWemakeprice.Name = "lblTitleWemakeprice";
            this.lblTitleWemakeprice.Size = new System.Drawing.Size(586, 50);
            this.lblTitleWemakeprice.TabIndex = 52;
            this.lblTitleWemakeprice.Text = "위메프";
            this.lblTitleWemakeprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResultWemakeprice
            // 
            this.lblResultWemakeprice.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblResultWemakeprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResultWemakeprice.Location = new System.Drawing.Point(885, 556);
            this.lblResultWemakeprice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultWemakeprice.Name = "lblResultWemakeprice";
            this.lblResultWemakeprice.Size = new System.Drawing.Size(586, 33);
            this.lblResultWemakeprice.TabIndex = 53;
            this.lblResultWemakeprice.Text = "위메프 추천순 검색 결과";
            this.lblResultWemakeprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbxWemakeprice
            // 
            this.lbxWemakeprice.FormattingEnabled = true;
            this.lbxWemakeprice.HorizontalExtent = 1000;
            this.lbxWemakeprice.HorizontalScrollbar = true;
            this.lbxWemakeprice.ItemHeight = 12;
            this.lbxWemakeprice.Location = new System.Drawing.Point(885, 617);
            this.lbxWemakeprice.Name = "lbxWemakeprice";
            this.lbxWemakeprice.Size = new System.Drawing.Size(586, 304);
            this.lbxWemakeprice.TabIndex = 54;
            this.lbxWemakeprice.SelectedIndexChanged += new System.EventHandler(this.lbxWemakeprice_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.btnHide);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1850, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(34, 961);
            this.panel1.TabIndex = 55;
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.BurlyWood;
            this.btnHide.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHide.Font = new System.Drawing.Font("휴먼엑스포", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnHide.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnHide.Location = new System.Drawing.Point(0, 0);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(34, 119);
            this.btnHide.TabIndex = 0;
            this.btnHide.Text = "숨\r\n기\r\n기";
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Plum;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1500, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 961);
            this.panel2.TabIndex = 56;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1487, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 320);
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(1487, 315);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(320, 320);
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(1487, 629);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(320, 320);
            this.pictureBox3.TabIndex = 59;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnAuction);
            this.groupBox2.Controls.Add(this.rbtnGmarket);
            this.groupBox2.Controls.Add(this.rbtnTmon);
            this.groupBox2.Controls.Add(this.rbtnWemakeprice);
            this.groupBox2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox2.Location = new System.Drawing.Point(12, 517);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 127);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "쇼핑몰 검색 이미지 선택";
            // 
            // rbtnAuction
            // 
            this.rbtnAuction.AutoSize = true;
            this.rbtnAuction.Checked = true;
            this.rbtnAuction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbtnAuction.Location = new System.Drawing.Point(12, 32);
            this.rbtnAuction.Name = "rbtnAuction";
            this.rbtnAuction.Size = new System.Drawing.Size(51, 24);
            this.rbtnAuction.TabIndex = 55;
            this.rbtnAuction.TabStop = true;
            this.rbtnAuction.Text = "옥션";
            this.rbtnAuction.UseVisualStyleBackColor = true;
            // 
            // rbtnGmarket
            // 
            this.rbtnGmarket.AutoSize = true;
            this.rbtnGmarket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbtnGmarket.Location = new System.Drawing.Point(12, 78);
            this.rbtnGmarket.Name = "rbtnGmarket";
            this.rbtnGmarket.Size = new System.Drawing.Size(64, 24);
            this.rbtnGmarket.TabIndex = 55;
            this.rbtnGmarket.Text = "G마켓";
            this.rbtnGmarket.UseVisualStyleBackColor = true;
            // 
            // rbtnTmon
            // 
            this.rbtnTmon.AutoSize = true;
            this.rbtnTmon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbtnTmon.Location = new System.Drawing.Point(120, 32);
            this.rbtnTmon.Name = "rbtnTmon";
            this.rbtnTmon.Size = new System.Drawing.Size(51, 24);
            this.rbtnTmon.TabIndex = 5;
            this.rbtnTmon.Text = "티몬";
            this.rbtnTmon.UseVisualStyleBackColor = true;
            // 
            // rbtnWemakeprice
            // 
            this.rbtnWemakeprice.AutoSize = true;
            this.rbtnWemakeprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.rbtnWemakeprice.Location = new System.Drawing.Point(120, 78);
            this.rbtnWemakeprice.Name = "rbtnWemakeprice";
            this.rbtnWemakeprice.Size = new System.Drawing.Size(63, 24);
            this.rbtnWemakeprice.TabIndex = 7;
            this.rbtnWemakeprice.Text = "위메프";
            this.rbtnWemakeprice.UseVisualStyleBackColor = true;
            // 
            // lblResultImage
            // 
            this.lblResultImage.AutoSize = true;
            this.lblResultImage.Font = new System.Drawing.Font("휴먼엑스포", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblResultImage.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblResultImage.Location = new System.Drawing.Point(1813, 0);
            this.lblResultImage.Name = "lblResultImage";
            this.lblResultImage.Size = new System.Drawing.Size(31, 207);
            this.lblResultImage.TabIndex = 61;
            this.lblResultImage.Text = "옥\r\n션\r\n\r\n대\r\n표\r\n\r\n이\r\n미\r\n지";
            // 
            // btnDialog
            // 
            this.btnDialog.BackColor = System.Drawing.Color.MediumAquamarine;
            this.btnDialog.Font = new System.Drawing.Font("문체부 제목 돋음체", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDialog.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnDialog.Location = new System.Drawing.Point(12, 865);
            this.btnDialog.Name = "btnDialog";
            this.btnDialog.Size = new System.Drawing.Size(219, 56);
            this.btnDialog.TabIndex = 62;
            this.btnDialog.Text = "네이버쇼핑 → 가격비교";
            this.btnDialog.UseVisualStyleBackColor = false;
            this.btnDialog.Click += new System.EventHandler(this.btnDialog_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.LawnGreen;
            this.btnReset.Font = new System.Drawing.Font("함초롬바탕 확장", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReset.Location = new System.Drawing.Point(12, 201);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(220, 37);
            this.btnReset.TabIndex = 63;
            this.btnReset.Text = "검색어 초기화";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblWarning_v2
            // 
            this.lblWarning_v2.BackColor = System.Drawing.SystemColors.Info;
            this.lblWarning_v2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWarning_v2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning_v2.ForeColor = System.Drawing.Color.Peru;
            this.lblWarning_v2.Location = new System.Drawing.Point(12, 839);
            this.lblWarning_v2.Name = "lblWarning_v2";
            this.lblWarning_v2.Size = new System.Drawing.Size(219, 23);
            this.lblWarning_v2.TabIndex = 64;
            this.lblWarning_v2.Text = "* 알림 : 모델명을 입력하세요.";
            this.lblWarning_v2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1884, 961);
            this.Controls.Add(this.lblWarning_v2);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDialog);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbxWemakeprice);
            this.Controls.Add(this.lblResultWemakeprice);
            this.Controls.Add(this.lblTitleWemakeprice);
            this.Controls.Add(this.lbxGmarket);
            this.Controls.Add(this.lblResultGmarket);
            this.Controls.Add(this.lblTitleGmarket);
            this.Controls.Add(this.lbxTmon);
            this.Controls.Add(this.lblResultTmon);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lbxAuction);
            this.Controls.Add(this.lblResultAuction);
            this.Controls.Add(this.lblTitleTmon);
            this.Controls.Add(this.lblTitleAuction);
            this.Controls.Add(this.btnWindowClose);
            this.Controls.Add(this.lblWarning_v1);
            this.Controls.Add(this.ListBoxReset_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblResultImage);
            this.Name = "MainForm";
            this.Text = "쇼핑몰 검색 프로그램";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnSalesVolume;
        private System.Windows.Forms.RadioButton rbtnHighPrice;
        private System.Windows.Forms.RadioButton rbtnLatest;
        private System.Windows.Forms.Button ListBoxReset_btn;
        private System.Windows.Forms.Label lblWarning_v1;
        private System.Windows.Forms.Button btnWindowClose;
        private System.Windows.Forms.Label lblTitleAuction;
        private System.Windows.Forms.Label lblTitleTmon;
        private System.Windows.Forms.Label lblResultAuction;
        private System.Windows.Forms.ListBox lbxAuction;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblResultTmon;
        private System.Windows.Forms.ListBox lbxTmon;
        private System.Windows.Forms.Label lblTitleGmarket;
        private System.Windows.Forms.Label lblResultGmarket;
        private System.Windows.Forms.ListBox lbxGmarket;
        private System.Windows.Forms.Label lblTitleWemakeprice;
        private System.Windows.Forms.Label lblResultWemakeprice;
        private System.Windows.Forms.ListBox lbxWemakeprice;
        private System.Windows.Forms.RadioButton rbtnRanking;
        private System.Windows.Forms.RadioButton rbtnLowPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnAuction;
        private System.Windows.Forms.RadioButton rbtnGmarket;
        private System.Windows.Forms.RadioButton rbtnTmon;
        private System.Windows.Forms.RadioButton rbtnWemakeprice;
        private System.Windows.Forms.Label lblResultImage;
        private System.Windows.Forms.Button btnDialog;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblWarning_v2;
    }
}

