using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vanGreunen_Cameron_Task1
{
    public partial class formGame : Form
    {
        GameEngine gameEngine;
        public formGame()
        {
            gameEngine = new GameEngine();
            lblMap.Text = gameEngine.View;
            InitializeComponent();
        }

        private void lblMap_Click(object sender, EventArgs e)
        {

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            gameEngine.MovePlayer(Movement.UP);
            lblMap.Text = gameEngine.View;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            gameEngine.MovePlayer(Movement.DOWN);
            lblMap.Text = gameEngine.View;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            gameEngine.MovePlayer(Movement.LEFT);
            lblMap.Text = gameEngine.View;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            gameEngine.MovePlayer(Movement.RIGHT);
            lblMap.Text = gameEngine.View;
        }
    }
}
