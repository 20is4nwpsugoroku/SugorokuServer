 using System;
using System.Collections.Generic;
using System.Text;

namespace SugorokuServer
{
	class Field
	{
		Square[] course;
		Player[] players; //4
		int cource_lenghs;
		int turm;

	}


	class Square
	{
		int index;
		EventType eventType;
	}
	

	class Player
	{
		string name;
		int point;
		int playerId;
	}


	enum EventType
	{

	}


	class PlayerAction
	{
		int playerId;
		int moveLength;
	}

}
