Feature: Login Feature
In order to Add skills
   As a Seller
   I want to be able to login to the skill trade website


@ignore
Scenario Outline: Successful Login
	Given Seller is at the Trade Skills Website 
	And Navigates to the Login Page
	When Seller enters valid <email_address> 
	And Enters valid <password>
	And Clicks on the Login button
	Then Seller name should be seen on the profile page
Examples: 
| email_address       | password |
| seema.mvp@gmail.com | mvp@2020 |

@ignore
Scenario Outline: Unsuccessful Login
	Given Seller is at the Trade Skills Website
	And Navigates to the Login Page
	When Seller enters valid <email_address> 
	And Enters invalid <password>
	And Clicks on the Login button
	Then Seller should get "Send Verification Email" message on the screen
Examples: 
| email_address       | password |
| seema.mvp@gmail.com | mmm@2020 |

