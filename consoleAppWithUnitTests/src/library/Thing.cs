﻿using static Newtonsoft.Json.JsonConvert;

namespace Library
{
    public class Thing
    {
        // Takes two ints, adds them, stores them in a string
        // (using string interpolation), then deserialises (via
        // Json.Convert) back to an int and returns that value
        public int Get(int left, int right) =>
            DeserializeObject<int>($"{left + right}");
    }
}
