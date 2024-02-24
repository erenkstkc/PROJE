using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using NAudio;
using NAudio.Wave;
using System.IO;

namespace PROJE
{
    public partial class Form1 : Form
    {
        private IWavePlayer waveoutdevice;
        private AudioFileReader audioreader;
        private IWavePlayer outdevice;
        private AudioFileReader audioreader1;

        bool playerBlock=false;
        bool enemyblock=false;
        Random Random = new Random();
        int enemySpeed = 5;
        int index = 0;
        int playerHealth = 100;
        int enemyHealth = 100;
        int playerSpeed= 50;
        System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
        SoundPlayer ses2 = new SoundPlayer(Resource1.Vurma_Sesi_Kafa_Atma_Sesi__1_);
        



        List<string> enemyAttack = new List<string> { "left", "right", "block" };
        public Form1()
        {

            waveoutdevice = new WaveOut();
            audioreader = new AudioFileReader("C:\\Users\\Eren\\Desktop\\PROJE OYUN\\PROJE\\PROJE\\PROJE\\Resources\\Vurma Sesi Kafa Atma Sesi (1).wav");
            waveoutdevice.Init(audioreader);

            outdevice = new WaveOut();
            audioreader1 = new AudioFileReader("C:\\Users\\Eren\\Desktop\\PROJE OYUN\\PROJE\\PROJE\\PROJE\\Resources\\Survivor - Eye Of The Tiger (Official HD Video).wav");
            outdevice.Init(audioreader1);



            InitializeComponent();
            ResetGame();

        }

        private void BoxerAttackTimerEvent(object sender, EventArgs e)
        {
            
            index=Random.Next(0,enemyAttack.Count);/* düşmanın hareketleri rastgele*/
            switch (enemyAttack[index].ToString())
            {
                case "left":
                    boxer.Image = Properties.Resources.word_image_47;
                    enemyblock = false;
                    if (boxer.Bounds.IntersectsWith(player.Bounds) && playerBlock == false)
                    {
                     //   waveoutdevice.Stop();
                     //   waveoutdevice.Play();
                        
                        ses2.Play();
                        playerHealth -= 5;



                    }
                break;
                case "right":
                    boxer.Image = Properties.Resources.word_image_46;
                    enemyblock = false;
                    if (boxer.Bounds.IntersectsWith(player.Bounds) && playerBlock == false)
                    {
                        //waveoutdevice.Stop();
                        //waveoutdevice.Play();


                        ses2.Play();

                        playerHealth -= 5;
                    }
                break;

                case "block":
                        boxer.Image=Properties.Resources.word_image_48;
                        enemyblock = true;
                    break;


            }
        }

        private void BoxerMoveTimerEvent(object sender, EventArgs e)
        {
            if (playerHealth > 1)
            {
                playerHealthBar.Value = playerHealth;
            }
            if (enemyHealth > 1)
            {
                boxerHealthBar.Value = enemyHealth;
            }
            boxer.Left += enemySpeed;
            if(boxer.Left > 630)
            {
                enemySpeed = -5;
            }
            if(boxer.Left < 150)
            {
                enemySpeed = 5;
            }
            if (enemyHealth < 1)
            {
                BoxerAttackTimer.Stop();
                BoxerMoveTimer.Stop();
                MessageBox.Show("KAZANDIN.TAMAMA BASARAK BİR KEZ DAHA OYNA");
                ResetGame();
            }
            if(playerHealth < 1)
            {
                BoxerAttackTimer.Stop();
                BoxerMoveTimer.Stop();
                MessageBox.Show("KAYBETTİN.TEKRAR OYNAMAK İÇİN TAMAMA BAS");
                ResetGame();
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                player.Image = Properties.Resources.word_image_42;
                playerBlock = false;
                if (player.Bounds.IntersectsWith(boxer.Bounds) && enemyblock == false)
                {
                    //outdevice.Stop();
                    //outdevice.Play();

                     ses2.Play();

                    enemyHealth -= 3;
                }
            }
            if(e.KeyCode == Keys.Right)
            {
                player.Image = Properties.Resources.word_image_41;
                playerBlock = false;
                if (player.Bounds.IntersectsWith(boxer.Bounds) && enemyblock == false)
                {
                    //outdevice.Stop();
                    //outdevice.Play();

                       ses2.Play();

                    enemyHealth -= 3;
                }
            }
            if(e.KeyCode == Keys.Down)
            {
                player.Image=Properties.Resources.word_image_43;
                playerBlock = true;
            }
            if (e.KeyCode == Keys.D)
            {
                player.Left += playerSpeed;
            }
            if(e.KeyCode == Keys.A)
            {
                player.Left -= playerSpeed;
            }
            if(e.KeyCode== Keys.Enter)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            player.Image = Properties.Resources.word_image_44;
            playerBlock = false;
        }
        private void ResetGame()
        {
            BoxerAttackTimer.Start();
            BoxerMoveTimer.Start();
            playerHealth = 100;
            enemyHealth = 100;
            boxer.Left = 400;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            outdevice.Stop();
            outdevice.Play();

            //ses.SoundLocation = "Survivor-Eye-Of-The-Tiger-_Official-HD-Video_.wav";
            //ses.Play();
        }

    }
}
