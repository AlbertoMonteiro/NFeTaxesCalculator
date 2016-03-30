Feature: InvoiceTaxes

Scenario Outline: Include PIS, COFINS AND CSLL when invoice ammount is greater than 5000 reais
    Given a Invoice with a ammount of 5000.01 reais
    And "<Tax>" tax rate is 10%
    When I setup taxes
    Then the "<Tax>" should be added
    Examples: 
    | Tax    |
    | PIS    |
    | COFINS |
    | CSLL   |

Scenario Outline: Do not include PIS, COFINS AND CSLL taxes when invoice ammount is less than or equals to 5000 reais
    Given a Invoice with a ammount of 5000.00 reais
    And "<Tax>" tax rate is 10%
    When I setup taxes	
    Then the "<Tax>" should not be added
    Examples: 
    | Tax    |
    | PIS    |
    | COFINS |
    | CSLL   |

Scenario: Include IR when tax ammount is greater than 10 reais
    Given a Invoice with a ammount of 100.00 reais
    And "IR" tax rate is 11%
    When I setup taxes
    Then the "IR" should be added

Scenario: Do not include IR tax when tax ammount is less than or equals to 10 reais
    Given a Invoice with a ammount of 100.00 reais
    And "IR" tax rate is 10%
    When I setup taxes	
    Then the "IR" should not be added