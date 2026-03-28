using Animations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;



namespace Octo
{
    public partial class frmPlay : Form
    {
        public frmPlay(string Player1Name,string Player2Name, frmSplash frmSplash
                      ,bool IsVsAi,bool AiAnimaion,bool IsAivsAi,int AiPlaySpeed)
        {
            InitializeComponent();

            _Player1Name = Player1Name;
            _Player2Name = Player2Name;
            this.frmSplash = frmSplash;

            _IsVsAi = IsVsAi;
            _AiAnimation = AiAnimaion;
            _IsAiVsAi = IsAivsAi;
            _AiPlayspeed = AiPlaySpeed;
        }

        
        enum PlayerColor {Black,White}
        PlayerColor _PlayerColor = PlayerColor.White;

        byte _Steps = 1;

        List<Button> _BlackButtonsList = new List<Button>();
        List<Button> _WhiteButtonsList = new List<Button>();
        List<Point>  _BlackButtonsLocationsList = new List<Point>();
        List<Point>  _WhiteButtonsLocationsList = new List<Point>();

        PictureBox[,] _StepsHighlights = new PictureBox[8, 8];

        bool _IsPlayersEnabled = false;

        bool _isStartWhite = true;
        bool _isStartBlack = true;


        bool _IsVsAi = false;
        bool _AiAnimation = false;
        bool _IsAiVsAi = false;

        int _AiPlayspeed;

        bool _IsGameEnd = false;

        byte _TempNum = 0;
        byte _TempSecs = 0;
        Random _Random = new Random();

        byte _SkipSecs = 0;

        int Secs = 0;
        int Min = 0;
        int Hours = 0;

        frmSplash frmSplash;

        string _Player1Name;
        string _Player2Name;






        List<SoundPlayer> _BloblsSfxList = new List<SoundPlayer>();
        List<SoundPlayer> _RollSfxList = new List<SoundPlayer>();
        SoundPlayer _SkipSfx = new SoundPlayer (Properties.Resources.Hit_2);
        SoundPlayer _SkipFaildSfx = new SoundPlayer (Properties.Resources.Metal_1);



        //_______________________________________________________________________//
        private void frmMainGame_Paint(object sender, PaintEventArgs e)
        {


            Pen MyPen = new Pen(Color.FromArgb(188, 204, 220), 2);

            MyPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            MyPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;




            //الخط اليمين
            e.Graphics.DrawLine(MyPen, 1800, 50, 1800, 1050);
            //الخط الشمال
            e.Graphics.DrawLine(MyPen, 800, 50, 800, 1050);


            e.Graphics.DrawLine(MyPen, 800, 50, 1800, 50);
            e.Graphics.DrawLine(MyPen, 800, 1050, 1800, 1050);


            //الخطوط العريضه
            e.Graphics.DrawLine(MyPen, 800, 175, 1800, 175);
            e.Graphics.DrawLine(MyPen, 800, 300, 1800, 300);
            e.Graphics.DrawLine(MyPen, 800, 425, 1800, 425);
            e.Graphics.DrawLine(MyPen, 800, 550, 1800, 550);
            e.Graphics.DrawLine(MyPen, 800, 675, 1800, 675);
            e.Graphics.DrawLine(MyPen, 800, 800, 1800, 800);
            e.Graphics.DrawLine(MyPen, 800, 925, 1800, 925);


            e.Graphics.DrawLine(MyPen, 925, 50, 925, 1050);
            e.Graphics.DrawLine(MyPen, 1050, 50, 1050, 1050);
            e.Graphics.DrawLine(MyPen, 1175, 50, 1175, 1050);
            e.Graphics.DrawLine(MyPen, 1175, 50, 1175, 1050);
            e.Graphics.DrawLine(MyPen, 1300, 50, 1300, 1050);
            e.Graphics.DrawLine(MyPen, 1425, 50, 1425, 1050);
            e.Graphics.DrawLine(MyPen, 1550, 50, 1550, 1050);
            e.Graphics.DrawLine(MyPen, 1675, 50, 1675, 1050);

        }
        private void frmMainGame_Load(object sender, EventArgs e)
        {
            AddStepsHighlights();

            AddBlackButtinsToList();
            AddWhiteButtinsToList();
            TransparetObjects();
            LoadSounds();

            lpPlayer1.Text = _Player1Name;
            lpPlayer2.Text = _Player2Name;

            lpPlayerTurn.Text = $"White ( {_Player1Name} ) Turn";

            AiRollTimer.Interval = _AiPlayspeed;

            if (_IsAiVsAi)
            {
                btnRandomNum.Enabled = false;
                PlayAi();
            }

        }

        void LoadSounds()
        {
            //Blobs

            SoundPlayer blob1 = new SoundPlayer(Properties.Resources.Blob_1);
            _BloblsSfxList.Add(blob1);

            SoundPlayer blob2 = new SoundPlayer(Properties.Resources.Blob_2);
            _BloblsSfxList.Add(blob2);

            SoundPlayer blob3 = new SoundPlayer(Properties.Resources.Blob_3);
            _BloblsSfxList.Add(blob3);

            SoundPlayer blob4 = new SoundPlayer(Properties.Resources.Blob_4);
            _BloblsSfxList.Add(blob4);

            SoundPlayer blob5 = new SoundPlayer(Properties.Resources.Blob_5);
            _BloblsSfxList.Add(blob5);

            SoundPlayer blob6 = new SoundPlayer(Properties.Resources.blob_6);
            _BloblsSfxList.Add(blob6);

            SoundPlayer blob7 = new SoundPlayer(Properties.Resources.blob_7);
            _BloblsSfxList.Add(blob7);



            //Roll
            SoundPlayer Rool1 = new SoundPlayer(Properties.Resources.Retro_Ping);
            _RollSfxList.Add(Rool1);

            SoundPlayer Rool2 = new SoundPlayer(Properties.Resources.Retro_Ping_2);
            _RollSfxList.Add(Rool2);

            SoundPlayer Rool3 = new SoundPlayer(Properties.Resources.Retro_Ping_3);
            _RollSfxList.Add(Rool3);

        }

        void PlayBlobSfx()
        {
            _BloblsSfxList[_Random.Next(_BloblsSfxList.Count)].Play();
        }

        void PlayRollSfx()
        {
            _RollSfxList[_Random.Next(_RollSfxList.Count)].Play();
        }

        void TransparetObjects()
        {
            Animations.clsAnimation.Transparent(btnRestartGame, pbMainBtnsPanel);

            Animations.clsAnimation.Transparent(btnRandomNum, pbMainBtnsPanel);
            Animations.clsAnimation.Transparent(btnSkip, pbMainBtnsPanel);
            Animations.clsAnimation.Transparent(btnExit, pbMainBtnsPanel);
        }

        void AddStepsHighlights()
        {
            string name;
            
            for(int i = 0; i < 8 ; i++)
            {
                for(int j = 0; j < 8 ; j++)
                {
                    // = G 2|0
                    name = "G" + i + "I" + j;
                    PictureBox pb = this.Controls[name] as PictureBox;
                    if(pb != null)
                    _StepsHighlights[i,j] = pb;
                    else
                        MessageBox.Show("PictureBox not found: " + name);
                }
            }
        }
        void AddBlackButtinsToList()
        {
            _BlackButtonsList.Add(btnB0);
            _BlackButtonsList.Add(btnB1);
            _BlackButtonsList.Add(btnB2);
            _BlackButtonsList.Add(btnB3);
            _BlackButtonsList.Add(btnB4);
            _BlackButtonsList.Add(btnB5);
            _BlackButtonsList.Add(btnB6);
            _BlackButtonsList.Add(btnB7);

            _BlackButtonsLocationsList.Add(btnB0.Location);
            _BlackButtonsLocationsList.Add(btnB1.Location);
            _BlackButtonsLocationsList.Add(btnB2.Location);
            _BlackButtonsLocationsList.Add(btnB3.Location);
            _BlackButtonsLocationsList.Add(btnB4.Location);
            _BlackButtonsLocationsList.Add(btnB5.Location);
            _BlackButtonsLocationsList.Add(btnB6.Location);
            _BlackButtonsLocationsList.Add(btnB7.Location);
            
        }

        void AddWhiteButtinsToList()
        {
            _WhiteButtonsList.Add(btnW0);
            _WhiteButtonsList.Add(btnW1);
            _WhiteButtonsList.Add(btnW2);
            _WhiteButtonsList.Add(btnW3);
            _WhiteButtonsList.Add(btnW4);
            _WhiteButtonsList.Add(btnW5);
            _WhiteButtonsList.Add(btnW6);
            _WhiteButtonsList.Add(btnW7);

            _WhiteButtonsLocationsList.Add(btnW0.Location);
            _WhiteButtonsLocationsList.Add(btnW1.Location);
            _WhiteButtonsLocationsList.Add(btnW2.Location);
            _WhiteButtonsLocationsList.Add(btnW3.Location);
            _WhiteButtonsLocationsList.Add(btnW4.Location);
            _WhiteButtonsLocationsList.Add(btnW5.Location);
            _WhiteButtonsLocationsList.Add(btnW6.Location);
            _WhiteButtonsLocationsList.Add(btnW7.Location);

        }

        void AddStepsText(Button btn)
        {
            byte Num = Convert.ToByte(btn.Text);
            Num -= (byte)_Steps;
            btn.Text = Num.ToString();

        }

        void ChangePlayer()
        {
            if (_PlayerColor == PlayerColor.White)
            {
                _PlayerColor = PlayerColor.Black;
                lpPlayerTurn.Text = $"Black ( {_Player2Name} ) Turn";
                pbPlayTurnImage.Image = Properties.Resources.BlackPlayer_Plane;
            }
            else
            {
                _PlayerColor = PlayerColor.White;
                lpPlayerTurn.Text = $"White ( {_Player1Name} ) Turn";
                pbPlayTurnImage.Image = Properties.Resources.WhitePlayer_Plane;

            }

        }

        bool CheckIsBtnOnTheEnd(Button btn)
        {
           if (btn.Text == "0") 
           {
              ShowErorToPlayersSteps(btn);
              return true;
           }

            DeleteError();

            return false;

        }

        bool CheckCurrentStepsToMove(Button btn) //عشان اعرف هل اقدر اتحرك ولا العدد اللي جالي اكبر
        {
            if(Convert.ToByte(btn.Text) - _Steps >= 0)
                return true;

            if(!_IsVsAi)
                MessageBox.Show("This move is not possible.","Game Info",MessageBoxButtons.OK,MessageBoxIcon.Information
                ); return false;
        }

        bool CheckNextIsTherePlayer(Button btn)//عشان اشوف المكان اللي انا رايحه فيه لاعب ولا لا
        {
            //MyTag to check is im black or white
            string Tag = btn.Tag.ToString();


            //عشان اعرف انا في اي عمود
            byte BtnColNum = byte.Parse(Tag.Split(' ')[1]);
            //عشان اعرف انا في اي صف
            byte btnNum = Convert.ToByte(btn.Text);

            if (btn.Tag.ToString().Contains("W"))
            {
                //هنا بشوف هل المكان اللي هروحه فيه قطعه سوداولا لا
                //عن طريق اني اجيب قرم القطعةالسودا اللي بتساوي رقم القطعه البيضه
                if (_StepsHighlights[(btnNum - _Steps), BtnColNum].Bounds.IntersectsWith(_BlackButtonsList[BtnColNum].Bounds))
                {
                    //لو فيه لاعب , هشوف هو فين , لو هو في مكانه في الاول ما نعملش حاجه
                    if(_BlackButtonsList[BtnColNum].Text == "7")
                    {
                        MessageBox.Show("Enemy is in their home. Move not possible.", "Move Blocked", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return true;
                    }
                    //لو هو متحرك من مكانه , هنرجعه لي مكانه ف الاول وهنخلي اللاعب يروح المكان اللي كان عليه

                    //نبدل الاماكن و ندي تفاصيل
                    btn.Location = _BlackButtonsList[BtnColNum].Location;
                    PlayBlobSfx();
                    AddStepsText(btn);
                    ChangePlayer();
                    DisablePlayers();
                    CheckResluts(btn);

                    //مكان البداية , وتصفير بياناته
                    _BlackButtonsList[BtnColNum].Location = _BlackButtonsLocationsList[BtnColNum];
                    _BlackButtonsList[BtnColNum].Text = "7";

                    return true;
                }
            }
            else
            {
                //هنا بشوف هل المكان اللي هروحه فيه قطعه بيضه ولا لا
                //عن طريق اني اجيب احسبها من العكس وازود الخطوات
                if (_StepsHighlights[((7 - btnNum) + _Steps), BtnColNum].Bounds.IntersectsWith(_WhiteButtonsList[BtnColNum].Bounds))
                {
                    //اعمل بردو كل حاجه عملتها مع الاسود فوق
                    if (_WhiteButtonsList[BtnColNum].Text == "7")
                    {
                        MessageBox.Show("Enemy is in their home. Move not possible.","Move Blocked",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        return true;
                    }


                    btn.Location = _WhiteButtonsList[BtnColNum].Location;
                    PlayBlobSfx();
                    AddStepsText(btn);
                    ChangePlayer();
                    DisablePlayers();
                    CheckResluts(btn);

                    _WhiteButtonsList[BtnColNum].Location = _WhiteButtonsLocationsList[BtnColNum];
                    _WhiteButtonsList[BtnColNum].Text = "7";


                    return true;
                }
            }

                return false;
        }

        void AiPlayDeffultMove(Button btn)
        {
            if(_PlayerColor == PlayerColor.White)
                btn.Location = new Point(btn.Location.X, btn.Location.Y - (125 * _Steps));
            else
                btn.Location = new Point(btn.Location.X, btn.Location.Y + (125 * _Steps));

            PlayBlobSfx();
            AddStepsText(btn);
            ChangePlayer();
            DisablePlayers();
            CheckResluts(btn);

        }

        bool AiCheckNextIsTherePlayer(Button btn,ref bool Con)
        {
            //MyTag to check is im black or white
            string Tag = btn.Tag.ToString();


            //عشان اعرف انا في اي عمود
            byte BtnColNum = byte.Parse(Tag.Split(' ')[1]);
            //عشان اعرف انا في اي صف
            byte btnNum = Convert.ToByte(btn.Text);

            if (btn.Tag.ToString().Contains("B"))
            {
                //هنا بشوف هل المكان اللي هروحه فيه قطعه بيضه ولا لا
                //عن طريق اني اجيب احسبها من العكس وازود الخطوات
                if (_StepsHighlights[((7 - btnNum) + _Steps), BtnColNum].Bounds.IntersectsWith(_WhiteButtonsList[BtnColNum].Bounds))
                {
                    //هل الابيض دافي الاخر ولو في الاخر ما اعملش حاجه
                    if (_WhiteButtonsList[BtnColNum].Text == "7")
                    {
                        Con = true;
                        return true;
                    }

                    //ابدل الاماكن
                    btn.Location = _WhiteButtonsList[BtnColNum].Location;
                    PlayBlobSfx();
                    AddStepsText(btn);
                    ChangePlayer();
                    DisablePlayers();

                    _WhiteButtonsList[BtnColNum].Location = _WhiteButtonsLocationsList[BtnColNum];
                    _WhiteButtonsList[BtnColNum].Text = "7";

                    Con = false;

                    if (_IsAiVsAi)
                        PlayAi();

                    return true;

                }
            }
            else
            {
                //هنا بشوف هل المكان اللي هروحه فيه قطعه سوداولا لا
                //عن طريق اني اجيب قرم القطعةالسودا اللي بتساوي رقم الفطعه البيضه
                if (_StepsHighlights[(btnNum - _Steps), BtnColNum].Bounds.IntersectsWith(_BlackButtonsList[BtnColNum].Bounds))
                {
                    //لو فيه لاعب , هشوف هو فين , لو هو في مكانه في الاول ما نعملش حاجه
                    if (_BlackButtonsList[BtnColNum].Text == "7")
                    {
                        Con = true;
                        return true;
                    }
                    //ابدل الاماكن
                    btn.Location = _WhiteButtonsList[BtnColNum].Location;
                    PlayBlobSfx();
                    AddStepsText(btn);
                    ChangePlayer();
                    DisablePlayers();



                    _WhiteButtonsList[BtnColNum].Location = _WhiteButtonsLocationsList[BtnColNum];
                    _WhiteButtonsList[BtnColNum].Text = "7";

                    Con = false;


                    if (_IsAiVsAi)
                        PlayAi();

                    return true;

                }
            }
                return false;

        }

        void PlayDice()
        {
            _Steps = (Byte)(_Random.Next(4) + 1);
            lpRandomNum.Text = _Steps.ToString();

        }

        void AiSkip()
        {
            lpSkip.Visible = true;
            lpSkip.Text = $"{_Player2Name} Skipped";
            SkipUiTimer.Start();
            _SkipSfx.Play();
            ChangePlayer();
            DisablePlayers();
        }

        void AiPlayWithOutAnimation()
        {
            PlayDice();


            var targetList = _PlayerColor == PlayerColor.White
                ? _WhiteButtonsList
                : _BlackButtonsList;

            lpIsEnable.Text = "AI Playing";

            var shuffledList = targetList.OrderBy(x => _Random.Next()).ToList();

            bool con = false;

          
                foreach(var btn in shuffledList)
                {
                
                    if (CheckCurrentStepsToMove(btn))
                    {
                        if (!AiCheckNextIsTherePlayer(btn, ref con))
                        {
                            AiPlayDeffultMove(btn);

                            if (_IsAiVsAi)
                            PlayAi();

                            return;
                        }


                }
                    else
                    {
                        con = true;
                    }

                    if (!con)
                        return;

                }

            _isStartBlack = false;
            _isStartWhite = false;

            AiSkip();


            if (_IsAiVsAi)
            {
                PlayAi();

            }

       


        }

        void AiPlayWithAnimation()
        {
            AiRandomNumTimer.Start();
            AiRollTimer.Start();
        }

        void PlayAi()
        {
            btnRandomNum.Enabled = false;

            if (_IsGameEnd)
                return;

            if (_AiAnimation)
            {
                AiPlayWithAnimation();
            }
            else
            {
                AiPlayWithOutAnimation();
            }

            if(_IsGameEnd || _IsAiVsAi)
            { 
                btnRandomNum.Enabled = false;
                return;
            }

                btnRandomNum.Enabled = true;

        }

        bool CheckWinner(Button btn)
        {
            var targetList = btn.Tag.ToString().Contains("W")
                ? _WhiteButtonsList
                : _BlackButtonsList;

            byte Counter = 0;

                foreach (var vbtn in targetList)
                {
                    Counter++;
                    if (vbtn.Text != "0")
                    {
                        return false;
                    }

                    if (Counter == 8)
                    {
                        return true;
                    }
                }

            return false;

        }

        void ChangeWinnerColor(Button btn)
        {

            string Tag;

            if(btn.Tag.ToString().Contains("W"))
                Tag = "W";
            else
                Tag = "B";


            for (byte i = 0; i < _BlackButtonsList.Count; i++)
                {
                    if (Tag == "W")
                    {
                        _WhiteButtonsList[i].BackColor = Color.FromArgb(80, 0, 192, 0); // green
                        _BlackButtonsList[i].BackColor = Color.FromArgb(80, 192, 0, 0); // red
                    }
                    else
                    {
                    _BlackButtonsList[i].BackColor = Color.FromArgb(80, 0, 192, 0); // green
                    _WhiteButtonsList[i].BackColor = Color.FromArgb(80, 192, 0, 0); // red
                }

                }

          
        }

        void CheckResluts(Button btn)
        {
            string winnerName = btn.Tag.ToString().Contains("W")? _Player1Name: _Player2Name;
            
                if(CheckWinner(btn))
                {
                    EndGame();
                    ChangeWinnerColor(btn);
                    lpWinnerName.Text = winnerName;
                    MessageBox.Show($"Congratulations {winnerName}, you won the game!");
                }

        }

        void PlayerMove(Button btn)
        {

            if (!CheckNextIsTherePlayer(btn))
            {
                if (btn.Tag.ToString().Contains("W"))
                {
                    btn.Location = new Point(btn.Location.X, btn.Location.Y - (125 * _Steps));
                }
                else
                {
                    btn.Location = new Point(btn.Location.X, btn.Location.Y + (125 * _Steps));
                }
                PlayBlobSfx();
                AddStepsText(btn);
                ChangePlayer();
                DisablePlayers();
                CheckResluts(btn);

            }

            if(_IsVsAi && _PlayerColor ==PlayerColor.Black && !_IsGameEnd)
            {
                PlayAi();
            }

        }

        bool CheckTurn(Button btn,PlayerColor c)
        {
            if(c == PlayerColor.White)
            {
                if (!btn.Tag.ToString().Contains("W"))
                {
                    MessageBox.Show("Wait for your turn.","Not Your Turn",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            else
            {
                if (!btn.Tag.ToString().Contains("B"))
                {
                    MessageBox.Show("Wait for your turn.", "Not Your Turn", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }

            }
            return true;
        }

        private void BtnClick(object sender, EventArgs e)
        {

            if (!_IsPlayersEnabled)
            {
                MessageBox.Show("Roll the dice first before making a move.","Roll Required",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
             }
            Button btn = (Button)sender;

            if (CheckIsBtnOnTheEnd(btn))
                return;


            if(_PlayerColor ==PlayerColor.White)
            { 
                if(!CheckTurn(btn,PlayerColor.White))
                {
                    return;
                }

                if(!CheckCurrentStepsToMove(btn))
                    return ;


                PlayerMove(btn);

                _isStartWhite = false;

            }
            else
            {
                if (!CheckTurn(btn, PlayerColor.Black))
                {
                    return;
                }

                if (!CheckCurrentStepsToMove(btn))
                    return;

                PlayerMove(btn);

                _isStartBlack = false;

            }

            

        }

        void ShowSteps(Button btn)
        {
            //MyTag to check is im black or white
            string Tag = btn.Tag.ToString();

            if (Tag.Contains("W"))
            {
                if (_PlayerColor != PlayerColor.White)
                    return;
            }
            else
            {
                if (_PlayerColor != PlayerColor.Black)
                    return;
            }


            //عشان اعرف انا في اي عمود
            byte BtnColNum = byte.Parse(Tag.Split(' ')[1]);
            //عشان اعرف انا في اي صف
            byte btnNum = Convert.ToByte(btn.Text);

            int currentStep = _Steps;
            if (Tag.Contains("W"))
            {
                for (int i = btnNum - 1; i >= 0 && currentStep > 0; i--)
                {
                    _StepsHighlights[i, BtnColNum].Visible = true;
                    currentStep--;
                }
            }
            else
            {
                for (int i =(7 - btnNum) + 1; i <= 7 && currentStep > 0; i++)
                {
                    _StepsHighlights[i, BtnColNum].Visible = true;
                    currentStep--;

                }
            }

        }

        void HiddenSteps(Button btn)
        {
            string Tag = btn.Tag.ToString();

            foreach(PictureBox pb in _StepsHighlights)
            {
                pb.Visible = false;
            }

        }

        void ShowErorToPlayersSteps(Button btn)
        {
            if(btn.Text == "0")
            {
                errorProvider1.SetError(btn, "You've reached the limit. You can't play here!");
            }
        }

        void DeleteError()
        {
            errorProvider1.Clear();
        }

        private void btn_MouseHover(object sender, EventArgs e)
        {
            Animations.clsAnimation.AnimationOnHover(sender, e,5);
            ShowSteps((Button)sender);
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Animations.clsAnimation.AnimationOnUnHover(sender, e, 5);
            HiddenSteps((Button)sender);
        }

        void EndGame()
        {
            _IsPlayersEnabled = false;

            for (int i = 0; i < _BlackButtonsList.Count; i++)
            {
                _BlackButtonsList[i].Enabled = false;
                _WhiteButtonsList[i].Enabled = false;
            }

            btnSkip.Enabled = false;
            btnRandomNum.Enabled = false;

            _IsGameEnd = true;

            SecondsTimer.Stop();

            lpIsEnable.Text = "Game End";

        }

        void DisablePlayers()
        {
            _IsPlayersEnabled = false;

            for (int i = 0; i < _BlackButtonsList.Count; i++)
            {
                _BlackButtonsList[i].Enabled = false;
                _WhiteButtonsList[i].Enabled = false;
            }

            if(!_IsAiVsAi)
            btnRandomNum.Enabled = true; //عشان مقدرش اجيب رقم تاني

            btnSkip.Enabled = false;//لازم اجيب رقم عشان اقدر اعمل سكيب

            lpIsEnable.Text = "Roll the Dice";
        }

        void EnablePlayers()
        {
            _IsPlayersEnabled= true;

            for (int i = 0; i < _BlackButtonsList.Count; i++)
            {
                _BlackButtonsList[i].Enabled = true;
                _WhiteButtonsList[i].Enabled = true;
            }

            btnRandomNum.Enabled = false;

            btnSkip.Enabled = true; 

            lpIsEnable.Text = "Make Your Move";

        }

        private void btnRandomNum_Click(object sender, EventArgs e)
        {
            PlayRollSfx();
            RandomNumTimer.Start();
            RollTimer.Start();
            
        }

        private void RandomNumTimer_Tick(object sender, EventArgs e)
        {
            _TempNum++;

            if( _TempNum > 4)
                _TempNum = 0;

            //_Steps = (byte)(Random.Next(4) + 1);
            lpRandomNum.Text = _TempNum.ToString();
        }

        void TakeRanomNumber()
        {
            _TempNum = (byte)(_Random.Next(4) + 1);
            lpRandomNum.Text = _TempNum.ToString();
            _Steps = _TempNum;
            _TempNum = 0;
            _TempSecs = 0;
            RandomNumTimer.Interval = 10;
            EnablePlayers();
        }

        private void TempSecs_Tick(object sender, EventArgs e)
        {
            _TempSecs++;

            if(_TempSecs == 1)
            {
                RandomNumTimer.Interval = 50;
            }
            else if( _TempSecs == 2)
            {
                RandomNumTimer.Interval = 100;
            }
            else if ( _TempSecs == 3)
            {
                RandomNumTimer.Stop();
                TakeRanomNumber();
                RollTimer.Stop();

            }
        }

        void CanSkip()
        {

            byte btnNum;
            byte Counter = 0;
            byte BtnColNum;


            if (_PlayerColor == PlayerColor.White)
            {
              foreach (Button But in _WhiteButtonsList)
              {
                  btnNum = Convert.ToByte(But.Text);
                  BtnColNum = byte.Parse(But.Tag.ToString().Split(' ')[1]);
                    Counter++;

                    if (btnNum - _Steps >= 0)
                    {
                        if (!_StepsHighlights[0, BtnColNum].Bounds.IntersectsWith(_BlackButtonsList[BtnColNum].Bounds))
                        {
                            errorProvider1.SetError(But, "Skipping is not allowed, you have a valid move.");
                            _SkipFaildSfx.Play();

                            return;
                        }
                    }

                  if(Counter == 8 && !_isStartWhite)
                    {
                        

                        lpSkip.Visible = true;
                        lpSkip.Text = $"{_Player1Name} Skipped";
                        SkipUiTimer.Start();
                        _SkipSfx.Play();

                        ChangePlayer();
                        DisablePlayers();

                        if (_IsVsAi)
                            PlayAi();

                        return ;
                    }

                }
            }
            else
            {
                foreach (Button But in _BlackButtonsList)
                {
                    btnNum = Convert.ToByte(But.Text);
                    BtnColNum = byte.Parse(But.Tag.ToString().Split(' ')[1]);

                    Counter++;

                    if ((7 - btnNum) + _Steps <= 7)
                    {
                        if(!_StepsHighlights[((7 - btnNum) + _Steps), BtnColNum].Bounds.IntersectsWith(_WhiteButtonsList[BtnColNum].Bounds))
                        {
                            errorProvider1.SetError(But, "Skipping is not allowed, you have a valid move.");
                            _SkipFaildSfx.Play();

                            return;
                        }
                    }

                    if (Counter == 8 && !_isStartBlack)
                    {
                       

                        lpSkip.Visible = true;
                        lpSkip.Text = $"{_Player2Name} Skipped";
                        SkipUiTimer.Start();
                        _SkipSfx.Play();

                        ChangePlayer();
                        DisablePlayers();

                        return;
                    }

                }
            }





        }
        private void btnSkip_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            CanSkip();
        }

        private void SecondsTimer_Tick(object sender, EventArgs e)
        {
            Secs = (Secs + 1) % 60;
            if (Secs == 0)
            {
                Min = (Min + 1) % 60;
                if (Min == 0)
                {
                    Hours = (Hours + 1) % 24;
                }
            }


            LpSecs.Text = Secs.ToString("D2");
            LpMin.Text = Min.ToString("D2");
            LpHours.Text = Hours.ToString("D2");

        }

        private void PanelsBtnsHover(object sender, EventArgs e)
        {
            clsAnimation.AnimationOnHover(sender, e, 5);
        }

        private void PanelsBtnsUnHover(object sender, EventArgs e)
        {

            clsAnimation.AnimationOnUnHover(sender, e, 5);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to exit the game?", "Exit Game", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            frmSplash.Show();
            this.Close();
        }

        void RestPlayersColors()
        {
            for (byte i = 0; i < _BlackButtonsList.Count; i++)
            {
                    _BlackButtonsList[i].BackColor = Color.FromArgb(217, 226, 236); // Deff Color
                    _WhiteButtonsList[i].BackColor = Color.FromArgb(217, 226, 236); // Deff Color
            }

        }

        private void btnRestartGame_Click(object sender, EventArgs e)
        {

            if(MessageBox.Show("Are you sure you want to restart the game?", "Restart Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            //Rest Locations
            for (int i = 0;i < _BlackButtonsList.Count;i++)
            {
                _BlackButtonsList[i].Location = _BlackButtonsLocationsList[i];
                _WhiteButtonsList[i].Location = _WhiteButtonsLocationsList[i];
            }
            DisablePlayers();

            //Rest Text , cus text = current location
            foreach (var btn in _WhiteButtonsList)
                btn.Text = "7";

            foreach (var btn in _BlackButtonsList)
                btn.Text = "7";

            // Reset Timer
            Secs = Min = Hours = 0;

            LpSecs.Text = "00";
            LpMin.Text = "00";
            LpHours.Text = "00";

            SecondsTimer.Start();

            lpWinnerName.Text = "In Prograss";

            _isStartWhite = true;
            _isStartBlack = true;

            //change player to black then change all thing to white in method
            _PlayerColor = PlayerColor.Black;
            ChangePlayer();

            RestPlayersColors();

            _IsGameEnd = false;

            if(_IsAiVsAi)
            {
                PlayAi();
            }

        }

        private void AiRandomNumTimer_Tick(object sender, EventArgs e)
        {
            _TempNum++;

            if (_TempNum > 4)
                _TempNum = 0;

            //_Steps = (byte)(Random.Next(4) + 1);
            lpRandomNum.Text = _TempNum.ToString();

        }

        private void AiRollTimer_Tick(object sender, EventArgs e)
        {
            _TempSecs++;

            if (_TempSecs == 1)
            {
                AiRandomNumTimer.Interval = 50;
            }
            else if (_TempSecs == 2)
            {
                AiRandomNumTimer.Interval = 100;
            }
            else if (_TempSecs == 3)
            {
                AiRandomNumTimer.Stop();
                AiRollTimer.Stop();
                AiPlayWithOutAnimation();
                
                if(!_IsAiVsAi)
                btnRandomNum.Enabled = true;

                _TempSecs = 0;
                _TempNum = 0;
            }
        }

        private void SkipUiTimer_Tick(object sender, EventArgs e)
        {
            _SkipSecs++;

            if( _SkipSecs  >= 3)
            {
                lpSkip.Visible = false;
                _SkipSecs = 0;
                SkipUiTimer.Stop();
            }
        }

    }
}
