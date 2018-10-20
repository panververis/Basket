# Basket
Butter, Milk and Bread Basket!

Simple, Clean and Well Tested customer basket, enabling a customer to buy butter, milk and bread!

Allows a customer to add items in the basket, and returns the final total price with the following promos applied (if they are applicable of course)

==
Available Products and Prices:

Butter 0.80 pounds

Milk   1.15 pounds

Bread  1.00 pounds

==
Available Promos:

Buying two butters, you can get a bread at 50% off

Buying three milks, you can get a fourth one for free.

==
(Testing scenarios included in the project's Unit Test)

TDD was followed ==> First write the Unit Test, THEN write actual code.
(Pretty good exercise actually for developing your TDD skills, it's a good TDD kata)
The above process can be clearly seen in the commits in the Repo.
Only master branch included (no reason for extra branches in such a small project)

(I am now hungry btw, craving cookies with milk and bread slices with butter and honey.)

==
IMPORTANT NOTE:
What I consider to be the most important point within my way of structuring the solution is the following:
I have separated the notions of "Promos", which are responsible for describing the way that discounts will be applied,
from the notion of the "Basket", which is responsible for holding a Collection (List) of Products, as well as a Collection (List) of Promos.
That gives the implementor the flexibility to add and calculate the Final Cost for ANY number of Products, using ANY number of Promos.

Overview of calculations ===> "Basket" + "Products" + "Promos" ===> "Final Cost".
							  "Final Cost" = "Total Cost" - "Promo Deductions"

The Final Price will be calculated in the following way:
The Total Cost (WITHOUT any deductions / discounts) is calculated by the "CostCalculator" class, which is essentially a Sum of its Products' Prices.
THEN each separate "Promo" calculates the amount that will be deducted from the Total Cost.
Finally, the sum of the "Promo Deductions" is subtracted from the Final Cost, and there you have it, 
a complete, clear, dynamic, completely decoupled picture of how the "Final Cost" was calculated.
That also enables for a breakdown of all the calculations to be printed on a receipt, for example!

My way of thinking was influenced by a combination of clear-cut SOLID design, as well as the Strategy Pattern. (where we can consider each Promo a "Strategy" implementation)