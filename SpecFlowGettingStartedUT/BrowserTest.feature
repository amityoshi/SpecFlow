Feature: Test online calculator
	"http://ata123456789123456789.appspot.com"

@mytag
Scenario Outline: Test add and multiply and substract numbers
	Given User opens <Browser> and enters <Url>
	And User enters <FirstVal> and <SecondVal>
	And selects <Opt> 
	When Click <Calculate> button
	Then result should be <Value>

	Examples:
	| Browser  | Url                                        | FirstVal | SecondVal | Opt   | Value |
	| "Chrome" | "http://ata123456789123456789.appspot.com" | 8        | 8         | "Add" | 16    |
	| "Chrome" | "http://ata123456789123456789.appspot.com" | 8        | 8         | "Mul" | 64    |
	| "Chrome" | "http://ata123456789123456789.appspot.com" | 8        | 8         | "Add" | 15    |