namespace netStrikeAdministrationTool
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.console_textbox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.user_listview = new System.Windows.Forms.ListView();
            this.liste_refresh = new System.Windows.Forms.Button();
            this.send_button = new System.Windows.Forms.Button();
            this.output_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connect_button = new System.Windows.Forms.Button();
            this.manuel_emir_check = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.emir_gönder_buton = new System.Windows.Forms.Button();
            this.emir_fonk_sayi_numeric = new System.Windows.Forms.NumericUpDown();
            this.emir_komut_testbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.emir_parametresi_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.emir_alici_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Listener = new System.ComponentModel.BackgroundWorker();
            this.discon = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.channel_textbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.server_textbox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.yoklamalabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.warn_label1 = new System.Windows.Forms.Label();
            this.destroybotnet_pass_button = new System.Windows.Forms.Button();
            this.destroybotnet_pass_textbox = new System.Windows.Forms.TextBox();
            this.DESTROY_BOTNET_BUTTON = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.destroybotnet_check = new System.Windows.Forms.CheckBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label16 = new System.Windows.Forms.Label();
            this.User_Refresher = new System.ComponentModel.BackgroundWorker();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emir_fonk_sayi_numeric)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // console_textbox
            // 
            this.console_textbox.BackColor = System.Drawing.Color.Black;
            this.console_textbox.Enabled = false;
            this.console_textbox.ForeColor = System.Drawing.Color.Lime;
            this.console_textbox.Location = new System.Drawing.Point(95, 399);
            this.console_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.console_textbox.Name = "console_textbox";
            this.console_textbox.Size = new System.Drawing.Size(807, 24);
            this.console_textbox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.user_listview);
            this.groupBox1.Controls.Add(this.liste_refresh);
            this.groupBox1.Controls.Add(this.send_button);
            this.groupBox1.Controls.Add(this.output_textbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.console_textbox);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1079, 438);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Çıktı";
            // 
            // user_listview
            // 
            this.user_listview.BackColor = System.Drawing.Color.Black;
            this.user_listview.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.user_listview.HideSelection = false;
            this.user_listview.Location = new System.Drawing.Point(911, 23);
            this.user_listview.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.user_listview.Name = "user_listview";
            this.user_listview.Size = new System.Drawing.Size(144, 331);
            this.user_listview.TabIndex = 16;
            this.user_listview.UseCompatibleStateImageBehavior = false;
            this.user_listview.View = System.Windows.Forms.View.List;
            // 
            // liste_refresh
            // 
            this.liste_refresh.BackColor = System.Drawing.Color.Black;
            this.liste_refresh.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.liste_refresh.Location = new System.Drawing.Point(911, 363);
            this.liste_refresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.liste_refresh.Name = "liste_refresh";
            this.liste_refresh.Size = new System.Drawing.Size(145, 26);
            this.liste_refresh.TabIndex = 5;
            this.liste_refresh.Text = "Yenile";
            this.liste_refresh.UseVisualStyleBackColor = false;
            this.liste_refresh.Click += new System.EventHandler(this.liste_refresh_Click);
            // 
            // send_button
            // 
            this.send_button.BackColor = System.Drawing.Color.Black;
            this.send_button.Enabled = false;
            this.send_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.send_button.Location = new System.Drawing.Point(911, 397);
            this.send_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.send_button.Name = "send_button";
            this.send_button.Size = new System.Drawing.Size(145, 26);
            this.send_button.TabIndex = 4;
            this.send_button.Text = "gönder";
            this.send_button.UseVisualStyleBackColor = false;
            this.send_button.Click += new System.EventHandler(this.send_button_Click);
            // 
            // output_textbox
            // 
            this.output_textbox.BackColor = System.Drawing.SystemColors.InfoText;
            this.output_textbox.ForeColor = System.Drawing.Color.Lime;
            this.output_textbox.Location = new System.Drawing.Point(12, 25);
            this.output_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.output_textbox.MaxLength = 999999999;
            this.output_textbox.Multiline = true;
            this.output_textbox.Name = "output_textbox";
            this.output_textbox.ReadOnly = true;
            this.output_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.output_textbox.Size = new System.Drawing.Size(889, 365);
            this.output_textbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(15, 402);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Konsol:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(672, 524);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "SERVER:";
            // 
            // connect_button
            // 
            this.connect_button.BackColor = System.Drawing.Color.Black;
            this.connect_button.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.connect_button.Location = new System.Drawing.Point(309, 101);
            this.connect_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(179, 64);
            this.connect_button.TabIndex = 6;
            this.connect_button.Text = "Bağlan";
            this.connect_button.UseVisualStyleBackColor = false;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // manuel_emir_check
            // 
            this.manuel_emir_check.AutoSize = true;
            this.manuel_emir_check.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.manuel_emir_check.ForeColor = System.Drawing.Color.Fuchsia;
            this.manuel_emir_check.Location = new System.Drawing.Point(16, 465);
            this.manuel_emir_check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.manuel_emir_check.Name = "manuel_emir_check";
            this.manuel_emir_check.Size = new System.Drawing.Size(174, 21);
            this.manuel_emir_check.TabIndex = 7;
            this.manuel_emir_check.Text = "manuel emir modu";
            this.manuel_emir_check.UseVisualStyleBackColor = true;
            this.manuel_emir_check.CheckedChanged += new System.EventHandler(this.manuel_emir_check_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Fuchsia;
            this.label3.Location = new System.Drawing.Point(35, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Durum:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(115, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "bağlı değil";
            // 
            // emir_gönder_buton
            // 
            this.emir_gönder_buton.BackColor = System.Drawing.Color.Black;
            this.emir_gönder_buton.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.emir_gönder_buton.ForeColor = System.Drawing.Color.Fuchsia;
            this.emir_gönder_buton.Location = new System.Drawing.Point(402, 31);
            this.emir_gönder_buton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emir_gönder_buton.Name = "emir_gönder_buton";
            this.emir_gönder_buton.Size = new System.Drawing.Size(124, 165);
            this.emir_gönder_buton.TabIndex = 10;
            this.emir_gönder_buton.Text = "GÖNDER";
            this.emir_gönder_buton.UseVisualStyleBackColor = false;
            this.emir_gönder_buton.Click += new System.EventHandler(this.ddos_fire_button_Click);
            // 
            // emir_fonk_sayi_numeric
            // 
            this.emir_fonk_sayi_numeric.Location = new System.Drawing.Point(161, 159);
            this.emir_fonk_sayi_numeric.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emir_fonk_sayi_numeric.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.emir_fonk_sayi_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.emir_fonk_sayi_numeric.Name = "emir_fonk_sayi_numeric";
            this.emir_fonk_sayi_numeric.Size = new System.Drawing.Size(73, 24);
            this.emir_fonk_sayi_numeric.TabIndex = 11;
            this.emir_fonk_sayi_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // emir_komut_testbox
            // 
            this.emir_komut_testbox.BackColor = System.Drawing.Color.Black;
            this.emir_komut_testbox.ForeColor = System.Drawing.Color.Lime;
            this.emir_komut_testbox.Location = new System.Drawing.Point(161, 46);
            this.emir_komut_testbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emir_komut_testbox.Name = "emir_komut_testbox";
            this.emir_komut_testbox.Size = new System.Drawing.Size(193, 24);
            this.emir_komut_testbox.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.emir_parametresi_textbox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.emir_alici_textbox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.emir_gönder_buton);
            this.groupBox2.Controls.Add(this.emir_komut_testbox);
            this.groupBox2.Controls.Add(this.emir_fonk_sayi_numeric);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupBox2.Location = new System.Drawing.Point(16, 511);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(564, 223);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Emir";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(36, 116);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 17);
            this.label19.TabIndex = 20;
            this.label19.Text = "Parametre:";
            // 
            // emir_parametresi_textbox
            // 
            this.emir_parametresi_textbox.BackColor = System.Drawing.Color.Black;
            this.emir_parametresi_textbox.ForeColor = System.Drawing.Color.Lime;
            this.emir_parametresi_textbox.Location = new System.Drawing.Point(161, 112);
            this.emir_parametresi_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emir_parametresi_textbox.Name = "emir_parametresi_textbox";
            this.emir_parametresi_textbox.Size = new System.Drawing.Size(193, 24);
            this.emir_parametresi_textbox.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Alıcı:";
            // 
            // emir_alici_textbox
            // 
            this.emir_alici_textbox.BackColor = System.Drawing.Color.Black;
            this.emir_alici_textbox.ForeColor = System.Drawing.Color.Lime;
            this.emir_alici_textbox.Location = new System.Drawing.Point(161, 79);
            this.emir_alici_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emir_alici_textbox.Name = "emir_alici_textbox";
            this.emir_alici_textbox.Size = new System.Drawing.Size(193, 24);
            this.emir_alici_textbox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 161);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Fonk. sayı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Komut:";
            // 
            // Listener
            // 
            this.Listener.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Listener_DoWork);
            // 
            // discon
            // 
            this.discon.DoWork += new System.ComponentModel.DoWorkEventHandler(this.discon_DoWork);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.channel_textbox);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.server_textbox);
            this.groupBox3.Controls.Add(this.connect_button);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupBox3.Location = new System.Drawing.Point(588, 511);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(507, 223);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bağlan";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Fuchsia;
            this.label9.Location = new System.Drawing.Point(35, 149);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 13;
            this.label9.Text = "Dns:";
            // 
            // channel_textbox
            // 
            this.channel_textbox.Location = new System.Drawing.Point(149, 101);
            this.channel_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.channel_textbox.Multiline = true;
            this.channel_textbox.Name = "channel_textbox";
            this.channel_textbox.Size = new System.Drawing.Size(132, 25);
            this.channel_textbox.TabIndex = 12;
            this.channel_textbox.Text = "#Chatterz";
            this.channel_textbox.TextChanged += new System.EventHandler(this.channel_textbox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Fuchsia;
            this.label8.Location = new System.Drawing.Point(35, 105);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 17);
            this.label8.TabIndex = 11;
            this.label8.Text = "Kanal:";
            // 
            // server_textbox
            // 
            this.server_textbox.Location = new System.Drawing.Point(149, 145);
            this.server_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.server_textbox.Multiline = true;
            this.server_textbox.Name = "server_textbox";
            this.server_textbox.Size = new System.Drawing.Size(132, 25);
            this.server_textbox.TabIndex = 10;
            this.server_textbox.Text = "irc.rizon.net";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.yoklamalabel);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupBox4.Location = new System.Drawing.Point(1103, 26);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(377, 414);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "BOTNET Denetimi";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // yoklamalabel
            // 
            this.yoklamalabel.AutoSize = true;
            this.yoklamalabel.Font = new System.Drawing.Font("Verdana", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.yoklamalabel.ForeColor = System.Drawing.Color.Red;
            this.yoklamalabel.Location = new System.Drawing.Point(131, 348);
            this.yoklamalabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.yoklamalabel.Name = "yoklamalabel";
            this.yoklamalabel.Size = new System.Drawing.Size(18, 17);
            this.yoklamalabel.TabIndex = 21;
            this.yoklamalabel.Text = "_";
            this.yoklamalabel.Click += new System.EventHandler(this.label19_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.Fuchsia;
            this.label18.Location = new System.Drawing.Point(209, 121);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 17);
            this.label18.TabIndex = 20;
            this.label18.Text = "_";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 257);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 27);
            this.button1.TabIndex = 19;
            this.button1.Text = "yenile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.ForeColor = System.Drawing.Color.Fuchsia;
            this.label15.Location = new System.Drawing.Point(159, 70);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(18, 17);
            this.label15.TabIndex = 18;
            this.label15.Text = "_";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 304);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 28);
            this.button2.TabIndex = 17;
            this.button2.Text = "İstemcileri yokla";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.Fuchsia;
            this.label13.Location = new System.Drawing.Point(31, 70);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 17);
            this.label13.TabIndex = 15;
            this.label13.Text = "Kullanıcı adı:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.Color.Fuchsia;
            this.label12.Location = new System.Drawing.Point(31, 206);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 17);
            this.label12.TabIndex = 14;
            this.label12.Text = "Admin:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.Fuchsia;
            this.label11.Location = new System.Drawing.Point(31, 166);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 17);
            this.label11.TabIndex = 13;
            this.label11.Text = "Davetsiz ziyaretçi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Fuchsia;
            this.label10.Location = new System.Drawing.Point(33, 121);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "Bilinen BOT sayısı:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.warn_label1);
            this.groupBox5.Controls.Add(this.destroybotnet_pass_button);
            this.groupBox5.Controls.Add(this.destroybotnet_pass_textbox);
            this.groupBox5.Controls.Add(this.DESTROY_BOTNET_BUTTON);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.destroybotnet_check);
            this.groupBox5.ForeColor = System.Drawing.Color.Fuchsia;
            this.groupBox5.Location = new System.Drawing.Point(1103, 511);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(377, 223);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "BOTNET\'i Sil";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // warn_label1
            // 
            this.warn_label1.AutoSize = true;
            this.warn_label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.warn_label1.Location = new System.Drawing.Point(80, 105);
            this.warn_label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.warn_label1.Name = "warn_label1";
            this.warn_label1.Size = new System.Drawing.Size(16, 17);
            this.warn_label1.TabIndex = 23;
            this.warn_label1.Text = "_";
            // 
            // destroybotnet_pass_button
            // 
            this.destroybotnet_pass_button.BackColor = System.Drawing.Color.Black;
            this.destroybotnet_pass_button.Location = new System.Drawing.Point(225, 59);
            this.destroybotnet_pass_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.destroybotnet_pass_button.Name = "destroybotnet_pass_button";
            this.destroybotnet_pass_button.Size = new System.Drawing.Size(68, 33);
            this.destroybotnet_pass_button.TabIndex = 21;
            this.destroybotnet_pass_button.Text = "Enter";
            this.destroybotnet_pass_button.UseVisualStyleBackColor = false;
            this.destroybotnet_pass_button.Click += new System.EventHandler(this.button4_Click);
            // 
            // destroybotnet_pass_textbox
            // 
            this.destroybotnet_pass_textbox.Location = new System.Drawing.Point(84, 64);
            this.destroybotnet_pass_textbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.destroybotnet_pass_textbox.Name = "destroybotnet_pass_textbox";
            this.destroybotnet_pass_textbox.Size = new System.Drawing.Size(132, 22);
            this.destroybotnet_pass_textbox.TabIndex = 18;
            // 
            // DESTROY_BOTNET_BUTTON
            // 
            this.DESTROY_BOTNET_BUTTON.Enabled = false;
            this.DESTROY_BOTNET_BUTTON.Location = new System.Drawing.Point(355, -167);
            this.DESTROY_BOTNET_BUTTON.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DESTROY_BOTNET_BUTTON.Name = "DESTROY_BOTNET_BUTTON";
            this.DESTROY_BOTNET_BUTTON.Size = new System.Drawing.Size(155, 41);
            this.DESTROY_BOTNET_BUTTON.TabIndex = 17;
            this.DESTROY_BOTNET_BUTTON.Text = "BOTNET\'i Sil";
            this.DESTROY_BOTNET_BUTTON.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.Fuchsia;
            this.label14.Location = new System.Drawing.Point(20, 68);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "Şifre:";
            // 
            // destroybotnet_check
            // 
            this.destroybotnet_check.AutoSize = true;
            this.destroybotnet_check.Enabled = false;
            this.destroybotnet_check.Location = new System.Drawing.Point(176, 103);
            this.destroybotnet_check.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.destroybotnet_check.Name = "destroybotnet_check";
            this.destroybotnet_check.Size = new System.Drawing.Size(109, 21);
            this.destroybotnet_check.TabIndex = 19;
            this.destroybotnet_check.Text = "ONAYLANDI";
            this.destroybotnet_check.UseVisualStyleBackColor = true;
            this.destroybotnet_check.CheckedChanged += new System.EventHandler(this.destroybotnet_check_CheckedChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(4, 740);
            this.splitter1.TabIndex = 17;
            this.splitter1.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.Color.Fuchsia;
            this.label16.Location = new System.Drawing.Point(872, 470);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(572, 17);
            this.label16.TabIndex = 22;
            this.label16.Text = "*\"BOTNET\'i Sil\" butonuna basarak tüm casus yazılımları deaktif etmiş olursunuz.";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // User_Refresher
            // 
            this.User_Refresher.DoWork += new System.ComponentModel.DoWorkEventHandler(this.User_Refresher_DoWork);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(0, 0);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 17);
            this.label20.TabIndex = 23;
            this.label20.Text = "label20";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1497, 740);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.manuel_emir_check);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "netStrike Administration Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emir_fonk_sayi_numeric)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox console_textbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox output_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button liste_refresh;
        private System.Windows.Forms.Button send_button;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.CheckBox manuel_emir_check;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button emir_gönder_buton;
        private System.Windows.Forms.NumericUpDown emir_fonk_sayi_numeric;
        private System.Windows.Forms.TextBox emir_komut_testbox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.ComponentModel.BackgroundWorker Listener;
        private System.ComponentModel.BackgroundWorker discon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox emir_alici_textbox;
        private System.Windows.Forms.ListView user_listview;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox channel_textbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox server_textbox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox destroybotnet_pass_textbox;
        private System.Windows.Forms.Button DESTROY_BOTNET_BUTTON;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox destroybotnet_check;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button destroybotnet_pass_button;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label warn_label1;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker User_Refresher;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label yoklamalabel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox emir_parametresi_textbox;
        private System.Windows.Forms.Label label20;
    }
}

