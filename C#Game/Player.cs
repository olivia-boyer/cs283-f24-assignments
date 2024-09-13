﻿using System;
using System.Drawing;
using System.Windows.Forms;
/* Class for the player character.
 * 
 * This program specifies the appearance and behavior of the player
 * character.
 * 
 * @author: Olivia Boyer
 * @version: September 12, 2024
 */
public class Player
{
	private int _xvalue;
	private int _yvalue;
	private Boolean _up = true;
	private Boolean _jumping = false;
	private int _ducking = 5;
	Image _egg = Image.FromFile("image0.png");
	Image _slide = Image.FromFile("egg2.png");
    
    public Player(int x, int y) {
		_xvalue = x;
		_yvalue = y;
	}

	public void Update(float dt)
	{
     if (_jumping)
		{
			Jump();
		}
	}

	public void Draw(Graphics g)
	{
		if (_ducking < 5 && _yvalue == 280)
		{
			g.DrawImage(_slide, CreateCharacter());
            _ducking += 1;
        } else
		{
			g.DrawImage(_egg, CreateCharacter());
		}
		
	}

	public Rectangle CreateCharacter()
	{
		if (_ducking < 5 && _yvalue == 280)
		{
			Rectangle slider = new Rectangle(_xvalue, _yvalue + 30, 50, 40);
            return slider;
        }
		else
		{
			Rectangle rect = new Rectangle(_xvalue, _yvalue, 50, 70);
			return rect;
		}
		}

	public void Jump()
	{
		if (_yvalue == 190) 
		{
			_up = false;
			
			_yvalue += 10;
		} else if (_up)
		{
			if (_yvalue == 280)
			{
				
				_yvalue -= 50;
			} else if (_yvalue == 230)
			{
				_yvalue -= 30;
			} else if (_yvalue == 200) 
			{
				_yvalue -= 10;
			}
			} else if (_yvalue == 200)
		    {
			_yvalue += 30;
			} else if (_yvalue == 230)
		{
			_yvalue += 50;
		} else
		{
			_up = true;
			_jumping = false;
		}
	}

	public void StartJump()
	{
		_jumping = true;
	}


	public void Duck()
	{
		_ducking = 0;
	}

	
	
}
