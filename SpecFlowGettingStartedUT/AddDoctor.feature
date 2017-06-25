Feature: Adding Doctor Detai

Scenario:Add Doctor with mandatory Data
Given "user" navigate to "Doctor List Page" 
And enters enters "Doctor Name" 
And enters "Doctor Location" 
And enters "doctor specilization" 
And enters "Doctor contact no"
When clicked on "Save" button 
Then System displays message "Doctor Succesfully added." 
And click on "Ok" button will redirect to "Doctor List Page" 

Scenario: Add doctor without doctor detail
Given "user" navigate to "Doctor List Page" 
And enters "Doctor Location" 
And enters "doctor specilization" 
And enters "Doctor contact no"
When clicked on "Save" button 
Then System displays validation message "Please enter Doctor Name"
And click on "Ok" button puts the focus to "Doctor Name" Field. 

Scenario:Add doctor with invalid doctor contact detail
Given "user" navigate to "Doctor List Page" 
And enters enters "Doctor Name" 
And enters "Doctor Location" 
And enters "doctor specilization" 
And enters invalid "Doctor contact no"
When clicked on "Save" button 
Then System displays validation message "Please enter Valid Contact nuber"
And click on "Ok" button puts the focus to "Doctor Contact number " Field. 