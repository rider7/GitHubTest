using Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperAdventure
{
    public partial class SuperAdventure : Form
    {
        private Player _player;
        public SuperAdventure()
        {
            InitializeComponent();

            Location location = new Location(1, "Home", "This is your house!");
            /*location.ID = 1;
            location.Name = "Home";
            location.Description = "This is your house!";*/

            _player = new Player(10, 10, 20, 0, 1);
           /* _player.CurrentHP = 10;
            _player.MaximumHP = 10;
            _player.Gold = 20;
            _player.ExperiencePoints = 0;
            _player.Level = 1;*/

            lblHP.Text = _player.CurrentHP.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExp.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblHP.Text = "100";
            lblGold.Text = "123";
        }

        private void SuperAdventure_Load(object sender, EventArgs e)
        {

        }
    }
}
