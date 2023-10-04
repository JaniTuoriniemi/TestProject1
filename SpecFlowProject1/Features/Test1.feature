Feature: Test1

This is test scenario 1 where the user creates and deletes an account.

@tag1
Scenario: User scans the the QR code and comes to the login page after clicking ta emot
	Given                                                     The user is on registrera din bok and clicks ta emot
	When                                                                           The user is taken to the login page and clicks inget Konto? Registrera dig
	Then                                                The user is taken to the bli medlem page
Scenario: user clicks the registrera konto and states his phone number and verification code 
	Given                                                                                User is on the bli medlem page and states his phone number and clicks verifiera
	When                                                           The user states the verification code and clicks verifiera
	Then                                        The user is take to skapa lösenord page
Scenario: The password is chosen and the user is taken to the ta emot page
	Given                                                                           The user is on the skapalösenord page and states his chosen password twice
	When                  User clicks spara
	Then                                             The user is again on the registrera din bok
Scenario: User goes to min profil and removes his account
	Given                                                             The user is on the registrera din bok and goes to min profil
	When                                     The use clicks on ta bort mitt konto 
	Then                                                          The user in now on the start page without being logged in
