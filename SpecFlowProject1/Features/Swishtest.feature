Feature: Swishtest

Tests the swish payment page by filling in the test form

@tag1
Scenario: Swish payment page test
Given                                   The browser is on the payment page
When                        The test form is filled
Then                                                              The test form is read on the swish confirmation page
