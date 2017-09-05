using System;
using System.Collections.Generic;

namespace marbles.Models
{
    public class MarblesModel
    {
        public string Color {get; set;}

        public MarblesModel()
        {

        }

        public List<string> colors = new List<string>(){"red","orange","yellow","green","blue","indigo","violet","black","white","silver","aqua"};
    }
}