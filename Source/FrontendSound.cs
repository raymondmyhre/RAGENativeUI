﻿namespace RAGENativeUI
{
    using System;

    public class FrontendSound
    {
        private string set;
        public string Set { get { return set; } set { set = value ?? throw new ArgumentNullException($"The frontend sound {nameof(Set)} can't be null."); } }
        private string name;
        public string Name { get { return name; } set { name = value ?? throw new ArgumentNullException($"The frontend sound {nameof(Name)} can't be null."); } }

        public FrontendSound(string set, string name)
        {
            Set = set;
            Name = name;
        }

        public void Play() => Common.PlaySoundFrontend(Set, Name);
    }
}