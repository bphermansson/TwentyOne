using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static TwentyOne.ValuesClass;

namespace TwentyOne
{
    internal class Card
    {
		private string _color;
        private int _value;
                
		public string getColor
		{
			get { return _color; }
		}
        public int getValue
        {
            get {               
                return _value;
            }
        }
        // Constructor
        public Card()
        {
            Array Colors = Enum.GetValues(typeof(Colors));           
            var rand = new Random();
            Colors cardColor = (Colors)Colors.GetValue(rand.Next(Colors.Length));
            int cardVal = rand.Next(2,14);

            _color = cardColor.ToString();
            _value = cardVal;
        }
    }
}
