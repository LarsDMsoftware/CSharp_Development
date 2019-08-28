using System;
using System.Collections.Generic;
using System.Text;

namespace BasicClasses
{
    class Greeting
    {
        //We add private field in the case we need custom set and get conditions as seen below
        private long rekeningsNummer;

        public long RekeningsNummer
        {
            get { return rekeningsNummer; }
            set
            {
                if (value / 100 % 97 == value % 100)
                    rekeningsNummer = value;
            }
        }

        public string Name { get; set; }
        public string Recipient { get; set; }

        public Greeting(string name, string recipient)
        {
            this.Name = name;
            this.Recipient = recipient;
        }

        //Here we overload the Greeting Constructor, so if we create an Object with -> Greeting greeting = new Greeting("Lars");
        //Lana will be used as default for recipient.
        public Greeting(string name) : this(name, "Lana")
        { }

        public override string ToString()
        {
            return string.Format("Hi {0}, I am {1}", Recipient, Name);
        }
    }
}
