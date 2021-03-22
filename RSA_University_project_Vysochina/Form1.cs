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
            btn_GenerateRandSeed.Focus();

        }


    }
}
