using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Web.Script.Serialization;
using System.Threading;
using System.Globalization;
using System.Resources;

namespace PasGen {
    public partial class fMain : Form {
        public fMain() {
            InitializeComponent();

            Point pos = this.PointToScreen( lblMessage.Location );
            pos = lvPasswords.PointToClient( pos );
            lblMessage.Parent = lvPasswords;
            lblMessage.Location = pos;
            lblMessage.BackColor = System.Drawing.Color.Transparent;
            lblMessage.Visible = false;
        }

        public string strLanguage = "";
        public string[] strChars;

        public Random random = new Random();

        public System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();

        public ResourceManager resMan;
        public CultureInfo culInfo;

        private void fMain_Load( object sender, EventArgs e ) {
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;

            string strSettings = Properties.Settings.Default["settings"].ToString();
            if(strSettings.Length > 0) {
                strSettings = DecryptPassword( strSettings );

                settings settings = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<settings>( strSettings );

                cbLetterCapital.Checked = settings.LetterCapital;
                cbLetterLower.Checked = settings.LetterLower;
                cbNumber.Checked = settings.Number;
                cbSymbol.Checked = settings.Symbol;
                cbDubiousSymbol.Checked = settings.Dubious;
                cbSpecialChar.Checked = settings.Special;
                udCapitalLower.Value = (settings.CapitalLower > 0) ? (settings.CapitalLower):(1);
                udCapitalUpper.Value = (settings.CapitalUpper > 0) ? (settings.CapitalUpper) : (1);
                udLowerLower.Value = (settings.LowerLower > 0) ? (settings.LowerLower) : (1);
                udLowerUpper.Value = (settings.LowerUpper > 0) ? (settings.LowerUpper) : (1);
                udNumericLower.Value = (settings.NumericLower > 0) ? (settings.NumericLower) : (1);
                udNumericUpper.Value = (settings.NumericUpper > 0) ? (settings.NumericUpper) : (1);
                udSymbolLower.Value = (settings.SymbolLower > 0) ? (settings.SymbolLower) : (1);
                udSymbolUpper.Value = (settings.SymbolUpper > 0) ? (settings.SymbolUpper) : (1);
                udSpecialLower.Value = (settings.SpecialLower > 0) ? (settings.SpecialLower) : (1);
                udSpecialUpper.Value = (settings.SpecialUpper > 0) ? (settings.SpecialUpper) : (1);
                udPasswordLength.Value = (settings.PasswordLength > 0) ? (settings.PasswordLength) : (1);
                udPasswordQuantity.Value = (settings.PasswordQuantity > 0) ? (settings.PasswordQuantity) : (1);
                tbSpecialChars.Text = settings.SpecialChars;
                strLanguage = settings.Language;
            }

            if( strLanguage.Length == 0 ) {
                CultureInfo ci = CultureInfo.InstalledUICulture;

                if(ci.Name == "tr-TR") {
                    strLanguage = "tr";
                } else {
                    strLanguage = "en";
                }
            }

            switchLanguage();

            lvPasswords.SmallImageList = ilPassword;

            timer.Interval = 1000;
            timer.Tick += new EventHandler( timer_tick );
        }

        private void timer_tick( object sender, EventArgs e ) {
            lblMessage.Visible = false;
            timer.Enabled = false;
        }

        private void fMain_FormClosing( object sender, FormClosingEventArgs e ) {
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            string settings = serializer.Serialize( new {
                LetterCapital = cbLetterCapital.Checked,
                LetterLower = cbLetterLower.Checked,
                Number = cbNumber.Checked,
                Symbol = cbSymbol.Checked,
                Dubious = cbDubiousSymbol.Checked,
                Special = cbSpecialChar.Checked,
                CapitalLower = udCapitalLower.Value,
                CapitalUpper = udCapitalUpper.Value,
                LowerLower = udLowerLower.Value,
                LowerUpper = udLowerUpper.Value,
                NumericLower = udNumericLower.Value,
                NumericUpper = udNumericUpper.Value,
                SymbolLower = udSymbolLower.Value,
                SymbolUpper = udSymbolUpper.Value,
                SpecialLower = udSpecialLower.Value,
                SpecialUpper = udSpecialUpper.Value,
                PasswordLength = udPasswordLength.Value,
                PasswordQuantity = udPasswordQuantity.Value,
                SpecialChars = tbSpecialChars.Text,
                Language = strLanguage
            } );

            Properties.Settings.Default["settings"] = EncryptPassword( settings );
            Properties.Settings.Default.Save();
        }

        private void cb_CheckedChanged( object sender, EventArgs e ) {
            switch(((CheckBox) sender).Name) {
                case "cbLetterCapital":
                    if(cbLetterCapital.Checked) {
                        udCapitalLower.Enabled = true;
                        udCapitalUpper.Enabled = true;
                    } else {
                        udCapitalLower.Enabled = false;
                        udCapitalUpper.Enabled = false;
                    }
                break;

                case "cbLetterLower":
                    if(cbLetterLower.Checked) {
                        udLowerLower.Enabled = true;
                        udLowerUpper.Enabled = true;
                    } else {
                        udLowerLower.Enabled = false;
                        udLowerUpper.Enabled = false;
                    }
                break;

                case "cbNumber":
                    if(cbNumber.Checked) {
                        udNumericLower.Enabled = true;
                        udNumericUpper.Enabled = true;
                    } else {
                        udNumericLower.Enabled = false;
                        udNumericUpper.Enabled = false;
                    }
                break;

                case "cbSymbol":
                    if(cbSymbol.Checked) {
                        udSymbolLower.Enabled = true;
                        udSymbolUpper.Enabled = true;
                    } else {
                        udSymbolLower.Enabled = false;
                        udSymbolUpper.Enabled = false;
                    }
                break;

                case "cbSpecialChar":
                    if(cbSpecialChar.Checked) {
                        tbSpecialChars.Enabled = true;
                        if( tbSpecialChars.Text.Length > 0 ) {
                            udSpecialLower.Enabled = true;
                            udSpecialUpper.Enabled = true;
                        }
                    } else {
                        tbSpecialChars.Enabled = false;
                        udSpecialLower.Enabled = false;
                        udSpecialUpper.Enabled = false;
                    }
                break;
            }

            check_generate();
        }

        private void udUpDown_ValueChanged( object sender, EventArgs e ) {
            check_totalnumber();

            switch( ((NumericUpDown)sender).Name ) {
                case "udCapitalLower": if( udCapitalLower.Value > udCapitalUpper.Value ) { udCapitalUpper.Value = udCapitalLower.Value; } break;
                case "udCapitalUpper": if( udCapitalUpper.Value < udCapitalLower.Value ) { udCapitalLower.Value = udCapitalUpper.Value; } break;
                case "udLowerLower": if( udLowerLower.Value > udLowerUpper.Value ) { udLowerUpper.Value = udLowerLower.Value; } break;
                case "udLowerUpper": if( udLowerUpper.Value < udLowerLower.Value ) { udLowerLower.Value = udLowerUpper.Value; } break;
                case "udNumericLower": if(udNumericLower.Value > udNumericUpper.Value ) { udNumericUpper.Value = udNumericLower.Value; } break;
                case "udNumericUpper": if(udNumericUpper.Value < udNumericLower.Value ) { udNumericLower.Value = udNumericUpper.Value; } break;
                case "udSymbolLower": if(udSymbolLower.Value > udSymbolUpper.Value) { udSymbolUpper.Value = udSymbolLower.Value; } break;
                case "udSymbolUpper": if(udSymbolUpper.Value < udSymbolLower.Value) { udSymbolLower.Value = udSymbolUpper.Value; } break;
            }
        }

        private void btnGenerate_Click( object sender, EventArgs e ) {
            int iPassLength = Convert.ToInt32( udPasswordLength.Value );

            if( cbDubiousSymbol.Checked ) {
                strChars = new string[] { "ABCDEFGHJKLMNPQRSTUVWXYZ", "abcdefghjkmnpqrstuvwxyz", "23456789", "%&?#$*", tbSpecialChars.Text };
            } else {
                strChars = new string[] { "ABCDEFGHIJKLMNOPQRSTUVWXYZ", "abcdefghijklmnopqrstuvwxyz", "0123456789", "!+%&/()=?-#$*_,;`", tbSpecialChars.Text };
            }

            int[,] iSettings = new int[5, 3];
            if( cbLetterCapital.Checked ) {
                iSettings[0, 0] = Convert.ToInt32( udCapitalLower.Value );
                iSettings[0, 1] = Convert.ToInt32( udCapitalUpper.Value );
            } else {
                iSettings[0, 0] = 0;
                iSettings[0, 1] = 0;
            }

            if(cbLetterLower.Checked) {
                iSettings[1, 0] = Convert.ToInt32( udLowerLower.Value );
                iSettings[1, 1] = Convert.ToInt32( udLowerUpper.Value );
            } else {
                iSettings[1, 0] = 0;
                iSettings[1, 1] = 0;
            }

            if(cbNumber.Checked) {
                iSettings[2, 0] = Convert.ToInt32( udNumericLower.Value );
                iSettings[2, 1] = Convert.ToInt32( udNumericUpper.Value );
            } else {
                iSettings[2, 0] = 0;
                iSettings[2, 1] = 0;
            }

            if(cbSymbol.Checked) {
                iSettings[3, 0] = Convert.ToInt32( udSymbolLower.Value );
                iSettings[3, 1] = Convert.ToInt32( udSymbolUpper.Value );
            } else {
                iSettings[3, 0] = 0;
                iSettings[3, 1] = 0;
            }

            if(cbSpecialChar.Checked && tbSpecialChars.Text.Length > 0 ) {
                iSettings[4, 0] = Convert.ToInt32( udSpecialLower.Value );
                iSettings[4, 1] = Convert.ToInt32( udSpecialUpper.Value );
            } else {
                iSettings[4, 0] = 0;
                iSettings[4, 1] = 0;
            }

            for(int i = 0; i < udPasswordQuantity.Value; i++ ) {
                Thread t = new Thread( () => generatePassword( iPassLength, iSettings, random ) );
                t.IsBackground = true;
                t.Start();
            }
        }

        private void btnClear_Click( object sender, EventArgs e ) {
            lvPasswords.Items.Clear();

            btnClear.Enabled = false;
        }

        private void tsmCopy_Click( object sender, EventArgs e ) {
            if(lvPasswords.SelectedItems.Count > 0) {
                Clipboard.SetText( lvPasswords.SelectedItems[0].Text );

                send_message( resMan.GetString( "lblCoppiedtoClipboard", culInfo ) );
            }
        }

        private void generatePassword( int iPassLength, int[,] iSettings, Random random ) {
            char[] chrPassword = new char[ iPassLength ];

            iSettings[0, 2] = 0;
            iSettings[1, 2] = 0;
            iSettings[2, 2] = 0;
            iSettings[3, 2] = 0;
            iSettings[4, 2] = 0;

            int i = 0;
            int d = 0;
            for(; d < 5; d++ ) {
                if(iSettings[d,0] > 0 ) {
                    for(int j = 0; j < iSettings[d, 0]; j++, i++, iSettings[d, 2]++) {
                        chrPassword[i] = strChars[d].Substring( random.Next( strChars[d].Length ), 1 ).ToCharArray()[0];
                    }
                }
            }

            while( i < iPassLength) {
                d = random.Next( 5 );
                if( iSettings[d, 2] < iSettings[d, 1]) {
                    chrPassword[i] = strChars[d].Substring( random.Next( strChars[d].Length ), 1 ).ToCharArray()[0];

                    i++;
                    iSettings[d, 2]++;
                }
            }

            updateList( shuffle( chrPassword, random ) );
        }

        public void updateList( string strPassword ) {
            if(lvPasswords.InvokeRequired) {
                lvPasswords.BeginInvoke( (MethodInvoker) delegate () { updateList( strPassword ); } );
            } else {
                if( lvPasswords.Items.Count < 20 ) {
                    ListViewItem lv = lvPasswords.Items.Add( strPassword, "password" );
                } else {
                    send_message( resMan.GetString( "lblReachedtoMaximum", culInfo ) );
                }
                btnClear.Enabled = true;
            }
        }

        private void send_message( string strMessage ) {
            lblMessage.Text = strMessage;

            lblMessage.Visible = true;
            timer.Enabled = true;
        }

        private string shuffle( char[] chr, Random random ) {
            char value;
            int n = chr.Length;

            while(n > 1) {
                n--;
                int k = random.Next( n + 1 );
                value = chr[k];
                chr[k] = chr[n];
                chr[n] = value;
            }
            return new string( chr );
        }

        private void check_generate() {
            if(cbLetterCapital.Checked == false && cbLetterLower.Checked == false && cbNumber.Checked == false && cbSymbol.Checked == false && cbSpecialChar.Checked == false) {
                btnGenerate.Enabled = false;
            } else {
                btnGenerate.Enabled = true;
            }

            check_totalnumber();
        }

        private void check_totalnumber() {
            int iLowerTotal = 0;
            int iUpperTotal = 0;
            int iPassLenght = 0;

            if(cbLetterCapital.Checked) {
                iLowerTotal += Convert.ToInt32( udCapitalLower.Value );
                iUpperTotal += Convert.ToInt32( udCapitalUpper.Value );
            }

            if(cbLetterLower.Checked) {
                iLowerTotal += Convert.ToInt32( udLowerLower.Value );
                iUpperTotal += Convert.ToInt32( udLowerUpper.Value );
            }

            if(cbNumber.Checked) {
                iLowerTotal += Convert.ToInt32( udNumericLower.Value );
                iUpperTotal += Convert.ToInt32( udNumericUpper.Value );
            }

            if(cbSymbol.Checked) {
                iLowerTotal += Convert.ToInt32( udSymbolLower.Value );
                iUpperTotal += Convert.ToInt32( udSymbolUpper.Value );
            }

            if(cbSpecialChar.Checked) {
                iLowerTotal += Convert.ToInt32( udSpecialLower.Value );
                iUpperTotal += Convert.ToInt32( udSpecialUpper.Value );
            }

            iPassLenght = Convert.ToInt32( udPasswordLength.Value );

            if(iPassLenght >= iLowerTotal && iPassLenght <= iUpperTotal) {
                btnGenerate.Enabled = true;
            } else {
                btnGenerate.Enabled = false;
            }
        }

        private string EncryptPassword( string password ) {
            byte[] data = Encoding.UTF8.GetBytes( password );
            byte[] encrypted_data = ProtectedData.Protect( data, null, DataProtectionScope.CurrentUser );

            return Convert.ToBase64String( encrypted_data );
        }

        private string DecryptPassword( string password ) {
            if(password.Length > 0) {
                byte[] encrypted_data = Convert.FromBase64String( password );
                byte[] data = ProtectedData.Unprotect( encrypted_data, null, DataProtectionScope.CurrentUser );

                return Encoding.UTF8.GetString( data );
            }

            return "";
        }

        private void lvPasswords_SelectedIndexChanged( object sender, EventArgs e ) {
            if( lvPasswords.SelectedItems.Count > 0 ) {
                btnCopy.Enabled = true;
            } else {
                btnCopy.Enabled = false;
            }
        }

        private void tbSpecialChars_TextChanged( object sender, EventArgs e ) {
            if( tbSpecialChars.Text.Length > 0 && cbSpecialChar.Checked == true ) {
                udSpecialLower.Enabled = true;
                udSpecialUpper.Enabled = true;
            } else {
                udSpecialLower.Enabled = false;
                udSpecialUpper.Enabled = false;
            }
        }

        private void switchLanguage() {
            if(strLanguage == "tr") {
                culInfo = CultureInfo.CreateSpecificCulture( "tr" );
                turkishToolStripMenuItem.Checked = true;
                englishToolStripMenuItem.Checked = false;
            } else {
                culInfo = CultureInfo.CreateSpecificCulture( "en" );
                turkishToolStripMenuItem.Checked = false;
                englishToolStripMenuItem.Checked = true;
            }

            resMan = new ResourceManager( "PasGen.Resource.Res", typeof( fMain ).Assembly );

            this.Text = resMan.GetString( "mainForm_Text", culInfo );
            gbSettingsGeneral.Text = resMan.GetString( "gbSettingsGeneral_Text", culInfo );

            cbLetterCapital.Text = resMan.GetString( "cbLetterCapital_Text", culInfo );
            cbLetterLower.Text = resMan.GetString( "cbLetterLower_Text", culInfo );
            cbNumber.Text = resMan.GetString( "cbNumber_Text", culInfo );
            cbSymbol.Text = resMan.GetString( "cbSymbol_Text", culInfo );
            cbDubiousSymbol.Text = resMan.GetString( "cbDubiousSymbol_Text", culInfo );

            btnGenerate.Text = resMan.GetString( "btnGenerate_Text", culInfo );
            btnCopy.Text = resMan.GetString( "btnCopy_Text", culInfo );
            btnClear.Text = resMan.GetString( "btnClear_Text", culInfo );

            ttMain.SetToolTip( cbSymbol, resMan.GetString( "cbSymbol_Hint", culInfo ) );
            ttMain.SetToolTip( cbDubiousSymbol, resMan.GetString( "cbDubiousSymbol_Hint", culInfo ) );

            tsmCopy.Text = btnCopy.Text;

            exitToolStripMenuItem.Text = resMan.GetString( "exitToolStripMenuItem_Text", culInfo );
            languageToolStripMenuItem.Text = resMan.GetString( "languageToolStripMenuItem_Text", culInfo );

            lblPasswordLentgh.Text = resMan.GetString( "udPasswordLength_Text", culInfo );
            lblPasswordQuantity.Text = resMan.GetString( "udPasswordQuantity_Text", culInfo );
            label1.Text = resMan.GetString( "udTo_Text", culInfo );
            label2.Text = label1.Text;
            label3.Text = label1.Text;
            label4.Text = label1.Text;
            label5.Text = label1.Text;
        }

        private void exitToolStripMenuItem_Click( object sender, EventArgs e ) {
            if(System.Windows.Forms.Application.MessageLoop) {
                System.Windows.Forms.Application.Exit();
            } else {
                System.Environment.Exit( 1 );
            }
        }

        private void turkishToolStripMenuItem_Click( object sender, EventArgs e ) {
            switch(((ToolStripMenuItem) sender).Text) {
                case "Türkçe":
                    strLanguage = "tr";
                break;

                case "English":
                    strLanguage = "en";
                break;

                default:
                    return;
            }

            switchLanguage();
        }

        private void lvPasswords_MouseDoubleClick( object sender, MouseEventArgs e ) {
            tsmCopy_Click( sender, e );
        }

        private void passwordsMenu_Opening( object sender, CancelEventArgs e ) {
            if( lvPasswords.Items.Count == 0 ) {
                e.Cancel = true;
            }
        }
    }

    public class settings {
        public bool LetterCapital { get; set; }
        public bool LetterLower { get; set; }
        public bool Number { get; set; }
        public bool Symbol { get; set; }
        public bool Dubious { get; set; }
        public bool Special { get; set; }
        public int CapitalLower { get; set; }
        public int CapitalUpper { get; set; }
        public int LowerLower { get; set; }
        public int LowerUpper { get; set; }
        public int NumericLower { get; set; }
        public int NumericUpper { get; set; }
        public int SymbolLower { get; set; }
        public int SymbolUpper { get; set; }
        public int SpecialLower { get; set; }
        public int SpecialUpper { get; set; }
        public int PasswordLength { get; set; }
        public int PasswordQuantity { get; set; }
        public string SpecialChars { get; set; }
        public string Language { get; set; }
    }
}
