Feature: Add Seller's Profile Details
   In order to Add skills
   As a Seller
   I want the feature to add my profile details to the skill trade website
   so that the people seeking for some skills can look into my details

@Ignore
Scenario: Add Seller’s Availability on the profile page
	Given Seller is on the profile page to add the Availability
	When Seller adds the Availability 'Full Time'
	Then Availability should be added on the profile page

@Ignore
Scenario: Add Seller’s Hours on the profile page
	Given Seller is on the profile page to add the Hours
	When Seller adds the Hours 'Less than 30hours a week'
	Then Hours should be added on the profile page

@Ignore
Scenario: Add Seller’s Earn Target on the profile page
	Given Seller is on the profile page to add the Earn Target
	When Seller adds the Earn Target 'Less than $500 per month'
	Then Earn Target should be added on the profile page

@Ignore
Scenario: Add Seller’s Description on the profile page
	Given Seller is on the profile page to add the Description
	When Seller adds the Description 'I am Test Analyst' 
	Then Description should be added on the profile page

@Ignore
Scenario Outline: Add Seller’s Languages on the profile page
	Given Seller clicks on Languages tab on the profile page
	When Seller adds a new Language '<Language>' 
	And Adds a new Level '<Level>' 
	Then Language should be added on the profile page
Examples: 
| Language  | Level  |
| English   | Basic  |
| Hindi     | Basic  |
| Japanese  | Basic  |

@Ignore
Scenario Outline: Cancel Seller’s added Languages on profile page
	Given Seller clicks on Languages tab on the profile page
	When Seller cancels added Language '<Language>'
	And cancels added Level '<Level>' 
	Then Language should not be added on the profile page
Examples: 
| Language | Level |
| Bengali  | Basic |
| chinese  | Basic |

@Ignore
Scenario: Validate Add functionality for Language with null values
	Given Seller clicks on Languages tab on the profile page
	When Seller adds a new language with null values
	Then Seller should get error message

@Ignore
Scenario: Validate Add functionality for duplicate Language
	Given Seller clicks on Languages tab on the profile page
	When Seller adds a new language with duplicate values
	Then Seller should get duplicate error message 

@Ignore
Scenario Outline: Update Seller’s Language on the profile page
	Given Seller clicks on Languages tab on the profile page
	When Seller selects the Language record for update
	And Updates the Language '<Language>' 
	And Updates the Level '<Level>' 
    Then Language should be updated on the profile page
Examples: 
| Language  | Level  |
| English   | Fluent |
| Hindi     | Fluent |

@Ignore
Scenario Outline: Cancel Seller’s updated Language on the profile page
	Given Seller clicks on Languages tab on the profile page
	When Seller selects the language record for update
	And Cancels updated Language '<Language>' 
	And Cancels updated Level '<Level>'
	Then Language should not be updated on the profile page
Examples: 
| Language  | Level |
| English   | Basic |
| Hindi     | Basic |

@Ignore
Scenario: Validate Update functionality for Language with null values
	Given Seller clicks on Languages tab on the profile page
	When Seller updates the language with null values
	Then Seller should get error message

@Ignore
Scenario: Validate Update functionality for duplicate Language 
	Given Seller clicks on Languages tab on the profile page
	When Seller updates the language with duplicate values
	Then Seller should get duplicate error message

@Ignore
Scenario: Delete Seller’s Language on profile page
	Given Seller clicks on Languages tab on the profile page
	When Seller deletes the language record 'English'  
	Then Language should be deleted on the profile page

@Ignore
Scenario Outline: Add Seller’s Skills on profile page
	Given Seller clicks on Skills tab on the profile page
	When Seller adds a new Skill '<Skill>' 
	And adds a new level '<Level>' 
	Then Skill should be added on the profile page
Examples: 
| Skill  | Level    |
| Java   | Beginner |
| C#     | Beginner |

@Ignore
Scenario Outline: Cancel Seller’s added Skills on profile page
	Given Seller clicks on Skills tab on the profile page
	When Seller cancels added Skill '<Skill>' 
	And Cancels added Level '<Level>' 
	Then Skill should not be added on the profile page
Examples: 
| Skill  | Level    |
| API    | Beginner |
| Docker | Beginner |

@Ignore
Scenario: Validate Add functionality for Skill with null values
	Given Seller clicks on Skills tab on the profile page
	When Seller adds a new skill with null values
	Then Seller should get error message

@Ignore
Scenario: Validate Add functionality for Skill with duplicate values
	Given Seller clicks on Skills tab on the profile page
	When Seller adds a new skill with duplicate values
	Then Seller should get duplicate error message

@Ignore
Scenario Outline: Update Seller’s Skills on profile page
	Given Seller clicks on Skills tab on the profile page
	When Seller selects the skill record for update
	And Updates the Skill '<Skill>' 
	And Updates the Level '<Level>' 
	Then Skill should be updated on the profile page
Examples: 
| Skill  | Level        |
| Java   | Intermediate |
| C#     | Intermediate |

@Ignore
Scenario Outline: Cancel Seller’s updated Skills on profile page
	Given Seller clicks on Skills tab on the profile page
	When Seller select the skill record for update
	And Cancels updated Skill '<Skill>' 
    And Cancels updated Level '<Level>' 
	Then Skill should not be updated on the profile page
Examples: 
| Skill  | Level  |
| Java   | Expert |
| C#     | Expert |

@Ignore
Scenario: Validate Update functionality for Skill with null values
	Given Seller clicks on Skills tab on the profile page
	When Seller updates the skill with null values
	Then Seller should get error message

@Ignore
Scenario: Validate Update functionality for Skill with duplicate values
	Given Seller clicks on Skills tab on the profile page
	When Seller updates the skill with duplicate values
	Then Seller should get duplicate error message

@Ignore
Scenario: Delete Seller’s Skills on profile page
	Given Seller clicks on Skills tab on the profile page
	When Seller deletes the Skill record 'Java' 
	Then Skill should be deleted on the profile page

@mytag
Scenario: Add Seller’s Education on profile page
	Given Seller clicks on Education tab on the profile page
	When Seller adds a new education with the following data:
	| University  | Country     | Title  | Degree    | Year |
    | Wellington  | New Zealand | B.Tech | Bachelors | 2018 |
    | Wellington1 | New Zealand | M.Tech | Masters   | 2018 |
    Then Education should be added on the profile page

@Ignore
Scenario: Cancel Seller’s added Education on profile page
	Given Seller clicks on Education tab on the profile page
	When Seller cancels added education with the following data:
	| University  | Country     | Title  | Degree    | Year |
    | Auckland    | New Zealand | B.Tech | Bachelors | 2018 |
    | Auckland1   | New Zealand | M.Tech | Masters   | 2018 |
	Then Education should not be added on the profile page

@Ignore
Scenario: Validate Add functionality for Education with null values
	Given Seller clicks on Education tab on the profile page
	When Seller adds a new education with null values
	Then Seller should get error message

@Ignore
Scenario: Validate Add functionality for Education with duplicate values
	Given Seller clicks on Education tab on the profile page
	When Seller adds a new education with duplicate values
	Then Seller should get duplicate error message

@mytag
Scenario Outline: Update Seller’s Education on the profile page
	Given Seller clicks on Education tab on the profile page
	When Seller selects the Education record 'B.Tech' for update
	And Updates University '<university>'
	And Updates Country '<country>' 
    Then Education should be updated on the profile page
Examples: 
| university             | country    |
| Australia University   | Australia  |
| Australia University1  | Australia  | 

@Ignore
Scenario Outline: Cancel Seller’s updated Education on profile page
	Given Seller clicks on Education tab on the profile page
	When Seller selects the Education record for update
	And Cancels updated University '<university>' 
	And Cancels updated Country '<country>' 
	Then Education should not be updated on the profile page
Examples: 
| university             | country    |
| Australia University   | Australia  |
| Australia University1  | Australia  | 

@Ignore
Scenario: Validate Update functionality for Education with null values
	Given Seller clicks on Education tab on the profile page
	When Seller updates the education with null values
	Then Seller should get error message

@Ignore
Scenario: Validate Update functionality for Education with duplicate values
	Given Seller clicks on Education tab on the profile page
	When Seller updates the education with duplicate values
	Then Seller should get duplicate error message

@mytag
Scenario: Delete Seller’s Education on profile page
	Given Seller clicks on Education tab on the profile page
	When Seller deletes the Education record 'M.Tech' 
	Then Education should be deleted on the profile page

@Ignore
Scenario: Add Seller’s Certification on profile page
	Given Seller clicks on Certification tab on the profile page
	When Seller adds a new Certification with the following data:
	| Certificate | From     | Year  |
    | ISTQB       | India    | 2016  |
    | DB2         | Auckland | 2016  |
	Then Certification should be added on the profile page

@Ignore
Scenario: Cancel Seller’s added Certification on profile page
	Given Seller clicks on Certification tab on the profile page
	When Seller cancels added Certification with the following data:
	| Certificate | From     | Year  |
    | Java        | India    | 2016  |
    | AWS         | Auckland | 2016  |
	Then Certification should not be added on the profile page

@Ignore
Scenario: Validate Add functionality for Certification with null values
	Given Seller clicks on Certification tab on the profile page
	When Seller adds a new certification with null values
	Then Seller should get error message

@Ignore
Scenario: Validate Add functionality for Certification with duplicate values
	Given Seller clicks on Certification tab on the profile page
	When Seller adds a new certification with duplicate values
	Then Seller should get duplicate error message

@Ignore
Scenario Outline: Update Seller’s Certification on profile page
	Given Seller clicks on Certification tab on the profile page
	When Seller selects the Certificate record for update
	And Updates From  '<From>' 
	And Updates Year '<Year>' 
	Then Certification should be Updated on the profile page
Examples: 
| From       | Year  |
| Wellington | 2018  |
| Wellington | 2018  |

@Ignore
Scenario Outline: Cancel Seller’s updated Certification on profile page
	Given Seller clicks on Certification tab on the profile page
	When Seller selects the Certificate record for update
	And Cancels updated From '<From>' 
	And Cancels updated Year '<Year>' 
	Then Certification should not be updated on the profile page
Examples: 
| From       | Year |
| Wellington | 2019 |
| Wellington | 2019 |

@Ignore
Scenario: Validate Update functionality for Certification with null values
	Given Seller clicks on Certification tab on the profile page
	When Seller updates the certification with null values
	Then Seller should get error message

@Ignore
Scenario: Validate Update functionality for Certification with duplicate values
	Given Seller clicks on Certification tab on the profile page
	When Seller updates the certification with duplicate values
	Then Seller should get duplicate error message

@Ignore
Scenario: Delete Seller’s Certification on profile page
	Given Seller clicks on Certification tab on the profile page
	When Seller deletes the Certificate record 'Java' 
	Then Certificate should be deleted on the profile page

