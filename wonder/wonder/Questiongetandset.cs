using System;
using System.Collections.Generic;
using System.Text;

namespace wonder
{
    public class Questiongetandset
    {
        public int Number { get; set; }
        public string QName { get; set; }
        //public List<Answer> Answers { get; set; }
        //public string QAnswer { get; set; }

        public override string ToString()
        {
            return QName;
           // return QAnswer;
        }
        
    }
    
    public class Answer
    {
        public string Text { get; set; }
        public int Value { get; set; }
        public bool IsSelected { get; set; }
    }

    
    /*
    internal class Questiongetandset
    {
    }

    */
}
