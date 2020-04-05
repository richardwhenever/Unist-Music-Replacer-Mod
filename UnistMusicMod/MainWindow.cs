using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UnistMusicMod
{
    public partial class MainWindow : Form
    {
        #region Replacement Music
        public string AkatsukiThemeReplaceLocation { get; set; }
        public string ByakuyaThemeReplaceLocation { get; set; }
        public string CarmineThemeReplaceLocation { get; set; }
        public string ChaosThemeReplaceLocation { get; set; }
        public string EnkiduThemeReplaceLocation { get; set; }
        public string GordeauThemeReplaceLocation { get; set; }
        public string HildaThemeReplaceLocation { get; set; }
        public string HydeThemeReplaceLocation { get; set; }
        public string LinneThemeReplaceLocation { get; set; }
        public string LondrekiaThemeReplaceLocation { get; set; }
        public string MerkavaThemeReplaceLocation { get; set; }
        public string MikaThemeReplaceLocation { get; set; }
        public string NanaseThemeReplaceLocation { get; set; }
        public string OrieThemeReplaceLocation { get; set; }
        public string PhononThemeReplaceLocation { get; set; }
        public string SethThemeReplaceLocation { get; set; }
        public string EltnumThemeReplaceLocation { get; set; }
        public string VatistaThemeReplaceLocation { get; set; }
        public string WagnerThemeReplaceLocation { get; set; }
        public string WaldsteinThemeReplaceLocation { get; set; }
        public string YuzurihaThemeReplaceLocation { get; set; }

        public string HydeVsSethReplaceLocation { get; set; }
        public string GordeauVsChaosReplaceLocation { get; set; }
        public string LondrekiaVsWagnerReplaceLocation { get; set; }

        public string MainMenuReplaceLocation { get; set; }
        public string CharacterSelectReplaceLocation { get; set; }
        public string VsScreenReplaceLocation { get; set; }
        public string VictoryScreenReplaceLocation { get; set; }
        public string AccessConnectReplaceLocation { get; set; }
        public string ChroniclesReplaceLocation { get; set; }
        public string LatestOpeningReplaceLocation { get; set; }
        #endregion

        #region Original Music
        public string AkatsukiThemeOriginal { get; set; }
        public string ByakuyaThemeOriginal { get; set; }
        public string CarmineThemeOriginal { get; set; }
        public string ChaosThemeOriginal { get; set; }
        public string EnkiduThemeOriginal { get; set; }
        public string GordeauThemeOriginal { get; set; }
        public string HildaThemeOriginal { get; set; }
        public string HydeThemeOriginal { get; set; }
        public string LinneThemeOriginal { get; set; }
        public string LondrekiaThemeOriginal { get; set; }
        public string MerkavaThemeOriginal { get; set; }
        public string MikaThemeOriginal { get; set; }
        public string NanaseThemeOriginal { get; set; }
        public string OrieThemeOriginal { get; set; }
        public string PhononThemeOriginal { get; set; }
        public string SethThemeOriginal { get; set; }
        public string EltnumThemeOriginal { get; set; }
        public string VatistaThemeOriginal { get; set; }
        public string WagnerThemeOriginal { get; set; }
        public string WaldsteinThemeOriginal { get; set; }
        public string YuzurihaThemeOriginal { get; set; }        

        public string HydeVsSethOriginal { get; set; }
        public string GordeauVsChaosOriginal { get; set; }
        public string LondrekiaVsWagnerOriginal { get; set; }

        public string MainMenuOriginal { get; set; }
        public string CharacterSelectOriginal { get; set; }
        public string VsScreenOriginal { get; set; }
        public string VictoryScreenOriginal { get; set; }
        public string AccessConnectOriginal { get; set; }
        public string ChroniclesOriginal { get; set; }
        public string LatestOpeningOriginal { get; set; }
        #endregion

        public MainWindow()
        {            
            if (!Directory.Exists(@"d"))
            {
                System.Windows.Forms.MessageBox.Show("UnistMusicReplacer.exe doesn't seem to be placed in the right location. "
                    + Environment.NewLine
                    + "Please make sure UnistMusicReplacer.exe is in the root directory of UNIST."
                    + Environment.NewLine
                    + "EXAMPLE: \"C:\\Program Files\\Steam\\steamapps\\common\\UNDER NIGHT In-Birth Exe Late[st]\"");

                System.Windows.Forms.Application.Exit();
                System.Environment.Exit(1);
            }
            else
            {
                #region Initialize Original Music
                // Character Theme 1/3
                // ===================================

                var currentPath = "";
                var validationSuccess = true;

                if (!File.Exists(Environment.CurrentDirectory + @"\d\Anjf9qfloo6zfobZg"))
                {
                    System.Windows.Forms.MessageBox.Show("Could not locate Akatsuki's Music File. "
                        + Environment.NewLine
                        + "Refer to the \"OriginalMusicFilesDetail.txt\" to find "
                        + "which file you need to copy from the \\Backup folder to the \\d folder.");

                    System.Windows.Forms.Application.Exit();
                    validationSuccess = false;
                }
                else
                {
                    currentPath = Environment.CurrentDirectory + @"\d\Anjf9qfloo6zfobZg";
                    AkatsukiThemeOriginal = currentPath;
                }

                if (!File.Exists(Environment.CurrentDirectory + @"\d\moassNsyootdo13Nk"))
                {
                    System.Windows.Forms.MessageBox.Show("Could not locate Byakukya's Music File. "
                        + Environment.NewLine
                        + "Refer to the \"OriginalMusicFilesDetail.txt\" to find "
                        + "which file you need to copy from the \\Backup folder to the \\d folder.");

                    System.Windows.Forms.Application.Exit();
                    validationSuccess = false;
                }
                else
                {
                    currentPath = Environment.CurrentDirectory + @"\d\moassNsyootdo13Nk";
                    ByakuyaThemeOriginal = currentPath;
                }

                if (!File.Exists(Environment.CurrentDirectory + @"\d\VwolaulogabioaW30"))
                {
                    System.Windows.Forms.MessageBox.Show("Could not locate Carmine's Music File. "
                        + Environment.NewLine
                        + "Refer to the \"OriginalMusicFilesDetail.txt\" to find "
                        + "which file you need to copy from the \\Backup folder to the \\d folder.");

                    System.Windows.Forms.Application.Exit();
                    validationSuccess = false;
                }
                else
                {
                    currentPath = Environment.CurrentDirectory + @"\d\VwolaulogabioaW30";
                    CarmineThemeOriginal = currentPath;
                }

                if (!File.Exists(Environment.CurrentDirectory + @"\d\Angf0qfloo6zfobBg"))
                {
                    System.Windows.Forms.MessageBox.Show("Could not locate Chaos's Music File. "
                        + Environment.NewLine
                        + "Refer to the \"OriginalMusicFilesDetail.txt\" to find "
                        + "which file you need to copy from the \\Backup folder to the \\d folder.");

                    System.Windows.Forms.Application.Exit();
                    validationSuccess = false;
                }
                else
                {
                    currentPath = Environment.CurrentDirectory + @"\d\Angf0qfloo6zfobBg";
                    ChaosThemeOriginal = currentPath;
                }

                if (!File.Exists(Environment.CurrentDirectory + @"\d\Ndos1Qyftoos1soxa"))
                {
                    System.Windows.Forms.MessageBox.Show("Could not locate Eltnum's Music File. "
                        + Environment.NewLine
                        + "Refer to the \"OriginalMusicFilesDetail.txt\" to find "
                        + "which file you need to copy from the \\Backup folder to the \\d folder.");

                    System.Windows.Forms.Application.Exit();
                    validationSuccess = false;
                }
                else
                {
                    currentPath = Environment.CurrentDirectory + @"\d\Ndos1Qyftoos1soxa";
                    EltnumThemeOriginal = currentPath;
                }

                if (!File.Exists(Environment.CurrentDirectory + @"\d\Y26odBohddleojkzo"))
                {
                    System.Windows.Forms.MessageBox.Show("Could not locate Enkidu's Music File. "
                        + Environment.NewLine
                        + "Refer to the \"OriginalMusicFilesDetail.txt\" to find "
                        + "which file you need to copy from the \\Backup folder to the \\d folder.");

                    System.Windows.Forms.Application.Exit();
                    validationSuccess = false;
                }
                else
                {
                    currentPath = Environment.CurrentDirectory + @"\d\Y26odBohddleojkzo";
                    EnkiduThemeOriginal = currentPath;
                }

                if (!File.Exists(Environment.CurrentDirectory + @"\d\PoqUufocuavfouc05"))
                {
                    System.Windows.Forms.MessageBox.Show("Could not locate Gordeau's Music File. "
                        + Environment.NewLine
                        + "Refer to the \"OriginalMusicFilesDetail.txt\" to find "
                        + "which file you need to copy from the \\Backup folder to the \\d folder.");

                    System.Windows.Forms.Application.Exit();
                    validationSuccess = false;
                }
                else
                {
                    currentPath = Environment.CurrentDirectory + @"\d\PoqUufocuavfouc05";
                    GordeauThemeOriginal = currentPath;
                }

                if (!File.Exists(Environment.CurrentDirectory + @"\d\Tyeouzjo10Zadogyy"))
                {
                    System.Windows.Forms.MessageBox.Show("Could not locate Hilda's Music File. "
                        + Environment.NewLine
                        + "Refer to the \"OriginalMusicFilesDetail.txt\" to find "
                        + "which file you need to copy from the \\Backup folder to the \\d folder.");

                    System.Windows.Forms.Application.Exit();
                    validationSuccess = false;
                }
                else
                {
                    currentPath = Environment.CurrentDirectory + @"\d\Tyeouzjo10Zadogyy";
                    HildaThemeOriginal = currentPath;
                }

                // Character Theme 2/3
                // ===================================

                if (!File.Exists(Environment.CurrentDirectory + @"\d\Jukl0wpzoooPgooo0"))
                {
                    System.Windows.Forms.MessageBox.Show("Could not locate Hyde's Music File. "
                        + Environment.NewLine
                        + "Refer to the \"OriginalMusicFilesDetail.txt\" to find "
                        + "which file you need to copy from the \\Backup folder to the \\d folder.");

                    System.Windows.Forms.Application.Exit();
                    validationSuccess = false;
                }
                else
                {
                    currentPath = Environment.CurrentDirectory + @"\d\Jukl0wpzoooPgooo0";
                    HydeThemeOriginal = currentPath;
                }

                if (!File.Exists(Environment.CurrentDirectory + @"\d\U6oazEogzfbohzk5v"))
                {
                    System.Windows.Forms.MessageBox.Show("Could not locate Linne's Music File. "
                        + Environment.NewLine
                        + "Refer to the \"OriginalMusicFilesDetail.txt\" to find "
                        + "which file you need to copy from the \\Backup folder to the \\d folder.");

                    System.Windows.Forms.Application.Exit();
                    validationSuccess = false;
                }
                else
                {
                    currentPath = Environment.CurrentDirectory + @"\d\U6oazEogzfbohzk5v";
                    LinneThemeOriginal = currentPath;
                }

                if (!File.Exists(Environment.CurrentDirectory + @"\d\Ndos1Xyptoos8soza"))
                {
                    System.Windows.Forms.MessageBox.Show("Could not locate Londrekia's Music File. "
                        + Environment.NewLine
                        + "Refer to the \"OriginalMusicFilesDetail.txt\" to find "
                        + "which file you need to copy from the \\Backup folder to the \\d folder.");

                    System.Windows.Forms.Application.Exit();
                    validationSuccess = false;
                }
                else
                {
                    currentPath = Environment.CurrentDirectory + @"\d\Ndos1Xyptoos8soza";
                    LondrekiaThemeOriginal = currentPath;
                }

                if (!File.Exists(Environment.CurrentDirectory + @"\d\Glrohmwo51Rjwotll"))
                {
                    System.Windows.Forms.MessageBox.Show("Could not locate Merkava's Music File. "
                        + Environment.NewLine
                        + "Refer to the \"OriginalMusicFilesDetail.txt\" to find "
                        + "which file you need to copy from the \\Backup folder to the \\d folder.");

                    System.Windows.Forms.Application.Exit();
                    validationSuccess = false;
                }
                else
                {
                    currentPath = Environment.CurrentDirectory + @"\d\Glrohmwo51Rjwotll";
                    MerkavaThemeOriginal = currentPath;
                }

                if (!File.Exists(Environment.CurrentDirectory + @"\d\U6oazFodzfbohzk7v"))
                {
                    System.Windows.Forms.MessageBox.Show("Could not locate Mika's Music File. "
                        + Environment.NewLine
                        + "Refer to the \"OriginalMusicFilesDetail.txt\" to find "
                        + "which file you need to copy from the \\Backup folder to the \\d folder.");

                    System.Windows.Forms.Application.Exit();
                    validationSuccess = false;
                }
                else
                {
                    currentPath = Environment.CurrentDirectory + @"\d\U6oazFodzfbohzk7v";
                    MikaThemeOriginal = currentPath;
                }

                if (!File.Exists(Environment.CurrentDirectory + @"\d\zoassNsyootdo12Zm"))
                {
                    System.Windows.Forms.MessageBox.Show("Could not locate Nanase's Music File. "
                        + Environment.NewLine
                        + "Refer to the \"OriginalMusicFilesDetail.txt\" to find "
                        + "which file you need to copy from the \\Backup folder to the \\d folder.");

                    System.Windows.Forms.Application.Exit();
                    validationSuccess = false;
                }
                else
                {
                    currentPath = Environment.CurrentDirectory + @"\d\zoassNsyootdo12Zm";
                    NanaseThemeOriginal = currentPath;
                }

                if (!File.Exists(Environment.CurrentDirectory + @"\d\Jukq4wpzoooWzooo0"))
                {
                    System.Windows.Forms.MessageBox.Show("Could not locate Orie's Music File. "
                        + Environment.NewLine
                        + "Refer to the \"OriginalMusicFilesDetail.txt\" to find "
                        + "which file you need to copy from the \\Backup folder to the \\d folder.");

                    System.Windows.Forms.Application.Exit();
                    validationSuccess = false;
                }
                else
                {
                    currentPath = Environment.CurrentDirectory + @"\d\Jukq4wpzoooWzooo0";
                    OrieThemeOriginal = currentPath;
                }

                if (!File.Exists(Environment.CurrentDirectory + @"\d\PoqDufocuavcouv24"))
                {
                    System.Windows.Forms.MessageBox.Show("Could not locate Phonon's Music File. "
                        + Environment.NewLine
                        + "Refer to the \"OriginalMusicFilesDetail.txt\" to find "
                        + "which file you need to copy from the \\Backup folder to the \\d folder.");

                    System.Windows.Forms.Application.Exit();
                    validationSuccess = false;
                }
                else
                {
                    currentPath = Environment.CurrentDirectory + @"\d\PoqDufocuavcouv24";
                    PhononThemeOriginal = currentPath;
                }

                if (!File.Exists(Environment.CurrentDirectory + @"\d\Zomero0aeceokQpf8"))
                {
                    System.Windows.Forms.MessageBox.Show("Could not locate Seth's Music File. "
                        + Environment.NewLine
                        + "Refer to the \"OriginalMusicFilesDetail.txt\" to find "
                        + "which file you need to copy from the \\Backup folder to the \\d folder.");

                    System.Windows.Forms.Application.Exit();
                    validationSuccess = false;
                }
                else
                {
                    currentPath = Environment.CurrentDirectory + @"\d\Zomero0aeceokQpf8";
                    SethThemeOriginal = currentPath;
                }

                // Character Theme 3/3
                // ===================================

                if (!File.Exists(Environment.CurrentDirectory + @"\d\oyqqLqwomrbo07Fkd"))
                {
                    System.Windows.Forms.MessageBox.Show("Could not locate Vatista's Music File. "
                        + Environment.NewLine
                        + "Refer to the \"OriginalMusicFilesDetail.txt\" to find "
                        + "which file you need to copy from the \\Backup folder to the \\d folder.");

                    System.Windows.Forms.Application.Exit();
                    validationSuccess = false;
                }
                else
                {
                    currentPath = Environment.CurrentDirectory + @"\d\oyqqLqwomrbo07Fkd";
                    VatistaThemeOriginal = currentPath;
                }

                if (!File.Exists(Environment.CurrentDirectory + @"\d\Y16odTodddleojxzo"))
                {
                    System.Windows.Forms.MessageBox.Show("Could not locate Wagner's Music File. "
                        + Environment.NewLine
                        + "Refer to the \"OriginalMusicFilesDetail.txt\" to find "
                        + "which file you need to copy from the \\Backup folder to the \\d folder.");

                    System.Windows.Forms.Application.Exit();
                    validationSuccess = false;
                }
                else
                {
                    currentPath = Environment.CurrentDirectory + @"\d\Y16odTodddleojxzo";
                    WagnerThemeOriginal = currentPath;
                }

                if (!File.Exists(Environment.CurrentDirectory + @"\d\Y75odToiddleojxzo"))
                {
                    System.Windows.Forms.MessageBox.Show("Could not locate Waldstein's Music File. "
                        + Environment.NewLine
                        + "Refer to the \"OriginalMusicFilesDetail.txt\" to find "
                        + "which file you need to copy from the \\Backup folder to the \\d folder.");

                    System.Windows.Forms.Application.Exit();
                    validationSuccess = false;
                }
                else
                {
                    currentPath = Environment.CurrentDirectory + @"\d\Y75odToiddleojxzo";
                    WaldsteinThemeOriginal = currentPath;
                }

                if (!File.Exists(Environment.CurrentDirectory + @"\d\V9aSgloiawoto0boa"))
                {
                    System.Windows.Forms.MessageBox.Show("Could not locate Yuzuriha's Music File. "
                        + Environment.NewLine
                        + "Refer to the \"OriginalMusicFilesDetail.txt\" to find "
                        + "which file you need to copy from the \\Backup folder to the \\d folder.");

                    System.Windows.Forms.Application.Exit();
                    validationSuccess = false;
                }
                else
                {
                    currentPath = Environment.CurrentDirectory + @"\d\V9aSgloiawoto0boa";
                    LondrekiaVsWagnerOriginal = currentPath;
                }

                if (!File.Exists(Environment.CurrentDirectory + @"\d\Jouokpzo72Eioodao74Tvlowoo"))
                {
                    System.Windows.Forms.MessageBox.Show("Could not locate Londrekia vs Wagner's Music File. "
                        + Environment.NewLine
                        + "Refer to the \"OriginalMusicFilesDetail.txt\" to find "
                        + "which file you need to copy from the \\Backup folder to the \\d folder.");

                    System.Windows.Forms.Application.Exit();
                    validationSuccess = false;
                }
                else
                {
                    currentPath = Environment.CurrentDirectory + @"\d\Jouokpzo72Eioodao74Tvlowoo";
                    YuzurihaThemeOriginal = currentPath;
                }

                if (!File.Exists(Environment.CurrentDirectory + @"\d\Lqwomrbo66Rinofco64Codoyqq"))
                {
                    System.Windows.Forms.MessageBox.Show("Could not locate Hyde Vs Seth's Music File. "
                        + Environment.NewLine
                        + "Refer to the \"OriginalMusicFilesDetail.txt\" to find "
                        + "which file you need to copy from the \\Backup folder to the \\d folder.");

                    System.Windows.Forms.Application.Exit();
                    validationSuccess = false;
                }
                else
                {
                    currentPath = Environment.CurrentDirectory + @"\d\Lqwomrbo66Rinofco64Codoyqq";
                    HydeVsSethOriginal = currentPath;
                }

                if (!File.Exists(Environment.CurrentDirectory + @"\d\osdo0tSod5oayo5et1oOsmNahs"))
                {
                    System.Windows.Forms.MessageBox.Show("Could not locate Gordeau Vs Chaos's Music File. "
                        + Environment.NewLine
                        + "Refer to the \"OriginalMusicFilesDetail.txt\" to find "
                        + "which file you need to copy from the \\Backup folder to the \\d folder.");

                    System.Windows.Forms.Application.Exit();
                    validationSuccess = false;
                }
                else
                {
                    currentPath = Environment.CurrentDirectory + @"\d\osdo0tSod5oayo5et1oOsmNahs";
                    GordeauVsChaosOriginal = currentPath;
                }

                // Miscallaneous
                // ===================================

                if (!File.Exists(Environment.CurrentDirectory + @"\d\myHoussyomgometo"))
                {
                    System.Windows.Forms.MessageBox.Show("Could not locate Main Menu's Music File. "
                        + Environment.NewLine
                        + "Refer to the \"OriginalMusicFilesDetail.txt\" to find "
                        + "which file you need to copy from the \\Backup folder to the \\d folder.");

                    System.Windows.Forms.Application.Exit();
                    validationSuccess = false;
                }
                else
                {
                    currentPath = Environment.CurrentDirectory + @"\d\myHoussyomgometo";
                    MainMenuOriginal = currentPath;
                }

                if (!File.Exists(Environment.CurrentDirectory + @"\d\Lqwocicomrbcovomdoyqq"))
                {
                    System.Windows.Forms.MessageBox.Show("Could not locate Character Select's Music File. "
                        + Environment.NewLine
                        + "Refer to the \"OriginalMusicFilesDetail.txt\" to find "
                        + "which file you need to copy from the \\Backup folder to the \\d folder.");

                    System.Windows.Forms.Application.Exit();
                    validationSuccess = false;
                }
                else
                {
                    currentPath = Environment.CurrentDirectory + @"\d\Lqwocicomrbcovomdoyqq";
                    CharacterSelectOriginal = currentPath;
                }

                if (!File.Exists(Environment.CurrentDirectory + @"\d\maggmsiopVxyoiomaa"))
                {
                    System.Windows.Forms.MessageBox.Show("Could not locate Versus Screen's Music File. "
                        + Environment.NewLine
                        + "Refer to the \"OriginalMusicFilesDetail.txt\" to find "
                        + "which file you need to copy from the \\Backup folder to the \\d folder.");

                    System.Windows.Forms.Application.Exit();
                    validationSuccess = false;
                }
                else
                {
                    currentPath = Environment.CurrentDirectory + @"\d\maggmsiopVxyoiomaa";
                    VsScreenOriginal = currentPath;
                }

                if (!File.Exists(Environment.CurrentDirectory + @"\d\Faskqmoqooskhkwcriw"))
                {
                    System.Windows.Forms.MessageBox.Show("Could not locate Victory Screen's Music File. "
                        + Environment.NewLine
                        + "Refer to the \"OriginalMusicFilesDetail.txt\" to find "
                        + "which file you need to copy from the \\Backup folder to the \\d folder.");

                    System.Windows.Forms.Application.Exit();
                    validationSuccess = false;
                }
                else
                {
                    currentPath = Environment.CurrentDirectory + @"\d\Faskqmoqooskhkwcriw";
                    VictoryScreenOriginal = currentPath;
                }

                if (!File.Exists(Environment.CurrentDirectory + @"\d\Ewqvjpruhjzjbroovno"))
                {
                    System.Windows.Forms.MessageBox.Show("Could not locate Network Menu's Music File. "
                        + Environment.NewLine
                        + "Refer to the \"OriginalMusicFilesDetail.txt\" to find "
                        + "which file you need to copy from the \\Backup folder to the \\d folder.");

                    System.Windows.Forms.Application.Exit();
                    validationSuccess = false;
                }
                else
                {
                    currentPath = Environment.CurrentDirectory + @"\d\Ewqvjpruhjzjbroovno";
                    AccessConnectOriginal = currentPath;
                }

                if (!File.Exists(Environment.CurrentDirectory + @"\d\Hmsoyeyoinxutoirkoumm"))
                {
                    System.Windows.Forms.MessageBox.Show("Could not locate Chronicle Menu's Music File. "
                        + Environment.NewLine
                        + "Refer to the \"OriginalMusicFilesDetail.txt\" to find "
                        + "which file you need to copy from the \\Backup folder to the \\d folder.");

                    System.Windows.Forms.Application.Exit();
                    validationSuccess = false;
                }
                else
                {
                    currentPath = Environment.CurrentDirectory + @"\d\Hmsoyeyoinxutoirkoumm";
                    ChroniclesOriginal = currentPath;
                }

                if (!File.Exists(Environment.CurrentDirectory + @"\d\gknorqooqZslmeeaem"))
                {
                    System.Windows.Forms.MessageBox.Show("Could not locate Unknown Actor EXE:Late[st] Opening Theme's Music File. "
                        + Environment.NewLine
                        + "Refer to the \"OriginalMusicFilesDetail.txt\" to find "
                        + "which file you need to copy from the \\Backup folder to the \\d folder.");

                    System.Windows.Forms.Application.Exit();
                    validationSuccess = false;
                }
                else
                {
                    currentPath = Environment.CurrentDirectory + @"\d\gknorqooqZslmeeaem";
                    LatestOpeningOriginal = currentPath;
                }

                #endregion

                if (validationSuccess)
                {
                    InitializeComponent();
                }   
                else
                {
                    System.Windows.Forms.Application.Exit();
                    System.Environment.Exit(1);
                }
            }                        
        }

        private void replaceMusicButton_Click(object sender, EventArgs e)
        {
            replaceMusicButton.Text = "Replacing....";
            replaceMusicButton.Enabled = false;
            var songList = new List<string>();

            #region Character Themes 1/3
            if (AkatsukiThemeReplaceLocation != null)
            {
                System.IO.File.Copy(AkatsukiThemeReplaceLocation, AkatsukiThemeOriginal, true);
                songList.Add("Open War -Again- (Akatsuki's Theme) : " + AkatsukiThemeReplaceLocation.Split('\\').Last());
            }
            else
            {
                songList.Add("Open War -Again- (Akatsuki's Theme) : Unchanged");
            }
                
            if (ByakuyaThemeReplaceLocation != null)
            {
                System.IO.File.Copy(ByakuyaThemeReplaceLocation, ByakuyaThemeOriginal, true);
                songList.Add("Beat Eat Nest (Byakuya's Theme) : " + ByakuyaThemeReplaceLocation.Split('\\').Last());
            }
            else
            {
                songList.Add("Beat Eat Nest (Byakuya's Theme) : Unchanged");
            }
                
            if (CarmineThemeReplaceLocation != null)
            {
                System.IO.File.Copy(CarmineThemeReplaceLocation, CarmineThemeOriginal, true);
                songList.Add("Bad Surface (Carmine's Theme) : " + CarmineThemeReplaceLocation.Split('\\').Last());
            }
            else
            {
                songList.Add("Bad Surface (Carmine's Theme) : Unchanged");
            }
                
            if (ChaosThemeReplaceLocation != null)
            {
                System.IO.File.Copy(ChaosThemeReplaceLocation, ChaosThemeOriginal, true);
                songList.Add("Erudite Eye (Chaos's Theme) : " + ChaosThemeReplaceLocation.Split('\\').Last());
            }
            else
            {
                songList.Add("Erudite Eye (Chaos's Theme) : Unchanged");
            }

            if (EltnumThemeReplaceLocation != null)
            {
                System.IO.File.Copy(EltnumThemeReplaceLocation, EltnumThemeOriginal, true);
                songList.Add("Blood Drain -Again- (Eltnum's Theme) : " + EltnumThemeReplaceLocation.Split('\\').Last());
            }
            else
            {
                songList.Add("Blood Drain -Again- (Eltnum's Theme) : Unchanged");
            }
                
            if (EnkiduThemeReplaceLocation != null)
            {
                System.IO.File.Copy(EnkiduThemeReplaceLocation, EnkiduThemeOriginal, true);
                songList.Add("Extreme Stream (Enkidu's Theme) : " + EnkiduThemeReplaceLocation.Split('\\').Last());
            }
            else
            {
                songList.Add("Extreme Stream (Enkidu's Theme) : Unchanged");
            }
                
            if (GordeauThemeReplaceLocation != null)
            {
                System.IO.File.Copy(GordeauThemeReplaceLocation, GordeauThemeOriginal, true);
                songList.Add("Rushing Heart (Gordeau's Theme) : " + GordeauThemeReplaceLocation.Split('\\').Last());
            }
            else
            {
                songList.Add("Rushing Heart (Gordeau's Theme) : Unchanged");
            }
                
            if (HildaThemeReplaceLocation != null)
            {
                System.IO.File.Copy(HildaThemeReplaceLocation, HildaThemeOriginal, true);
                songList.Add("Overwhelm Despair (Hilda's Theme) : " + HildaThemeReplaceLocation.Split('\\').Last());
            }
            else
            {
                songList.Add("Overwhelm Despair (Hilda's Theme) : Unchanged");
            }
            #endregion

            #region Character Themes 2/3
            if (HydeThemeReplaceLocation != null)
            {
                System.IO.File.Copy(HydeThemeReplaceLocation, HydeThemeOriginal, true);
                songList.Add("Scraper Sky High (Hyde's Theme) : " + HydeThemeReplaceLocation.Split('\\').Last());
            }
            else
            {
                songList.Add("Scraper Sky High (Hyde's Theme) : Unchanged");
            }
                
            if (LinneThemeReplaceLocation != null)
            {
                System.IO.File.Copy(LinneThemeReplaceLocation, LinneThemeOriginal, true);
                songList.Add("Night Walker (Linne's Theme) : " + LinneThemeReplaceLocation.Split('\\').Last());
            }
            else
            {
                songList.Add("Night Walker (Linne's Theme) : Unchanged");
            }

            if (LondrekiaThemeReplaceLocation != null)
            {
                System.IO.File.Copy(LondrekiaThemeReplaceLocation, LondrekiaThemeOriginal, true);
                songList.Add("Icefield White Night (Londrekia Theme) : " + LondrekiaThemeReplaceLocation.Split('\\').Last());
            }
            else
            {
                songList.Add("Icefield White Night (Londrekia Theme) : Unchanged");
            }

            if (MerkavaThemeReplaceLocation != null)
            {
                System.IO.File.Copy(MerkavaThemeReplaceLocation, MerkavaThemeOriginal, true);
                songList.Add("Unseen Entities (Merkava's Theme) : " + MerkavaThemeReplaceLocation.Split('\\').Last());
            }
            else
            {
                songList.Add("Unseen Entities (Merkava's Theme) : Unchanged");
            }
                
            if (MikaThemeReplaceLocation != null)
            {
                System.IO.File.Copy(MikaThemeReplaceLocation, MikaThemeOriginal, true);
                songList.Add("Forceful Step (Mika's Theme) : " + MikaThemeReplaceLocation.Split('\\').Last());
            }
            else
            {
                songList.Add("Forceful Step (Mika's Theme) : Unchanged");
            }
                
            if (NanaseThemeReplaceLocation != null)
            {
                System.IO.File.Copy(NanaseThemeReplaceLocation, NanaseThemeOriginal, true);
                songList.Add("Gallant Girl ~Blowing Wind that Flows from the Sky~(Nanase Theme) : " + NanaseThemeReplaceLocation.Split('\\').Last());
            }
            else
            {
                songList.Add("Gallant Girl ~Blowing Wind that Flows from the Sky~(Nanase Theme) : Unchanged");
            }
                
            if (OrieThemeReplaceLocation != null)
            {
                System.IO.File.Copy(OrieThemeReplaceLocation, OrieThemeOriginal, true);
                songList.Add("Purity & Strictly (Orie's Theme) : " + OrieThemeReplaceLocation.Split('\\').Last());
            }
            else
            {
                songList.Add("Purity & Strictly (Orie's Theme) : Unchanged");
            }
                
            if (PhononThemeReplaceLocation != null)
            {
                System.IO.File.Copy(PhononThemeReplaceLocation, PhononThemeOriginal, true);
                songList.Add("Sounds of Night Wind (Phonon Theme) : " + PhononThemeReplaceLocation.Split('\\').Last());
            }
            else
            {
                songList.Add("Sounds of Night Wind (Phonon Theme) : Unchanged");
            }
                
            if (SethThemeReplaceLocation != null)
            {
                System.IO.File.Copy(SethThemeReplaceLocation, SethThemeOriginal, true);
                songList.Add("Monochrome Memory (Seth's Theme) : " + SethThemeReplaceLocation.Split('\\').Last());
            }
            else
            {
                songList.Add("Monochrome Memory (Seth's Theme) : Unchanged");
            }
            #endregion

            #region Character Themes 3/3
            if (VatistaThemeReplaceLocation != null)
            {
                System.IO.File.Copy(VatistaThemeReplaceLocation, VatistaThemeOriginal, true);
                songList.Add("Snow Sisters (Vatista Theme) : " + VatistaThemeReplaceLocation.Split('\\').Last());
            }
            else
            {
                songList.Add("Snow Sisters (Vatista Theme) : Unchanged");
            }
                
            if (WagnerThemeReplaceLocation != null)
            {
                System.IO.File.Copy(WagnerThemeReplaceLocation, WagnerThemeOriginal, true);
                songList.Add("Flame & Destiny (Wagner's Theme) : " + WagnerThemeReplaceLocation.Split('\\').Last());
            }
            else
            {
                songList.Add("Flame & Destiny (Wagner's Theme) : Unchanged");
            }
                
            if (WaldsteinThemeReplaceLocation != null)
            {
                System.IO.File.Copy(WaldsteinThemeReplaceLocation, WaldsteinThemeOriginal, true);
                songList.Add("Maximize Power! (Waldstein's Theme) : " + WaldsteinThemeReplaceLocation.Split('\\').Last());
            }
            else
            {
                songList.Add("Maximize Power! (Waldstein's Theme) : Unchanged");
            }
                
            if (YuzurihaThemeReplaceLocation != null)
            {
                System.IO.File.Copy(YuzurihaThemeReplaceLocation, YuzurihaThemeOriginal, true);
                songList.Add("Moving Like A Blossoming Lily (Yuzuriha's Theme) : " + YuzurihaThemeReplaceLocation.Split('\\').Last());
            }
            else
            {
                songList.Add("Moving Like A Blossoming Lily (Yuzuriha's Theme) : Unchanged");
            }
                
            if (HydeVsSethReplaceLocation != null)
            {
                System.IO.File.Copy(HydeVsSethReplaceLocation, HydeVsSethOriginal, true);
                songList.Add("Mutual Situation(Hyde vs Seth) : " + HydeVsSethReplaceLocation.Split('\\').Last());
            }
            else
            {
                songList.Add("Mutual Situation(Hyde vs Seth) : Unchanged");
            }
                
            if (GordeauVsChaosReplaceLocation != null)
            {
                System.IO.File.Copy(GordeauVsChaosReplaceLocation, GordeauVsChaosOriginal, true);
                songList.Add("Cross Thought (Gordeau vs Chaos Theme) : " + GordeauVsChaosReplaceLocation.Split('\\').Last());
            }
            else
            {
                songList.Add("Cross Thought (Gordeau vs Chaos Theme) : Unchanged");
            }

            if (LondrekiaVsWagnerReplaceLocation != null)
            {
                System.IO.File.Copy(LondrekiaVsWagnerReplaceLocation, LondrekiaVsWagnerOriginal, true);
                songList.Add("Incompatible Relation (Londrekia vs Wagner Theme) : " + LondrekiaVsWagnerReplaceLocation.Split('\\').Last());
            }
            else
            {
                songList.Add("Incompatible Relation (Londrekia vs Wagner Theme) : Unchanged");
            }
            #endregion

            #region Miscellaneous
            if (MainMenuReplaceLocation != null)
            {
                System.IO.File.Copy(MainMenuReplaceLocation, MainMenuOriginal, true);
                songList.Add("Main Menu : " + MainMenuReplaceLocation.Split('\\').Last());
            }
            else
            {
                songList.Add("Main Menu : Unchanged");
            }
                
            if (CharacterSelectReplaceLocation != null)
            {
                System.IO.File.Copy(CharacterSelectReplaceLocation, CharacterSelectOriginal, true);
                songList.Add("Character Select : " + CharacterSelectReplaceLocation.Split('\\').Last());
            }
            else
            {
                songList.Add("Character Select : Unchanged");
            }
            
            if (VsScreenReplaceLocation != null)
            {
                System.IO.File.Copy(VsScreenReplaceLocation, VsScreenOriginal, true);
                songList.Add("Vs Screen : " + VsScreenReplaceLocation.Split('\\').Last());
            }
            else
            {
                songList.Add("Vs Screen : Unchanged");
            }
            
            if (VictoryScreenReplaceLocation != null)
            {
                System.IO.File.Copy(VictoryScreenReplaceLocation, VictoryScreenOriginal, true);
                songList.Add("Victory Screen : " + VictoryScreenReplaceLocation.Split('\\').Last());
            }
            else
            {
                songList.Add("Victory Screen : Unchanged");
            }
            
            if (ChroniclesReplaceLocation != null)
            {
                System.IO.File.Copy(ChroniclesReplaceLocation, ChroniclesOriginal, true);
                songList.Add("Chronicles Menu : " + ChroniclesReplaceLocation.Split('\\').Last());
            }
            else
            {
                songList.Add("Chronicles Menu : Unchanged");
            }
            
            if (AccessConnectReplaceLocation != null)
            {
                System.IO.File.Copy(AccessConnectReplaceLocation, AccessConnectOriginal, true);
                songList.Add("Access Connect(Network Menu) : " + AccessConnectReplaceLocation.Split('\\').Last());
            }
            else
            {
                songList.Add("Access Connect(Network Menu) : Unchanged");
            }

            if (LatestOpeningReplaceLocation != null)
            {
                System.IO.File.Copy(LatestOpeningReplaceLocation, LatestOpeningOriginal, true);
                songList.Add("Unknown Actor EXE:Late[st] Opening Theme : " + LatestOpeningReplaceLocation.Split('\\').Last());
            }
            else
            {
                songList.Add("Unknown Actor EXE:Late[st] Opening Theme : Unchanged");
            }
            #endregion


            if (!File.Exists("ModdedSongList.txt")) // If file does not exists
            {
                File.Create("ModdedSongList.txt").Close(); // Create file
                
            }
            else // If file already exists
            {
                 // Clear file
                //using (StreamWriter sw = File.AppendText("Song_List.txt"))
                //{
                //    sw.WriteLine("WRITE SOME TEXT"); // Write text to .txt file
                //}
            }

            var initialText = "";

            using (StreamReader sr = new StreamReader("ModdedSongList.txt"))
            {
                initialText = sr.ReadToEnd();
            }

            File.WriteAllText("ModdedSongList.txt", String.Empty);

            using (StreamWriter sw = File.AppendText("ModdedSongList.txt"))
            {

                sw.WriteLine(DateTime.Today.ToShortDateString());
                sw.WriteLine(Environment.NewLine);
                foreach (var song in songList)
                {
                    sw.WriteLine(song.ToString()); // Write text to .txt file
                }
                sw.WriteLine(Environment.NewLine);
                sw.WriteLine("==========================");
                sw.WriteLine(Environment.NewLine);

                sw.WriteLine(initialText);
                
            }

            replaceMusicButton.Text = "Replace The Music";
            replaceMusicButton.Enabled = true;

            System.Windows.Forms.MessageBox.Show("Music has been replaced. Refer to ModdedSongList.txt for all songs changed.");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
                       
        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        #region Character Themes 1/3
        private void akatsukiThemeButton_Click_1(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = openFileDialog.FileName;
                AkatsukiThemeReplaceLocation = file;
                akatsukiThemeFileLocation.Text = openFileDialog.FileName.ToString();
            }
        }

        private void byakuyaThemeButton_Click_1(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                //System.IO.File.Copy(openFileDialog.FileName, )
                var file = openFileDialog.FileName;
                ByakuyaThemeReplaceLocation = file;
                byakuyaThemeFileLocation.Text = openFileDialog.FileName.ToString();
            }
        }

        private void carmineThemeButton_Click_1(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                //System.IO.File.Copy(openFileDialog.FileName, )
                var file = openFileDialog.FileName;
                CarmineThemeReplaceLocation = file;
                carmineThemeFileLocation.Text = openFileDialog.FileName.ToString();
            }
        }

        private void chaosThemeButton_Click_1(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                //System.IO.File.Copy(openFileDialog.FileName, )
                var file = openFileDialog.FileName;
                ChaosThemeReplaceLocation = file;
                chaosThemeFileLocation.Text = openFileDialog.FileName.ToString();
            }
        }

        private void eltnumThemeButton_Click_1(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                //System.IO.File.Copy(openFileDialog.FileName, )
                var file = openFileDialog.FileName;
                EltnumThemeReplaceLocation = file;
                eltnumThemeFileLocation.Text = openFileDialog.FileName.ToString();
            }
        }

        private void enkiduThemeButton_Click_1(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                //System.IO.File.Copy(openFileDialog.FileName, )
                var file = openFileDialog.FileName;
                EnkiduThemeReplaceLocation = file;
                enkiduThemeFileLocation.Text = openFileDialog.FileName.ToString();
            }
        }

        private void gordeauThemeButton_Click_1(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                //System.IO.File.Copy(openFileDialog.FileName, )
                var file = openFileDialog.FileName;
                GordeauThemeReplaceLocation = file;
                gordeauThemeFileLocation.Text = openFileDialog.FileName.ToString();
            }
        }

        private void hildaThemeButton_Click_1(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                //System.IO.File.Copy(openFileDialog.FileName, )
                var file = openFileDialog.FileName;
                HildaThemeReplaceLocation = file;
                hildaThemeFileLocation.Text = openFileDialog.FileName.ToString();
            }
        }
        #endregion

        #region Character Theme 2/3
        private void hydeThemeButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog(); 
            if (result == DialogResult.OK) 
            {
                var file = openFileDialog.FileName;
                HydeThemeReplaceLocation = file;
                hydeThemeFileLocation.Text = openFileDialog.FileName.ToString();
            }
        }

        private void linneThemeButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = openFileDialog.FileName;
                LinneThemeReplaceLocation = file;
                linneThemeFileLocation.Text = openFileDialog.FileName.ToString();
            }
        }

        private void londrekiaThemeButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = openFileDialog.FileName;
                LondrekiaThemeReplaceLocation = file;
                londrekiaThemeFileLocation.Text = openFileDialog.FileName.ToString();
            }
        }

        private void merkavaThemeButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = openFileDialog.FileName;
                MerkavaThemeReplaceLocation = file;
                merkavaThemeFileLocation.Text = openFileDialog.FileName.ToString();
            }
        }

        private void mikaThemeButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = openFileDialog.FileName;
                MikaThemeReplaceLocation = file;
                mikaThemeFileLocation.Text = openFileDialog.FileName.ToString();
            }
        }

        private void nanaseThemeButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = openFileDialog.FileName;
                NanaseThemeReplaceLocation = file;
                nanaseThemeFileLocation.Text = openFileDialog.FileName.ToString();
            }
        }

        private void orieThemeButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = openFileDialog.FileName;
                OrieThemeReplaceLocation = file;
                orieThemeFileLocation.Text = openFileDialog.FileName.ToString();
            }
        }

        private void phononThemeButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = openFileDialog.FileName;
                PhononThemeReplaceLocation = file;
                phononThemeFileLocation.Text = openFileDialog.FileName.ToString();
            }
        }


        #endregion

        #region Character Themes 3/3
        private void sethThemeButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = openFileDialog.FileName;
                SethThemeReplaceLocation = file;
                sethThemeFileLocation.Text = openFileDialog.FileName.ToString();
            }
        }

        private void vatistaThemeButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = openFileDialog.FileName;
                VatistaThemeReplaceLocation = file;
                vatistaThemeFileLocation.Text = openFileDialog.FileName.ToString();
            }
        }

        private void wagnerThemeButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = openFileDialog.FileName;
                WagnerThemeReplaceLocation = file;
                wagnerThemeFileLocation.Text = openFileDialog.FileName.ToString();
            }
        }

        private void waldsteinThemeButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = openFileDialog.FileName;
                WaldsteinThemeReplaceLocation = file;
                waldsteinThemeFileLocation.Text = openFileDialog.FileName.ToString();
            }
        }

        private void yuzurihaThemeButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = openFileDialog.FileName;
                YuzurihaThemeReplaceLocation = file;
                yuzurihaThemeFileLocation.Text = openFileDialog.FileName.ToString();
            }
        }

        private void hydeVsSethThemeButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = openFileDialog.FileName;
                HydeVsSethReplaceLocation = file;
                londrekiaVsWagnerThemeFileLocation.Text = openFileDialog.FileName.ToString();
            }
        }

        private void gordeauVsChaosThemeButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = openFileDialog.FileName;
                GordeauVsChaosReplaceLocation = file;
                gordeauVsChaosThemeFileLocation.Text = openFileDialog.FileName.ToString();
            }
        }

        private void londrekiaVsWagnerThemeButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = openFileDialog.FileName;
                LondrekiaVsWagnerReplaceLocation = file;
                londrekiaVsWagnerThemeFileLocation.Text = openFileDialog.FileName.ToString();
            }
        }
        #endregion

        #region Miscellaneous


        private void mainMenuThemeButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = openFileDialog.FileName;
                MainMenuReplaceLocation = file;
                mainMenuThemeFileLocation.Text = openFileDialog.FileName.ToString();
            }
        }

        private void networkThemeButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = openFileDialog.FileName;
                AccessConnectReplaceLocation = file;
                networkThemeFileLocation.Text = openFileDialog.FileName.ToString();
            }
        }

        private void chroniclesThemeButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = openFileDialog.FileName;
                ChroniclesReplaceLocation = file;
                chroniclesThemeFileLocation.Text = openFileDialog.FileName.ToString();
            }
        }

        private void characterSelectThemeButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = openFileDialog.FileName;
                CharacterSelectReplaceLocation= file;
                characterSelectThemeFileLocation.Text = openFileDialog.FileName.ToString();
            }
        }

        private void versusThemeButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = openFileDialog.FileName;
                VsScreenReplaceLocation = file;
                versusThemeFileLocation.Text = openFileDialog.FileName.ToString();
            }
        }

        private void victoryThemeButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = openFileDialog.FileName;
                VictoryScreenReplaceLocation = file;
                victoryThemeFileLocation.Text = openFileDialog.FileName.ToString();
            }
        }

        private void latestOpeningButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();

            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var file = openFileDialog.FileName;
                LatestOpeningReplaceLocation = file;
                latestOpeningFileLocation.Text = openFileDialog.FileName.ToString();
            }
        }

        #endregion


    }
}
