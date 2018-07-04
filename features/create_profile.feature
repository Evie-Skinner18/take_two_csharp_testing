Feature: As a trainee I should be able to create a profile

  Scenario: Using valid details I should be able to log in
    Given I am on the log in page
    And I enter my details
    When I click submit
    Then I should be redirected to the profiles index page

  Scenario: I should be able to create a profile
    Given I am logged in
    When I click new profile
    And add the correct details
    Then it should show me the profile on the index page

  Scenario: I should be able to choose my education stream at the academy
    Given I am logged in
    When I click create a profile
    Then I should be given a drop down list of streams to choose from

  Scenario: I should be able to view an already created profile
    Given I am logged in
    And there is already a profile created
    When I click on the profile
    Then it should show me the profile

  Scenario: I should be able to edit my profile
    Given I am logged in
    When I click edit
    And change the details on my profile form
    Then it should show the updated details on the id page

  Scenario: I should be able to delete a profile
    Given I am logged in
    And there is already a profile created
    When I click to delete the profile
    Then it should remove the profile from that page

  Scenario: I should be able to view my profile straight after completion
    Given I am logged in
    When I create a new profile
    And click save
    Then it should redirect me to that specific profiles page

  Scenario: I should be able to view my profile as a PDF document
    Given I am logged in
    When I click download on an already created profile
    Then it should redirect me to the profile as a PDF document

  Scenario: I should be able to download my profile
    Given I am logged in
    When I click download on an already created profile
    And click the download button on the PDF viewer
    Then it should download the file


  Scenario: I should be able to add a new project
    Given I am logged in
    And I navigate to the project section
    When I click to add a new project
    And fill in the correct details of my project
    Then it should show my project on the index

  Scenario: I should be able to view a project
    Given I am logged in
    And I navigate to the project section
    When I click a project
    Then it should show my project id page

  Scenario: I should be able to delete a project
    Given I am logged in
    And I navigate to the project section
    When I click to delete a project
    Then it should not show my project on the index

  Scenario: I want to add an Employment section
    Given that I am logged in
    And I navigate to the Employment page
    And I fill out the Employment form correctly
    When I click save
    Then I should see the Employment confirmation message

  Scenario: I want to update my existing Employment section
    Given that I am logged in
    And I navigate to the Employment page
    And I edit the information in the form
    When I click save
    Then I should see the Employment update confirmation message

  Scenario: I want to delete an Employment section
    Given that I am logged in
    And I navigate to the Employment page
    When I click Destroy
    Then I should see the Employment destroyed confirmation message

  Scenario: I want to add an Education section
    Given that I am logged in
    And I navigate to the Education page
    And I fill out the Education form correctly
    When I click save
    Then I should see the Education confirmation message

  Scenario: I want to update my existing Education section
    Given that I am logged in
    And I navigate to the Education page
    And I edit the information in the form
    When I click save
    Then I should see the Education update confirmation message

  Scenario: I want to delete an Education section
    Given that I am logged in
    And I navigate to the Education page
    When I click Destroy
    Then I should see the Education destroyed confirmation message

  Scenario: I want to add a Certification section
    Given that I am logged in
    And I navigate to the Certification page
    And I fill out the Certification form correctly
    When I click save
    Then I should see the Certification confirmation message

  Scenario: I want to update my existing Certification section
    Given that I am logged in
    And I navigate to the Certification page
    And I edit the information in the form
    When I click save
    Then I should see the Certification update confirmation message

  Scenario: I want to delete a Certification  section
    Given that I am logged in
    And I navigate to the Certification page
    When I click Destroy
    Then I should see the Certification destroyed confirmation message

  Scenario: I want to add a Custom section
    Given that I am logged in
    And I navigate to the Custom page
    And I fill out the Custom form correctly
    When I click save
    Then I should see the Custom confirmation message

  Scenario: I want to update my existing Custom section
    Given that I am logged in
    And I navigate to the Custom page
    And I edit the information in the form
    When I click save
    Then I should see the Custom update confirmation message

  Scenario: I want to delete a Custom section
    Given that I am logged in
    And I navigate to the Custom page
    When I click Destroy
    Then I should see the Custom destroyed confirmation message
