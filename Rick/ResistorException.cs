using System;

namespace Rick
{
    /// <summary>
    /// Exceptions raised calculating the `Resistance` of a `Resistor`.
    /// </summary>
    /// <remarks>
    /// Instead of using system exceptions, I prefer to return more specific classes.
    /// </remarks>
    public class ResistorException : Exception
    {
        public ResistorException(string message) : base(message) { }
    }
}