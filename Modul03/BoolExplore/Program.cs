﻿using System;

namespace BoolExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//bool _b = true;
			//bool _test = 5 > 10;

			int[] _i = new int[] { 4, 3, 2 };

			int _ui = Convert.ToInt32 ( Console.ReadLine ());

//			bool _check01 = _ui <= _i.Length;
//			bool _check02 = _ui > 0;
//
//			bool _exp01 = _check01 && _check02;		//Логическо И "&&" - ще върне true само като и двете условия са true
//			bool _exp02 = _check01 || _check02;		//Логическо ИЛИ || - ще върне true, ако едно от двете условия е вярно
//			bool _exp03 = ! _check01;				//Отрицание "!"
//
//
//			Console.WriteLine ("Логическо И: " + _exp01.ToString ());
//			Console.WriteLine ("Логическо ИЛИ:" + _exp02.ToString ());
//			Console.WriteLine ("Отрицание на " + _check01.ToString () + ": " + _exp03);
//
			if (_ui > 0	&& _ui <= _i.Length) {
				Console.WriteLine (_i [_ui - 1]);
			} else {
				if (_ui > _i.Length)
				{ 
					Console.WriteLine ("Прекалено голям индекс\n\n\n");
				}
				if (_ui <= 0)
				{ 
					Console.WriteLine ("Прекалено малък индекс\n\n\n");
				}
			}

//			Console.WriteLine (_i [_ui - 1]);
		}
	}
}
