﻿Feature: CalculateResistance
    In order to determine the resistance of a resistor
    As a QA technician
    I want to be calculate the resistance using the color bands

@ignore
Scenario: Determine resistance of a resistor with a tolerance
    Given I have resistor with the bands
        | Resistor | Band A | Band B | Band C | Band D |
        |        1 | Yellow | Violet | Red    | Gold   |
        |        2 | Blue   | Red    | Black  | Silver |
        |        3 | White  | Green  | Violet | Brown  |
        |        4 | White  | Gray   | Green  | Green  |
        |        5 | Brown  | Orange | Red    | Blue   |
    When I enter these colors
        | Resistor | Band A | Band B | Band C | Band D |
        |        1 | Yellow | Violet | Red    | Gold   |
        |        2 | Blue   | Red    | Black  | Silver |
        |        3 | White  | Green  | Violet | Brown  |
        |        4 | White  | Gray   | Green  | Green  |
        |        5 | Brown  | Orange | Red    | Blue   |
    Then I see the resistance
        | Resistor | Nominal Resistance | Tolerance |
        |        1 | 4700 ohms          |        5% |
        |        2 | 62 ohms            |       10% |
        |        3 | 950 Mohms          |        1% |
        |        4 | 9.8 Mohms          |      0.5% |
        |        5 | 1.3 kohms          |     0.25% |

@ignore
Scenario: Determine resistance of a resistor with no tolerance

@ignore
Scenario: Determine resistance of a resistor with three significant figures

@ignore
Scenario: Determine resistance of a resistor with a temperature coefficent

@ignore
Scenario: Determine resistance of a single band resistor

@ignore
Scenario: Determine resistance of a resistor with an illegal band
	Given I have a resister with the bands
		| Band D |
		| Black  |
		| Orange |
		| White  |

