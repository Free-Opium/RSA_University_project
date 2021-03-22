using com.sun.media.sound;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA_University_project_Vysochina
{

   
    public partial class Test_tool_rand : Form
    {
        public Test_tool_rand()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            RandomGenerator.currentSeedValue = RandomGenerator.GenerateSeedFromTimestamp();

        }

        //ГПСЧ
        private void btn_GenerateRandSeed_Click(object sender, EventArgs e)
        {
            var seed = RandomGenerator.GenerateSeedFromTimestamp();
            tb_passive_CurrentRandseed.Text = seed.ToString();
            tb_passive_MainRandseed.Text = seed.ToString();

        }

        private void btn_SaveManualRandSeed_Click(object sender, EventArgs e)
        {
            if (tb_ManualRandSeed.Text.Length > 0)
            {
                var seed = RandomGenerator.currentSeedValue = long.Parse(tb_ManualRandSeed.Text);
                tb_passive_CurrentRandseed.Text = seed.ToString();
                tb_passive_MainRandseed.Text = seed.ToString();
            }
        }

        private void btn_SaveRange_Click(object sender, EventArgs e)
        {
            if (tb_RangeMin.Text.Length > 0) RandomGenerator.rangeMin = long.Parse(tb_RangeMin.Text);
            else RandomGenerator.rangeMin = RandomGenerator.rangeMinDefault;

            if (tb_RangeMax.Text.Length > 0) RandomGenerator.rangeMax = long.Parse(tb_RangeMax.Text);
            else RandomGenerator.rangeMax = RandomGenerator.rangeMaxDefault;

        }

        private void btn_GenerateNextNumber_Click(object sender, EventArgs e)
        {
            if (tb_passive_MainRandseed.TextLength == 0)
            {
                tb_passive_MainRandseed.Text = RandomGenerator.currentSeedValue.ToString();
                tb_passive_CurrentRandseed.Text = RandomGenerator.currentSeedValue.ToString();
            }



            RandomGenerator.GenerateNext();

            tb_passive_CurrentRandseed.Text = RandomGenerator.currentSeedValue.ToString();

            tb_passive_CurrentRandomValue.Text = RandomGenerator.currentRandomValue.ToString();

        }

        //ГСД
        private void btn_GetGCD_Click(object sender, EventArgs e)
        {
            tb_passive_GCDResult.Text = (GCD.Get(
                                long.Parse(tb_GCD_A.Text), 
                                long.Parse(tb_GCD_B.Text))).ToString();

        }

        //Расширенный Эвклид
        private void btn_GetGCDEx_Click(object sender, EventArgs e)
        {
            int x;
            int y;
            int E = int.Parse(tb_GCDEx_E.Text);
            int fi = int.Parse(tb_GCDEx_Fi.Text);
            var div = GCD_Extended.Gcd(E, fi, out x, out y);


            tb_passive_GCDEx_D.Text = x.ToString();
            tb_passive_GCDEx_Y.Text = y.ToString();

        }

        //Модульное возведение в степень
        private void button1_Click(object sender, EventArgs e)
        {
            tb_passive_MPResult.Text = (ModPow.Get(int.Parse(tb_MP_X.Text), int.Parse(tb_MP_Y.Text), int.Parse(tb_MP_N.Text))).ToString();
        }

        //Малая теорема Ферма
        private void btn_PrimeCheck_Click(object sender, EventArgs e)
        {
            tb_passive_FermaPrimeCheckResult.Text = Ferma.Check(long.Parse(tb_FermaInputNumber.Text)) ? "Число на 99,9999% простое" : "Число не является простым";

        }

        private void btn_GenerateForPrimeTest_Click(object sender, EventArgs e)
        {
            var num =
            RandomGenerator.GenerateNext();
            tb_FermaInputNumber.Text = num.ToString();
        }

        private void tb_FermaInputNumber_TextChanged(object sender, EventArgs e)
        {
            tb_passive_FermaPrimeCheckResult.Text = "";
        }
    }
}
