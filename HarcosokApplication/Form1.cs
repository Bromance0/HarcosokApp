using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HarcosokApplication
{
    public partial class karakterLetrehozasForm : Form
    {
        private const string dbLetrehoz = @"create database if not exists cs_harcosok";
        private const string harcosok = @"create table if not exists cs_harcosok.harcosok (
                                                                                            id int primary key auto_increment,
                                                                                            nev varchar(20) not null unique,
                                                                                            letrehozas date not null)";

        private const string kepessegek = @"create table if not exists cs_harcosok.kepessegek (
                                                                                                id int primary key auto_increment,
                                                                                                nev varchar(30) not null,
                                                                                                leiras varchar(100) not null,
                                                                                                harcos_id int,
                                                                                                FOREIGN KEY (harcos_id) REFERENCES harcosok(id))";


        private string connectString = "Server=localhost;Database=cs_harcosok;Uid=root;Password=";
        private MySqlConnection conn;

        public karakterLetrehozasForm()
        {
            conn = new MySqlConnection(connectString);
            try
            {
                conn.Open();
                var cmd_dbLetrehozas = conn.CreateCommand();
                cmd_dbLetrehozas.CommandText = dbLetrehoz;
                cmd_dbLetrehozas.ExecuteNonQuery();
                var cmd_HarcosokLetrehozas = conn.CreateCommand();
                cmd_HarcosokLetrehozas.CommandText = harcosok;
                cmd_HarcosokLetrehozas.ExecuteNonQuery();
                var cmd_KepessegekLetrehozas = conn.CreateCommand();
                cmd_KepessegekLetrehozas.CommandText = kepessegek;
                cmd_KepessegekLetrehozas.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                DialogResult result = MessageBox.Show("Nem sikerült kapcsolatot létesíteni a szerverrrel!", "Kapcsolati hiba!", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                this.Enabled = false;
            }
            harcosokKiir();
            hasznaloToltes();
            modositButton.Enabled = false;
            torlesButton.Enabled = false;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Close();
        }

        private void letrehozButton_Click(object sender, EventArgs e)
        {
            
            var ellenorzes = conn.CreateCommand();
            ellenorzes.CommandText = "select count(*) for cs_harcosok.harcosok where nev=@nev";
            ellenorzes.Parameters.AddWithValue("@nev", harcosokNeveTextBox.Text);
            var db_sor = (int)ellenorzes.ExecuteScalar();

            if (harcosokNeveTextBox == null || harcosokNeveTextBox.Text == "")
            {
                MessageBox.Show("Adjon meg egy harcos nevet!");
            }
            else
            {
                if (db_sor >= 1)
                {
                    MessageBox.Show("Már létezik ilyen karakter!");
                }
                else
                {
                    var harcosneve = conn.CreateCommand();
                    harcosneve.CommandText = "insert into cs_harcosok.harcosok (nev, letrehozas) values (@nev, @datum)";
                    harcosneve.Parameters.AddWithValue("@nev", harcosokNeveTextBox.Text);
                    harcosneve.Parameters.AddWithValue("@datum", DateTime.Now);
                    harcosneve.ExecuteNonQuery();
                    MessageBox.Show("Karakter felvéve!");
                }
            }
            harcosokKiir();
            hasznaloToltes();
            modositButton.Enabled = false;
            torlesButton.Enabled = false;
        }
        private void hasznaloToltes()
        {

            var uresEllenorzes = conn.CreateCommand();
            uresEllenorzes.CommandText = "select count(nev) from cs_harcosok.harcosok";
            var sorSzam = (long)uresEllenorzes.ExecuteScalar();
            if (sorSzam == 0)
            {
                kepessegGroupBox.Enabled = false;
                kepessegLeirasTextBox.Enabled = false;
            }
            else
            {
                kepessegGroupBox.Enabled = true;
                var karakterek = conn.CreateCommand();
                karakterek.CommandText = "select nev from cs_harcosok.harcosok";
                MySqlDataReader reader;
                using (reader = karakterek.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (!hasznaloComboBox.Items.Contains(reader["nev"]))
                        {
                            hasznaloComboBox.Items.Add(reader["nev"]);
                        }
                    }
                }
            }
        }

        private void hozzaadButton_Click(object sender, EventArgs e)
        {
            if (kepessegNeveTextBox.Text == "" || kepessegNeveTextBox == null || hasznaloComboBox.SelectedItem == null || leirasTextBox.Text == "" || leirasTextBox.Text == null)
            {
                MessageBox.Show("Mindent ki kell tölteni!");
            }
            else
            {
                string leiras = "";
                string harcosNeve = hasznaloComboBox.SelectedItem.ToString();
                int harcosID = 0;
                var xharcosID = conn.CreateCommand();
                xharcosID.CommandText = "select id from cs_harcosok.harcosok where nev = @nev";
                xharcosID.Parameters.AddWithValue("@nev", harcosNeve);
                MySqlDataReader reader;
                using (reader = xharcosID.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        harcosID = (int)reader["id"];
                    }
                }
                for (int i = 0; i < leirasTextBox.Lines.Count(); i++)
                {
                    leiras += leirasTextBox.Lines[i];
                }
                var kepessegNev = conn.CreateCommand();
                kepessegNev.CommandText = "insert into cs_harcosok.kepessegek (nev, leiras, harcos_id) values (@nev, @leiras, @id)";
                kepessegNev.Parameters.AddWithValue("@nev", kepessegNeveTextBox.Text);
                kepessegNev.Parameters.AddWithValue("@leiras", leiras);
                kepessegNev.Parameters.AddWithValue("@id", harcosID);
                kepessegNev.ExecuteNonQuery();

                MessageBox.Show("Képesség hozzáadva!");
                harcosokKiir();
                hasznaloToltes();
                modositButton.Enabled = false;
                torlesButton.Enabled = false;
            }

        }
        private void harcosokKiir()
        {
            var harcosokOssz = conn.CreateCommand();
            harcosokOssz.CommandText = "select nev, letrehozas from cs_harcosok.harcosok";
            MySqlDataReader reader;
            using (reader = harcosokOssz.ExecuteReader())
            {
                while (reader.Read())
                {
                    if (!harcosokListBox.Items.Contains(reader["nev"]))
                    {
                        var nev = reader["nev"];
                        var datum = string.Format("{0:d}", reader["letrehozas"]);

                        harcosokListBox.Items.Add(nev + "\t" + datum);
                    }
                }
            }
        }
        private void warriorsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (harcosokListBox.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                string warriorName = harcosokListBox.Items[harcosokListBox.SelectedIndex].ToString();
                int warriorName_Length = warriorName.Length - 23;
                var kivalasztottHarcosok = conn.CreateCommand();
                kivalasztottHarcosok.CommandText = "select kepessegek.nev nev from kepessegek inner join harcosok on kepessegek.harcos_id = harcosok.id where harcosok.nev like @hnev";
                kivalasztottHarcosok.Parameters.AddWithValue("@Hnev", warriorName.Substring(0, warriorName_Length));
                MySqlDataReader reader;

                using (reader = kivalasztottHarcosok.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        kepessegekListBox.Items.Add(reader["nev"]);
                    }
                }

                if (kepessegekListBox.Items.Count > 0)
                {
                    kepessegekListBox.SelectedIndex = 0;
                    modositButton.Enabled = true;
                    torlesButton.Enabled = true;
                }
                else
                {
                    modositButton.Enabled = false;
                    torlesButton.Enabled = false;
                    hasznaloToltes();
                }

                torlesButton.Enabled = true;
            }

        }

        private void kepessegekListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ;
            string abilityName = kepessegekListBox.Items[kepessegekListBox.SelectedIndex].ToString();
            var kepesseg = conn.CreateCommand();
            kepesseg.CommandText = "select leiras from kepessegek where nev like @KKNev";
            kepesseg.Parameters.AddWithValue("@KKNev", abilityName);
            MySqlDataReader reader;

            using (reader = kepesseg.ExecuteReader())
            {
                while (reader.Read())
                {
                    kepessegLeirasTextBox.Text += reader["leiras"];
                }
            }
            modositButton.Enabled = true;
            kepessegLeirasTextBox.Enabled = true;
        }

        private void torlesButton_Click(object sender, EventArgs e)
        {
            DialogResult deleteForSure = MessageBox.Show("Biztosan törli?", "Törlés", MessageBoxButtons.YesNo);
            if (deleteForSure == DialogResult.Yes)
            {
                string abilityName = kepessegekListBox.Items[kepessegekListBox.SelectedIndex].ToString();
                var kepessegtorles = conn.CreateCommand();
                kepessegtorles.CommandText = "delete from kepessegek where kepessegek.nev = @KKNev";
                kepessegtorles.Parameters.AddWithValue("@KKNev", abilityName);
                kepessegtorles.ExecuteNonQuery();
                harcosokKiir();

                if (kepessegekListBox.Items.Count > 0)
                {
                    kepessegekListBox.SelectedIndex = 0;
                    modositButton.Enabled = true;
                    torlesButton.Enabled = true;
                }
                else
                {
                    modositButton.Enabled = false;
                    torlesButton.Enabled = false;
                }
            }

        }

        private void modositButton_Click(object sender, EventArgs e)
        {
            string kepessegNev = kepessegekListBox.Items[kepessegekListBox.SelectedIndex].ToString();
            string ujleiras = leirasTextBox.Text;
            if (kepessegLeirasTextBox.Text == "" || kepessegLeirasTextBox == null)
            {
                MessageBox.Show("Nem maradhat üresen a leítás rész!");
            }
            else
            {
                DialogResult newDescription = MessageBox.Show("Biztosan módosítja?", "Módosítás", MessageBoxButtons.YesNo);
                if (newDescription == DialogResult.Yes)
                {
                    var leirasmodositas = conn.CreateCommand();
                    leirasmodositas.CommandText = "update kepessegek set leiras = @Ujleiras where nev = @KKNev";
                    leirasmodositas.Parameters.AddWithValue("@Ujleiras", ujleiras);
                    leirasmodositas.Parameters.AddWithValue("@KKNev", kepessegNev);
                    leirasmodositas.ExecuteNonQuery();
                    MessageBox.Show("Módosítva!");
                }
            }
        }
    }   

}
