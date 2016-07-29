namespace Rick
{
    /// <summary>
    /// Identifies the valid colors of electron component bands.
    /// </summary>
    /// <remarks>
    /// I could have put this value in the `Resistance` class perhaps even nesting it within that class. I can still 
    /// refactor the solution to do that; however, with the possibility that I will use this enumeration for other
    /// classes (like `Capacitors`), I have chosen to put it in its own file.
    /// </remarks>
    public enum BandColor
    {
        // Because most color corresponds to a specific digit (see https://en.wikipedia.org/wiki/Electronic_color_code),
        // I have chosen to explicitly set the value of those digits even though the compiler will assign the same 
        // values that I did. In addition, I did not assign a digit value to `Gold`, `Silver` and `None` because those
        // colors have no corresponding digit value (even though the compiler will continue assigning sequential values). 
        Black = 0,
        Brown = 1,
        Red = 2,
        Orange = 3,
        Yellow = 4,
        Green = 5,
        Blue = 6,
        Violet = 7,
        Gray = 8,
        White = 9,
        Gold,
        Silver,
        None
    }
}