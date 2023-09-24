Feature: Feature2

A short summary of thttps://reink.se/book/register-qr?QrCode=eebe74a8-56ce-4e10-a8a2-6e4f6ef6c8cdhe feature

@tag1
Scenario: 1 
    Given        Webbläsaren är oinloggad på ta emot sidan 
	When             Ta emot är klickad
	Then                                webläsaren tas till login sidan
Scenario: 2
	Given                                      webläsaren är åter på "ta emot sidan"
	When                       "ta emot" klickas igen 
	Then                                  det ska nu stå "bok registrerad"
Scenario: 3
	Given                        webbläsaren är utloggad 
	When                                                                                                                       QR koden skannas och webläsaren tas till https://reink.se/book/register-qr?QrCode=eebe74a8-56ce-4e10-a8a2-6e4f6ef6c8cd 
	Then                          det ska stå "jag är klar"                                                  
Scenario: 4
	Given                                       webläsaren står på "jag är klar" sidan                                                       
	When                              klicka på nästa och logga in
	Then                              "jag är klar" sidan ska visas
Scenario: 5
	Given                                       webläsaren står på "jag är klar" sidan
	When              Nästa klickas
	Then                      Betalasidan ska visas
Scenario: 6
	Given                                webläsaren är på "betala" sidan
	When                     sätt prist till 1 kr
	Then                           Betalningen ska vara klar
Scenario: 7
	Given [context]
	When [action]
	Then [outcome]
Scenario: 8
	Given [context]
	When [action]
	Then [outcome]
Scenario: 9
	Given [context]
	When [action]
	Then [outcome]
Scenario: 10
	Given [context]
	When [action]
	Then [outcome]
Scenario: 11
	Given [context]
	When [action]
	Then [outcome]