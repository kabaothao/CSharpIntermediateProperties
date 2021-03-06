using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateProperties
{
    public class Person
    {

        //public string Name { get; set; }
        //public string Username { get; set; }

        //type prop and click on tab twice


        /*So always declare all your auto implemented properties on the top of a vertical separator and then put

          the calculated properties on the bottom.
        */




        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        
        public DateTime Birthdate { get; private set; } //We have two properties here. One is and how to implement a property which doesn't have a backing field.
                                                        //This property has a private set accessor which means it's really only you cannot change it. And we sit back in the constructor here.
                                                        //You also have another property which doesn't have a set method either.
        
        public int Age
        {
            get 
                {   
                    var timeSpan = DateTime.Today - Birthdate; 
                    var years = timeSpan.Days / 365;
                    return years;
                }
        }
    }
}

