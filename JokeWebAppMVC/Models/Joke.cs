﻿namespace JokeWebAppMVC.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string JokeQuestion { get; set; }
        public string JokeAnswer { get; set; }

        //Constructor
        public Joke()
        {
            
        }
    }
}
