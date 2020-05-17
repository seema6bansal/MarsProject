Feature: Add Profile Feature
   In order to Add skills
   As a Seller
   I want to be able to add my skills to the skill trade website

@Ignore
Scenario: Add Seller’s Availability on profile page
	Given Seller is on the profile page and click on add icon for Availability
	When Seller select Availability 'Full Time'
	Then Availability should be added on the profile page

@Ignore
Scenario: Add Seller’s Hours on profile page
	Given Seller is on the profile page and click on add icon for Hours
	When Seller select Hours 'Less than 30hours a week'
	Then Hours should be added on the profile page

@Ignore
Scenario: Add Seller’s Earn Target on profile page
	Given Seller is on the profile page and click on add icon for Earn Target
	When Seller select Earn Target 'Less than $500 per month'
	Then Earn Target should be added on the profile page

@Ignore
Scenario: Add Seller’s description on profile page
	Given Seller is on the profile page and click on add icon for Description
	When Seller add the description 'I am Test Analyst' and click on Save button
	Then Description should be added on the profile page


@Ignore
Scenario Outline: Add Seller’s Languages on profile page
	Given Seller is on the profile page and click on Languages tab
	When Seller add a language with '<Language>' and '<Level>' and click on Add button
	Then Language should be added on the profile page
Examples: 
| Language  | Level  |
| English   | Basic  |
| Hindi     | Basic  |
| Japanese  | Basic  |

@Ignore
Scenario Outline: Cancel Seller’s added Languages on profile page
	Given Seller is on the profile page and click on Languages tab
	When Seller add a language with '<Language>' and '<Level>' and click on Cancel button
	Then Language should not be added on the profile page
Examples: 
| Language | Level |
| Bengali  | Basic |
| chinese  | Basic |

@Ignore
Scenario Outline: Update Seller’s Language on profile page
	Given Seller is on the profile page and click on Languages tab
	When Seller select the Language record and click on edit icon
	And Update the record with '<Language>' and '<Level>' and click on Update button
    Then Language should be Updated on the profile page
Examples: 
| Language  | Level  |
| English   | Fluent |
| Hindi     | Fluent |

@Ignore
Scenario Outline: Cancel Seller’s updated Language on profile page
	Given Seller is on the profile page and click on Languages tab
	When Seller select the language record and click on edit icon
	And Update the record with '<Language>' and '<Level>' and click on Cancel button
	Then Language should not be Updated on the profile page
Examples: 
| Language  | Level |
| English   | Basic |
| Hindi     | Basic |

@Ignore
Scenario: Delete Seller’s Language on profile page
	Given Seller is on the profile page and click on Languages tab
	When Select the language record 'English' and click on delete icon
	Then Language should be deleted on the profile page

@Ignore
Scenario Outline: Add Seller’s Skills on profile page
	Given Seller is on the profile page and click on Skills tab
	When Seller add a Skill with '<Skill>' and '<Level>' and click on Add button
	Then Skill should be added on the profile page
Examples: 
| Skill  | Level    |
| Java   | Beginner |
| C#     | Beginner |


@Ignore
Scenario Outline: Cancel Seller’s added Skills on profile page
	Given Seller is on the profile page and click on Skills tab
	When Seller add a Skill with '<Skill>' and '<Level>' and click on Cancel button
	Then Skill should not be added on the profile page
Examples: 
| Skill  | Level    |
| API    | Beginner |
| Docker | Beginner |

@Ignore
Scenario Outline: Update Seller’s Skills on profile page
	Given Seller is on the profile page and click on Skills tab
	When Seller select the skill record and click on edit icon
	And Update the record with '<Skill>' and '<Level>' and click on Update button
	Then Skill should be updated on the profile page
Examples: 
| Skill  | Level        |
| Java   | Intermediate |
| C#     | Intermediate |


@Ignore
Scenario Outline: Cancel Seller’s updated Skills on profile page
	Given Seller is on the profile page and click on Skills tab
	When Seller select the skill record and click on edit icon
	And Update the record with '<Skill>' and '<Level>' and click on Cancel button
	Then Skill should not be updated on the profile page
Examples: 
| Skill  | Level  |
| Java   | Expert |
| C#     | Expert |

@Ignore
Scenario: Delete Seller’s Skills on profile page
	Given Seller is on the profile page and click on Skills tab
	When Seller select the Skill record 'Java' and click on delete icon
	Then Skill should be deleted on the profile page

@mytag
Scenario Outline: Add Seller’s Education on profile page
	Given Seller is on the profile page and click on Education tab
	When Seller add a new education with '<university>', '<country>', '<Title>', '<degree>' and <year> and click on Add button
	Then Education should be added on the profile page
Examples: 
| university  | country     | Title  | degree    | year |
| Wellington  | New Zealand | B.Tech | Bachelors | 2018 |
| Wellington1 | New Zealand | M.Tech | Masters   | 2018 |

@Ignore
Scenario Outline: Cancel Seller’s added Education on profile page
	Given Seller is on the profile page and click on Education tab
	When Seller add a education with '<university>', '<country>', '<Title>', '<degree>' and <year> and click on Cancel button
	Then Education should not be added on the profile page
Examples: 
| university  | country     | Title  | degree    | year |
| Auckland    | New Zealand | B.Tech | Bachelors | 2018 |
| Auckland1   | New Zealand | M.Tech | Masters   | 2018 |

@mytag
Scenario Outline: Update Seller’s Education on profile page
	Given Seller is on the profile page and click on Education tab
	When Seller select the Education record 'B.Tech' and click on edit icon
	And Update the record with '<university>' and '<country>' and click on Update button
    Then Education should be updated on the profile page
Examples: 
| university             | country    |
| Australia University   | Australia  |
| Australia University1  | Australia  | 

@Ignore
Scenario Outline: Cancel Seller’s updated Education on profile page
	Given Seller is on the profile page and click on Education tab
	When Seller select the Education record and click on edit icon
	And Update the record with '<university>' and '<country>' and click on Cancel button
	Then Education should not be updated on the profile page
Examples: 
| university             | country    |
| Australia University   | Australia  |
| Australia University1  | Australia  | 

@mytag
Scenario: Delete Seller’s Education on profile page
	Given Seller is on the profile page and click on Education tab
	When Seller select the Education record 'M.Tech' and click on delete icon
	Then Education should be deleted on the profile page

@Ignore
Scenario Outline: Add Seller’s Certification on profile page
	Given Seller is on the profile page and click on Certification tab 
	When Seller add a Certification with '<Certificate>', '<From>' and '<Year>' and click on Add button 
	Then Certification should be added on the profile page
Examples: 
| Certificate | From     | Year  |
| ISTQB       | India    | 2016  |
| DB2         | Auckland | 2016  |

@Ignore
Scenario Outline: Cancel Seller’s added Certification on profile page
	Given Seller is on the profile page and click on Certification tab
	When Seller add a Certification with '<Certificate>', '<From>' and '<Year>' and click on Cancel button 
	Then Certification should not be added on the profile page
Examples: 
| Certificate | From     | Year  |
| Java        | India    | 2016  |
| AWS         | Auckland | 2016  |

@Ignore
Scenario Outline: Update Seller’s Certification on profile page
	Given Seller is on the profile page and click on Certification tab
	When Seller select the Certificate record and click on edit icon
	And Update the record with '<From>' and '<Year>' and click on Update button
	Then Certification should be Updated on the profile page
Examples: 
| From       | Year  |
| Wellington | 2018  |
| Wellington | 2018  |

@Ignore
Scenario Outline: Cancel Seller’s updated Certification on profile page
	Given Seller is on the profile page and click on Certification tab
	When Seller select the Certificate record and click on edit icon
	And Update the record with '<From>' and '<Year>' and click on Cancel button
	Then Certification should not be updated on the profile page
Examples: 
| From       | Year |
| Wellington | 2019 |
| Wellington | 2019 |

@Ignore
Scenario: Delete Seller’s Certification on profile page
	Given Seller is on the profile page and click on Certification tab
	When Seller select the Certificate record 'Java' and click on delete icon
	Then Certificate should be deleted on the profile page