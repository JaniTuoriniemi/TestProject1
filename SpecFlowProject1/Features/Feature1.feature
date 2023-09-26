Feature: Feature1

Test Scenario2

@tag1
Scenario: This is är test1.It tests the steps 1-4 in Test scenario 2.
	Given                                                       The browser is on the ta emot page being not logged in
	When                                                              Ta emot is clicked and the browser is taken to the login page
	Then                                                                                                             The browser is logged in and taken to either of two pages depending if the book is already registered or not
Scenario: This is är test2.It tests the steps 6-7b-9 in Test scenario 2.
 Given                                   The browser is on the Ta emot page
 When                                                                          jag ska lämna boken på en addres is cklicked and the browser is logged in
 Then                                  The screen jag är klar is visible
 Scenario:This is är test3.It tests the steps 6-10 in Test scenario 2.
 Given                                                          Nästa is clicked and the browser is taken to login screen
 When                         The browser is logged in
 Then                               The betala screen is visible
 Scenario: This is test 4. It tests the payment steps 9-10 in Test scenario 2.
 Given                                     The browser is on the betala screen
 Then                                                The price is set to 1 Kr and Betala is clicked.
 Then                                 A Swish checkout page is visible

