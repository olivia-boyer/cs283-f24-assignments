using System;
using System.Drawing;
using System.Media;
using System.Security.Cryptography;
using System.Windows.Forms;
/*The main program for directing the game.
 * 
 * Implements the game loop and end conditions.
 * 
 * edited from base code.
 */
public class Game
{
    Player _player = new Player(10, 280);
    Obstacles _obstacles = new Obstacles();
    Boolean _gameover;
    private Boolean _credits;
    public void Setup()
    {
        _credits = true;
    }

    public void Update(float dt)
    {
        _player.Update(dt);
        _obstacles.Update(dt);
        if (Collision())
        {
            _gameover = true;
        }
    }

    public void Draw(Graphics g)
    {
        Color background = ColorTranslator.FromHtml("#606060");
        Brush brush = new SolidBrush(background); //sample code reference
        g.FillRectangle(brush, 0, 0, 640, 480);
        if (_credits)
        {
        DrawCredits(g);
        
        }
        if (!_gameover)
            {
                Pen _pen = new Pen(Color.Black, 3);
                g.DrawLine(_pen, 0, 351, 641, 351);
                _player.Draw(g);
                _obstacles.Draw(g);

            } else
            {
                SolidBrush drawBrush = new SolidBrush(Color.DarkRed);
                Font drawFont = new Font("Arial", 16);
                StringFormat format = new StringFormat();  //assignment example code
                format.LineAlignment = StringAlignment.Center;
                format.Alignment = StringAlignment.Center;
                g.DrawString("Game Over \n click to restart", drawFont, drawBrush, 320, 240, format);
            _obstacles.StartOver();

            }
           
        }

    public Boolean Collision()
    {
        if (_player.CreateCharacter().IntersectsWith(_obstacles.Area()))
        {
            return true;
        } else
        {
            return false;
        }
    }


    public void MouseClick(MouseEventArgs mouse)
        {
            if (mouse.Button == MouseButtons.Left)
            {
                System.Console.WriteLine(mouse.Location.X + ", " + mouse.Location.Y);
                if (_gameover)
                {
                    _gameover = false;
                }
            }
        }

        public void DrawCredits(Graphics g)
        {
        SolidBrush brush = new SolidBrush(Color.Black);
        SolidBrush white = new SolidBrush(Color.White);
        Font drawFont = new Font("Arial", 16);
        g.FillRectangle(brush, 10, 380, 200, 100);
        g.DrawString("Olivia Boyer \n 2027 \n Egg Escape", drawFont, white, 20, 400);
    }

        public void KeyDown(KeyEventArgs key)
        {
            if (key.KeyCode == Keys.D || key.KeyCode == Keys.Right)
            {
            }
            else if (key.KeyCode == Keys.S || key.KeyCode == Keys.Down)
            {
                _player.Duck();
            }
            else if (key.KeyCode == Keys.A || key.KeyCode == Keys.Left)
            {
            }
            else if (key.KeyCode == Keys.W || key.KeyCode == Keys.Up)
            {
                _player.StartJump();
            }
            else if (key.KeyCode == Keys.Add) //I could only find the keycode for the number pad one
            {
                _credits = !_credits;
            }
        }
    }

