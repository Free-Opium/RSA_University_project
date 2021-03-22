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
            btn_GenerateNextNumber.Focus();

            RandomGenerator.currentSeedValue = RandomGenerator.GenerateSeedFromTimestamp();
            RandomGenerator.rangeMin = RandomGenerator.rangeMinDefault;
            RandomGenerator.rangeMax = RandomGenerator.rangeMaxDefault;

        }

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

            
           RandomGenerator.GenerateNext(RandomGenerator.currentSeedValue, 
                                         RandomGenerator.rangeMin,
                                         RandomGenerator.rangeMax);

            tb_passive_CurrentRandseed.Text = RandomGenerator.currentSeedValue.ToString();

            tb_passive_CurrentRandomValue.Text = RandomGenerator.currentRandomValue.ToString();

        }
    }
}
