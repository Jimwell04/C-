using System;
using System.Linq;
using System.Collections.Generic;

namespace ClassStructAndDelegate
{
    public struct Fruit 
    {         
        
        public Fruit(string name, string color) {
        	
        	Name = name;
        	Color = color;
        	
        }
        
        public string Name { get; set; }
        public string Color { get; set; }
        
    }
}