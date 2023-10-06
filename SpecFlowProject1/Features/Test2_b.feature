Feature: 

Performs a test procedure according to procedure 2

@tag1
Scenario: 1
Given                                                                   a)The QR code is scanned and the browser is taken to ta emot page:
When                      b)Ta emot is clicked:
Then                            c)The browser is logged in: 
Scenario:2
Given                                      a)The browser return to ta emot page:
When                          b)ta emot" clicked again:
Then                                      c)It should now read bok registrerad:
Scenario:3
Given                              a)The browser is logged out: 
When                           b)The QR koden is scanned:
Then                                 c)It must now read jag är klar:
Scenario:4
Given                                              a)The browser is now on the page jag är klar:  
When                         b)click nästa and login:
Then                                         c)The browser is now on the page betala:
Scenario:5
Given                                                 a)The browser goes to the the swish payment page   
When                                b)The test form is filled
Then                                                       c)The test form is read on the swish confirmation page
Scenario:6
Given                                                a)The browser is again on the page jag är klar: 
When                                             b)Click lämna boken på en addres and login:
Then                                                      c)The jag är klar page with adress should be visible:
Scenario:7
Given                                                                                                                              a) The nästaabutton is clicked and the browser is taken to the payment page where the slider is moved and phone number stated
When                                                 b)The test form is filled and avsluta is clicked
Then                                                               c) The hidden test form is read on the swish confirmation page