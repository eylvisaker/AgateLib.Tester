﻿Feature: TitleMenuExample
	
	Background:
		Given I have the title menu

Scenario: Start game from title menu
	When I select Start
	Then The game starts

Scenario: Load game from title menu
	When I select Load
	Then The game loads
