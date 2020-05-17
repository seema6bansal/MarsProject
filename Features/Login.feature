Feature: Login Feature
In order to Add skills
   As a Seller
   I want to be able to login to the skill trade website


@mytag
Scenario Outline: Successful Login
	Given Seller is at the Trade Skills Website 
	And Navigate to the Login Page
	When Seller enter valid <email_address> and valid <password>
	And Click on the Login button
	Then Seller name should be seen on the profile page
Examples: 
| email_address       | password |
| seema.mvp@gmail.com | mvp@2020 |

@Ignore
Scenario Outline: Unsuccessful Login
	Given Seller is at the Trade Skills Website
	And Navigate to the Login Page
	When Seller enter valid <email_address> and invalid <password>
	And Click on the Login button
	Then Seller should get "Send Verification Email" message on the screen
Examples: 
| email_address       | password |
| seema.mvp@gmail.com | mmm@2020 |

