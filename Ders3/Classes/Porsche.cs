﻿using AcunMedyaDers1.Classes;
using Ders3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders3.Classes
{
	public class Porsche : Araba, IAracHizi
	{
		public void arachızlıgidiyor(string isim)
		{
			Console.WriteLine("**" + isim + " Çok hızlı gidiyor..");
		}
	}
}
