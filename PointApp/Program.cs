﻿using System;

using PointLib;

namespace PointApp
{
    class Program
    {
        static void Main(string[] args)
        {	
			Point p= new Point(4,2);
            Console.WriteLine(p.getModule());
        }
    }
}
