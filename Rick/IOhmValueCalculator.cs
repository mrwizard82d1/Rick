 namespace Rick
 {
     public interface IOhmValueCalculator

     {
         /// <summary>
         /// Calculates the Ohm value of a resistor based on the band colors.
         /// </summary>
         /// <param name="bandAColor">The color of the first figure of component value band.</param>
         /// <param name="bandBColor">The color of the second significant figure band.</param>
         /// <param name="bandCColor">The color of the decimal multiplier band.</param>
         /// <param name="bandDColor">The color of the tolerance value band.</param>
         /// <remarks>
         /// <para>
         /// This interface plays the role of Facade in the Facade design pattern. It simplifies the domain interface so
         /// that the web application only needs call a single method in order to calculate the resistance of a resistor.
         /// </para>
         /// <para>
         /// Although I could implement a more domain-oriented interface, a single interface provides the needs of 
         /// the web application without the web application needing to understand a complex domain model.
         /// </para>
         /// </remarks>
         int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor);
     }
 }
