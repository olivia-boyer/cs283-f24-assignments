using System;
using System.Drawing;
using System.Security.Principal;
using System.Windows.Forms;
/* Class defining the obstacle boxes.
 * 
 * This class defines the appearance and behavior
 * of the game's obstacles.
 * 
 * @author: Olivia Boyer
 * @Version: September 9, 2024
 */
public class Obstacles
{
	private int _xpos;
	private int _ypos;
    private Random _rnd;
	private int _speed;
	Image _box = Image.FromFile("image1.png");
	
    public Obstacles()
	{
        _rnd = new Random();
        _speed = _rnd.Next(40, 80); //speed varies randomly
		GenerateHeight();
		_xpos = Window.width;
	}

	//called once per frame, controls motion
	public void Update(float dt)
	{
		if (_xpos > -50)
		{
				_xpos -= _speed;
			}
			else
			{
			StartOver();
			}
	}
		

	//called once per frame, draws obstacle in updated position
	public void Draw(Graphics g)
	{
		Pen _pen = new Pen(Color.Black, 3);
		g.DrawImage(_box,Area());
	}

	/*determines whether obstacle is to be jumped or ducked under
	using random numbers
	*/
	
	private void GenerateHeight()
	{
    _ypos = 60 * _rnd.Next(4, 6);
    }

	//returns rectangle representing the obstacle
	//for use in determining collision
	public Rectangle Area()
	{
		Rectangle rect = new Rectangle(_xpos, _ypos, 50, 50);
		return rect;
	}

	//gives slight variation in how quickly obstacle comes on screen
	private int StartDistance()
	{
		return Window.width+ _rnd.Next(-20,20);
	}
	
	//resets obstacle position
	public void StartOver()
	{
		_xpos = Window.width;
		GenerateHeight();
        _speed = _rnd.Next(40, 80);
    }

	
}

