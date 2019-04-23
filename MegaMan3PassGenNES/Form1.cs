/**
 *  @file           Form1.cs / FormMegaMan3PassGenNES
 *  @brief          Password Generator for the NES Game MegaMan III
 *  @copyright      Shawn M. Crawford 2019
 *  @date           04/23/2019
 *
 *  @remark Author  Shawn M. Crawford (sleepy9090)
 *
 *  @note           N/A
 *
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaMan3PassGenNES
{
    public partial class FormMegaMan3PassGenNes : Form
    {
        private readonly Bitmap _blankBitmap = MegaMan3PassGenNES.Properties.Resources.blank;
        private readonly Bitmap _redDotBitmap = MegaMan3PassGenNES.Properties.Resources.reddot;
        private readonly Bitmap _blueDotBitmap = MegaMan3PassGenNES.Properties.Resources.bluedot;

        public FormMegaMan3PassGenNes()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;

            PopulateImages();
            PopulateEnergyTankComboBox();
        }

        private void PopulateEnergyTankComboBox()
        {
            for (int i = 0; i <= 9; i++)
            {
                comboBoxEnergyTanks.Items.Add(i);
            }
            comboBoxEnergyTanks.SelectedIndex = 0;
        }

        private void PopulateImages()
        {
            pictureBoxA1.Image = _blankBitmap;
            pictureBoxA1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA1.Image.Tag = _blankBitmap.ToString();
            pictureBoxA2.Image = _blankBitmap;
            pictureBoxA2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA2.Image.Tag = _blankBitmap.ToString();
            pictureBoxA3.Image = _blankBitmap;
            pictureBoxA3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA3.Image.Tag = _blankBitmap.ToString();
            pictureBoxA4.Image = _blankBitmap;
            pictureBoxA4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA4.Image.Tag = _blankBitmap.ToString();
            pictureBoxA5.Image = _blankBitmap;
            pictureBoxA5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA5.Image.Tag = _blankBitmap.ToString();
            pictureBoxA6.Image = _blankBitmap;
            pictureBoxA6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA6.Image.Tag = _blankBitmap.ToString();

            pictureBoxB1.Image = _blankBitmap;
            pictureBoxB1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB1.Image.Tag = _blankBitmap.ToString();
            pictureBoxB2.Image = _blankBitmap;
            pictureBoxB2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB2.Image.Tag = _blankBitmap.ToString();
            pictureBoxB3.Image = _blankBitmap;
            pictureBoxB3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB3.Image.Tag = _blankBitmap.ToString();
            pictureBoxB4.Image = _blankBitmap;
            pictureBoxB4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB4.Image.Tag = _blankBitmap.ToString();
            pictureBoxB5.Image = _blankBitmap;
            pictureBoxB5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB5.Image.Tag = _blankBitmap.ToString();
            pictureBoxB6.Image = _blankBitmap;
            pictureBoxB6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB6.Image.Tag = _blankBitmap.ToString();

            pictureBoxC1.Image = _blankBitmap;
            pictureBoxC1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC1.Image.Tag = _blankBitmap.ToString();
            pictureBoxC2.Image = _blankBitmap;
            pictureBoxC2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC2.Image.Tag = _blankBitmap.ToString();
            pictureBoxC3.Image = _blankBitmap;
            pictureBoxC3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC3.Image.Tag = _blankBitmap.ToString();
            pictureBoxC4.Image = _blankBitmap;
            pictureBoxC4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC4.Image.Tag = _blankBitmap.ToString();
            pictureBoxC5.Image = _blankBitmap;
            pictureBoxC5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC5.Image.Tag = _blankBitmap.ToString();
            pictureBoxC6.Image = _blankBitmap;
            pictureBoxC6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC6.Image.Tag = _blankBitmap.ToString();

            pictureBoxD1.Image = _blankBitmap;
            pictureBoxD1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD1.Image.Tag = _blankBitmap.ToString();
            pictureBoxD2.Image = _blankBitmap;
            pictureBoxD2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD2.Image.Tag = _blankBitmap.ToString();
            pictureBoxD3.Image = _blankBitmap;
            pictureBoxD3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD3.Image.Tag = _blankBitmap.ToString();
            pictureBoxD4.Image = _blankBitmap;
            pictureBoxD4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD4.Image.Tag = _blankBitmap.ToString();
            pictureBoxD5.Image = _blankBitmap;
            pictureBoxD5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD5.Image.Tag = _blankBitmap.ToString();
            pictureBoxD6.Image = _blankBitmap;
            pictureBoxD6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD6.Image.Tag = _blankBitmap.ToString();

            pictureBoxE1.Image = _blankBitmap;
            pictureBoxE1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE1.Image.Tag = _blankBitmap.ToString();
            pictureBoxE2.Image = _blankBitmap;
            pictureBoxE2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE2.Image.Tag = _blankBitmap.ToString();
            pictureBoxE3.Image = _blankBitmap;
            pictureBoxE3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE3.Image.Tag = _blankBitmap.ToString();
            pictureBoxE4.Image = _blankBitmap;
            pictureBoxE4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE4.Image.Tag = _blankBitmap.ToString();
            pictureBoxE5.Image = _blankBitmap;
            pictureBoxE5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE5.Image.Tag = _blankBitmap.ToString();
            pictureBoxE6.Image = _blankBitmap;
            pictureBoxE6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE6.Image.Tag = _blankBitmap.ToString();

            pictureBoxF1.Image = _blankBitmap;
            pictureBoxF1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxF1.Image.Tag = _blankBitmap.ToString();
            pictureBoxF2.Image = _blankBitmap;
            pictureBoxF2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxF2.Image.Tag = _blankBitmap.ToString();
            pictureBoxF3.Image = _blankBitmap;
            pictureBoxF3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxF3.Image.Tag = _blankBitmap.ToString();
            pictureBoxF4.Image = _blankBitmap;
            pictureBoxF4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxF4.Image.Tag = _blankBitmap.ToString();
            pictureBoxF5.Image = _blankBitmap;
            pictureBoxF5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxF5.Image.Tag = _blankBitmap.ToString();
            pictureBoxF6.Image = _blankBitmap;
            pictureBoxF6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxF6.Image.Tag = _blankBitmap.ToString();
        }

        private void ResetImages()
        {
            pictureBoxA1.Image = null;
            pictureBoxA1.Image = _blankBitmap;
            pictureBoxA1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA1.Image.Tag = _blankBitmap.ToString();
            pictureBoxA2.Image = null;
            pictureBoxA2.Image = _blankBitmap;
            pictureBoxA2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA2.Image.Tag = _blankBitmap.ToString();
            pictureBoxA3.Image = null;
            pictureBoxA3.Image = _blankBitmap;
            pictureBoxA3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA3.Image.Tag = _blankBitmap.ToString();
            pictureBoxA4.Image = null;
            pictureBoxA4.Image = _blankBitmap;
            pictureBoxA4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA4.Image.Tag = _blankBitmap.ToString();
            pictureBoxA5.Image = null;
            pictureBoxA5.Image = _blankBitmap;
            pictureBoxA5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA5.Image.Tag = _blankBitmap.ToString();
            pictureBoxA6.Image = null;
            pictureBoxA6.Image = _blankBitmap;
            pictureBoxA6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxA6.Image.Tag = _blankBitmap.ToString();

            pictureBoxB1.Image = null;
            pictureBoxB1.Image = _blankBitmap;
            pictureBoxB1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB1.Image.Tag = _blankBitmap.ToString();
            pictureBoxB2.Image = null;
            pictureBoxB2.Image = _blankBitmap;
            pictureBoxB2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB2.Image.Tag = _blankBitmap.ToString();
            pictureBoxB3.Image = null;
            pictureBoxB3.Image = _blankBitmap;
            pictureBoxB3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB3.Image.Tag = _blankBitmap.ToString();
            pictureBoxB4.Image = null;
            pictureBoxB4.Image = _blankBitmap;
            pictureBoxB4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB4.Image.Tag = _blankBitmap.ToString();
            pictureBoxB5.Image = null;
            pictureBoxB5.Image = _blankBitmap;
            pictureBoxB5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB5.Image.Tag = _blankBitmap.ToString();
            pictureBoxB6.Image = null;
            pictureBoxB6.Image = _blankBitmap;
            pictureBoxB6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxB6.Image.Tag = _blankBitmap.ToString();

            pictureBoxC1.Image = null;
            pictureBoxC1.Image = _blankBitmap;
            pictureBoxC1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC1.Image.Tag = _blankBitmap.ToString();
            pictureBoxC2.Image = null;
            pictureBoxC2.Image = _blankBitmap;
            pictureBoxC2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC2.Image.Tag = _blankBitmap.ToString();
            pictureBoxC3.Image = null;
            pictureBoxC3.Image = _blankBitmap;
            pictureBoxC3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC3.Image.Tag = _blankBitmap.ToString();
            pictureBoxC4.Image = null;
            pictureBoxC4.Image = _blankBitmap;
            pictureBoxC4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC4.Image.Tag = _blankBitmap.ToString();
            pictureBoxC5.Image = null;
            pictureBoxC5.Image = _blankBitmap;
            pictureBoxC5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC5.Image.Tag = _blankBitmap.ToString();
            pictureBoxC6.Image = null;
            pictureBoxC6.Image = _blankBitmap;
            pictureBoxC6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxC6.Image.Tag = _blankBitmap.ToString();

            pictureBoxD1.Image = null;
            pictureBoxD1.Image = _blankBitmap;
            pictureBoxD1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD1.Image.Tag = _blankBitmap.ToString();
            pictureBoxD2.Image = null;
            pictureBoxD2.Image = _blankBitmap;
            pictureBoxD2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD2.Image.Tag = _blankBitmap.ToString();
            pictureBoxD3.Image = null;
            pictureBoxD3.Image = _blankBitmap;
            pictureBoxD3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD3.Image.Tag = _blankBitmap.ToString();
            pictureBoxD4.Image = null;
            pictureBoxD4.Image = _blankBitmap;
            pictureBoxD4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD4.Image.Tag = _blankBitmap.ToString();
            pictureBoxD5.Image = null;
            pictureBoxD5.Image = _blankBitmap;
            pictureBoxD5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD5.Image.Tag = _blankBitmap.ToString();
            pictureBoxD6.Image = null;
            pictureBoxD6.Image = _blankBitmap;
            pictureBoxD6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxD6.Image.Tag = _blankBitmap.ToString();

            pictureBoxE1.Image = null;
            pictureBoxE1.Image = _blankBitmap;
            pictureBoxE1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE1.Image.Tag = _blankBitmap.ToString();
            pictureBoxE2.Image = null;
            pictureBoxE2.Image = _blankBitmap;
            pictureBoxE2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE2.Image.Tag = _blankBitmap.ToString();
            pictureBoxE3.Image = null;
            pictureBoxE3.Image = _blankBitmap;
            pictureBoxE3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE3.Image.Tag = _blankBitmap.ToString();
            pictureBoxE4.Image = null;
            pictureBoxE4.Image = _blankBitmap;
            pictureBoxE4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE4.Image.Tag = _blankBitmap.ToString();
            pictureBoxE5.Image = null;
            pictureBoxE5.Image = _blankBitmap;
            pictureBoxE5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE5.Image.Tag = _blankBitmap.ToString();
            pictureBoxE6.Image = null;
            pictureBoxE6.Image = _blankBitmap;
            pictureBoxE6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxE6.Image.Tag = _blankBitmap.ToString();

            pictureBoxF1.Image = null;
            pictureBoxF1.Image = _blankBitmap;
            pictureBoxF1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxF1.Image.Tag = _blankBitmap.ToString();
            pictureBoxF2.Image = null;
            pictureBoxF2.Image = _blankBitmap;
            pictureBoxF2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxF2.Image.Tag = _blankBitmap.ToString();
            pictureBoxF3.Image = null;
            pictureBoxF3.Image = _blankBitmap;
            pictureBoxF3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxF3.Image.Tag = _blankBitmap.ToString();
            pictureBoxF4.Image = null;
            pictureBoxF4.Image = _blankBitmap;
            pictureBoxF4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxF4.Image.Tag = _blankBitmap.ToString();
            pictureBoxF5.Image = null;
            pictureBoxF5.Image = _blankBitmap;
            pictureBoxF5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxF5.Image.Tag = _blankBitmap.ToString();
            pictureBoxF6.Image = null;
            pictureBoxF6.Image = _blankBitmap;
            pictureBoxF6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxF6.Image.Tag = _blankBitmap.ToString();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            ResetImages();

            #region Variables
            bool defeatedTopMan = checkBoxTopMan.Checked;
            bool defeatedSnakeMan = checkBoxSnakeMan.Checked;
            bool defeatedMagnetMan = checkBoxMagnetMan.Checked;
            bool defeatedNeedleMan = checkBoxNeedleMan.Checked;
            bool defeatedHardMan = checkBoxHardMan.Checked;
            bool defeatedGeminiMan = checkBoxGeminiMan.Checked;
            bool defeatedSparkMan = checkBoxSparkMan.Checked;
            bool defeatedShadowMan = checkBoxShadowMan.Checked;

            bool defeatedWilyNeedleMan = checkBoxWilyNeedleMan.Checked;
            bool defeatedWilyGeminiMan = checkBoxWilyGeminiMan.Checked;
            bool defeatedWilySparkMan = checkBoxWilySparkMan.Checked;
            bool defeatedWilyShadowMan = checkBoxWilyShadowMan.Checked;

            bool defeatedBreakMan = checkBoxBreakMan.Checked;

            int numberOfEnergyTanks = comboBoxEnergyTanks.SelectedIndex;
            #endregion

            switch (numberOfEnergyTanks)
            {
                case 0:
                    pictureBoxC5.Image = null;
                    pictureBoxC5.Image = _redDotBitmap;
                    pictureBoxC5.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxC5.Image.Tag = _redDotBitmap.ToString();
                    break;
                case 1:
                    pictureBoxE6.Image = null;
                    pictureBoxE6.Image = _redDotBitmap;
                    pictureBoxE6.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxE6.Image.Tag = _redDotBitmap.ToString();
                    break;
                case 2:
                    pictureBoxE4.Image = null;
                    pictureBoxE4.Image = _redDotBitmap;
                    pictureBoxE4.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxE4.Image.Tag = _redDotBitmap.ToString();
                    break;
                case 3:
                    pictureBoxB4.Image = null;
                    pictureBoxB4.Image = _redDotBitmap;
                    pictureBoxB4.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxB4.Image.Tag = _redDotBitmap.ToString();
                    break;
                case 4:
                    pictureBoxA5.Image = null;
                    pictureBoxA5.Image = _redDotBitmap;
                    pictureBoxA5.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxA5.Image.Tag = _redDotBitmap.ToString();
                    break;
                case 5:
                    pictureBoxC1.Image = null;
                    pictureBoxC1.Image = _redDotBitmap;
                    pictureBoxC1.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxC1.Image.Tag = _redDotBitmap.ToString();
                    break;
                case 6:
                    pictureBoxD2.Image = null;
                    pictureBoxD2.Image = _redDotBitmap;
                    pictureBoxD2.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxD2.Image.Tag = _redDotBitmap.ToString();
                    break;
                case 7:
                    pictureBoxC3.Image = null;
                    pictureBoxC3.Image = _redDotBitmap;
                    pictureBoxC3.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxC3.Image.Tag = _redDotBitmap.ToString();
                    break;
                case 8:
                    pictureBoxF2.Image = null;
                    pictureBoxF2.Image = _redDotBitmap;
                    pictureBoxF2.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxF2.Image.Tag = _redDotBitmap.ToString();
                    break;
                case 9:
                    pictureBoxA6.Image = null;
                    pictureBoxA6.Image = _redDotBitmap;
                    pictureBoxA6.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxA6.Image.Tag = _redDotBitmap.ToString();
                    break;
                default:
                    pictureBoxC5.Image = null;
                    pictureBoxC5.Image = _redDotBitmap;
                    pictureBoxC5.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxC5.Image.Tag = _redDotBitmap.ToString();
                    break;
            }

            if (defeatedBreakMan)
            {
                checkBoxTopMan.Checked = true;
                checkBoxSnakeMan.Checked = true;
                checkBoxMagnetMan.Checked = true;
                checkBoxNeedleMan.Checked = true;
                checkBoxHardMan.Checked = true;
                checkBoxGeminiMan.Checked = true;
                checkBoxSparkMan.Checked = true;
                checkBoxShadowMan.Checked = true;

                checkBoxWilyNeedleMan.Checked = true;
                checkBoxWilyGeminiMan.Checked = true;
                checkBoxWilySparkMan.Checked = true;
                checkBoxWilyShadowMan.Checked = true;

                defeatedTopMan = true;
                defeatedSnakeMan = true;
                defeatedMagnetMan = true;
                defeatedNeedleMan = true;
                defeatedHardMan = true;
                defeatedGeminiMan = true;
                defeatedSparkMan = true;
                defeatedShadowMan = true;

                defeatedWilyNeedleMan = true;
                defeatedWilyGeminiMan = true;
                defeatedWilySparkMan = true;
                defeatedWilyShadowMan = true;

                pictureBoxA3.Image = null;
                pictureBoxA3.Image = _blueDotBitmap;
                pictureBoxA3.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxA3.Image.Tag = _blueDotBitmap.ToString();

                pictureBoxD3.Image = null;
                pictureBoxD3.Image = _blueDotBitmap;
                pictureBoxD3.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxD3.Image.Tag = _blueDotBitmap.ToString();

                pictureBoxB5.Image = null;
                pictureBoxB5.Image = _blueDotBitmap;
                pictureBoxB5.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxB5.Image.Tag = _blueDotBitmap.ToString();

                pictureBoxF4.Image = null;
                pictureBoxF4.Image = _blueDotBitmap;
                pictureBoxF4.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxF4.Image.Tag = _blueDotBitmap.ToString();

                pictureBoxB2.Image = null;
                pictureBoxB2.Image = _blueDotBitmap;
                pictureBoxB2.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxB2.Image.Tag = _blueDotBitmap.ToString();

                pictureBoxA1.Image = null;
                pictureBoxA1.Image = _blueDotBitmap;
                pictureBoxA1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxA1.Image.Tag = _blueDotBitmap.ToString();

                pictureBoxE1.Image = null;
                pictureBoxE1.Image = _redDotBitmap;
                pictureBoxE1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBoxE1.Image.Tag = _redDotBitmap.ToString();
            }
            else
            {
                if (defeatedWilyNeedleMan || defeatedWilyGeminiMan || defeatedWilySparkMan || defeatedWilyShadowMan)
                {
                    checkBoxTopMan.Checked = true;
                    checkBoxSnakeMan.Checked = true;
                    checkBoxMagnetMan.Checked = true;
                    checkBoxNeedleMan.Checked = true;
                    checkBoxHardMan.Checked = true;
                    checkBoxGeminiMan.Checked = true;
                    checkBoxSparkMan.Checked = true;
                    checkBoxShadowMan.Checked = true;

                    defeatedTopMan = true;
                    defeatedSnakeMan = true;
                    defeatedMagnetMan = true;
                    defeatedNeedleMan = true;
                    defeatedHardMan = true;
                    defeatedGeminiMan = true;
                    defeatedSparkMan = true;
                    defeatedShadowMan = true;

                    pictureBoxA3.Image = null;
                    pictureBoxA3.Image = _blueDotBitmap;
                    pictureBoxA3.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxA3.Image.Tag = _blueDotBitmap.ToString();

                    pictureBoxD3.Image = null;
                    pictureBoxD3.Image = _blueDotBitmap;
                    pictureBoxD3.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxD3.Image.Tag = _blueDotBitmap.ToString();

                    pictureBoxB5.Image = null;
                    pictureBoxB5.Image = _blueDotBitmap;
                    pictureBoxB5.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxB5.Image.Tag = _blueDotBitmap.ToString();

                    pictureBoxF4.Image = null;
                    pictureBoxF4.Image = _blueDotBitmap;
                    pictureBoxF4.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBoxF4.Image.Tag = _blueDotBitmap.ToString();

                    if (defeatedWilyNeedleMan && defeatedWilyGeminiMan)
                    {
                        pictureBoxB2.Image = null;
                        pictureBoxB2.Image = _blueDotBitmap;
                        pictureBoxB2.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxB2.Image.Tag = _blueDotBitmap.ToString();
                    }
                    else if (defeatedWilyNeedleMan)
                    {
                        pictureBoxB2.Image = null;
                        pictureBoxB2.Image = _redDotBitmap;
                        pictureBoxB2.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxB2.Image.Tag = _redDotBitmap.ToString();
                    }
                    else if (defeatedWilyGeminiMan)
                    {
                        pictureBoxB6.Image = null;
                        pictureBoxB6.Image = _redDotBitmap;
                        pictureBoxB6.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxB6.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedWilySparkMan && defeatedWilyShadowMan)
                    {
                        pictureBoxA1.Image = null;
                        pictureBoxA1.Image = _blueDotBitmap;
                        pictureBoxA1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxA1.Image.Tag = _blueDotBitmap.ToString();
                    }
                    else if (defeatedWilySparkMan)
                    {
                        pictureBoxA1.Image = null;
                        pictureBoxA1.Image = _redDotBitmap;
                        pictureBoxA1.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxA1.Image.Tag = _redDotBitmap.ToString();
                    }
                    else if (defeatedWilyShadowMan)
                    {
                        pictureBoxA4.Image = null;
                        pictureBoxA4.Image = _redDotBitmap;
                        pictureBoxA4.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxA4.Image.Tag = _redDotBitmap.ToString();
                    }
                }
                else
                {
                    if (defeatedTopMan && defeatedSnakeMan)
                    {
                        pictureBoxA3.Image = null;
                        pictureBoxA3.Image = _blueDotBitmap;
                        pictureBoxA3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxA3.Image.Tag = _blueDotBitmap.ToString();
                    }
                    else if (defeatedTopMan)
                    {
                        pictureBoxA3.Image = null;
                        pictureBoxA3.Image = _redDotBitmap;
                        pictureBoxA3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxA3.Image.Tag = _redDotBitmap.ToString();
                    }
                    else if (defeatedSnakeMan)
                    {
                        pictureBoxF6.Image = null;
                        pictureBoxF6.Image = _redDotBitmap;
                        pictureBoxF6.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxF6.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedMagnetMan && defeatedNeedleMan)
                    {
                        pictureBoxD3.Image = null;
                        pictureBoxD3.Image = _blueDotBitmap;
                        pictureBoxD3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxD3.Image.Tag = _blueDotBitmap.ToString();
                    }
                    else if (defeatedMagnetMan)
                    {
                        pictureBoxF5.Image = null;
                        pictureBoxF5.Image = _redDotBitmap;
                        pictureBoxF5.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxF5.Image.Tag = _redDotBitmap.ToString();
                    }
                    else if (defeatedNeedleMan)
                    {
                        pictureBoxD3.Image = null;
                        pictureBoxD3.Image = _redDotBitmap;
                        pictureBoxD3.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxD3.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedHardMan && defeatedGeminiMan)
                    {
                        pictureBoxB5.Image = null;
                        pictureBoxB5.Image = _blueDotBitmap;
                        pictureBoxB5.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxB5.Image.Tag = _blueDotBitmap.ToString();
                    }
                    else if (defeatedHardMan)
                    {
                        pictureBoxC4.Image = null;
                        pictureBoxC4.Image = _redDotBitmap;
                        pictureBoxC4.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxC4.Image.Tag = _redDotBitmap.ToString();
                    }
                    else if (defeatedGeminiMan)
                    {
                        pictureBoxB5.Image = null;
                        pictureBoxB5.Image = _redDotBitmap;
                        pictureBoxB5.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxB5.Image.Tag = _redDotBitmap.ToString();
                    }

                    if (defeatedSparkMan && defeatedShadowMan)
                    {
                        pictureBoxF4.Image = null;
                        pictureBoxF4.Image = _blueDotBitmap;
                        pictureBoxF4.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxF4.Image.Tag = _blueDotBitmap.ToString();
                    }
                    else if (defeatedSparkMan)
                    {
                        pictureBoxF4.Image = null;
                        pictureBoxF4.Image = _redDotBitmap;
                        pictureBoxF4.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxF4.Image.Tag = _redDotBitmap.ToString();
                    }
                    else if (defeatedShadowMan)
                    {
                        pictureBoxD6.Image = null;
                        pictureBoxD6.Image = _redDotBitmap;
                        pictureBoxD6.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBoxD6.Image.Tag = _redDotBitmap.ToString();
                    }
                }
            }
        }
    }
}
